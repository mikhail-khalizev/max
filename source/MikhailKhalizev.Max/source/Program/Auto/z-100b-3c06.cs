using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3c06-60893fc8")]
        public void Method_100b_3c06()
        {
            ii(0x100b_3c06, 5);  push(0x48);                           /* push 0x48 */
            ii(0x100b_3c0b, 5);  call(Definitions.sys_check_available_stack_size, 0xb_2142);/* call 0x10165d52 */
            ii(0x100b_3c10, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_3c11, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_3c12, 1);  push(esi);                            /* push esi */
            ii(0x100b_3c13, 1);  push(edi);                            /* push edi */
            ii(0x100b_3c14, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_3c15, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_3c17, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x100b_3c1d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_3c20, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_3c23, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_3c25, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3c28, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3c2b, 5);  call(0x1013_ad11, 0x8_70e1);          /* call 0x1013ad11 */
            ii(0x100b_3c30, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_3c32, 2);  if(jnz(0x100b_3c46, 0x12)) goto l_0x100b_3c46;/* jnz 0x100b3c46 */
            ii(0x100b_3c34, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_3c37, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3c3a, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3c3d, 5);  call(0x1008_b4ec, -0x2_8756);         /* call 0x1008b4ec */
            ii(0x100b_3c42, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_3c44, 2);  if(jz(0x100b_3c4f, 9)) goto l_0x100b_3c4f;/* jz 0x100b3c4f */
        l_0x100b_3c46:
            ii(0x100b_3c46, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_3c4a, 5);  jmp(0x100b_3e00, 0x1b1); goto l_0x100b_3e00;/* jmp 0x100b3e00 */
        l_0x100b_3c4f:
            ii(0x100b_3c4f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3c52, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3c55, 5);  call(0x1007_6574, -0x3_d6e6);         /* call 0x10076574 */
            ii(0x100b_3c5a, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_3c5e, 2);  if(jz(0x100b_3c71, 0x11)) goto l_0x100b_3c71;/* jz 0x100b3c71 */
            ii(0x100b_3c60, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3c63, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3c66, 5);  call(0x1007_6574, -0x3_d6f7);         /* call 0x10076574 */
            ii(0x100b_3c6b, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100b_3c6f, 2);  if(jnz(0x100b_3c73, 2)) goto l_0x100b_3c73;/* jnz 0x100b3c73 */
        l_0x100b_3c71:
            ii(0x100b_3c71, 2);  jmp(0x100b_3c84, 0x11); goto l_0x100b_3c84;/* jmp 0x100b3c84 */
        l_0x100b_3c73:
            ii(0x100b_3c73, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3c76, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3c79, 5);  call(0x1007_6574, -0x3_d70a);         /* call 0x10076574 */
            ii(0x100b_3c7e, 4);  cmp(memb[ds, eax + 61], 9);           /* cmp byte [eax+0x3d], 0x9 */
            ii(0x100b_3c82, 2);  if(jnz(0x100b_3c86, 2)) goto l_0x100b_3c86;/* jnz 0x100b3c86 */
        l_0x100b_3c84:
            ii(0x100b_3c84, 2);  jmp(0x100b_3c97, 0x11); goto l_0x100b_3c97;/* jmp 0x100b3c97 */
        l_0x100b_3c86:
            ii(0x100b_3c86, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3c89, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3c8c, 5);  call(0x1007_6574, -0x3_d71d);         /* call 0x10076574 */
            ii(0x100b_3c91, 4);  cmp(memb[ds, eax + 61], 0x16);        /* cmp byte [eax+0x3d], 0x16 */
            ii(0x100b_3c95, 2);  if(jnz(0x100b_3c99, 2)) goto l_0x100b_3c99;/* jnz 0x100b3c99 */
        l_0x100b_3c97:
            ii(0x100b_3c97, 2);  jmp(0x100b_3caa, 0x11); goto l_0x100b_3caa;/* jmp 0x100b3caa */
        l_0x100b_3c99:
            ii(0x100b_3c99, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3c9c, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3c9f, 5);  call(0x1007_6574, -0x3_d730);         /* call 0x10076574 */
            ii(0x100b_3ca4, 4);  cmp(memb[ds, eax + 62], 0xe);         /* cmp byte [eax+0x3e], 0xe */
            ii(0x100b_3ca8, 2);  if(jnz(0x100b_3caf, 5)) goto l_0x100b_3caf;/* jnz 0x100b3caf */
        l_0x100b_3caa:
            ii(0x100b_3caa, 5);  jmp(0x100b_3df4, 0x145); goto l_0x100b_3df4;/* jmp 0x100b3df4 */
        l_0x100b_3caf:
            ii(0x100b_3caf, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_3cb2, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_3cb5, 5);  call(0x1008_b060, -0x2_8c5a);         /* call 0x1008b060 */
            ii(0x100b_3cba, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100b_3cbc, 1);  push(eax);                            /* push eax */
            ii(0x100b_3cbd, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x100b_3cbf, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100b_3cc1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_3cc3, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100b_3cc6, 5);  call(0x1008_b148, -0x2_8b83);         /* call 0x1008b148 */
            ii(0x100b_3ccb, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100b_3cce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3cd1, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_3cd4, 5);  call(0x1007_6574, -0x3_d765);         /* call 0x10076574 */
            ii(0x100b_3cd9, 5);  call(0x1015_2532, 0x9_e854);          /* call 0x10152532 */
            ii(0x100b_3cde, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3ce1, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3ce4, 5);  call(0x1007_6574, -0x3_d775);         /* call 0x10076574 */
            ii(0x100b_3ce9, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x100b_3cec, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100b_3cef, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3cf2, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3cf5, 5);  call(0x1007_6574, -0x3_d786);         /* call 0x10076574 */
            ii(0x100b_3cfa, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x100b_3cfd, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100b_3d00, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100b_3d03, 5);  call(0x1007_6aac, -0x3_d25c);         /* call 0x10076aac */
            ii(0x100b_3d08, 3);  lea(ebx, memd[ss, ebp - 32]);         /* lea ebx, [ebp-0x20] */
            ii(0x100b_3d0b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_3d0d, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_3d0f, 5);  call(0x1010_82ce, 0x5_45ba);          /* call 0x101082ce */
            ii(0x100b_3d14, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_3d16, 6);  if(jnz(0x100b_3dea, 0xce)) goto l_0x100b_3dea;/* jnz 0x100b3dea */
            ii(0x100b_3d1c, 5);  call(0x1008_ac50, -0x2_90d1);         /* call 0x1008ac50 */
            ii(0x100b_3d21, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100b_3d23, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100b_3d25, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_3d28, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3d2b, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3d2e, 5);  call(0x1007_6574, -0x3_d7bf);         /* call 0x10076574 */
            ii(0x100b_3d33, 5);  call(0x1015_2962, 0x9_ec2a);          /* call 0x10152962 */
            ii(0x100b_3d38, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3d3b, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100b_3d3e, 5);  call(0x1008_af28, -0x2_8e1b);         /* call 0x1008af28 */
            ii(0x100b_3d43, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100b_3d46, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100b_3d49, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_3d4c, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100b_3d4f, 3);  call_abs(memd[ds, edx + 32]);         /* call dword [edx+0x20] */
            ii(0x100b_3d52, 2);  cmp(al, 8);                           /* cmp al, 0x8 */
            ii(0x100b_3d54, 2);  if(jnz(0x100b_3d7f, 0x29)) goto l_0x100b_3d7f;/* jnz 0x100b3d7f */
            ii(0x100b_3d56, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3d59, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100b_3d5c, 5);  call(0x1008_af28, -0x2_8e39);         /* call 0x1008af28 */
            ii(0x100b_3d61, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100b_3d64, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x100b_3d67, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100b_3d6a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3d6d, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3d70, 5);  call(0x1007_65d0, -0x3_d7a5);         /* call 0x100765d0 */
            ii(0x100b_3d75, 3);  mov(ecx, memd[ss, ebp - 44]);         /* mov ecx, [ebp-0x2c] */
            ii(0x100b_3d78, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_3d7a, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x100b_3d7c, 3);  call_abs(memd[ds, ebx + 44]);         /* call dword [ebx+0x2c] */
        l_0x100b_3d7f:
            ii(0x100b_3d7f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3d82, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3d85, 5);  call(0x1007_6574, -0x3_d816);         /* call 0x10076574 */
            ii(0x100b_3d8a, 5);  call(0x1015_26ac, 0x9_e91d);          /* call 0x101526ac */
            ii(0x100b_3d8f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100b_3d91, 2);  if(jnz(0x100b_3db3, 0x20)) goto l_0x100b_3db3;/* jnz 0x100b3db3 */
            ii(0x100b_3d93, 5);  call(0x1008_a79c, -0x2_95fc);         /* call 0x1008a79c */
            ii(0x100b_3d98, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100b_3d9a, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100b_3d9c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3d9f, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3da2, 5);  call(0x1007_65d0, -0x3_d7d7);         /* call 0x100765d0 */
            ii(0x100b_3da7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_3da9, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100b_3dae, 5);  call(0x100a_53ac, -0xea07);           /* call 0x100a53ac */
        l_0x100b_3db3:
            ii(0x100b_3db3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_3db5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3db8, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_3dbb, 5);  call(0x1007_6630, -0x3_d790);         /* call 0x10076630 */
            ii(0x100b_3dc0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_3dc2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3dc5, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_3dc8, 5);  call(0x1007_6630, -0x3_d79d);         /* call 0x10076630 */
            ii(0x100b_3dcd, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_3dd0, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100b_3dd5, 5);  call(0x100a_5e27, -0xdfb3);           /* call 0x100a5e27 */
            ii(0x100b_3dda, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_3dde, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_3de0, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_3de3, 5);  call(0x1008_8b7c, -0x2_b26c);         /* call 0x10088b7c */
            ii(0x100b_3de8, 2);  jmp(0x100b_3e00, 0x16); goto l_0x100b_3e00;/* jmp 0x100b3e00 */
        l_0x100b_3dea:
            ii(0x100b_3dea, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_3dec, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_3def, 5);  call(0x1008_8b7c, -0x2_b278);         /* call 0x10088b7c */
        l_0x100b_3df4:
            ii(0x100b_3df4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3df7, 5);  call(0x100b_3ed0, 0xd4);              /* call 0x100b3ed0 */
            ii(0x100b_3dfc, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
        l_0x100b_3e00:
            ii(0x100b_3e00, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100b_3e03, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_3e05, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_3e06, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_3e07, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_3e08, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_3e09, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_3e0a, 1);  ret();                                /* ret */
        }
    }
}
