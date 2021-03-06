using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7341-4988a51f")]
        public void Method_1008_7341()
        {
            ii(0x1008_7341, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_7346, 5);  call(Definitions.sys_check_available_stack_size, 0xd_ea07);/* call 0x10165d52 */
            ii(0x1008_734b, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_734c, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_734d, 1);  push(esi);                            /* push esi */
            ii(0x1008_734e, 1);  push(edi);                            /* push edi */
            ii(0x1008_734f, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_7350, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_7352, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_7358, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_735b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_735e, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_7362, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_7365, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_7367, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_7368, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_7369, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_736a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_736b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_736c, 1);  ret();                                /* ret */
        }
    }
}
