using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7cde-503038e6")]
        public void Method_0000_7cde()
        {
            ii(0x7cde, 3);    pushw(0x9b);                              /* push 0x9b */
            ii(0x7ce1, 3);    callw(0x7cd4, -0x10);                     /* call 0x7cd4 */
            ii(0x7ce4, 1);    dec(ax);                                  /* dec ax */
            ii(0x7ce5, 1);    pushw(ax);                                /* push ax */
            ii(0x7ce6, 3);    mov(memw_a16[ds, 0x930], ax);             /* mov [0x930], ax */
            ii(0x7ce9, 4);    mov(dx, memw_a16[ds, 0xa12]);             /* mov dx, [0xa12] */
            ii(0x7ced, 3);    mov(ax, memw_a16[ds, 0xa10]);             /* mov ax, [0xa10] */
            ii(0x7cf0, 1);    pushw(dx);                                /* push dx */
            ii(0x7cf1, 1);    pushw(ax);                                /* push ax */
            ii(0x7cf2, 3);    mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0x7cf5:
            ii(0x7cf5, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x7cf7, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x7cf9, 2);    if(loopw_a16(0x7cf5, -0x6)) goto l_0x7cf5; /* loop 0x7cf5 */
            ii(0x7cfb, 3);    mov(memw_a16[ds, 0x932], ax);             /* mov [0x932], ax */
            ii(0x7cfe, 4);    mov(memb_a16[ds, 0x934], dl);             /* mov [0x934], dl */
            ii(0x7d02, 4);    mov(memb_a16[ds, 0x937], dh);             /* mov [0x937], dh */
            ii(0x7d06, 2);    pushw(0xe);                               /* push 0xe */
            ii(0x7d08, 3);    callw(0x7a5a, -0x2b1);                    /* call 0x7a5a */
            ii(0x7d0b, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x7d0e, 1);    retw(); return;                           /* ret */
        }
    }
}
