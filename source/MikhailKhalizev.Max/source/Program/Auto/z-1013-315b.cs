using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_315b-f109cc59")]
        public void Method_1013_315b()
        {
            ii(0x1013_315b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_3160, 5);  call(Definitions.sys_check_available_stack_size, 0x3_2bed);/* call 0x10165d52 */
            ii(0x1013_3165, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_3166, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_3167, 1);  push(esi);                            /* push esi */
            ii(0x1013_3168, 1);  push(edi);                            /* push edi */
            ii(0x1013_3169, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_316a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_316c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_3172, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_3175, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_3178, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_317b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_317e, 5);  call(0x100d_4e6c, -0x5_e317);         /* call 0x100d4e6c */
            ii(0x1013_3183, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1013_3185, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1013_3187, 5);  mov(edx, 0x26);                       /* mov edx, 0x26 */
            ii(0x1013_318c, 5);  mov(eax, 0x11);                       /* mov eax, 0x11 */
            ii(0x1013_3191, 5);  call(0x1010_5b00, -0x2_d696);         /* call 0x10105b00 */
            ii(0x1013_3196, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_3198, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_3199, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_319a, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_319b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_319c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_319d, 1);  ret();                                /* ret */
        }
    }
}
