using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_efac-4633fdc5")]
        public void Method_1009_efac()
        {
            ii(0x1009_efac, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_efb1, 5);  call(Definitions.sys_check_available_stack_size, 0xc_6d9c);/* call 0x10165d52 */
            ii(0x1009_efb6, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_efb7, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_efb8, 1);  push(edx);                            /* push edx */
            ii(0x1009_efb9, 1);  push(esi);                            /* push esi */
            ii(0x1009_efba, 1);  push(edi);                            /* push edi */
            ii(0x1009_efbb, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_efbc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_efbe, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_efc4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_efc7, 4);  mov(memb[ss, ebp - 8], 0xf);          /* mov byte [ebp-0x8], 0xf */
            ii(0x1009_efcb, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_efce, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_efd0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_efd1, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_efd2, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_efd3, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_efd4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_efd5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_efd6, 1);  ret();                                /* ret */
        }
    }
}
