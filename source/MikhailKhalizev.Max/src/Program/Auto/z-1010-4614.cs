using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4614-785a705")]
        public void Method_1010_4614()
        {
            ii(0x1010_4614, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_4619, 5);  call(Definitions.sys_check_available_stack_size, 0x6_1734);/* call 0x10165d52 */
            ii(0x1010_461e, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_461f, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_4620, 1);  push(esi);                            /* push esi */
            ii(0x1010_4621, 1);  push(edi);                            /* push edi */
            ii(0x1010_4622, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_4623, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_4625, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_462b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_462e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_4631, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_4634, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4637, 5);  call(0x1013_a5af, 0x3_5f73);          /* call 0x1013a5af */
            ii(0x1010_463c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_463e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_463f, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_4640, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_4641, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_4642, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_4643, 1);  ret();                                /* ret */
        }
    }
}
