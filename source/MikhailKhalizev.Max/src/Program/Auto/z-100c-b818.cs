using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b818-ec63bbb1")]
        public void Method_100c_b818()
        {
            ii(0x100c_b818, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_b81d, 5);  call(Definitions.sys_check_available_stack_size, 0x9_a530);/* call 0x10165d52 */
            ii(0x100c_b822, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b823, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b824, 1);  push(esi);                            /* push esi */
            ii(0x100c_b825, 1);  push(edi);                            /* push edi */
            ii(0x100c_b826, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b827, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b829, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_b82f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b832, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100c_b835, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_b83a, 3);  lea(edx, memd[ss, ebp - 4]);          /* lea edx, [ebp-0x4] */
            ii(0x100c_b83d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b840, 5);  call(0x1013_c055, 0x7_0810);          /* call 0x1013c055 */
            ii(0x100c_b845, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b847, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b848, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b849, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b84a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b84b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b84c, 1);  ret();                                /* ret */
        }
    }
}
