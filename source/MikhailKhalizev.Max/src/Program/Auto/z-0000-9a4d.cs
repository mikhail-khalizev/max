using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9a4d-2f438374")]
        public void Method_0000_9a4d()
        {
            ii(0x9a4d, 4);    enterw(0x12, 0);                          /* enter 0x12, 0x0 */
            ii(0x9a51, 1);    pushw(di);                                /* push di */
            ii(0x9a52, 1);    pushw(si);                                /* push si */
            ii(0x9a53, 3);    callw(0x773a, -0x231c);                   /* call 0x773a */
            ii(0x9a56, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x9a59, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x9a5b, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x9a5d, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x9a5f, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x9a62, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x9a65, 3);    sub(ax, 0x8);                             /* sub ax, 0x8 */
            ii(0x9a68, 3);    mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x9a6b, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x9a6e, 3);    or(bl, 0x8);                              /* or bl, 0x8 */
            ii(0x9a71, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x9a73, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0x9a75, 3);    mov(si, memw_a16[es, bx]);                /* mov si, [es:bx] */
            ii(0x9a78, 1);    inc(si);                                  /* inc si */
            ii(0x9a79, 2);    shr(si, 0x1);                             /* shr si, 1 */
            ii(0x9a7b, 2);    jmpw(0x9af0, 0x73); goto l_0x9af0;        /* jmp 0x9af0 */
        l_0x9a7d:
            ii(0x9a7d, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x9a7f, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x9a81, 3);    add(bx, memw_a16[ss, bp - 0xe]);          /* add bx, [bp-0xe] */
            ii(0x9a84, 3);    mov(es, memw_a16[ss, bp - 0xc]);          /* mov es, [bp-0xc] */
            ii(0x9a87, 3);    mov(di, memw_a16[es, bx]);                /* mov di, [es:bx] */
            ii(0x9a8a, 4);    cmp(di, 0x80);                            /* cmp di, 0x80 */
            ii(0x9a8e, 2);    if(jbw(0x9af0, 0x60)) goto l_0x9af0;      /* jb 0x9af0 */
            ii(0x9a90, 3);    cmp(memw_a16[ss, bp + 0x6], di);          /* cmp [bp+0x6], di */
            ii(0x9a93, 2);    if(jnzw(0x9aa2, 0xd)) goto l_0x9aa2;      /* jnz 0x9aa2 */
            ii(0x9a95, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x9a98, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x9a9a, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x9a9c, 3);    add(bx, memw_a16[ss, bp - 0xe]);          /* add bx, [bp-0xe] */
            ii(0x9a9f, 3);    mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
        l_0x9aa2:
            ii(0x9aa2, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x9aa5, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x9aa7, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x9aa9, 3);    add(bx, memw_a16[ss, bp - 0x6]);          /* add bx, [bp-0x6] */
            ii(0x9aac, 3);    mov(es, memw_a16[ss, bp - 0x4]);          /* mov es, [bp-0x4] */
            ii(0x9aaf, 3);    mov(bx, memw_a16[es, bx]);                /* mov bx, [es:bx] */
            ii(0x9ab2, 2);    mov(cx, di);                              /* mov cx, di */
            ii(0x9ab4, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x9ab6, 3);    mov(memw_a16[ss, bp - 0x12], bx);         /* mov [bp-0x12], bx */
            ii(0x9ab9, 3);    mov(memw_a16[ss, bp - 0x10], es);         /* mov [bp-0x10], es */
            ii(0x9abc, 3);    cmp(memw_a16[es, bx], ax);                /* cmp [es:bx], ax */
            ii(0x9abf, 2);    if(jnzw(0x9af0, 0x2f)) goto l_0x9af0;     /* jnz 0x9af0 */
            ii(0x9ac1, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x9ac3, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x9ac5, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x9ac7, 3);    mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x9aca, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x9acc, 4);    mov(al, memb_a16[es, bx + 0x5]);          /* mov al, [es:bx+0x5] */
            ii(0x9ad0, 3);    mov(memb_a16[ss, bp - 0x2], al);          /* mov [bp-0x2], al */
            ii(0x9ad3, 5);    mov(memb_a16[es, bx + 0x5], 0xf2);        /* mov byte [es:bx+0x5], 0xf2 */
            ii(0x9ad8, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x9adb, 2);    mov(cx, bx);                              /* mov cx, bx */
            ii(0x9add, 2);    mov(dx, es);                              /* mov dx, es */
            ii(0x9adf, 3);    les(bx, ss, bp - 0x12);                   /* les bx, [bp-0x12] */
            ii(0x9ae2, 3);    mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x9ae5, 3);    mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x9ae8, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x9aea, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0x9aec, 4);    mov(memb_a16[es, bx + 0x5], al);          /* mov [es:bx+0x5], al */
        l_0x9af0:
            ii(0x9af0, 1);    dec(si);                                  /* dec si */
            ii(0x9af1, 2);    if(jnsw(0x9a7d, -0x76)) goto l_0x9a7d;    /* jns 0x9a7d */
            ii(0x9af3, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x9af6, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x9af8, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x9afa, 3);    mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x9afd, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x9aff, 5);    mov(memb_a16[es, bx + 0x5], 0x80);        /* mov byte [es:bx+0x5], 0x80 */
            ii(0x9b04, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x9b07, 4);    mov(memw_a16[es, bx + 0x6], ax);          /* mov [es:bx+0x6], ax */
            ii(0x9b0b, 3);    callw(0x6f71, -0x2b9d);                   /* call 0x6f71 */
            ii(0x9b0e, 1);    popw(si);                                 /* pop si */
            ii(0x9b0f, 1);    popw(di);                                 /* pop di */
            ii(0x9b10, 1);    leavew();                                 /* leave */
            ii(0x9b11, 1);    retw();                                   /* ret */
        }
    }
}
