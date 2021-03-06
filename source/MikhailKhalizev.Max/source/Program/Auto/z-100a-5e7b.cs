using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_5e7b-9063d1")]
        public void Method_100a_5e7b()
        {
            ii(0x100a_5e7b, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_5e80, 5);  call(Definitions.sys_check_available_stack_size, 0xb_fecd);/* call 0x10165d52 */
            ii(0x100a_5e85, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_5e86, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_5e87, 1);  push(esi);                            /* push esi */
            ii(0x100a_5e88, 1);  push(edi);                            /* push edi */
            ii(0x100a_5e89, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_5e8a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_5e8c, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_5e92, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_5e95, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_5e98, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_5e9b, 5);  call(0x1008_aef4, -0x1_afac);         /* call 0x1008aef4 */
            ii(0x100a_5ea0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_5ea2, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_5ea5, 5);  call(0x1008_ae70, -0x1_b03a);         /* call 0x1008ae70 */
            ii(0x100a_5eaa, 2);  jmp(0x100a_5eb4, 8); goto l_0x100a_5eb4;/* jmp 0x100a5eb4 */
        l_0x100a_5eac:
            ii(0x100a_5eac, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_5eaf, 5);  call(0x1007_6bf8, -0x2_f2bc);         /* call 0x10076bf8 */
        l_0x100a_5eb4:
            ii(0x100a_5eb4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5eb6, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_5eb9, 5);  call(0x1013_ad71, 0x9_4eb3);          /* call 0x1013ad71 */
            ii(0x100a_5ebe, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_5ec0, 2);  if(jz(0x100a_5ede, 0x1c)) goto l_0x100a_5ede;/* jz 0x100a5ede */
            ii(0x100a_5ec2, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_5ec5, 5);  call(0x1008_adc4, -0x1_b106);         /* call 0x1008adc4 */
            ii(0x100a_5eca, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_5ecd, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_5ed0, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100a_5ed3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_5ed6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_5ed9, 3);  call_abs(memd[ds, ebx + 92]);         /* call dword [ebx+0x5c] */
            ii(0x100a_5edc, 2);  jmp(0x100a_5eac, -0x32); goto l_0x100a_5eac;/* jmp 0x100a5eac */
        l_0x100a_5ede:
            ii(0x100a_5ede, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_5ee0, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_5ee3, 5);  call(0x1008_8bbc, -0x1_d32c);         /* call 0x10088bbc */
            ii(0x100a_5ee8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_5eea, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_5eeb, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_5eec, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_5eed, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_5eee, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_5eef, 1);  ret();                                /* ret */
        }
    }
}
