using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bbe5-7550c67a")]
        public void Method_1013_bbe5()
        {
            ii(0x1013_bbe5, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_bbea, 5);  call(Definitions.sys_check_available_stack_size, 0x2_a163);/* call 0x10165d52 */
            ii(0x1013_bbef, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_bbf0, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_bbf1, 1);  push(esi);                            /* push esi */
            ii(0x1013_bbf2, 1);  push(edi);                            /* push edi */
            ii(0x1013_bbf3, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_bbf4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_bbf6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_bbfc, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_bbff, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_bc02, 5);  mov(ebx, 4);                          /* mov ebx, 0x4 */
            ii(0x1013_bc07, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_bc0a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bc0d, 5);  call(0x1013_ba86, -0x18c);            /* call 0x1013ba86 */
            ii(0x1013_bc12, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_bc14, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_bc15, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_bc16, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_bc17, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_bc18, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_bc19, 1);  ret();                                /* ret */
        }
    }
}
