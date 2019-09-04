using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa25a-8f5dbe2b")]
        public void Method_0000_a25a()
        {
            ii(0xa25a, 2);  push(0x26);                                /* push 0x26 */
            ii(0xa25c, 3);  call(0x4a9c, -0x57c3);                     /* call 0x4a9c */
            ii(0xa25f, 1);  pop(cx);                                   /* pop cx */
            ii(0xa260, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0xa262, 2);  if(jmp_func(0xa2af, 0x4b)) return;         /* jmp 0xa2af */
        }
    }
}
