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
            var allText = JsonConvert.SerializeObject(_models.OrderBy(x => x.Address), Formatting.Indented);

            if (_outputFileStream != null)
            {
                using (var sw = new StreamWriter(_outputFileStream))
                {
                    sw.Write(allText);
                    _outputFileStream.SetLength(_outputFileStream.Position);
                    _outputFileStream = null;
                }
            }
            else
                File.WriteAllText(Path.Combine(_configuration.SettingsDirectory, _configuration.MethodInfosFile), allText);
        }

        public void OpenFile()
        {
            _outputFileStream = File.Open(
                Path.Combine(_configuration.SettingsDirectory, _configuration.MethodInfosFile),
                FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
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