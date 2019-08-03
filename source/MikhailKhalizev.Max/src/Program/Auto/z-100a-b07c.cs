using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("beb7704c-14ea-442a-a094-39cc33aa4a31")]
        public void Method_100a_b07c()
        {
            ii(0x100a_b07c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_b081, 5); calld(Definitions.sys_check_available_stack_size, 0xbaccc); /* call 0x10165d52 */
            ii(0x100a_b086, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b087, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b088, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b089, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b08a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b08b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b08d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_b093, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b096, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_b099, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_b09c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b09f, 5); calld(0x1013_a2ab, 0x8f207);            /* call 0x1013a2ab */
            ii(0x100a_b0a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b0a6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b0a7, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b0a8, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b0a9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b0aa, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b0ab, 1); retd(); return;                         /* ret */
        }
    }
}
