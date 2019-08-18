using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_55f0-9a75181e")]
        public void Method_0017_55f0()
        {
            ii(0x17_55f0, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x17_55f4, 1); pushw(ds);                                /* push ds */
            ii(0x17_55f5, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_55f8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_55fa, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x17_55fc, 3); cmp(ax, memw_a16[ss, bp + 0x6]);          /* cmp ax, [bp+0x6] */
            ii(0x17_55ff, 2); if(jzw(0x17_5605, 0x4)) goto l_0x17_5605; /* jz 0x5605 */
            ii(0x17_5601, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_5603, 2); mov(es, ax);                              /* mov es, ax */
        l_0x17_5605:
            ii(0x17_5605, 5); mov(memw_a16[ss, bp - 0x2], 0x8);         /* mov word [bp-0x2], 0x8 */
            ii(0x17_560a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_560d, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_5610, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_5613, 4); mov(al, memb_a16[es, bx + 0x5]);          /* mov al, [es:bx+0x5] */
            ii(0x17_5617, 2); and(al, 0xe9);                            /* and al, 0xe9 */
            ii(0x17_5619, 2); or(al, 0x9);                              /* or al, 0x9 */
            ii(0x17_561b, 4); mov(memb_a16[es, bx + 0x5], al);          /* mov [es:bx+0x5], al */
            ii(0x17_561f, 1); popw(ds);                                 /* pop ds */
            ii(0x17_5620, 1); leavew();                                 /* leave */
            ii(0x17_5621, 1); retfw(); return;                          /* retf */
        }
    }
}
