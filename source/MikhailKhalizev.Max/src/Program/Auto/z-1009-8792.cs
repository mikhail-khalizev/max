using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("78ab6d62-06e5-49f5-9c14-66fed9f8a72e")]
        public void Method_1009_8792()
        {
            ii(0x1009_8792, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_8797, 5); calld(Definitions.sys_check_available_stack_size, 0xc_d5b6); /* call 0x10165d52 */
            ii(0x1009_879c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_879d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_879e, 1); pushd(esi);                             /* push esi */
            ii(0x1009_879f, 1); pushd(edi);                             /* push edi */
            ii(0x1009_87a0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_87a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_87a3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_87a9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_87ac, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_87af, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_87b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_87b5, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_87b8, 5); calld(0x1008_aab4, -0xdd09);            /* call 0x1008aab4 */
            ii(0x1009_87bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_87bf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_87c0, 1); popd(edi);                              /* pop edi */
            ii(0x1009_87c1, 1); popd(esi);                              /* pop esi */
            ii(0x1009_87c2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_87c3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_87c4, 1); retd(); return;                         /* ret */
        }
    }
}
