using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a7a89c2-739f-4540-a39f-87e16e7aa80a")]
        public void Method_0019_2bc2()
        {
            ii(0x19_2bc2, 1); pushw(bp);                                /* push bp */
            ii(0x19_2bc3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_2bc5, 3); sub(sp, 0x4);                             /* sub sp, 0x4 */
            ii(0x19_2bc8, 1); pushw(ds);                                /* push ds */
            ii(0x19_2bc9, 4); mov(es, memw_a16[ds, 0x3c18]);            /* mov es, [0x3c18] */
            ii(0x19_2bcd, 5); mov(bx, memw_a16[es, 0x2c]);              /* mov bx, [es:0x2c] */
            ii(0x19_2bd2, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x19_2bd4, 3); mov(memw_a16[ss, bp - 0x2], es);          /* mov [bp-0x2], es */
            ii(0x19_2bd7, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_2bd9, 2); xor(si, si);                              /* xor si, si */
            ii(0x19_2bdb, 2); xor(di, di);                              /* xor di, di */
            ii(0x19_2bdd, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_2be0, 2); or(bx, bx);                               /* or bx, bx */
            ii(0x19_2be2, 2); if(jzw(0x19_2bf2, 0xe)) goto l_0x19_2bf2; /* jz 0x2bf2 */
            ii(0x19_2be4, 6); cmp(memb_a16[es, 0], 0);                  /* cmp byte [es:0x0], 0x0 */
            ii(0x19_2bea, 2); if(jzw(0x19_2bf2, 0x6)) goto l_0x19_2bf2; /* jz 0x2bf2 */
        l_0x19_2bec:
            ii(0x19_2bec, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x19_2bee, 1); inc(si);                                  /* inc si */
            ii(0x19_2bef, 1); scasb_a16();                              /* scasb */
            ii(0x19_2bf0, 2); if(jnzw(0x19_2bec, -0x6)) goto l_0x19_2bec; /* jnz 0x2bec */
        l_0x19_2bf2:
            ii(0x19_2bf2, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x19_2bf4, 1); inc(ax);                                  /* inc ax */
            ii(0x19_2bf5, 2); and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x19_2bf7, 1); inc(si);                                  /* inc si */
            ii(0x19_2bf8, 2); mov(di, si);                              /* mov di, si */
            ii(0x19_2bfa, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x19_2bfc, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x19_2bfe, 3); mov(cx, 0x9);                             /* mov cx, 0x9 */
            ii(0x19_2c01, 3); callw(0x19_3ae2, 0xede);                  /* call 0x3ae2 */
            ii(0x19_2c04, 1); pushw(dx);                                /* push dx */
            ii(0x19_2c05, 1); pushw(ax);                                /* push ax */
            ii(0x19_2c06, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x19_2c08, 3); callw(0x19_3ae2, 0xed7);                  /* call 0x3ae2 */
            ii(0x19_2c0b, 3); mov(memw_a16[ds, 0x3c3b], ax);            /* mov [0x3c3b], ax */
            ii(0x19_2c0e, 4); mov(memw_a16[ds, 0x3c3d], dx);            /* mov [0x3c3d], dx */
            ii(0x19_2c12, 3); mov(memw_a16[ss, bp - 0x4], dx);          /* mov [bp-0x4], dx */
            ii(0x19_2c15, 1); pushw(es);                                /* push es */
            ii(0x19_2c16, 1); popw(ds);                                 /* pop ds */
            ii(0x19_2c17, 2); mov(cx, di);                              /* mov cx, di */
            ii(0x19_2c19, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_2c1b, 2); xor(si, si);                              /* xor si, si */
            ii(0x19_2c1d, 1); popw(di);                                 /* pop di */
            ii(0x19_2c1e, 1); popw(es);                                 /* pop es */
            ii(0x19_2c1f, 1); dec(cx);                                  /* dec cx */
            ii(0x19_2c20, 2); if(jcxzw(0x19_2c55, 0x33)) goto l_0x19_2c55; /* jcxz 0x2c55 */
        l_0x19_2c22:
            ii(0x19_2c22, 2); mov(ax, memw_a16[ds, si]);                /* mov ax, [si] */
            ii(0x19_2c24, 5); cmp(ax, memw_a16[ss, 0x3bf6]);            /* cmp ax, [ss:0x3bf6] */
            ii(0x19_2c29, 2); if(jnzw(0x19_2c3f, 0x14)) goto l_0x19_2c3f; /* jnz 0x2c3f */
            ii(0x19_2c2b, 1); pushw(cx);                                /* push cx */
            ii(0x19_2c2c, 1); pushw(si);                                /* push si */
            ii(0x19_2c2d, 1); pushw(di);                                /* push di */
            ii(0x19_2c2e, 1); pushw(es);                                /* push es */
            ii(0x19_2c2f, 1); pushw(ss);                                /* push ss */
            ii(0x19_2c30, 1); popw(es);                                 /* pop es */
            ii(0x19_2c31, 3); mov(di, 0x3bf6);                          /* mov di, 0x3bf6 */
            ii(0x19_2c34, 3); mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0x19_2c37, 2); repe_a16(() => cmpsw_a16());              /* repe cmpsw */
            ii(0x19_2c39, 1); popw(es);                                 /* pop es */
            ii(0x19_2c3a, 1); popw(di);                                 /* pop di */
            ii(0x19_2c3b, 1); popw(si);                                 /* pop si */
            ii(0x19_2c3c, 1); popw(cx);                                 /* pop cx */
            ii(0x19_2c3d, 2); if(jzw(0x19_2c4a, 0xb)) goto l_0x19_2c4a; /* jz 0x2c4a */
        l_0x19_2c3f:
            ii(0x19_2c3f, 3); mov(ds, memw_a16[ss, bp - 0x4]);          /* mov ds, [bp-0x4] */
            ii(0x19_2c42, 2); mov(memw_a16[ds, bx], di);                /* mov [bx], di */
            ii(0x19_2c44, 3); mov(memw_a16[ds, bx + 0x2], es);          /* mov [bx+0x2], es */
            ii(0x19_2c47, 3); add(bx, 0x4);                             /* add bx, 0x4 */
        l_0x19_2c4a:
            ii(0x19_2c4a, 3); mov(ds, memw_a16[ss, bp - 0x2]);          /* mov ds, [bp-0x2] */
        l_0x19_2c4d:
            ii(0x19_2c4d, 1); lodsb_a16();                              /* lodsb */
            ii(0x19_2c4e, 1); stosb_a16();                              /* stosb */
            ii(0x19_2c4f, 2); or(al, al);                               /* or al, al */
            ii(0x19_2c51, 2); if(jnzw(0x19_2c4d, -0x6)) goto l_0x19_2c4d; /* jnz 0x2c4d */
            ii(0x19_2c53, 2); if(loopw_a16(0x19_2c22, -0x33)) goto l_0x19_2c22; /* loop 0x2c22 */
        l_0x19_2c55:
            ii(0x19_2c55, 3); mov(ds, memw_a16[ss, bp - 0x4]);          /* mov ds, [bp-0x4] */
            ii(0x19_2c58, 2); mov(memw_a16[ds, bx], cx);                /* mov [bx], cx */
            ii(0x19_2c5a, 3); mov(memw_a16[ds, bx + 0x2], cx);          /* mov [bx+0x2], cx */
            ii(0x19_2c5d, 1); popw(ds);                                 /* pop ds */
            ii(0x19_2c5e, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_2c60, 1); popw(bp);                                 /* pop bp */
            ii(0x19_2c61, 1); retfw(); return;                          /* retf */
        }
    }
}
