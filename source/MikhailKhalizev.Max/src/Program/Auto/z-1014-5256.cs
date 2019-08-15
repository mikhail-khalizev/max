using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("67eb6c93-505e-43c1-9cee-47de62ac4394")]
        public void Method_1014_5256()
        {
            ii(0x1014_5256, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_525b, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0af2); /* call 0x10165d52 */
            ii(0x1014_5260, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5261, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5262, 1); pushd(edx);                             /* push edx */
            ii(0x1014_5263, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5264, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5265, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5266, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5268, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_526e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_5271, 5); mov(edx, StringDefinitions.ExpectingANumber); /* mov edx, 0x101acfa7 */
            ii(0x1014_5276, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_5279, 5); calld(0x1014_5151, -0x12d);             /* call 0x10145151 */
            ii(0x1014_527e, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_5285, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5288, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_528a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_528b, 1); popd(edi);                              /* pop edi */
            ii(0x1014_528c, 1); popd(esi);                              /* pop esi */
            ii(0x1014_528d, 1); popd(edx);                              /* pop edx */
            ii(0x1014_528e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_528f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5290, 1); retd(); return;                         /* ret */
        }
    }
}
