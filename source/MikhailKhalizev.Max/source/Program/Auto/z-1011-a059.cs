using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_a059-170dca1d")]
        public void Method_1011_a059()
        {
            ii(0x1011_a059, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1011_a05e, 5);  call(Definitions.sys_check_available_stack_size, 0x4_bcef);/* call 0x10165d52 */
            ii(0x1011_a063, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_a064, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_a065, 1);  push(edx);                            /* push edx */
            ii(0x1011_a066, 1);  push(esi);                            /* push esi */
            ii(0x1011_a067, 1);  push(edi);                            /* push edi */
            ii(0x1011_a068, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_a069, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_a06b, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_a071, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_a074, 5);  mov(eax, 0x101c_5316);                /* mov eax, 0x101c5316 */
            ii(0x1011_a079, 5);  call(0x1012_0d64, 0x6ce6);            /* call 0x10120d64 */
            ii(0x1011_a07e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_a081, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a084, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_a086, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_a087, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_a088, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_a089, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_a08a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_a08b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_a08c, 1);  ret();                                /* ret */
        }
    }
}
