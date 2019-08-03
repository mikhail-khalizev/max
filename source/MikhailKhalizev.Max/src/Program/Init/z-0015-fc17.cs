using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7205c515-f77c-4312-b968-fa8c6949794f")]
        public void Method_0015_fc17()
        {
            ii(0x15_fc17, 1); pushw(bp);                                /* push bp */
            ii(0x15_fc18, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fc1a, 1); pushw(ds);                                /* push ds */
            ii(0x15_fc1b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fc1e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fc20, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_fc23, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_fc26, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_fc29, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_fc2c, 3); callw(0x15_fbdb, -0x54);                  /* call 0xfbdb */
            ii(0x15_fc2f, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fc30, 1); leavew();                                 /* leave */
            ii(0x15_fc31, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
