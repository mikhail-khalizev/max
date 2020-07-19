using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9894-da967fdd")]
        public void Method_1008_9894()
        {
            ii(0x1008_9894, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9899, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c4b4);/* call 0x10165d52 */
            ii(0x1008_989e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_989f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_98a0, 1);  push(edx);                            /* push edx */
            ii(0x1008_98a1, 1);  push(esi);                            /* push esi */
            ii(0x1008_98a2, 1);  push(edi);                            /* push edi */
            ii(0x1008_98a3, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_98a4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_98a6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_98ac, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_98af, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_98b2, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x1008_98b5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_98b8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_98bb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_98bd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_98be, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_98bf, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_98c0, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_98c1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_98c2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_98c3, 1);  ret();                                /* ret */
        }
    }
}
