using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Configuration;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Utils;
using Polly;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class Redecode
    {
        public BinToCSharpDto Configuration { get; }
        public MethodInfoCollection MethodInfoCollection;
        private readonly DefinitionCollection _definitionCollection;

        public int LimitFiles { get; set; } = int.MaxValue;

        public Redecode(
            BinToCSharpDto configuration,
            MethodInfoCollection methodInfoCollection,
            DefinitionCollection definitionCollection)
        {
            MethodInfoCollection = methodInfoCollection;
            _definitionCollection = definitionCollection;
            Configuration = configuration;
        }

        public void Start(Assembly assembly)
        {
            var allDecodedMethodInfos = assembly.GetTypes()
                .Where(x => typeof(BridgeProcessor).IsAssignableFrom(x))
                .SelectMany(
                    bridgeProcessorType => bridgeProcessorType.GetMethods(BindingFlags.Instance | BindingFlags.Public),
                    (bridgeProcessorType, methodInfo) => methodInfo.GetCustomAttribute<MethodInfoAttribute>())
                .Where(attribute => attribute != null)
                .Select(attribute => MethodInfoCollection.GetByIdOrNull(attribute.Id))
                .Where(methodInfo => methodInfo != null)
                .ToList();


            var directory = Configuration.CodeOutput;
            var methodsWithPath = new List<(MethodInfoDto MethodInfo, string Path)>();
            foreach (var filePath in Directory.EnumerateFiles(directory))
            {
                if (LimitFiles <= methodsWithPath.Count)
                    break;

                var extension = Path.GetExtension(filePath);
                if (extension != ".cs")
                    continue;
                var text = File.ReadAllText(filePath);

                var startIndex = text.IndexOf("[MethodInfo(\"", StringComparison.Ordinal);
                if (startIndex < 0)
                    continue;

                startIndex += "[MethodInfo(\"".Length;
                var endIndex = text.IndexOf("\")]", startIndex, StringComparison.Ordinal);
                if (endIndex < 0)
                    continue;

                var id = text.Substring(startIndex, endIndex - startIndex);

                var mi = MethodInfoCollection.GetByIdOrNull(id);
                if (mi != null)
                    methodsWithPath.Add((mi, filePath));
            }

            var policy = Policy
                .Handle<IOException>()
                .WaitAndRetry(3, retryAttempt => TimeSpan.FromSeconds(1));
            
            var exList = new List<Exception>();

            var engineCache = new ConcurrentBag<Engine>();

            Parallel.ForEach(
                methodsWithPath.ToLookup(x => x.MethodInfo.Address),
                new ParallelOptions { MaxDegreeOfParallelism = 1 }, // For debug.
                x =>
                {
                    foreach (var (mi, filePath) in x.OrderBy(y => y.MethodInfo))
                    {
                        engineCache.TryTake(out var engine);

                        try
                        {
                            var csBase = mi.CsBase;
                            if (mi.Address < csBase ||
                                mi.Mode == ArchitectureMode.x86_16 && csBase + 0xffff < mi.Address + mi.RawBytes.Length)
                                csBase = mi.Address;


                            if (engine == null)
                            {
                                engine = new Engine(
                                    Configuration,
                                    _definitionCollection,
                                    MethodInfoCollection);
                                
                                //foreach (var methodInfo in allDecodedMethodInfos)
                                //    engine.AddAlreadyDecodedFunc(methodInfo);
                            }

                            engine.ClearDecoded();

                            engine.Memory = new MemoryFromMethodInfo(mi);
                            engine.CsBase = csBase;
                            engine.Mode = mi.Mode;
                            
                            engine.LimitDecodeTotalLength = mi.RawBytes.Length;
                            engine.SuppressDecode.Clear();
                            engine.SuppressDecode.Add(0, mi.Address);
                            engine.SuppressDecode.Add(mi.Address + mi.RawBytes.Length, 0);
                            
                            //engine.RemoveAlreadyDecodedFunc(mi.Address);

                            if (mi.Address == 0x545d)
                            {
                                var debug = 0;
                            }

                            engine.DecodeMethod(mi.Address, mi.Address + mi.RawBytes.Length);

                            var fileBakPath = filePath + ".bak";
                            policy.Execute(() => File.Delete(fileBakPath));
                            policy.Execute(() => File.Move(filePath, fileBakPath));

                            try
                            {
                                engine.Save(false);
                            }
                            catch
                            {
                                policy.Execute(() => File.Move(fileBakPath, filePath));
                                throw;
                            }

                            policy.Execute(() => File.Delete(fileBakPath));
                        }
                        catch (Exception ex)
                        {
                            exList.Add(ex);
                            NonBlockingConsole.WriteLine($"Ошибка при сохранении метода {{{mi.Id}}} в файл: {ex.Message.TrimEnd('.')}.");
                        }
                        finally
                        {
                            if (engine != null)
                            {
                                engine.AddAlreadyDecodedFunc(mi);
                                engineCache.Add(engine);
                            }
                        }
                    }
                });

            if (exList.Count != 0)
                throw new AggregateException(exList);
        }
    }
}