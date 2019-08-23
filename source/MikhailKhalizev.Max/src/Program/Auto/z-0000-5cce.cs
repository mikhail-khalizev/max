using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5cce-503038e6")]
        public void Method_0000_5cce()
        {
            ii(0x5cce, 3);    pushw(0x9b);                              /* push 0x9b */
            ii(0x5cd1, 3);    callw(0x5cc4, -0x10);                     /* call 0x5cc4 */
            ii(0x5cd4, 1);    dec(ax);                                  /* dec ax */
            ii(0x5cd5, 1);    pushw(ax);                                /* push ax */
            ii(0x5cd6, 3);    mov(memw_a16[ds, 0x930], ax);             /* mov [0x930], ax */
            ii(0x5cd9, 4);    mov(dx, memw_a16[ds, 0xa12]);             /* mov dx, [0xa12] */
            ii(0x5cdd, 3);    mov(ax, memw_a16[ds, 0xa10]);             /* mov ax, [0xa10] */
            ii(0x5ce0, 1);    pushw(dx);                                /* push dx */
            ii(0x5ce1, 1);    pushw(ax);                                /* push ax */
            ii(0x5ce2, 3);    mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0x5ce5:
            ii(0x5ce5, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x5ce7, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x5ce9, 2);    if(loopw_a16(0x5ce5, -0x6)) goto l_0x5ce5; /* loop 0x5ce5 */
            ii(0x5ceb, 3);    mov(memw_a16[ds, 0x932], ax);             /* mov [0x932], ax */
            ii(0x5cee, 4);    mov(memb_a16[ds, 0x934], dl);             /* mov [0x934], dl */
            ii(0x5cf2, 4);    mov(memb_a16[ds, 0x937], dh);             /* mov [0x937], dh */
            ii(0x5cf6, 2);    pushw(0xe);                               /* push 0xe */
            ii(0x5cf8, 3);    callw(0x5a4a, -0x2b1);                    /* call 0x5a4a */
            ii(0x5cfb, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x5cfe, 1);    retw();                                   /* ret */
        }
    }
}
