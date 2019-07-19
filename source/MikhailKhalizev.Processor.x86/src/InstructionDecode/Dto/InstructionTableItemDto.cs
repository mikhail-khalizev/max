using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    public class InstructionTableItemDto
    {
        public string Opcode { get; set; } = "";
        public string Instruction { get; set; } = "";
        public string OperandEncoding { get; set; }
        public string Bit64Mode { get; set; }
        public string CompatLegMode { get; set; }
        public string Bit64Bit32ModeSupport { get; set; }
        public string CpuidFeatureFlag { get; set; }
        public string Description { get; set; }
        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}