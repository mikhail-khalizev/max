using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4584655d-863c-4eb6-a431-dab859f07db7")]
        public void Method_100b_7650()
        {
            ii(0x100b_7650, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7655, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e6f8); /* call 0x10165d52 */
            ii(0x100b_765a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_765b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_765c, 1); pushd(esi);                             /* push esi */
            ii(0x100b_765d, 1); pushd(edi);                             /* push edi */
            ii(0x100b_765e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_765f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7661, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7667, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_766a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_766d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_7672, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7675, 5); calld(0x1007_5e24, -0x4_1856);          /* call 0x10075e24 */
            ii(0x100b_767a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_767d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7680, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7683, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_7686, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7688, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7689, 1); popd(edi);                              /* pop edi */
            ii(0x100b_768a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_768b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_768c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_768d, 1); retd(); return;                         /* ret */
        }
    }
}
