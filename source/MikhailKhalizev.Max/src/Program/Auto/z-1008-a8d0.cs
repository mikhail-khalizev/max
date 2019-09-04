using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a8d0-40b00f35")]
        public void Method_1008_a8d0()
        {
            ii(0x1008_a8d0, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_a8d5, 5);  call(Definitions.sys_check_available_stack_size, 0xd_b478);/* call 0x10165d52 */
            ii(0x1008_a8da, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a8db, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a8dc, 1);  push(esi);                            /* push esi */
            ii(0x1008_a8dd, 1);  push(edi);                            /* push edi */
            ii(0x1008_a8de, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a8df, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a8e1, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1008_a8e7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a8ea, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_a8ed, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_a8f0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a8f3, 5);  call(0x1013_ac03, 0xb_030b);          /* call 0x1013ac03 */
            ii(0x1008_a8f8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a8fb, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1008_a8fe, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_a901, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a904, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_a907, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_a90a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a90c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a90d, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a90e, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a90f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a910, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a911, 1);  ret();                                /* ret */
        }
    }
}
