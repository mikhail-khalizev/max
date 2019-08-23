using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d7c6-baa04106")]
        public void Method_0017_d7c6()
        {
            ii(0x17_d7c6, 1); push(bp);                                 /* push bp */
            ii(0x17_d7c7, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_d7c9, 1); push(ds);                                 /* push ds */
            ii(0x17_d7ca, 4); mov(es, memw[ds, 0x1c54]);                /* mov es, [0x1c54] */
            ii(0x17_d7ce, 5); mov(bx, memw[es, 0x2c]);                  /* mov bx, [es:0x2c] */
            ii(0x17_d7d3, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x17_d7d5, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_d7d7, 2); xor(si, si);                              /* xor si, si */
            ii(0x17_d7d9, 2); xor(di, di);                              /* xor di, di */
            ii(0x17_d7db, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x17_d7de, 2); or(bx, bx);                               /* or bx, bx */
            ii(0x17_d7e0, 2); if(jz(0x17_d7f0, 0xe)) goto l_0x17_d7f0;  /* jz 0xd7f0 */
            ii(0x17_d7e2, 6); cmp(memb[es, 0], 0);                      /* cmp byte [es:0x0], 0x0 */
            ii(0x17_d7e8, 2); if(jz(0x17_d7f0, 0x6)) goto l_0x17_d7f0;  /* jz 0xd7f0 */
        l_0x17_d7ea:
            ii(0x17_d7ea, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x17_d7ec, 1); inc(si);                                  /* inc si */
            ii(0x17_d7ed, 1); scasb();                                  /* scasb */
            ii(0x17_d7ee, 2); if(jnz(0x17_d7ea, -0x6)) goto l_0x17_d7ea; /* jnz 0xd7ea */
        l_0x17_d7f0:
            ii(0x17_d7f0, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x17_d7f2, 1); inc(ax);                                  /* inc ax */
            ii(0x17_d7f3, 2); and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x17_d7f5, 1); inc(si);                                  /* inc si */
            ii(0x17_d7f6, 2); mov(di, si);                              /* mov di, si */
            ii(0x17_d7f8, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x17_d7fa, 3); mov(cx, 0x9);                             /* mov cx, 0x9 */
            ii(0x17_d7fd, 3); call(0x17_e23c, 0xa3c);                   /* call 0xe23c */
            ii(0x17_d800, 1); push(ax);                                 /* push ax */
            ii(0x17_d801, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x17_d803, 3); call(0x17_e23c, 0xa36);                   /* call 0xe23c */
            ii(0x17_d806, 3); mov(memw[ds, 0x1c75], ax);                /* mov [0x1c75], ax */
            ii(0x17_d809, 1); push(es);                                 /* push es */
            ii(0x17_d80a, 1); push(ds);                                 /* push ds */
            ii(0x17_d80b, 1); pop(es);                                  /* pop es */
            ii(0x17_d80c, 1); pop(ds);                                  /* pop ds */
            ii(0x17_d80d, 2); mov(cx, di);                              /* mov cx, di */
            ii(0x17_d80f, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_d811, 2); xor(si, si);                              /* xor si, si */
            ii(0x17_d813, 1); pop(di);                                  /* pop di */
            ii(0x17_d814, 1); dec(cx);                                  /* dec cx */
            ii(0x17_d815, 2); if(jcxz(0x17_d83d, 0x26)) goto l_0x17_d83d; /* jcxz 0xd83d */
        l_0x17_d817:
            ii(0x17_d817, 2); mov(ax, memw[ds, si]);                    /* mov ax, [si] */
            ii(0x17_d819, 5); cmp(ax, memw[ss, 0x1c32]);                /* cmp ax, [ss:0x1c32] */
            ii(0x17_d81e, 2); if(jnz(0x17_d830, 0x10)) goto l_0x17_d830; /* jnz 0xd830 */
            ii(0x17_d820, 1); push(cx);                                 /* push cx */
            ii(0x17_d821, 1); push(si);                                 /* push si */
            ii(0x17_d822, 1); push(di);                                 /* push di */
            ii(0x17_d823, 3); mov(di, 0x1c32);                          /* mov di, 0x1c32 */
            ii(0x17_d826, 3); mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0x17_d829, 2); repe(() => cmpsw());                      /* repe cmpsw */
            ii(0x17_d82b, 1); pop(di);                                  /* pop di */
            ii(0x17_d82c, 1); pop(si);                                  /* pop si */
            ii(0x17_d82d, 1); pop(cx);                                  /* pop cx */
            ii(0x17_d82e, 2); if(jz(0x17_d835, 0x5)) goto l_0x17_d835;  /* jz 0xd835 */
        l_0x17_d830:
            ii(0x17_d830, 3); mov(memw[es, bx], di);                    /* mov [es:bx], di */
            ii(0x17_d833, 1); inc(bx);                                  /* inc bx */
            ii(0x17_d834, 1); inc(bx);                                  /* inc bx */
        l_0x17_d835:
            ii(0x17_d835, 1); lodsb();                                  /* lodsb */
            ii(0x17_d836, 1); stosb();                                  /* stosb */
            ii(0x17_d837, 2); or(al, al);                               /* or al, al */
            ii(0x17_d839, 2); if(jnz(0x17_d835, -0x6)) goto l_0x17_d835; /* jnz 0xd835 */
            ii(0x17_d83b, 2); if(loop(0x17_d817, -0x26)) goto l_0x17_d817; /* loop 0xd817 */
        l_0x17_d83d:
            ii(0x17_d83d, 3); mov(memw[es, bx], cx);                    /* mov [es:bx], cx */
            ii(0x17_d840, 1); pop(ds);                                  /* pop ds */
            ii(0x17_d841, 1); pop(bp);                                  /* pop bp */
            ii(0x17_d842, 1); retf();                                   /* retf */
        }
    }
}
