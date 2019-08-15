using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3a7a37ce-dc56-4840-9783-7b079e565239")]
        public void Method_1014_5632()
        {
            ii(0x1014_5632, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_5637, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0716); /* call 0x10165d52 */
            ii(0x1014_563c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_563d, 1); pushd(esi);                             /* push esi */
            ii(0x1014_563e, 1); pushd(edi);                             /* push edi */
            ii(0x1014_563f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5640, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5642, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_5648, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_564b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_564e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_5651, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5654, 5); calld(0x1013_aaa8, -0xabb1);            /* call 0x1013aaa8 */
            ii(0x1014_5659, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_565c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1014_565f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_5662, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_5665, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5668, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_566b, 5); calld(0x1013_b57c, -0xa0f4);            /* call 0x1013b57c */
            ii(0x1014_5670, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1014_5673, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_5676, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_567a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_567d, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_5680, 5); calld(0x1013_b603, -0xa082);            /* call 0x1013b603 */
            ii(0x1014_5685, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1014_5688, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_568b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_568e, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_7208); /* mov dword [eax+0x2], 0x101b7208 */
            ii(0x1014_5695, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5698, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_569b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_569e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_56a0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_56a1, 1); popd(edi);                              /* pop edi */
            ii(0x1014_56a2, 1); popd(esi);                              /* pop esi */
            ii(0x1014_56a3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_56a4, 1); retd(); return;                         /* ret */
        }
    }
}
