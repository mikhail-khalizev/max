using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0864-8f9fa4bf")]
        public void Method_1012_0864()
        {
            ii(0x1012_0864, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_0869, 5);  call(Definitions.sys_check_available_stack_size, 0x4_54e4);/* call 0x10165d52 */
            ii(0x1012_086e, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_086f, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_0870, 1);  push(esi);                            /* push esi */
            ii(0x1012_0871, 1);  push(edi);                            /* push edi */
            ii(0x1012_0872, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_0873, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_0875, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_087b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_087e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_0881, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_0884, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0887, 5);  call(0x1013_a2ab, 0x1_9a1f);          /* call 0x1013a2ab */
            ii(0x1012_088c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_088e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_088f, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_0890, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_0891, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_0892, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_0893, 1);  ret();                                /* ret */
        }
    }
}
