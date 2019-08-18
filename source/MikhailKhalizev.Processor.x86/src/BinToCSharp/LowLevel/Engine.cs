using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.BinToCSharp.Plugin;
using MikhailKhalizev.Processor.x86.Configuration;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;
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
    /// </summary>
    public class Engine
    {
        public BinToCSharpDto Configuration { get; }
        public DefinitionCollection DefinitionCollection { get; }
        public ArchitectureMode Mode { get; set; }
        public Address CsBase { get; set; }
        public Address DsBase { get; set; }
        public MethodInfoCollection MethodInfoCollection { get; }
        public IMemory Memory { get; set; }

        public event EventHandler<CSharpInstruction> InstructionDecoded;
        public event EventHandler OnSave;

        public UsedSpace<Address> SuppressDecode { get; } = new UsedSpace<Address>();
        public DecodedCode DecodedCode { get; } = new DecodedCode();

        public bool AddMethodInfoJumpsToDecode { get; set; } = true;
        public int LimitDecodeTotalLength { get; set; }

        /// <summary>
        /// Список адресов на которых происходит принудительное завершение декодирования.
        /// Это требуется при декодировании 'странного' кода. Например когда в функции,
        /// вызванной call происходит возврат не на один уровень вверх, а на два. В результате
        /// требуется принудительно остановить декодирование после данного call.
        /// </summary>
        /// <remarks>
        /// Если <see cref="ForceEndMethod"/> делит инструкцию пополам,
        /// то эта инструкция относится к методу, расположенному с меньшим адресом.
        /// </remarks>
        private MySortedSet<Address> ForceEndMethod { get; } = new MySortedSet<Address>();

        private MultiValueDictionary<Address, MethodInfoDto> AlreadyDecodedMethods { get; } = new MultiValueDictionary<Address, MethodInfoDto>();

        /// <summary>
        /// Набор адресов начиная с которых необходимо произвести декодирование.
        /// </summary>
        private readonly HashSet<Address> _addressesToDecode = new HashSet<Address>();

        /// <summary>
        /// Содержит информацию об определённых методах.
        /// </summary>
        public MySortedSet<DetectedMethod> NewDetectedMethods { get; } = new MySortedSet<DetectedMethod>(DetectedMethod.BeginComparer);

        public Dictionary<Address, int> Alignment { get; } = new Dictionary<Address, int>(); // <addr of start, aligment>

        // Переходы на известные адреса.
        public SortedSet<BrunchInfo> BrunchesInfo = new SortedSet<BrunchInfo>(BrunchInfo.BeginComparer);

        private const int LineCmdOffset = 18;
        private const int LineCommentOffset = 60;

        private readonly SimpleBranchPlugin _simpleBranchPlugin; // addr_to_decode from any jmp.
        private readonly SwitchPlugin _switchPlugin;
        private readonly ReadCStringPlugin _readCStringPlugin;
        private readonly CommentDummyInstructionsPlugin comment_idle; // comment dummy instruction


        public Engine(
            BinToCSharpDto configuration,
            DefinitionCollection definitionCollection,
            MethodInfoCollection methodInfoCollection)
        {
            Configuration = configuration;
            DefinitionCollection = definitionCollection;
            MethodInfoCollection = methodInfoCollection;

            _readCStringPlugin = new ReadCStringPlugin(this);
            comment_idle = new CommentDummyInstructionsPlugin(this);
            _simpleBranchPlugin = new SimpleBranchPlugin(this);
            _switchPlugin = new SwitchPlugin(this);

            LimitDecodeTotalLength = Configuration.LimitDecodeSize;
        }

        public void ClearDecoded()
        {
            Alignment.Clear();
            DecodedCode.Clear();
            BrunchesInfo.Clear();
            _addressesToDecode.Clear();
            NewDetectedMethods.Clear();
        }

        public void AddForceEndMethod(Address fullAddress)
        {
            ForceEndMethod.Add(fullAddress);
        }

        public void AddAlreadyDecodedFunc(MethodInfoDto model)
        {
            foreach (var address in model.Addresses.Take(1))
                AlreadyDecodedMethods.Add(address, model);
        }

        public void RemoveAlreadyDecodedFunc(Address fullAddress)
        {
            AlreadyDecodedMethods.Remove(fullAddress);
        }

        public bool HaveAlreadyDecodedMethodStartedWith(Address fullAddress)
        {
            if (!AlreadyDecodedMethods.TryGetValue(fullAddress, out var models))
                return false;

            foreach (var model in models)
            {
                if (Memory.Equals(fullAddress, model.RawBytes))
                    return true;
            }

            return false;
        }

        private bool AlreadyDecodedContainsMethodInfo(MethodInfoDto methodInfoDto)
        {
            return AlreadyDecodedMethods.GetValues(methodInfoDto.Address, false)?.Contains(methodInfoDto) == true;
        }

        public bool AddToNewDetectedMethods(Address address)
        {
            return NewDetectedMethods.Add(new DetectedMethod(address));
        }


        public void AddToDecode(Address address)
        {
            _addressesToDecode.Add(address);
        }

        public void DecodeMethod(Address start)
        {
            if (AddToNewDetectedMethods(start))
                Decode(start);
        }

        public void DecodeMethod(Address start, Address end)
        {
            DecodeMethod(start);

            var interval = DecodedCode.Area.FindIntervalThatContainsValue(start, false);
            if (!interval.Contains(start))
                throw new InvalidOperationException();

            while (!interval.Contains(end, true))
            {
                Decode(interval.End);

                var newInterval = DecodedCode.Area.FindIntervalThatContainsValue(start, false);
                if (interval.End == newInterval.End)
                    return;

                interval = newInterval;
            }
        }

        public void Decode(Address address)
        {
            AddToDecode(address);
            ProcessDecode();
        }

        public void ProcessDecode()
        {
            while (_addressesToDecode.Count != 0)
            {
                var address = _addressesToDecode.First();
                _addressesToDecode.Remove(address);
                ProcessStep(address);
            }
        }


        private class AssemblyCode : IAssemblyCode
        {
            public Engine Engine { get; }
            public ud Ud { get; }

            public AssemblyCode(Engine engine, ud ud)
            {
                Engine = engine;
                Ud = ud;
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
                        Ud.inp_end = 1;
                        Ud.error = 1;
                        Ud.errorMessage = "byte expected, eoi received";
                        return 0;
                    }
                }
            }

            /// <inheritdoc />
            public int Length => int.MaxValue;
        }

        private void ProcessStep(Address address)
        {
            if (DecodedCode.Contains(address))
                return; // Код включающий этот адрес уже декодирован.

            if (HaveAlreadyDecodedMethodStartedWith(address))
                return; // Нашли среди декодированных.

            if (address < CsBase)
                return;

            if (LimitDecodeTotalLength <= 0)
                return;

            var lowerBound = SuppressDecode.LowerBound(address, false);
            var nearestSuppressDecode = lowerBound.IsEmpty ? Address.MaxValue : lowerBound.Begin;

            if (nearestSuppressDecode <= address)
                return;


            // Decode.

            Memory.GetMinSize(address, 1); // Попробуем прочитать хоть один байт - вдруг чтение недоступно.

            var u = new ud();
            var ac = new AssemblyCode(this, u);
            udis86.ud_init(ref u);
            udis86.ud_set_pc(ref u, address);
            udis86.ud_set_mode(ref u, (byte)Mode);
            udis86.ud_set_vendor(ref u, (int)Vendor.Any);
            udis86.ud_set_syntax(ref u, new syn_intel().ud_translate_intel);
            udis86.ud_set_input_buffer(ref u, ac);

            u.inp_buf_index = (int)address;


            // Функция, начинающаяся с точного совпадения force_end_funcs_ может начать декодироваться.
            var nearestForceEnd = ForceEndMethod.FirstGreaterOrDefault(address);
            if (nearestForceEnd == default)
                nearestForceEnd = Address.MaxValue;


            CSharpInstruction cmd = null;
            while (true)
            {
                var pc = u.pc;
                if (nearestForceEnd <= pc || nearestSuppressDecode <= pc)
                    break;

                // Разрешим методам пересекаться при отсутствии ret в конце метода.
                // Так выполнение кода может быть быстрее (при циклах), т.к. нет постоянных вызовов других методов.
                if (cmd != null && cmd.IsRet && HaveAlreadyDecodedMethodStartedWith(pc))
                    break; // Нашли среди декодированных.

                var length = udis86.ud_disassemble(ref u);
                if (length <= 0 || u.error != 0 || u.mnemonic == ud_mnemonic_code.UD_Iinvalid)
                    break; //throw new InvalidOperationException("Преждевременное завершение функции.");

                LimitDecodeTotalLength -= length;

                cmd = new CSharpInstruction(DefinitionCollection, u);

                DecodedCode.Insert(cmd);
                InstructionDecoded?.Invoke(this, cmd);

                if (cmd.IsJmpOrRet)
                    break; // Потенциальный конец функции.

                if (DecodedCode.Contains(cmd.End))
                    break; // Следующая часть кода уже декодирована.
            }
        }

        public void SetCStringDataArea(Address begin, Address end)
        {
            _readCStringPlugin.StringArea = Interval.From(begin, end);
        }

        // Добавляет инструкции выравнивания чтобы заполнить "дыры".
        public void AddAlignmentAsInstructions()
        {
            foreach (var (address, size) in Alignment)
            {
                var interval = DecodedCode.Area.FindIntervalThatContainsValue(address, false);
                if (interval.IsEmpty)
                    throw new InvalidOperationException();

                if (interval.Begin < address)
                    continue; // Выравнивание не требуется, т.к. до нас уже что-то есть.

                if (interval != DecodedCode.Area.First())
                {
                    var intervalBefore = DecodedCode.Area.GetIntervalBefore(address);
                    var prevAddress = intervalBefore.End;

                    if (address < prevAddress + size)
                        DecodedCode.Insert(new CSharpInstruction(prevAddress, address, "Выравнивание."));
                }
            }
        }

        private void LayoutMethods()
        {
            //NonBlockingConsole.WriteLine("Разбиение кода на методы.");

            if (_addressesToDecode.Count != 0)
                ProcessDecode();

            //AddAlignmentAsInstructions();
            AddToNewDetectedMethods(DecodedCode.Area.First().Begin);

            while (true)
            {
                var successCount = 0;
                var toRemove = new List<DetectedMethod>();

                foreach (var detectedMethod in NewDetectedMethods.ToArray())
                {
                    var methodBegin = detectedMethod.Begin;

                    // Следует ли вычислять конец этой функции или он уже вычислен.
                    if (detectedMethod.End != 0)
                    {
                        var next = NewDetectedMethods.FirstGreaterOrDefault(new DetectedMethod(methodBegin));

                        if (next != null && detectedMethod.End <= next.Begin)
                        {
                            successCount++;
                            continue;
                        }

                        detectedMethod.End = 0;
                    }

                    if (!DecodedCode.Contains(methodBegin))
                    {
                        // Вообще не декодировали этот адрес. Видимо он либо alredy_decoded или suppress.
                        toRemove.Add(detectedMethod);
                        continue;
                    }

                    // --- Вычисляем... ---

                    var firstCmd = DecodedCode.GetInstructionOrNull(methodBegin);

                    if (firstCmd == null)
                        throw new InvalidOperationException("Начало функции делит инструкцию пополам.");

                    // --- Посчитаем min_end - адрес конца функции, дальше которого функция точно уже не может продолжаться. ---

                    var nearestForceEnd = ForceEndMethod.FirstGreaterOrDefault(methodBegin);
                    if (nearestForceEnd == default)
                        nearestForceEnd = Address.MaxValue;

                    var methodEnd = nearestForceEnd;

                    // Учтём, что инструкции в decoded_code могут пересекаться. Найдём 'верную дорожку'.

                    var instructions = new List<CSharpInstruction>();
                    CSharpInstruction lastInstr = null;
                    var lastInstrEnd = firstCmd.Begin;

                    for (var cmd = firstCmd; cmd != null; cmd = DecodedCode.GetNextInstruction(cmd))
                    {
                        if (methodEnd <= cmd.Begin)
                            break;

                        // Не допускаем большие "дыры".
                        if (2 * (lastInstrEnd - firstCmd.Begin) < cmd.Begin - lastInstrEnd)
                            break;

                        // Проверим на принадлежность к NewDetectedMethods.
                        if (cmd != firstCmd && NewDetectedMethods.Contains(new DetectedMethod(cmd.Begin)))
                        {
                            // Т.к. эта инструкция является NewDetectedMethods, то предыдущая - конец функции.
                            break;
                        }

                        // Проверим на принадлежность к AlreadyDecodedMethods.
                        // Разрешим методам пересекаться при отсутствии ret в конце метода.
                        // Так выполнение кода может быть быстрее (при циклах), т.к. нет постоянных вызовов других методов.
                        if ((lastInstr == null || lastInstr.IsRet) && HaveAlreadyDecodedMethodStartedWith(lastInstrEnd))
                        {
                            // Нашли среди декодированных.
                            break;
                        }

                        instructions.Add(cmd);
                        lastInstr = cmd;
                        lastInstrEnd = cmd.End;
                    }

                    // Убираем конечные закомментированные инструкции.
                    while (instructions.Count != 0 && instructions[instructions.Count - 1].CommentThis)
                        instructions.RemoveAt(instructions.Count - 1);

                    if (instructions.Count == 0)
                    {
                        toRemove.Add(detectedMethod);
                        continue;
                    }

                    methodEnd = instructions[instructions.Count - 1].End;

                    // Заполняем label.

                    detectedMethod.Labels.Clear();

                    foreach (var i in BrunchesInfo.GetViewBetween(new BrunchInfo(methodBegin), new BrunchInfo(methodEnd)))
                    {
                        foreach (var to in i.To)
                        {
                            if (methodBegin <= to && to < methodEnd)
                            {
                                // Ссылка внутрь функции.

                                var index = instructions.BinarySearch(new CSharpInstruction(to), CSharpInstruction.BeginComparer);

                                if (0 <= index)
                                    detectedMethod.Labels.Add(to);
                                else
                                {
                                    // TODO Улучшить логику обработки подобных ситуаций.
                                    // Впрочем, не надо - довольно редкий специфический случай.

                                    NonBlockingConsole.WriteLine($"Предупреждение: Метка '{to}' делит инструкцию пополам.");
                                    AddToNewDetectedMethods(to); // create if not exist.
                                }
                            }
                            else
                            {
                                if (DecodedCode.Contains(to))
                                    AddToNewDetectedMethods(to); // create if not exist.
                            }
                        }
                    }

                    detectedMethod.Instructions = instructions;
                    detectedMethod.End = methodEnd;
                    detectedMethod.RawBytes = Memory.ReadAll(detectedMethod.Begin, detectedMethod.End - detectedMethod.Begin);
                    detectedMethod.MethodInfo = MethodInfoCollection.GetByRawBytes(Mode, detectedMethod.RawBytes, detectedMethod.Begin);

                    // TODO Собрать все Jumps воедино и учесть в рамках Process или JmpCallLoopSimple.
                    // Чтобы LayoutMethods ничего не декодировал.
                    if (AddMethodInfoJumpsToDecode && detectedMethod.MethodInfo?.Jumps != null)
                    {
                        var interval = Interval.From(detectedMethod.Begin, detectedMethod.End);

                        foreach (var externalJump in detectedMethod.MethodInfo.Jumps
                            .SelectMany(x => x.Value)
                            .Where(x => !interval.Contains(x.Address)))
                        {
                            DecodeMethod(externalJump.Address);
                        }
                    }

                    successCount++;
                }

                foreach (var detectedMethod in toRemove)
                    NewDetectedMethods.Remove(detectedMethod);

                if (successCount == NewDetectedMethods.Count)
                {
                    // Проверяем код на "дыры" после jmp и jcc. В Dos коде нередко происходит возврат обратно на инструкцию непосредственно за jmp.

                    foreach (var method in NewDetectedMethods.ToArray())
                    {
                        var prev = method.Instructions.First();
                        foreach (var instruction in method.Instructions.Skip(1))
                        {
                            var decodeStart = prev.End;

                            while (decodeStart != 0 && decodeStart < instruction.Begin && DecodedCode.GetInstructionBefore(decodeStart).IsJmpOrJcc)
                            {
                                Decode(decodeStart);
                                if (DecodedCode.GetInstructionOrNull(decodeStart) == null)
                                    break; // Decode fail. Skip this hole.

                                decodeStart = DecodedCode.Area.FindIntervalThatContainsValue(decodeStart, false).End; // Can be 0 if decodeStart in AlreadyDecodedMethod.

                                // Заново пересчитываем метод.
                                method.End = 0;
                                successCount = 0;
                            }

                            prev = instruction;
                        }
                    }

                    if (successCount == NewDetectedMethods.Count)
                        break;
                }
            }
        }

        // return file paths.
        public List<string> Save(bool inParallel = true)
        {
            var path = Configuration.CodeOutput;
            Directory.CreateDirectory(path);

            LayoutMethods(); // Может запускать декодирование новых частей кода.

            OnSave?.Invoke(this, EventArgs.Empty);

            foreach (var detectedMethod in NewDetectedMethods)
            {
                Address expectedMethodInfoCsBase;
                if (detectedMethod.MethodInfo != null)
                {
                    expectedMethodInfoCsBase = CsBase == 0 ? 0 : CsBase - (detectedMethod.Begin - detectedMethod.MethodInfo.Address);
                    if (detectedMethod.MethodInfo.CsBase != expectedMethodInfoCsBase)
                    {
                        detectedMethod.MethodInfo.CsBase = expectedMethodInfoCsBase;
                        MethodInfoCollection.SetDirty();
                    }

                    continue;
                }

                var mi = MethodInfoCollection.GetByRawBytes(Mode, detectedMethod.RawBytes, detectedMethod.Begin);
                if (mi == null)
                {
                    mi = new MethodInfoDto();
                    mi.Guid = Guid.NewGuid();
                    mi.CsBase = CsBase;
                    mi.Address = detectedMethod.Begin;
                    mi.Mode = Mode;
                    mi.RawBytes = detectedMethod.RawBytes;
                    MethodInfoCollection.Add(mi);
                }

                expectedMethodInfoCsBase = CsBase == 0 ? 0 : CsBase - (detectedMethod.Begin - mi.Address);
                if (mi.CsBase != expectedMethodInfoCsBase)
                {
                    mi.CsBase = expectedMethodInfoCsBase;
                    MethodInfoCollection.SetDirty();
                }

                detectedMethod.MethodInfo = mi;
            }

            MethodInfoCollection.Save();

            if (!inParallel || NewDetectedMethods.Count < 4)
            {
                var files = new List<string>();
                var exList = new List<Exception>();

                foreach (var detectedMethod in NewDetectedMethods.OrderBy(x => x.MethodInfo.Guid))
                {
                    try
                    {
                        var filePath = SaveMethod(detectedMethod);
                        if (filePath != null)
                            files.Add(filePath);
                    }
                    catch (Exception ex)
                    {
                        exList.Add(ex);
                        NonBlockingConsole.WriteLine($"Ошибка при сохранении метода '{detectedMethod.MethodInfo.Address}' в файл: {ex.Message.TrimEnd('.')}.");
                    }
                }

                MethodInfoCollection.Save();

                if (exList.Count != 0)
                    throw new AggregateException(exList);

                return files;
            }
            else
            {
                var files = new ConcurrentBag<string>();
                var exList = new ConcurrentBag<Exception>();

                var uniqueDetectedMethodsByAddress = NewDetectedMethods
                    .ToLookup(x => x.MethodInfo)
                    .Select(y => y.OrderBy(x => x.MethodInfo.Addresses.IndexOf(x.Begin)).First())
                    .ToLookup(x => x.MethodInfo.Address);

                Parallel.ForEach(
                    uniqueDetectedMethodsByAddress,
                    detectedMethodsWithSameAddress =>
                    {
                        foreach (var detectedMethod in detectedMethodsWithSameAddress.OrderBy(x => x.MethodInfo.Guid))
                        {
                            try
                            {
                                var filePath = SaveMethod(detectedMethod);
                                if (filePath != null)
                                    files.Add(filePath);
                            }
                            catch (Exception ex)
                            {
                                exList.Add(ex);
                                NonBlockingConsole.WriteLine($"Ошибка при сохранении метода '{detectedMethod.MethodInfo.Address}' в файл: {ex.Message.TrimEnd('.')}.");
                            }
                        }
                    });

                MethodInfoCollection.Save();

                if (exList.Count != 0)
                    throw new AggregateException(exList);

                return files.ToList();
            }
        }

        private string SaveMethod(DetectedMethod detectedMethod)
        {
            var methodBegin = detectedMethod.MethodInfo.Address;
            var methodEnd = methodBegin + detectedMethod.End - detectedMethod.Begin;

            // Skip empty method.
            if (methodBegin == methodEnd)
                return null;


            // Бывает среди _вновь_ декодированных встречаются абсолютно одинаковые функции. Исключаем эти дубликаты.
            if (AlreadyDecodedContainsMethodInfo(detectedMethod.MethodInfo))
            {
                NonBlockingConsole.WriteLine(
                    $"Метод '{detectedMethod.Begin}' эквивалентен уже существующему {{{detectedMethod.MethodInfo.Guid}}} по адресу '{detectedMethod.MethodInfo.Address}'.");
                return null;
            }


            NonBlockingConsole.WriteLine($"Сохранение метода '{methodBegin}' в файл.");


            var baseFileName = "z-" + methodBegin.ToString(
                o => o
                    .RemoveHexPrefix()
                    .SetTrimZero(false)
                    .SetGroupSize(4)
                    .SetGroupSeparator("-"));

            var ns = AddressNameConverter.GetNamespace(methodBegin);

            var kd = DefinitionCollection.GetAddressFullName(
                methodBegin,
                new DefinitionCollection.Options { SkipDeclaringType = true, NullIfNoName = true });

            if (ns != null && (kd == null || !kd.StartsWith(ns)))
                baseFileName += $"-{ns}";

            if (kd != null)
                baseFileName += $"-{kd}";


            var filePath = "";
            var num = 1;
            while (true)
            {
                filePath = Path.Combine(Configuration.CodeOutput, baseFileName + (1 < num ? $".{num}" : "") + ".cs");
                if (!File.Exists(filePath))
                    break;
                num++;
            }

            var output = new StringBuilder();
            WriteCSharpMethodToStringBuilder(output, detectedMethod, num);

            File.WriteAllText(filePath, output.ToString());
            return filePath;
        }


        private void WriteCSharpMethodToStringBuilder(StringBuilder output, DetectedMethod detectedMethod, int fileNum)
        {
            var methodBegin = detectedMethod.MethodInfo.Address;
            var methodEnd = methodBegin + detectedMethod.End - detectedMethod.Begin;
            var offset = detectedMethod.MethodInfo.Address - detectedMethod.Begin;


            var first_cmd = detectedMethod.Instructions.First();

            var methodName = DefinitionCollection.GetAddressFullName(methodBegin, new DefinitionCollection.Options { SkipDeclaringType = true, NullIfNoName = true });
            if (methodName == null)
                methodName = $"Method_{methodBegin.ToString(o => o.RemoveHexPrefix().SetTrimZero(false).SetGroupSize(4))}";

            var ns = AddressNameConverter.GetNamespace(methodBegin);
            if (ns != null)
                ns = $"/* {ns} */ ";

            output.AppendLine("using System;");
            output.AppendLine("using MikhailKhalizev.Processor.x86.BinToCSharp;");
            output.AppendLine("");
            output.AppendLine($"namespace {Configuration.Namespace}");
            output.AppendLine("{");
            output.AppendLine($"    public partial class {Configuration.RawProgramClassName}");
            output.AppendLine("    {");
            output.AppendLine($"        [MethodInfo(\"{detectedMethod.MethodInfo.Guid}\")]");
            output.AppendLine($"        public void {ns}{methodName}{(1 < fileNum ? "_v" + fileNum : "")}()");
            output.AppendLine("        {");

            bool skip = false; // Если нашли недостижимый код устанавливаем в true.
            bool last_instr_jmp_or_ret = false;
            var last_instr_end = first_cmd.Begin;

            for (var cmd_index = 0; cmd_index < detectedMethod.Instructions.Count; cmd_index++)//   cmd = first_cmd; cmd != detectedMethod -> instr.end(); cmd++)
            {
                var cmd = detectedMethod.Instructions[cmd_index];
                var haveLabel = detectedMethod.Labels.Contains(cmd.Begin);

                output.Append("        ");

                if (last_instr_end != cmd.Begin) // Обнаружен не декодированный код.
                {
                    var os = new StringBuilder();
                    write_instruction_position_and_spaces(os, last_instr_end, cmd.Begin, offset);

                    output.AppendLine(
                        last_instr_jmp_or_ret
                            ? $"//  {os}Недостижимый (и не декодированный) код."
                            : $"    {os}throw new InvalidOperationException(\"Не декодированный код.\");");
                    output.Append("        ");
                }

                if (haveLabel)
                {
                    output.AppendLine($"l_{cmd.Begin + offset}:");
                    output.Append("        ");
                    skip = false;
                }

                // InstructionToString может изменить CommentThis. Поэтому вызывается раньше.
                string instr;
                try
                {
                    instr = InstructionToString(detectedMethod, cmd_index, offset);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(
                        $"Instuction address: {cmd.Begin}, Method address: {detectedMethod.MethodInfo.Address}, Method Guid: {{{detectedMethod.MethodInfo.Guid}}}", ex);
                }


                if (skip || cmd.CommentThis)
                    output.Append("//"); // Комментируем недостижимый код.

                if (cmd.IsRet || (cmd.IsJmp && cmd.IsLocalBranch /* is 'goto'. */))
                    skip = true;


                output.AppendLine($"    {instr}");

                last_instr_end = cmd.End;
                last_instr_jmp_or_ret = cmd.IsJmpOrRet;
            }

            output.AppendLine("        }");
            output.AppendLine("    }");
            output.AppendLine("}");
        }

        private void write_instruction_position_and_spaces(StringBuilder os, Address begin, Address end, int offset)
        {
            WriteInstructionPosition(os, begin, end, offset);
            write_spaces(os, LineCmdOffset - 1);
            os.Append(' ');
        }

        private void write_spaces(StringBuilder os, int offset)
        {
            var count = offset - os.Length;
            if (0 < count)
                os.Append(new string(' ', count));
        }

        private void WriteInstructionPosition(StringBuilder os, Address begin, Address end, int offset)
        {
            os.Append($"ii({begin + offset}, {end - begin});");
        }

        private string InstructionToString(DetectedMethod df, int cmdIndex, int offset)
        {
            var os = new StringBuilder();

            var cmd = df.Instructions[cmdIndex];

            WriteInstructionPosition(os, cmd.Begin, cmd.End, offset);
            write_spaces(os, LineCmdOffset - 1);

            var comments_in_current_func = new List<string>();

            if (cmd.WriteCmd != null)
            {
                os.Append(" " + cmd.WriteCmd(this, df, cmdIndex, comments_in_current_func, offset));

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