using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("883dfa76-3e1b-4219-b3f2-dc16f47b5022")]
        public void Method_0014_06b4()
        {
            ii(0x14_06b4, 4); movzx(eax, ax);                           /* movzx eax, ax */
            ii(0x14_06b8, 4); movzx(ebx, bx);                           /* movzx ebx, bx */
            ii(0x14_06bc, 4); movzx(ecx, cx);                           /* movzx ecx, cx */
            ii(0x14_06c0, 4); movzx(edx, dx);                           /* movzx edx, dx */
            ii(0x14_06c4, 4); movzx(edi, di);                           /* movzx edi, di */
            ii(0x14_06c8, 4); movzx(esi, si);                           /* movzx esi, si */
            ii(0x14_06cc, 1); retfw(); return;                          /* retf */
        }
    }
}
