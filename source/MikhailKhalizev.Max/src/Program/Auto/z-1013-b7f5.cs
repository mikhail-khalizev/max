using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b705dde2-5ef6-4581-8122-28a85e4da891")]
        public void Method_1013_b7f5()
        {
            ii(0x1013_b7f5, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_b7fa, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a553); /* call 0x10165d52 */
            ii(0x1013_b7ff, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b800, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b801, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b802, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b803, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b804, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b806, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_b80c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b80f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b812, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_b816, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b819, 5); calld(0x1013_b399, -0x485);             /* call 0x1013b399 */
            ii(0x1013_b81e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b821, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_b824, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b827, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b82a, 7); mov(memd_a32[ds, eax + 0xa], 0x101b_6f1c); /* mov dword [eax+0xa], 0x101b6f1c */
            ii(0x1013_b831, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b834, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_b837, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b83a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b83c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b83d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b83e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b83f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b840, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b841, 1); retd(); return;                         /* ret */
        }
    }
}
