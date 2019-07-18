using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ed5f6d1-0219-45ef-a824-3ae9e25daf9d")]
        public void Method_0000_88d5()
        {
            ii(0x88d5, 5);    and(memb_a16[ds, 0x47], -0x3 /* 0xfd */); /* and byte [0x47], 0xfd */
            ii(0x88da, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x88dc, 1);    cwd();                                    /* cwd */
            ii(0x88dd, 1);    leavew();                                 /* leave */
            ii(0x88de, 1);    retw(); return;                           /* ret */
        }
    }
}
