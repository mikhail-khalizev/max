using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a674-fbdeac7")]
        public void Method_1008_a674()
        {
            ii(0x1008_a674, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1008_a679, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b6d4);/* call 0x10165d52 */
            ii(0x1008_a67e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a67f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a680, 1);  push(esi);                            /* push esi */
            ii(0x1008_a681, 1);  push(edi);                            /* push edi */
            ii(0x1008_a682, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a683, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a685, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_a68b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a68e, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1008_a691, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1008_a694, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_a697, 3);  mov(memb[ds, edx + 69], al);          /* mov [edx+0x45], al */
            ii(0x1008_a69a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a69c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a69d, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a69e, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a69f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a6a0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a6a1, 1);  ret();                                /* ret */
        }
    }
}
