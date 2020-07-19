using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_87ac-d4387b62")]
        public void Method_100e_87ac()
        {
            ii(0x100e_87ac, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_87b1, 5);  call(Definitions.sys_check_available_stack_size, 0x7_d59c);/* call 0x10165d52 */
            ii(0x100e_87b6, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_87b7, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_87b8, 1);  push(edx);                            /* push edx */
            ii(0x100e_87b9, 1);  push(esi);                            /* push esi */
            ii(0x100e_87ba, 1);  push(edi);                            /* push edi */
            ii(0x100e_87bb, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_87bc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_87be, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_87c4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_87c7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_87ca, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x100e_87cd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_87d0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_87d3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_87d5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_87d6, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_87d7, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_87d8, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_87d9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_87da, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_87db, 1);  ret();                                /* ret */
        }
    }
}
