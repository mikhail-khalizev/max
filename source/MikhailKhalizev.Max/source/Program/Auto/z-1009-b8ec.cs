using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b8ec-50c96cb7")]
        public void Method_1009_b8ec()
        {
            ii(0x1009_b8ec, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_b8f1, 5);  call(Definitions.sys_check_available_stack_size, 0xc_a45c);/* call 0x10165d52 */
            ii(0x1009_b8f6, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_b8f7, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_b8f8, 1);  push(esi);                            /* push esi */
            ii(0x1009_b8f9, 1);  push(edi);                            /* push edi */
            ii(0x1009_b8fa, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_b8fb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_b8fd, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_b903, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_b906, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_b909, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_b90e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_b911, 5);  call(Definitions.my_dtor_0x101b_6edc, 0x9_f32f);/* call 0x1013ac45 */
            ii(0x1009_b916, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_b919, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_b91c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_b91f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_b922, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_b924, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_b925, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_b926, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_b927, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_b928, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_b929, 1);  ret();                                /* ret */
        }
    }
}
