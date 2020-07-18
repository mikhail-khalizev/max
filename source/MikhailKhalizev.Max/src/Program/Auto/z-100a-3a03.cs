using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3a03-820be779")]
        public void Method_100a_3a03()
        {
            ii(0x100a_3a03, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_3a08, 5);  call(Definitions.sys_check_available_stack_size, 0xc_2345);/* call 0x10165d52 */
            ii(0x100a_3a0d, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_3a0e, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_3a0f, 1);  push(edx);                            /* push edx */
            ii(0x100a_3a10, 1);  push(esi);                            /* push esi */
            ii(0x100a_3a11, 1);  push(edi);                            /* push edi */
            ii(0x100a_3a12, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_3a13, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_3a15, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_3a1b, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3a1e, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x100a_3a25, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_3a28, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_3a2a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_3a2b, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_3a2c, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_3a2d, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_3a2e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_3a2f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_3a30, 1);  ret();                                /* ret */
        }
    }
}
