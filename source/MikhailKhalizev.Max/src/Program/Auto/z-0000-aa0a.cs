using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("37dc2121-424e-44c3-ac14-5ea168e704ba")]
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
