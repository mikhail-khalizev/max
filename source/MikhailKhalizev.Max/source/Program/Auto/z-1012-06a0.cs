using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_06a0-d89ce37b")]
        public void Method_1012_06a0()
        {
            ii(0x1012_06a0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_06a5, 5);  call(Definitions.sys_check_available_stack_size, 0x4_56a8);/* call 0x10165d52 */
            ii(0x1012_06aa, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_06ab, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_06ac, 1);  push(edx);                            /* push edx */
            ii(0x1012_06ad, 1);  push(esi);                            /* push esi */
            ii(0x1012_06ae, 1);  push(edi);                            /* push edi */
            ii(0x1012_06af, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_06b0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_06b2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_06b8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_06bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_06be, 5);  call(0x1007_6c30, -0xa_9a93);         /* call 0x10076c30 */
            ii(0x1012_06c3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_06c6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_06c9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_06cb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_06cc, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_06cd, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_06ce, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_06cf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_06d0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_06d1, 1);  ret();                                /* ret */
        }
    }
}
