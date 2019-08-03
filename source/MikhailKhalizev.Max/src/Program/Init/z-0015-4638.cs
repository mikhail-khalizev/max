using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fe166295-e0ba-41eb-bd09-d4266e588353")]
        public void Method_0015_4638()
        {
            ii(0x15_4638, 1); pushw(ds);                                /* push ds */
            ii(0x15_4639, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_463c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_463e, 5); cmp(memw_a16[ds, 0x3b72], 0x1);           /* cmp word [0x3b72], 0x1 */
            ii(0x15_4643, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x15_4645, 2); neg(ax);                                  /* neg ax */
            ii(0x15_4647, 1); popw(ds);                                 /* pop ds */
            ii(0x15_4648, 1); retfw(); return;                          /* retf */
        }
    }
}
