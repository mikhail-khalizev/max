using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7cfc-bc6668b5")]
        public void Method_100b_7cfc()
        {
            ii(0x100b_7cfc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_7d01, 5);  call(Definitions.sys_check_available_stack_size, 0xa_e04c);/* call 0x10165d52 */
            ii(0x100b_7d06, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7d07, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7d08, 1);  push(esi);                            /* push esi */
            ii(0x100b_7d09, 1);  push(edi);                            /* push edi */
            ii(0x100b_7d0a, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7d0b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7d0d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_7d13, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7d16, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7d19, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_7d1c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7d1f, 5);  call(0x1013_ac7d, 0x8_2f59);          /* call 0x1013ac7d */
            ii(0x100b_7d24, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_7d27, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_7d2a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7d2c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7d2d, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7d2e, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7d2f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7d30, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7d31, 1);  ret();                                /* ret */
        }
    }
}
