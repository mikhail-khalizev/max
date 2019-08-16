using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77f15e13-d432-4f7c-9537-6e91ce3c1be1")]
        public void Method_100a_a700()
        {
            ii(0x100a_a700, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a705, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b648); /* call 0x10165d52 */
            ii(0x100a_a70a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a70b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a70c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a70d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a70e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a70f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a711, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a717, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a71a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a71d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_a721, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x100a_a724, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_a726, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a729, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100a_a72c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_a72e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_a731, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_a734, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a736, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a737, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a738, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a739, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a73a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a73b, 1); retd(); return;                         /* ret */
        }
    }
}