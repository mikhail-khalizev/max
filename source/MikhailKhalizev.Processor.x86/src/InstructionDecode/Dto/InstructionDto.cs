using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    public class InstructionDto
    {
        /// <summary>
        /// A mnemonic is a reserved name for a class of instruction opcodes which have the same function.
        /// </summary>
        public string Mnemonic { get; set; }

        public string UniqueName
        {
            get => _uniqueName ?? Mnemonic.ToLowerInvariant();
            set => _uniqueName = value;
        }

        private string _uniqueName;

        public bool ShouldSerializeUniqueName()
        {
            return UniqueName != Mnemonic.ToLowerInvariant();
        }

        public string Description { get; set; }

        public string Url { get; set; }

        public List<InstructionTableItemDto> Table { get; set; }

        public List<InstructionOperandEncodingItemDto> OperandEncoding { get; set; }

        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}