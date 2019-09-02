using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfa54-d04f0bae")]
        public void Method_0000_fa54()
        {
            ii(0xfa54, 1);    push(bp);                                 /* push bp */
            ii(0xfa55, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xfa57, 2);    push(8);                                  /* push 0x8 */
            ii(0xfa59, 1);    pop(ds);                                  /* pop ds */
            ii(0xfa5a, 1);    pushfw();                                 /* pushfw */
            ii(0xfa5b, 1);    cli();                                    /* cli */
            ii(0xfa5c, 3);    mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0xfa5f, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0xfa62, 3);    mov(ax, memw[ss, bp + 10]);               /* mov ax, [bp+0xa] */
            ii(0xfa65, 2);    mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0xfa67, 3);    mov(al, memb[ss, bp + 12]);               /* mov al, [bp+0xc] */
            ii(0xfa6a, 3);    mov(memb[ds, bx + 5], al);                /* mov [bx+0x5], al */
            ii(0xfa6d, 3);    mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0xfa70, 3);    mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0xfa73, 3);    mov(cx, 4);                               /* mov cx, 0x4 */
        l_0xfa76:
            ii(0xfa76, 2);    shl(ax, 1);                               /* shl ax, 1 */
            ii(0xfa78, 2);    rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0xfa7a, 2);    if(loop(0xfa76, -6)) goto l_0xfa76;       /* loop 0xfa76 */
            ii(0xfa7c, 3);    mov(memw[ds, bx + 2], ax);                /* mov [bx+0x2], ax */
            ii(0xfa7f, 3);    mov(memb[ds, bx + 4], dl);                /* mov [bx+0x4], dl */
            ii(0xfa82, 3);    mov(memb[ds, bx + 7], dh);                /* mov [bx+0x7], dh */
            ii(0xfa85, 1);    pop(dx);                                  /* pop dx */
            ii(0xfa86, 1);    pop(bp);                                  /* pop bp */
            ii(0xfa87, 1);    pop(ax);                                  /* pop ax */
            ii(0xfa88, 2);    mov(cx, ss);                              /* mov cx, ss */
            ii(0xfa8a, 2);    mov(ss, cx);                              /* mov ss, cx */
            ii(0xfa8c, 2);    push(0x20);                               /* push 0x20 */
            ii(0xfa8e, 1);    pop(ds);                                  /* pop ds */
            ii(0xfa8f, 1);    push(dx);                                 /* push dx */
            ii(0xfa90, 1);    popfw();                                  /* popfw */
            ii(0xfa91, 2);    jmp_abs(ax);                              /* jmp ax */
        }
    }
}
