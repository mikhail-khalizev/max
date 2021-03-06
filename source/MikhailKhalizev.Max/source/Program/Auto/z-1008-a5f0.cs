using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a5f0-9ebf89b0")]
        public void Method_1008_a5f0()
        {
            ii(0x1008_a5f0, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_a5f5, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b758);/* call 0x10165d52 */
            ii(0x1008_a5fa, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a5fb, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a5fc, 1);  push(esi);                            /* push esi */
            ii(0x1008_a5fd, 1);  push(edi);                            /* push edi */
            ii(0x1008_a5fe, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a5ff, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a601, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1008_a607, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a60a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_a60d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_a610, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a613, 5);  call(0x1013_abc3, 0xb_05ab);          /* call 0x1013abc3 */
            ii(0x1008_a618, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a61b, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_a61e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_a621, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a624, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_a627, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_a62a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a62c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a62d, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a62e, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a62f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a630, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a631, 1);  ret();                                /* ret */
        }
    }
}
