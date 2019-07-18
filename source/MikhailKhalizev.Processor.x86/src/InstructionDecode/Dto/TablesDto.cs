using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    public class TablesDto
    {
        // 325383-sdm-vol-2abcd.pdf
        // 2.1.3 ModR/M and SIB Bytes.
        // Table 2-1. 16-Bit Addressing Forms with the ModR/M Byte.
        //public string ModRM16Bit { get; set; }

        // Table 2-2. 32-Bit Addressing Forms with the ModR/M Byte.
        //public string ModRM32Bit { get; set; }

        // Table 2-3. 32-Bit Addressing Forms with the SIB Byte.
        //public string SIB32Bit { get; set; }
        
        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}