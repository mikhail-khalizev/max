using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9cd8-f6fbe577")]
        public void Method_1008_9cd8()
        {
            ii(0x1008_9cd8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_9cdd, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c070); /* call 0x10165d52 */
            ii(0x1008_9ce2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9ce3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9ce4, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9ce5, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9ce6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9ce7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9ce9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9cef, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9cf2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9cf5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_9cf8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9cfb, 5); calld(0x1013_a2ab, 0xb_05ab);           /* call 0x1013a2ab */
            ii(0x1008_9d00, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9d02, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9d03, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9d04, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9d05, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9d06, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9d07, 1); retd(); return;                         /* ret */
        }
    }
}
