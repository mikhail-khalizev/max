using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c12f-cef07030")]
        public void Method_1013_c12f()
        {
            ii(0x1013_c12f, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_c134, 5);  call(Definitions.sys_check_available_stack_size, 0x2_9c19);/* call 0x10165d52 */
            ii(0x1013_c139, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_c13a, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_c13b, 1);  push(esi);                            /* push esi */
            ii(0x1013_c13c, 1);  push(edi);                            /* push edi */
            ii(0x1013_c13d, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_c13e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_c140, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_c146, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c149, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_c14c, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1013_c151, 3);  lea(edx, memd[ss, ebp - 4]);          /* lea edx, [ebp-0x4] */
            ii(0x1013_c154, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c157, 5);  call(0x1013_c055, -0x107);            /* call 0x1013c055 */
            ii(0x1013_c15c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_c15e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_c15f, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_c160, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_c161, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_c162, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_c163, 1);  ret();                                /* ret */
        }
    }
}
