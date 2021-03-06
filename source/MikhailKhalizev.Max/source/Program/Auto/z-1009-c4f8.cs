using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c4f8-b146eb7")]
        public void Method_1009_c4f8()
        {
            ii(0x1009_c4f8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_c4fd, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9850);/* call 0x10165d52 */
            ii(0x1009_c502, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c503, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c504, 1);  push(edx);                            /* push edx */
            ii(0x1009_c505, 1);  push(esi);                            /* push esi */
            ii(0x1009_c506, 1);  push(edi);                            /* push edi */
            ii(0x1009_c507, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c508, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c50a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_c510, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c513, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c516, 5);  call(0x1007_6c30, -0x2_58eb);         /* call 0x10076c30 */
            ii(0x1009_c51b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c51e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c521, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c523, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c524, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c525, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c526, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_c527, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c528, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c529, 1);  ret();                                /* ret */
        }
    }
}
