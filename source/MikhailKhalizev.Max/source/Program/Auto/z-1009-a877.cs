using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a877-d5141743")]
        public void Method_1009_a877()
        {
            ii(0x1009_a877, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_a87c, 5);  call(Definitions.sys_check_available_stack_size, 0xc_b4d1);/* call 0x10165d52 */
            ii(0x1009_a881, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_a882, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_a883, 1);  push(edx);                            /* push edx */
            ii(0x1009_a884, 1);  push(esi);                            /* push esi */
            ii(0x1009_a885, 1);  push(edi);                            /* push edi */
            ii(0x1009_a886, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_a887, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_a889, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_a88f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_a892, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_a894, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a897, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1009_a89a, 5);  call(0x1008_afe4, -0xf8bb);           /* call 0x1008afe4 */
            ii(0x1009_a89f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a8a2, 5);  call(0x1009_a476, -0x431);            /* call 0x1009a476 */
            ii(0x1009_a8a7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_a8a9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_a8aa, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_a8ab, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_a8ac, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_a8ad, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_a8ae, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_a8af, 1);  ret();                                /* ret */
        }
    }
}
