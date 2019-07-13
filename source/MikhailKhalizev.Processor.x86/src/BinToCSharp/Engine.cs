using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MikhailKhalizev.Max;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.BinToCSharp.Plugin;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using SharpDisasm.Udis86;

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
        public ArchitectureMode Mode { get; }
        public Address CsBase { get; }
        public Address DsBase { get; }
        public IMemory Memory { get; }

        public event EventHandler<Instruction> InstructionDecoded;
        
        public UsedSpace<Address> SuppressDecode { get; } = new UsedSpace<Address>();



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


        private MultiValueDictionary<Address, FunctionModel> already_decoded_funcs_ { get; } = new MultiValueDictionary<Address, FunctionModel>();

        public void AddAlreadyDecodedFunc(FunctionModel model)
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
                if (Memory.mem_pg_equals(address, model.GetRawBytes()))
                    return true;
            }

            return false;
        }

        FunctionModel already_decoded_funcs_try_find(Address addr, int size)
        {
            foreach (var pair in already_decoded_funcs_)
            foreach (var functionModel in pair.Value)
            {
                var bytes = functionModel.GetRawBytes();
                if (bytes.Length == size && Memory.mem_pg_equals(addr, bytes))
                    return functionModel;
            }

            return null;
        }

        /// <summary>
        /// Набор адресов начиная с которых необходимо произвести декодирование.
        /// </summary>
        private HashSet<Address> AddressesToDecode = new HashSet<Address>();

        /// <summary>
        /// Содержит информацию об определённых методах.
        /// </summary>
        private SortedSet<DetectedMethod> NewDetectedMethods = new SortedSet<DetectedMethod>(DetectedMethod.BeginComparer);

        private Dictionary<Address, int> Aligment = new Dictionary<Address, int>(); // <addr of start, aligment>

        private SortedSet<JumpsToKnownAddresses> jmp_to_known_addr = new SortedSet<JumpsToKnownAddresses>(JumpsToKnownAddresses.BeginComparer);
        private DecodedCode code = new DecodedCode();

        private const int LineCmdOffset = 22;
        private const int LineCommentOffset = 60;

        // TODO plugin::jmp_call_loop_simple plugin_jmp_call_loop_simple; - addr_to_decode from any jmp.
        // TODO plugin::switch_ plugin_switch; - decode switch.
        private readonly AddCStringToCommentPlugin _addCStringToCommentPlugin;
        // TODO plugin::comment_idle plugin_comment_idle; - comment dummy instruction


        public Engine(ArchitectureMode mode, Address csBase, Address dsBase, IMemory memory)
        {
            Mode = mode;
            CsBase = csBase;
            DsBase = dsBase;
            Memory = memory;

            if (csBase != 0)
                SuppressDecode.Add(0, csBase);

            _addCStringToCommentPlugin = new AddCStringToCommentPlugin(this);
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

                if (cmd._is_jmp_or_ret)
                    break; // Потенциальный конец функции.
                
                if (code.Contains(cmd.End))
                    break; // Следующая часть кода уже декодирована.
            }
        }

        public void SetCStringDataArea(Address begin, Address end)
        {
            _addCStringToCommentPlugin.StringDataAreaBegin = begin;
            _addCStringToCommentPlugin.StringDataAreaEnd = end;
        }
        
        public void add_aligment_as_instructions()
        {
            foreach (var a in Aligment)
            {
                var iter_area = code.area.Find(a.Key, false);
                if (iter_area.IsEmpty)
                    throw new InvalidOperationException();

                if (iter_area.Begin < a.Key)
                    continue; // Выравнивание не требуется, т.к. до нас уже что-то есть.

                if (iter_area != code.area.First())
                {
                    var i = code.area.GetIntervalBefore(a.Key);
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

                foreach (var func in NewDetectedMethods)
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
                    
                    var first_cmd = code.cmd_get(addr_func);

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
                    var may_be_end_of_func = new List<Address>();

                    for (var cmd = first_cmd; cmd != null; cmd = code.cmd_get_next_logical(cmd))
                    {
                        if (min_end <= cmd.Begin)
                            break;

                        if (2 * (last_instr_end - first_cmd.Begin) < cmd.Begin - last_instr_end)
                            break; // Не допускаем большие "дыры".

                        // Проверим на принадлежность к new_detected_funcs.

                        if (NewDetectedMethods.Contains(new DetectedMethod(cmd.Begin)))
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

                        if (cmd._is_jmp_or_ret)
                            may_be_end_of_func.Add(cmd.End);

                        instr.Add(cmd);
                        last_instr_end = cmd.End;
                    }

                    // Убираем конечные закомментированные инструкции.

                    while (instr.Count != 0)
                    {
                        if (instr[instr.Count - 1]._commentThis == false)
                            break;

                        instr.RemoveAt(instr.Count - 1);
                    }

                    min_end = instr[instr.Count - 1].End;

                    // Заполняем label.

                    func.Labels.Clear();

                    foreach (var i in jmp_to_known_addr.GetViewBetween(JumpsToKnownAddresses.CreateDummy(addr_func), JumpsToKnownAddresses.CreateDummy(min_end)))
                    {
                        foreach (var to in i.To)
                        {
                            if (addr_func <= to && to < min_end)
                            {
                                // Ссылка внутрь функции.

                                var index = instr.BinarySearch(Instruction.CreateDummyInstruction(to), Instruction.BeginComparer);

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
                    success_count++;
                }

                foreach (var detectedMethod in toRemove)
                    NewDetectedMethods.Remove(detectedMethod);

                if (success_count == NewDetectedMethods.Count)
                    break;
            }
        }

        public void write_cxx_to_dir(string path)
        {
            layout_funcs();

            throw new NotImplementedException();
        }
    }
}