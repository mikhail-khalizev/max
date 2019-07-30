using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Core
{
    public class EflagsRegisterImpl : EflagsRegister
    {
        public override bool cf { get; set; }
        public override bool pf { get; set; }
        public override bool af { get; set; }
        public override bool zf { get; set; }
        public override bool sf { get; set; }
        public override bool tf { get; set; }
        public override bool @if { get; set; }
        public override bool df { get; set; }
        public override bool of { get; set; }
        public override int iopl { get; set; }
        public override bool nt { get; set; }
        public override bool rf { get; set; }
        public override bool vm { get; set; }
        public override bool ac { get; set; }
        public override bool vif { get; set; }
        public override bool vip { get; set; }
        public override bool id { get; set; }
    }
}