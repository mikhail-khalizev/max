using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Decoder.Dto
{
    public class OperandEncodingDto
    {
        public string OperandEncoding { get; set; }
        public List<string> Operands { get; set; }
    }
}