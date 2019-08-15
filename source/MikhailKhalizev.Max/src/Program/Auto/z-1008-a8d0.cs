using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("95c39515-71f5-4438-b990-53a50959fbb6")]
        public void Method_1008_a8d0()
        {
            ii(0x1008_a8d0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_a8d5, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b478); /* call 0x10165d52 */
            ii(0x1008_a8da, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a8db, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a8dc, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a8dd, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a8de, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a8df, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a8e1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a8e7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a8ea, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a8ed, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_a8f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a8f3, 5); calld(0x1013_ac03, 0xb_030b);           /* call 0x1013ac03 */
            ii(0x1008_a8f8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a8fb, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_a8fe, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a901, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a904, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_a907, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_a90a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a90c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a90d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a90e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a90f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a910, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a911, 1); retd(); return;                         /* ret */
        }
    }
}
