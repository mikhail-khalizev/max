using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("328a771d-c227-4789-b2a6-46d4285bb846")]
        public void Method_0000_fa54()
        {
            ii(0xfa54, 1);    pushw(bp);                                /* push bp */
            ii(0xfa55, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xfa57, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0xfa59, 1);    popw(ds);                                 /* pop ds */
            ii(0xfa5a, 1);    pushfw();                                 /* pushfw */
            ii(0xfa5b, 1);    cli();                                    /* cli */
            ii(0xfa5c, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0xfa5f, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0xfa62, 3);    mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0xfa65, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0xfa67, 3);    mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
            ii(0xfa6a, 3);    mov(memb_a16[ds, bx + 0x5], al);          /* mov [bx+0x5], al */
            ii(0xfa6d, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0xfa70, 3);    mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0xfa73, 3);    mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0xfa76:
            ii(0xfa76, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xfa78, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0xfa7a, 2);    if(loopw_a16(0xfa76, -0x6)) goto l_0xfa76; /* loop 0xfa76 */
            ii(0xfa7c, 3);    mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0xfa7f, 3);    mov(memb_a16[ds, bx + 0x4], dl);          /* mov [bx+0x4], dl */
            ii(0xfa82, 3);    mov(memb_a16[ds, bx + 0x7], dh);          /* mov [bx+0x7], dh */
            ii(0xfa85, 1);    popw(dx);                                 /* pop dx */
            ii(0xfa86, 1);    popw(bp);                                 /* pop bp */
            ii(0xfa87, 1);    popw(ax);                                 /* pop ax */
            ii(0xfa88, 2);    mov(cx, ss);                              /* mov cx, ss */
            ii(0xfa8a, 2);    mov(ss, cx);                              /* mov ss, cx */
            ii(0xfa8c, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0xfa8e, 1);    popw(ds);                                 /* pop ds */
            ii(0xfa8f, 1);    pushw(dx);                                /* push dx */
            ii(0xfa90, 1);    popfw();                                  /* popfw */
            ii(0xfa91, 2);    if(jmpw_abs(ax)) return;                  /* jmp ax */
        }
    }
}
