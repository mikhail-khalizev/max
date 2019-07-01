

namespace MikhailKhalizev.Processor.x86.Abstractions.Registers
{
    public abstract class Cr4Register
    {
        /// <summary>
        /// Virtual-8086 Mode Extensions.
        /// </summary>
        public abstract bool vme { get; set; }

        /// <summary>
        /// Protected-Mode Virtual Interrupts.
        /// </summary>
        public abstract bool pvi { get; set; }

        /// <summary>
        /// Time Stamp Disable.
        /// </summary>
        public abstract bool tsd { get; set; }

        /// <summary>
        /// Debugging Extensions.
        /// </summary>
        public abstract bool de { get; set; }

        /// <summary>
        /// Page Size Extensions.
        /// </summary>
        public abstract bool pse { get; set; }

        /// <summary>
        /// Physical Address Extension.
        /// </summary>
        public abstract bool pae { get; set; }

        /// <summary>
        /// Machine-Check Enable.
        /// </summary>
        public abstract bool mce { get; set; }

        /// <summary>
        /// Page Global Enable.
        /// </summary>
        public abstract bool pge { get; set; }

        /// <summary>
        /// Performance-Monitoring Counter Enable.
        /// </summary>
        public abstract bool pce { get; set; }

        /// <summary>
        /// Operating System Support for FXSAVE and FXRSTOR instructions.
        /// </summary>
        public abstract bool osfxsr { get; set; }

        /// <summary>
        /// Operating System Support for Unmasked SIMD Floating-Point Exceptions.
        /// </summary>
        public abstract bool osxmmexcpt { get; set; }

        /// <summary>
        /// VMX-Enable Bit.
        /// </summary>
        public abstract bool vmxe { get; set; }

        /// <summary>
        /// SMX-Enable Bit.
        /// </summary>
        public abstract bool smxe { get; set; }

        /// <summary>
        /// FSGSBASE-Enable Bit.
        /// </summary>
        public abstract bool fsgsbase { get; set; }

        /// <summary>
        /// PCID-Enable Bit.
        /// </summary>
        public abstract bool pcide { get; set; }

        /// <summary>
        /// XSAVE and Processor Extended States-Enable Bit.
        /// </summary>
        public abstract bool osxsave { get; set; }

        /// <summary>
        /// SMEP-Enable Bit.
        /// </summary>
        public abstract bool smep { get; set; }
    }
}