using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    public class DecodeDto
    {
        public List<InstructionDto> Instructions { get; set; }

        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}