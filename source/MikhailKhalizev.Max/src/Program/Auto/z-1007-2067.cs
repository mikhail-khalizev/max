using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2067-b1ea12d8")]
        public void Method_1007_2067()
        {
            ii(0x1007_2067, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_206a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_206c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_206d, 1); popd(edi);                              /* pop edi */
            ii(0x1007_206e, 1); popd(esi);                              /* pop esi */
            ii(0x1007_206f, 1); popd(edx);                              /* pop edx */
            ii(0x1007_2070, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_2071, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_2072, 1); retd(); return;                         /* ret */
        }
    }
}
