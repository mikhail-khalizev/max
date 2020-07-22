// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
#pragma warning disable IDE1006 // Naming Styles

using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers
{
    public class EflagsRegister : Register
    {
        /// <summary>
        /// Carry flag.
        /// </summary>
        public virtual bool cf
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.cf);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.cf);
        }

        /// <summary>
        /// Parity flag.
        /// </summary>
        public virtual bool pf
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.pf);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.pf);
        }

        /// <summary>
        /// Adjust flag.
        /// </summary>
        public virtual bool af
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.af);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.af);
        }

        /// <summary>
        /// Zero flag.
        /// </summary>
        public virtual bool zf
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.zf);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.zf);
        }

        /// <summary>
        /// Sign flag.
        /// </summary>
        public virtual bool sf
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.sf);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.sf);
        }

        /// <summary>
        /// Trap Flag.
        /// </summary>
        public virtual bool tf
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.tf);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.tf);
        }

        /// <summary>
        /// Interrupt Enable Flag.
        /// </summary>
        public virtual bool @if
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.@if);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.@if);
        }

        /// <summary>
        /// Direction flag.
        /// </summary>
        public virtual bool df
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.df);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.df);
        }

        /// <summary>
        /// Overflow flag.
        /// </summary>
        public virtual bool of
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.of);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.of);
        }

        /// <summary>
        /// I/O Privilege Level.
        /// </summary>
        public virtual int iopl
        {
            get => (int) ((Value & EflagsMask.iopl) >> 12);
            set => Value = (uint) ((Value & ~EflagsMask.iopl) | ((value << 12) & EflagsMask.iopl));
        }

        /// <summary>
        /// Nested Task Flag.
        /// </summary>
        public virtual bool nt
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.nt);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.nt);
        }

        /// <summary>
        /// Resume Flag.
        /// </summary>
        public virtual bool rf
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.rf);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.rf);
        }

        /// <summary>
        /// Virtual-8086 Mode.
        /// </summary>
        public virtual bool vm
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.vm);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.vm);
        }

        /// <summary>
        /// Alignment Check.
        /// </summary>
        public virtual bool ac
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.ac);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.ac);
        }

        /// <summary>
        /// Virtual Interrupt Flag.
        /// </summary>
        public virtual bool vif
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.vif);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.vif);
        }

        /// <summary>
        /// Virtual Interrupt Pending.
        /// </summary>
        public virtual bool vip
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.vip);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.vip);
        }

        /// <summary>
        /// Identification Flag.
        /// </summary>
        /// <remarks>Indicates support for the CPUID instruction.</remarks>
        public virtual bool id
        {
            get => BinaryHelper.IsSetByMask(Value, EflagsMask.id);
            set => BinaryHelper.SetByMask(ref Value, value, EflagsMask.id);
        }


        /// <inheritdoc />
        public override int LengthInBits => 32;
        
        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => Value;
            set => Value = (uint) value;
        }
        protected uint Value;
    }
}