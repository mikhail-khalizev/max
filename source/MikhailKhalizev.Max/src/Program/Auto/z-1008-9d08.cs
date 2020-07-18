using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9d08-4540b82c")]
        public void Method_1008_9d08()
        {
            ii(0x1008_9d08, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9d0d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c040);/* call 0x10165d52 */
            ii(0x1008_9d12, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9d13, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9d14, 1);  push(edx);                            /* push edx */
            ii(0x1008_9d15, 1);  push(esi);                            /* push esi */
            ii(0x1008_9d16, 1);  push(edi);                            /* push edi */
            ii(0x1008_9d17, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9d18, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9d1a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_9d20, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9d23, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9d26, 5);  call(0x1007_6b58, -0x1_31d3);         /* call 0x10076b58 */
            ii(0x1008_9d2b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9d2e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9d31, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9d33, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9d34, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_9d35, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_9d36, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_9d37, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_9d38, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_9d39, 1);  ret();                                /* ret */
        }
    }
}
