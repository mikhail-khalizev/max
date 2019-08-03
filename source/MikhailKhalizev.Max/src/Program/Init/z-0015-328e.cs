using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0d80db88-f312-42d3-927c-87a19416024f")]
        public void Method_0015_328e()
        {
            ii(0x15_328e, 1); pushw(bp);                                /* push bp */
            ii(0x15_328f, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_3291, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x15_3294, 5); test(memb_a16[ds, bx + 0x3e4d], 0x2);     /* test byte [bx+0x3e4d], 0x2 */
            ii(0x15_3299, 2); if(jzw(0x15_32a0, 0x5)) goto l_0x15_32a0; /* jz 0x32a0 */
            ii(0x15_329b, 3); lea(ax, bx - 0x20);                       /* lea ax, [bx-0x20] */
            ii(0x15_329e, 2); jmpw(0x15_32a2, 0x2); goto l_0x15_32a2;   /* jmp 0x32a2 */
        l_0x15_32a0:
            ii(0x15_32a0, 2); mov(ax, bx);                              /* mov ax, bx */
        l_0x15_32a2:
            ii(0x15_32a2, 1); popw(bp);                                 /* pop bp */
            ii(0x15_32a3, 1); retfw(); return;                          /* retf */
        }
    }
}
