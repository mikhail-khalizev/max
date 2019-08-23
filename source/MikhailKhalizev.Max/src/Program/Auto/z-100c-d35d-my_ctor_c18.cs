using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d35d-48cd147")]
        public void my_ctor_c18()
        {
            ii(0x100c_d35d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_d362, 5); calld(Definitions.sys_check_available_stack_size, 0x9_89eb); /* call 0x10165d52 */
            ii(0x100c_d367, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d368, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d369, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d36a, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d36b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d36c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d36e, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_d374, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d377, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_d37a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_d37d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d380, 5); calld(Definitions.my_ctor_c15, -0x1afd); /* call 0x100cb888 */
            ii(0x100c_d385, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_d388, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_d38b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_d38e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d391, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_59dc); /* mov dword [eax+0x2], 0x101b59dc */
            ii(0x100c_d398, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_d39b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_d39e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_d3a1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d3a3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d3a4, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d3a5, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d3a6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d3a7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d3a8, 1); retd();                                 /* ret */
        }
    }
}
