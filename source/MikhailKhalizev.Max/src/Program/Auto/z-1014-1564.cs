using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1564-241118e7")]
        public void Method_1014_1564()
        {
            ii(0x1014_1564, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_1569, 5);  call(Definitions.sys_check_available_stack_size, 0x2_47e4);/* call 0x10165d52 */
            ii(0x1014_156e, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_156f, 1);  push(esi);                            /* push esi */
            ii(0x1014_1570, 1);  push(edi);                            /* push edi */
            ii(0x1014_1571, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_1572, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_1574, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_157a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_157d, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_1580, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1014_1583, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_1587, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_158a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_158d, 5);  call(0x1013_b0f9, -0x6499);           /* call 0x1013b0f9 */
            ii(0x1014_1592, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_1594, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_1595, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_1596, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_1597, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_1598, 1);  ret();                                /* ret */
        }
    }
}
