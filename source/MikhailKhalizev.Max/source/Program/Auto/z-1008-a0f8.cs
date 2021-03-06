using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a0f8-4b1b8add")]
        public void Method_1008_a0f8()
        {
            ii(0x1008_a0f8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_a0fd, 5);  call(Definitions.sys_check_available_stack_size, 0xd_bc50);/* call 0x10165d52 */
            ii(0x1008_a102, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a103, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a104, 1);  push(edx);                            /* push edx */
            ii(0x1008_a105, 1);  push(esi);                            /* push esi */
            ii(0x1008_a106, 1);  push(edi);                            /* push edi */
            ii(0x1008_a107, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a108, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a10a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_a110, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a113, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a116, 5);  call(0x1007_6c30, -0x1_34eb);         /* call 0x10076c30 */
            ii(0x1008_a11b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a11e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a121, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a123, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a124, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a125, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a126, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_a127, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a128, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a129, 1);  ret();                                /* ret */
        }
    }
}
