using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c798-9ade14de")]
        public void Method_1013_c798()
        {
            ii(0x1013_c798, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_c79d, 5); calld(Definitions.sys_check_available_stack_size, 0x2_95b0); /* call 0x10165d52 */
            ii(0x1013_c7a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c7a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c7a4, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c7a5, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c7a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c7a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c7a9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c7af, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c7b2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c7b5, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_c7b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c7bc, 5); calld(0x1013_c7d0, 0xf);                /* call 0x1013c7d0 */
            ii(0x1013_c7c1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_c7c4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_c7c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c7c9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c7ca, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c7cb, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c7cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c7cd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c7ce, 1); retd(); return;                         /* ret */
        }
    }
}
