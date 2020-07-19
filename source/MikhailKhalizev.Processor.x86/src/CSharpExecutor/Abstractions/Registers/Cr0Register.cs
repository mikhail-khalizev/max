

using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers
{
    public class Cr0Register : Register
    {
        /// <summary>
        /// Paging.
        /// </summary>
        public virtual bool pg
        {
            get => BinaryHelper.IsSet(Value, 31);
            set => BinaryHelper.Set(ref Value, value, 31);
        }

        /// <summary>
        /// Cache Disable.
        /// </summary>
        public virtual bool cd
        {
            get => BinaryHelper.IsSet(Value, 30);
            set => BinaryHelper.Set(ref Value, value, 30);
        }

        /// <summary>
        /// Not Write-through.
        /// </summary>
        public virtual bool nw
        {
            get => BinaryHelper.IsSet(Value, 29);
            set => BinaryHelper.Set(ref Value, value, 29);
        }

        /// <summary>
        /// Alignment MaskUInt64.
        /// </summary>
        public virtual bool am
        {
            get => BinaryHelper.IsSet(Value, 18);
            set => BinaryHelper.Set(ref Value, value, 18);
        }

        /// <summary>
        /// Write Protect.
        /// </summary>
        public virtual bool wp
        {
            get => BinaryHelper.IsSet(Value, 16);
            set => BinaryHelper.Set(ref Value, value, 16);
        }

        /// <summary>
        /// Numeric Error.
        /// </summary>
        public virtual bool ne
        {
            get => BinaryHelper.IsSet(Value, 5);
            set => BinaryHelper.Set(ref Value, value, 5);
        }

        /// <summary>
        /// Extension Type.
        /// </summary>
        public virtual bool et
        {
            get => BinaryHelper.IsSet(Value, 4);
            set => BinaryHelper.Set(ref Value, value, 4);
        }

        /// <summary>
        /// Task Switched.
        /// </summary>
        public virtual bool ts
        {
            get => BinaryHelper.IsSet(Value, 3);
            set => BinaryHelper.Set(ref Value, value, 3);
        }

        /// <summary>
        /// Emulation.
        /// </summary>
        public virtual bool em
        {
            get => BinaryHelper.IsSet(Value, 2);
            set => BinaryHelper.Set(ref Value, value, 2);
        }

        /// <summary>
        /// Monitor Coprocessor.
        /// </summary>
        public virtual bool mp
        {
            get => BinaryHelper.IsSet(Value, 1);
            set => BinaryHelper.Set(ref Value, value, 1);
        }

        /// <summary>
        /// Protection Enable.
        /// </summary>
        public virtual bool pe
        {
            get => BinaryHelper.IsSet(Value, 0);
            set => BinaryHelper.Set(ref Value, value, 0);
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