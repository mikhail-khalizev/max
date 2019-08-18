using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaa0a-8f5dbe2b")]
        public void Method_0000_aa0a()
        {
            ii(0xaa0a, 2);    pushw(0x26);                              /* push 0x26 */
            ii(0xaa0c, 3);    callw(0x524c, -0x57c3);                   /* call 0x524c */
            ii(0xaa0f, 1);    popw(cx);                                 /* pop cx */
            ii(0xaa10, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xaa12, 2);    if(jmpw_func(0xaa5f, 0x4b)) return;       /* jmp 0xaa5f */
        }
    }
}
