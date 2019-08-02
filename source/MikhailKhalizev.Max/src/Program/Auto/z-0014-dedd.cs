using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("af3f7797-c5fd-46e5-bf30-dfbef0cb2d21")]
        public void Method_0014_dedd()
        {
            ii(0x14_dedd, 1); pushw(cx);                                /* push cx */
            ii(0x14_dede, 3); mov(cx, 0x404e);                          /* mov cx, 0x404e */
            ii(0x14_dee1, 3); callw(0x14_ee48, 0xf64);                  /* call 0xee48 */
            ii(0x14_dee4, 1); popw(cx);                                 /* pop cx */
            ii(0x14_dee5, 8); jmpd_far_abs(0x80, 0x38); return;         /* jmp dword 0x80:0x80 */
        }
    }
}
