using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5301-166c90c8")]
        public void Method_0000_5301()
        {
            ii(0x5301, 4);    enter(0x56, 0);                           /* enter 0x56, 0x0 */
            ii(0x5305, 1);    push(si);                                 /* push si */
            ii(0x5306, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x530a, 2);    if(jnz(0x5311, 0x5)) goto l_0x5311;       /* jnz 0x5311 */
            ii(0x530c, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x530e, 1);    pop(si);                                  /* pop si */
            ii(0x530f, 1);    leave();                                  /* leave */
            ii(0x5310, 1);    ret(); return;                            /* ret */
        l_0x5311:
            ii(0x5311, 2);    push(0x30);                               /* push 0x30 */
            ii(0x5313, 2);    push(0);                                  /* push 0x0 */
            ii(0x5315, 3);    lea(ax, memw[ss, bp - 0x56]);             /* lea ax, [bp-0x56] */
            ii(0x5318, 1);    push(ax);                                 /* push ax */
            ii(0x5319, 3);    call(0x5d66, 0xa4a);                      /* call 0x5d66 */
            ii(0x531c, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x531f, 3);    lea(ax, memw[ss, bp - 0x1e]);             /* lea ax, [bp-0x1e] */
            ii(0x5322, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x5325, 3);    mov(memw[ss, bp - 0x18], ss);             /* mov [bp-0x18], ss */
            ii(0x5328, 2);    mov(ax, ss);                              /* mov ax, ss */
            ii(0x532a, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x532c, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x532e, 3);    call(0x5d94, 0xa63);                      /* call 0x5d94 */
            ii(0x5331, 3);    add(ax, memw[ss, bp - 0x1a]);             /* add ax, [bp-0x1a] */
            ii(0x5334, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x5337, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x533a, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x533d, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x533f, 3);    mov(memw[ss, bp - 0x44], ax);             /* mov [bp-0x44], ax */
            ii(0x5342, 3);    mov(memb[ss, bp - 0x42], bl);             /* mov [bp-0x42], bl */
            ii(0x5345, 4);    mov(memb[ss, bp - 0x3a], 0xc0);           /* mov byte [bp-0x3a], 0xc0 */
            ii(0x5349, 5);    mov(memw[ss, bp - 0x38], 0x8000);         /* mov word [bp-0x38], 0x8000 */
            ii(0x534e, 2);    mov(al, 0xf2);                            /* mov al, 0xf2 */
            ii(0x5350, 3);    mov(memb[ss, bp - 0x39], al);             /* mov [bp-0x39], al */
            ii(0x5353, 3);    mov(memb[ss, bp - 0x41], al);             /* mov [bp-0x41], al */
            ii(0x5356, 4);    mov(memb[ss, bp - 0x11], 0x87);           /* mov byte [bp-0x11], 0x87 */
            ii(0x535a, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x535d, 3);    mov(memw[ss, bp - 0x46], ax);             /* mov [bp-0x46], ax */
            ii(0x5360, 3);    mov(memw[ss, bp - 0x3e], ax);             /* mov [bp-0x3e], ax */
            ii(0x5363, 3);    mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0x5366, 3);    lea(ax, memw[ss, bp - 0x56]);             /* lea ax, [bp-0x56] */
            ii(0x5369, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x536c, 3);    mov(memw[ss, bp - 0x18], ss);             /* mov [bp-0x18], ss */
            ii(0x536f, 3);    mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x5372, 2);    mov(ax, ss);                              /* mov ax, ss */
            ii(0x5374, 3);    mov(memw[ss, bp - 0x26], ax);             /* mov [bp-0x26], ax */
            ii(0x5377, 5);    mov(memw[ss, bp - 0x1e], 0xfe);           /* mov word [bp-0x1e], 0xfe */
            ii(0x537c, 3);    lea(ax, memw[ss, bp - 0x26]);             /* lea ax, [bp-0x26] */
            ii(0x537f, 1);    push(ax);                                 /* push ax */
            ii(0x5380, 3);    lea(cx, memw[ss, bp - 0x12]);             /* lea cx, [bp-0x12] */
            ii(0x5383, 1);    push(cx);                                 /* push cx */
            ii(0x5384, 1);    push(cx);                                 /* push cx */
            ii(0x5385, 2);    push(0x15);                               /* push 0x15 */
            ii(0x5387, 3);    call(0x5c2c, 0x8a2);                      /* call 0x5c2c */
            ii(0x538a, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x538d, 3);    mov(ax, memw[ds, 0x11ec]);                /* mov ax, [0x11ec] */
            ii(0x5390, 3);    mov(dx, 0xf000);                          /* mov dx, 0xf000 */
            ii(0x5393, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x5396, 3);    mov(memw[ss, bp - 0x14], dx);             /* mov [bp-0x14], dx */
            ii(0x5399, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x539b, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x539d, 3);    mov(cx, memw[ss, bp + 0x4]);              /* mov cx, [bp+0x4] */
            ii(0x53a0, 4);    sub(memw[es, bx + 0x4], cx);              /* sub [es:bx+0x4], cx */
            ii(0x53a4, 4);    mov(si, memw[es, bx + 0x6]);              /* mov si, [es:bx+0x6] */
            ii(0x53a8, 3);    mov(memw[ss, bp - 0x1c], si);             /* mov [bp-0x1c], si */
            ii(0x53ab, 4);    sub(memw[es, bx + 0x6], cx);              /* sub [es:bx+0x6], cx */
            ii(0x53af, 5);    mov(memw[ss, bp - 0x1e], 0xfc);           /* mov word [bp-0x1e], 0xfc */
            ii(0x53b4, 4);    mov(memb[ss, bp - 0x11], 0x87);           /* mov byte [bp-0x11], 0x87 */
            ii(0x53b8, 5);    mov(memw[ss, bp - 0xe], 0x1);             /* mov word [bp-0xe], 0x1 */
            ii(0x53bd, 3);    lea(ax, memw[ss, bp - 0x26]);             /* lea ax, [bp-0x26] */
            ii(0x53c0, 1);    push(ax);                                 /* push ax */
            ii(0x53c1, 3);    lea(ax, memw[ss, bp - 0x12]);             /* lea ax, [bp-0x12] */
            ii(0x53c4, 1);    push(ax);                                 /* push ax */
            ii(0x53c5, 1);    push(ax);                                 /* push ax */
            ii(0x53c6, 2);    push(0x15);                               /* push 0x15 */
            ii(0x53c8, 3);    call(0x5c2c, 0x861);                      /* call 0x5c2c */
            ii(0x53cb, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x53ce, 3);    mov(ax, memw[ss, bp - 0x1c]);             /* mov ax, [bp-0x1c] */
            ii(0x53d1, 3);    les(bx, memw[ss, bp - 0x16]);             /* les bx, [bp-0x16] */
            ii(0x53d4, 4);    sub(ax, memw[es, bx + 0x6]);              /* sub ax, [es:bx+0x6] */
            ii(0x53d8, 3);    mov(memw[ss, bp + 0x4], ax);              /* mov [bp+0x4], ax */
            ii(0x53db, 4);    sub(memw[ds, 0x120a], ax);                /* sub [0x120a], ax */
            ii(0x53df, 3);    mov(ax, memw[ds, 0x120a]);                /* mov ax, [0x120a] */
            ii(0x53e2, 1);    pop(si);                                  /* pop si */
            ii(0x53e3, 1);    leave();                                  /* leave */
            ii(0x53e4, 1);    ret();                                    /* ret */
        }
    }
}
