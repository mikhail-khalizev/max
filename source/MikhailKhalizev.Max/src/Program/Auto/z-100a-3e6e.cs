using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3e6e-69d0413b")]
        public void Method_100a_3e6e()
        {
            ii(0x100a_3e6e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_3e73, 5);  call(Definitions.sys_check_available_stack_size, 0xc_1eda);/* call 0x10165d52 */
            ii(0x100a_3e78, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_3e79, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_3e7a, 1);  push(edx);                            /* push edx */
            ii(0x100a_3e7b, 1);  push(esi);                            /* push esi */
            ii(0x100a_3e7c, 1);  push(edi);                            /* push edi */
            ii(0x100a_3e7d, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_3e7e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_3e80, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_3e86, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3e89, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x100a_3e90, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_3e93, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_3e95, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_3e96, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_3e97, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_3e98, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_3e99, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_3e9a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_3e9b, 1);  ret();                                /* ret */
        }
    }
}
