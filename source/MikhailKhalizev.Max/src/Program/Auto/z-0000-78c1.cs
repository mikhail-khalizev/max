using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x78c1-a9872dd2")]
        public void Method_0000_78c1()
        {
            ii(0x78c1, 4);    enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x78c5, 1);    push(di);                                 /* push di */
            ii(0x78c6, 1);    push(si);                                 /* push si */
            ii(0x78c7, 3);    call(0x572a, -0x21a0);                    /* call 0x572a */
            ii(0x78ca, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x78cd, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x78cf, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x78d1, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x78d3, 3);    mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0x78d6, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x78d9, 3);    sub(ax, 0x8);                             /* sub ax, 0x8 */
            ii(0x78dc, 3);    mov(memw[ss, bp - 0xe], dx);              /* mov [bp-0xe], dx */
            ii(0x78df, 3);    mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x78e2, 3);    or(bl, 0x8);                              /* or bl, 0x8 */
            ii(0x78e5, 3);    mov(memw[ss, bp - 0xa], cx);              /* mov [bp-0xa], cx */
            ii(0x78e8, 3);    mov(memw[ss, bp - 0x8], bx);              /* mov [bp-0x8], bx */
            ii(0x78eb, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x78ed, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0x78ef, 3);    mov(si, memw[es, bx]);                    /* mov si, [es:bx] */
            ii(0x78f2, 1);    inc(si);                                  /* inc si */
            ii(0x78f3, 2);    shr(si, 0x1);                             /* shr si, 1 */
            ii(0x78f5, 2);    jmp(0x7962, 0x6b); goto l_0x7962;         /* jmp 0x7962 */
        l_0x78f7:
            ii(0x78f7, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x78f9, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x78fb, 3);    add(bx, memw[ss, bp - 0xe]);              /* add bx, [bp-0xe] */
            ii(0x78fe, 3);    mov(es, memw[ss, bp - 0xc]);              /* mov es, [bp-0xc] */
            ii(0x7901, 3);    mov(di, memw[es, bx]);                    /* mov di, [es:bx] */
            ii(0x7904, 4);    cmp(di, 0x80);                            /* cmp di, 0x80 */
            ii(0x7908, 2);    if(jb(0x7962, 0x58)) goto l_0x7962;       /* jb 0x7962 */
            ii(0x790a, 3);    add(di, memw[ss, bp + 0x6]);              /* add di, [bp+0x6] */
            ii(0x790d, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x790f, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x7911, 2);    mov(ax, bx);                              /* mov ax, bx */
            ii(0x7913, 3);    add(bx, memw[ss, bp - 0xe]);              /* add bx, [bp-0xe] */
            ii(0x7916, 3);    mov(memw[es, bx], di);                    /* mov [es:bx], di */
            ii(0x7919, 2);    mov(cx, di);                              /* mov cx, di */
            ii(0x791b, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x791d, 3);    mov(memw[ss, bp - 0x16], cx);             /* mov [bp-0x16], cx */
            ii(0x7920, 3);    or(dl, 0x8);                              /* or dl, 0x8 */
            ii(0x7923, 3);    mov(memw[ss, bp - 0xa], cx);              /* mov [bp-0xa], cx */
            ii(0x7926, 3);    mov(memw[ss, bp - 0x8], dx);              /* mov [bp-0x8], dx */
            ii(0x7929, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x792b, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x792d, 4);    mov(cl, memb[es, bx + 0x5]);              /* mov cl, [es:bx+0x5] */
            ii(0x7931, 3);    mov(memb[ss, bp - 0x2], cl);              /* mov [bp-0x2], cl */
            ii(0x7934, 5);    mov(memb[es, bx + 0x5], 0x92);            /* mov byte [es:bx+0x5], 0x92 */
            ii(0x7939, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x793b, 3);    add(bx, memw[ss, bp - 0x6]);              /* add bx, [bp-0x6] */
            ii(0x793e, 3);    mov(es, memw[ss, bp - 0x4]);              /* mov es, [bp-0x4] */
            ii(0x7941, 3);    mov(ax, memw[ss, bp - 0x16]);             /* mov ax, [bp-0x16] */
            ii(0x7944, 3);    mov(cx, memw[es, bx]);                    /* mov cx, [es:bx] */
            ii(0x7947, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x7949, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0x794b, 5);    cmp(memw[es, bx], 0x80);                  /* cmp word [es:bx], 0x80 */
            ii(0x7950, 2);    if(jb(0x7958, 0x6)) goto l_0x7958;        /* jb 0x7958 */
            ii(0x7952, 3);    mov(dx, memw[ss, bp + 0x6]);              /* mov dx, [bp+0x6] */
            ii(0x7955, 3);    add(memw[es, bx], dx);                    /* add [es:bx], dx */
        l_0x7958:
            ii(0x7958, 3);    mov(al, memb[ss, bp - 0x2]);              /* mov al, [bp-0x2] */
            ii(0x795b, 3);    les(bx, memw[ss, bp - 0xa]);              /* les bx, [bp-0xa] */
            ii(0x795e, 4);    mov(memb[es, bx + 0x5], al);              /* mov [es:bx+0x5], al */
        l_0x7962:
            ii(0x7962, 1);    dec(si);                                  /* dec si */
            ii(0x7963, 2);    if(jns(0x78f7, -0x6e)) goto l_0x78f7;     /* jns 0x78f7 */
            ii(0x7965, 3);    call(0x4f61, -0x2a07);                    /* call 0x4f61 */
            ii(0x7968, 1);    pop(si);                                  /* pop si */
            ii(0x7969, 1);    pop(di);                                  /* pop di */
            ii(0x796a, 1);    leave();                                  /* leave */
            ii(0x796b, 1);    ret();                                    /* ret */
        }
    }
}
