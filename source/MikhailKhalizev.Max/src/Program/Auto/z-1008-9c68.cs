using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eec2dbab-e5e9-4c28-a469-b9480cbf02e6")]
        public void Method_1008_9c68()
        {
            ii(0x1008_9c68, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9c6d, 5); calld(Definitions.sys_check_available_stack_size, 0xdc0e0); /* call 0x10165d52 */
            ii(0x1008_9c72, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9c73, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9c74, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9c75, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9c76, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9c77, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9c79, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9c7f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9c82, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9c85, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1008_9c89, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9c8c, 5); calld(0x1013_a854, 0xb0bc3);            /* call 0x1013a854 */
            ii(0x1008_9c91, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9c94, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9c97, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9c99, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9c9a, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9c9b, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9c9c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9c9d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9c9e, 1); retd(); return;                         /* ret */
        }
    }
}
