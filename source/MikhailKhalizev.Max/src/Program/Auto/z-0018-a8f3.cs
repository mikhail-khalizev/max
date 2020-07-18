using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a8f3-a73936f7")]
        public void Method_0018_a8f3()
        {
            ii(0x18_a8f3, 3);  call(0x18_ab18, 0x222);                 /* call 0xab18 */
            ii(0x18_a8f6, 2);  if(jb(0x18_a912, 0x1a)) goto l_0x18_a912;/* jb 0xa912 */
            ii(0x18_a8f8, 3);  mov(si, memw[ss, bp + 18]);             /* mov si, [bp+0x12] */
            ii(0x18_a8fb, 4);  mov(di, memw[ds, 0xa]);                 /* mov di, [0xa] */
            ii(0x18_a8ff, 3);  mov(memw[ds, bx + 18], di);             /* mov [bx+0x12], di */
            ii(0x18_a902, 4);  mov(cx, memw[ds, 0xe]);                 /* mov cx, [0xe] */
            ii(0x18_a906, 1);  push(ds);                               /* push ds */
            ii(0x18_a907, 3);  mov(ds, memw[ss, bp + 4]);              /* mov ds, [bp+0x4] */
        l_0x18_a90a:
            ii(0x18_a90a, 1);  lodsb();                                /* lodsb */
            ii(0x18_a90b, 1);  stosb();                                /* stosb */
            ii(0x18_a90c, 2);  or(al, al);                             /* or al, al */
            ii(0x18_a90e, 2);  if(loopne(0x18_a90a, -6)) goto l_0x18_a90a;/* loopne 0xa90a */
            ii(0x18_a910, 1);  pop(ds);                                /* pop ds */
            ii(0x18_a911, 1);  clc();                                  /* clc */
        l_0x18_a912:
            ii(0x18_a912, 1);  ret();                                  /* ret */
        }
    }
}
