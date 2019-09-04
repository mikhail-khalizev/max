using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c26f-fbab5179")]
        public void Method_100e_c26f()
        {
            ii(0x100e_c26f, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100e_c274, 5);  call(Definitions.sys_check_available_stack_size, 0x7_9ad9);/* call 0x10165d52 */
            ii(0x100e_c279, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_c27a, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_c27b, 1);  push(esi);                            /* push esi */
            ii(0x100e_c27c, 1);  push(edi);                            /* push edi */
            ii(0x100e_c27d, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_c27e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_c280, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100e_c286, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_c289, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_c28c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_c28f, 5);  call(0x1007_6338, -0x7_5f5c);         /* call 0x10076338 */
            ii(0x100e_c294, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_c296, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c299, 5);  call(0x1007_64b8, -0x7_5de6);         /* call 0x100764b8 */
            ii(0x100e_c29e, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_c2a5, 2);  jmp(0x100e_c2af, 8); goto l_0x100e_c2af;/* jmp 0x100ec2af */
        l_0x100e_c2a7:
            ii(0x100e_c2a7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c2aa, 5);  call(0x1007_6bf8, -0x7_56b7);         /* call 0x10076bf8 */
        l_0x100e_c2af:
            ii(0x100e_c2af, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c2b1, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c2b4, 5);  call(0x1013_ad71, 0x4_eab8);          /* call 0x1013ad71 */
            ii(0x100e_c2b9, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_c2bb, 2);  if(jz(0x100e_c2e4, 0x27)) goto l_0x100e_c2e4;/* jz 0x100ec2e4 */
            ii(0x100e_c2bd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c2c0, 5);  call(0x1007_63a0, -0x7_5f25);         /* call 0x100763a0 */
            ii(0x100e_c2c5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c2c7, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100e_c2ca, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c2ce, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_c2d0, 2);  if(jnz(0x100e_c2e2, 0x10)) goto l_0x100e_c2e2;/* jnz 0x100ec2e2 */
            ii(0x100e_c2d2, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c2d5, 5);  call(0x1007_63a0, -0x7_5f3a);         /* call 0x100763a0 */
            ii(0x100e_c2da, 5);  call(0x1015_09a6, 0x6_46c7);          /* call 0x101509a6 */
            ii(0x100e_c2df, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x100e_c2e2:
            ii(0x100e_c2e2, 2);  jmp(0x100e_c2a7, -0x3d); goto l_0x100e_c2a7;/* jmp 0x100ec2a7 */
        l_0x100e_c2e4:
            ii(0x100e_c2e4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_c2e7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_c2ea, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c2ec, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c2ef, 5);  call(0x1007_5f6c, -0x7_6388);         /* call 0x10075f6c */
            ii(0x100e_c2f4, 2);  jmp(0x100e_c300, 0xa); goto l_0x100e_c300;/* jmp 0x100ec300 */
        //  ii(0x100e_c2f6, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x100e_c2f8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
        //  ii(0x100e_c2fb, 5);  call(0x1007_5f6c, -0x7_6394);         /* call 0x10075f6c */
        l_0x100e_c300:
            ii(0x100e_c300, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_c303, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_c305, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_c306, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_c307, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_c308, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_c309, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_c30a, 1);  ret();                                /* ret */
        }
    }
}
