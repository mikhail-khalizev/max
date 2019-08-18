using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("92d4179a-a59d-4476-917b-da07fda157bf")]
        public void Method_100d_5224()
        {
            ii(0x100d_5224, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_5225, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_5226, 1); pushd(edx);                             /* push edx */
            ii(0x100d_5227, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5228, 1); pushd(edi);                             /* push edi */
            ii(0x100d_5229, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_522a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_522c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_5232, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_5235, 5); mov(edx, 0x101c_35a8);                  /* mov edx, 0x101c35a8 */
            ii(0x100d_523a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_523d, 5); calld(0x100d_4d78, -0x4ca);             /* call 0x100d4d78 */
            ii(0x100d_5242, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_5245, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5247, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_5248, 1); popd(edi);                              /* pop edi */
            ii(0x100d_5249, 1); popd(esi);                              /* pop esi */
            ii(0x100d_524a, 1); popd(edx);                              /* pop edx */
            ii(0x100d_524b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_524c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_524d, 1); retd(); return;                         /* ret */
        }
    }
}
