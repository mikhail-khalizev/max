using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9e70-383084f1")]
        public void Method_1008_9e70()
        {
            ii(0x1008_9e70, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_9e75, 5); calld(Definitions.sys_check_available_stack_size, 0xd_bed8); /* call 0x10165d52 */
            ii(0x1008_9e7a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9e7b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9e7c, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9e7d, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9e7e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9e7f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9e81, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_9e87, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9e8a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9e8d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_9e90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9e93, 5); calld(0x1013_ac03, 0xb_0d6b);           /* call 0x1013ac03 */
            ii(0x1008_9e98, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9e9b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_9e9e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9ea1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9ea4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_9ea7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_9eaa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9eac, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9ead, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9eae, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9eaf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9eb0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9eb1, 1); retd(); return;                         /* ret */
        }
    }
}
