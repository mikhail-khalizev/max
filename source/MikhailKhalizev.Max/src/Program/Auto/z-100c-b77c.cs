using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b77c-1342ae06")]
        public void Method_100c_b77c()
        {
            ii(0x100c_b77c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_b781, 5);  call(Definitions.sys_check_available_stack_size, 0x9_a5cc);/* call 0x10165d52 */
            ii(0x100c_b786, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b787, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b788, 1);  push(esi);                            /* push esi */
            ii(0x100c_b789, 1);  push(edi);                            /* push edi */
            ii(0x100c_b78a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b78b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b78d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_b793, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b796, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_b799, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_b79c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b79f, 5);  call(0x1013_ac7d, 0x6_f4d9);          /* call 0x1013ac7d */
            ii(0x100c_b7a4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_b7a7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_b7aa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b7ac, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b7ad, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b7ae, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b7af, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b7b0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b7b1, 1);  ret();                                /* ret */
        }
    }
}
