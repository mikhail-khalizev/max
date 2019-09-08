using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using MikhailKhalizev.Max.Dos;
using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.CSharpExecutor;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using ConfigurationDto = MikhailKhalizev.Max.Configuration.ConfigurationDto;

namespace MikhailKhalizev.Max.Program
{
    public class RawProgramMain : BridgeCpu, ICompiledMethodCollection
    {
        public new Processor.x86.CSharpExecutor.Cpu Implementation { get; }
        public ConfigurationDto Configuration { get; }
        public DefinitionCollection DefinitionCollection { get; }
        public IServiceProvider ServiceProvider { get; }
        public MethodInfoCollection MethodInfoCollection { get; }

        public DosMemory DosMemory { get; }
        public DosInterrupt DosInterrupt { get; }
        public DosTimer DosTimer { get; }
        public DosPort DosPort { get; }
        public DosDma DosDma { get; }
        public DosPic DosPic { get; }

        public MultiValueDictionary<Address, MyMethodInfo> MethodsByAddress = new MultiValueDictionary<Address, MyMethodInfo>();

        public const ushort ImageLoadSeg = 0x1a2; // Const from dosbox.
        public const ushort PspSeg = ImageLoadSeg - 16; // 0x192

        public RawProgramMain(
            Processor.x86.CSharpExecutor.Cpu implementation,
            ConfigurationDto configuration,
            MethodInfoCollection methodInfoCollection,
            DefinitionCollection definitionCollection,
            IServiceProvider serviceProvider)
            : base(implementation)
        {
            MethodInfoCollection = methodInfoCollection;
            Configuration = configuration;
            Implementation = implementation;
            DefinitionCollection = definitionCollection;
            ServiceProvider = serviceProvider;

            DosMemory = new DosMemory(implementation, this);
            DosInterrupt = new DosInterrupt(implementation, this);
            DosTimer = new DosTimer(implementation, this);
            DosPort = new DosPort(implementation, this);
            DosDma = new DosDma(implementation, this);
            DosPic = new DosPic(implementation, this);

            Implementation.MethodInfoCollection = MethodInfoCollection;
            implementation.CompiledMethodCollection = this;
            implementation.runIrqs += (sender, args) => DosPic.RunIrqs();
            implementation.runInb += (sender, args) =>
            {
                try
                {
                    DosPort.MyInb(args.value, args.port);
                    // NonBlockingConsole.WriteLine($"inb, port: {args.port}, value: {args.value}");
                }
                catch
                {
                    NonBlockingConsole.WriteLine($"inb, port: {args.port}, value: {args.value}");
                    throw;
                }
            };
            implementation.runOutb += (sender, args) =>
            {
                try
                {
                    DosPort.MyOutb(args.port, args.value);
                    // NonBlockingConsole.WriteLine($"outb, port: {args.port}, value: {args.value}");
                }
                catch
                {
                    NonBlockingConsole.WriteLine($"outb, port: {args.port}, value: {args.value}");
                    throw;
                }
            };
            implementation.runOutw += (sender, args) =>
            {
                try
                {
                    DosPort.MyOutw(args.port, args.value);
                }
                catch
                {
                    Console.WriteLine($"outb, value: {args.value}, port: {args.port}");
                    throw;
                }
            };
        }

        public void Start()
        {
            ConnectDecodedMethods(GetType().Assembly);
            DosInterrupt.Initialize();
            InitializeX86DosProgram();
            DosTimer.Initialize();

            Implementation.CorrectMethodPosition(0);
        }

