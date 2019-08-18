using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a5f0-9ebf89b0")]
        public void Method_1008_a5f0()
        {
            ii(0x1008_a5f0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_a5f5, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b758); /* call 0x10165d52 */
            ii(0x1008_a5fa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a5fb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a5fc, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a5fd, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a5fe, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a5ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a601, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a607, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a60a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a60d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_a610, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a613, 5); calld(0x1013_abc3, 0xb_05ab);           /* call 0x1013abc3 */
            ii(0x1008_a618, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a61b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_a61e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a621, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a624, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_a627, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_a62a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a62c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a62d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a62e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a62f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a630, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a631, 1); retd(); return;                         /* ret */
        }
    }
}
