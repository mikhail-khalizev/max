using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7c72d2f3-7646-47ae-a903-0f7076480186")]
        public void Method_1012_5bdd()
        {
            ii(0x1012_5bdd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5be0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5be2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_5be3, 1); popd(edi);                              /* pop edi */
            ii(0x1012_5be4, 1); popd(esi);                              /* pop esi */
            ii(0x1012_5be5, 1); popd(edx);                              /* pop edx */
            ii(0x1012_5be6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_5be7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_5be8, 1); retd(); return;                         /* ret */
        }
    }
}
