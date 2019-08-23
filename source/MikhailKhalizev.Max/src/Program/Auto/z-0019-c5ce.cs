using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c5ce-3ec6f9ea")]
        public void Method_0019_c5ce()
        {
            ii(0x19_c5ce, 1); push(bp);                                 /* push bp */
            ii(0x19_c5cf, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_c5d1, 4); cmp(memw[ss, bp + 0x8], 0);               /* cmp word [bp+0x8], 0x0 */
            ii(0x19_c5d5, 2); if(jl(0x19_c64f, 0x78)) goto l_0x19_c64f; /* jl 0xc64f */
            ii(0x19_c5d7, 2); push(0x7b);                               /* push 0x7b */
            ii(0x19_c5d9, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x19_c5dc, 3); mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
            ii(0x19_c5df, 3); add(ax, 0x72);                            /* add ax, 0x72 */
            ii(0x19_c5e2, 1); push(dx);                                 /* push dx */
            ii(0x19_c5e3, 1); push(ax);                                 /* push ax */
            ii(0x19_c5e4, 3); mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x19_c5e7, 3); mov(dx, memw[ss, bp + 0x6]);              /* mov dx, [bp+0x6] */
            ii(0x19_c5ea, 3); add(ax, 0x5);                             /* add ax, 0x5 */
            ii(0x19_c5ed, 1); push(dx);                                 /* push dx */
            ii(0x19_c5ee, 1); push(ax);                                 /* push ax */
            ii(0x19_c5ef, 5); call_far_abs(0x80, 0x44ba);               /* call word 0x80:0x44ba */
            ii(0x19_c5f4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_c5f6, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_c5f9, 4); mov(memb[es, bx], 0x24);                  /* mov byte [es:bx], 0x24 */
            ii(0x19_c5fd, 3); mov(bx, memw[ss, bp + 0x8]);              /* mov bx, [bp+0x8] */
            ii(0x19_c600, 3); sar(bx, 0xc);                             /* sar bx, 0xc */
            ii(0x19_c603, 3); and(bx, 0xf);                             /* and bx, 0xf */
            ii(0x19_c606, 4); mov(al, memb[ds, bx + 0x2764]);           /* mov al, [bx+0x2764] */
            ii(0x19_c60a, 3); mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x19_c60d, 4); mov(memb[es, bx + 0x1], al);              /* mov [es:bx+0x1], al */
            ii(0x19_c611, 2); mov(cl, 0x8);                             /* mov cl, 0x8 */
            ii(0x19_c613, 3); mov(bh, memb[ss, bp + 0x9]);              /* mov bh, [bp+0x9] */
            ii(0x19_c616, 4); and(bx, 0xf00);                           /* and bx, 0xf00 */
            ii(0x19_c61a, 2); sar(bx, cl);                              /* sar bx, cl */
            ii(0x19_c61c, 4); mov(al, memb[ds, bx + 0x2764]);           /* mov al, [bx+0x2764] */
            ii(0x19_c620, 3); mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x19_c623, 4); mov(memb[es, bx + 0x2], al);              /* mov [es:bx+0x2], al */
            ii(0x19_c627, 3); mov(bl, memb[ss, bp + 0x8]);              /* mov bl, [bp+0x8] */
            ii(0x19_c62a, 4); and(bx, 0xf0);                            /* and bx, 0xf0 */
            ii(0x19_c62e, 3); sar(bx, 0x4);                             /* sar bx, 0x4 */
            ii(0x19_c631, 4); mov(al, memb[ds, bx + 0x2764]);           /* mov al, [bx+0x2764] */
            ii(0x19_c635, 3); mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x19_c638, 4); mov(memb[es, bx + 0x3], al);              /* mov [es:bx+0x3], al */
            ii(0x19_c63c, 3); mov(bl, memb[ss, bp + 0x8]);              /* mov bl, [bp+0x8] */
            ii(0x19_c63f, 3); and(bx, 0xf);                             /* and bx, 0xf */
            ii(0x19_c642, 4); mov(al, memb[ds, bx + 0x2764]);           /* mov al, [bx+0x2764] */
            ii(0x19_c646, 3); mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x19_c649, 4); mov(memb[es, bx + 0x4], al);              /* mov [es:bx+0x4], al */
            ii(0x19_c64d, 2); jmp(0x19_c677, 0x28); goto l_0x19_c677;   /* jmp 0xc677 */
        l_0x19_c64f:
            ii(0x19_c64f, 2); push(0x7f);                               /* push 0x7f */
            ii(0x19_c651, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x19_c654, 3); mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
            ii(0x19_c657, 3); add(ax, 0x72);                            /* add ax, 0x72 */
            ii(0x19_c65a, 1); push(dx);                                 /* push dx */
            ii(0x19_c65b, 1); push(ax);                                 /* push ax */
            ii(0x19_c65c, 3); mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x19_c65f, 3); mov(dx, memw[ss, bp + 0x6]);              /* mov dx, [bp+0x6] */
            ii(0x19_c662, 1); inc(ax);                                  /* inc ax */
            ii(0x19_c663, 1); push(dx);                                 /* push dx */
            ii(0x19_c664, 1); push(ax);                                 /* push ax */
            ii(0x19_c665, 5); call_far_abs(0x80, 0x44ba);               /* call word 0x80:0x44ba */
            ii(0x19_c66a, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_c66c, 2); mov(al, 0x41);                            /* mov al, 0x41 */
            ii(0x19_c66e, 3); sub(al, memb[ss, bp + 0x8]);              /* sub al, [bp+0x8] */
            ii(0x19_c671, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_c674, 3); mov(memb[es, bx], al);                    /* mov [es:bx], al */
        l_0x19_c677:
            ii(0x19_c677, 1); push(es);                                 /* push es */
            ii(0x19_c678, 1); push(bx);                                 /* push bx */
            ii(0x19_c679, 5); call_far_abs(0x80, 0x4508);               /* call word 0x80:0x4508 */
            ii(0x19_c67e, 1); pop(bx);                                  /* pop bx */
            ii(0x19_c67f, 1); pop(bx);                                  /* pop bx */
            ii(0x19_c680, 1); leave();                                  /* leave */
            ii(0x19_c681, 3); ret(0xa);                                 /* ret 0xa */
        }
    }
}
