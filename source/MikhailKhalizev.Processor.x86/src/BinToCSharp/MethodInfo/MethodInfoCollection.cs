using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MikhailKhalizev.Processor.x86.Configuration;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;
using Polly;
using SharpDisasm;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo
{
    public class MethodInfoCollection
    {
        private readonly BinToCSharpDto _configuration;
        private readonly Dictionary<Guid, MethodInfoDto> _methodByGuid;
        private bool _dirty;

        public static MethodInfoCollection Load(BinToCSharpDto configuration)
        {
            var path = Path.Combine(configuration.SettingsDirectory, configuration.MethodInfosFile);
            var allText = File.Exists(path) ? File.ReadAllText(path) : "";
            var methods = (JsonConvert.DeserializeObject<List<MethodInfoDto>>(allText) ?? new List<MethodInfoDto>())
                .Where(x => x.Raw.Length % 2 == 0)
                .ToDictionary(x => x.Guid, x => x);

            foreach (var (_, methodInfoDto) in methods)
            {
                if (methodInfoDto.Id == null)
                    methodInfoDto.Id = MethodInfoDto.GenerateId(methodInfoDto.Address, methodInfoDto.RawBytes);
            }

            path = Path.Combine(configuration.SettingsDirectory, configuration.JumpInfosFile);
            allText = File.Exists(path) ? File.ReadAllText(path) : "";
            var jumpsInfos = JsonConvert.DeserializeObject<List<JumpsInfoDto>>(allText) ?? new List<JumpsInfoDto>();

            foreach (var jumpsInfo in jumpsInfos)
            {
                methods.TryGetValue(jumpsInfo.Guid, out var method);
                if (method != null)
                {
                    method.JumpsInfo = jumpsInfo;

                    if (method.Jumps == null)
                        method.Jumps = new Dictionary<Address, HashSet<JumpDestinationInfoDto>>();

                    if (jumpsInfo.Jumps != null)
                        foreach (var (from, to) in jumpsInfo.Jumps)
                            method.Jumps[from] = to.ToHashSet();
                }
            }

            return new MethodInfoCollection(configuration, methods);
        }

        private MethodInfoCollection(BinToCSharpDto configuration, Dictionary<Guid, MethodInfoDto> methodByGuid)
        {
            _configuration = configuration;
            _methodByGuid = methodByGuid;
        }

        public void SetDirty()
        {
            _dirty = true;
        }

        public void Save(bool methodsJson = true, bool methodJumpsJson = true, bool force = false)
        {
            if (!_dirty && !force)
                return;
            if (methodsJson && methodJumpsJson)
                _dirty = false;

            var policy = Policy
                .Handle<IOException>()
                .WaitAndRetry(3, retryAttempt => TimeSpan.FromSeconds(1));

            if (methodsJson)
            {
                var path = Path.Combine(_configuration.SettingsDirectory, _configuration.MethodInfosFile);

                policy.Execute(
                    () =>
                    {
                        using (var fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
                        using (var sw = new StreamWriter(fs))
                        {
                            var allText = JsonConvert.SerializeObject(
                                _methodByGuid.Values.Where(x => !x.IgnoreSave).OrderBy(x => x.Address),
                                new JsonSerializerSettings
                                {
                                    Formatting = Formatting.Indented,
                                    DefaultValueHandling = DefaultValueHandling.Ignore
                                });
                            sw.Write(allText);
                            sw.Flush();
                            fs.SetLength(fs.Position);
                        }
                    });
            }

            if (methodJumpsJson)
            {
                var path = Path.Combine(_configuration.SettingsDirectory, _configuration.JumpInfosFile);

                policy.Execute(
                    () =>
                    {
                        using (var fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
                        using (var sw = new StreamWriter(fs))
                        {
                            var allText = JsonConvert.SerializeObject(
                                _methodByGuid.Values
                                    .Where(x => !x.IgnoreSave && (0 < x.Jumps?.Count || 0 < x.JumpsInfo?.IsGoUp?.Count))
                                    .OrderBy(x => x.Address)
                                    .Select(
                                        x =>
                                        {
                                            var ji = x.JumpsInfo ?? new JumpsInfoDto();

                                            ji.Id = x.Id;
                                            ji.Guid = x.Guid;
                                            ji.Address = x.Address;

                                            if (ji.IsGoUp != null && 0 < ji.IsGoUp.Count)
                                                ji.IsGoUp.Sort();
                                            else
                                                ji.IsGoUp = null;

                                            if (x.Jumps != null && 0 < x.Jumps.Count)
                                                ji.Jumps = x.Jumps.ToDictionary(y => y.Key, y => y.Value.OrderBy(z => z.Address).ToList());
                                            else
                                                ji.Jumps = null;

                                            return ji;
                                        }),
                                new JsonSerializerSettings
                                {
                                    Formatting = Formatting.Indented,
                                    DefaultValueHandling = DefaultValueHandling.Ignore
                                });
                            sw.Write(allText);
                            sw.Flush();
                            fs.SetLength(fs.Position);
                        }
                    });
            }
        }

        public MethodInfoDto GetByGuidOrNull(Guid guid)
        {
            lock (_methodByGuid)
            {
                _methodByGuid.TryGetValue(guid, out var method);
                return method;
            }
        }
        
        public MethodInfoDto GetByRawBytes(ArchitectureMode mode, byte[] rawBytes, Address address)
        {
            lock (_methodByGuid)
                return _methodByGuid.Values.FirstOrDefault(x => x.Address == address && x.Mode == mode && x.RawBytes.SequenceEqual(rawBytes));
        }

        public void Add(MethodInfoDto method)
        {
            lock (_methodByGuid)
            {
                var exists = _methodByGuid.Values.Any(
                    x =>
                        x.Guid == method.Guid ||
                        (x.Address == method.Address && x.Mode == method.Mode && x.RawBytes.SequenceEqual(method.RawBytes)));

                if (exists)
                    throw new InvalidOperationException("Duplicated item");

                _methodByGuid.Add(method.Guid, method);
            }

            SetDirty();
        }

        public void AddJumpAndSave(
            MethodInfoDto fromMethod, Address fromAddress,
            MethodInfoDto toMethod, Address toAddress,
            int cSharpFunctionDelta)
        {
            fromAddress -= cSharpFunctionDelta;

            if (Interval.From(
                    fromMethod.Address + cSharpFunctionDelta,
                    fromMethod.Address + cSharpFunctionDelta + fromMethod.RawBytes.Length)
                .Contains(toAddress))
                toAddress -= cSharpFunctionDelta;


            if (fromMethod.Jumps == null)
                fromMethod.Jumps = new Dictionary<Address, HashSet<JumpDestinationInfoDto>>();

            if (!fromMethod.Jumps.TryGetValue(fromAddress, out var tos))
            {
                tos = new HashSet<JumpDestinationInfoDto>();
                fromMethod.Jumps[fromAddress] = tos;
            }

            var added = tos.Add(new JumpDestinationInfoDto { Address = toAddress, Guid = toMethod.Guid });
            if (!added)
            {
                tos.TryGetValue(new JumpDestinationInfoDto { Address = toAddress }, out var actual);

                if (actual.Id != toMethod.Id)
                {
                    actual.Id = toMethod.Id;
                    added = true;
                }

                if (actual.Guid != toMethod.Guid)
                {
                    actual.Guid = toMethod.Guid;
                    added = true;
                }
            }

            if (added && !fromMethod.IgnoreSave)
                Save(methodsJson: false, force: true);
        }

        public void AddExtraRaw(MethodInfoDto methodInfo, Address extraBeginAddress, byte[] extraBytes, int methodOffset)
        {
            var extraInterval = Interval.From(extraBeginAddress, extraBeginAddress + extraBytes.Length);
            var methodInterval = Interval.From(methodInfo.Address + methodOffset, methodInfo.Address + methodOffset + methodInfo.RawBytes.Length);

            var exists = Enumerable.Empty<Interval<Address, Address.Comparer>>().Append(methodInterval);
            if (methodInfo.ExtraRaw != null)
                exists = exists.Concat(methodInfo.ExtraRaw.Select(x => Interval.From(x.Key, x.Key + x.Value.Length / 2)));

            foreach (var interval in extraInterval.Subtract(exists).SelectMany(x => x.Split(methodInterval)))
            {
                if (methodInfo.ExtraRaw == null)
                    methodInfo.ExtraRaw = new Dictionary<Address, string>();

                var raw = new ArraySegment<byte>(extraBytes).Slice(interval.Begin - extraBeginAddress, interval.End - interval.Begin);
                var rawString = HexHelper.ToHexWithoutPrefix(raw);

                methodInfo.ExtraRaw[interval.Begin] = rawString;
                SetDirty();
            }
        }
    }
}