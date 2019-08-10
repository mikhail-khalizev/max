

namespace MikhailKhalizev.Processor.x86.Core.Abstractions.Registers
{
    public class Cr4Register
    {
        /// <summary>
        /// Virtual-8086 Mode Extensions.
        /// </summary>
        public virtual bool vme { get; set; }

        /// <summary>
        /// Protected-Mode Virtual Interrupts.
        /// </summary>
        public virtual bool pvi { get; set; }

        /// <summary>
        /// Time Stamp Disable.
        /// </summary>
        public virtual bool tsd { get; set; }

        /// <summary>
        /// Debugging Extensions.
        /// </summary>
        public virtual bool de { get; set; }

        /// <summary>
        /// Page Size Extensions.
        /// </summary>
        public virtual bool pse { get; set; }

        /// <summary>
        /// Physical Address Extension.
        /// </summary>
        public virtual bool pae { get; set; }

        /// <summary>
        /// Machine-Check Enable.
        /// </summary>
        public virtual bool mce { get; set; }

        /// <summary>
        /// Page Global Enable.
        /// </summary>
        public virtual bool pge { get; set; }

        /// <summary>
        /// Performance-Monitoring Counter Enable.
        /// </summary>
        public virtual bool pce { get; set; }

        /// <summary>
        /// Operating System Support for FXSAVE and FXRSTOR instructions.
        /// </summary>
        public virtual bool osfxsr { get; set; }

        /// <summary>
        /// Operating System Support for Unmasked SIMD Floating-Point Exceptions.
        /// </summary>
        public virtual bool osxmmexcpt { get; set; }

        /// <summary>
        /// VMX-Enable Bit.
        /// </summary>
        public virtual bool vmxe { get; set; }

        /// <summary>
        /// SMX-Enable Bit.
        /// </summary>
        public virtual bool smxe { get; set; }

        /// <summary>
        /// FSGSBASE-Enable Bit.
        /// </summary>
        public virtual bool fsgsbase { get; set; }

        /// <summary>
        /// PCID-Enable Bit.
        /// </summary>
        public virtual bool pcide { get; set; }

        /// <summary>
        /// XSAVE and Processor Extended States-Enable Bit.
        /// </summary>
        public virtual bool osxsave { get; set; }

        /// <summary>
        /// SMEP-Enable Bit.
        /// </summary>
        public virtual bool smep { get; set; }
    }
}