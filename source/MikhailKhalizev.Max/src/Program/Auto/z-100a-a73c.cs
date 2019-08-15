using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76299b8e-66c1-4c29-bbdc-dbbe0b83e8ad")]
        public void Method_100a_a73c()
        {
            ii(0x100a_a73c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_a741, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b60c); /* call 0x10165d52 */
            ii(0x100a_a746, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_a747, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_a748, 1); pushd(esi);                             /* push esi */
            ii(0x100a_a749, 1); pushd(edi);                             /* push edi */
            ii(0x100a_a74a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_a74b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a74d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_a753, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_a756, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_a759, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a75c, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x100a_a75e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_a761, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_a764, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_a767, 5); calld(0x100a_a774, 0x8);                /* call 0x100aa774 */
            ii(0x100a_a76c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a76e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_a76f, 1); popd(edi);                              /* pop edi */
            ii(0x100a_a770, 1); popd(esi);                              /* pop esi */
            ii(0x100a_a771, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_a772, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_a773, 1); retd(); return;                         /* ret */
        }
    }
}
