﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using MikhailKhalizev.Max;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.BinToCSharp.Plugin;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    /// <summary>
    /// Алгоритм декодирует код по частям. Каждую часть декодируется последовательно
    /// до тех пор пока не встретится потенциальный конец функции (ret или jmp). После
    /// чего декодирование части заканчивается и начинается декодирование других частей,
    /// выявленных по операциям ветвления (jcc, jmp, loop, call).
    /// 
    /// Алгоритм устроен так, что без необходимости, ничего лишнего он не декодирует.
    ///
    /// (Возможно описание устарело) 
    /// </summary>
    public class Engine
    {
        public ConfigurationDto Configuration { get; }
        public ArchitectureMode Mode { get; }
        public Address CsBase { get; }
        public Address DsBase { get; }
        public MethodInfos MethodInfos { get; }
        public IMemory Memory { get; }

        public event EventHandler<Instruction> InstructionDecoded;
        
        public UsedSpace<Address> SuppressDecode { get; } = new UsedSpace<Address>();
        public DecodedCode code { get; } = new DecodedCode();



        /// <summary>
        /// Список адресов на которых происходит принудительное завершение декодирования.
        /// Это требуется при декодировании 'странного' кода. Например когда в функции,
        /// вызванной call происходит возврат не на один уровень вверх, а на два. В результате
        /// требуется принудительно остановить декодирование после данного call.
        /// </summary>
        /// <remarks>
        /// Если <see cref="ForceEndFuncs"/> делит инструкцию пополам,
        /// то эта инструкция относится к методу, расположенному с меньшим адресом.
        /// </remarks>
        private SortedSet<Address> force_end_funcs_ { get; } = new SortedSet<Address>();

        public void AddForceEndFuncs(Address address)
        {
            force_end_funcs_.Add(address);
        }


        private MultiValueDictionary<Address, MethodInfoDto> already_decoded_funcs_ { get; } = new MultiValueDictionary<Address, MethodInfoDto>();

        public void AddAlreadyDecodedFunc(MethodInfoDto model)
        {
            foreach (var address in model.Addresses)
                already_decoded_funcs_.Add(address, model);
        }

        public void RemoveAlreadyDecodedFunc(Address address)
        {
            already_decoded_funcs_.Remove(address);
        }

        public bool already_decoded_funcs_check(Address address)
        {
            if (!already_decoded_funcs_.TryGetValue(address, out var models))
                return false;

            foreach (var model in models)
            {
                if (Memory.Equals(address, model.RawBytes))
                    return true;
            }

            return false;
        }

        MethodInfoDto already_decoded_funcs_try_find(Address addr, int size)
        {
            foreach (var pair in already_decoded_funcs_)
            foreach (var functionModel in pair.Value)
            {
                var bytes = functionModel.RawBytes;
                if (bytes.Length == size && Memory.Equals(addr, bytes))
                    return functionModel;
            }

            return null;
        }

        /// <summary>
        /// Набор адресов начиная с которых необходимо произвести декодирование.
        /// </summary>
        public HashSet<Address> AddressesToDecode = new HashSet<Address>();

        /// <summary>
        /// Содержит информацию об определённых методах.
        /// </summary>
        public SortedSet<DetectedMethod> NewDetectedMethods { get; } = new SortedSet<DetectedMethod>(DetectedMethod.BeginComparer);

        public Dictionary<Address, int> Aligment { get; } = new Dictionary<Address, int>(); // <addr of start, aligment>

        // Переходы на известные адреса.
        public SortedSet<JumpsToKnownAddresses> jmp_to_known_addr = new SortedSet<JumpsToKnownAddresses>(JumpsToKnownAddresses.BeginComparer);
        
        private const int LineCmdOffset = 18;
        private const int LineCommentOffset = 60;

        private readonly JmpCallLoopSimple jmp_call_loop_simple; // addr_to_decode from any jmp.
        private readonly Switch switch_;
        private readonly AddCStringToCommentPlugin _addCStringToCommentPlugin;
        private readonly CommentDummyInstructions comment_idle; // comment dummy instruction


        public Engine(ConfigurationDto configuration, IMemory memory, ArchitectureMode mode, Address csBase, Address dsBase, MethodInfos methodInfos = null)
        {
            Configuration = configuration;
            Memory = memory;
            Mode = mode;
            CsBase = csBase;
            DsBase = dsBase;
            MethodInfos = methodInfos ?? MethodInfos.Load(configuration);
            
            if (csBase != 0)
                SuppressDecode.Add(0, csBase);

            _addCStringToCommentPlugin = new AddCStringToCommentPlugin(this);
            comment_idle = new CommentDummyInstructions(this);
            jmp_call_loop_simple = new JmpCallLoopSimple(this);
            switch_ = new Switch(this);
        }

        public void DecodeMethod(Address address)
        {
            if (NewDetectedMethods.Add(new DetectedMethod(address)))
                Decode(address);
        }

        private void Decode(Address address)
        {
            AddressesToDecode.Add(address);
            Process();
        }

        private void Process()
        {
            while (AddressesToDecode.Count != 0)
            {
                var address = AddressesToDecode.First();
                AddressesToDecode.Remove(address);
                Process(address);
            }
        }


        private class AssemblyCode : IAssemblyCode
        {
            public Engine Engine { get; }
            public Disassembler Disassembler { get; set; }

            public AssemblyCode(Engine engine)
            {
                Engine = engine;
            }

            /// <inheritdoc />
            public byte this[int index]
            {
                get
                {
                    // @todo Проверять suppress_decode.
                    try
                    {
                        if (index < Engine.CsBase)
                            throw new InvalidOperationException();

                        if (Engine.Mode == ArchitectureMode.x86_16 && 0xffff < index - Engine.CsBase)
                            throw new NotImplementedException();

                        return Engine.Memory.GetMinSize(index, 1)[0];
                    }
                    catch (Exception)
                    {
                        Disassembler._u.inp_end = 1;
                        Disassembler._u.error = 1;
                        Disassembler._u.errorMessage = "byte expected, eoi received";
                        return 0;
                    }
                }
            }

            /// <inheritdoc />
            public int Length => int.MaxValue;
        }

        private void Process(Address address)
        {
            if (code.Contains(address))
                return; // Код включающий этот адрес уже декодирован.

            if (address < CsBase)
                return;

            var lowerBound = SuppressDecode.LowerBound(address, false);
            var nearestSuppressDecode = lowerBound.IsEmpty ? Address.MaxValue : lowerBound.Begin;
            
            if (nearestSuppressDecode <= address)
                return;


            // Decode.

            Memory.GetMinSize(address, 1); // Попробуем прочитать хоть один байт - вдруг чтение недоступно.

            var ac = new AssemblyCode(this);
            var dis = new Disassembler(ac, Mode, address, true, Vendor.Intel);
            ac.Disassembler = dis;
            dis._u.inp_buf_index = address;


            
            // Функция, начинающаяся с точного совпадения force_end_funcs_ может начать декодироваться.
            var nearestForceEnd = force_end_funcs_.GetViewBetween(address, Address.MaxValue)
                .Where(x => x != address)
                .DefaultIfEmpty(Address.MaxValue)
                .First();


            while (true)
            {
                var eip = dis._u.pc;
                if (nearestForceEnd <= eip || nearestSuppressDecode <= eip)
                    break;

                if (already_decoded_funcs_check(eip))
                    break; // Нашли среди декодированных.


                var rawInstruction = dis.NextInstruction();
                if (rawInstruction == null)
                    throw new InvalidOperationException("Преждевременное завершение функции из-за нехватки кода.");

                var cmd = new Instruction(rawInstruction);

                // Бывают случаи, когда ud_obj незнаком с инструкцией, хотя в документации x86 она есть.
                //        if (cmd.mnemonic == UD_Iinvalid)
                //            throw exo::exception::not_implemented();

                code.Insert(cmd);
                InstructionDecoded?.Invoke(this, cmd);

                if (cmd.IsJmpOrRet)
                    break; // Потенциальный конец функции.
                
                if (code.Contains(cmd.End))
                    break; // Следующая часть кода уже декодирована.
            }
        }

        public void SetCStringDataArea(Address begin, Address end)
        {
            _addCStringToCommentPlugin.StringArea = Interval.From(begin, end);
        }
        
        public void add_aligment_as_instructions()
        {
            foreach (var a in Aligment)
            {
                var iter_area = code.Area.Find(a.Key, false);
                if (iter_area.IsEmpty)
                    throw new InvalidOperationException();

                if (iter_area.Begin < a.Key)
                    continue; // Выравнивание не требуется, т.к. до нас уже что-то есть.

                if (iter_area != code.Area.First())
                {
                    var i = code.Area.GetIntervalBefore(a.Key);
                    var prev_addr = i.End;

                    if (a.Key < prev_addr + a.Value)
                        code.Insert(new Instruction(prev_addr, a.Key, "Выравнивание."));
                }
            }
        }

        public void layout_funcs()
        {
            add_aligment_as_instructions();
            
            while (true)
            {
                var success_count = 0;
                var toRemove = new List<DetectedMethod>();

                foreach (var func in NewDetectedMethods.ToList())
                {
                    var addr_func = func.Begin;

                    // Следует ли вычислять конец этой функции или он уже вычислен.
                    if (func.End != 0)
                    {
                        var next = NewDetectedMethods.GetViewBetween(
                            new DetectedMethod(addr_func + 1),
                            new DetectedMethod(Address.MaxValue)).FirstOrDefault();

                        if (next != null && func.End <= next.Begin)
                        {
                            success_count++;
                            continue;
                        }

                        func.End = 0;
                    }

                    if (!code.Contains(addr_func))
                    {
                        // Вообще не декодировали этот адрес. Видимо он либо alredy_decoded или suppress.
                        toRemove.Add(func);
                        continue;
                    }

                    // --- Вычисляем... ---
                    
                    var first_cmd = code.GetInstruction(addr_func);

                    if (first_cmd == null)
                        throw new InvalidOperationException("Начало функции делит инструкцию пополам.");

                    // --- Посчитаем min_end - адрес конца функции, дальше которого функция точно уже не может продолжаться. ---

                    var nearestForceEnd = force_end_funcs_.GetViewBetween(addr_func, Address.MaxValue)
                        .Where(x => x != addr_func)
                        .DefaultIfEmpty(Address.MaxValue)
                        .First();

                    var min_end = nearestForceEnd;

                    // Учтём, что инструкции в decoded_code могут пересекаться. Найдём 'верную дорожку'.

                    var instr = new List<Instruction>();
                    var last_instr_end = first_cmd.Begin;
                    //var may_be_end_of_func = new List<Address>();

                    for (var cmd = first_cmd; cmd != null; cmd = code.GetNextInstruction(cmd))
                    {
                        if (min_end <= cmd.Begin)
                            break;

                        if (2 * (last_instr_end - first_cmd.Begin) < cmd.Begin - last_instr_end)
                            break; // Не допускаем большие "дыры".

                        // Проверим на принадлежность к new_detected_funcs.

                        if (cmd != first_cmd && NewDetectedMethods.Contains(new DetectedMethod(cmd.Begin)))
                        {
                            // Т.к. эта инструкция является new_detected_funcs, то предыдущая - конец функции.
                            break;
                        }

                        // Проверим на принадлежность к already_decoded_funcs_.

                        if (already_decoded_funcs_check(cmd.Begin))
                        {
                            // Нашли среди декодированных.
                            break;
                        }

                        //if (cmd.IsJmpOrRet)
                        //    may_be_end_of_func.Add(cmd.End);

                        instr.Add(cmd);
                        last_instr_end = cmd.End;
                    }

                    // Убираем конечные закомментированные инструкции.

                    while (instr.Count != 0)
                    {
                        if (instr[instr.Count - 1].CommentThis == false)
                            break;

                        instr.RemoveAt(instr.Count - 1);
                    }

                    min_end = instr[instr.Count - 1].End;

                    // Заполняем label.

                    func.Labels.Clear();

                    foreach (var i in jmp_to_known_addr.GetViewBetween(new JumpsToKnownAddresses(addr_func), new JumpsToKnownAddresses(min_end)))
                    {
                        foreach (var to in i.To)
                        {
                            if (addr_func <= to && to < min_end)
                            {
                                // Ссылка внутрь функции.

                                var index = instr.BinarySearch(new Instruction(to), Instruction.BeginComparer);

                                if (0 <= index)
                                    func.Labels.Add(to);
                                else
                                {
                                    Console.Error.WriteLine($"Предупреждение: Метка '{to}' делит инструкцию пополам.");

                                    // @todo Улучшить.
                                    NewDetectedMethods.Add(new DetectedMethod(to)); // create if not exist.
                                }
                            }
                            else
                            {
                                if (code.Contains(to))
                                    NewDetectedMethods.Add(new DetectedMethod(to)); // create if not exist.
                            }
                        }
                    }

                    func.Instructions = instr;
                    func.End = min_end;
                    func.RawBytes = Memory.ReadAll(func.Begin, func.End - func.Begin);

                    success_count++;
                }

                foreach (var detectedMethod in toRemove)
                    NewDetectedMethods.Remove(detectedMethod);

                if (success_count == NewDetectedMethods.Count)
                    break;
            }
        }

        public void Save()
        {
            var path = Configuration.CodeOutput;

            layout_funcs();

            foreach (var detectedMethod in NewDetectedMethods)
            {
                if (detectedMethod.MethodInfo != null)
                    continue;
                
                var mi = MethodInfos.GetByRawBytes(detectedMethod.RawBytes);
                if (mi == null)
                {
                    mi = new MethodInfoDto();
                    mi.Guid = Guid.NewGuid();
                    mi.Address = detectedMethod.Begin;
                    mi.Mode = Mode;
                    mi.RawBytes = detectedMethod.RawBytes;
                    MethodInfos.Add(mi);
                }
                else if (!mi.Addresses.Contains(detectedMethod.Begin))
                    mi.Addresses.Add(detectedMethod.Begin);

                detectedMethod.MethodInfo = mi;
            }

            MethodInfos.Save();

            foreach (var detectedMethod in NewDetectedMethods)
            {
                var methodBegin = detectedMethod.Begin;
                var methodEnd = detectedMethod.End;

                if (methodBegin == methodEnd)
                    continue; // Skip empty method.


                // Бывает среди _вновь_ декодированных встречаются абсолютно одинаковые функции. Исключаем их.
                var functionModel = already_decoded_funcs_try_find(methodBegin, methodEnd - methodBegin);
                if (functionModel != null)
                {
                    Console.WriteLine($"Декодированная функция '{methodBegin}' эквивалентна уже существующей {{{functionModel.Guid}}} по адресу'{functionModel.Address}'.");
                    continue;
                }


                Console.WriteLine($"Сохранение метода '{methodBegin}' в файл.");
                
                var output = new StringBuilder();
                WriteCSharpMethodToStringBuilder(output, detectedMethod);
                
                var ns = AddressNameConverter.GetNamespace(methodBegin);
                var kd = AddressNameConverter.KnownDefinitions.GetValueOrDefault(methodBegin);

                var filePath = path;

                filePath += $"/z-{methodBegin.ToString(o => o.RemoveHexPrefix().SetTrimZero(false).SetGroupSize(4).SetGroupSeparator("-"))}";

                if (ns != null)
                    filePath += $"-{ns}";

                if (kd != null)
                    filePath += $"-{kd}";

                filePath += ".cs";


                File.WriteAllText(filePath, output.ToString());
            }

            MethodInfos.Save();
        }

        private void WriteCSharpMethodToStringBuilder(StringBuilder output, DetectedMethod detectedMethod)
        {
            var methodAddress = detectedMethod.Begin;
            var addr_func_end = detectedMethod.End;


            var first_cmd = detectedMethod.Instructions.First();

            AddressNameConverter.KnownDefinitions.TryGetValue(methodAddress, out var methodName);
            if (methodName == null)
                methodName = $"Method_{methodAddress.ToString(o => o.RemoveHexPrefix().SetTrimZero(false).SetGroupSize(4))}";
            
            var ns = AddressNameConverter.GetNamespace(methodAddress);
            if (ns != null)
                ns = $"/* {ns} */ ";
            
            output.AppendLine("using MikhailKhalizev.Processor.x86.BinToCSharp;");
            output.AppendLine("");
            output.AppendLine($"namespace {Configuration.Namespace}");
            output.AppendLine("{");
            output.AppendLine($"    public partial class {Configuration.ClassName}");
            output.AppendLine("    {");
            output.AppendLine($"        [MethodInfo(\"{detectedMethod.MethodInfo.Guid}\")]");
            output.AppendLine($"        public void {ns}{methodName}()");
            output.AppendLine("        {");

            // hash compute

            //{
            //    size_t hash = 0;

            //    for (var i = addr_func; i < addr_func_end;)
            //    {
            //        memory_space_const avail_space = mem(i, 1).sub_space(0, addr_func_end - i);
            //        hash_value(hash, avail_space);
            //        i += avail_space.size();
            //    }

            //    output << ", " << hash;
            //}

            //output.Append($", {(int)Mode}, ({{");

            {
                //memory_space_const avail_space = mem(addr_func, 1);

                //for (addr_type i = addr_func; i < addr_func_end - 1; i++)
                //{
                //    if (avail_space.is_empty())
                //        avail_space = mem(i, 1);

                //    output << avail_space.get<uint8_t, addr_type>(0) << ", ";

                //    avail_space = avail_space.remove_prefix(1);
                //}

                //output << avail_space.get<uint8_t, addr_type>(0);
            }

            //output.AppendLine("}))");


            bool skip = false; // Если нашли недостижимый код устанавливаем в true.
            bool last_instr_jmp_or_ret = false;
            var last_instr_end = first_cmd.Begin;

            for (var cmd_index = 0; cmd_index < detectedMethod.Instructions.Count; cmd_index++)//   cmd = first_cmd; cmd != detectedMethod -> instr.end(); cmd++)
            {
                var cmd = detectedMethod.Instructions[cmd_index];
                bool have_label = detectedMethod.Labels.Contains(cmd.Begin);

                var addr_of_line = cmd.Begin;

                if (addr_func_end <= addr_of_line)
                    break;


                output.Append("        ");

                if (last_instr_end != cmd.Begin) // Обнаружен не декодированный код.
                {
                    if (last_instr_jmp_or_ret == false)
                        throw new NotImplementedException(); // Случай когда перед недостижимым кодом нет ret или jmp. Пока достаточно генерировать исключение.

                    var os = new StringBuilder();
                    write_instruction_position_and_spaces(os, last_instr_end, cmd.Begin);
                    output.AppendLine($"//  {os} /* Недостижимый код. */");
                }


                if (have_label)
                {
                    output.AppendLine($"l_{addr_of_line}:");
                    output.Append("        ");
                    skip = false;
                }


                // instruction_to_string может изменить comment_this. Поэтому вызывается раньше.
                var instr = instruction_to_string(detectedMethod, cmd_index);


                if (skip || cmd.CommentThis)
                    output.Append("//"); // Комментируем недостижимый код.

                if (cmd.IsJmpOrRet)
                    skip = true;


                output.AppendLine($"    {instr}");

                last_instr_end = cmd.End;
                last_instr_jmp_or_ret = cmd.IsJmpOrRet;
            }

            if (last_instr_jmp_or_ret == false)
            {
                // Функция не заканчивается на jmp или ret.
                // Возможно её разбивает другая функция в неудобном месте.

                var os = new StringBuilder();
                write_instruction_position_and_spaces(os, addr_func_end, addr_func_end);
                os.Append($"jmpd_func({AddressNameConverter.GetResultName(addr_func_end, false, true)}, 0);");
                write_spaces(os, LineCommentOffset - 1);
                output.AppendLine($"            {os} /* Принудительное завершение функции. */");
            }

            output.AppendLine("        }");
            output.AppendLine("    }");
            output.AppendLine("}");
        }

        private void write_instruction_position_and_spaces(StringBuilder os, Address begin, Address end)
        {
            write_instruction_position(os, begin, end);
            write_spaces(os, LineCmdOffset - 1);
            os.Append(' ');
        }

        private void write_spaces(StringBuilder os, int offset)
        {
            var count = offset - os.Length;
            if (0 < count)
                os.Append(new string(' ', count));
        }

        private void write_instruction_position(StringBuilder os, Address begin, Address end)
        {
            os.Append($"ii({begin}, {end - begin});");
        }

        private string instruction_to_string(DetectedMethod df, int cmd_index)
        {
            var os = new StringBuilder();

            var cmd = df.Instructions[cmd_index];

            write_instruction_position(os, cmd.Begin, cmd.End);
            write_spaces(os, LineCmdOffset - 1);

            var comments_in_current_func = new List<string>();

            if (cmd.write_cmd != null)
            {
                os.Append(" " + cmd.write_cmd(this, df, cmd_index, comments_in_current_func));

                if (cmd.Comments.Count != 0 || comments_in_current_func.Count != 0)
                    write_spaces(os, LineCommentOffset - 1);
            }

            foreach (var s in cmd.Comments)
                os.Append($" /* {s} */");
            
            foreach (var s in comments_in_current_func)
                os.Append($" /* {s} */");

            return os.ToString();
        }
    }
}