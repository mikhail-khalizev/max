using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.FullSimulate
{
    public class Cr0RegisterImpl : Cr0Register
    {
        public override bool pe { get; set; }
        public override bool pg { get; set; }
        public override bool cd { get; set; }
        public override bool nw { get; set; }
        public override bool am { get; set; }
        public override bool wp { get; set; }
        public override bool ne { get; set; }
        public override bool et { get; set; }
        public override bool ts { get; set; }
        public override bool em { get; set; }
        public override bool mp { get; set; }
    };
}