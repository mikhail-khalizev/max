using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7b24-bcf4bded")]
        public void Method_0017_7b24()
        {
            ii(0x17_7b24, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x17_7b28, 1); pushw(di);                                /* push di */
            ii(0x17_7b29, 1); pushw(si);                                /* push si */
            ii(0x17_7b2a, 1); pushw(ds);                                /* push ds */
            ii(0x17_7b2b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7b2e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7b30, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
        l_0x17_7b35:
            ii(0x17_7b35, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_7b38, 4); cmp(memw_a16[ds, 0x50bc], ax);            /* cmp [0x50bc], ax */
            ii(0x17_7b3c, 2); if(jaw(0x17_7b41, 0x3)) goto l_0x17_7b41; /* ja 0x7b41 */
            ii(0x17_7b3e, 3); jmpw(0x17_7be4, 0xa3); goto l_0x17_7be4;  /* jmp 0x7be4 */
        l_0x17_7b41:
            ii(0x17_7b41, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_7b43, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x17_7b46, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x17_7b4a, 3); mov(cx, memw_a16[es, bx + si]);           /* mov cx, [es:bx+si] */
            ii(0x17_7b4d, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x17_7b51, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x17_7b54, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_7b57, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x17_7b59, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_7b5b, 2); or(dx, cx);                               /* or dx, cx */
            ii(0x17_7b5d, 2); if(jzw(0x17_7bde, 0x7f)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7b5f, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7b63, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_7b65, 3); mov(dl, memb_a16[es, bx + si]);           /* mov dl, [es:bx+si] */
            ii(0x17_7b68, 3); and(dl, 0x80);                            /* and dl, 0x80 */
            ii(0x17_7b6b, 3); cmp(dl, -0x80 /* 0x80 */);                /* cmp dl, 0x80 */
            ii(0x17_7b6e, 2); if(jzw(0x17_7bde, 0x6e)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7b70, 3); sub(cx, 0);                               /* sub cx, 0x0 */
            ii(0x17_7b73, 3); sbb(di, 0x1);                             /* sbb di, 0x1 */
            ii(0x17_7b76, 1); pushw(di);                                /* push di */
            ii(0x17_7b77, 1); pushw(cx);                                /* push cx */
            ii(0x17_7b78, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7b7c, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7b80, 3); callw(0x17_9208, 0x1685);                 /* call 0x9208 */
            ii(0x17_7b83, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7b86, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_7b89, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x17_7b8c, 4); test(memb_a16[ss, bp - 0xa], 0x20);       /* test byte [bp-0xa], 0x20 */
            ii(0x17_7b90, 2); if(jzw(0x17_7bc2, 0x30)) goto l_0x17_7bc2; /* jz 0x7bc2 */
            ii(0x17_7b92, 4); and(memb_a16[ss, bp - 0xa], -0x21 /* 0xdf */); /* and byte [bp-0xa], 0xdf */
            ii(0x17_7b96, 1); pushw(dx);                                /* push dx */
            ii(0x17_7b97, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_7b9a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_7b9d, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_7ba0, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_7ba3, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_7ba6, 1); pushw(dx);                                /* push dx */
            ii(0x17_7ba7, 1); pushw(ax);                                /* push ax */
            ii(0x17_7ba8, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_7bac, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_7bb0, 3); callw(0x17_9235, 0x1682);                 /* call 0x9235 */
            ii(0x17_7bb3, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_7bb6, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7bba, 4); or(memb_a16[es, bx + si], 0x7f);          /* or byte [es:bx+si], 0x7f */
            ii(0x17_7bbe, 2); jmpw(0x17_7bde, 0x1e); goto l_0x17_7bde;  /* jmp 0x7bde */
        //  ii(0x17_7bc0, 2); Недостижимый код.
        l_0x17_7bc2:
            ii(0x17_7bc2, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7bc6, 3); mov(si, memw_a16[ss, bp - 0x6]);          /* mov si, [bp-0x6] */
            ii(0x17_7bc9, 4); test(memb_a16[es, bx + si], 0x7f);        /* test byte [es:bx+si], 0x7f */
            ii(0x17_7bcd, 2); if(jzw(0x17_7bde, 0xf)) goto l_0x17_7bde; /* jz 0x7bde */
            ii(0x17_7bcf, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x17_7bd2, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_7bd4, 2); dec(al);                                  /* dec al */
            ii(0x17_7bd6, 2); xor(cl, al);                              /* xor cl, al */
            ii(0x17_7bd8, 3); and(cl, 0x7f);                            /* and cl, 0x7f */
            ii(0x17_7bdb, 3); xor(memb_a16[es, bx + si], cl);           /* xor [es:bx+si], cl */
        l_0x17_7bde:
            ii(0x17_7bde, 3); inc(memw_a16[ss, bp - 0x6]);              /* inc word [bp-0x6] */
            ii(0x17_7be1, 3); jmpw(0x17_7b35, -0xaf); goto l_0x17_7b35; /* jmp 0x7b35 */
        l_0x17_7be4:
            ii(0x17_7be4, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7be5, 1); popw(si);                                 /* pop si */
            ii(0x17_7be6, 1); popw(di);                                 /* pop di */
            ii(0x17_7be7, 1); leavew();                                 /* leave */
            ii(0x17_7be8, 1); retfw(); return;                          /* retf */
        }
    }
}
