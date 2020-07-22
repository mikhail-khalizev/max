using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b0ac-1e7c01c8")]
        public void Method_100a_b0ac()
        {
            ii(0x100a_b0ac, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_b0b1, 5);  call(Definitions.sys_check_available_stack_size, 0xb_ac9c);/* call 0x10165d52 */
            ii(0x100a_b0b6, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_b0b7, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_b0b8, 1);  push(edx);                            /* push edx */
            ii(0x100a_b0b9, 1);  push(esi);                            /* push esi */
            ii(0x100a_b0ba, 1);  push(edi);                            /* push edi */
            ii(0x100a_b0bb, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_b0bc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_b0be, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_b0c4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_b0c7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b0ca, 5);  call(0x1007_6b58, -0x3_4577);         /* call 0x10076b58 */
            ii(0x100a_b0cf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_b0d2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_b0d5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_b0d7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_b0d8, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_b0d9, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_b0da, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_b0db, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_b0dc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_b0dd, 1);  ret();                                /* ret */
        }
    }
}
