using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("11d38923-0e05-4095-a93a-c52689e6b416")]
        public void Method_1013_ba3c()
        {
            ii(0x1013_ba3c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_ba41, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a30c); /* call 0x10165d52 */
            ii(0x1013_ba46, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_ba47, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_ba48, 1); pushd(edx);                             /* push edx */
            ii(0x1013_ba49, 1); pushd(esi);                             /* push esi */
            ii(0x1013_ba4a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_ba4b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_ba4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ba4e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_ba54, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_ba57, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ba5a, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_ba5d, 5); calld(0x1013_b325, -0x73d);             /* call 0x1013b325 */
            ii(0x1013_ba62, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ba65, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1013_ba68, 2); if(jzd(0x1013_ba74, 0xa)) goto l_0x1013_ba74; /* jz 0x1013ba74 */
            ii(0x1013_ba6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ba6d, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_ba6f, 5); calld(Definitions.sys_fclose, 0x3_65f5); /* call 0x10172069 */
        l_0x1013_ba74:
            ii(0x1013_ba74, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_ba77, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1013_ba7d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ba7f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_ba80, 1); popd(edi);                              /* pop edi */
            ii(0x1013_ba81, 1); popd(esi);                              /* pop esi */
            ii(0x1013_ba82, 1); popd(edx);                              /* pop edx */
            ii(0x1013_ba83, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_ba84, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_ba85, 1); retd(); return;                         /* ret */
        }
    }
}
