using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f0888d84-24b3-43ac-a359-c454e597491e")]
        public void Method_0018_df15()
        {
            ii(0x18_df15, 1); pushw(cx);                                /* push cx */
            ii(0x18_df16, 3); mov(cx, 0x130);                           /* mov cx, 0x130 */
            ii(0x18_df19, 3); callw(0x18_eded, 0xed1);                  /* call 0xeded */
            ii(0x18_df1c, 1); popw(cx);                                 /* pop cx */
            ii(0x18_df1d, 8); if(jmpd_far_abs(0x80, 0x40)) return;      /* jmp dword 0x80:0x80 */
        }
    }
}
