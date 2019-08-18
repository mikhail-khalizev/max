using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("986999fc-83a4-4bb8-8a90-fad09e99c58e")]
        public void Method_0000_9bc9()
        {
            ii(0x9bc9, 4);    enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x9bcd, 1);    pushw(di);                                /* push di */
            ii(0x9bce, 1);    pushw(si);                                /* push si */
            ii(0x9bcf, 5);    mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x9bd4, 5);    mov(memw_a16[ss, bp - 0x6], 0x8);         /* mov word [bp-0x6], 0x8 */
        l_0x9bd9:
            ii(0x9bd9, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x9bdc, 5);    mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x9be1, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x9be4:
            ii(0x9be4, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x9be7, 3);    mov(si, memw_a16[es, bx]);                /* mov si, [es:bx] */
            ii(0x9bea, 3);    mov(memw_a16[ss, bp - 0x10], si);         /* mov [bp-0x10], si */
            ii(0x9bed, 3);    and(si, -0x8 /* 0xf8 */);                 /* and si, 0xfff8 */
            ii(0x9bf0, 3);    cmp(si, memw_a16[ss, bp + 0x8]);          /* cmp si, [bp+0x8] */
            ii(0x9bf3, 2);    if(jnzw(0x9c04, 0xf)) goto l_0x9c04;      /* jnz 0x9c04 */
            ii(0x9bf5, 3);    mov(al, memb_a16[ss, bp - 0x10]);         /* mov al, [bp-0x10] */
            ii(0x9bf8, 3);    xor(al, memb_a16[ss, bp + 0xa]);          /* xor al, [bp+0xa] */
            ii(0x9bfb, 3);    and(ax, 0x7);                             /* and ax, 0x7 */
            ii(0x9bfe, 3);    xor(ax, memw_a16[ss, bp + 0xa]);          /* xor ax, [bp+0xa] */
            ii(0x9c01, 3);    mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
        l_0x9c04:
            ii(0x9c04, 3);    mov(memw_a16[ss, bp - 0x8], si);          /* mov [bp-0x8], si */
            ii(0x9c07, 3);    mov(memw_a16[ss, bp - 0xa], si);          /* mov [bp-0xa], si */
            ii(0x9c0a, 3);    les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x9c0d, 4);    mov(al, memb_a16[es, bx + 0x5]);          /* mov al, [es:bx+0x5] */
            ii(0x9c11, 2);    sub(ah, ah);                              /* sub ah, ah */
            ii(0x9c13, 3);    mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x9c16, 5);    mov(memb_a16[es, bx + 0x5], 0x92);        /* mov byte [es:bx+0x5], 0x92 */
            ii(0x9c1b, 4);    add(memw_a16[ss, bp - 0x4], 0x2);         /* add word [bp-0x4], 0x2 */
            ii(0x9c1f, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x9c22, 3);    mov(di, memw_a16[es, bx]);                /* mov di, [es:bx] */
            ii(0x9c25, 3);    lea(ax, bx + 0x2);                        /* lea ax, [bx+0x2] */
            ii(0x9c28, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x9c2b, 2);    jmpw(0x9c4c, 0x1f); goto l_0x9c4c;        /* jmp 0x9c4c */
        l_0x9c2d:
            ii(0x9c2d, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x9c30, 4);    add(memw_a16[ss, bp - 0x4], 0x2);         /* add word [bp-0x4], 0x2 */
            ii(0x9c34, 3);    mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x9c37, 3);    mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0x9c3a, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x9c3c, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x9c3e, 3);    mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x9c41, 3);    cmp(memw_a16[es, bx], cx);                /* cmp [es:bx], cx */
            ii(0x9c44, 2);    if(jnzw(0x9c4c, 0x6)) goto l_0x9c4c;      /* jnz 0x9c4c */
            ii(0x9c46, 3);    mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x9c49, 3);    mov(memw_a16[es, bx], cx);                /* mov [es:bx], cx */
        l_0x9c4c:
            ii(0x9c4c, 1);    dec(di);                                  /* dec di */
            ii(0x9c4d, 2);    if(jnsw(0x9c2d, -0x22)) goto l_0x9c2d;    /* jns 0x9c2d */
            ii(0x9c4f, 3);    mov(al, memb_a16[ss, bp - 0xe]);          /* mov al, [bp-0xe] */
            ii(0x9c52, 3);    les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x9c55, 4);    mov(memb_a16[es, bx + 0x5], al);          /* mov [es:bx+0x5], al */
            ii(0x9c59, 4);    test(memb_a16[ss, bp - 0x10], 0x3);       /* test byte [bp-0x10], 0x3 */
            ii(0x9c5d, 2);    if(jzw(0x9be4, -0x7b)) goto l_0x9be4;     /* jz 0x9be4 */
            ii(0x9c5f, 4);    add(memw_a16[ss, bp + 0x4], 0x8);         /* add word [bp+0x4], 0x8 */
            ii(0x9c63, 4);    test(memb_a16[ss, bp - 0x10], 0x2);       /* test byte [bp-0x10], 0x2 */
            ii(0x9c67, 2);    if(jnzw(0x9c6c, 0x3)) goto l_0x9c6c;      /* jnz 0x9c6c */
            ii(0x9c69, 3);    jmpw(0x9bd9, -0x93); goto l_0x9bd9;       /* jmp 0x9bd9 */
        l_0x9c6c:
            ii(0x9c6c, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x9c6f, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x9c72, 3);    les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x9c75, 5);    mov(memb_a16[es, bx + 0x5], 0x80);        /* mov byte [es:bx+0x5], 0x80 */
            ii(0x9c7a, 3);    mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x9c7d, 3);    les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x9c80, 4);    mov(memw_a16[es, bx + 0x6], ax);          /* mov [es:bx+0x6], ax */
            ii(0x9c84, 1);    popw(si);                                 /* pop si */
            ii(0x9c85, 1);    popw(di);                                 /* pop di */
            ii(0x9c86, 1);    leavew();                                 /* leave */
            ii(0x9c87, 1);    retw(); return;                           /* ret */
        }
    }
}
