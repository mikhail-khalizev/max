using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    public class TablesDto
    {
        public string ModRM16Bit { get; set; }
        public string ModRM32Bit { get; set; }
        public string SIB32Bit { get; set; }

        // 253665-sdm-vol-1.pdf. APPENDIX A EFLAGS CROSS-REFERENCE.
        public string EflagsCrossReference { get; set; }

        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}