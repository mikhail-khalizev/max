using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x551e-503038e6")]
        public void Method_0000_551e()
        {
            ii(0x551e, 3);    push(0x9b);                               /* push 0x9b */
            ii(0x5521, 3);    call(0x5514, -0x10);                      /* call 0x5514 */
            ii(0x5524, 1);    dec(ax);                                  /* dec ax */
            ii(0x5525, 1);    push(ax);                                 /* push ax */
            ii(0x5526, 3);    mov(memw[ds, 0x930], ax);                 /* mov [0x930], ax */
            ii(0x5529, 4);    mov(dx, memw[ds, 0xa12]);                 /* mov dx, [0xa12] */
            ii(0x552d, 3);    mov(ax, memw[ds, 0xa10]);                 /* mov ax, [0xa10] */
            ii(0x5530, 1);    push(dx);                                 /* push dx */
            ii(0x5531, 1);    push(ax);                                 /* push ax */
            ii(0x5532, 3);    mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0x5535:
            ii(0x5535, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x5537, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x5539, 2);    if(loop(0x5535, -0x6)) goto l_0x5535;     /* loop 0x5535 */
            ii(0x553b, 3);    mov(memw[ds, 0x932], ax);                 /* mov [0x932], ax */
            ii(0x553e, 4);    mov(memb[ds, 0x934], dl);                 /* mov [0x934], dl */
            ii(0x5542, 4);    mov(memb[ds, 0x937], dh);                 /* mov [0x937], dh */
            ii(0x5546, 2);    push(0xe);                                /* push 0xe */
            ii(0x5548, 3);    call(0x529a, -0x2b1);                     /* call 0x529a */
            ii(0x554b, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x554e, 1);    ret();                                    /* ret */
        }
    }
}
