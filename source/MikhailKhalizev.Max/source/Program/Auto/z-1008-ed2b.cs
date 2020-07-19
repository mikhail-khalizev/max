using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ed2b-d035792c")]
        public void Method_1008_ed2b()
        {
            ii(0x1008_ed2b, 5);  push(0x78);                           /* push 0x78 */
            ii(0x1008_ed30, 5);  call(Definitions.sys_check_available_stack_size, 0xd_701d);/* call 0x10165d52 */
            ii(0x1008_ed35, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_ed36, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_ed37, 1);  push(edx);                            /* push edx */
            ii(0x1008_ed38, 1);  push(esi);                            /* push esi */
            ii(0x1008_ed39, 1);  push(edi);                            /* push edi */
            ii(0x1008_ed3a, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_ed3b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_ed3d, 6);  sub(esp, 0x54);                       /* sub esp, 0x54 */
            ii(0x1008_ed43, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_ed46, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ed49, 5);  cmp(memw[ds, eax + 19], 0x21);        /* cmp word [eax+0x13], 0x21 */
            ii(0x1008_ed4e, 2);  if(jz(0x1008_ed5a, 0xa)) goto l_0x1008_ed5a;/* jz 0x1008ed5a */
            ii(0x1008_ed50, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ed53, 5);  cmp(memw[ds, eax + 19], 0x27);        /* cmp word [eax+0x13], 0x27 */
            ii(0x1008_ed58, 2);  if(jnz(0x1008_ed5c, 2)) goto l_0x1008_ed5c;/* jnz 0x1008ed5c */
        l_0x1008_ed5a:
            ii(0x1008_ed5a, 2);  jmp(0x1008_ed66, 0xa); goto l_0x1008_ed66;/* jmp 0x1008ed66 */
        l_0x1008_ed5c:
            ii(0x1008_ed5c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ed5f, 5);  cmp(memw[ds, eax + 19], 0xc);         /* cmp word [eax+0x13], 0xc */
            ii(0x1008_ed64, 2);  if(jnz(0x1008_ed68, 2)) goto l_0x1008_ed68;/* jnz 0x1008ed68 */
        l_0x1008_ed66:
            ii(0x1008_ed66, 2);  jmp(0x1008_ed72, 0xa); goto l_0x1008_ed72;/* jmp 0x1008ed72 */
        l_0x1008_ed68:
            ii(0x1008_ed68, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ed6b, 5);  cmp(memw[ds, eax + 19], 0x17);        /* cmp word [eax+0x13], 0x17 */
            ii(0x1008_ed70, 2);  if(jnz(0x1008_ed74, 2)) goto l_0x1008_ed74;/* jnz 0x1008ed74 */
        l_0x1008_ed72:
            ii(0x1008_ed72, 2);  jmp(0x1008_ed7e, 0xa); goto l_0x1008_ed7e;/* jmp 0x1008ed7e */
        l_0x1008_ed74:
            ii(0x1008_ed74, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ed77, 5);  cmp(memw[ds, eax + 19], 0xb);         /* cmp word [eax+0x13], 0xb */
            ii(0x1008_ed7c, 2);  if(jnz(0x1008_ed83, 5)) goto l_0x1008_ed83;/* jnz 0x1008ed83 */
        l_0x1008_ed7e:
            ii(0x1008_ed7e, 5);  jmp(0x1008_ef93, 0x210); goto l_0x1008_ef93;/* jmp 0x1008ef93 */
        l_0x1008_ed83:
            ii(0x1008_ed83, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ed86, 3);  mov(eax, memd[ds, eax + 17]);         /* mov eax, [eax+0x11] */
            ii(0x1008_ed89, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_ed8c, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1008_ed8f, 7);  test(memb[ds, eax + 0x101c_81c0], 0x10);/* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1008_ed96, 6);  if(jz(0x1008_ef93, 0x1f7)) goto l_0x1008_ef93;/* jz 0x1008ef93 */
            ii(0x1008_ed9c, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1008_ed9f, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_82b4);/* call 0x10076af0 */
            ii(0x1008_eda4, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_eda8, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_edab, 5);  call(0x1008_bbed, -0x31c3);           /* call 0x1008bbed */
            ii(0x1008_edb0, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_edb3, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x1008_edb7, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_edbb, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_edbe, 5);  call(0x1009_c350, 0xd58d);            /* call 0x1009c350 */
            ii(0x1008_edc3, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1008_edc6, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x1008_edca, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_edcd, 5);  call(0x1008_a6f8, -0x46da);           /* call 0x1008a6f8 */
            ii(0x1008_edd2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_edd4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_edd7, 5);  call(0x1008_e7e0, -0x5fc);            /* call 0x1008e7e0 */
            ii(0x1008_eddc, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_eddf, 5);  call(0x1008_a6f8, -0x46ec);           /* call 0x1008a6f8 */
            ii(0x1008_ede4, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_ede6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ede9, 5);  call(0x1008_eb17, -0x2d7);            /* call 0x1008eb17 */
            ii(0x1008_edee, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_edf1, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_edf4, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_edf7, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_edfa, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1008_edfd, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_ee00, 3);  call_abs(memd[ds, ebx + 28]);         /* call dword [ebx+0x1c] */
            ii(0x1008_ee03, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_ee06, 1);  dec(eax);                             /* dec eax */
            ii(0x1008_ee07, 4);  mov(memw[ss, ebp - 40], ax);          /* mov [ebp-0x28], ax */
            ii(0x1008_ee0b, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1008_ee0e, 4);  mov(memw[ss, ebp - 38], ax);          /* mov [ebp-0x26], ax */
            ii(0x1008_ee12, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_ee15, 3);  sub(eax, memd[ss, ebp - 64]);         /* sub eax, [ebp-0x40] */
            ii(0x1008_ee18, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_ee1b, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_ee22, 2);  jmp(0x1008_ee28, 4); goto l_0x1008_ee28;/* jmp 0x1008ee28 */
        l_0x1008_ee24:
            ii(0x1008_ee24, 4);  add(memd[ss, ebp - 16], 2);           /* add dword [ebp-0x10], 0x2 */
        l_0x1008_ee28:
            ii(0x1008_ee28, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_ee2c, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1008_ee2f, 6);  if(jge(0x1008_ef7f, 0x14a)) goto l_0x1008_ef7f;/* jge 0x1008ef7f */
            ii(0x1008_ee35, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_ee3c, 2);  jmp(0x1008_ee44, 6); goto l_0x1008_ee44;/* jmp 0x1008ee44 */
        l_0x1008_ee3e:
            ii(0x1008_ee3e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_ee41, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x1008_ee44:
            ii(0x1008_ee44, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_ee47, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1008_ee4b, 6);  if(jge(0x1008_ef64, 0x113)) goto l_0x1008_ef64;/* jge 0x1008ef64 */
            ii(0x1008_ee51, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_ee55, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_ee58, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1008_ee5d, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_ee5f, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1008_ee62, 5);  call(0x1008_b1a4, -0x3cc3);           /* call 0x1008b1a4 */
            ii(0x1008_ee67, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1008_ee6b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_ee6d, 2);  if(jl(0x1008_ee7b, 0xc)) goto l_0x1008_ee7b;/* jl 0x1008ee7b */
            ii(0x1008_ee6f, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1008_ee72, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1008_ee79, 2);  if(jl(0x1008_ee7d, 2)) goto l_0x1008_ee7d;/* jl 0x1008ee7d */
        l_0x1008_ee7b:
            ii(0x1008_ee7b, 2);  jmp(0x1008_ee85, 8); goto l_0x1008_ee85;/* jmp 0x1008ee85 */
        l_0x1008_ee7d:
            ii(0x1008_ee7d, 4);  movsx(eax, memw[ss, ebp - 38]);       /* movsx eax, word [ebp-0x26] */
            ii(0x1008_ee81, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_ee83, 2);  if(jge(0x1008_ee87, 2)) goto l_0x1008_ee87;/* jge 0x1008ee87 */
        l_0x1008_ee85:
            ii(0x1008_ee85, 2);  jmp(0x1008_ee93, 0xc); goto l_0x1008_ee93;/* jmp 0x1008ee93 */
        l_0x1008_ee87:
            ii(0x1008_ee87, 3);  mov(eax, memd[ss, ebp - 38]);         /* mov eax, [ebp-0x26] */
            ii(0x1008_ee8a, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1008_ee91, 2);  if(jl(0x1008_ee98, 5)) goto l_0x1008_ee98;/* jl 0x1008ee98 */
        l_0x1008_ee93:
            ii(0x1008_ee93, 5);  jmp(0x1008_ef5f, 0xc7); goto l_0x1008_ef5f;/* jmp 0x1008ef5f */
        l_0x1008_ee98:
            ii(0x1008_ee98, 4);  movsx(ebx, memw[ss, ebp - 38]);       /* movsx ebx, word [ebp-0x26] */
            ii(0x1008_ee9c, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1008_eea0, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_eea3, 5);  call(0x1008_a728, -0x4780);           /* call 0x1008a728 */
            ii(0x1008_eea8, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1008_eeaa, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1008_eeac, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_eeb1, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1008_eeb4, 6);  if(jnz(0x1008_ef5f, 0xa5)) goto l_0x1008_ef5f;/* jnz 0x1008ef5f */
            ii(0x1008_eeba, 5);  mov(eax, 0x35);                       /* mov eax, 0x35 */
            ii(0x1008_eebf, 5);  call(Definitions.sys_new, 0xd_6f3c);  /* call 0x10165e00 */
            ii(0x1008_eec4, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1008_eec7, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_eeca, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1008_eecd, 4);  cmp(memd[ss, ebp - 72], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1008_eed1, 2);  if(jz(0x1008_ef0b, 0x38)) goto l_0x1008_ef0b;/* jz 0x1008ef0b */
            ii(0x1008_eed3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_eed6, 3);  add(eax, 0x1d);                       /* add eax, 0x1d */
            ii(0x1008_eed9, 5);  call(0x1008_af84, -0x3f5a);           /* call 0x1008af84 */
            ii(0x1008_eede, 1);  push(eax);                            /* push eax */
            ii(0x1008_eedf, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1008_eee2, 3);  lea(eax, memd[ss, ebp - 76]);         /* lea eax, [ebp-0x4c] */
            ii(0x1008_eee5, 5);  call(0x1007_5e64, -0x1_9086);         /* call 0x10075e64 */
            ii(0x1008_eeea, 1);  push(eax);                            /* push eax */
            ii(0x1008_eeeb, 5);  mov(ecx, 0x27);                       /* mov ecx, 0x27 */
            ii(0x1008_eef0, 5);  mov(ebx, 0x1c80);                     /* mov ebx, 0x1c80 */
            ii(0x1008_eef5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_eef8, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_eefb, 5);  call(0x1008_c999, -0x2567);           /* call 0x1008c999 */
            ii(0x1008_ef00, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1008_ef03, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1008_ef06, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x1008_ef09, 2);  jmp(0x1008_ef11, 6); goto l_0x1008_ef11;/* jmp 0x1008ef11 */
        l_0x1008_ef0b:
            ii(0x1008_ef0b, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1008_ef0e, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
        l_0x1008_ef11:
            ii(0x1008_ef11, 3);  mov(edx, memd[ss, ebp - 84]);         /* mov edx, [ebp-0x54] */
            ii(0x1008_ef14, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_ef17, 5);  call(0x1009_c2d4, 0xd3b8);            /* call 0x1009c2d4 */
            ii(0x1008_ef1c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_ef1e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ef21, 3);  add(eax, 0x1d);                       /* add eax, 0x1d */
            ii(0x1008_ef24, 5);  call(0x1013_ad71, 0xa_be48);          /* call 0x1013ad71 */
            ii(0x1008_ef29, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_ef2b, 2);  if(jz(0x1008_ef49, 0x1c)) goto l_0x1008_ef49;/* jz 0x1008ef49 */
            ii(0x1008_ef2d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_ef30, 5);  call(0x1009_c2a4, 0xd36f);            /* call 0x1009c2a4 */
            ii(0x1008_ef35, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_ef37, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_ef3a, 3);  add(eax, 0x1d);                       /* add eax, 0x1d */
            ii(0x1008_ef3d, 5);  call(0x1008_afb4, -0x3f8e);           /* call 0x1008afb4 */
            ii(0x1008_ef42, 5);  call(0x1009_350b, 0x45c4);            /* call 0x1009350b */
            ii(0x1008_ef47, 2);  jmp(0x1008_ef5f, 0x16); goto l_0x1008_ef5f;/* jmp 0x1008ef5f */
        l_0x1008_ef49:
            ii(0x1008_ef49, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_ef4c, 5);  call(0x1009_c274, 0xd323);            /* call 0x1009c274 */
            ii(0x1008_ef51, 5);  mov(ebx, 0x101c_3180);                /* mov ebx, 0x101c3180 */
            ii(0x1008_ef56, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_ef58, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_ef5a, 5);  call(0x100a_4d50, 0x1_5df1);          /* call 0x100a4d50 */
        l_0x1008_ef5f:
            ii(0x1008_ef5f, 5);  jmp(0x1008_ee3e, -0x126); goto l_0x1008_ee3e;/* jmp 0x1008ee3e */
        l_0x1008_ef64:
            ii(0x1008_ef64, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_ef68, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_ef6b, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1008_ef70, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_ef72, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1008_ef75, 5);  call(0x1008_b1a4, -0x3dd6);           /* call 0x1008b1a4 */
            ii(0x1008_ef7a, 5);  jmp(0x1008_ee24, -0x15b); goto l_0x1008_ee24;/* jmp 0x1008ee24 */
        l_0x1008_ef7f:
            ii(0x1008_ef7f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_ef81, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_ef84, 5);  call(0x1009_c0a4, 0xd11b);            /* call 0x1009c0a4 */
            ii(0x1008_ef89, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_ef8b, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_ef8e, 5);  call(0x1008_bc9f, -0x32f4);           /* call 0x1008bc9f */
        l_0x1008_ef93:
            ii(0x1008_ef93, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_ef95, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_ef96, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_ef97, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_ef98, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_ef99, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_ef9a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_ef9b, 1);  ret();                                /* ret */
        }
    }
}
