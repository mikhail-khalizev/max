using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b198-bb7bbc0f")]
        public void Method_100c_b198()
        {
            ii(0x100c_b198, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_b19d, 5);  call(Definitions.sys_check_available_stack_size, 0x9_abb0);/* call 0x10165d52 */
            ii(0x100c_b1a2, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b1a3, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b1a4, 1);  push(esi);                            /* push esi */
            ii(0x100c_b1a5, 1);  push(edi);                            /* push edi */
            ii(0x100c_b1a6, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b1a7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b1a9, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100c_b1af, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b1b2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_b1b5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_b1b8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b1bb, 5);  call(0x1007_6d14, -0x5_44ac);         /* call 0x10076d14 */
            ii(0x100c_b1c0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b1c3, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100c_b1c6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_b1c9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b1cc, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_b1cf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_b1d2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b1d4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b1d5, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b1d6, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b1d7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b1d8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b1d9, 1);  ret();                                /* ret */
        }
    }
}
