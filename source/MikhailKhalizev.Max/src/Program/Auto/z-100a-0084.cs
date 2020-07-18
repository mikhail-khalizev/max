using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_0084-bd74a0b1")]
        public void Method_100a_0084()
        {
            ii(0x100a_0084, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_0089, 5);  call(Definitions.sys_check_available_stack_size, 0xc_5cc4);/* call 0x10165d52 */
            ii(0x100a_008e, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_008f, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_0090, 1);  push(esi);                            /* push esi */
            ii(0x100a_0091, 1);  push(edi);                            /* push edi */
            ii(0x100a_0092, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_0093, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_0095, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_009b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_009e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_00a1, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_00a4, 3);  add(edx, 0x13);                       /* add edx, 0x13 */
            ii(0x100a_00a7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_00aa, 5);  call(0x1007_5e64, -0x2_a24b);         /* call 0x10075e64 */
            ii(0x100a_00af, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_00b2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_00b4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_00b5, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_00b6, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_00b7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_00b8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_00b9, 1);  ret();                                /* ret */
        }
    }
}
