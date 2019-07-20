using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.FullSimulate
{
    public class Ia32EferRegisterImpl : Ia32EferRegister
    {
        public override bool sce { get; set; }
        public override bool lme { get; set; }
        public override bool lma { get; set; }
        public override bool nxe { get; set; }
    }
}