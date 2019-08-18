using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4b70-196815fc")]
        public void Method_0019_4b70()
        {
            ii(0x19_4b70, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x19_4b74, 1); pushw(ds);                                /* push ds */
            ii(0x19_4b75, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_4b78, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_4b7a, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_4b7d, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_4b80, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_4b82, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
        l_0x19_4b84:
            ii(0x19_4b84, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x19_4b86, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x19_4b88, 2); dec(cl);                                  /* dec cl */
            ii(0x19_4b8a, 2); if(jnzw(0x19_4b84, -0x8)) goto l_0x19_4b84; /* jnz 0x4b84 */
            ii(0x19_4b8c, 3); add(ax, memw_a16[ss, bp + 0x6]);          /* add ax, [bp+0x6] */
            ii(0x19_4b8f, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x19_4b92, 1); pushw(dx);                                /* push dx */
            ii(0x19_4b93, 1); pushw(ax);                                /* push ax */
            ii(0x19_4b94, 1); pushw(cs);                                /* push cs */
            ii(0x19_4b95, 3); callw(0x19_4abc, -0xdc);                  /* call 0x4abc */
            ii(0x19_4b98, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_4b9b, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4b9c, 1); leavew();                                 /* leave */
            ii(0x19_4b9d, 1); retfw(); return;                          /* retf */
        //  ii(0x19_4b9e, 50); Недостижимый (и не декодированный) код.
        //    ii(0x19_4bd0, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
        //    ii(0x19_4bd4, 1); pushw(ds);                                /* push ds */
        //    ii(0x19_4bd5, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
        //    ii(0x19_4bd8, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x19_4bda, 5); cmp(memw_a16[ds, 0x3b72], 0);             /* cmp word [0x3b72], 0x0 */
        //    ii(0x19_4bdf, 2); if(jnzw(0x19_4c0a, 0x29)) goto l_0x19_4c0a; /* jnz 0x4c0a */
        //    ii(0x19_4be1, 5); mov(memw_a16[ss, bp - 0x4], 0x1);         /* mov word [bp-0x4], 0x1 */
        //    ii(0x19_4be6, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4be8, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4bea, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
        //    ii(0x19_4bed, 1); pushw(ss);                                /* push ss */
        //    ii(0x19_4bee, 1); pushw(ax);                                /* push ax */
        //    ii(0x19_4bef, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4bf1, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4bf3, 1); nop();                                    /* nop */
        //    ii(0x19_4bf4, 1); pushw(cs);                                /* push cs */
        //    ii(0x19_4bf5, 3); callw(0x19_41fd, -0x9fb);                 /* call 0x41fd */
        //    ii(0x19_4bf8, 3); add(sp, 0xc);                             /* add sp, 0xc */
        //    ii(0x19_4bfb, 2); or(ax, ax);                               /* or ax, ax */
        //    ii(0x19_4bfd, 2); if(jnzw(0x19_4c04, 0x5)) goto l_0x19_4c04; /* jnz 0x4c04 */
        //    ii(0x19_4bff, 2); sub(ax, ax);                              /* sub ax, ax */
        //    ii(0x19_4c01, 1); popw(ds);                                 /* pop ds */
        //    ii(0x19_4c02, 1); leavew();                                 /* leave */
        //    ii(0x19_4c03, 1); retfw(); return;                          /* retf */
        l_0x19_4c04:
            ii(0x19_4c04, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_4c07, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4c08, 1); leavew();                                 /* leave */
            ii(0x19_4c09, 1); retfw(); return;                          /* retf */
        l_0x19_4c0a:
            ii(0x19_4c0a, 5); mov(memw_a16[ss, bp - 0x4], 0x2);         /* mov word [bp-0x4], 0x2 */
            ii(0x19_4c0f, 5); mov(memw_a16[ss, bp - 0x8], 0xa000);      /* mov word [bp-0x8], 0xa000 */
            ii(0x19_4c14, 5); mov(memw_a16[ss, bp - 0x6], 0xa00);       /* mov word [bp-0x6], 0xa00 */
            ii(0x19_4c19, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4c1b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4c1d, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_4c20, 1); pushw(ss);                                /* push ss */
            ii(0x19_4c21, 1); pushw(ax);                                /* push ax */
            ii(0x19_4c22, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x19_4c25, 1); nop();                                    /* nop */
            ii(0x19_4c26, 1); pushw(cs);                                /* push cs */
            ii(0x19_4c27, 3); callw(0x19_4188, -0xaa2);                 /* call 0x4188 */
            ii(0x19_4c2a, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_4c2d, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x19_4c30, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4c31, 1); leavew();                                 /* leave */
            ii(0x19_4c32, 1); retfw(); return;                          /* retf */
        //  ii(0x19_4c33, 1); Недостижимый (и не декодированный) код.
        //    ii(0x19_4c34, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
        //    ii(0x19_4c38, 1); pushw(ds);                                /* push ds */
        //    ii(0x19_4c39, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
        //    ii(0x19_4c3c, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x19_4c3e, 5); cmp(memw_a16[ds, 0x3b72], 0);             /* cmp word [0x3b72], 0x0 */
        //    ii(0x19_4c43, 2); if(jnzw(0x19_4c66, 0x21)) goto l_0x19_4c66; /* jnz 0x4c66 */
        //    ii(0x19_4c45, 5); mov(memw_a16[ss, bp - 0x4], 0x1);         /* mov word [bp-0x4], 0x1 */
        //    ii(0x19_4c4a, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4c4c, 2); pushw(0);                                 /* push 0x0 */
        //    ii(0x19_4c4e, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
        //    ii(0x19_4c51, 1); pushw(ss);                                /* push ss */
        //    ii(0x19_4c52, 1); pushw(ax);                                /* push ax */
        //    ii(0x19_4c53, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
        //    ii(0x19_4c56, 2); pushw(0x1);                               /* push 0x1 */
        //    ii(0x19_4c58, 1); nop();                                    /* nop */
        //    ii(0x19_4c59, 1); pushw(cs);                                /* push cs */
        //    ii(0x19_4c5a, 3); callw(0x19_41fd, -0xa60);                 /* call 0x41fd */
        //    ii(0x19_4c5d, 3); add(sp, 0xc);                             /* add sp, 0xc */
        //    ii(0x19_4c60, 2); sub(ax, ax);                              /* sub ax, ax */
        //    ii(0x19_4c62, 1); popw(ds);                                 /* pop ds */
        //    ii(0x19_4c63, 1); leavew();                                 /* leave */
        //    ii(0x19_4c64, 1); retfw(); return;                          /* retf */
        //  ii(0x19_4c65, 1); Недостижимый (и не декодированный) код.
        l_0x19_4c66:
            ii(0x19_4c66, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_4c69, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_4c6c, 5); mov(memw_a16[ss, bp - 0x6], 0x700);       /* mov word [bp-0x6], 0x700 */
            ii(0x19_4c71, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4c73, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_4c75, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_4c78, 1); pushw(ss);                                /* push ss */
            ii(0x19_4c79, 1); pushw(ax);                                /* push ax */
            ii(0x19_4c7a, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x19_4c7d, 1); nop();                                    /* nop */
            ii(0x19_4c7e, 1); pushw(cs);                                /* push cs */
            ii(0x19_4c7f, 3); callw(0x19_4188, -0xafa);                 /* call 0x4188 */
            ii(0x19_4c82, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_4c85, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_4c87, 1); popw(ds);                                 /* pop ds */
            ii(0x19_4c88, 1); leavew();                                 /* leave */
            ii(0x19_4c89, 1); retfw(); return;                          /* retf */
        }
    }
}
