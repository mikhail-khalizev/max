using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8d4c-271e7dd2")]
        public void Method_1008_8d4c()
        {
            ii(0x1008_8d4c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_8d51, 5);  call(Definitions.sys_check_available_stack_size, 0xd_cffc);/* call 0x10165d52 */
            ii(0x1008_8d56, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_8d57, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_8d58, 1);  push(esi);                            /* push esi */
            ii(0x1008_8d59, 1);  push(edi);                            /* push edi */
            ii(0x1008_8d5a, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_8d5b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_8d5d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_8d63, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8d66, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_8d69, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_8d6e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8d71, 5);  call(Definitions.my_dtor_0x101b_6edc, 0xb_1ecf);/* call 0x1013ac45 */
            ii(0x1008_8d76, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8d79, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8d7c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_8d7f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_8d82, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_8d84, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_8d85, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_8d86, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_8d87, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_8d88, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_8d89, 1);  ret();                                /* ret */
        }
    }
}
