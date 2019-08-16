using System;
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
        public MethodsInfo _methodsInfo;
        private readonly DefinitionCollection _definitionCollection;

        public Redecode(
            BinToCSharpDto configuration,
            MethodsInfo methodsInfo,
            DefinitionCollection definitionCollection)
        {
            _methodsInfo = methodsInfo;
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
                .Select(attribute => _methodsInfo.GetByGuidOrNull(attribute.Guid))
                .Where(methodInfo => methodInfo != null)
                .ToList();


            var directory = Configuration.CodeOutput;
            var methodsWithPath = new List<(MethodInfoDto MethodInfo, string Path)>();
            foreach (var filePath in Directory.EnumerateFiles(directory))
            {
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

                var guidString = text.Substring(startIndex, endIndex - startIndex);
                var guid = Guid.Parse(guidString);

                var mi = _methodsInfo.GetByGuidOrNull(guid);
                if (mi != null)
                    methodsWithPath.Add((mi, filePath));
            }


            var policy = Policy
                .Handle<IOException>()
                .WaitAndRetry(3, retryAttempt => TimeSpan.FromSeconds(1));

            var exList = new List<Exception>();

            Parallel.ForEach(
                methodsWithPath,
                new ParallelOptions { MaxDegreeOfParallelism = 1 }, // TODO Remove?
                x =>
                {
                    var (mi, filePath) = x;
                    
                    try
                    {
                        var csBase = mi.CsBase;
                        if (mi.Mode == ArchitectureMode.x86_16 && csBase + 0xffff < mi.Address + mi.RawBytes.Length || mi.Address < csBase)
                            csBase = mi.Address;

                        var engine = new Engine(Configuration, _definitionCollection, new MemoryFromMethodInfo(mi), mi.Mode, csBase, 0, _methodsInfo);
                        engine.SuppressDecode.Add(0, mi.Address);
                        engine.SuppressDecode.Add(mi.Address + mi.RawBytes.Length, 0);
                        foreach (var methodInfo in allDecodedMethodInfos)
                            engine.AddAlreadyDecodedFunc(methodInfo);
                        engine.RemoveAlreadyDecodedFunc(mi.Address);

                        engine.DecodeMethod(mi.Address, mi.Address + mi.RawBytes.Length);

                        var fileBakPath = filePath + ".bak";
                        policy.Execute(() => File.Delete(fileBakPath));
                        policy.Execute(() => File.Move(filePath, fileBakPath));

                        try
                        {
                            engine.Save();
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
                        NonBlockingConsole.WriteLine($"Ошибка при сохранении метода {{{mi.Guid}}} в файл: {ex.Message.TrimEnd('.')}.");
                    }
                });

            if (exList.Count != 0)
                throw new AggregateException(exList);
        }
    }
}