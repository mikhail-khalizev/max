using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d5b5-22fbd0d6")]
        public void Method_0019_d5b5()
        {
            ii(0x19_d5b5, 4); enterw(0x4a, 0);                          /* enter 0x4a, 0x0 */
            ii(0x19_d5b9, 1); pushw(si);                                /* push si */
            ii(0x19_d5ba, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_d5bd, 4); les(si, es, bx + 0x1c);                   /* les si, [es:bx+0x1c] */
            ii(0x19_d5c1, 4); mov(ax, memw_a16[es, si + 0x1c]);         /* mov ax, [es:si+0x1c] */
            ii(0x19_d5c5, 4); mov(dx, memw_a16[es, si + 0x1e]);         /* mov dx, [es:si+0x1e] */
            ii(0x19_d5c9, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x19_d5cc, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x19_d5cf, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_d5d1, 2); if(jnzw(0x19_d5d6, 0x3)) goto l_0x19_d5d6; /* jnz 0xd5d6 */
            ii(0x19_d5d3, 3); jmpw(0x19_d6d1, 0xfb); goto l_0x19_d6d1;  /* jmp 0xd6d1 */
        l_0x19_d5d6:
            ii(0x19_d5d6, 4); pushw(memw_a16[ds, 0x2af8]);              /* push word [0x2af8] */
            ii(0x19_d5da, 4); pushw(memw_a16[ds, 0x2af6]);              /* push word [0x2af6] */
            ii(0x19_d5de, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d5e0, 3); pushw(0x2000);                            /* push 0x2000 */
            ii(0x19_d5e3, 1); pushw(cs);                                /* push cs */
            ii(0x19_d5e4, 3); callw(0x19_d52d, -0xba);                  /* call 0xd52d */
            ii(0x19_d5e7, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_d5ea, 3); mov(memw_a16[ss, bp - 0x46], ax);         /* mov [bp-0x46], ax */
            ii(0x19_d5ed, 3); mov(memw_a16[ss, bp - 0x44], dx);         /* mov [bp-0x44], dx */
            ii(0x19_d5f0, 3); mov(memw_a16[ss, bp - 0x4a], ax);         /* mov [bp-0x4a], ax */
            ii(0x19_d5f3, 3); mov(memw_a16[ss, bp - 0x48], dx);         /* mov [bp-0x48], dx */
            ii(0x19_d5f6, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d5f8, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d5fa, 1); pushw(dx);                                /* push dx */
            ii(0x19_d5fb, 1); pushw(ax);                                /* push ax */
            ii(0x19_d5fc, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d5fe, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x19_d601, 3); callw(0x19_de46, 0x842);                  /* call 0xde46 */
            ii(0x19_d604, 3); mov(memw_a16[ss, bp - 0x42], ax);         /* mov [bp-0x42], ax */
            ii(0x19_d607, 3); mov(memw_a16[ss, bp - 0x40], dx);         /* mov [bp-0x40], dx */
            ii(0x19_d60a, 4); les(bx, ds, 0x2b9a);                      /* les bx, [0x2b9a] */
            ii(0x19_d60e, 5); mov(ax, memw_a16[es, bx + 0x244]);        /* mov ax, [es:bx+0x244] */
            ii(0x19_d613, 3); les(bx, ss, bp - 0x42);                   /* les bx, [bp-0x42] */
            ii(0x19_d616, 5); mov(memw_a16[es, bx + 0xff8], ax);        /* mov [es:bx+0xff8], ax */
            ii(0x19_d61b, 7); mov(memw_a16[es, bx + 0xffa], 0);         /* mov word [es:bx+0xffa], 0x0 */
            ii(0x19_d622, 3); mov(ax, memw_a16[ss, bp - 0x46]);         /* mov ax, [bp-0x46] */
            ii(0x19_d625, 3); mov(dx, memw_a16[ss, bp - 0x44]);         /* mov dx, [bp-0x44] */
            ii(0x19_d628, 3); add(ax, 0xff8);                           /* add ax, 0xff8 */
            ii(0x19_d62b, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x19_d62e, 3); mov(memw_a16[ss, bp - 0x46], ax);         /* mov [bp-0x46], ax */
            ii(0x19_d631, 3); mov(memw_a16[ss, bp - 0x44], dx);         /* mov [bp-0x44], dx */
            ii(0x19_d634, 3); mov(ax, memw_a16[ds, 0x19ea]);            /* mov ax, [0x19ea] */
            ii(0x19_d637, 4); mov(dx, memw_a16[ds, 0x19ec]);            /* mov dx, [0x19ec] */
            ii(0x19_d63b, 3); sub(memw_a16[ss, bp - 0x46], ax);         /* sub [bp-0x46], ax */
            ii(0x19_d63e, 3); sbb(memw_a16[ss, bp - 0x44], dx);         /* sbb [bp-0x44], dx */
            ii(0x19_d641, 1); pushw(es);                                /* push es */
            ii(0x19_d642, 1); pushw(bx);                                /* push bx */
            ii(0x19_d643, 3); callw(0x19_df78, 0x932);                  /* call 0xdf78 */
            ii(0x19_d646, 3); mov(ax, memw_a16[ss, bp - 0x46]);         /* mov ax, [bp-0x46] */
            ii(0x19_d649, 3); mov(dx, memw_a16[ss, bp - 0x44]);         /* mov dx, [bp-0x44] */
            ii(0x19_d64c, 4); mov(es, memw_a16[ds, 0x3fc4]);            /* mov es, [0x3fc4] */
            ii(0x19_d650, 4); mov(memw_a16[es, 0x2b94], ax);            /* mov [es:0x2b94], ax */
            ii(0x19_d654, 5); mov(memw_a16[es, 0x2b96], dx);            /* mov [es:0x2b96], dx */
            ii(0x19_d659, 3); mov(ax, memw_a16[ds, 0x19e8]);            /* mov ax, [0x19e8] */
            ii(0x19_d65c, 4); mov(memw_a16[es, 0x2b98], ax);            /* mov [es:0x2b98], ax */
            ii(0x19_d660, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d662, 1); pushw(ds);                                /* push ds */
            ii(0x19_d663, 3); pushw(0x2a92);                            /* push 0x2a92 */
            ii(0x19_d666, 1); nop();                                    /* nop */
            ii(0x19_d667, 1); pushw(cs);                                /* push cs */
            ii(0x19_d668, 3); callw(0x19_cd5c, -0x90f);                 /* call 0xcd5c */
            ii(0x19_d66b, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_d66e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d670, 2); if(jzw(0x19_d695, 0x23)) goto l_0x19_d695; /* jz 0xd695 */
            ii(0x19_d672, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x19_d675, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x19_d678, 4); pushw(memw_a16[ds, 0x19e4]);              /* push word [0x19e4] */
            ii(0x19_d67c, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x19_d67f, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x19_d682, 3); add(ax, 0xea);                            /* add ax, 0xea */
            ii(0x19_d685, 1); pushw(dx);                                /* push dx */
            ii(0x19_d686, 1); pushw(ax);                                /* push ax */
            ii(0x19_d687, 1); pushw(ds);                                /* push ds */
            ii(0x19_d688, 3); pushw(0x2a9b);                            /* push 0x2a9b */
            ii(0x19_d68b, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x19_d690, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x19_d693, 2); jmpw(0x19_d6c8, 0x33); goto l_0x19_d6c8;  /* jmp 0xd6c8 */
        l_0x19_d695:
            ii(0x19_d695, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x19_d698, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x19_d69b, 4); pushw(memw_a16[ds, 0x19e4]);              /* push word [0x19e4] */
            ii(0x19_d69f, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x19_d6a2, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x19_d6a5, 3); add(ax, 0xea);                            /* add ax, 0xea */
            ii(0x19_d6a8, 1); pushw(dx);                                /* push dx */
            ii(0x19_d6a9, 1); pushw(ax);                                /* push ax */
            ii(0x19_d6aa, 1); pushw(ds);                                /* push ds */
            ii(0x19_d6ab, 3); pushw(0x2ac9);                            /* push 0x2ac9 */
            ii(0x19_d6ae, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x19_d6b3, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x19_d6b6, 4); pushw(memw_a16[ds, 0x19e4]);              /* push word [0x19e4] */
            ii(0x19_d6ba, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x19_d6bd, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x19_d6c0, 1); nop();                                    /* nop */
            ii(0x19_d6c1, 1); pushw(cs);                                /* push cs */
            ii(0x19_d6c2, 3); callw(0x19_d8fa, 0x235);                  /* call 0xd8fa */
            ii(0x19_d6c5, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x19_d6c8:
            ii(0x19_d6c8, 3); pushw(memw_a16[ss, bp - 0x48]);           /* push word [bp-0x48] */
            ii(0x19_d6cb, 3); pushw(memw_a16[ss, bp - 0x4a]);           /* push word [bp-0x4a] */
            ii(0x19_d6ce, 3); callw(0x19_a1c1, -0x3510);                /* call 0xa1c1 */
        l_0x19_d6d1:
            ii(0x19_d6d1, 1); popw(si);                                 /* pop si */
            ii(0x19_d6d2, 1); leavew();                                 /* leave */
            ii(0x19_d6d3, 3); retw(0x4);                                /* ret 0x4 */
        }
    }
}
