using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b210-ba43cf15")]
        public void Method_1011_b210()
        {
            ii(0x1011_b210, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1011_b215, 5);  call(Definitions.sys_check_available_stack_size, 0x4_ab38);/* call 0x10165d52 */
            ii(0x1011_b21a, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_b21b, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_b21c, 1);  push(esi);                            /* push esi */
            ii(0x1011_b21d, 1);  push(edi);                            /* push edi */
            ii(0x1011_b21e, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_b21f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_b221, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1011_b227, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_b22a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_b22d, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1011_b231, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_b234, 5);  call(0x100e_0720, -0x3_ab19);         /* call 0x100e0720 */
            ii(0x1011_b239, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_b23c, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1011_b240, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1011_b243, 3);  add(ebx, 8);                          /* add ebx, 0x8 */
            ii(0x1011_b246, 5);  mov(edx, StringDefinitions.XEnd3);    /* mov edx, 0x101a7d60 */
            ii(0x1011_b24b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b24e, 5);  call(0x1014_5c2e, 0x2_a9db);          /* call 0x10145c2e */
            ii(0x1011_b253, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1011_b256, 3);  add(ebx, 0xa);                        /* add ebx, 0xa */
            ii(0x1011_b259, 5);  mov(edx, StringDefinitions.YEnd3);    /* mov edx, 0x101a7d66 */
            ii(0x1011_b25e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b261, 5);  call(0x1014_5c2e, 0x2_a9c8);          /* call 0x10145c2e */
            ii(0x1011_b266, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1011_b269, 3);  add(ebx, 0x16);                       /* add ebx, 0x16 */
            ii(0x1011_b26c, 5);  mov(edx, StringDefinitions.Index9);   /* mov edx, 0x101a7d6c */
            ii(0x1011_b271, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b274, 5);  call(0x1014_5c2e, 0x2_a9b5);          /* call 0x10145c2e */
            ii(0x1011_b279, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b27c, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_b27f, 5);  call(0x1012_0b8c, 0x5908);            /* call 0x10120b8c */
        l_0x1011_b284:
            ii(0x1011_b284, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1011_b286, 5);  mov(ebx, StringDefinitions.Step);     /* mov ebx, 0x101a7d72 */
            ii(0x1011_b28b, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x1011_b28e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b291, 5);  call(0x1014_625c, 0x2_afc6);          /* call 0x1014625c */
            ii(0x1011_b296, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_b298, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_b29b, 5);  call(0x100e_06a4, -0x3_abfc);         /* call 0x100e06a4 */
            ii(0x1011_b2a0, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1011_b2a2, 5);  call(0x1013_ad71, 0x1_faca);          /* call 0x1013ad71 */
            ii(0x1011_b2a7, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_b2a9, 2);  if(jz(0x1011_b2b4, 9)) goto l_0x1011_b2b4;/* jz 0x1011b2b4 */
            ii(0x1011_b2ab, 7);  mov(memd[ss, ebp - 32], 1);           /* mov dword [ebp-0x20], 0x1 */
            ii(0x1011_b2b2, 2);  jmp(0x1011_b2bb, 7); goto l_0x1011_b2bb;/* jmp 0x1011b2bb */
        l_0x1011_b2b4:
            ii(0x1011_b2b4, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1011_b2bb:
            ii(0x1011_b2bb, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_b2be, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_b2c1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_b2c3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_b2c6, 5);  call(0x100e_03fc, -0x3_aecf);         /* call 0x100e03fc */
            ii(0x1011_b2cb, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1011_b2cf, 2);  if(jz(0x1011_b30e, 0x3d)) goto l_0x1011_b30e;/* jz 0x1011b30e */
            ii(0x1011_b2d1, 5);  mov(edx, StringDefinitions.X5);       /* mov edx, 0x101a7d77 */
            ii(0x1011_b2d6, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_b2d9, 5);  call(0x100e_0648, -0x3_ac96);         /* call 0x100e0648 */
            ii(0x1011_b2de, 5);  call(0x1014_60aa, 0x2_adc7);          /* call 0x101460aa */
            ii(0x1011_b2e3, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1011_b2e6, 5);  mov(edx, StringDefinitions.Y3);       /* mov edx, 0x101a7d79 */
            ii(0x1011_b2eb, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_b2ee, 5);  call(0x100e_0648, -0x3_acab);         /* call 0x100e0648 */
            ii(0x1011_b2f3, 5);  call(0x1014_60aa, 0x2_adb2);          /* call 0x101460aa */
            ii(0x1011_b2f8, 3);  mov(memb[ss, ebp - 15], al);          /* mov [ebp-0xf], al */
            ii(0x1011_b2fb, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1011_b2fe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b301, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_b304, 5);  call(0x1012_0b08, 0x57ff);            /* call 0x10120b08 */
            ii(0x1011_b309, 5);  jmp(0x1011_b284, -0x8a); goto l_0x1011_b284;/* jmp 0x1011b284 */
        l_0x1011_b30e:
            ii(0x1011_b30e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_b310, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_b313, 5);  call(0x100e_03fc, -0x3_af1c);         /* call 0x100e03fc */
            ii(0x1011_b318, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_b31a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_b31b, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_b31c, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_b31d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_b31e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_b31f, 1);  ret();                                /* ret */
        }
    }
}
