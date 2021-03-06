using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7e70-c91995f")]
        public void Method_1014_7e70()
        {
            ii(0x1014_7e70, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_7e75, 5);  call(Definitions.sys_check_available_stack_size, 0x1_ded8);/* call 0x10165d52 */
            ii(0x1014_7e7a, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_7e7b, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7e7c, 1);  push(esi);                            /* push esi */
            ii(0x1014_7e7d, 1);  push(edi);                            /* push edi */
            ii(0x1014_7e7e, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7e7f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7e81, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_7e87, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7e8a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_7e8d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_7e90, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7e93, 5);  call(0x1013_a2ab, -0xdbed);           /* call 0x1013a2ab */
            ii(0x1014_7e98, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_7e9a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_7e9b, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_7e9c, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_7e9d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_7e9e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_7e9f, 1);  ret();                                /* ret */
        }
    }
}
