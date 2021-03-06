using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6054-4373a90")]
        public void Method_1010_6054()
        {
            ii(0x1010_6054, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1010_6059, 5);  call(Definitions.sys_check_available_stack_size, 0x5_fcf4);/* call 0x10165d52 */
            ii(0x1010_605e, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_605f, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_6060, 1);  push(edx);                            /* push edx */
            ii(0x1010_6061, 1);  push(esi);                            /* push esi */
            ii(0x1010_6062, 1);  push(edi);                            /* push edi */
            ii(0x1010_6063, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_6064, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_6066, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_606c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_606f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_6072, 1);  push(eax);                            /* push eax */
            ii(0x1010_6073, 5);  call(0x1012_36ac, 0x1_d634);          /* call 0x101236ac */
            ii(0x1010_6078, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1010_607b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_607d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_607e, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_607f, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_6080, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_6081, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6082, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_6083, 1);  ret();                                /* ret */
        }
    }
}
