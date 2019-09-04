using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x997c-cfb49c25")]
        public void Method_0000_997c()
        {
            ii(0x997c, 4);    enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x9980, 1);    push(di);                                 /* push di */
            ii(0x9981, 1);    push(si);                                 /* push si */
            ii(0x9982, 5);    mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x9987, 3);    call(0x773a, -0x2250);                    /* call 0x773a */
            ii(0x998a, 5);    mov(memw[ss, bp - 6], 0);                 /* mov word [bp-0x6], 0x0 */
            ii(0x998f, 5);    mov(memw[ss, bp - 4], 8);                 /* mov word [bp-0x4], 0x8 */
            ii(0x9994, 4);    cmp(memw[ss, bp + 4], 0);                 /* cmp word [bp+0x4], 0x0 */
            ii(0x9998, 2);    if(jle(0x99ee, 0x54)) goto l_0x99ee;      /* jle 0x99ee */
            ii(0x999a, 3);    mov(bx, 8);                               /* mov bx, 0x8 */
            ii(0x999d, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x999f, 3);    mov(si, memw[es, bx]);                    /* mov si, [es:bx] */
            ii(0x99a2, 3);    shr(si, 3);                               /* shr si, 0x3 */
            ii(0x99a5, 1);    dec(si);                                  /* dec si */
            ii(0x99a6, 1);    dec(si);                                  /* dec si */
            ii(0x99a7, 3);    mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x99aa, 3);    add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x99ad, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x99b0, 2);    jmp(0x99bb, 9); goto l_0x99bb;            /* jmp 0x99bb */
        l_0x99b2:
            ii(0x99b2, 3);    cmp(memw[ss, bp - 2], si);                /* cmp [bp-0x2], si */
            ii(0x99b5, 2);    if(jl(0x99ba, 3)) goto l_0x99ba;          /* jl 0x99ba */
            ii(0x99b7, 3);    jmp(0x9a43, 0x89); goto l_0x9a43;         /* jmp 0x9a43 */
        l_0x99ba:
            ii(0x99ba, 1);    dec(si);                                  /* dec si */
        l_0x99bb:
            ii(0x99bb, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x99bd, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x99c0, 3);    add(bx, memw[ss, bp - 6]);                /* add bx, [bp-0x6] */
            ii(0x99c3, 3);    mov(es, memw[ss, bp - 4]);                /* mov es, [bp-0x4] */
            ii(0x99c6, 5);    cmp(memb[es, bx + 5], 0);                 /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x99cb, 2);    if(jnz(0x99b2, -0x1b)) goto l_0x99b2;     /* jnz 0x99b2 */
            ii(0x99cd, 3);    mov(di, memw[ss, bp + 4]);                /* mov di, [bp+0x4] */
            ii(0x99d0, 1);    dec(di);                                  /* dec di */
        l_0x99d1:
            ii(0x99d1, 1);    dec(di);                                  /* dec di */
            ii(0x99d2, 2);    if(jns(0x99d9, 5)) goto l_0x99d9;         /* jns 0x99d9 */
        l_0x99d4:
            ii(0x99d4, 3);    mov(memw[ss, bp - 8], si);                /* mov [bp-0x8], si */
            ii(0x99d7, 2);    jmp(0x9a43, 0x6a); goto l_0x9a43;         /* jmp 0x9a43 */
        l_0x99d9:
            ii(0x99d9, 1);    dec(si);                                  /* dec si */
            ii(0x99da, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x99dc, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x99df, 3);    add(bx, memw[ss, bp - 6]);                /* add bx, [bp-0x6] */
            ii(0x99e2, 3);    mov(es, memw[ss, bp - 4]);                /* mov es, [bp-0x4] */
            ii(0x99e5, 5);    cmp(memb[es, bx + 5], 0);                 /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x99ea, 2);    if(jz(0x99d1, -0x1b)) goto l_0x99d1;      /* jz 0x99d1 */
            ii(0x99ec, 2);    jmp(0x99bb, -0x33); goto l_0x99bb;        /* jmp 0x99bb */
        l_0x99ee:
            ii(0x99ee, 3);    les(bx, memw[ss, bp - 6]);                /* les bx, [bp-0x6] */
            ii(0x99f1, 4);    mov(ax, memw[es, bx + 8]);                /* mov ax, [es:bx+0x8] */
            ii(0x99f5, 3);    shr(ax, 3);                               /* shr ax, 0x3 */
            ii(0x99f8, 3);    add(ax, memw[ss, bp + 4]);                /* add ax, [bp+0x4] */
            ii(0x99fb, 1);    dec(ax);                                  /* dec ax */
            ii(0x99fc, 1);    dec(ax);                                  /* dec ax */
            ii(0x99fd, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x9a00, 3);    mov(si, 0x10);                            /* mov si, 0x10 */
            ii(0x9a03, 2);    jmp(0x9a3d, 0x38); goto l_0x9a3d;         /* jmp 0x9a3d */
        l_0x9a05:
            ii(0x9a05, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x9a07, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x9a0a, 3);    add(bx, memw[ss, bp - 6]);                /* add bx, [bp-0x6] */
            ii(0x9a0d, 5);    cmp(memb[es, bx + 5], 0);                 /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x9a12, 2);    if(jnz(0x9a35, 0x21)) goto l_0x9a35;      /* jnz 0x9a35 */
            ii(0x9a14, 3);    mov(di, memw[ss, bp + 4]);                /* mov di, [bp+0x4] */
            ii(0x9a17, 2);    neg(di);                                  /* neg di */
            ii(0x9a19, 2);    add(si, di);                              /* add si, di */
        l_0x9a1b:
            ii(0x9a1b, 1);    dec(si);                                  /* dec si */
            ii(0x9a1c, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x9a1e, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x9a21, 3);    add(bx, memw[ss, bp - 6]);                /* add bx, [bp-0x6] */
            ii(0x9a24, 3);    mov(es, memw[ss, bp - 4]);                /* mov es, [bp-0x4] */
            ii(0x9a27, 5);    cmp(memb[es, bx + 5], 0);                 /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x9a2c, 2);    if(jnz(0x9a3d, 0xf)) goto l_0x9a3d;       /* jnz 0x9a3d */
            ii(0x9a2e, 1);    dec(di);                                  /* dec di */
            ii(0x9a2f, 2);    or(di, di);                               /* or di, di */
            ii(0x9a31, 2);    if(jg(0x9a1b, -0x18)) goto l_0x9a1b;      /* jg 0x9a1b */
            ii(0x9a33, 2);    jmp(0x99d4, -0x61); goto l_0x99d4;        /* jmp 0x99d4 */
        l_0x9a35:
            ii(0x9a35, 1);    inc(si);                                  /* inc si */
            ii(0x9a36, 3);    cmp(memw[ss, bp - 2], si);                /* cmp [bp-0x2], si */
            ii(0x9a39, 2);    if(jg(0x9a05, -0x36)) goto l_0x9a05;      /* jg 0x9a05 */
            ii(0x9a3b, 2);    jmp(0x9a43, 6); goto l_0x9a43;            /* jmp 0x9a43 */
        l_0x9a3d:
            ii(0x9a3d, 4);    cmp(memw[ss, bp - 8], 0);                 /* cmp word [bp-0x8], 0x0 */
            ii(0x9a41, 2);    if(jz(0x9a05, -0x3e)) goto l_0x9a05;      /* jz 0x9a05 */
        l_0x9a43:
            ii(0x9a43, 3);    call(0x6f71, -0x2ad5);                    /* call 0x6f71 */
            ii(0x9a46, 3);    mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x9a49, 1);    pop(si);                                  /* pop si */
            ii(0x9a4a, 1);    pop(di);                                  /* pop di */
            ii(0x9a4b, 1);    leave();                                  /* leave */
            ii(0x9a4c, 1);    ret();                                    /* ret */
        }
    }
}
