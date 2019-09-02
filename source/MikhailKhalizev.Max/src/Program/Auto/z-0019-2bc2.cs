using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_2bc2-20bb4f8f")]
        public void Method_0019_2bc2()
        {
            ii(0x19_2bc2, 1); push(bp);                                 /* push bp */
            ii(0x19_2bc3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_2bc5, 3); sub(sp, 4);                               /* sub sp, 0x4 */
            ii(0x19_2bc8, 1); push(ds);                                 /* push ds */
            ii(0x19_2bc9, 4); mov(es, memw[ds, 0x3c18]);                /* mov es, [0x3c18] */
            ii(0x19_2bcd, 5); mov(bx, memw[es, 0x2c]);                  /* mov bx, [es:0x2c] */
            ii(0x19_2bd2, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x19_2bd4, 3); mov(memw[ss, bp - 2], es);                /* mov [bp-0x2], es */
            ii(0x19_2bd7, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_2bd9, 2); xor(si, si);                              /* xor si, si */
            ii(0x19_2bdb, 2); xor(di, di);                              /* xor di, di */
            ii(0x19_2bdd, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_2be0, 2); or(bx, bx);                               /* or bx, bx */
            ii(0x19_2be2, 2); if(jz(0x19_2bf2, 0xe)) goto l_0x19_2bf2;  /* jz 0x2bf2 */
            ii(0x19_2be4, 6); cmp(memb[es, 0], 0);                      /* cmp byte [es:0x0], 0x0 */
            ii(0x19_2bea, 2); if(jz(0x19_2bf2, 6)) goto l_0x19_2bf2;    /* jz 0x2bf2 */
        l_0x19_2bec:
            ii(0x19_2bec, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x19_2bee, 1); inc(si);                                  /* inc si */
            ii(0x19_2bef, 1); scasb();                                  /* scasb */
            ii(0x19_2bf0, 2); if(jnz(0x19_2bec, -6)) goto l_0x19_2bec;  /* jnz 0x2bec */
        l_0x19_2bf2:
            ii(0x19_2bf2, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x19_2bf4, 1); inc(ax);                                  /* inc ax */
            ii(0x19_2bf5, 2); and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x19_2bf7, 1); inc(si);                                  /* inc si */
            ii(0x19_2bf8, 2); mov(di, si);                              /* mov di, si */
            ii(0x19_2bfa, 2); shl(si, 1);                               /* shl si, 1 */
            ii(0x19_2bfc, 2); shl(si, 1);                               /* shl si, 1 */
            ii(0x19_2bfe, 3); mov(cx, 9);                               /* mov cx, 0x9 */
            ii(0x19_2c01, 3); call(0x19_3ae2, 0xede);                   /* call 0x3ae2 */
            ii(0x19_2c04, 1); push(dx);                                 /* push dx */
            ii(0x19_2c05, 1); push(ax);                                 /* push ax */
            ii(0x19_2c06, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x19_2c08, 3); call(0x19_3ae2, 0xed7);                   /* call 0x3ae2 */
            ii(0x19_2c0b, 3); mov(memw[ds, 0x3c3b], ax);                /* mov [0x3c3b], ax */
            ii(0x19_2c0e, 4); mov(memw[ds, 0x3c3d], dx);                /* mov [0x3c3d], dx */
            ii(0x19_2c12, 3); mov(memw[ss, bp - 4], dx);                /* mov [bp-0x4], dx */
            ii(0x19_2c15, 1); push(es);                                 /* push es */
            ii(0x19_2c16, 1); pop(ds);                                  /* pop ds */
            ii(0x19_2c17, 2); mov(cx, di);                              /* mov cx, di */
            ii(0x19_2c19, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_2c1b, 2); xor(si, si);                              /* xor si, si */
            ii(0x19_2c1d, 1); pop(di);                                  /* pop di */
            ii(0x19_2c1e, 1); pop(es);                                  /* pop es */
            ii(0x19_2c1f, 1); dec(cx);                                  /* dec cx */
            ii(0x19_2c20, 2); if(jcxz(0x19_2c55, 0x33)) goto l_0x19_2c55; /* jcxz 0x2c55 */
        l_0x19_2c22:
            ii(0x19_2c22, 2); mov(ax, memw[ds, si]);                    /* mov ax, [si] */
            ii(0x19_2c24, 5); cmp(ax, memw[ss, 0x3bf6]);                /* cmp ax, [ss:0x3bf6] */
            ii(0x19_2c29, 2); if(jnz(0x19_2c3f, 0x14)) goto l_0x19_2c3f; /* jnz 0x2c3f */
            ii(0x19_2c2b, 1); push(cx);                                 /* push cx */
            ii(0x19_2c2c, 1); push(si);                                 /* push si */
            ii(0x19_2c2d, 1); push(di);                                 /* push di */
            ii(0x19_2c2e, 1); push(es);                                 /* push es */
            ii(0x19_2c2f, 1); push(ss);                                 /* push ss */
            ii(0x19_2c30, 1); pop(es);                                  /* pop es */
            ii(0x19_2c31, 3); mov(di, 0x3bf6);                          /* mov di, 0x3bf6 */
            ii(0x19_2c34, 3); mov(cx, 6);                               /* mov cx, 0x6 */
            ii(0x19_2c37, 2); repe(() => cmpsw());                      /* repe cmpsw */
            ii(0x19_2c39, 1); pop(es);                                  /* pop es */
            ii(0x19_2c3a, 1); pop(di);                                  /* pop di */
            ii(0x19_2c3b, 1); pop(si);                                  /* pop si */
            ii(0x19_2c3c, 1); pop(cx);                                  /* pop cx */
            ii(0x19_2c3d, 2); if(jz(0x19_2c4a, 0xb)) goto l_0x19_2c4a;  /* jz 0x2c4a */
        l_0x19_2c3f:
            ii(0x19_2c3f, 3); mov(ds, memw[ss, bp - 4]);                /* mov ds, [bp-0x4] */
            ii(0x19_2c42, 2); mov(memw[ds, bx], di);                    /* mov [bx], di */
            ii(0x19_2c44, 3); mov(memw[ds, bx + 2], es);                /* mov [bx+0x2], es */
            ii(0x19_2c47, 3); add(bx, 4);                               /* add bx, 0x4 */
        l_0x19_2c4a:
            ii(0x19_2c4a, 3); mov(ds, memw[ss, bp - 2]);                /* mov ds, [bp-0x2] */
        l_0x19_2c4d:
            ii(0x19_2c4d, 1); lodsb();                                  /* lodsb */
            ii(0x19_2c4e, 1); stosb();                                  /* stosb */
            ii(0x19_2c4f, 2); or(al, al);                               /* or al, al */
            ii(0x19_2c51, 2); if(jnz(0x19_2c4d, -6)) goto l_0x19_2c4d;  /* jnz 0x2c4d */
            ii(0x19_2c53, 2); if(loop(0x19_2c22, -0x33)) goto l_0x19_2c22; /* loop 0x2c22 */
        l_0x19_2c55:
            ii(0x19_2c55, 3); mov(ds, memw[ss, bp - 4]);                /* mov ds, [bp-0x4] */
            ii(0x19_2c58, 2); mov(memw[ds, bx], cx);                    /* mov [bx], cx */
            ii(0x19_2c5a, 3); mov(memw[ds, bx + 2], cx);                /* mov [bx+0x2], cx */
            ii(0x19_2c5d, 1); pop(ds);                                  /* pop ds */
            ii(0x19_2c5e, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_2c60, 1); pop(bp);                                  /* pop bp */
            ii(0x19_2c61, 1); retf();                                   /* retf */
        }
    }
}
