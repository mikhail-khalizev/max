namespace MikhailKhalizev.Processor.x86.Core.Abstractions.Registers
{
    public abstract class EflagsRegister : Register
    {
        /// <summary>
        /// Carry flag.
        /// </summary>
        public abstract bool cf { get; set; }

        /// <summary>
        /// Parity flag.
        /// </summary>
        public abstract bool pf { get; set; }

        /// <summary>
        /// Adjust flag.
        /// </summary>
        public abstract bool af { get; set; }

        /// <summary>
        /// Zero flag.
        /// </summary>
        public abstract bool zf { get; set; }

        /// <summary>
        /// Sign flag.
        /// </summary>
        public abstract bool sf { get; set; }

        /// <summary>
        /// Trap Flag.
        /// </summary>
        public abstract bool tf { get; set; }

        /// <summary>
        /// Interrupt Enable Flag.
        /// </summary>
        public abstract bool @if { get; set; }

        /// <summary>
        /// Direction flag.
        /// </summary>
        public abstract bool df { get; set; }

        /// <summary>
        /// Overflow flag.
        /// </summary>
        public abstract bool of { get; set; }

        /// <summary>
        /// I/O Privilege Level.
        /// </summary>
        public abstract int iopl { get; set; }

        /// <summary>
        /// Nested Task Flag.
        /// </summary>
        public abstract bool nt { get; set; }

        /// <summary>
        /// Resume Flag.
        /// </summary>
        public abstract bool rf { get; set; }

        /// <summary>
        /// Virtual-8086 Mode.
        /// </summary>
        public abstract bool vm { get; set; }

        /// <summary>
        /// Alignment Check.
        /// </summary>
        public abstract bool ac { get; set; }

        /// <summary>
        /// Virtual Interrupt Flag.
        /// </summary>
        public abstract bool vif { get; set; }

        /// <summary>
        /// Virtual Interrupt Pending.
        /// </summary>
        public abstract bool vip { get; set; }

        /// <summary>
        /// Identification Flag.
        /// </summary>
        /// <remarks>Indicates support for the CPUID instruction.</remarks>
        public abstract bool id { get; set; }


        /// <inheritdoc />
        public override int Bits => 32;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get
            {
                uint ret = 0;

                ret |= cf ? EflagsMask.cf : 0;
                ret |= 0x02; // Always set.
                ret |= pf ? EflagsMask.pf : 0;

                ret |= af ? EflagsMask.af : 0;
                ret |= zf ? EflagsMask.zf : 0;
                ret |= sf ? EflagsMask.sf : 0;

                ret |= tf ? EflagsMask.tf : 0;
                ret |= @if ? EflagsMask.@if : 0;
                ret |= df ? EflagsMask.df : 0;
                ret |= of ? EflagsMask.of : 0;

                ret |= (uint)(iopl << 12) & EflagsMask.iopl;
                ret |= nt ? EflagsMask.nt : 0;

                ret |= rf ? EflagsMask.rf : 0;
                ret |= vm ? EflagsMask.vm : 0;
                ret |= ac ? EflagsMask.ac : 0;
                ret |= vif ? EflagsMask.vif : 0;

                ret |= vip ? EflagsMask.vip : 0;
                ret |= id ? EflagsMask.id : 0;

                return ret;
            }
            set
            {
                cf = (value & EflagsMask.cf) != 0;
                pf = (value & EflagsMask.pf) != 0;

                af = (value & EflagsMask.af) != 0;
                zf = (value & EflagsMask.zf) != 0;
                sf = (value & EflagsMask.sf) != 0;

                tf = (value & EflagsMask.tf) != 0;
                @if = (value & EflagsMask.@if) != 0;
                df = (value & EflagsMask.df) != 0;
                of = (value & EflagsMask.of) != 0;

                iopl = (int) ((value & EflagsMask.iopl) >> 12);
                nt = (value & EflagsMask.nt) != 0;

                rf = (value & EflagsMask.rf) != 0;
                vm = (value & EflagsMask.vm) != 0;
                ac = (value & EflagsMask.ac) != 0;
                vif = (value & EflagsMask.vif) != 0;

                vip = (value & EflagsMask.vip) != 0;
                id = (value & EflagsMask.id) != 0;
            }
        }
    }
}