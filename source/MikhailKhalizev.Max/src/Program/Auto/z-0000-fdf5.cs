using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cdbe69df-8904-4604-8634-cbe1f9c0f77d")]
        public void Method_0000_fdf5()
        {
            ii(0xfdf5, 1);    pushw(cx);                                /* push cx */
            ii(0xfdf6, 3);    mov(cx, 0x148);                           /* mov cx, 0x148 */
            ii(0xfdf9, 3);    callw(0x1_0e08, 0x100c);                  /* call 0xe08 */
            ii(0xfdfc, 1);    popw(cx);                                 /* pop cx */
            ii(0xfdfd, 8);    if(jmpd_far_abs(0x70, 0x20)) return;      /* jmp dword 0x70:0x70 */
        }
    }
}
