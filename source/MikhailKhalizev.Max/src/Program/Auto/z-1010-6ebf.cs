using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6ebf-b8905fbc")]
        public void Method_1010_6ebf()
        {
            ii(0x1010_6ebf, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x1010_6ec4, 5);  call(Definitions.sys_check_available_stack_size, 0x5_ee89);/* call 0x10165d52 */
            ii(0x1010_6ec9, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_6eca, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_6ecb, 1);  push(edx);                            /* push edx */
            ii(0x1010_6ecc, 1);  push(esi);                            /* push esi */
            ii(0x1010_6ecd, 1);  push(edi);                            /* push edi */
            ii(0x1010_6ece, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_6ecf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_6ed1, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x1010_6ed7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_6ed8, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_6ed9, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_6eda, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_6edb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6edc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_6edd, 1);  ret();                                /* ret */
        }
    }
}
