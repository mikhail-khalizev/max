using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7c14-fef06f31")]
        public void Method_100b_7c14()
        {
            ii(0x100b_7c14, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_7c19, 5);  call(Definitions.sys_check_available_stack_size, 0xa_e134);/* call 0x10165d52 */
            ii(0x100b_7c1e, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7c1f, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7c20, 1);  push(esi);                            /* push esi */
            ii(0x100b_7c21, 1);  push(edi);                            /* push edi */
            ii(0x100b_7c22, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7c23, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7c25, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_7c2b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7c2e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7c31, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_7c34, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7c37, 5);  call(0x1013_a2ab, 0x8_266f);          /* call 0x1013a2ab */
            ii(0x100b_7c3c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7c3e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7c3f, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7c40, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7c41, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7c42, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7c43, 1);  ret();                                /* ret */
        }
    }
}
