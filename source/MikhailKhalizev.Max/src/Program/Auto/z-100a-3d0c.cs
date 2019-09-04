using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3d0c-f05fe4a3")]
        public void Method_100a_3d0c()
        {
            ii(0x100a_3d0c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_3d11, 5);  call(Definitions.sys_check_available_stack_size, 0xc_203c);/* call 0x10165d52 */
            ii(0x100a_3d16, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_3d17, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_3d18, 1);  push(edx);                            /* push edx */
            ii(0x100a_3d19, 1);  push(esi);                            /* push esi */
            ii(0x100a_3d1a, 1);  push(edi);                            /* push edi */
            ii(0x100a_3d1b, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_3d1c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_3d1e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_3d24, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3d27, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x100a_3d2e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_3d31, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_3d33, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_3d34, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_3d35, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_3d36, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_3d37, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_3d38, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_3d39, 1);  ret();                                /* ret */
        }
    }
}
