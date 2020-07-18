using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2eb4-6b1b76de")]
        public void Method_1007_2eb4()
        {
            ii(0x1007_2eb4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_2eb9, 5);  call(Definitions.sys_check_available_stack_size, 0xf_2e94);/* call 0x10165d52 */
            ii(0x1007_2ebe, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_2ebf, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_2ec0, 1);  push(esi);                            /* push esi */
            ii(0x1007_2ec1, 1);  push(edi);                            /* push edi */
            ii(0x1007_2ec2, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_2ec3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_2ec5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_2ecb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_2ece, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
        l_0x1007_2ed1:
            ii(0x1007_2ed1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2ed3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2ed6, 5);  call(0x1013_ad71, 0xc_7e96);          /* call 0x1013ad71 */
            ii(0x1007_2edb, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_2edd, 2);  if(jz(0x1007_2f01, 0x22)) goto l_0x1007_2f01;/* jz 0x10072f01 */
            ii(0x1007_2edf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2ee2, 5);  call(0x1007_63a0, 0x34b9);            /* call 0x100763a0 */
            ii(0x1007_2ee7, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_2eeb, 2);  if(jnz(0x1007_2eff, 0x12)) goto l_0x1007_2eff;/* jnz 0x10072eff */
            ii(0x1007_2eed, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2ef0, 5);  call(0x1007_63a0, 0x34ab);            /* call 0x100763a0 */
            ii(0x1007_2ef5, 5);  call(0x1007_611c, 0x3222);            /* call 0x1007611c */
            ii(0x1007_2efa, 3);  cmp(eax, memd[ss, ebp - 8]);          /* cmp eax, [ebp-0x8] */
            ii(0x1007_2efd, 2);  if(jz(0x1007_2f01, 2)) goto l_0x1007_2f01;/* jz 0x10072f01 */
        l_0x1007_2eff:
            ii(0x1007_2eff, 2);  jmp(0x1007_2f03, 2); goto l_0x1007_2f03;/* jmp 0x10072f03 */
        l_0x1007_2f01:
            ii(0x1007_2f01, 2);  jmp(0x1007_2f0d, 0xa); goto l_0x1007_2f0d;/* jmp 0x10072f0d */
        l_0x1007_2f03:
            ii(0x1007_2f03, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2f06, 5);  call(0x1007_6bf8, 0x3ced);            /* call 0x10076bf8 */
            ii(0x1007_2f0b, 2);  jmp(0x1007_2ed1, -0x3c); goto l_0x1007_2ed1;/* jmp 0x10072ed1 */
        l_0x1007_2f0d:
            ii(0x1007_2f0d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2f0f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2f12, 5);  call(0x1013_ad71, 0xc_7e5a);          /* call 0x1013ad71 */
            ii(0x1007_2f17, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1007_2f1a, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_2f1d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_2f1f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_2f20, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_2f21, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_2f22, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_2f23, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_2f24, 1);  ret();                                /* ret */
        }
    }
}
