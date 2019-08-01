using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    public class MethodsInfo
    {
        private readonly BinToCSharpDto _configuration;
        private readonly Dictionary<Guid, MethodInfoDto> _methodByGuid;

        public static MethodsInfo Load(BinToCSharpDto configuration)
        {
            var path = Path.Combine(configuration.SettingsDirectory, configuration.MethodInfosFile);
            var allText = File.Exists(path) ? File.ReadAllText(path) : "";
            var methods = (JsonConvert.DeserializeObject<List<MethodInfoDto>>(allText) ?? new List<MethodInfoDto>()).ToDictionary(x => x.Guid, x => x);

            path = Path.Combine(configuration.SettingsDirectory, configuration.JumpInfosFile);
            allText = File.Exists(path) ? File.ReadAllText(path) : "";
            var jumps = JsonConvert.DeserializeObject<List<JumpsInfoDto>>(allText) ?? new List<JumpsInfoDto>();

            foreach (var jump in jumps)
            {
                methods.TryGetValue(jump.Guid, out var method);
                if (method != null)
                    method.Jumps = jump.Jumps.ToDictionary(x => x.Key, x => x.Value.ToHashSet());
            }

            return new MethodsInfo(configuration, methods);
        }

        private MethodsInfo(BinToCSharpDto configuration, Dictionary<Guid, MethodInfoDto> methodByGuid)
        {
            _configuration = configuration;
            _methodByGuid = methodByGuid;
        }

        public void Save()
        {
            var path = Path.Combine(_configuration.SettingsDirectory, _configuration.MethodInfosFile);

            using (var fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            using (var sw = new StreamWriter(fs))
            {
                var allText = JsonConvert.SerializeObject(_methodByGuid.Values.Where(x => !x.IgnoreSave).OrderBy(x => x.Address), Formatting.Indented);
                sw.Write(allText);
                sw.Flush();
                fs.SetLength(fs.Position);
            }


            path = Path.Combine(_configuration.SettingsDirectory, _configuration.JumpInfosFile);

            using (var fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            using (var sw = new StreamWriter(fs))
            {
                var allText = JsonConvert.SerializeObject(
                    _methodByGuid.Values
                        .Where(x => !x.IgnoreSave && 0 < x.Jumps?.Count)
                        .OrderBy(x => x.Address)
                        .Select(
                            x => new JumpsInfoDto
                            {
                                Guid = x.Guid,
                                Address = x.Address,
                                Jumps = x.Jumps.ToDictionary(y => y.Key, y => y.Value.OrderBy(z => z).ToList())
                            }),
                    Formatting.Indented);
                sw.Write(allText);
                sw.Flush();
                fs.SetLength(fs.Position);
            }
        }
        
        public MethodInfoDto GetByGuid(Guid guid)
        {
            _methodByGuid.TryGetValue(guid, out var method);
            return method;
        }

        public MethodInfoDto GetByRawBytes(ArchitectureMode mode, byte[] rawBytes)
        {
            return _methodByGuid.Values.FirstOrDefault(x => x.Mode == mode && x.RawBytes.SequenceEqual(rawBytes));
        }

        public void Add(MethodInfoDto method)
        {
            if (_methodByGuid.Values.Any(x => x.Guid == method.Guid || (x.Mode == method.Mode && x.RawBytes.SequenceEqual(method.RawBytes))))
                throw new InvalidOperationException("Duplicated item");
            _methodByGuid.Add(method.Guid, method);
        }

        public void AddJumpAndSave(MethodInfoDto method, Address from, Address to, int cSharpFunctionDelta)
        {
            from -= cSharpFunctionDelta;

            if (Interval.From(
                    method.Address + cSharpFunctionDelta,
                    method.Address + cSharpFunctionDelta + method.RawBytes.Length)
                .Contains(to))
                to -= cSharpFunctionDelta;


            if (method.Jumps == null)
                method.Jumps = new Dictionary<Address, HashSet<Address>>();
            
            if (!method.Jumps.TryGetValue(from, out var tos))
            {
                tos = new HashSet<Address>();
                method.Jumps[from] = tos;
            }

            var added = tos.Add(to);

            if (added && !method.IgnoreSave)
                Save();
        }
    }
}