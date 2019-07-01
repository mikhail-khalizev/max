

namespace MikhailKhalizev.Processor.x86.Abstractions.Registers
{
    public abstract class Cr0Register : Register
    {
        /// <summary>
        /// Paging.
        /// </summary>
        public abstract bool pg { get; set; }

        /// <summary>
        /// Cache Disable.
        /// </summary>
        public abstract bool cd { get; set; }

        /// <summary>
        /// Not Write-through.
        /// </summary>
        public abstract bool nw { get; set; }

        /// <summary>
        /// Alignment Mask.
        /// </summary>
        public abstract bool am { get; set; }

        /// <summary>
        /// Write Protect.
        /// </summary>
        public abstract bool wp { get; set; }

        /// <summary>
        /// Numeric Error.
        /// </summary>
        public abstract bool ne { get; set; }

        /// <summary>
        /// Extension Type.
        /// </summary>
        public abstract bool et { get; set; }

        /// <summary>
        /// Task Switched.
        /// </summary>
        public abstract bool ts { get; set; }

        /// <summary>
        /// Emulation.
        /// </summary>
        public abstract bool em { get; set; }

        /// <summary>
        /// Monitor Coprocessor.
        /// </summary>
        public abstract bool mp { get; set; }

        /// <summary>
        /// Protection Enable.
        /// </summary>
        public abstract bool pe { get; set; }


        /// <inheritdoc />
        public override int Bits => 32;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get
            {
                ulong ret = 0;

                ret |= pe ? 0x1 : 0u;
                ret |= mp ? 0x2 : 0u;
                ret |= em ? 0x4 : 0u;
                ret |= ts ? 0x8 : 0u;
                ret |= et ? 0x10 : 0u;
                ret |= ne ? 0x20 : 0u;

                ret |= wp ? (1 << 16) : 0u;
                ret |= am ? (1 << 18) : 0u;

                ret |= nw ? (1 << 29) : 0u;
                ret |= cd ? (1 << 30) : 0u;
                ret |= pg ? (1u << 31) : 0u;

                return ret;
            }
            set
            {
                pe = (value & 0x1) != 0;
                mp = (value & 0x2) != 0;
                em = (value & 0x4) != 0;
                ts = (value & 0x8) != 0;
                et = (value & 0x10) != 0;
                ne = (value & 0x20) != 0;

                wp = (value & (1 << 16)) != 0;
                am = (value & (1 << 18)) != 0;

                nw = (value & (1 << 29)) != 0;
                cd = (value & (1 << 30)) != 0;
                pg = (value & (1u << 31)) != 0;
            }
        }
    }
}