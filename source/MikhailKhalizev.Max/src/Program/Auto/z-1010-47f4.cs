using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("871c2f89-680c-4e44-ba85-12906d7755f5")]
        public void Method_1010_47f4()
        {
            ii(0x1010_47f4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_47f9, 5); calld(Definitions.sys_check_available_stack_size, 0x6_1554); /* call 0x10165d52 */
            ii(0x1010_47fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_47ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_4800, 1); pushd(esi);                             /* push esi */
            ii(0x1010_4801, 1); pushd(edi);                             /* push edi */
            ii(0x1010_4802, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_4803, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4805, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_480b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_480e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_4811, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_4814, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4817, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1010_481a, 5); calld(0x1008_aab4, -0x7_9d6b);          /* call 0x1008aab4 */
            ii(0x1010_481f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4821, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_4822, 1); popd(edi);                              /* pop edi */
            ii(0x1010_4823, 1); popd(esi);                              /* pop esi */
            ii(0x1010_4824, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_4825, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_4826, 1); retd(); return;                         /* ret */
        }
    }
}
