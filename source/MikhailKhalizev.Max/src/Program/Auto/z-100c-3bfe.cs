using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_3bfe-d26a8542")]
        public void Method_100c_3bfe()
        {
            ii(0x100c_3bfe, 5);  push(0x88);                           /* push 0x88 */
            ii(0x100c_3c03, 5);  call(Definitions.sys_check_available_stack_size, 0xa_214a);/* call 0x10165d52 */
            ii(0x100c_3c08, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_3c09, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_3c0a, 1);  push(esi);                            /* push esi */
            ii(0x100c_3c0b, 1);  push(edi);                            /* push edi */
            ii(0x100c_3c0c, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_3c0d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_3c0f, 6);  sub(esp, 0x70);                       /* sub esp, 0x70 */
            ii(0x100c_3c15, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_3c18, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_3c1b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3c1e, 5);  call(Definitions.my__get_unit, -0xbc07);/* call 0x100b801c */
            ii(0x100c_3c23, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100c_3c26, 3);  mov(edx, memd[ss, ebp - 76]);         /* mov edx, [ebp-0x4c] */
            ii(0x100c_3c29, 3);  mov(ebx, memd[ds, edx + 26]);         /* mov ebx, [edx+0x1a] */
            ii(0x100c_3c2c, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_3c2f, 3);  mov(edx, memd[ss, ebp - 76]);         /* mov edx, [ebp-0x4c] */
            ii(0x100c_3c32, 3);  mov(edx, memd[ds, edx + 24]);         /* mov edx, [edx+0x18] */
            ii(0x100c_3c35, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_3c38, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x100c_3c3b, 5);  call(0x1007_6aac, -0x4_d194);         /* call 0x10076aac */
            ii(0x100c_3c40, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3c43, 5);  call(0x100c_b490, 0x7848);            /* call 0x100cb490 */
            ii(0x100c_3c48, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_3c4b, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x100c_3c4e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3c51, 5);  call(0x100b_808c, -0xbbca);           /* call 0x100b808c */
            ii(0x100c_3c56, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x100c_3c59, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x100c_3c5c, 5);  call(0x1007_5e64, -0x4_ddfd);         /* call 0x10075e64 */
            ii(0x100c_3c61, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_3c63, 3);  lea(edx, memd[ss, ebp - 72]);         /* lea edx, [ebp-0x48] */
            ii(0x100c_3c66, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x100c_3c69, 5);  call(0x1007_5e64, -0x4_de0a);         /* call 0x10075e64 */
            ii(0x100c_3c6e, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x100c_3c70, 5);  call(0x100a_5fca, -0x1_dcab);         /* call 0x100a5fca */
            ii(0x100c_3c75, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100c_3c78, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_3c7a, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_3c7d, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100c_3c7f, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100c_3c81, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_3c84, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_3c87, 3);  sub(memd[ss, ebp - 40], eax);         /* sub [ebp-0x28], eax */
            ii(0x100c_3c8a, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100c_3c8d, 5);  call(0x1007_623c, -0x4_da56);         /* call 0x1007623c */
            ii(0x100c_3c92, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_3c94, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100c_3c97, 4);  cmp(ax, memw[ds, edx + 16]);          /* cmp ax, [edx+0x10] */
            ii(0x100c_3c9b, 2);  if(jge(0x100c_3ca6, 9)) goto l_0x100c_3ca6;/* jge 0x100c3ca6 */
            ii(0x100c_3c9d, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_3ca1, 5);  jmp(0x100c_3ea9, 0x203); goto l_0x100c_3ea9;/* jmp 0x100c3ea9 */
        l_0x100c_3ca6:
            ii(0x100c_3ca6, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100c_3ca9, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_3cac, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_3caf, 5);  call(0x100b_8852, -0xb462);           /* call 0x100b8852 */
            ii(0x100c_3cb4, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x100c_3cb7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_3cba, 5);  call(0x100c_b460, 0x77a1);            /* call 0x100cb460 */
            ii(0x100c_3cbf, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100c_3cc2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3cc5, 3);  add(eax, 0x6d);                       /* add eax, 0x6d */
            ii(0x100c_3cc8, 5);  call(0x100c_b24c, 0x757f);            /* call 0x100cb24c */
            ii(0x100c_3ccd, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_3ccf, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3cd2, 5);  call(0x100c_b198, 0x74c1);            /* call 0x100cb198 */
            ii(0x100c_3cd7, 7);  mov(memd[ss, ebp - 52], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x100c_3cde, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_3ce1, 5);  call(Definitions.my_ctor_0x101b_4184, -0x4_d1f6);/* call 0x10076af0 */
            ii(0x100c_3ce6, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_3ce9, 5);  call(Definitions.my_ctor_0x101b_4184, -0x4_d1fe);/* call 0x10076af0 */
            ii(0x100c_3cee, 2);  jmp(0x100c_3cf8, 8); goto l_0x100c_3cf8;/* jmp 0x100c3cf8 */
        l_0x100c_3cf0:
            ii(0x100c_3cf0, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3cf3, 5);  call(0x1007_6bf8, -0x4_d100);         /* call 0x10076bf8 */
        l_0x100c_3cf8:
            ii(0x100c_3cf8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_3cfa, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3cfd, 5);  call(0x1013_ad71, 0x7_706f);          /* call 0x1013ad71 */
            ii(0x100c_3d02, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_3d04, 6);  if(jz(0x100c_3e6e, 0x164)) goto l_0x100c_3e6e;/* jz 0x100c3e6e */
            ii(0x100c_3d0a, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3d0d, 5);  call(0x100c_b0ec, 0x73da);            /* call 0x100cb0ec */
            ii(0x100c_3d12, 5);  call(0x100c_b2f4, 0x75dd);            /* call 0x100cb2f4 */
            ii(0x100c_3d17, 3);  cmp(al, memb[ss, ebp - 20]);          /* cmp al, [ebp-0x14] */
            ii(0x100c_3d1a, 6);  if(jnz(0x100c_3e69, 0x149)) goto l_0x100c_3e69;/* jnz 0x100c3e69 */
            ii(0x100c_3d20, 3);  lea(edx, memd[ss, ebp - 72]);         /* lea edx, [ebp-0x48] */
            ii(0x100c_3d23, 3);  lea(eax, memd[ss, ebp - 80]);         /* lea eax, [ebp-0x50] */
            ii(0x100c_3d26, 5);  call(0x1007_5e64, -0x4_dec7);         /* call 0x10075e64 */
            ii(0x100c_3d2b, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_3d2d, 3);  lea(edx, memd[ss, ebp - 84]);         /* lea edx, [ebp-0x54] */
            ii(0x100c_3d30, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3d33, 5);  call(0x100c_b0ec, 0x73b4);            /* call 0x100cb0ec */
            ii(0x100c_3d38, 5);  call(0x100b_8b42, -0xb1fb);           /* call 0x100b8b42 */
            ii(0x100c_3d3d, 3);  lea(ebx, memd[ss, ebp - 48]);         /* lea ebx, [ebp-0x30] */
            ii(0x100c_3d40, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_3d42, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100c_3d44, 5);  call(0x1008_8b44, -0x3_b205);         /* call 0x10088b44 */
            ii(0x100c_3d49, 3);  lea(edx, memd[ss, ebp - 48]);         /* lea edx, [ebp-0x30] */
            ii(0x100c_3d4c, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x100c_3d4f, 5);  call(0x1007_5e64, -0x4_def0);         /* call 0x10075e64 */
            ii(0x100c_3d54, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_3d56, 3);  lea(edx, memd[ss, ebp - 72]);         /* lea edx, [ebp-0x48] */
            ii(0x100c_3d59, 3);  lea(eax, memd[ss, ebp - 92]);         /* lea eax, [ebp-0x5c] */
            ii(0x100c_3d5c, 5);  call(0x1007_5e64, -0x4_defd);         /* call 0x10075e64 */
            ii(0x100c_3d61, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x100c_3d63, 5);  call(0x100a_5fca, -0x1_dd9e);         /* call 0x100a5fca */
            ii(0x100c_3d68, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100c_3d6b, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_3d6d, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_3d70, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100c_3d72, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100c_3d74, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_3d77, 3);  lea(edx, memd[ss, ebp - 48]);         /* lea edx, [ebp-0x30] */
            ii(0x100c_3d7a, 3);  lea(eax, memd[ss, ebp - 96]);         /* lea eax, [ebp-0x60] */
            ii(0x100c_3d7d, 5);  call(0x1007_5e64, -0x4_df1e);         /* call 0x10075e64 */
            ii(0x100c_3d82, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x100c_3d84, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x100c_3d87, 3);  lea(eax, memd[ss, ebp - 100]);        /* lea eax, [ebp-0x64] */
            ii(0x100c_3d8a, 5);  call(0x1007_5e64, -0x4_df2b);         /* call 0x10075e64 */
            ii(0x100c_3d8f, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_3d91, 3);  lea(edx, memd[ss, ebp - 104]);        /* lea edx, [ebp-0x68] */
            ii(0x100c_3d94, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3d97, 5);  call(0x100c_b0ec, 0x7350);            /* call 0x100cb0ec */
            ii(0x100c_3d9c, 5);  call(0x100b_89ad, -0xb3f4);           /* call 0x100b89ad */
            ii(0x100c_3da1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_3da3, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_3da6, 5);  call(0x1008_8b44, -0x3_b267);         /* call 0x10088b44 */
            ii(0x100c_3dab, 3);  lea(edx, memd[ss, ebp - 44]);         /* lea edx, [ebp-0x2c] */
            ii(0x100c_3dae, 3);  lea(eax, memd[ss, ebp - 108]);        /* lea eax, [ebp-0x6c] */
            ii(0x100c_3db1, 5);  call(0x1007_5e64, -0x4_df52);         /* call 0x10075e64 */
            ii(0x100c_3db6, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_3db8, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x100c_3dbb, 3);  lea(eax, memd[ss, ebp - 112]);        /* lea eax, [ebp-0x70] */
            ii(0x100c_3dbe, 5);  call(0x1007_5e64, -0x4_df5f);         /* call 0x10075e64 */
            ii(0x100c_3dc3, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x100c_3dc5, 5);  call(0x100a_5fca, -0x1_de00);         /* call 0x100a5fca */
            ii(0x100c_3dca, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100c_3dcd, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_3dcf, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_3dd2, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100c_3dd4, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100c_3dd6, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_3dd9, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_3ddc, 3);  sub(memd[ss, ebp - 28], eax);         /* sub [ebp-0x1c], eax */
            ii(0x100c_3ddf, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_3de3, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_3de5, 2);  if(jge(0x100c_3dee, 7)) goto l_0x100c_3dee;/* jge 0x100c3dee */
            ii(0x100c_3de7, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100c_3dee:
            ii(0x100c_3dee, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100c_3df2, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_3df7, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_3df9, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_3dfc, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100c_3dfe, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100c_3e02, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_3e04, 2);  if(jge(0x100c_3e1e, 0x18)) goto l_0x100c_3e1e;/* jge 0x100c3e1e */
            ii(0x100c_3e06, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100c_3e0a, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_3e0f, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_3e11, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_3e14, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100c_3e16, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100c_3e1a, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_3e1c, 2);  if(jl(0x100c_3e20, 2)) goto l_0x100c_3e20;/* jl 0x100c3e20 */
        l_0x100c_3e1e:
            ii(0x100c_3e1e, 2);  jmp(0x100c_3e3b, 0x1b); goto l_0x100c_3e3b;/* jmp 0x100c3e3b */
        l_0x100c_3e20:
            ii(0x100c_3e20, 4);  cmp(memb[ss, ebp - 12], 0);           /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100c_3e24, 2);  if(jnz(0x100c_3e39, 0x13)) goto l_0x100c_3e39;/* jnz 0x100c3e39 */
            ii(0x100c_3e26, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3e29, 5);  call(0x100c_b0ec, 0x72be);            /* call 0x100cb0ec */
            ii(0x100c_3e2e, 5);  call(0x100c_b2c0, 0x748d);            /* call 0x100cb2c0 */
            ii(0x100c_3e33, 4);  cmp(ax, 0xffff);                      /* cmp ax, 0xffff */
            ii(0x100c_3e37, 2);  if(jnz(0x100c_3e3b, 2)) goto l_0x100c_3e3b;/* jnz 0x100c3e3b */
        l_0x100c_3e39:
            ii(0x100c_3e39, 2);  jmp(0x100c_3e3d, 2); goto l_0x100c_3e3d;/* jmp 0x100c3e3d */
        l_0x100c_3e3b:
            ii(0x100c_3e3b, 2);  jmp(0x100c_3e69, 0x2c); goto l_0x100c_3e69;/* jmp 0x100c3e69 */
        l_0x100c_3e3d:
            ii(0x100c_3e3d, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100c_3e41, 2);  if(jz(0x100c_3e55, 0x12)) goto l_0x100c_3e55;/* jz 0x100c3e55 */
            ii(0x100c_3e43, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100c_3e47, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100c_3e4b, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100c_3e4d, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_3e51, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_3e53, 2);  if(jge(0x100c_3e69, 0x14)) goto l_0x100c_3e69;/* jge 0x100c3e69 */
        l_0x100c_3e55:
            ii(0x100c_3e55, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3e58, 5);  call(0x100c_b120, 0x72c3);            /* call 0x100cb120 */
            ii(0x100c_3e5d, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100c_3e60, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_3e63, 3);  add(eax, memd[ss, ebp - 24]);         /* add eax, [ebp-0x18] */
            ii(0x100c_3e66, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x100c_3e69:
            ii(0x100c_3e69, 5);  jmp(0x100c_3cf0, -0x17e); goto l_0x100c_3cf0;/* jmp 0x100c3cf0 */
        l_0x100c_3e6e:
            ii(0x100c_3e6e, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100c_3e72, 2);  if(jnz(0x100c_3e84, 0x10)) goto l_0x100c_3e84;/* jnz 0x100c3e84 */
            ii(0x100c_3e74, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_3e78, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_3e7a, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3e7d, 5);  call(0x100c_a554, 0x66d2);            /* call 0x100ca554 */
            ii(0x100c_3e82, 2);  jmp(0x100c_3ea9, 0x25); goto l_0x100c_3ea9;/* jmp 0x100c3ea9 */
        l_0x100c_3e84:
            ii(0x100c_3e84, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_3e87, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100c_3e8a, 5);  call(0x100b_8b93, -0xb2fc);           /* call 0x100b8b93 */
            ii(0x100c_3e8f, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100c_3e93, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_3e95, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_3e98, 5);  call(0x100c_a554, 0x66b7);            /* call 0x100ca554 */
            ii(0x100c_3e9d, 2);  jmp(0x100c_3ea9, 0xa); goto l_0x100c_3ea9;/* jmp 0x100c3ea9 */
        //  ii(0x100c_3e9f, 10);  Недостижимый код.
        l_0x100c_3ea9:
            ii(0x100c_3ea9, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100c_3eac, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_3eae, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_3eaf, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_3eb0, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_3eb1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_3eb2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_3eb3, 1);  ret();                                /* ret */
        }
    }
}
