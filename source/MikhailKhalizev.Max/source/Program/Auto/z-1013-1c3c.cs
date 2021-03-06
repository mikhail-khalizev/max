using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1c3c-4737b54a")]
        public void Method_1013_1c3c()
        {
            ii(0x1013_1c3c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_1c41, 5);  call(Definitions.sys_check_available_stack_size, 0x3_410c);/* call 0x10165d52 */
            ii(0x1013_1c46, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_1c47, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_1c48, 1);  push(esi);                            /* push esi */
            ii(0x1013_1c49, 1);  push(edi);                            /* push edi */
            ii(0x1013_1c4a, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_1c4b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_1c4d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_1c53, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1c56, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_1c59, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_1c5c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1c5f, 5);  call(0x1013_ac7d, 0x9019);            /* call 0x1013ac7d */
            ii(0x1013_1c64, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_1c67, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_1c6a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_1c6c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_1c6d, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_1c6e, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_1c6f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_1c70, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_1c71, 1);  ret();                                /* ret */
        }
    }
}
