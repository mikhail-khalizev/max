using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c90c3e36-15a6-4417-b981-c5a4dd1e9e69")]
        public void Method_1008_b060()
        {
            ii(0x1008_b060, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_b065, 5); calld(Definitions.sys_check_available_stack_size, 0xdace8); /* call 0x10165d52 */
            ii(0x1008_b06a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b06b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b06c, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b06d, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b06e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b06f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b071, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_b077, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b07a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b07d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_b080, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b083, 5); calld(0x1013_abc3, 0xafb3b);            /* call 0x1013abc3 */
            ii(0x1008_b088, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b08b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_b08e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_b091, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b094, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_b097, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_b09a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b09c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b09d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b09e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b09f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b0a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b0a1, 1); retd(); return;                         /* ret */
        }
    }
}
