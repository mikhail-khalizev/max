using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9780a715-b8ee-4aef-aa44-f708ea4a5691")]
        public void Method_0000_7b20()
        {
            ii(0x7b20, 4);    enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x7b24, 1);    pushw(di);                                /* push di */
            ii(0x7b25, 1);    pushw(si);                                /* push si */
            ii(0x7b26, 5);    mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x7b2b, 5);    mov(memw_a16[ss, bp - 0x6], 0x8);         /* mov word [bp-0x6], 0x8 */
        l_0x7b30:
            ii(0x7b30, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x7b33, 5);    mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x7b38, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x7b3b:
            ii(0x7b3b, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x7b3e, 3);    mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x7b41, 3);    mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x7b44, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x7b47, 3);    add(memw_a16[es, bx], ax);                /* add [es:bx], ax */
            ii(0x7b4a, 3);    mov(cx, memw_a16[ss, bp - 0x10]);         /* mov cx, [bp-0x10] */
            ii(0x7b4d, 3);    and(cl, 0xf8);                            /* and cl, 0xf8 */
            ii(0x7b50, 2);    add(ax, cx);                              /* add ax, cx */
            ii(0x7b52, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0x7b54, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x7b57, 3);    les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x7b5a, 4);    mov(al, memb_a16[es, bx + 0x5]);          /* mov al, [es:bx+0x5] */
            ii(0x7b5e, 2);    sub(ah, ah);                              /* sub ah, ah */
            ii(0x7b60, 3);    mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x7b63, 5);    mov(memb_a16[es, bx + 0x5], 0x92);        /* mov byte [es:bx+0x5], 0x92 */
            ii(0x7b68, 4);    add(memw_a16[ss, bp - 0x4], 0x2);         /* add word [bp-0x4], 0x2 */
            ii(0x7b6c, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x7b6f, 3);    mov(di, memw_a16[es, bx]);                /* mov di, [es:bx] */
            ii(0x7b72, 3);    lea(ax, bx + 0x2);                        /* lea ax, [bx+0x2] */
            ii(0x7b75, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x7b78, 2);    jmpw(0x7b95, 0x1b); goto l_0x7b95;        /* jmp 0x7b95 */
        l_0x7b7a:
            ii(0x7b7a, 3);    les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x7b7d, 4);    add(memw_a16[ss, bp - 0x4], 0x2);         /* add word [bp-0x4], 0x2 */
            ii(0x7b81, 3);    mov(bx, memw_a16[es, bx]);                /* mov bx, [es:bx] */
            ii(0x7b84, 2);    mov(cx, si);                              /* mov cx, si */
            ii(0x7b86, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x7b88, 5);    cmp(memw_a16[es, bx], 0x80);              /* cmp word [es:bx], 0x80 */
            ii(0x7b8d, 2);    if(jbw(0x7b95, 0x6)) goto l_0x7b95;       /* jb 0x7b95 */
            ii(0x7b8f, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x7b92, 3);    add(memw_a16[es, bx], ax);                /* add [es:bx], ax */
        l_0x7b95:
            ii(0x7b95, 1);    dec(di);                                  /* dec di */
            ii(0x7b96, 2);    if(jnsw(0x7b7a, -0x1e)) goto l_0x7b7a;    /* jns 0x7b7a */
            ii(0x7b98, 3);    mov(al, memb_a16[ss, bp - 0xe]);          /* mov al, [bp-0xe] */
            ii(0x7b9b, 3);    les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x7b9e, 4);    mov(memb_a16[es, bx + 0x5], al);          /* mov [es:bx+0x5], al */
            ii(0x7ba2, 4);    test(memb_a16[ss, bp - 0x10], 0x3);       /* test byte [bp-0x10], 0x3 */
            ii(0x7ba6, 2);    if(jzw(0x7b3b, -0x6d)) goto l_0x7b3b;     /* jz 0x7b3b */
            ii(0x7ba8, 4);    add(memw_a16[ss, bp + 0x4], 0x8);         /* add word [bp+0x4], 0x8 */
            ii(0x7bac, 4);    test(memb_a16[ss, bp - 0x10], 0x2);       /* test byte [bp-0x10], 0x2 */
            ii(0x7bb0, 2);    if(jnzw(0x7bb5, 0x3)) goto l_0x7bb5;      /* jnz 0x7bb5 */
            ii(0x7bb2, 3);    jmpw(0x7b30, -0x85); goto l_0x7b30;       /* jmp 0x7b30 */
        l_0x7bb5:
            ii(0x7bb5, 1);    popw(si);                                 /* pop si */
            ii(0x7bb6, 1);    popw(di);                                 /* pop di */
            ii(0x7bb7, 1);    leavew();                                 /* leave */
            ii(0x7bb8, 1);    retw(); return;                           /* ret */
        }
    }
}
