using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2a82-4997ab4f")]
        public void Method_100a_2a82()
        {
            ii(0x100a_2a82, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_2a87, 5);  call(Definitions.sys_check_available_stack_size, 0xc_32c6);/* call 0x10165d52 */
            ii(0x100a_2a8c, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_2a8d, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_2a8e, 1);  push(edx);                            /* push edx */
            ii(0x100a_2a8f, 1);  push(esi);                            /* push esi */
            ii(0x100a_2a90, 1);  push(edi);                            /* push edi */
            ii(0x100a_2a91, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_2a92, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_2a94, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_2a9a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_2a9d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_2aa2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2aa5, 5);  call(0x100a_2a04, -0xa6);             /* call 0x100a2a04 */
            ii(0x100a_2aaa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_2aac, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_2aad, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_2aae, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_2aaf, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_2ab0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_2ab1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_2ab2, 1);  ret();                                /* ret */
        }
    }
}
