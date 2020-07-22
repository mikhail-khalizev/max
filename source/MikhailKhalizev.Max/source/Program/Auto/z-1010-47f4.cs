using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_47f4-f7dbeffd")]
        public void Method_1010_47f4()
        {
            ii(0x1010_47f4, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_47f9, 5);  call(Definitions.sys_check_available_stack_size, 0x6_1554);/* call 0x10165d52 */
            ii(0x1010_47fe, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_47ff, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_4800, 1);  push(esi);                            /* push esi */
            ii(0x1010_4801, 1);  push(edi);                            /* push edi */
            ii(0x1010_4802, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_4803, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_4805, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_480b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_480e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_4811, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_4814, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4817, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1010_481a, 5);  call(0x1008_aab4, -0x7_9d6b);         /* call 0x1008aab4 */
            ii(0x1010_481f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_4821, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_4822, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_4823, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_4824, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_4825, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_4826, 1);  ret();                                /* ret */
        }
    }
}
