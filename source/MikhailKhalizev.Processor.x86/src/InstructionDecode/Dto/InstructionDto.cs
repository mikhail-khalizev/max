using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    [DebuggerDisplay("Title = {Title}")]
    public class InstructionDto
    {
        [JsonIgnore]
        public string Title => $"{Mnemonics} - {Summary}";

        public string Mnemonics { get; set; }
        
        public string Summary { get; set; }
        
        public string Url { get; set; }

        /// <summary>
        /// Page number in Intel documentation <see cref="DocumentationFile"/>.
        /// </summary>
        public int PageNumber { get; set; }

        [JsonIgnore]
        public const string DocumentationFile = "325383-sdm-vol-2abcd.pdf";

        public List<InstructionItemDto> Items { get; set; }

        public List<OperandEncodingDto> OperandEncoding { get; set; }

        [JsonExtensionData]
        private IDictionary<string, JToken> AdditionalData { get; set; }
    }
}