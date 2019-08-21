using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3c47-f9fa8f66")]
        public void Method_1016_3c47()
        {
            ii(0x1016_3c47, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_3c4a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_3c4c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_3c4d, 1); popd(edi);                              /* pop edi */
            ii(0x1016_3c4e, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3c4f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3c50, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_3c51, 1); retd(); return;                         /* ret */
        }
    }
}
