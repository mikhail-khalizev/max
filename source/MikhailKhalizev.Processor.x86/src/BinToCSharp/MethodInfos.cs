using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class MethodInfos
    {
        private readonly ConfigurationDto _configuration;
        private readonly List<MethodInfoDto> _models;
        private FileStream _outputFileStream;

        public static MethodInfos Load(ConfigurationDto configuration)
        {
            var allText = File.ReadAllText(Path.Combine(configuration.SettingsDirectory, configuration.MethodInfosFile));
            var models = JsonConvert.DeserializeObject<List<MethodInfoDto>>(allText);
            return new MethodInfos(configuration, models);
        }

        private MethodInfos(ConfigurationDto configuration, List<MethodInfoDto> models)
        {
            _configuration = configuration;
            _models = models;
        }

        public void Save()
        {
            var path = Path.Combine(_configuration.SettingsDirectory, _configuration.MethodInfosFile);
            using (var fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            using (var sw = new StreamWriter(fs))
            {
                var allText = JsonConvert.SerializeObject(_models.OrderBy(x => x.Address), Formatting.Indented);
                sw.Write(allText);
                sw.Flush();
                fs.SetLength(fs.Position);
            }
        }
        
        public MethodInfoDto GetByGuid(Guid guid)
        {
            return _models.FirstOrDefault(x => x.Guid == guid);
        }

        public MethodInfoDto GetByRawBytes(byte[] rawBytes)
        {
            return _models.FirstOrDefault(x => x.RawBytes.SequenceEqual(rawBytes));
        }

        public void Add(MethodInfoDto dto)
        {
            if (_models.Any(x => x.Guid == dto.Guid || x.RawBytes.SequenceEqual(dto.RawBytes)))
                throw new InvalidOperationException("Duplicated item");
            _models.Add(dto);
        }
    }
}