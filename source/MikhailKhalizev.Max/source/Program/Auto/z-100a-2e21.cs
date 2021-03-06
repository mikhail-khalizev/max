using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2e21-c7d3c91b")]
        public void Method_100a_2e21()
        {
            ii(0x100a_2e21, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_2e26, 5);  call(Definitions.sys_check_available_stack_size, 0xc_2f27);/* call 0x10165d52 */
            ii(0x100a_2e2b, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_2e2c, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_2e2d, 1);  push(esi);                            /* push esi */
            ii(0x100a_2e2e, 1);  push(edi);                            /* push edi */
            ii(0x100a_2e2f, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_2e30, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_2e32, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_2e38, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_2e3b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_2e3e, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_2e42, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100a_2e45, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_2e47, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_2e48, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_2e49, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_2e4a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_2e4b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_2e4c, 1);  ret();                                /* ret */
        }
    }
}
