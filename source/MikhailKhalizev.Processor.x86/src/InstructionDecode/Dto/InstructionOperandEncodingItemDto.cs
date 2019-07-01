using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    public class InstructionOperandEncodingItemDto
    {
        public string OperandEncoding { get; set; }
        public List<string> Operands { get; set; }
    }
}