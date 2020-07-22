using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2e9c-ba779e01")]
        public void Method_1010_2e9c()
        {
            ii(0x1010_2e9c, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1010_2ea1, 5);  call(Definitions.sys_check_available_stack_size, 0x6_2eac);/* call 0x10165d52 */
            ii(0x1010_2ea6, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_2ea7, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_2ea8, 1);  push(esi);                            /* push esi */
            ii(0x1010_2ea9, 1);  push(edi);                            /* push edi */
            ii(0x1010_2eaa, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_2eab, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_2ead, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1010_2eb3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_2eb6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_2eb9, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1010_2ebd, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2ec0, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x8_c7d5);/* call 0x100766f0 */
            ii(0x1010_2ec5, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_2ec8, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1010_2ecc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2ecf, 5);  call(0x1013_a6f4, 0x3_7820);          /* call 0x1013a6f4 */
        l_0x1010_2ed4:
            ii(0x1010_2ed4, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1010_2ed6, 5);  mov(ebx, StringDefinitions.Unit7);    /* mov ebx, 0x101a314c */
            ii(0x1010_2edb, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1010_2ede, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2ee1, 5);  call(0x1014_61ae, 0x4_32c8);          /* call 0x101461ae */
            ii(0x1010_2ee6, 5);  call(0x100e_0d98, -0x2_2153);         /* call 0x100e0d98 */
            ii(0x1010_2eeb, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1010_2eee, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_2ef0, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1010_2ef2, 5);  call(0x1007_6630, -0x8_c8c7);         /* call 0x10076630 */
            ii(0x1010_2ef7, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1010_2ef9, 5);  call(0x1013_ad71, 0x3_7e73);          /* call 0x1013ad71 */
            ii(0x1010_2efe, 2);  test(al, al);                         /* test al, al */
            ii(0x1010_2f00, 2);  if(jz(0x1010_2f0b, 9)) goto l_0x1010_2f0b;/* jz 0x10102f0b */
            ii(0x1010_2f02, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1010_2f09, 2);  jmp(0x1010_2f12, 7); goto l_0x1010_2f12;/* jmp 0x10102f12 */
        l_0x1010_2f0b:
            ii(0x1010_2f0b, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x1010_2f12:
            ii(0x1010_2f12, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_2f15, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_2f18, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_2f1a, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_2f1d, 5);  call(0x100e_0158, -0x2_2dca);         /* call 0x100e0158 */
            ii(0x1010_2f22, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1010_2f26, 6);  if(jz(0x1010_2fe7, 0xbb)) goto l_0x1010_2fe7;/* jz 0x10102fe7 */
            ii(0x1010_2f2c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2f2f, 5);  call(0x1007_65d0, -0x8_c964);         /* call 0x100765d0 */
            ii(0x1010_2f34, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_2f36, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2f39, 5);  call(0x1008_ab1c, -0x7_8422);         /* call 0x1008ab1c */
            ii(0x1010_2f3e, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2f41, 5);  call(0x1007_6574, -0x8_c9d2);         /* call 0x10076574 */
            ii(0x1010_2f46, 4);  test(memb[ds, eax + 19], 0x20);       /* test byte [eax+0x13], 0x20 */
            ii(0x1010_2f4a, 2);  if(jz(0x1010_2f62, 0x16)) goto l_0x1010_2f62;/* jz 0x10102f62 */
            ii(0x1010_2f4c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2f4f, 5);  call(0x1007_6574, -0x8_c9e0);         /* call 0x10076574 */
            ii(0x1010_2f54, 6);  mov(edx, memd[ds, 0x101c_70a0]);      /* mov edx, [0x101c70a0] */
            ii(0x1010_2f5a, 3);  mov(memd[ds, eax + 34], edx);         /* mov [eax+0x22], edx */
            ii(0x1010_2f5d, 5);  jmp(0x1010_2fd6, 0x74); goto l_0x1010_2fd6;/* jmp 0x10102fd6 */
        l_0x1010_2f62:
            ii(0x1010_2f62, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2f65, 5);  call(0x1007_6574, -0x8_c9f6);         /* call 0x10076574 */
            ii(0x1010_2f6a, 4);  test(memb[ds, eax + 19], 0x10);       /* test byte [eax+0x13], 0x10 */
            ii(0x1010_2f6e, 2);  if(jz(0x1010_2f83, 0x13)) goto l_0x1010_2f83;/* jz 0x10102f83 */
            ii(0x1010_2f70, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2f73, 5);  call(0x1007_6574, -0x8_ca04);         /* call 0x10076574 */
            ii(0x1010_2f78, 6);  mov(edx, memd[ds, 0x101c_70a4]);      /* mov edx, [0x101c70a4] */
            ii(0x1010_2f7e, 3);  mov(memd[ds, eax + 34], edx);         /* mov [eax+0x22], edx */
            ii(0x1010_2f81, 2);  jmp(0x1010_2fd6, 0x53); goto l_0x1010_2fd6;/* jmp 0x10102fd6 */
        l_0x1010_2f83:
            ii(0x1010_2f83, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2f86, 5);  call(0x1007_6574, -0x8_ca17);         /* call 0x10076574 */
            ii(0x1010_2f8b, 4);  test(memb[ds, eax + 19], 8);          /* test byte [eax+0x13], 0x8 */
            ii(0x1010_2f8f, 2);  if(jz(0x1010_2fa4, 0x13)) goto l_0x1010_2fa4;/* jz 0x10102fa4 */
            ii(0x1010_2f91, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2f94, 5);  call(0x1007_6574, -0x8_ca25);         /* call 0x10076574 */
            ii(0x1010_2f99, 6);  mov(edx, memd[ds, 0x101c_70a8]);      /* mov edx, [0x101c70a8] */
            ii(0x1010_2f9f, 3);  mov(memd[ds, eax + 34], edx);         /* mov [eax+0x22], edx */
            ii(0x1010_2fa2, 2);  jmp(0x1010_2fd6, 0x32); goto l_0x1010_2fd6;/* jmp 0x10102fd6 */
        l_0x1010_2fa4:
            ii(0x1010_2fa4, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2fa7, 5);  call(0x1007_6574, -0x8_ca38);         /* call 0x10076574 */
            ii(0x1010_2fac, 4);  test(memb[ds, eax + 19], 4);          /* test byte [eax+0x13], 0x4 */
            ii(0x1010_2fb0, 2);  if(jz(0x1010_2fc5, 0x13)) goto l_0x1010_2fc5;/* jz 0x10102fc5 */
            ii(0x1010_2fb2, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2fb5, 5);  call(0x1007_6574, -0x8_ca46);         /* call 0x10076574 */
            ii(0x1010_2fba, 6);  mov(edx, memd[ds, 0x101c_70ac]);      /* mov edx, [0x101c70ac] */
            ii(0x1010_2fc0, 3);  mov(memd[ds, eax + 34], edx);         /* mov [eax+0x22], edx */
            ii(0x1010_2fc3, 2);  jmp(0x1010_2fd6, 0x11); goto l_0x1010_2fd6;/* jmp 0x10102fd6 */
        l_0x1010_2fc5:
            ii(0x1010_2fc5, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2fc8, 5);  call(0x1007_6574, -0x8_ca59);         /* call 0x10076574 */
            ii(0x1010_2fcd, 6);  mov(edx, memd[ds, 0x101c_70b0]);      /* mov edx, [0x101c70b0] */
            ii(0x1010_2fd3, 3);  mov(memd[ds, eax + 34], edx);         /* mov [eax+0x22], edx */
        l_0x1010_2fd6:
            ii(0x1010_2fd6, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2fd9, 5);  call(0x1007_6574, -0x8_ca6a);         /* call 0x10076574 */
            ii(0x1010_2fde, 4);  mov(memb[ds, eax + 44], 0);           /* mov byte [eax+0x2c], 0x0 */
            ii(0x1010_2fe2, 5);  jmp(0x1010_2ed4, -0x113); goto l_0x1010_2ed4;/* jmp 0x10102ed4 */
        l_0x1010_2fe7:
            ii(0x1010_2fe7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_2fe9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_2fec, 5);  call(0x1007_5f2c, -0x8_d0c5);         /* call 0x10075f2c */
            ii(0x1010_2ff1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_2ff3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_2ff4, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_2ff5, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_2ff6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_2ff7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_2ff8, 1);  ret();                                /* ret */
        }
    }
}
