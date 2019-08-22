

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers
{
    public abstract class Ia32EferRegister
    {
        /// <summary>
        /// SYSCALL Enable.
        /// </summary>
        /// <remarks>Enables SYSCALL/SYSRET instructions in 64-bit mode.</remarks>
        public abstract bool sce { get; set; }

        /// <summary>
        /// IA-32e Mode Enable.
        /// </summary>
        /// <remarks>Enables IA-32e mode operation.</remarks>
        public abstract bool lme { get; set; }

        /// <summary>
        /// IA-32e Mode Active.
        /// </summary>
        /// <remarks>Indicates IA-32e mode is active when set.</remarks>
        public abstract bool lma { get; set; }

        /// <summary>
        /// Execute Disable Bit Enable.
        /// </summary>
        /// <remarks>Enables page access restriction by preventing instruction fetches from PAE pages with the XD bit set.</remarks>
        public abstract bool nxe { get; set; }
    }
}