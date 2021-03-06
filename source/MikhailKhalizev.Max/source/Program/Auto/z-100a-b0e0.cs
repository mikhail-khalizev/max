using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b0e0-dafa67cd")]
        public void Method_100a_b0e0()
        {
            ii(0x100a_b0e0, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_b0e5, 5);  call(Definitions.sys_check_available_stack_size, 0xb_ac68);/* call 0x10165d52 */
            ii(0x100a_b0ea, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_b0eb, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_b0ec, 1);  push(edx);                            /* push edx */
            ii(0x100a_b0ed, 1);  push(esi);                            /* push esi */
            ii(0x100a_b0ee, 1);  push(edi);                            /* push edi */
            ii(0x100a_b0ef, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_b0f0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_b0f2, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_b0f8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_b0fb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b0fe, 5);  call(0x1013_a0af, 0x8_efac);          /* call 0x1013a0af */
            ii(0x100a_b103, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_b106, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x100a_b109, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_b10c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b10f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_b112, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_b115, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_b117, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_b118, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_b119, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_b11a, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_b11b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_b11c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_b11d, 1);  ret();                                /* ret */
        }
    }
}
