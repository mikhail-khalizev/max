using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7c78-23c6c46e")]
        public void Method_1008_7c78()
        {
            ii(0x1008_7c78, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_7c7d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_e0d0);/* call 0x10165d52 */
            ii(0x1008_7c82, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_7c83, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_7c84, 1);  push(edx);                            /* push edx */
            ii(0x1008_7c85, 1);  push(esi);                            /* push esi */
            ii(0x1008_7c86, 1);  push(edi);                            /* push edi */
            ii(0x1008_7c87, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_7c88, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_7c8a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_7c90, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_7c93, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x1008_7c9a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_7c9d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_7c9f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_7ca0, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_7ca1, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_7ca2, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_7ca3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_7ca4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_7ca5, 1);  ret();                                /* ret */
        }
    }
}
