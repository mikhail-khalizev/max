using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4ac33db2-346b-4950-8c39-e693ea984d79")]
        public void Method_1013_c758()
        {
            ii(0x1013_c758, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_c75d, 5); calld(Definitions.sys_check_available_stack_size, 0x2_95f0); /* call 0x10165d52 */
            ii(0x1013_c762, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c763, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c764, 1); pushd(edx);                             /* push edx */
            ii(0x1013_c765, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c766, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c767, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c768, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c76a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c770, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_c773, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c776, 5); calld(0x1013_a0af, -0x26cc);            /* call 0x1013a0af */
            ii(0x1013_c77b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_c77e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1013_c781, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c784, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c787, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_c78a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_c78d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c78f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c790, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c791, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c792, 1); popd(edx);                              /* pop edx */
            ii(0x1013_c793, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c794, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c795, 1); retd(); return;                         /* ret */
        }
    }
}
