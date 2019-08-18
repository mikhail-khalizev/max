using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3517fc26-5438-4abd-89c0-a96757b7025f")]
        public void Method_1008_a914()
        {
            ii(0x1008_a914, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_a919, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b434); /* call 0x10165d52 */
            ii(0x1008_a91e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a91f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a920, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a921, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a922, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a923, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a925, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a92b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a92e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a931, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_a934, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a937, 5); calld(0x1013_abc3, 0xb_0287);           /* call 0x1013abc3 */
            ii(0x1008_a93c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a93f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_a942, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a945, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a948, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_a94b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_a94e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a950, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a951, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a952, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a953, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a954, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a955, 1); retd(); return;                         /* ret */
        }
    }
}
