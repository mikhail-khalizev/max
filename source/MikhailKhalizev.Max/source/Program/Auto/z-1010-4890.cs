using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4890-9e1b2c8d")]
        public void Method_1010_4890()
        {
            ii(0x1010_4890, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_4895, 5);  call(Definitions.sys_check_available_stack_size, 0x6_14b8);/* call 0x10165d52 */
            ii(0x1010_489a, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_489b, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_489c, 1);  push(esi);                            /* push esi */
            ii(0x1010_489d, 1);  push(edi);                            /* push edi */
            ii(0x1010_489e, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_489f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_48a1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_48a7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_48aa, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_48ad, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_48b0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_48b3, 5);  call(0x1013_a369, 0x3_5ab1);          /* call 0x1013a369 */
            ii(0x1010_48b8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_48ba, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_48bb, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_48bc, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_48bd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_48be, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_48bf, 1);  ret();                                /* ret */
        }
    }
}
