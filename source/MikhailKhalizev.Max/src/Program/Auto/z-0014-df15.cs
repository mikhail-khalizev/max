using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("400032fa-5941-4177-a554-4b4979083d99")]
        public void Method_0014_df15()
        {
            ii(0x14_df15, 1); pushw(cx);                                /* push cx */
            ii(0x14_df16, 3); mov(cx, 0x130);                           /* mov cx, 0x130 */
            ii(0x14_df19, 3); callw(0x14_eded, 0xed1);                  /* call 0xeded */
            ii(0x14_df1c, 1); popw(cx);                                 /* pop cx */
            ii(0x14_df1d, 8); if(jmpd_far_abs(0x80, 0x40)) return;      /* jmp dword 0x80:0x80 */
        }
    }
}
