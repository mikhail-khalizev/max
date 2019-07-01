using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.FullSimulate
{
    public class SegmentRegisterImpl : SegmentRegister
    {
        public Processor Processor { get; }

        /// <inheritdoc />
        protected override ulong UInt64Internal { get; set; }


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
                return;
            }

            if (IsNull)
            {
                Descriptor = new SegmentDescriptor();
                return;
            }

            Descriptor = Processor.get_orig_desc_ref(Selector);
        }
    }
}