        private void ConnectDecodedMethods(Assembly assembly)
        {
            foreach (var bridgeProcessorType in assembly.GetTypes().Where(x => typeof(BridgeCpu).IsAssignableFrom(x)))
            {
                object instance = null;

                foreach (var methodInfo in bridgeProcessorType.GetMethods(BindingFlags.Instance | BindingFlags.Public))
                {
                    var attribute = methodInfo.GetCustomAttribute<MethodInfoAttribute>();
                    if (attribute == null)
                        continue;

                    var mi = MethodInfoCollection.GetByIdOrNull(attribute.Id);
                    if (mi == null)
                        continue;

                    if (instance == null)
                    {
                        instance = Activator.CreateInstance(bridgeProcessorType, Implementation);
                        foreach (var pi in bridgeProcessorType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(x => x.PropertyType == typeof(RawProgramMain)))
                            pi.SetValue(instance, this);
                    }

                    var fi = new MyMethodInfo();
                    fi.MethodInfo = mi;
                    fi.Action = (Action)methodInfo.CreateDelegate(typeof(Action), instance);

                    MethodsByAddress.Add(mi.Address, fi);
                }
            }
        }

        public void InitializeX86DosProgram()
        {
            cr0.UInt32 = 0x0010;

            var exeBytes = File.ReadAllBytes(Path.Combine(Configuration.Max.InstalledPath, Configuration.Max.ExeFileName));
            var dosMz = new DosMz(exeBytes);

            if (!dosMz.IsCorrect)
                throw new Exception();

            DosMemory.dos_mem_init();

            // Alloc dos - dummy.

            bx = PspSeg - 2; // internal alloc logic
            DosMemory.dos_mem_alloc();
            if (eflags.cf)
                throw new Exception();

            // Alloc image.

            var exe_image_off = dosMz.ExeDataStart;
            var image_size = dosMz.ExeDataLength;

            bx = (image_size + 15) / 16 + 16; // psp_size
            DosMemory.dos_mem_alloc();
            if (eflags.cf)
                throw new Exception();

            if (ax.UInt16 != PspSeg)
                throw new Exception();

            ds.Selector = (ImageLoadSeg);

            var image = Implementation.Memory.GetFixSize(ds, 0, image_size);

            // Upload image of program.

            exeBytes.AsSpan().Slice(exe_image_off, image_size).CopyTo(image);

            // Apply realoc.

            foreach (var relocation in dosMz.Relocations)
            {
                var addr = relocation.Seg * 16 + relocation.Ofs;

                if (image_size <= addr + 1)
                    throw new Exception();

                image.Ref<ushort>(addr) += ImageLoadSeg;
            }

            // set psp

            var evnseg = PspSeg - 0xa; // 0x188
            var evn_init = new byte[]
            {
                // PATH=Z:\\
                0x50, 0x41, 0x54, 0x48, 0x3d, 0x5a, 0x3a, 0x5c, 0x0,

                // COMSPEC=Z:\\COMMAND.COM
                0x43, 0x4f, 0x4d, 0x53, 0x50, 0x45, 0x43, 0x3d, 0x5a, 0x3a, 0x5c, 0x43,
                0x4f, 0x4d, 0x4d, 0x41, 0x4e, 0x44, 0x2e, 0x43, 0x4f, 0x4d, 0x0,

                // BLASTER=A220 I7 D1 H5 T6 // Port Address - 220, Interrupt - 7, DMA Channel - 1, "High" DMA Channel - 5, Type of Card - 6.
                0x42, 0x4c, 0x41, 0x53, 0x54, 0x45, 0x52, 0x3d, 0x41, 0x32, 0x32,
                0x30, 0x20, 0x49, 0x37, 0x20, 0x44, 0x31, 0x20, 0x48, 0x35, 0x20,
                0x54, 0x36, 0x0,

                0x0, 0x1, 0x0,

                // C:\\MAXRUN.EXE
                0x43, 0x3a, 0x5c, 0x4d, 0x41, 0x58, 0x52, 0x55, 0x4e, 0x2e, 0x45,
                0x58, 0x45, 0x0
            };

            ds.Selector = (evnseg);
            evn_init.CopyTo(
                Implementation.Memory
                    .GetFixSize(ds, 0, evn_init.Length));

            ds.Selector = (PspSeg); // 0x192
            memb_a16[ds, 0x81] = 0xd; // Empty command-line (terminated by a 0x0D).
            memw_a16[ds, 0x2c] = evnseg;

            // Terminate address of previous program.
            // memw_a16(ds, 0xa) = 0x20c8;
            // memw_a16(ds, 0xa + 2) = 0xf000;

            ds.Selector = (evnseg - 1); // 0x187
            memb_a16[ds, 0] = 0x4d; // Не знаю, что это.
            memw_a16[ds, 1] = PspSeg;
            memw_a16[ds, 3] = 0x9;

            ds.Selector = (PspSeg - 1); // 0x191
            // memw_a16(ds, 0x3) = 0x1346 - 0x191;
            memw_a16[ds, 0x3] = 0xc02 - 0x191;



            // Устанавливаем начальные значения в регистры.

            ds.Selector = (PspSeg);
            es = ds;

            ss.Selector = (ImageLoadSeg + dosMz.Hdr.InitialSs);
            sp = dosMz.Hdr.InitialSp;

            cs.Selector = (ImageLoadSeg + dosMz.Hdr.InitialCs);
            eip = dosMz.Hdr.InitialIp;
            CurrentInstructionAddress = dosMz.Hdr.InitialIp;

            eax = 0;
            ebx = 0;
            ecx = 0xff;
            edx = PspSeg;

            esi = 0x2382;
            edi = 0x340;
            ebp = 0x91c;

            eflags.UInt32 = 0x7202;
        }

