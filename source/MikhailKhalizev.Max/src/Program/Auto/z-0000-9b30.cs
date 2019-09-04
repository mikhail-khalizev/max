using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9b30-c8cb18ae")]
        public void Method_0000_9b30()
        {
            ii(0x9b30, 4);    enter(0x10, 0);                           /* enter 0x10, 0x0 */
            ii(0x9b34, 1);    push(di);                                 /* push di */
            ii(0x9b35, 1);    push(si);                                 /* push si */
            ii(0x9b36, 5);    mov(memw[ss, bp - 8], 0);                 /* mov word [bp-0x8], 0x0 */
            ii(0x9b3b, 5);    mov(memw[ss, bp - 6], 8);                 /* mov word [bp-0x6], 0x8 */
        l_0x9b40:
            ii(0x9b40, 3);    mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x9b43, 5);    mov(memw[ss, bp - 4], 0);                 /* mov word [bp-0x4], 0x0 */
            ii(0x9b48, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
        l_0x9b4b:
            ii(0x9b4b, 3);    les(bx, memw[ss, bp - 4]);                /* les bx, [bp-0x4] */
            ii(0x9b4e, 3);    mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x9b51, 3);    mov(memw[ss, bp - 16], ax);               /* mov [bp-0x10], ax */
            ii(0x9b54, 3);    mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x9b57, 3);    add(memw[es, bx], ax);                    /* add [es:bx], ax */
            ii(0x9b5a, 3);    mov(cx, memw[ss, bp - 16]);               /* mov cx, [bp-0x10] */
            ii(0x9b5d, 3);    and(cl, 0xf8);                            /* and cl, 0xf8 */
            ii(0x9b60, 2);    add(ax, cx);                              /* add ax, cx */
            ii(0x9b62, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0x9b64, 3);    mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x9b67, 3);    les(bx, memw[ss, bp - 8]);                /* les bx, [bp-0x8] */
            ii(0x9b6a, 4);    mov(al, memb[es, bx + 5]);                /* mov al, [es:bx+0x5] */
            ii(0x9b6e, 2);    sub(ah, ah);                              /* sub ah, ah */
            ii(0x9b70, 3);    mov(memw[ss, bp - 14], ax);               /* mov [bp-0xe], ax */
            ii(0x9b73, 5);    mov(memb[es, bx + 5], 0x92);              /* mov byte [es:bx+0x5], 0x92 */
            ii(0x9b78, 4);    add(memw[ss, bp - 4], 2);                 /* add word [bp-0x4], 0x2 */
            ii(0x9b7c, 3);    les(bx, memw[ss, bp - 4]);                /* les bx, [bp-0x4] */
            ii(0x9b7f, 3);    mov(di, memw[es, bx]);                    /* mov di, [es:bx] */
            ii(0x9b82, 3);    lea(ax, memw[ds, bx + 2]);                /* lea ax, [bx+0x2] */
            ii(0x9b85, 3);    mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x9b88, 2);    jmp(0x9ba5, 0x1b); goto l_0x9ba5;         /* jmp 0x9ba5 */
        l_0x9b8a:
            ii(0x9b8a, 3);    les(bx, memw[ss, bp - 4]);                /* les bx, [bp-0x4] */
            ii(0x9b8d, 4);    add(memw[ss, bp - 4], 2);                 /* add word [bp-0x4], 0x2 */
            ii(0x9b91, 3);    mov(bx, memw[es, bx]);                    /* mov bx, [es:bx] */
            ii(0x9b94, 2);    mov(cx, si);                              /* mov cx, si */
            ii(0x9b96, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x9b98, 5);    cmp(memw[es, bx], 0x80);                  /* cmp word [es:bx], 0x80 */
            ii(0x9b9d, 2);    if(jb(0x9ba5, 6)) goto l_0x9ba5;          /* jb 0x9ba5 */
            ii(0x9b9f, 3);    mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x9ba2, 3);    add(memw[es, bx], ax);                    /* add [es:bx], ax */
        l_0x9ba5:
            ii(0x9ba5, 1);    dec(di);                                  /* dec di */
            ii(0x9ba6, 2);    if(jns(0x9b8a, -0x1e)) goto l_0x9b8a;     /* jns 0x9b8a */
            ii(0x9ba8, 3);    mov(al, memb[ss, bp - 14]);               /* mov al, [bp-0xe] */
            ii(0x9bab, 3);    les(bx, memw[ss, bp - 8]);                /* les bx, [bp-0x8] */
            ii(0x9bae, 4);    mov(memb[es, bx + 5], al);                /* mov [es:bx+0x5], al */
            ii(0x9bb2, 4);    test(memb[ss, bp - 16], 3);               /* test byte [bp-0x10], 0x3 */
            ii(0x9bb6, 2);    if(jz(0x9b4b, -0x6d)) goto l_0x9b4b;      /* jz 0x9b4b */
            ii(0x9bb8, 4);    add(memw[ss, bp + 4], 8);                 /* add word [bp+0x4], 0x8 */
            ii(0x9bbc, 4);    test(memb[ss, bp - 16], 2);               /* test byte [bp-0x10], 0x2 */
            ii(0x9bc0, 2);    if(jnz(0x9bc5, 3)) goto l_0x9bc5;         /* jnz 0x9bc5 */
            ii(0x9bc2, 3);    jmp(0x9b40, -0x85); goto l_0x9b40;        /* jmp 0x9b40 */
        l_0x9bc5:
            ii(0x9bc5, 1);    pop(si);                                  /* pop si */
            ii(0x9bc6, 1);    pop(di);                                  /* pop di */
            ii(0x9bc7, 1);    leave();                                  /* leave */
            ii(0x9bc8, 1);    ret();                                    /* ret */
        }
    }
}
