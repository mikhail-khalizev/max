using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0198-f3dc473")]
        public void Method_100e_0198()
        {
            ii(0x100e_0198, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_019d, 5);  call(Definitions.sys_check_available_stack_size, 0x8_5bb0);/* call 0x10165d52 */
            ii(0x100e_01a2, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_01a3, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_01a4, 1);  push(esi);                            /* push esi */
            ii(0x100e_01a5, 1);  push(edi);                            /* push edi */
            ii(0x100e_01a6, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_01a7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_01a9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_01af, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_01b2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_01b5, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100e_01ba, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_01bd, 5);  call(0x1013_a1be, 0x5_9ffc);          /* call 0x1013a1be */
            ii(0x100e_01c2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_01c5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_01c8, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_01cb, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_01ce, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_01d0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_01d1, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_01d2, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_01d3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_01d4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_01d5, 1);  ret();                                /* ret */
        }
    }
}
