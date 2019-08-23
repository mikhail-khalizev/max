using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4828-e81dc4d5")]
        public void Method_1010_4828()
        {
            ii(0x1010_4828, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_482d, 5); call(Definitions.sys_check_available_stack_size, 0x6_1520); /* call 0x10165d52 */
            ii(0x1010_4832, 1); push(ebx);                              /* push ebx */
            ii(0x1010_4833, 1); push(ecx);                              /* push ecx */
            ii(0x1010_4834, 1); push(esi);                              /* push esi */
            ii(0x1010_4835, 1); push(edi);                              /* push edi */
            ii(0x1010_4836, 1); push(ebp);                              /* push ebp */
            ii(0x1010_4837, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4839, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_483f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_4842, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_4845, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_4848, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_484b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1010_484e, 5); call(0x1008_ab1c, -0x7_9d37);           /* call 0x1008ab1c */
            ii(0x1010_4853, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4855, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_4856, 1); pop(edi);                               /* pop edi */
            ii(0x1010_4857, 1); pop(esi);                               /* pop esi */
            ii(0x1010_4858, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_4859, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_485a, 1); ret();                                  /* ret */
        }
    }
}
