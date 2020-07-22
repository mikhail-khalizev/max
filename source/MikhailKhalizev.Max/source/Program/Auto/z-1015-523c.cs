using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_523c-5f46fcd0")]
        public void Method_1015_523c()
        {
            ii(0x1015_523c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1015_5241, 5);  call(Definitions.sys_check_available_stack_size, 0x1_0b0c);/* call 0x10165d52 */
            ii(0x1015_5246, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_5247, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_5248, 1);  push(esi);                            /* push esi */
            ii(0x1015_5249, 1);  push(edi);                            /* push edi */
            ii(0x1015_524a, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_524b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_524d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1015_5253, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_5256, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_5259, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_525c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_525f, 5);  call(0x1013_a112, -0x1_b152);         /* call 0x1013a112 */
            ii(0x1015_5264, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_5267, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1015_526a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_526d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_5270, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_5273, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_5276, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_5278, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_5279, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_527a, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_527b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_527c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_527d, 1);  ret();                                /* ret */
        }
    }
}
