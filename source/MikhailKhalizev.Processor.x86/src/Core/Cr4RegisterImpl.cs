using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.FullSimulate
{
    public class Cr4RegisterImpl : Cr4Register
    {
        public override bool smep { get; set; }
        public override bool osxsave { get; set; }
        public override bool pcide { get; set; }
        public override bool fsgsbase { get; set; }
        public override bool smxe { get; set; }
        public override bool vmxe { get; set; }
        public override bool osxmmexcpt { get; set; }
        public override bool osfxsr { get; set; }
        public override bool pce { get; set; }
        public override bool pge { get; set; }
        public override bool mce { get; set; }
        public override bool pae { get; set; }
        public override bool pse { get; set; }
        public override bool de { get; set; }
        public override bool tsd { get; set; }
        public override bool pvi { get; set; }
        public override bool vme { get; set; }
    };
}