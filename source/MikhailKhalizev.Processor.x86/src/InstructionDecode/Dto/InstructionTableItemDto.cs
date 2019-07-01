namespace MikhailKhalizev.Processor.x86.InstructionDecode.Dto
{
    public class InstructionTableItemDto
    {
        public string Opcode { get; set; }
        public string Instruction { get; set; }
        public string OperandEncoding { get; set; }
        public string Bit64Mode { get; set; }
        public string CompatLegMode { get; set; }
        public string Description { get; set; }
    }
}