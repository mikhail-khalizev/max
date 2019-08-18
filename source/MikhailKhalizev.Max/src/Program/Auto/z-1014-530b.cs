using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c6ef47f2-0d36-49b3-973b-c6823b2deed3")]
        public void Method_1014_530b()
        {
            ii(0x1014_530b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_5310, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0a3d); /* call 0x10165d52 */
            ii(0x1014_5315, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5316, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5317, 1); pushd(edx);                             /* push edx */
            ii(0x1014_5318, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5319, 1); pushd(edi);                             /* push edi */
            ii(0x1014_531a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_531b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_531d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_5323, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_5326, 5); mov(edx, StringDefinitions.ExpectingAPointer); /* mov edx, 0x101acfde */
            ii(0x1014_532b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_532e, 5); calld(0x1014_5151, -0x1e2);             /* call 0x10145151 */
            ii(0x1014_5333, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_533a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_533d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_533f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5340, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5341, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5342, 1); popd(edx);                              /* pop edx */
            ii(0x1014_5343, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5344, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5345, 1); retd(); return;                         /* ret */
        }
    }
}
