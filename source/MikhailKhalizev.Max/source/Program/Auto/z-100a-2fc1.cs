using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2fc1-d7cf10d5")]
        public void Method_100a_2fc1()
        {
            ii(0x100a_2fc1, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_2fc6, 5);  call(Definitions.sys_check_available_stack_size, 0xc_2d87);/* call 0x10165d52 */
            ii(0x100a_2fcb, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_2fcc, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_2fcd, 1);  push(esi);                            /* push esi */
            ii(0x100a_2fce, 1);  push(edi);                            /* push edi */
            ii(0x100a_2fcf, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_2fd0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_2fd2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_2fd8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_2fdb, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_2fde, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_2fe0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_2fe1, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_2fe2, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_2fe3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_2fe4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_2fe5, 1);  ret();                                /* ret */
        }
    }
}
