using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4a1c-7c93afb4")]
        public void Method_1016_4a1c()
        {
            ii(0x1016_4a1c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1016_4a21, 5);  call(Definitions.sys_check_available_stack_size, 0x132c);/* call 0x10165d52 */
            ii(0x1016_4a26, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_4a27, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_4a28, 1);  push(esi);                            /* push esi */
            ii(0x1016_4a29, 1);  push(edi);                            /* push edi */
            ii(0x1016_4a2a, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_4a2b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_4a2d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1016_4a33, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4a36, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_4a39, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_4a3c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4a3f, 5);  call(0x1007_6d14, -0xe_dd30);         /* call 0x10076d14 */
            ii(0x1016_4a44, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4a47, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1016_4a4a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1016_4a4d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4a50, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_4a53, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1016_4a56, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_4a58, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_4a59, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_4a5a, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_4a5b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_4a5c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_4a5d, 1);  ret();                                /* ret */
        }
    }
}
