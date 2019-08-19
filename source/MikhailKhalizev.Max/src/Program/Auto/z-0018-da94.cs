using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_da94-d04f0bae")]
        public void Method_0018_da94()
        {
            ii(0x18_da94, 1); pushw(bp);                                /* push bp */
            ii(0x18_da95, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_da97, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x18_da99, 1); popw(ds);                                 /* pop ds */
            ii(0x18_da9a, 1); pushfw();                                 /* pushfw */
            ii(0x18_da9b, 1); cli();                                    /* cli */
            ii(0x18_da9c, 3); mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x18_da9f, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x18_daa2, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x18_daa5, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x18_daa7, 3); mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
            ii(0x18_daaa, 3); mov(memb_a16[ds, bx + 0x5], al);          /* mov [bx+0x5], al */
            ii(0x18_daad, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x18_dab0, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x18_dab3, 3); mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0x18_dab6:
            ii(0x18_dab6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x18_dab8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x18_daba, 2); if(loopw_a16(0x18_dab6, -0x6)) goto l_0x18_dab6; /* loop 0xdab6 */
            ii(0x18_dabc, 3); mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x18_dabf, 3); mov(memb_a16[ds, bx + 0x4], dl);          /* mov [bx+0x4], dl */
            ii(0x18_dac2, 3); mov(memb_a16[ds, bx + 0x7], dh);          /* mov [bx+0x7], dh */
            ii(0x18_dac5, 1); popw(dx);                                 /* pop dx */
            ii(0x18_dac6, 1); popw(bp);                                 /* pop bp */
            ii(0x18_dac7, 1); popw(ax);                                 /* pop ax */
            ii(0x18_dac8, 2); mov(cx, ss);                              /* mov cx, ss */
            ii(0x18_daca, 2); mov(ss, cx);                              /* mov ss, cx */
            ii(0x18_dacc, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x18_dace, 1); popw(ds);                                 /* pop ds */
            ii(0x18_dacf, 1); pushw(dx);                                /* push dx */
            ii(0x18_dad0, 1); popfw();                                  /* popfw */
            ii(0x18_dad1, 2); if(jmpw_abs(ax)) return;                  /* jmp ax */
        }
    }
}
