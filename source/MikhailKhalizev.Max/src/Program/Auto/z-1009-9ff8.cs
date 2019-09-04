using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9ff8-5eafbfd2")]
        public void Method_1009_9ff8()
        {
            ii(0x1009_9ff8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_9ffd, 5);  call(Definitions.sys_check_available_stack_size, 0xc_bd50);/* call 0x10165d52 */
            ii(0x1009_a002, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_a003, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_a004, 1);  push(edx);                            /* push edx */
            ii(0x1009_a005, 1);  push(esi);                            /* push esi */
            ii(0x1009_a006, 1);  push(edi);                            /* push edi */
            ii(0x1009_a007, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_a008, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_a00a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_a010, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_a013, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_a01a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a01d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_a01f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_a020, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_a021, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_a022, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_a023, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_a024, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_a025, 1);  ret();                                /* ret */
        }
    }
}
