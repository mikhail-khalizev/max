using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_475c-c4bd1f8b")]
        public void Method_1010_475c()
        {
            ii(0x1010_475c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1010_4761, 5);  call(Definitions.sys_check_available_stack_size, 0x6_15ec);/* call 0x10165d52 */
            ii(0x1010_4766, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_4767, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_4768, 1);  push(edx);                            /* push edx */
            ii(0x1010_4769, 1);  push(esi);                            /* push esi */
            ii(0x1010_476a, 1);  push(edi);                            /* push edi */
            ii(0x1010_476b, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_476c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_476e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_4774, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_4777, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_477a, 4);  mov(ax, memw[ds, eax + 18]);          /* mov ax, [eax+0x12] */
            ii(0x1010_477e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_4781, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4784, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_4786, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_4787, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_4788, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_4789, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_478a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_478b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_478c, 1);  ret();                                /* ret */
        }
    }
}
