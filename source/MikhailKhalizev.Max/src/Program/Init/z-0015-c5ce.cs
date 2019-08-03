using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("05ab552f-df9d-4259-ae00-1b99564713eb")]
        public void Method_0015_c5ce()
        {
            ii(0x15_c5ce, 1); pushw(bp);                                /* push bp */
            ii(0x15_c5cf, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_c5d1, 4); cmp(memw_a16[ss, bp + 0x8], 0);           /* cmp word [bp+0x8], 0x0 */
            ii(0x15_c5d5, 2); if(jlw(0x15_c64f, 0x78)) goto l_0x15_c64f; /* jl 0xc64f */
            ii(0x15_c5d7, 2); pushw(0x7b);                              /* push 0x7b */
            ii(0x15_c5d9, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_c5dc, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x15_c5df, 3); add(ax, 0x72);                            /* add ax, 0x72 */
            ii(0x15_c5e2, 1); pushw(dx);                                /* push dx */
            ii(0x15_c5e3, 1); pushw(ax);                                /* push ax */
            ii(0x15_c5e4, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_c5e7, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x15_c5ea, 3); add(ax, 0x5);                             /* add ax, 0x5 */
            ii(0x15_c5ed, 1); pushw(dx);                                /* push dx */
            ii(0x15_c5ee, 1); pushw(ax);                                /* push ax */
            ii(0x15_c5ef, 5); callw_far_abs(0x80, 0x44ba);              /* call word 0x80:0x44ba */
            ii(0x15_c5f4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_c5f6, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_c5f9, 4); mov(memb_a16[es, bx], 0x24);              /* mov byte [es:bx], 0x24 */
            ii(0x15_c5fd, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x15_c600, 3); sar(bx, 0xc);                             /* sar bx, 0xc */
            ii(0x15_c603, 3); and(bx, 0xf);                             /* and bx, 0xf */
            ii(0x15_c606, 4); mov(al, memb_a16[ds, bx + 0x2764]);       /* mov al, [bx+0x2764] */
            ii(0x15_c60a, 3); mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x15_c60d, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
            ii(0x15_c611, 2); mov(cl, 0x8);                             /* mov cl, 0x8 */
            ii(0x15_c613, 3); mov(bh, memb_a16[ss, bp + 0x9]);          /* mov bh, [bp+0x9] */
            ii(0x15_c616, 4); and(bx, 0xf00);                           /* and bx, 0xf00 */
            ii(0x15_c61a, 2); sar(bx, cl);                              /* sar bx, cl */
            ii(0x15_c61c, 4); mov(al, memb_a16[ds, bx + 0x2764]);       /* mov al, [bx+0x2764] */
            ii(0x15_c620, 3); mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x15_c623, 4); mov(memb_a16[es, bx + 0x2], al);          /* mov [es:bx+0x2], al */
            ii(0x15_c627, 3); mov(bl, memb_a16[ss, bp + 0x8]);          /* mov bl, [bp+0x8] */
            ii(0x15_c62a, 4); and(bx, 0xf0);                            /* and bx, 0xf0 */
            ii(0x15_c62e, 3); sar(bx, 0x4);                             /* sar bx, 0x4 */
            ii(0x15_c631, 4); mov(al, memb_a16[ds, bx + 0x2764]);       /* mov al, [bx+0x2764] */
            ii(0x15_c635, 3); mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x15_c638, 4); mov(memb_a16[es, bx + 0x3], al);          /* mov [es:bx+0x3], al */
            ii(0x15_c63c, 3); mov(bl, memb_a16[ss, bp + 0x8]);          /* mov bl, [bp+0x8] */
            ii(0x15_c63f, 3); and(bx, 0xf);                             /* and bx, 0xf */
            ii(0x15_c642, 4); mov(al, memb_a16[ds, bx + 0x2764]);       /* mov al, [bx+0x2764] */
            ii(0x15_c646, 3); mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x15_c649, 4); mov(memb_a16[es, bx + 0x4], al);          /* mov [es:bx+0x4], al */
            ii(0x15_c64d, 2); jmpw(0x15_c677, 0x28); goto l_0x15_c677;  /* jmp 0xc677 */
        l_0x15_c64f:
            ii(0x15_c64f, 2); pushw(0x7f);                              /* push 0x7f */
            ii(0x15_c651, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_c654, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x15_c657, 3); add(ax, 0x72);                            /* add ax, 0x72 */
            ii(0x15_c65a, 1); pushw(dx);                                /* push dx */
            ii(0x15_c65b, 1); pushw(ax);                                /* push ax */
            ii(0x15_c65c, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_c65f, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x15_c662, 1); inc(ax);                                  /* inc ax */
            ii(0x15_c663, 1); pushw(dx);                                /* push dx */
            ii(0x15_c664, 1); pushw(ax);                                /* push ax */
            ii(0x15_c665, 5); callw_far_abs(0x80, 0x44ba);              /* call word 0x80:0x44ba */
            ii(0x15_c66a, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_c66c, 2); mov(al, 0x41);                            /* mov al, 0x41 */
            ii(0x15_c66e, 3); sub(al, memb_a16[ss, bp + 0x8]);          /* sub al, [bp+0x8] */
            ii(0x15_c671, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_c674, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
        l_0x15_c677:
            ii(0x15_c677, 1); pushw(es);                                /* push es */
            ii(0x15_c678, 1); pushw(bx);                                /* push bx */
            ii(0x15_c679, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x15_c67e, 1); popw(bx);                                 /* pop bx */
            ii(0x15_c67f, 1); popw(bx);                                 /* pop bx */
            ii(0x15_c680, 1); leavew();                                 /* leave */
            ii(0x15_c681, 3); retw(0xa); return;                        /* ret 0xa */
        }
    }
}
