using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9b00-e66350b9")]
        public void Method_1008_9b00()
        {
            ii(0x1008_9b00, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9b05, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c248);/* call 0x10165d52 */
            ii(0x1008_9b0a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9b0b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9b0c, 1);  push(edx);                            /* push edx */
            ii(0x1008_9b0d, 1);  push(esi);                            /* push esi */
            ii(0x1008_9b0e, 1);  push(edi);                            /* push edi */
            ii(0x1008_9b0f, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9b10, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9b12, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_9b18, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9b1b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9b1e, 5);  call(0x1007_6c30, -0x1_2ef3);         /* call 0x10076c30 */
            ii(0x1008_9b23, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9b26, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9b29, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9b2b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9b2c, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_9b2d, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_9b2e, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_9b2f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_9b30, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_9b31, 1);  ret();                                /* ret */
        }
    }
}
