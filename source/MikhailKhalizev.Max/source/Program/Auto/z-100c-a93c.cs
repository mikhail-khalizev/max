using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a93c-d07cca42")]
        public void Method_100c_a93c()
        {
            ii(0x100c_a93c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_a941, 5);  call(Definitions.sys_check_available_stack_size, 0x9_b40c);/* call 0x10165d52 */
            ii(0x100c_a946, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_a947, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_a948, 1);  push(esi);                            /* push esi */
            ii(0x100c_a949, 1);  push(edi);                            /* push edi */
            ii(0x100c_a94a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_a94b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_a94d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_a953, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a956, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a959, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_a95d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a960, 5);  call(0x100a_b494, -0x1_f4d1);         /* call 0x100ab494 */
            ii(0x100c_a965, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_a968, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_a96b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_a96d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_a96e, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_a96f, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_a970, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_a971, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_a972, 1);  ret();                                /* ret */
        }
    }
}