        /// <inheritdoc />
        public void GetMethod(out MethodInfoDto methodInfo, out Action method)
        {
            while (true)
            {
                var fullAddress = cs[eip];
                if (fullAddress == 0)
                    throw new InvalidOperationException("Запрос метода по нулевому указателю.");

                var info = find_func_exact(fullAddress);
                if (info != null)
                {
                    methodInfo = info.MethodInfo;
                    method = info.Action;
                    return;
                }

                // Всё-таки декодируем.
                var files = DecodeCurrentMethod();

                // Compile and load.
                try
                {
                    NonBlockingConsole.WriteLine($"Компилирование новых методов.");
                    var dllPath = Compile(files);

                    NonBlockingConsole.WriteLine($"Загрузка '{dllPath}'.");
                    var assembly = Assembly.LoadFile(dllPath);

                    DefinitionCollection.AddDefinitionsFromAssembly(assembly);
                    ConnectDecodedMethods(assembly);
                }
                catch (Exception ex)
                {
                    NonBlockingConsole.WriteLine(ex);
                    throw;
                }
            }

            //throw new InvalidOperationException("Метод не найдена.");
        }

        private int _compileNum;

        private string Compile(IEnumerable<string> files)
        {
            _compileNum++;
            var assemblyName = $"{GetType().Assembly.GetName().Name}.RawProgram.{_compileNum}";
            var assemblyDllPath = Path.Combine(Path.GetTempPath(), assemblyName + ".dll");
            var assemblyPdbPath = Path.Combine(Path.GetTempPath(), assemblyName + ".pdb");

            var syntaxTrees = files
                .Append(@"src\Program\RawProgram.cs")
                .Append(Path.Combine(Configuration.BinToCSharp.CodeOutput, Configuration.BinToCSharp.StringDefinitionsClassName + ".cs"))
                .Select(
                    file =>
                    {
                        var source = File.ReadAllText(file);
                        var stringText = SourceText.From(source, Encoding.UTF8);
                        var parsedSyntaxTree = SyntaxFactory.ParseSyntaxTree(
                            stringText,
                            CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.Latest),
                            file);
                        return parsedSyntaxTree;
                    })
                .ToList();

