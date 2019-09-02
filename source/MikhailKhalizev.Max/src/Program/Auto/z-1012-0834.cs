using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0834-e7dfc9dd")]
        public void Method_1012_0834()
        {
            ii(0x1012_0834, 5); push(0x20);                             /* push 0x20 */
            ii(0x1012_0839, 5); call(Definitions.sys_check_available_stack_size, 0x4_5514); /* call 0x10165d52 */
            ii(0x1012_083e, 1); push(ebx);                              /* push ebx */
            ii(0x1012_083f, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0840, 1); push(esi);                              /* push esi */
            ii(0x1012_0841, 1); push(edi);                              /* push edi */
            ii(0x1012_0842, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0843, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0845, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1012_084b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_084e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_0851, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_0854, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_0857, 5); call(0x1013_a369, 0x1_9b0d);            /* call 0x1013a369 */
            ii(0x1012_085c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_085e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_085f, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0860, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0861, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0862, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0863, 1); ret();                                  /* ret */
        }
    }
}
