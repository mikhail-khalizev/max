using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d88c-450127a4")]
        public void Method_1011_d88c()
        {
            ii(0x1011_d88c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_d891, 5);  call(Definitions.sys_check_available_stack_size, 0x4_84bc);/* call 0x10165d52 */
            ii(0x1011_d896, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_d897, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_d898, 1);  push(esi);                            /* push esi */
            ii(0x1011_d899, 1);  push(edi);                            /* push edi */
            ii(0x1011_d89a, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_d89b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_d89d, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_d8a3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_d8a6, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1011_d8a9, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_d8ac, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_d8af, 3);  mov(memb[ds, edx + 21], al);          /* mov [edx+0x15], al */
            ii(0x1011_d8b2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_d8b4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_d8b5, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_d8b6, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_d8b7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_d8b8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_d8b9, 1);  ret();                                /* ret */
        }
    }
}
