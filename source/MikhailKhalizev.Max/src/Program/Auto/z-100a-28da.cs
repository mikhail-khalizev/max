using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_28da-6db1285")]
        public void Method_100a_28da()
        {
            ii(0x100a_28da, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_28df, 5);  call(Definitions.sys_check_available_stack_size, 0xc_346e);/* call 0x10165d52 */
            ii(0x100a_28e4, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_28e5, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_28e6, 1);  push(esi);                            /* push esi */
            ii(0x100a_28e7, 1);  push(edi);                            /* push edi */
            ii(0x100a_28e8, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_28e9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_28eb, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_28f1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_28f4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_28f7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_28f9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_28fa, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_28fb, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_28fc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_28fd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_28fe, 1);  ret();                                /* ret */
        }
    }
}
