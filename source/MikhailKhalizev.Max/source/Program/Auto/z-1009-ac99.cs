using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ac99-3a80de80")]
        public void Method_1009_ac99()
        {
            ii(0x1009_ac99, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_ac9e, 5);  call(Definitions.sys_check_available_stack_size, 0xc_b0af);/* call 0x10165d52 */
            ii(0x1009_aca3, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_aca4, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_aca5, 1);  push(edx);                            /* push edx */
            ii(0x1009_aca6, 1);  push(esi);                            /* push esi */
            ii(0x1009_aca7, 1);  push(edi);                            /* push edi */
            ii(0x1009_aca8, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_aca9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_acab, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_acb1, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_acb4, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_acbb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_acbe, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_acc0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_acc1, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_acc2, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_acc3, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_acc4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_acc5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_acc6, 1);  ret();                                /* ret */
        }
    }
}
