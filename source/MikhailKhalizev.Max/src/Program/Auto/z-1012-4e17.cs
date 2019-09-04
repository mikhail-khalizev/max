using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4e17-45d05aa2")]
        public void Method_1012_4e17()
        {
            ii(0x1012_4e17, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_4e1c, 5);  call(Definitions.sys_check_available_stack_size, 0x4_0f31);/* call 0x10165d52 */
            ii(0x1012_4e21, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_4e22, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_4e23, 1);  push(edx);                            /* push edx */
            ii(0x1012_4e24, 1);  push(esi);                            /* push esi */
            ii(0x1012_4e25, 1);  push(edi);                            /* push edi */
            ii(0x1012_4e26, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_4e27, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_4e29, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1012_4e2f, 5);  mov(eax, 0x5d);                       /* mov eax, 0x5d */
            ii(0x1012_4e34, 5);  call(0x1012_4dd5, -0x64);             /* call 0x10124dd5 */
            ii(0x1012_4e39, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_4e3b, 5);  call(0x1012_4c13, -0x22d);            /* call 0x10124c13 */
            ii(0x1012_4e40, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_4e43, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_4e46, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_4e48, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_4e49, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_4e4a, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_4e4b, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_4e4c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_4e4d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_4e4e, 1);  ret();                                /* ret */
        }
    }
}
