using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_584c-c6c9162f")]
        public void Method_1011_584c()
        {
            ii(0x1011_584c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_5851, 5);  call(Definitions.sys_check_available_stack_size, 0x5_04fc);/* call 0x10165d52 */
            ii(0x1011_5856, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_5857, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_5858, 1);  push(edx);                            /* push edx */
            ii(0x1011_5859, 1);  push(esi);                            /* push esi */
            ii(0x1011_585a, 1);  push(edi);                            /* push edi */
            ii(0x1011_585b, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_585c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_585e, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1011_5864, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_5867, 5);  call(0x100e_88bd, -0x2_cfaf);         /* call 0x100e88bd */
            ii(0x1011_586c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_586e, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_5872, 5);  call(0x1011_556b, -0x30c);            /* call 0x1011556b */
            ii(0x1011_5877, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_5879, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_587a, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_587b, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_587c, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_587d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_587e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_587f, 1);  ret();                                /* ret */
        }
    }
}
