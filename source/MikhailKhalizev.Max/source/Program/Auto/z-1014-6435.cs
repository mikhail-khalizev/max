using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_6435-6b91b0c0")]
        public void Method_1014_6435()
        {
            ii(0x1014_6435, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_643a, 5);  call(Definitions.sys_check_available_stack_size, 0x1_f913);/* call 0x10165d52 */
            ii(0x1014_643f, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_6440, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_6441, 1);  push(edx);                            /* push edx */
            ii(0x1014_6442, 1);  push(esi);                            /* push esi */
            ii(0x1014_6443, 1);  push(edi);                            /* push edi */
            ii(0x1014_6444, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_6445, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_6447, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_644d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_6450, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_6453, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_6456, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6459, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_645b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_645c, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_645d, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_645e, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_645f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_6460, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_6461, 1);  ret();                                /* ret */
        }
    }
}
