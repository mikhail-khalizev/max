using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b36c-deec3836")]
        public void Method_100a_b36c()
        {
            ii(0x100a_b36c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_b371, 5);  call(Definitions.sys_check_available_stack_size, 0xb_a9dc);/* call 0x10165d52 */
            ii(0x100a_b376, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_b377, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_b378, 1);  push(esi);                            /* push esi */
            ii(0x100a_b379, 1);  push(edi);                            /* push edi */
            ii(0x100a_b37a, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_b37b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_b37d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_b383, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_b386, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_b389, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_b38c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_b38f, 5);  call(0x1013_ac03, 0x8_f86f);          /* call 0x1013ac03 */
            ii(0x100a_b394, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_b397, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_b39a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_b39d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_b3a0, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_b3a3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_b3a6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_b3a8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_b3a9, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_b3aa, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_b3ab, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_b3ac, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_b3ad, 1);  ret();                                /* ret */
        }
    }
}