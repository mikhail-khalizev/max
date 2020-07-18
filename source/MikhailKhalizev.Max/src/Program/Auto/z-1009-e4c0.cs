using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e4c0-86b90a80")]
        public void Method_1009_e4c0()
        {
            ii(0x1009_e4c0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_e4c5, 5);  call(Definitions.sys_check_available_stack_size, 0xc_7888);/* call 0x10165d52 */
            ii(0x1009_e4ca, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_e4cb, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_e4cc, 1);  push(edx);                            /* push edx */
            ii(0x1009_e4cd, 1);  push(esi);                            /* push esi */
            ii(0x1009_e4ce, 1);  push(edi);                            /* push edi */
            ii(0x1009_e4cf, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_e4d0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_e4d2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_e4d8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_e4db, 4);  mov(memb[ss, ebp - 8], 0x2b);         /* mov byte [ebp-0x8], 0x2b */
            ii(0x1009_e4df, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_e4e2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_e4e4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_e4e5, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_e4e6, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_e4e7, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_e4e8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_e4e9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_e4ea, 1);  ret();                                /* ret */
        }
    }
}
