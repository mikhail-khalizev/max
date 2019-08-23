using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b70c-8c90873")]
        public void Method_1013_b70c()
        {
            ii(0x1013_b70c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_b711, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a63c); /* call 0x10165d52 */
            ii(0x1013_b716, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b717, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b718, 1); pushd(edx);                             /* push edx */
            ii(0x1013_b719, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b71a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b71b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b71c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b71e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_b724, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_b727, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b72a, 6); mov(memd_a32[ds, eax], 0x101b_6ef0);    /* mov dword [eax], 0x101b6ef0 */
            ii(0x1013_b730, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b733, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b736, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b739, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b73b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b73c, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b73d, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b73e, 1); popd(edx);                              /* pop edx */
            ii(0x1013_b73f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b740, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b741, 1); retd();                                 /* ret */
        }
    }
}
