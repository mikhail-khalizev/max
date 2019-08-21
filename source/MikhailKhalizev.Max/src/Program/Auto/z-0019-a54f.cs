using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_a54f-32132e42")]
        public void Method_0019_a54f()
        {
            ii(0x19_a54f, 3); mov(ax, memw_a16[ss, bp - 0x42]);         /* mov ax, [bp-0x42] */
            ii(0x19_a552, 3); dec(memw_a16[ss, bp - 0x42]);             /* dec word [bp-0x42] */
            ii(0x19_a555, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_a557, 2); if(jnzw_func(0x19_a50c, -0x4d)) return;   /* jnz 0xa50c */
            ii(0x19_a559, 3); mov(ax, memw_a16[ds, 0x2b9c]);            /* mov ax, [0x2b9c] */
            ii(0x19_a55c, 4); or(ax, memw_a16[ds, 0x2b9a]);             /* or ax, [0x2b9a] */
            ii(0x19_a560, 2); if(jzw(0x19_a588, 0x26)) goto l_0x19_a588; /* jz 0xa588 */
            ii(0x19_a562, 4); pushw(memw_a16[ds, 0x2b9c]);              /* push word [0x2b9c] */
            ii(0x19_a566, 1); nop();                                    /* nop */
            ii(0x19_a567, 1); pushw(cs);                                /* push cs */
            ii(0x19_a568, 3); callw(0x19_d997, 0x342c);                 /* call 0xd997 */
            ii(0x19_a56b, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a56c, 4); pushw(memw_a16[ds, 0x2b9c]);              /* push word [0x2b9c] */
            ii(0x19_a570, 4); pushw(memw_a16[ds, 0x2b9a]);              /* push word [0x2b9a] */
            ii(0x19_a574, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x19_a579, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a57a, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a57b, 1); pushw(dx);                                /* push dx */
            ii(0x19_a57c, 1); pushw(ax);                                /* push ax */
            ii(0x19_a57d, 3); callw(0x19_a1c1, -0x3bf);                 /* call 0xa1c1 */
            ii(0x19_a580, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_a582, 3); mov(memw_a16[ds, 0x2b9c], ax);            /* mov [0x2b9c], ax */
            ii(0x19_a585, 3); mov(memw_a16[ds, 0x2b9a], ax);            /* mov [0x2b9a], ax */
        l_0x19_a588:
            ii(0x19_a588, 3); mov(ax, memw_a16[ds, 0x1f1c]);            /* mov ax, [0x1f1c] */
            ii(0x19_a58b, 4); or(ax, memw_a16[ds, 0x1f1a]);             /* or ax, [0x1f1a] */
            ii(0x19_a58f, 2); if(jzw(0x19_a5b0, 0x1f)) goto l_0x19_a5b0; /* jz 0xa5b0 */
            ii(0x19_a591, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_a595, 4); dec(memw_a16[es, bx + 0x10]);             /* dec word [es:bx+0x10] */
            ii(0x19_a599, 2); if(jnzw(0x19_a5a3, 0x8)) goto l_0x19_a5a3; /* jnz 0xa5a3 */
            ii(0x19_a59b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_a59d, 3); mov(memw_a16[ds, 0x1f1c], ax);            /* mov [0x1f1c], ax */
            ii(0x19_a5a0, 3); mov(memw_a16[ds, 0x1f1a], ax);            /* mov [0x1f1a], ax */
        l_0x19_a5a3:
            ii(0x19_a5a3, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x19_a5a5, 1); pushw(ds);                                /* push ds */
            ii(0x19_a5a6, 3); pushw(0x1f22);                            /* push 0x1f22 */
            ii(0x19_a5a9, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_a5ab, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_a5ad, 3); callw(0x19_9bb6, -0x9fa);                 /* call 0x9bb6 */
        l_0x19_a5b0:
            ii(0x19_a5b0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_a5b2, 1); pushw(ds);                                /* push ds */
            ii(0x19_a5b3, 3); pushw(0x2051);                            /* push 0x2051 */
            ii(0x19_a5b6, 1); nop();                                    /* nop */
            ii(0x19_a5b7, 1); pushw(cs);                                /* push cs */
            ii(0x19_a5b8, 3); callw(0x19_cd5c, 0x27a1);                 /* call 0xcd5c */
            ii(0x19_a5bb, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_a5be, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_a5c0, 2); if(jzw(0x19_a5f5, 0x33)) goto l_0x19_a5f5; /* jz 0xa5f5 */
            ii(0x19_a5c2, 5); mov(memw_a16[ss, bp - 0x4a], 0);          /* mov word [bp-0x4a], 0x0 */
            ii(0x19_a5c7, 5); mov(memw_a16[ss, bp - 0x48], 0x8);        /* mov word [bp-0x48], 0x8 */
            ii(0x19_a5cc, 3); mov(ax, 0x68);                            /* mov ax, 0x68 */
            ii(0x19_a5cf, 3); mov(dx, 0x8);                             /* mov dx, 0x8 */
            ii(0x19_a5d2, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x19_a5d4, 1); pushw(ds);                                /* push ds */
            ii(0x19_a5d5, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x19_a5d7, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x19_a5d9, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_a5db, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x19_a5dd, 1); movsw_a16();                              /* movsw */
            ii(0x19_a5de, 1); movsw_a16();                              /* movsw */
            ii(0x19_a5df, 1); movsw_a16();                              /* movsw */
            ii(0x19_a5e0, 1); movsw_a16();                              /* movsw */
            ii(0x19_a5e1, 1); popw(ds);                                 /* pop ds */
            ii(0x19_a5e2, 3); mov(bx, 0x6d);                            /* mov bx, 0x6d */
            ii(0x19_a5e5, 4); and(memb_a16[es, bx], -0x20 /* 0xe0 */);  /* and byte [es:bx], 0xe0 */
            ii(0x19_a5e9, 4); or(memb_a16[es, bx], 0x2);                /* or byte [es:bx], 0x2 */
            ii(0x19_a5ed, 3); mov(ax, 0x68);                            /* mov ax, 0x68 */
            ii(0x19_a5f0, 1); nop();                                    /* nop */
            ii(0x19_a5f1, 1); pushw(cs);                                /* push cs */
            ii(0x19_a5f2, 3); callw(0x19_e398, 0x3da3);                 /* call 0xe398 */
        l_0x19_a5f5:
            ii(0x19_a5f5, 3); callw(0x19_8bea, -0x1a0e);                /* call 0x8bea */
            ii(0x19_a5f8, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_a5fa, 1); popw(ds);                                 /* pop ds */
            ii(0x19_a5fb, 1); popw(si);                                 /* pop si */
            ii(0x19_a5fc, 1); popw(di);                                 /* pop di */
            ii(0x19_a5fd, 1); leavew();                                 /* leave */
            ii(0x19_a5fe, 1); retfw(); return;                          /* retf */
        }
    }
}
