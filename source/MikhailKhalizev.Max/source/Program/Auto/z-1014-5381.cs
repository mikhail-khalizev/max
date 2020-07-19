using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5381-4f775a1f")]
        public void Method_1014_5381()
        {
            ii(0x1014_5381, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_5386, 5);  call(Definitions.sys_check_available_stack_size, 0x2_09c7);/* call 0x10165d52 */
            ii(0x1014_538b, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_538c, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_538d, 1);  push(edx);                            /* push edx */
            ii(0x1014_538e, 1);  push(esi);                            /* push esi */
            ii(0x1014_538f, 1);  push(edi);                            /* push edi */
            ii(0x1014_5390, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_5391, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_5393, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1014_5399, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_539c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_539e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_539f, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_53a0, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_53a1, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_53a2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_53a3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_53a4, 1);  ret();                                /* ret */
        }
    }
}
