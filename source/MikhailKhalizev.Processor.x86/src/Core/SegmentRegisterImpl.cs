using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Core
{
    public class SegmentRegisterImpl : SegmentRegister
    {
        public Processor Processor { get; }

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => _uInt64Internal;
            set
            {
                _uInt64Internal = value;
                LoadDescriptor();
            }
        }
        private ulong _uInt64Internal;

        /// <inheritdoc />
        public override uint RPL
        {
            get => _rpl;
            set
            {
                _rpl = value;
                _uInt64Internal = (ushort) ((_uInt64Internal & ~0b0011u) | (_rpl & 0b0011u));
            }
        }
        private uint _rpl;


        public bool In64BitMode => Processor.InIa32eMode && l && !db;
        public bool InCompatibilityMode => Processor.InIa32eMode && !l;

        public SegmentRegisterImpl(Processor processor)
        {
            Processor = processor;
        }

        protected override void LoadDescriptor()
        {
            if (Processor.cr0.pe == false)
            {
                Descriptor.Base = Selector * 16u;
                _rpl = 0;
                return;
            }

            _rpl = (uint)_uInt64Internal & 0b0011u;

            if (IsNull)
            {
                Descriptor = new SegmentDescriptor();
                return;
            }

            Descriptor = Processor.get_orig_desc_ref(Selector);
        }
    }
}