            var defaultReferences =
                AppDomain.CurrentDomain.GetAssemblies()
                    .Select(
                        x =>
                        {
                            try
                            {
                                return MetadataReference.CreateFromFile(x.Location);
                            }
                            catch (NotSupportedException)
                            {
                                // In memory modules not supported Location.
                                return null;
                            }
                        })
                    .Where(x => x != null)
                    .ToList();

            var defaultCompilationOptions =
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                    //.WithOverflowChecks(true)
                    .WithOptimizationLevel(OptimizationLevel.Release);

            var compilation = CSharpCompilation.Create(assemblyName, syntaxTrees, defaultReferences, defaultCompilationOptions);

            var result = compilation.Emit(assemblyDllPath, assemblyPdbPath);
            if (!result.Success)
            {
                var str = string.Join(Environment.NewLine, result.Diagnostics.Where(x => x.DefaultSeverity == DiagnosticSeverity.Error));
                throw new InvalidOperationException(str);
            }

            return assemblyDllPath;
        }

        private MyMethodInfo find_func_exact(Address fullAddress)
        {
            var infos = MethodsByAddress.GetValues(fullAddress, false);
            if (infos == null)
                return null;

            foreach (var info in infos)
            {
                if ((int)info.MethodInfo.Mode != (cs.db ? 32 : 16))
                    continue;

                if (Implementation.Memory.Equals(fullAddress, info.MethodInfo.RawBytes))
                    return info;
            }

            return null;
        }


        public static void ConfigureEngine(LowLevelEngine engine)
        {
            // Аргументы следующим методам установлены опытным путём.

            engine.SuppressDecode.Add(0x1030_0000, 0);

            engine.SetCStringDataArea(0x101a_0003, 0x101b_384d);

            engine.AddForceEndMethod(0xbb03);
            engine.AddForceEndMethod(0xbb6f);
            engine.AddForceEndMethod(0xbb73);
            engine.AddForceEndMethod(0xdb13);
            engine.AddForceEndMethod(0x18_9b43);
            engine.AddForceEndMethod(0x18_f4c7);
            engine.AddForceEndMethod(0x18_b5b5);
            engine.AddForceEndMethod(0x18_edfc);
            engine.AddForceEndMethod(0x18_f88b);
            engine.AddForceEndMethod(0x18_f8ef);
            engine.AddForceEndMethod(0x19_8748);
            engine.AddForceEndMethod(0x100f_e8f8);
            engine.AddForceEndMethod(0x100f_bf17);
            engine.AddForceEndMethod(0x100f_a6fe);
            engine.AddForceEndMethod(0x100f_bf17);

            // mve
            foreach (var interval in MveForceEndIntervals)
                for (var i = interval.Begin; i <= interval.End; i++)
                    engine.AddForceEndMethod(i);
        }

        public static Interval<Address, Address.Comparer>[] MveForceEndIntervals { get; } = {
            new Interval<Address, Address.Comparer>(0x1018_eb10, 0x1018_ebd3),
            new Interval<Address, Address.Comparer>(0x1018_ec5c, 0x1018_ecd6),
            new Interval<Address, Address.Comparer>(0x1018_edc8, 0x1018_eedc),
            new Interval<Address, Address.Comparer>(0x1018_efd0, 0x1018_f0ba),
            new Interval<Address, Address.Comparer>(0x1018_f1a0, 0x1018_f278),
            new Interval<Address, Address.Comparer>(0x1018_f408, 0x1018_f4eb),
            new Interval<Address, Address.Comparer>(0x1018_f56c, 0x1018_f5f6),
            new Interval<Address, Address.Comparer>(0x1018_f6dc, 0x1018_f7c2),
            new Interval<Address, Address.Comparer>(0x1018_f89c, 0x1018_f926),
            new Interval<Address, Address.Comparer>(0x1018_fab4, 0x1018_fbc1),
            new Interval<Address, Address.Comparer>(0x1018_fd50, 0x1018_fe4d),
            new Interval<Address, Address.Comparer>(0x1018_ffcc, 0x1019_00b7)
        };

