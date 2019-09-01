using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor
{
    public class SegmentRegisterImpl : SegmentRegister
    {
        public Cpu Cpu { get; }

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => (ulong)_selector;
            set
            {
                _selector = (int) value;
                LoadDescriptor();
            }
        }
        private int _selector;

        /// <inheritdoc />
        public override int RPL
        {
            get => _rpl;
            set
            {
                _rpl = value;
                _selector = ((_selector & ~0b0011) | (_rpl & 0b0011));
            }
        }
        private int _rpl;


        public bool In64BitMode => l && !db && Cpu.InIa32eMode;
        public bool InCompatibilityMode => !l && Cpu.InIa32eMode;

        public SegmentRegisterImpl(Cpu cpu)
        {
            Cpu = cpu;
        }

        private void LoadDescriptor()
        {
            if (Cpu.cr0.pe == false)
            {
                Descriptor.Base = (uint)(Selector * 16);
                _rpl = 0;
                return;
            }

            _rpl = _selector & 0b0011;

            if (IsNull)
            {
                Descriptor = new SegmentDescriptor();
                return;
            }

            Descriptor = Cpu.get_orig_desc_ref(Selector);
        }
    }
}