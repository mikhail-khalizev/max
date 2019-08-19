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
    // TODO Разделить класс на несколько - один разбивает код на части. Другой преобразовывает в C#. Третий сохраняет в файл.

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
        public IMethodInfoCollection MethodInfoCollection { get; }
        public ArchitectureMode Mode { get; set; }
        public Address CsBase { get; set; }
        public Address DsBase { get; set; }
        public IMemory Memory { get; set; }

        public event EventHandler<CSharpInstruction> InstructionDecoded;
        public event EventHandler OnSave;

        public UsedSpace<Address> SuppressDecode { get; } = new UsedSpace<Address>();
        public DecodedCode DecodedCode { get; } = new DecodedCode();

        public int LimitDecodeTotalLength { get; set; }

        /// <summary>
        /// Список адресов на которых происходит принудительное завершение декодирования.
        /// Это требуется при декодировании 'странного' кода. Например когда в методе,
        /// вызванным call происходит возврат не на один уровень вверх, а на два. В результате
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
        /// Содержит информацию о найденных методах.
        /// </summary>
        public MySortedSet<DetectedMethod> NewDetectedMethods { get; } = new MySortedSet<DetectedMethod>(DetectedMethod.BeginComparer);

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
            IMethodInfoCollection methodInfoCollection)
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

        public void SetCStringDataArea(Address begin, Address end)
        {
            _readCStringPlugin.StringArea = Interval.From(begin, end);
        }

        public void AddForceEndMethod(Address fullAddress)
        {
            ForceEndMethod.Add(fullAddress);
        }

        public void AddAlreadyDecodedFunc(MethodInfoDto model)
        {
            AlreadyDecodedMethods.Add(model.Address, model);
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
                if (SuppressDecode.Contains(model.Address + model.RawBytes.Length, false))
                    continue;

                if (Memory.Equals(fullAddress, model.RawBytes))
                    return true;
            }

            return false;
        }

        private bool AlreadyDecodedContainsMethodInfo(MethodInfoDto methodInfoDto)
        {
            return AlreadyDecodedMethods.GetValues(methodInfoDto.Address, false)?.Contains(methodInfoDto) == true;
        }


        public bool AddNewDetectedMethod(Address address)
        {
            if (SuppressDecode.Contains(address, false))
                return false;

            if (HaveAlreadyDecodedMethodStartedWith(address))
                return false;

            return NewDetectedMethods.Add(new DetectedMethod(address));
        }

        public void DecodeMethod(Address start)
        {
            Decode(start);
            AddNewDetectedMethod(start);
        }

        public void Decode(Address address)
        {
            AddToDecode(address);
            ProcessDecode();
        }

        public void AddToDecode(Address address)
        {
            _addressesToDecode.Add(address);
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


        private void ProcessStep(Address address)
        {
            if (address < CsBase)
                return;

            if (LimitDecodeTotalLength <= 0)
                return;

            if (DecodedCode.ContainsInstruction(address))
                return; // Код включающий этот адрес уже декодирован.

            var lowerBound = SuppressDecode.LowerBound(address, false);
            var nearestSuppressDecode = lowerBound.IsEmpty ? Address.MaxValue : lowerBound.Begin;

            if (nearestSuppressDecode <= address)
                return;

            Memory.GetMinSize(address, 1); // Попробуем прочитать хоть один байт - вдруг чтение недоступно.

            // Функция, начинающаяся с точного совпадения ForceEndMethod может начать декодироваться.
            var nearestForceEnd = ForceEndMethod.FirstGreaterOrDefault(address);
            if (nearestForceEnd == default)
                nearestForceEnd = Address.MaxValue;

            foreach (var cmd in CSharpInstruction.DecodeCode(Memory, address, Mode, DefinitionCollection))
            {
                LimitDecodeTotalLength -= (cmd.End - cmd.Begin);

                DecodedCode.Insert(cmd);
                InstructionDecoded?.Invoke(this, cmd);

                if (cmd.IsJmpOrRet)
                    break; // Потенциальный конец функции.

                if (DecodedCode.ContainsInstruction(cmd.End))
                    break; // Следующая часть кода уже декодирована.

                if (nearestForceEnd <= cmd.End || nearestSuppressDecode <= cmd.End)
                    break;
            }
        }


        // Может запускать декодирование новых частей кода.
        public void DetectMethods()
        {
            if (_addressesToDecode.Count != 0)
                ProcessDecode();

            // --- Разбиение кода на методы. ---

            AddNewDetectedMethod(DecodedCode.Area.First().Begin);

            while (true)
            {
                var successCount = 0;
                var toRemove = new List<DetectedMethod>();

                foreach (var method in NewDetectedMethods.ToArray())
                {
                    var methodBegin = method.Begin;
                    var methodEnd = Address.MaxValue;

                    // Проверим, делит ли другой метод текущий.

                    if (method.End != 0)
                    {
                        var otherMethod = NewDetectedMethods.FirstGreaterOrDefault(new DetectedMethod(methodBegin));

                        if (otherMethod == null || method.End <= otherMethod.Begin)
                        {
                            successCount++;
                            continue;
                        }

                        method.End = 0;
                        methodEnd = Math.Min(methodEnd, otherMethod.Begin);
                    }

                    // Проверим наличие первой инструкции метода.

                    var firstCmd = DecodedCode.GetInstructionOrNull(methodBegin);

                    if (firstCmd == null)
                    {
                        // Вообще не декодировали этот адрес. Видимо он либо AlreadyDecodedMethods или SuppressDecode.
                        toRemove.Add(method);
                        continue;
                    }

                    // Посчитаем methodEnd - адрес конца метода, дальше которого функция точно уже не может продолжаться.

                    methodEnd = Math.Min(methodEnd, ForceEndMethod.FirstGreaterOrDefault(methodBegin, Address.MaxValue));
                    methodEnd = Math.Min(methodEnd, NewDetectedMethods.FirstGreaterOrDefault(method)?.Begin ?? Address.MaxValue);

                    // Учтём, что инструкции в DecodedCode могут пересекаться. Найдём "верную дорожку".

                    var instructions = new List<CSharpInstruction>();

                    CSharpInstruction lastInstr = null;
                    var lastInstrEnd = firstCmd.Begin;

                    for (var cmd = firstCmd; cmd != null; cmd = DecodedCode.GetNextInstruction(cmd))
                    {
                        if (methodEnd <= cmd.Begin)
                            break;

                        // Не допускаем большие "дыры".
                        var holeSize = cmd.Begin - lastInstrEnd;
                        if (2 * (int)Mode < holeSize && 2 * (lastInstrEnd - firstCmd.Begin) < holeSize)
                            break;

                        // Проверим на принадлежность к AlreadyDecodedMethods.
                        // Разрешим методам пересекаться при отсутствии ret и jmp в конце метода.
                        // Так выполнение кода может быть быстрее (при циклах), т.к. нет постоянных вызовов других методов.
                        if ((lastInstr == null || (lastInstr.End != cmd.Begin) || (lastInstr.End == cmd.Begin && lastInstr.IsJmpOrRet)) &&
                            HaveAlreadyDecodedMethodStartedWith(lastInstrEnd))
                        {
                            // Нашли среди декодированных.
                            break;
                        }

                        if (methodEnd < cmd.End)
                            break;

                        instructions.Add(cmd);
                        lastInstr = cmd;
                        lastInstrEnd = cmd.End;
                    }

                    // Убираем конечные закомментированные инструкции.
                    while (instructions.Count != 0 && instructions[instructions.Count - 1].CommentThis)
                        instructions.RemoveAt(instructions.Count - 1);

                    if (instructions.Count == 0)
                    {
                        toRemove.Add(method);
                        continue;
                    }

                    methodEnd = instructions[instructions.Count - 1].End;

                    // Заполняем label.

                    method.Labels.Clear();

                    foreach (var branchInfo in BrunchesInfo.GetViewBetween(new BrunchInfo(methodBegin), new BrunchInfo(methodEnd)))
                    {
                        var branchInstructionIndex = instructions.BinarySearch(new CSharpInstruction(branchInfo.From), CSharpInstruction.BeginComparer);
                        if (branchInstructionIndex < 0)
                            continue;

                        foreach (var addressTo in branchInfo.To)
                        {
                            if (methodBegin <= addressTo && addressTo < methodEnd)
                            {
                                // Переход внутрь метода.

                                var index = instructions.BinarySearch(new CSharpInstruction(addressTo), CSharpInstruction.BeginComparer);

                                if (0 <= index)
                                    method.Labels.Add(addressTo);
                                else
                                {
                                    // TODO Улучшить логику обработки подобных ситуаций.
                                    // Впрочем, не надо - довольно редкий специфический случай.

                                    NonBlockingConsole.WriteLine($"Предупреждение: Метка '{addressTo}' делит инструкцию пополам.");
                                    if (DecodedCode.ContainsInstruction(addressTo))
                                        AddNewDetectedMethod(addressTo);
                                }
                            }
                            else
                            {
                                if (DecodedCode.ContainsInstruction(addressTo))
                                    AddNewDetectedMethod(addressTo);
                            }
                        }
                    }

                    // Готово.

                    method.Instructions = instructions;
                    method.End = methodEnd;
                    method.RawBytes = Memory.ReadAll(method.Begin, method.End - method.Begin);

                    successCount++;
                }

                foreach (var detectedMethod in toRemove)
                    NewDetectedMethods.Remove(detectedMethod);

                if (successCount == NewDetectedMethods.Count)
                {
                    // Проверяем код на "дыры" после jmp. В Dos коде нередко происходит возврат обратно на инструкцию непосредственно за jmp.

                    foreach (var method in NewDetectedMethods.ToArray())
                    {
                        var prev = method.Instructions.First();
                        foreach (var instruction in method.Instructions.Skip(1))
                        {
                            var decodeStart = prev.End;

                            while (decodeStart != 0 && decodeStart < instruction.Begin && DecodedCode.GetInstructionBefore(decodeStart).IsJmp)
                            {
                                // Перед декодированием, временно, добавляем адрес instruction.Begin в ForceEndMethod для безопасности.
                                // А то вдруг там некорректный код и адрес instruction.Begin находится внутри инструкции и тогда мы можем уйти далеко за наш метод.
                                var fem = ForceEndMethod.Contains(instruction.Begin);
                                if (!fem)
                                    AddForceEndMethod(instruction.Begin);

                                Decode(decodeStart);

                                if (!fem)
                                    ForceEndMethod.Remove(instruction.Begin);

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

            // --- Постобработка. ---

            foreach (var method in NewDetectedMethods)
            {
                // Заполняем MethodInfo.
                
                var mi = MethodInfoCollection.GetForMethod(Mode, method.RawBytes, method.Begin);
                if (mi == null)
                {
                    mi = new MethodInfoDto();
                    mi.CsBase = CsBase;
                    mi.Address = method.Begin;
                    mi.Mode = Mode;
                    mi.RawBytes = method.RawBytes;
                    mi.Id = MethodInfoDto.GenerateId(mi.Address, mi.Mode, mi.RawBytes);
                    MethodInfoCollection.Add(mi);
                }

                method.MethodInfo = mi;

                // Заполняем IsLocalBranch.

                foreach (var brunchInfo in BrunchesInfo.GetViewBetween(new BrunchInfo(method.Begin), new BrunchInfo(method.End)))
                {
                    var branchInstructionIndex = method.Instructions.BinarySearch(new CSharpInstruction(brunchInfo.From), CSharpInstruction.BeginComparer);
                    if (branchInstructionIndex < 0)
                        continue;

                    var branchInstruction = method.Instructions[branchInstructionIndex];
                    if (!branchInstruction.IsJmpOrJcc && !branchInstruction.IsLoopOrLoopcc)
                        continue;

                    if (branchInstruction.IsLocalBranch)
                        continue;
                    
                    branchInstruction.IsLocalBranch = brunchInfo.To.All(
                        addressTo =>
                        {
                            if (method.Begin <= addressTo && addressTo < method.End)
                            {
                                // Переход внутрь метода.

                                var index = method.Instructions.BinarySearch(
                                    new CSharpInstruction(addressTo),
                                    CSharpInstruction.BeginComparer);

                                if (0 <= index)
                                    return true;
                            }

                            return false;
                        });
                }
                
                // Удаляем недостижимый код.

                //foreach (var instruction in method.Instructions)
                //{
                    
                //}
            }

            //MethodInfoCollection.Save();
        }


        // return file paths.
        public List<string> Save(bool inParallel = true, bool callDetectMethods = true)
        {
            if (callDetectMethods)
                DetectMethods();


            var path = Configuration.CodeOutput;
            Directory.CreateDirectory(path);

            OnSave?.Invoke(this, EventArgs.Empty);


            if (!inParallel || NewDetectedMethods.Count < 4)
            {
                var files = new List<string>();
                var exList = new List<Exception>();

                foreach (var detectedMethod in NewDetectedMethods.OrderBy(x => x.MethodInfo))
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

                //MethodInfoCollection.Save();

                if (exList.Count != 0)
                    throw new AggregateException(exList);

                return files;
            }
            else
            {
                var files = new ConcurrentBag<string>();
                var exList = new ConcurrentBag<Exception>();

                var uniqueDetectedMethodsByAddress = NewDetectedMethods.ToLookup(x => x.MethodInfo.Address);

                Parallel.ForEach(
                    uniqueDetectedMethodsByAddress,
                    detectedMethodsWithSameAddress =>
                    {
                        foreach (var detectedMethod in detectedMethodsWithSameAddress.OrderBy(x => x.MethodInfo))
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

                //MethodInfoCollection.Save();

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


            NonBlockingConsole.WriteLine($"Сохранение метода '{methodBegin}' в файл '{Path.GetFileName(filePath)}'.");


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
            output.AppendLine($"        [MethodInfo(\"{detectedMethod.MethodInfo.Id}\")]");
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

                if (last_instr_end != cmd.Begin) // Обнаружен недекодированный код.
                {
                    var os = new StringBuilder();
                    write_instruction_position_and_spaces(os, last_instr_end, cmd.Begin, offset);

                    output.AppendLine(
                        last_instr_jmp_or_ret
                            ? $"//  {os}Недостижимый код."
                            : $"    {os}throw new InvalidOperationException(\"Недекодированный код.\");");
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
                        $"Instruction address: {cmd.Begin}, Method Id: '{detectedMethod.MethodInfo.Id}'", ex);
                }


                if (skip || cmd.CommentThis)
                    output.Append("//"); // Комментируем недостижимый код.
                else
                    output.Append("  ");   

                if (cmd.IsRet || (cmd.IsJmp && cmd.IsLocalBranch /* is 'goto'. */))
                    skip = true;


                output.AppendLine($"  {instr}");

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