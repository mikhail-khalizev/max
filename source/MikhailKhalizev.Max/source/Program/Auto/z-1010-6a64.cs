using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6a64-c6fb3b5a")]
        public void Method_1010_6a64()
        {
            ii(0x1010_6a64, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_6a69, 5);  call(Definitions.sys_check_available_stack_size, 0x5_f2e4);/* call 0x10165d52 */
            ii(0x1010_6a6e, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_6a6f, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_6a70, 1);  push(esi);                            /* push esi */
            ii(0x1010_6a71, 1);  push(edi);                            /* push edi */
            ii(0x1010_6a72, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_6a73, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_6a75, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_6a7b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_6a7e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_6a81, 5);  mov(ebx, 4);                          /* mov ebx, 0x4 */
            ii(0x1010_6a86, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_6a89, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_6a8c, 5);  call(0x1013_ba86, 0x3_4ff5);          /* call 0x1013ba86 */
            ii(0x1010_6a91, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_6a93, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_6a94, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_6a95, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_6a96, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6a97, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_6a98, 1);  ret();                                /* ret */
        }
    }
}
