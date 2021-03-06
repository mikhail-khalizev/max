using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_aa3c-f339cb59")]
        public void Method_1013_aa3c()
        {
            ii(0x1013_aa3c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_aa41, 5);  call(Definitions.sys_check_available_stack_size, 0x2_b30c);/* call 0x10165d52 */
            ii(0x1013_aa46, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_aa47, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_aa48, 1);  push(edx);                            /* push edx */
            ii(0x1013_aa49, 1);  push(esi);                            /* push esi */
            ii(0x1013_aa4a, 1);  push(edi);                            /* push edi */
            ii(0x1013_aa4b, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_aa4c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_aa4e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_aa54, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_aa57, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_aa5a, 5);  call(0x1007_6c68, -0xc_3df7);         /* call 0x10076c68 */
            ii(0x1013_aa5f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_aa62, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_aa65, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_aa67, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_aa68, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_aa69, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_aa6a, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_aa6b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_aa6c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_aa6d, 1);  ret();                                /* ret */
        }
    }
}
