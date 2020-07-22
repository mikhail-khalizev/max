using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a998-fcb7ee50")]
        public void Method_1008_a998()
        {
            ii(0x1008_a998, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1008_a99d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b3b0);/* call 0x10165d52 */
            ii(0x1008_a9a2, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a9a3, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a9a4, 1);  push(esi);                            /* push esi */
            ii(0x1008_a9a5, 1);  push(edi);                            /* push edi */
            ii(0x1008_a9a6, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a9a7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a9a9, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_a9af, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a9b2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_a9b5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_a9b8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a9bb, 5);  add(eax, 0x82);                       /* add eax, 0x82 */
            ii(0x1008_a9c0, 5);  call(0x1007_6630, -0x1_4395);         /* call 0x10076630 */
            ii(0x1008_a9c5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a9c7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a9c8, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a9c9, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a9ca, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a9cb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a9cc, 1);  ret();                                /* ret */
        }
    }
}
