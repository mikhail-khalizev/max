using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9e08-fa153812")]
        public void Method_1008_9e08()
        {
            ii(0x1008_9e08, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9e0d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_bf40);/* call 0x10165d52 */
            ii(0x1008_9e12, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9e13, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9e14, 1);  push(edx);                            /* push edx */
            ii(0x1008_9e15, 1);  push(esi);                            /* push esi */
            ii(0x1008_9e16, 1);  push(edi);                            /* push edi */
            ii(0x1008_9e17, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9e18, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9e1a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_9e20, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9e23, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9e26, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_9e28, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9e2b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9e2e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9e30, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9e31, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_9e32, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_9e33, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_9e34, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_9e35, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_9e36, 1);  ret();                                /* ret */
        }
    }
}
