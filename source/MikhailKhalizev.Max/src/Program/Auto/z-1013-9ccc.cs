using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9ccc-1aff5e34")]
        public void Method_1013_9ccc()
        {
            ii(0x1013_9ccc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_9cd1, 5); calld(Definitions.sys_check_available_stack_size, 0x2_c07c); /* call 0x10165d52 */
            ii(0x1013_9cd6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_9cd7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_9cd8, 1); pushd(esi);                             /* push esi */
            ii(0x1013_9cd9, 1); pushd(edi);                             /* push edi */
            ii(0x1013_9cda, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_9cdb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9cdd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_9ce3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9ce6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_9ce9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_9cee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9cf1, 5); calld(0x1013_b0a5, 0x13af);             /* call 0x1013b0a5 */
            ii(0x1013_9cf6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9cf9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9cfc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_9cff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_9d02, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9d04, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_9d05, 1); popd(edi);                              /* pop edi */
            ii(0x1013_9d06, 1); popd(esi);                              /* pop esi */
            ii(0x1013_9d07, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_9d08, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_9d09, 1); retd();                                 /* ret */
        }
    }
}
