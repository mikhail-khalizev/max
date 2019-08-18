using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5c5a2108-651f-41ce-9d53-b98a2d8f719a")]
        public void Method_0018_dedd()
        {
            ii(0x18_dedd, 1); pushw(cx);                                /* push cx */
            ii(0x18_dede, 3); mov(cx, 0x404e);                          /* mov cx, 0x404e */
            ii(0x18_dee1, 3); callw(0x18_ee48, 0xf64);                  /* call 0xee48 */
            ii(0x18_dee4, 1); popw(cx);                                 /* pop cx */
            ii(0x18_dee5, 8); if(jmpd_far_abs(0x80, 0x38)) return;      /* jmp dword 0x80:0x80 */
        }
    }
}
