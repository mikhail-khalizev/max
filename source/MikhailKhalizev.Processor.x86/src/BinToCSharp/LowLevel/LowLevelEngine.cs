using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel.Plugin;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Configuration;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    // TODO Разделить класс на несколько - один разбивает код на части. Другой преобразовывает в C#. Третий сохраняет в файл.

    /// <summary>
    /// Алгоритм декодирует код по частям. Каждую часть декодируется последовательно
    /// до тех пор пока не встретится потенциальный конец функции (ret или jmp). После
    /// чего декодирование части заканчивается и начинается декодирование других частей,
    /// выявленных по операциям ветвления (jcc, jmp, loop, call).
    /// </summary>
    public class LowLevelEngine
    {
        public static DetectedMethod GetMethod(MethodInfoDto mi, Action<LowLevelEngine> configure = null)
        {
            var engine = new LowLevelEngine(
                new BinToCSharpDto(),
                new DefinitionCollection(),
                new InMemoryMethodInfoCollection());

            engine.Memory = new MemoryFromMethodInfo(mi);
            engine.CsBase = mi.CsBase;
            engine.Mode = mi.Mode;

            engine.SuppressDecodeIntervals.Add(0, mi.Address);
            engine.SuppressDecodeIntervals.Add(mi.Address + mi.RawBytes.Length, 0);

            configure?.Invoke(engine);

            engine.DecodeMethod(mi.Address);
            engine.DetectMethods();

            var method = engine.NewDetectedMethods.First(x => x.Begin == mi.Address);
            return method;
        }


        public BinToCSharpDto Configuration { get; }
        public DefinitionCollection DefinitionCollection { get; }
        public IMethodInfoCollection MethodInfoCollection { get; }
        public ArchitectureMode Mode { get; set; }
        public Address CsBase { get; set; }
        public Address DsBase { get; set; }
        public IRandomAccess Memory { get; set; }

        public event EventHandler<X86Instruction> InstructionDecoded;
        public event EventHandler OnSave;

        public IntervalCollection<Address> SuppressDecodeIntervals { get; } = new IntervalCollection<Address>();
        public DecodedCode DecodedCode { get; } = new DecodedCode();

        public int LimitDecodeTotalLength { get; set; }

        /// <summary>
        /// Список адресов на которых происходит принудительное завершение декодирования.
        /// Это требуется при декодировании 'странного' кода. Например когда в методе,
        /// вызванным call происходит возврат не на один уровень вверх, а на два. В результате
        /// требуется принудительно остановить декодирование после данного call.
        /// </summary>
        /// <remarks>
        /// Если <see cref="ForceEndOfMethod"/> делит инструкцию пополам,
        /// то эта инструкция относится к методу, расположенному с меньшим адресом.
        /// </remarks>
        private MySortedSet<Address> ForceEndOfMethod { get; } = new MySortedSet<Address>();

        private MultiValueDictionary<Address, MethodInfoDto> AlreadyKnowMethods { get; } = new MultiValueDictionary<Address, MethodInfoDto>();

        /// <summary>
        /// Набор адресов начиная с которых необходимо произвести декодирование.
        /// </summary>
        private readonly HashSet<Address> _addressesToDecode = new HashSet<Address>();

        /// <summary>
        /// Содержит информацию о найденных методах.
        /// </summary>
        public MySortedSet<DetectedMethod> NewDetectedMethods { get; } = new MySortedSet<DetectedMethod>(DetectedMethod.BeginComparer);

        // Переходы на известные адреса.
        public SortedSet<BranchInfo> BranchesInfo = new SortedSet<BranchInfo>(BranchInfo.BeginComparer);

        private readonly SimpleBranchPlugin _simpleBranchPlugin; // addr_to_decode from any jmp.
        private readonly SwitchPlugin _switchPlugin;
        private readonly ReadCStringPlugin _readCStringPlugin;

        public delegate void OnInstructionAttachToMethodDelegate(DetectedMethod method, int instructionIndex);
        private readonly MySortedDictionary<IInstruction, OnInstructionAttachToMethodDelegate> _onAttachToMethodDelegates =
            new MySortedDictionary<IInstruction, OnInstructionAttachToMethodDelegate>(IInstruction.BeginComparer);

        public LowLevelEngine(
            BinToCSharpDto configuration,
            DefinitionCollection definitionCollection,
            IMethodInfoCollection methodInfoCollection)
        {
            Configuration = configuration;
            DefinitionCollection = definitionCollection;
            MethodInfoCollection = methodInfoCollection;

            _readCStringPlugin = new ReadCStringPlugin(this);
            _simpleBranchPlugin = new SimpleBranchPlugin(this);
            _switchPlugin = new SwitchPlugin(this);

            LimitDecodeTotalLength = Configuration.LimitDecodeSize;
        }

        public void SetCStringDataArea(Address begin, Address end)
        {
            _readCStringPlugin.StringArea = Interval.From(begin, end);
        }

        public void RegisterOnInstructionAttachToMethod(X86Instruction instruction, OnInstructionAttachToMethodDelegate action)
        {
            if (_onAttachToMethodDelegates.TryGetValue(instruction, out var prevAction))
                action += prevAction;

            _onAttachToMethodDelegates[instruction] = action;
        }

        public void AddForceEndOfMethod(Address fullAddress)
        {
            ForceEndOfMethod.Add(fullAddress);
        }

        public void AddAlreadyKnownMethod(MethodInfoDto model)
        {
            AlreadyKnowMethods.Add(model.Address, model);
        }

        public void RemoveAlreadyKnownMethod(Address fullAddress)
        {
            AlreadyKnowMethods.Remove(fullAddress);
        }

        public bool CheckIsHaveAlreadyKnownMethodWithStartAddress(Address fullAddress)
        {
            if (!AlreadyKnowMethods.TryGetValue(fullAddress, out var models))
                return false;

            foreach (var model in models)
            {
                if (SuppressDecodeIntervals.Contains(model.Address + model.RawBytes.Length, false))
                    continue;

                if (Memory.Equals(fullAddress, model.RawBytes))
                    return true;
            }

            return false;
        }

        private bool CheckIsAlreadyKnowMethodsContainsMethodInfo(MethodInfoDto methodInfoDto)
        {
            return AlreadyKnowMethods.GetValues(methodInfoDto.Address, false)?.Contains(methodInfoDto) == true;
        }


        public bool AddNewDetectedMethod(Address addressOfMethodBegin)
        {
            if (SuppressDecodeIntervals.Contains(addressOfMethodBegin, false))
                return false;

            if (CheckIsHaveAlreadyKnownMethodWithStartAddress(addressOfMethodBegin))
                return false;

            return NewDetectedMethods.Add(new DetectedMethod(addressOfMethodBegin));
        }

        public void DecodeMethod(Address start)
        {
            Decode(start);

            // Mark that we have method started with 'start' address.
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
                ProcessDecodeStep(address);
            }
        }


        private void ProcessDecodeStep(Address address)
        {
            if (address < CsBase)
                return;

            if (LimitDecodeTotalLength <= 0)
                return;

            if (DecodedCode.ContainsInstruction(address))
                return; // Код включающий этот адрес уже декодирован.

            var lowerBound = SuppressDecodeIntervals.LowerBound(address, false);
            var nearestSuppressDecode = lowerBound.IsEmpty ? Address.MaxValue : lowerBound.Begin;

            if (nearestSuppressDecode <= address)
                return;

            Memory.GetMinSize(address, 1); // Попробуем прочитать хоть один байт - вдруг чтение недоступно.

            // Функция, начинающаяся с точного совпадения ForceEndMethod может начать декодироваться.
            var nearestForceEnd = ForceEndOfMethod.FirstGreaterOrDefault(address);
            if (nearestForceEnd == default)
                nearestForceEnd = Address.MaxValue;

            foreach (var cmd in X86Instruction.DecodeCode(Memory, address, Mode, DefinitionCollection))
            {
                LimitDecodeTotalLength -= cmd.Length;

                DecodedCode.Insert(cmd);
                InstructionDecoded?.Invoke(this, cmd);

                if (cmd.Metadata.IsJmpOrRet)
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

            SplitCodeToMethods();
            PostProcessingNewDetectedMethods();
        }

        private void SplitCodeToMethods()
        {
            AddNewDetectedMethod(DecodedCode.Area.First().Begin);

            while (true)
            {
                var successCount = 0;
                var toRemove = new List<DetectedMethod>();

                foreach (var method in NewDetectedMethods.ToArray())
                {
                    var methodBegin = method.Begin;

                    // Проверим, делит ли другой метод текущий.

                    if (method.End != 0)
                    {
                        var otherMethod = NewDetectedMethods.FirstGreaterOrDefault(method);

                        if (otherMethod == null || method.End <= otherMethod.Begin)
                        {
                            // Пересечения с другим методом нет. Всё корректно.
                            successCount++;
                            continue;
                        }

                        // Надо заново разбить этот метод.
                        method.End = 0;
                    }

                    // Проверим наличие первой инструкции метода.

                    var firstCmd = DecodedCode.GetInstructionOrNull(methodBegin);

                    if (firstCmd == null)
                    {
                        // Вообще не декодировали этот адрес. Видимо он либо AlreadyKnownMethods или SuppressDecode.
                        toRemove.Add(method);
                        continue;
                    }

                    // Посчитаем methodEnd - адрес конца метода, дальше которого функция точно уже не может продолжаться.

                    var forceEndAfter = ForceEndOfMethod.FirstGreaterOrDefault(methodBegin, Address.MaxValue);
                    var forceEndInsideAfter = NewDetectedMethods.FirstGreaterOrDefault(method)?.Begin ?? Address.MaxValue;

                    // Учтём, что инструкции в DecodedCode могут пересекаться. Найдём "верную дорожку".

                    var instructions = new List<IInstruction>();

                    IInstruction prevInstr = null;
                    var prevInstrEnd = firstCmd.Begin;

                    for (var cmd = firstCmd; cmd != null; cmd = DecodedCode.GetNextInstruction(cmd))
                    {
                        if (forceEndAfter <= cmd.Begin || forceEndInsideAfter < cmd.End)
                            break;

                        // Не допускаем большие "дыры".

                        var holeSize = cmd.Begin - prevInstrEnd;
                        if (2 * (int)Mode < holeSize && 2 * (prevInstrEnd - firstCmd.Begin) < holeSize)
                            break;

                        // Проверим на принадлежность к AlreadyKnownMethods.
                        // Разрешим методам пересекаться при отсутствии ret и jmp в конце метода.
                        // Так выполнение кода может быть быстрее (при циклах), т.к. нет постоянных вызовов других методов.

                        if ((prevInstr == null || prevInstr.Metadata.IsJmpOrRet) &&
                            (CheckIsHaveAlreadyKnownMethodWithStartAddress(prevInstrEnd) ||
                                (cmd.Begin != prevInstrEnd && CheckIsHaveAlreadyKnownMethodWithStartAddress(cmd.Begin))))
                        {
                            // Нашли среди уже существующих методов.
                            break;
                        }

                        instructions.Add(cmd);

                        prevInstr = cmd;
                        prevInstrEnd = cmd.End;
                    }

                    // Убираем конечные закомментированные инструкции.
                    while (instructions.Count != 0 && instructions[instructions.Count - 1] is X86Instruction csi && csi.CommentThis)
                        instructions.RemoveAt(instructions.Count - 1);

                    if (instructions.Count == 0)
                    {
                        toRemove.Add(method);
                        continue;
                    }

                    method.Instructions = instructions;
                    method.End = instructions[instructions.Count - 1].End;
                    method.RawBytes = Memory.ReadAll(method.Begin, method.End - method.Begin);

                    // Заполняем label.

                    foreach (var branchInfo in BranchesInfo.GetViewBetween(new BranchInfo(methodBegin), new BranchInfo(method.End)))
                    {
                        var branchInstructionIndex = method.InstructionIndexOf(branchInfo.From);
                        if (branchInstructionIndex < 0)
                            continue;

                        foreach (var addressTo in branchInfo.To)
                        {
                            if (methodBegin <= addressTo && addressTo < method.End)
                            {
                                // Переход внутрь метода.

                                var index = method.InstructionIndexOf(addressTo);
                                if (index < 0)
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

                            while (decodeStart != 0 && decodeStart < instruction.Begin && DecodedCode.GetInstructionBefore(decodeStart).Metadata.IsJmp)
                            {
                                // Перед декодированием, временно, добавляем адрес instruction.Begin в ForceEndMethod для безопасности.
                                // А то вдруг там некорректный код и адрес instruction.Begin находится внутри инструкции и тогда мы можем уйти далеко за наш метод.
                                var shouldAddFam = ForceEndOfMethod.Contains(instruction.Begin);
                                if (!shouldAddFam)
                                    AddForceEndOfMethod(instruction.Begin);

                                Decode(decodeStart);

                                if (!shouldAddFam)
                                    ForceEndOfMethod.Remove(instruction.Begin);

                                if (DecodedCode.GetInstructionOrNull(decodeStart) == null)
                                    break; // Decode fail. Skip this hole.

                                decodeStart = DecodedCode.Area.FindIntervalThatContainsValue(decodeStart, false)
                                    .End; // Can be 0 if decodeStart in AlreadyKnownMethods.

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

        private void PostProcessingNewDetectedMethods()
        {
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

                if (CheckIsAlreadyKnowMethodsContainsMethodInfo(mi))
                    throw new InvalidOperationException("Detect already decoded method. Error in algorithm.");

                // Заполняем IsLastInstructionInMethod.

                method.Instructions[^1].Metadata.IsLastInstructionInMethod = true;

                // Заполняем HasLabel и IsLocalBranch.

                foreach (var branchInfo in BranchesInfo.GetViewBetween(new BranchInfo(method.Begin), new BranchInfo(method.End)))
                {
                    var fromInstructionIndex = method.InstructionIndexOf(branchInfo.From);
                    if (fromInstructionIndex < 0)
                        continue;

                    foreach (var to in branchInfo.To)
                    {
                        var toInstructionIndex = method.InstructionIndexOf(to);
                        if (0 <= toInstructionIndex)
                            method.Instructions[toInstructionIndex].Metadata.HasLabel = true;
                    }

                    var fromInstruction = method.Instructions[fromInstructionIndex];
                    fromInstruction.Metadata.IsLocalBranch = branchInfo.To.All(
                        addressTo =>
                        {
                            if (method.Begin <= addressTo && addressTo < method.End)
                            {
                                // Переход внутрь метода.

                                var index = method.InstructionIndexOf(addressTo);
                                if (0 <= index)
                                    return true;
                            }

                            return false;
                        });
                }

                // Call onAttachToMethod.
                
                foreach (var instruction in _onAttachToMethodDelegates
                    .GreaterThat(new AddressSearchInstruction(method.Begin - 1))
                    .Where(x => x.Begin < method.End).ToList())
                {
                    var index = method.InstructionIndexOf(instruction);
                    if (0 <= index)
                        _onAttachToMethodDelegates[instruction](method, index);
                }

                // Удаляем недостижимый код.

                while (true)
                {
                    var skip = false; // Если нашли недостижимый код устанавливаем в true.
                    var anyBranchSkipped = false;

                    var removeLabels = new HashSet<Address>();

                    for (var cmdIndex = 0; cmdIndex < method.Instructions.Count; cmdIndex++)
                    {
                        var cmd = method.Instructions[cmdIndex];

                        if (cmd.Metadata.HasLabel)
                            skip = false;

                        if (skip)
                        {
                            if (BranchesInfo.TryGetValue(new BranchInfo(cmd.Begin), out var branchInfo))
                            {
                                anyBranchSkipped = true;
                                removeLabels.UnionWith(branchInfo.To);
                            }

                            method.Instructions.RemoveAt(cmdIndex);
                            cmdIndex--;
                        }
                        else if (cmd.Metadata.IsRet || (cmd.Metadata.IsJmp && cmd.Metadata.IsLocalBranch /* is 'goto'. */))
                        {
                            // NOTE Если это не локальный переход, а просто IsJmp,
                            // то часто встречается ситуация, что после этого перехода
                            // осуществляется возврат на следующую после данной инструкции инструкцию.
                            //
                            // Поэтому все нелокальные переходы допускают продолжение:
                            //
                            //    ii(0xa14a, 5);  if(jmp_far_ind(memw[cs, 0x17be])) return;  /* jmp far word [cs:0x17be] */
                            //    ii(0xa14f, 2);  jmp(0xa167, 0x16); goto l_0xa167;          /* jmp 0xa167 */
                            //
                            //    (обратите внимание на 'if' и 'return')


                            skip = true;
                        }
                    }

                    if (!anyBranchSkipped)
                        break;

                    foreach (var branchInfo in BranchesInfo.GetViewBetween(new BranchInfo(method.Begin), new BranchInfo(method.End)))
                    {
                        var fromInstructionIndex = method.InstructionIndexOf(branchInfo.From);
                        if (fromInstructionIndex < 0)
                            continue;

                        removeLabels.ExceptWith(branchInfo.To);
                    }

                    if (removeLabels.Count == 0)
                        break;

                    foreach (var removeLabel in removeLabels)
                    {
                        var index = method.InstructionIndexOf(removeLabel);
                        if (0 <= index)
                            method.Instructions[index].Metadata.HasLabel = false;
                    }
                }
            }
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

        private string SaveMethod(DetectedMethod method)
        {
            var methodBegin = method.MethodInfo.Address;
            var methodEnd = methodBegin + method.End - method.Begin;

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

            if (!string.IsNullOrEmpty(ns) && (kd == null || !kd.StartsWith(ns)))
                baseFileName += $"-{ns.Replace("_", "-")}";

            if (kd != null)
                baseFileName += $"-{kd}";


            var filePath = "";
            var num = 1;
            while (true)
            {
                filePath = Path.Combine(Configuration.CodeOutput, baseFileName + (1 < num ? $".{num}" : "") + ".cs");
                if (!File.Exists(filePath))
                    break;

                var text = File.ReadAllText(filePath);
                if (text.Contains(method.MethodInfo.Id))
                    break; // Перезапишем уже существующий файл.

                num++;
            }


            NonBlockingConsole.WriteLine($"Сохранение метода '{methodBegin}' в файл '{Path.GetFileName(filePath)}'.");


            var output = new StringBuilder();
            WriteCSharpMethodToStringBuilder(output, method, num);

            File.WriteAllText(filePath, output.ToString());
            return filePath;
        }

        private void WriteCSharpMethodToStringBuilder(StringBuilder output, DetectedMethod detectedMethod, int fileNum)
        {
            var methodBegin = detectedMethod.MethodInfo.Address;


            var firstCmd = detectedMethod.Instructions.First();

            var methodName = DefinitionCollection.GetAddressFullName(methodBegin, new DefinitionCollection.Options { SkipDeclaringType = true, NullIfNoName = true });
            if (methodName == null)
                methodName = $"Method_{methodBegin.ToString(o => o.RemoveHexPrefix().SetTrimZero(false).SetGroupSize(4))}";

            var ns = AddressNameConverter.GetNamespace(methodBegin);
            if (!string.IsNullOrEmpty(ns))
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

            var lastInstrJmpOrRet = false;
            var lastInstrEnd = firstCmd.Begin;

            for (var cmdIndex = 0; cmdIndex < detectedMethod.Instructions.Count; cmdIndex++)
            {
                var cmd = detectedMethod.Instructions[cmdIndex];

                var lines = Enumerable.Empty<string>();

                if (lastInstrEnd != cmd.Begin) // Обнаружен недекодированный код.
                {
                    var ii = InstructionExtensions.GetInstructionInfoStringStatic(true, lastInstrEnd, cmd.Begin);
                    lines = lines.Append(
                        lastInstrJmpOrRet
                            ? $"//  {ii}Недостижимый код."
                            : $"    {ii}throw new InvalidOperationException(\"Недекодированный код.\");");
                }

                try
                {
                    if (cmd.Metadata.HasLabel)
                        lines = lines.Append($"l_{cmd.Begin}:");

                    lines = lines.Concat(cmd.GetLowLevelCode());

                    foreach (var str in lines)
                    {
                        output.Append(new string(' ', 8));
                        output.AppendLine(str);
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException($"X86Instruction address: {cmd.Begin}, Method Id: '{detectedMethod.MethodInfo.Id}'", ex);
                }

                lastInstrEnd = cmd.End;
                lastInstrJmpOrRet = cmd.Metadata.IsJmpOrRet;
            }

            output.AppendLine("        }");
            output.AppendLine("    }");
            output.AppendLine("}");
        }
    }
}