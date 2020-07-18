using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9ca0-d8fd8c09")]
        public void Method_1008_9ca0()
        {
            ii(0x1008_9ca0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_9ca5, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c0a8);/* call 0x10165d52 */
            ii(0x1008_9caa, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_9cab, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9cac, 1);  push(esi);                            /* push esi */
            ii(0x1008_9cad, 1);  push(edi);                            /* push edi */
            ii(0x1008_9cae, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9caf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9cb1, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_9cb7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9cba, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_9cbd, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_9cc0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9cc3, 5);  call(0x1013_a66b, 0xb_09a3);          /* call 0x1013a66b */
            ii(0x1008_9cc8, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1008_9ccb, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_9cce, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_9cd0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_9cd1, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_9cd2, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_9cd3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_9cd4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_9cd5, 1);  ret();                                /* ret */
        }
    }
}
