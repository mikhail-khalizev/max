using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    public class InstructionDto
    {
        public string Mnemonics { get; set; }
        
        public string Summary { get; set; }
        
        public string Url { get; set; }

        public List<InstructionItemDto> Items { get; set; }

        public List<OperandEncodingDto> OperandEncoding { get; set; }

        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}