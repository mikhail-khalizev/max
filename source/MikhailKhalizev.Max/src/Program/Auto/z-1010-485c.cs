using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_485c-47aa5f1d")]
        public void Method_1010_485c()
        {
            ii(0x1010_485c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_4861, 5); call(Definitions.sys_check_available_stack_size, 0x6_14ec); /* call 0x10165d52 */
            ii(0x1010_4866, 1); push(ebx);                              /* push ebx */
            ii(0x1010_4867, 1); push(ecx);                              /* push ecx */
            ii(0x1010_4868, 1); push(esi);                              /* push esi */
            ii(0x1010_4869, 1); push(edi);                              /* push edi */
            ii(0x1010_486a, 1); push(ebp);                              /* push ebp */
            ii(0x1010_486b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_486d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1010_4873, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_4876, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1010_4879, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1010_487c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_487f, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1010_4882, 5); call(0x1010_4890, 9);                   /* call 0x10104890 */
            ii(0x1010_4887, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4889, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_488a, 1); pop(edi);                               /* pop edi */
            ii(0x1010_488b, 1); pop(esi);                               /* pop esi */
            ii(0x1010_488c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_488d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_488e, 1); ret();                                  /* ret */
        }
    }
}
