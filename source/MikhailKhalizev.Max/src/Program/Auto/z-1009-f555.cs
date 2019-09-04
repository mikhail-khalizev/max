using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_f555-1385506b")]
        public void Method_1009_f555()
        {
            ii(0x1009_f555, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_f55a, 5);  call(Definitions.sys_check_available_stack_size, 0xc_67f3);/* call 0x10165d52 */
            ii(0x1009_f55f, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_f560, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_f561, 1);  push(edx);                            /* push edx */
            ii(0x1009_f562, 1);  push(esi);                            /* push esi */
            ii(0x1009_f563, 1);  push(edi);                            /* push edi */
            ii(0x1009_f564, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_f565, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_f567, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_f56d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_f570, 4);  mov(memb[ss, ebp - 8], 4);            /* mov byte [ebp-0x8], 0x4 */
            ii(0x1009_f574, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_f577, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_f579, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_f57a, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_f57b, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_f57c, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_f57d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_f57e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_f57f, 1);  ret();                                /* ret */
        }
    }
}
