using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_aaca-ff00b057")]
        public void Method_100d_aaca()
        {
            ii(0x100d_aaca, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_aacf, 5);  call(Definitions.sys_check_available_stack_size, 0x8_b27e);/* call 0x10165d52 */
            ii(0x100d_aad4, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_aad5, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_aad6, 1);  push(esi);                            /* push esi */
            ii(0x100d_aad7, 1);  push(edi);                            /* push edi */
            ii(0x100d_aad8, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_aad9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_aadb, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_aae1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_aae4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_aae7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_aae9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_aaea, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_aaeb, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_aaec, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_aaed, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_aaee, 1);  ret();                                /* ret */
        }
    }
}
