using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5df0-70e6cc9c")]
        public void Method_100b_5df0()
        {
            ii(0x100b_5df0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_5df5, 5);  call(Definitions.sys_check_available_stack_size, 0xa_ff58);/* call 0x10165d52 */
            ii(0x100b_5dfa, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_5dfb, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_5dfc, 1);  push(edx);                            /* push edx */
            ii(0x100b_5dfd, 1);  push(esi);                            /* push esi */
            ii(0x100b_5dfe, 1);  push(edi);                            /* push edi */
            ii(0x100b_5dff, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_5e00, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_5e02, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_5e08, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_5e0b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_5e0e, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_5e11, 5);  call(0x1007_6338, -0x3_fade);         /* call 0x10076338 */
            ii(0x100b_5e16, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x100b_5e19, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_5e1b, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_5e1d, 5);  call(0x1007_64b8, -0x3_f96a);         /* call 0x100764b8 */
            ii(0x100b_5e22, 2);  jmp(0x100b_5e2c, 8); goto l_0x100b_5e2c;/* jmp 0x100b5e2c */
        l_0x100b_5e24:
            ii(0x100b_5e24, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100b_5e27, 5);  call(0x1007_6bf8, -0x3_f234);         /* call 0x10076bf8 */
        l_0x100b_5e2c:
            ii(0x100b_5e2c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_5e2e, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100b_5e31, 5);  call(0x1013_ad71, 0x8_4f3b);          /* call 0x1013ad71 */
            ii(0x100b_5e36, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_5e38, 2);  if(jz(0x100b_5e55, 0x1b)) goto l_0x100b_5e55;/* jz 0x100b5e55 */
            ii(0x100b_5e3a, 5);  call(0x1008_ac50, -0x2_b1ef);         /* call 0x1008ac50 */
            ii(0x100b_5e3f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100b_5e41, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100b_5e43, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_5e46, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100b_5e49, 5);  call(0x1007_63a0, -0x3_faae);         /* call 0x100763a0 */
            ii(0x100b_5e4e, 5);  call(0x1015_2962, 0x9_cb0f);          /* call 0x10152962 */
            ii(0x100b_5e53, 2);  jmp(0x100b_5e24, -0x31); goto l_0x100b_5e24;/* jmp 0x100b5e24 */
        l_0x100b_5e55:
            ii(0x100b_5e55, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_5e58, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_5e5b, 5);  call(0x1013_a6f4, 0x8_4894);          /* call 0x1013a6f4 */
            ii(0x100b_5e60, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_5e62, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_5e65, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100b_5e68, 5);  call(0x1008_afe4, -0x2_ae89);         /* call 0x1008afe4 */
            ii(0x100b_5e6d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_5e70, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100b_5e75, 5);  call(0x100a_5e27, -0x1_0053);         /* call 0x100a5e27 */
            ii(0x100b_5e7a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_5e7c, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100b_5e7f, 5);  call(0x1007_5f6c, -0x3_ff18);         /* call 0x10075f6c */
            ii(0x100b_5e84, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_5e86, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_5e87, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_5e88, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_5e89, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_5e8a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_5e8b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_5e8c, 1);  ret();                                /* ret */
        }
    }
}
