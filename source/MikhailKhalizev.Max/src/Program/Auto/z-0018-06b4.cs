using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_06b4-3d7e8d72")]
        public void Method_0018_06b4()
        {
            ii(0x18_06b4, 4); movzx(eax, ax);                           /* movzx eax, ax */
            ii(0x18_06b8, 4); movzx(ebx, bx);                           /* movzx ebx, bx */
            ii(0x18_06bc, 4); movzx(ecx, cx);                           /* movzx ecx, cx */
            ii(0x18_06c0, 4); movzx(edx, dx);                           /* movzx edx, dx */
            ii(0x18_06c4, 4); movzx(edi, di);                           /* movzx edi, di */
            ii(0x18_06c8, 4); movzx(esi, si);                           /* movzx esi, si */
            ii(0x18_06cc, 1); retf();                                   /* retf */
        }
    }
}
