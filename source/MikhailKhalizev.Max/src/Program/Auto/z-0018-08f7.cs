using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_08f7-b0f1ac8f")]
        public void Method_0018_08f7()
        {
            ii(0x18_08f7, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x18_08fb, 1);  push(ds);                               /* push ds */
            ii(0x18_08fc, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x18_08ff, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x18_0901, 1);  push(ds);                               /* push ds */
            ii(0x18_0902, 1);  push(ss);                               /* push ss */
            ii(0x18_0903, 1);  pop(ds);                                /* pop ds */
            ii(0x18_0904, 2);  push(0);                                /* push 0x0 */
            ii(0x18_0906, 2);  push(0);                                /* push 0x0 */
            ii(0x18_0908, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x18_090b, 1);  nop();                                  /* nop */
            ii(0x18_090c, 1);  push(cs);                               /* push cs */
            ii(0x18_090d, 3);  call(0x17_dc4c, -0x2cc4);               /* call 0xdc4c */
            ii(0x18_0910, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x18_0913, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_0916, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x18_0919, 1);  pop(ds);                                /* pop ds */
            ii(0x18_091a, 1);  pop(ds);                                /* pop ds */
            ii(0x18_091b, 1);  leave();                                /* leave */
            ii(0x18_091c, 3);  retf(4);                                /* retf 0x4 */
        }
    }
}
