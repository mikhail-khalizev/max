using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a1e8-ae73a978")]
        public void Method_1008_a1e8()
        {
            ii(0x1008_a1e8, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_a1ed, 5);  call(Definitions.sys_check_available_stack_size, 0xd_bb60);/* call 0x10165d52 */
            ii(0x1008_a1f2, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a1f3, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a1f4, 1);  push(edx);                            /* push edx */
            ii(0x1008_a1f5, 1);  push(esi);                            /* push esi */
            ii(0x1008_a1f6, 1);  push(edi);                            /* push edi */
            ii(0x1008_a1f7, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a1f8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a1fa, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_a200, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a203, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a206, 5);  call(0x1007_6d58, -0x1_34b3);         /* call 0x10076d58 */
            ii(0x1008_a20b, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a20e, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1008_a211, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a214, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a217, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_a21a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_a21d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a21f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a220, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a221, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a222, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_a223, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a224, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a225, 1);  ret();                                /* ret */
        }
    }
}
