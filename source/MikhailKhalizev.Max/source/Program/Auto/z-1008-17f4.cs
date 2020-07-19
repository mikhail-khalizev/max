using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_17f4-37e21aea")]
        public void Method_1008_17f4()
        {
            ii(0x1008_17f4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_17f9, 5);  call(Definitions.sys_check_available_stack_size, 0xe_4554);/* call 0x10165d52 */
            ii(0x1008_17fe, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_17ff, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_1800, 1);  push(edx);                            /* push edx */
            ii(0x1008_1801, 1);  push(esi);                            /* push esi */
            ii(0x1008_1802, 1);  push(edi);                            /* push edi */
            ii(0x1008_1803, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_1804, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_1806, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_180c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_180f, 4);  mov(memb[ss, ebp - 8], 2);            /* mov byte [ebp-0x8], 0x2 */
            ii(0x1008_1813, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_1816, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_1818, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_1819, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_181a, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_181b, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_181c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_181d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_181e, 1);  ret();                                /* ret */
        }
    }
}
