using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_39d5-f2a1fa6a")]
        public void Method_100a_39d5()
        {
            ii(0x100a_39d5, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_39da, 5);  call(Definitions.sys_check_available_stack_size, 0xc_2373);/* call 0x10165d52 */
            ii(0x100a_39df, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_39e0, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_39e1, 1);  push(edx);                            /* push edx */
            ii(0x100a_39e2, 1);  push(esi);                            /* push esi */
            ii(0x100a_39e3, 1);  push(edi);                            /* push edi */
            ii(0x100a_39e4, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_39e5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_39e7, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_39ed, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_39f0, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x100a_39f7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_39fa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_39fc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_39fd, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_39fe, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_39ff, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_3a00, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_3a01, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_3a02, 1);  ret();                                /* ret */
        }
    }
}
