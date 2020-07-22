using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1ad4-a7697fdd")]
        public void Method_1013_1ad4()
        {
            ii(0x1013_1ad4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_1ad9, 5);  call(Definitions.sys_check_available_stack_size, 0x3_4274);/* call 0x10165d52 */
            ii(0x1013_1ade, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_1adf, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_1ae0, 1);  push(edx);                            /* push edx */
            ii(0x1013_1ae1, 1);  push(esi);                            /* push esi */
            ii(0x1013_1ae2, 1);  push(edi);                            /* push edi */
            ii(0x1013_1ae3, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_1ae4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_1ae6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_1aec, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_1aef, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1af2, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1013_1af5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1af8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1afb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_1afd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_1afe, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_1aff, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_1b00, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_1b01, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_1b02, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_1b03, 1);  ret();                                /* ret */
        }
    }
}
