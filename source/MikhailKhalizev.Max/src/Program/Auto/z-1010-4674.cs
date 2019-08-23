using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4674-76af681b")]
        public void Method_1010_4674()
        {
            ii(0x1010_4674, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_4679, 5); call(Definitions.sys_check_available_stack_size, 0x6_16d4); /* call 0x10165d52 */
            ii(0x1010_467e, 1); push(ebx);                              /* push ebx */
            ii(0x1010_467f, 1); push(ecx);                              /* push ecx */
            ii(0x1010_4680, 1); push(esi);                              /* push esi */
            ii(0x1010_4681, 1); push(edi);                              /* push edi */
            ii(0x1010_4682, 1); push(ebp);                              /* push ebp */
            ii(0x1010_4683, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4685, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_468b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_468e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_4691, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_4694, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4697, 5); call(0x1013_a2ab, 0x3_5c0f);            /* call 0x1013a2ab */
            ii(0x1010_469c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_469e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_469f, 1); pop(edi);                               /* pop edi */
            ii(0x1010_46a0, 1); pop(esi);                               /* pop esi */
            ii(0x1010_46a1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_46a2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_46a3, 1); ret();                                  /* ret */
        }
    }
}