        private List<string> DecodeCurrentMethod()
        {
            //    exit(1); // TODO "--on-unknown-func={decode-and-exit, exit}"

            var fullAddress = cs[eip];

            var engine = new LowLevelEngine(
                Configuration.BinToCSharp,
                DefinitionCollection,
                MethodInfoCollection);

            engine.Memory = Implementation.Memory;
            engine.Mode = cs.db ? ArchitectureMode.x86_32 : ArchitectureMode.x86_16;
            engine.CsBase = cs.Descriptor.Base;
            engine.DsBase = ds.Descriptor.Base;

            ConfigureEngine(engine);

            if (cs.Descriptor.Base + cs.Descriptor.Limit + 1 != 0)
                engine.SuppressDecode.Add(cs.Descriptor.Base + cs.Descriptor.Limit + 1 + 1, 0);

            foreach (var pair in MethodsByAddress)
                foreach (var info in pair.Value)
                    engine.AddAlreadyDecodedFunc(info.MethodInfo);
            engine.RemoveAlreadyDecodedFunc(fullAddress); // force decode.


            // Замечено, что многие функции начинаются со следующих двух команд.

            // {0x68, 0x28, 0, 0, 0,  0xe8, 0x90, 0xa1, 0xb, 0}
            // ii(0, 0x5)   pushd(0x28);                                      /* push dword 0x28 */
            // ii(0, 0x5)   calld(sys_check_available_stack_size, 0xb_a190);  /* call 0x10165d52 */

            // Весь код MAXRUN.EXE
            Address code_start = 0x1007_0000;
            Address code_end = 0x1016_5d52;

            if (cs[0] == 0 && cs.db && its_first && !MethodsByAddress.ContainsKey(0x1007_0010) && !MethodsByAddress.ContainsKey(0x1016_4ad4))
            {
                its_first = false;
                NonBlockingConsole.WriteLine("Декодирования всего пользовательского кода MAX.");

                var code = Span<byte>.Empty;
                for (var i = code_start; i < code_end; i++)
                {
                    if (code.Length == 0)
                        code = Memory.GetMinSize(i, 1);

                    if (code[0] == 0x68)
                    {
                        if (code.Length < 10)
                            code = Memory.GetMinSize(i, 10);

                        if (code[5] == 0xe8 && code.Ref<uint>(6) + i + 10 == 0x1016_5d52 && !MethodsByAddress.ContainsKey(i))
                            engine.DecodeMethod(i);
                    }

                    code = code.Slice(1);
                }
            }


            NonBlockingConsole.WriteLine($"Запуск декодирования кода '{fullAddress}'.");

            engine.DecodeMethod(fullAddress);
            try
            {
                return engine.Save();
            }
            finally
            {
                MethodInfoCollection.Save();
            }
        }

        private bool its_first = true;

        public void add_internal_dyn_func(Action func, int mode, Address address)
        {
            var myMethodInfos = MethodsByAddress.GetValues(address, false);

            if (myMethodInfos != null)
            {
                foreach (var myMethodInfo in myMethodInfos)
                    if (myMethodInfo.Action != func)
                        throw new InvalidOperationException();
            }

            MethodsByAddress.Add(
                address,
                new MyMethodInfo
                {
                    Action = func,
                    MethodInfo = new MethodInfoDto
                    {
                        Id = func.Method.Name,
                        Address = address,
                        Mode = (ArchitectureMode)mode,
                        IgnoreSave = true
                    },
                });
        }

        public void add_internal_dyn_func_if_free(Action func, int mode, Address address)
        {
            if (MethodsByAddress.ContainsKey(address))
                return;

            add_internal_dyn_func(func, mode, address);
        }
    }

    public class MyMethodInfo
    {
        public MethodInfoDto MethodInfo { get; set; }

        public Action Action { get; set; }
    }
}