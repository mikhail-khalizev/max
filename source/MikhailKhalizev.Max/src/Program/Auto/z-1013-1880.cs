using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("570df5b3-0aa1-4586-ac50-59034a664ad4")]
        public void Method_1013_1880()
        {
            ii(0x1013_1880, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1885, 5); calld(Definitions.sys_check_available_stack_size, 0x3_44c8); /* call 0x10165d52 */
            ii(0x1013_188a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_188b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_188c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_188d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_188e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_188f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1891, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_1897, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_189a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_189d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_18a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_18a5, 5); calld(0x1013_b0a5, 0x97fb);             /* call 0x1013b0a5 */
            ii(0x1013_18aa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_18ad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_18b0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_18b3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_18b6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_18b8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_18b9, 1); popd(edi);                              /* pop edi */
            ii(0x1013_18ba, 1); popd(esi);                              /* pop esi */
            ii(0x1013_18bb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_18bc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_18bd, 1); retd(); return;                         /* ret */
        }
    }
}
