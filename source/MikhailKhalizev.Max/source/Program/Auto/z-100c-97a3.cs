using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_97a3-dc8e21da")]
        public void Method_100c_97a3()
        {
            ii(0x100c_97a3, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_97a8, 5);  call(Definitions.sys_check_available_stack_size, 0x9_c5a5);/* call 0x10165d52 */
            ii(0x100c_97ad, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_97ae, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_97af, 1);  push(edx);                            /* push edx */
            ii(0x100c_97b0, 1);  push(esi);                            /* push esi */
            ii(0x100c_97b1, 1);  push(edi);                            /* push edi */
            ii(0x100c_97b2, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_97b3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_97b5, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_97bb, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_97be, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x100c_97c5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_97c8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_97ca, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_97cb, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_97cc, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_97cd, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_97ce, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_97cf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_97d0, 1);  ret();                                /* ret */
        }
    }
}
