using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_454c-a3b3ade9")]
        public void Method_1010_454c()
        {
            ii(0x1010_454c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_4551, 5);  call(Definitions.sys_check_available_stack_size, 0x6_17fc);/* call 0x10165d52 */
            ii(0x1010_4556, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_4557, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_4558, 1);  push(esi);                            /* push esi */
            ii(0x1010_4559, 1);  push(edi);                            /* push edi */
            ii(0x1010_455a, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_455b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_455d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_4563, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_4566, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_4569, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_456c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_456f, 5);  call(0x1007_6cd0, -0x8_d8a4);         /* call 0x10076cd0 */
            ii(0x1010_4574, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_4577, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1010_457a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_457d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4580, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_4583, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_4586, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_4588, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_4589, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_458a, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_458b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_458c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_458d, 1);  ret();                                /* ret */
        }
    }
}
