using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_2dc1-62971109")]
        public void Method_100e_2dc1()
        {
            ii(0x100e_2dc1, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_2dc6, 5);  call(Definitions.sys_check_available_stack_size, 0x8_2f87);/* call 0x10165d52 */
            ii(0x100e_2dcb, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_2dcc, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_2dcd, 1);  push(edx);                            /* push edx */
            ii(0x100e_2dce, 1);  push(esi);                            /* push esi */
            ii(0x100e_2dcf, 1);  push(edi);                            /* push edi */
            ii(0x100e_2dd0, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_2dd1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_2dd3, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_2dd9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x100e_2ddc:
            ii(0x100e_2ddc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2ddf, 4);  cmp(memb[ds, eax + 23], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x100e_2de3, 6);  if(jnz(0x100e_2efb, 0x112)) goto l_0x100e_2efb;/* jnz 0x100e2efb */
            ii(0x100e_2de9, 5);  call(/* sys */ 0x1016_b208, 0x8_841a);/* call 0x1016b208 */
            ii(0x100e_2dee, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_2df1, 7);  cmp(memd[ss, ebp - 8], 0x119);        /* cmp dword [ebp-0x8], 0x119 */
            ii(0x100e_2df8, 2);  if(jnz(0x100e_2dff, 5)) goto l_0x100e_2dff;/* jnz 0x100e2dff */
            ii(0x100e_2dfa, 5);  call(0x1011_6ba6, 0x3_3da7);          /* call 0x10116ba6 */
        l_0x100e_2dff:
            ii(0x100e_2dff, 4);  cmp(memd[ss, ebp - 8], 0x3f);         /* cmp dword [ebp-0x8], 0x3f */
            ii(0x100e_2e03, 6);  if(jnz(0x100e_2ec5, 0xbc)) goto l_0x100e_2ec5;/* jnz 0x100e2ec5 */
            ii(0x100e_2e09, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2e0c, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x100e_2e0f, 5);  call(0x1007_6574, -0x6_c8a0);         /* call 0x10076574 */
            ii(0x100e_2e14, 5);  cmp(memw[ds, eax + 8], 0xa);          /* cmp word [eax+0x8], 0xa */
            ii(0x100e_2e19, 2);  if(jnz(0x100e_2e35, 0x1a)) goto l_0x100e_2e35;/* jnz 0x100e2e35 */
            ii(0x100e_2e1b, 5);  call(0x100d_4e6c, -0xdfb4);           /* call 0x100d4e6c */
            ii(0x100e_2e20, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_2e22, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100e_2e24, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_2e26, 5);  mov(eax, 0xc);                        /* mov eax, 0xc */
            ii(0x100e_2e2b, 5);  call(0x1010_5b00, 0x2_2cd0);          /* call 0x10105b00 */
            ii(0x100e_2e30, 5);  jmp(0x100e_2ec5, 0x90); goto l_0x100e_2ec5;/* jmp 0x100e2ec5 */
        l_0x100e_2e35:
            ii(0x100e_2e35, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2e38, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x100e_2e3b, 5);  call(0x1007_6574, -0x6_c8cc);         /* call 0x10076574 */
            ii(0x100e_2e40, 5);  cmp(memw[ds, eax + 8], 0xb);          /* cmp word [eax+0x8], 0xb */
            ii(0x100e_2e45, 2);  if(jnz(0x100e_2e5e, 0x17)) goto l_0x100e_2e5e;/* jnz 0x100e2e5e */
            ii(0x100e_2e47, 5);  call(0x100d_4e6c, -0xdfe0);           /* call 0x100d4e6c */
            ii(0x100e_2e4c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_2e4e, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100e_2e50, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_2e52, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x100e_2e57, 5);  call(0x1010_5b00, 0x2_2ca4);          /* call 0x10105b00 */
            ii(0x100e_2e5c, 2);  jmp(0x100e_2ec5, 0x67); goto l_0x100e_2ec5;/* jmp 0x100e2ec5 */
        l_0x100e_2e5e:
            ii(0x100e_2e5e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2e61, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x100e_2e64, 5);  call(0x1007_6574, -0x6_c8f5);         /* call 0x10076574 */
            ii(0x100e_2e69, 5);  cmp(memw[ds, eax + 8], 9);            /* cmp word [eax+0x8], 0x9 */
            ii(0x100e_2e6e, 2);  if(jnz(0x100e_2e87, 0x17)) goto l_0x100e_2e87;/* jnz 0x100e2e87 */
            ii(0x100e_2e70, 5);  call(0x100d_4e6c, -0xe009);           /* call 0x100d4e6c */
            ii(0x100e_2e75, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_2e77, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100e_2e79, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_2e7b, 5);  mov(eax, 0xb);                        /* mov eax, 0xb */
            ii(0x100e_2e80, 5);  call(0x1010_5b00, 0x2_2c7b);          /* call 0x10105b00 */
            ii(0x100e_2e85, 2);  jmp(0x100e_2ec5, 0x3e); goto l_0x100e_2ec5;/* jmp 0x100e2ec5 */
        l_0x100e_2e87:
            ii(0x100e_2e87, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2e8a, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x100e_2e8d, 5);  call(0x1007_6574, -0x6_c91e);         /* call 0x10076574 */
            ii(0x100e_2e92, 5);  cmp(memw[ds, eax + 8], 3);            /* cmp word [eax+0x8], 0x3 */
            ii(0x100e_2e97, 2);  if(jnz(0x100e_2eb0, 0x17)) goto l_0x100e_2eb0;/* jnz 0x100e2eb0 */
            ii(0x100e_2e99, 5);  call(0x100d_4e6c, -0xe032);           /* call 0x100d4e6c */
            ii(0x100e_2e9e, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_2ea0, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100e_2ea2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_2ea4, 5);  mov(eax, 0x20);                       /* mov eax, 0x20 */
            ii(0x100e_2ea9, 5);  call(0x1010_5b00, 0x2_2c52);          /* call 0x10105b00 */
            ii(0x100e_2eae, 2);  jmp(0x100e_2ec5, 0x15); goto l_0x100e_2ec5;/* jmp 0x100e2ec5 */
        l_0x100e_2eb0:
            ii(0x100e_2eb0, 5);  call(0x100d_4e6c, -0xe049);           /* call 0x100d4e6c */
            ii(0x100e_2eb5, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_2eb7, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100e_2eb9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_2ebb, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x100e_2ec0, 5);  call(0x1010_5b00, 0x2_2c3b);          /* call 0x10105b00 */
        l_0x100e_2ec5:
            ii(0x100e_2ec5, 5);  call(0x100d_5094, -0xde36);           /* call 0x100d5094 */
            ii(0x100e_2eca, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_2ecc, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100e_2ece, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_2ed0, 5);  call(0x1010_0e32, 0x1_df5d);          /* call 0x10100e32 */
            ii(0x100e_2ed5, 7);  cmp(memb[ds, 0x101c_37d2], 0);        /* cmp byte [0x101c37d2], 0x0 */
            ii(0x100e_2edc, 2);  if(jnz(0x100e_2ee4, 6)) goto l_0x100e_2ee4;/* jnz 0x100e2ee4 */
            ii(0x100e_2ede, 4);  cmp(memd[ss, ebp - 8], 0x1b);         /* cmp dword [ebp-0x8], 0x1b */
            ii(0x100e_2ee2, 2);  if(jnz(0x100e_2ee6, 2)) goto l_0x100e_2ee6;/* jnz 0x100e2ee6 */
        l_0x100e_2ee4:
            ii(0x100e_2ee4, 2);  jmp(0x100e_2eec, 6); goto l_0x100e_2eec;/* jmp 0x100e2eec */
        l_0x100e_2ee6:
            ii(0x100e_2ee6, 4);  cmp(memd[ss, ebp - 8], 0xd);          /* cmp dword [ebp-0x8], 0xd */
            ii(0x100e_2eea, 2);  if(jnz(0x100e_2ef6, 0xa)) goto l_0x100e_2ef6;/* jnz 0x100e2ef6 */
        l_0x100e_2eec:
            ii(0x100e_2eec, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_2eef, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_2ef1, 5);  call(0x100e_3938, 0xa42);             /* call 0x100e3938 */
        l_0x100e_2ef6:
            ii(0x100e_2ef6, 5);  jmp(0x100e_2ddc, -0x11f); goto l_0x100e_2ddc;/* jmp 0x100e2ddc */
        l_0x100e_2efb:
            ii(0x100e_2efb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_2efd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_2efe, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_2eff, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_2f00, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_2f01, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_2f02, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_2f03, 1);  ret();                                /* ret */
        }
    }
}
