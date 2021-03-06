using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2783-c4a05d36")]
        public void Method_1015_2783()
        {
            ii(0x1015_2783, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1015_2788, 5);  call(Definitions.sys_check_available_stack_size, 0x1_35c5);/* call 0x10165d52 */
            ii(0x1015_278d, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_278e, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_278f, 1);  push(esi);                            /* push esi */
            ii(0x1015_2790, 1);  push(edi);                            /* push edi */
            ii(0x1015_2791, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_2792, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_2794, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_279a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_279d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_27a0, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_27a3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_27a6, 5);  add(eax, 0x94);                       /* add eax, 0x94 */
            ii(0x1015_27ab, 5);  call(0x1009_ca40, -0xb_5d70);         /* call 0x1009ca40 */
            ii(0x1015_27b0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_27b2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_27b3, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_27b4, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_27b5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_27b6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_27b7, 1);  ret();                                /* ret */
        }
    }
}
