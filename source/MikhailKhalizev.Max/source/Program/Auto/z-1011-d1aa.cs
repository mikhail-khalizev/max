using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d1aa-8c93fa6")]
        public void Method_1011_d1aa()
        {
            ii(0x1011_d1aa, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1011_d1af, 5);  call(Definitions.sys_check_available_stack_size, 0x4_8b9e);/* call 0x10165d52 */
            ii(0x1011_d1b4, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_d1b5, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_d1b6, 1);  push(edx);                            /* push edx */
            ii(0x1011_d1b7, 1);  push(esi);                            /* push esi */
            ii(0x1011_d1b8, 1);  push(edi);                            /* push edi */
            ii(0x1011_d1b9, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_d1ba, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_d1bc, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_d1c2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_d1c5, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1011_d1c9, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_d1cc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_d1ce, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_d1cf, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_d1d0, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_d1d1, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_d1d2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_d1d3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_d1d4, 1);  ret();                                /* ret */
        }
    }
}
