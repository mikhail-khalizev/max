using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7e40-33b7a59")]
        public void Method_1014_7e40()
        {
            ii(0x1014_7e40, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_7e45, 5);  call(Definitions.sys_check_available_stack_size, 0x1_df08);/* call 0x10165d52 */
            ii(0x1014_7e4a, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_7e4b, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7e4c, 1);  push(esi);                            /* push esi */
            ii(0x1014_7e4d, 1);  push(edi);                            /* push edi */
            ii(0x1014_7e4e, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7e4f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7e51, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_7e57, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7e5a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_7e5d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_7e60, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7e63, 5);  call(0x1013_a5af, -0xd8b9);           /* call 0x1013a5af */
            ii(0x1014_7e68, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_7e6a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_7e6b, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_7e6c, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_7e6d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_7e6e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_7e6f, 1);  ret();                                /* ret */
        }
    }
}
