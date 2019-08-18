using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b1e4-d83f1538")]
        public void Method_1008_b1e4()
        {
            ii(0x1008_b1e4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_b1e9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ab64); /* call 0x10165d52 */
            ii(0x1008_b1ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b1ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b1f0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b1f1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b1f2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b1f3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b1f5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_b1fb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b1fe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b201, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1008_b205, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b208, 5); calld(0x1008_b3a4, 0x197);              /* call 0x1008b3a4 */
            ii(0x1008_b20d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b210, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_b213, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_b216, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b219, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_b21c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_b21f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b221, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b222, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b223, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b224, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b225, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b226, 1); retd(); return;                         /* ret */
        }
    }
}
