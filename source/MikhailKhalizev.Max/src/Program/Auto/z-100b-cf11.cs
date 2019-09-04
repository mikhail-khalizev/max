using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_cf11-f8d1024f")]
        public void Method_100b_cf11()
        {
            ii(0x100b_cf11, 5);  push(0x8c);                           /* push 0x8c */
            ii(0x100b_cf16, 5);  call(Definitions.sys_check_available_stack_size, 0xa_8e37);/* call 0x10165d52 */
            ii(0x100b_cf1b, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_cf1c, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_cf1d, 1);  push(edx);                            /* push edx */
            ii(0x100b_cf1e, 1);  push(esi);                            /* push esi */
            ii(0x100b_cf1f, 1);  push(edi);                            /* push edi */
            ii(0x100b_cf20, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_cf21, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_cf23, 6);  sub(esp, 0x70);                       /* sub esp, 0x70 */
            ii(0x100b_cf29, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_cf2c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_cf2f, 4);  cmp(memd[ds, eax + 99], 0);           /* cmp dword [eax+0x63], 0x0 */
            ii(0x100b_cf33, 6);  if(jz(0x100b_d38f, 0x456)) goto l_0x100b_d38f;/* jz 0x100bd38f */
            ii(0x100b_cf39, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_cf3d, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_cf40, 5);  call(0x1008_bbed, -0x3_1358);         /* call 0x1008bbed */
            ii(0x100b_cf45, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100b_cf48, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x100b_cf4c, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_cf50, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100b_cf53, 5);  call(Definitions.my_ctor_0x101b_56fc, -0x3_42dc);/* call 0x10088c7c */
            ii(0x100b_cf58, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100b_cf5b, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x100b_cf5f, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x100b_cf64, 5);  call(0x1007_6338, -0x4_6c31);         /* call 0x10076338 */
            ii(0x100b_cf69, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_cf6b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_cf6e, 5);  call(0x1007_64b8, -0x4_6abb);         /* call 0x100764b8 */
            ii(0x100b_cf73, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_cf76, 5);  call(Definitions.my_ctor_0x101b_4184, -0x4_648b);/* call 0x10076af0 */
            ii(0x100b_cf7b, 6);  mov(memw[ss, ebp - 16], 0);           /* mov word [ebp-0x10], 0x0 */
            ii(0x100b_cf81, 2);  jmp(0x100b_cf8a, 7); goto l_0x100b_cf8a;/* jmp 0x100bcf8a */
        l_0x100b_cf83:
            ii(0x100b_cf83, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_cf86, 4);  inc(memw[ss, ebp - 16]);              /* inc word [ebp-0x10] */
        l_0x100b_cf8a:
            ii(0x100b_cf8a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_cf8d, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x100b_cf94, 2);  if(jge(0x100b_cfcf, 0x39)) goto l_0x100b_cfcf;/* jge 0x100bcfcf */
            ii(0x100b_cf96, 6);  mov(memw[ss, ebp - 14], 0);           /* mov word [ebp-0xe], 0x0 */
            ii(0x100b_cf9c, 2);  jmp(0x100b_cfa5, 7); goto l_0x100b_cfa5;/* jmp 0x100bcfa5 */
        l_0x100b_cf9e:
            ii(0x100b_cf9e, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x100b_cfa1, 4);  inc(memw[ss, ebp - 14]);              /* inc word [ebp-0xe] */
        l_0x100b_cfa5:
            ii(0x100b_cfa5, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x100b_cfa8, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x100b_cfaf, 2);  if(jge(0x100b_cfcd, 0x1c)) goto l_0x100b_cfcd;/* jge 0x100bcfcd */
            ii(0x100b_cfb1, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100b_cfb5, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100b_cfb8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_cfbb, 3);  mov(eax, memd[ds, eax + 99]);         /* mov eax, [eax+0x63] */
            ii(0x100b_cfbe, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100b_cfc0, 4);  movsx(edx, memw[ss, ebp - 14]);       /* movsx edx, word [ebp-0xe] */
            ii(0x100b_cfc4, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100b_cfc6, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100b_cfc8, 3);  and(memb[ds, eax], -5 /* 0xfb */);    /* and byte [eax], 0xfb */
            ii(0x100b_cfcb, 2);  jmp(0x100b_cf9e, -0x2f); goto l_0x100b_cf9e;/* jmp 0x100bcf9e */
        l_0x100b_cfcd:
            ii(0x100b_cfcd, 2);  jmp(0x100b_cf83, -0x4c); goto l_0x100b_cf83;/* jmp 0x100bcf83 */
        l_0x100b_cfcf:
            ii(0x100b_cfcf, 2);  jmp(0x100b_cfd9, 8); goto l_0x100b_cfd9;/* jmp 0x100bcfd9 */
        l_0x100b_cfd1:
            ii(0x100b_cfd1, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_cfd4, 5);  call(0x1007_6bf8, -0x4_63e1);         /* call 0x10076bf8 */
        l_0x100b_cfd9:
            ii(0x100b_cfd9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_cfdb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_cfde, 5);  call(0x1013_ad71, 0x7_dd8e);          /* call 0x1013ad71 */
            ii(0x100b_cfe3, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_cfe5, 2);  if(jz(0x100b_d014, 0x2d)) goto l_0x100b_d014;/* jz 0x100bd014 */
            ii(0x100b_cfe7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_cfea, 5);  call(0x1007_63a0, -0x4_6c4f);         /* call 0x100763a0 */
            ii(0x100b_cfef, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_cff1, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100b_cff4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_cff7, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100b_cffa, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100b_cffc, 2);  if(jnz(0x100b_d012, 0x14)) goto l_0x100b_d012;/* jnz 0x100bd012 */
            ii(0x100b_cffe, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d001, 5);  call(0x1007_63d4, -0x4_6c32);         /* call 0x100763d4 */
            ii(0x100b_d006, 3);  lea(ebx, memd[ss, ebp - 44]);         /* lea ebx, [ebp-0x2c] */
            ii(0x100b_d009, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d00b, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_d00d, 5);  call(0x1008_ab1c, -0x3_24f6);         /* call 0x1008ab1c */
        l_0x100b_d012:
            ii(0x100b_d012, 2);  jmp(0x100b_cfd1, -0x43); goto l_0x100b_cfd1;/* jmp 0x100bcfd1 */
        l_0x100b_d014:
            ii(0x100b_d014, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x100b_d019, 5);  call(0x1007_6338, -0x4_6ce6);         /* call 0x10076338 */
            ii(0x100b_d01e, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x100b_d021, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d023, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_d025, 5);  call(0x1007_643c, -0x4_6bee);         /* call 0x1007643c */
            ii(0x100b_d02a, 2);  jmp(0x100b_d034, 8); goto l_0x100b_d034;/* jmp 0x100bd034 */
        l_0x100b_d02c:
            ii(0x100b_d02c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d02f, 5);  call(0x1007_6bf8, -0x4_643c);         /* call 0x10076bf8 */
        l_0x100b_d034:
            ii(0x100b_d034, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d036, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d039, 5);  call(0x1013_ad71, 0x7_dd33);          /* call 0x1013ad71 */
            ii(0x100b_d03e, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_d040, 2);  if(jz(0x100b_d08a, 0x48)) goto l_0x100b_d08a;/* jz 0x100bd08a */
            ii(0x100b_d042, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d045, 5);  call(0x1007_63a0, -0x4_6caa);         /* call 0x100763a0 */
            ii(0x100b_d04a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d04c, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100b_d04f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_d052, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100b_d055, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100b_d057, 2);  if(jnz(0x100b_d072, 0x19)) goto l_0x100b_d072;/* jnz 0x100bd072 */
            ii(0x100b_d059, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d05c, 5);  call(0x1007_63d4, -0x4_6c8d);         /* call 0x100763d4 */
            ii(0x100b_d061, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d063, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_d066, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100b_d069, 5);  call(0x100b_cbe9, -0x485);            /* call 0x100bcbe9 */
            ii(0x100b_d06e, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_d070, 2);  if(jnz(0x100b_d074, 2)) goto l_0x100b_d074;/* jnz 0x100bd074 */
        l_0x100b_d072:
            ii(0x100b_d072, 2);  jmp(0x100b_d088, 0x14); goto l_0x100b_d088;/* jmp 0x100bd088 */
        l_0x100b_d074:
            ii(0x100b_d074, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d077, 5);  call(0x1007_63d4, -0x4_6ca8);         /* call 0x100763d4 */
            ii(0x100b_d07c, 3);  lea(ebx, memd[ss, ebp - 44]);         /* lea ebx, [ebp-0x2c] */
            ii(0x100b_d07f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d081, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_d083, 5);  call(0x1008_ab1c, -0x3_256c);         /* call 0x1008ab1c */
        l_0x100b_d088:
            ii(0x100b_d088, 2);  jmp(0x100b_d02c, -0x5e); goto l_0x100b_d02c;/* jmp 0x100bd02c */
        l_0x100b_d08a:
            ii(0x100b_d08a, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x100b_d08f, 5);  call(0x1007_6338, -0x4_6d5c);         /* call 0x10076338 */
            ii(0x100b_d094, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x100b_d097, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d099, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_d09b, 5);  call(0x1007_643c, -0x4_6c64);         /* call 0x1007643c */
            ii(0x100b_d0a0, 2);  jmp(0x100b_d0aa, 8); goto l_0x100b_d0aa;/* jmp 0x100bd0aa */
        l_0x100b_d0a2:
            ii(0x100b_d0a2, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d0a5, 5);  call(0x1007_6bf8, -0x4_64b2);         /* call 0x10076bf8 */
        l_0x100b_d0aa:
            ii(0x100b_d0aa, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d0ac, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d0af, 5);  call(0x1013_ad71, 0x7_dcbd);          /* call 0x1013ad71 */
            ii(0x100b_d0b4, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_d0b6, 2);  if(jz(0x100b_d100, 0x48)) goto l_0x100b_d100;/* jz 0x100bd100 */
            ii(0x100b_d0b8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d0bb, 5);  call(0x1007_63a0, -0x4_6d20);         /* call 0x100763a0 */
            ii(0x100b_d0c0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d0c2, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100b_d0c5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_d0c8, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100b_d0cb, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100b_d0cd, 2);  if(jnz(0x100b_d0e8, 0x19)) goto l_0x100b_d0e8;/* jnz 0x100bd0e8 */
            ii(0x100b_d0cf, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d0d2, 5);  call(0x1007_63d4, -0x4_6d03);         /* call 0x100763d4 */
            ii(0x100b_d0d7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d0d9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_d0dc, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100b_d0df, 5);  call(0x100b_cbe9, -0x4fb);            /* call 0x100bcbe9 */
            ii(0x100b_d0e4, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_d0e6, 2);  if(jnz(0x100b_d0ea, 2)) goto l_0x100b_d0ea;/* jnz 0x100bd0ea */
        l_0x100b_d0e8:
            ii(0x100b_d0e8, 2);  jmp(0x100b_d0fe, 0x14); goto l_0x100b_d0fe;/* jmp 0x100bd0fe */
        l_0x100b_d0ea:
            ii(0x100b_d0ea, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d0ed, 5);  call(0x1007_63d4, -0x4_6d1e);         /* call 0x100763d4 */
            ii(0x100b_d0f2, 3);  lea(ebx, memd[ss, ebp - 44]);         /* lea ebx, [ebp-0x2c] */
            ii(0x100b_d0f5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d0f7, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_d0f9, 5);  call(0x1008_ab1c, -0x3_25e2);         /* call 0x1008ab1c */
        l_0x100b_d0fe:
            ii(0x100b_d0fe, 2);  jmp(0x100b_d0a2, -0x5e); goto l_0x100b_d0a2;/* jmp 0x100bd0a2 */
        l_0x100b_d100:
            ii(0x100b_d100, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100b_d103, 5);  call(0x1007_6338, -0x4_6dd0);         /* call 0x10076338 */
            ii(0x100b_d108, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x100b_d10b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d10d, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_d10f, 5);  call(0x1007_643c, -0x4_6cd8);         /* call 0x1007643c */
            ii(0x100b_d114, 2);  jmp(0x100b_d11e, 8); goto l_0x100b_d11e;/* jmp 0x100bd11e */
        l_0x100b_d116:
            ii(0x100b_d116, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d119, 5);  call(0x1007_6bf8, -0x4_6526);         /* call 0x10076bf8 */
        l_0x100b_d11e:
            ii(0x100b_d11e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d120, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d123, 5);  call(0x1013_ad71, 0x7_dc49);          /* call 0x1013ad71 */
            ii(0x100b_d128, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_d12a, 6);  if(jz(0x100b_d1af, 0x7f)) goto l_0x100b_d1af;/* jz 0x100bd1af */
            ii(0x100b_d130, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d133, 5);  call(0x1007_63a0, -0x4_6d98);         /* call 0x100763a0 */
            ii(0x100b_d138, 5);  call(0x1007_623c, -0x4_6f01);         /* call 0x1007623c */
            ii(0x100b_d13d, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x100b_d141, 5);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x100b_d146, 3);  movsx(esi, ax);                       /* movsx esi, ax */
            ii(0x100b_d149, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d14c, 5);  call(0x1007_63a0, -0x4_6db1);         /* call 0x100763a0 */
            ii(0x100b_d151, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x100b_d154, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100b_d157, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d15a, 5);  call(0x1007_63a0, -0x4_6dbf);         /* call 0x100763a0 */
            ii(0x100b_d15f, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x100b_d162, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100b_d165, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x100b_d168, 5);  call(0x1007_6aac, -0x4_66c1);         /* call 0x10076aac */
            ii(0x100b_d16d, 3);  lea(ecx, memd[ss, ebp - 68]);         /* lea ecx, [ebp-0x44] */
            ii(0x100b_d170, 2);  mov(ebx, esi);                        /* mov ebx, esi */
            ii(0x100b_d172, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d174, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x100b_d176, 5);  call(0x100a_95c1, -0x1_3bba);         /* call 0x100a95c1 */
        l_0x100b_d17b:
            ii(0x100b_d17b, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x100b_d17e, 5);  call(0x1008_982c, -0x3_3957);         /* call 0x1008982c */
            ii(0x100b_d183, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100b_d186, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x100b_d189, 5);  call(0x1008_9860, -0x3_392e);         /* call 0x10089860 */
            ii(0x100b_d18e, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100b_d191, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_d194, 5);  call(0x1008_a728, -0x3_2a71);         /* call 0x1008a728 */
            ii(0x100b_d199, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100b_d19b, 3);  mov(memb[ds, eax], 1);                /* mov byte [eax], 0x1 */
            ii(0x100b_d19e, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x100b_d1a1, 5);  call(0x100a_96db, -0x1_3acb);         /* call 0x100a96db */
            ii(0x100b_d1a6, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_d1a8, 2);  if(jnz(0x100b_d17b, -0x2f)) goto l_0x100b_d17b;/* jnz 0x100bd17b */
            ii(0x100b_d1aa, 5);  jmp(0x100b_d116, -0x99); goto l_0x100b_d116;/* jmp 0x100bd116 */
        l_0x100b_d1af:
            ii(0x100b_d1af, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_d1b6, 2);  jmp(0x100b_d1be, 6); goto l_0x100b_d1be;/* jmp 0x100bd1be */
        l_0x100b_d1b8:
            ii(0x100b_d1b8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_d1bb, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x100b_d1be:
            ii(0x100b_d1be, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100b_d1c2, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100b_d1c5, 6);  if(jge(0x100b_d274, 0xa9)) goto l_0x100b_d274;/* jge 0x100bd274 */
            ii(0x100b_d1cb, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_d1ce, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_d1d1, 3);  cmp(ax, memw[ds, edx]);               /* cmp ax, [edx] */
            ii(0x100b_d1d4, 2);  if(jz(0x100b_d1ef, 0x19)) goto l_0x100b_d1ef;/* jz 0x100bd1ef */
            ii(0x100b_d1d6, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100b_d1da, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100b_d1e0, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100b_d1e6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100b_d1eb, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100b_d1ed, 2);  if(jnz(0x100b_d1f4, 5)) goto l_0x100b_d1f4;/* jnz 0x100bd1f4 */
        l_0x100b_d1ef:
            ii(0x100b_d1ef, 5);  jmp(0x100b_d26f, 0x7b); goto l_0x100b_d26f;/* jmp 0x100bd26f */
        l_0x100b_d1f4:
            ii(0x100b_d1f4, 6);  mov(memw[ss, ebp - 16], 0);           /* mov word [ebp-0x10], 0x0 */
            ii(0x100b_d1fa, 2);  jmp(0x100b_d203, 7); goto l_0x100b_d203;/* jmp 0x100bd203 */
        l_0x100b_d1fc:
            ii(0x100b_d1fc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_d1ff, 4);  inc(memw[ss, ebp - 16]);              /* inc word [ebp-0x10] */
        l_0x100b_d203:
            ii(0x100b_d203, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_d206, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x100b_d20d, 2);  if(jge(0x100b_d26f, 0x60)) goto l_0x100b_d26f;/* jge 0x100bd26f */
            ii(0x100b_d20f, 6);  mov(memw[ss, ebp - 14], 0);           /* mov word [ebp-0xe], 0x0 */
            ii(0x100b_d215, 2);  jmp(0x100b_d21e, 7); goto l_0x100b_d21e;/* jmp 0x100bd21e */
        l_0x100b_d217:
            ii(0x100b_d217, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x100b_d21a, 4);  inc(memw[ss, ebp - 14]);              /* inc word [ebp-0xe] */
        l_0x100b_d21e:
            ii(0x100b_d21e, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x100b_d221, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x100b_d228, 2);  if(jge(0x100b_d26d, 0x43)) goto l_0x100b_d26d;/* jge 0x100bd26d */
            ii(0x100b_d22a, 4);  movsx(edx, memw[ss, ebp - 14]);       /* movsx edx, word [ebp-0xe] */
            ii(0x100b_d22e, 5);  mov(eax, memd[ds, 0x101c_8170]);      /* mov eax, [0x101c8170] */
            ii(0x100b_d233, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100b_d236, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100b_d239, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100b_d23d, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100b_d23f, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100b_d243, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100b_d249, 6);  mov(eax, memd[ds, eax + 0x101c_a6a3]);/* mov eax, [eax+0x101ca6a3] */
            ii(0x100b_d24f, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100b_d251, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x100b_d254, 2);  if(jz(0x100b_d26b, 0x15)) goto l_0x100b_d26b;/* jz 0x100bd26b */
            ii(0x100b_d256, 4);  movsx(ebx, memw[ss, ebp - 14]);       /* movsx ebx, word [ebp-0xe] */
            ii(0x100b_d25a, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100b_d25e, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_d261, 5);  call(0x1008_a728, -0x3_2b3e);         /* call 0x1008a728 */
            ii(0x100b_d266, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100b_d268, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x100b_d26b:
            ii(0x100b_d26b, 2);  jmp(0x100b_d217, -0x56); goto l_0x100b_d217;/* jmp 0x100bd217 */
        l_0x100b_d26d:
            ii(0x100b_d26d, 2);  jmp(0x100b_d1fc, -0x73); goto l_0x100b_d1fc;/* jmp 0x100bd1fc */
        l_0x100b_d26f:
            ii(0x100b_d26f, 5);  jmp(0x100b_d1b8, -0xbc); goto l_0x100b_d1b8;/* jmp 0x100bd1b8 */
        l_0x100b_d274:
            ii(0x100b_d274, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100b_d277, 5);  call(0x1007_6338, -0x4_6f44);         /* call 0x10076338 */
            ii(0x100b_d27c, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x100b_d27f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d281, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100b_d283, 5);  call(0x1007_643c, -0x4_6e4c);         /* call 0x1007643c */
            ii(0x100b_d288, 2);  jmp(0x100b_d292, 8); goto l_0x100b_d292;/* jmp 0x100bd292 */
        l_0x100b_d28a:
            ii(0x100b_d28a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d28d, 5);  call(0x1007_6bf8, -0x4_669a);         /* call 0x10076bf8 */
        l_0x100b_d292:
            ii(0x100b_d292, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d294, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d297, 5);  call(0x1013_ad71, 0x7_dad5);          /* call 0x1013ad71 */
            ii(0x100b_d29c, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_d29e, 6);  if(jz(0x100b_d371, 0xcd)) goto l_0x100b_d371;/* jz 0x100bd371 */
            ii(0x100b_d2a4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d2a7, 5);  call(0x1007_63a0, -0x4_6f0c);         /* call 0x100763a0 */
            ii(0x100b_d2ac, 5);  call(0x1007_623c, -0x4_7075);         /* call 0x1007623c */
            ii(0x100b_d2b1, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x100b_d2b5, 5);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x100b_d2ba, 3);  movsx(esi, ax);                       /* movsx esi, ax */
            ii(0x100b_d2bd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d2c0, 5);  call(0x1007_63a0, -0x4_6f25);         /* call 0x100763a0 */
            ii(0x100b_d2c5, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x100b_d2c8, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100b_d2cb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d2ce, 5);  call(0x1007_63a0, -0x4_6f33);         /* call 0x100763a0 */
            ii(0x100b_d2d3, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x100b_d2d6, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100b_d2d9, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x100b_d2dc, 5);  call(0x1007_6aac, -0x4_6835);         /* call 0x10076aac */
            ii(0x100b_d2e1, 3);  lea(ecx, memd[ss, ebp - 104]);        /* lea ecx, [ebp-0x68] */
            ii(0x100b_d2e4, 2);  mov(ebx, esi);                        /* mov ebx, esi */
            ii(0x100b_d2e6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d2e8, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x100b_d2ea, 5);  call(0x100a_9833, -0x1_3abc);         /* call 0x100a9833 */
        l_0x100b_d2ef:
            ii(0x100b_d2ef, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x100b_d2f2, 5);  call(0x100c_ab38, 0xd841);            /* call 0x100cab38 */
            ii(0x100b_d2f7, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100b_d2fa, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x100b_d2fd, 5);  call(0x100c_ab6c, 0xd86a);            /* call 0x100cab6c */
            ii(0x100b_d302, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100b_d305, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_d308, 5);  call(0x1008_a728, -0x3_2be5);         /* call 0x1008a728 */
            ii(0x100b_d30d, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100b_d30f, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x100b_d312, 2);  if(jnz(0x100b_d360, 0x4c)) goto l_0x100b_d360;/* jnz 0x100bd360 */
            ii(0x100b_d314, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_d317, 5);  call(0x1008_a6f8, -0x3_2c24);         /* call 0x1008a6f8 */
            ii(0x100b_d31c, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x100b_d31e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d321, 5);  call(0x1007_63a0, -0x4_6f86);         /* call 0x100763a0 */
            ii(0x100b_d326, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x100b_d329, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100b_d32c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d32f, 5);  call(0x1007_63a0, -0x4_6f94);         /* call 0x100763a0 */
            ii(0x100b_d334, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x100b_d337, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100b_d33a, 3);  lea(eax, memd[ss, ebp - 108]);        /* lea eax, [ebp-0x6c] */
            ii(0x100b_d33d, 5);  call(0x1007_6aac, -0x4_6896);         /* call 0x10076aac */
            ii(0x100b_d342, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100b_d344, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x100b_d347, 5);  call(0x100c_aba0, 0xd854);            /* call 0x100caba0 */
            ii(0x100b_d34c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d34e, 3);  lea(eax, memd[ss, ebp - 112]);        /* lea eax, [ebp-0x70] */
            ii(0x100b_d351, 5);  call(0x1007_5e64, -0x4_74f2);         /* call 0x10075e64 */
            ii(0x100b_d356, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_d358, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_d35b, 5);  call(0x100b_ccb3, -0x6ad);            /* call 0x100bccb3 */
        l_0x100b_d360:
            ii(0x100b_d360, 3);  lea(eax, memd[ss, ebp - 104]);        /* lea eax, [ebp-0x68] */
            ii(0x100b_d363, 5);  call(0x100a_9ae0, -0x1_3888);         /* call 0x100a9ae0 */
            ii(0x100b_d368, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_d36a, 2);  if(jnz(0x100b_d2ef, -0x7d)) goto l_0x100b_d2ef;/* jnz 0x100bd2ef */
            ii(0x100b_d36c, 5);  jmp(0x100b_d28a, -0xe7); goto l_0x100b_d28a;/* jmp 0x100bd28a */
        l_0x100b_d371:
            ii(0x100b_d371, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d373, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100b_d376, 5);  call(0x1007_5f6c, -0x4_740f);         /* call 0x10075f6c */
            ii(0x100b_d37b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d37d, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100b_d380, 5);  call(Definitions.my_dtor_0x101b_56fc, -0x3_4749);/* call 0x10088c3c */
            ii(0x100b_d385, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_d387, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x100b_d38a, 5);  call(0x1008_bc9f, -0x3_16f0);         /* call 0x1008bc9f */
        l_0x100b_d38f:
            ii(0x100b_d38f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_d391, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_d392, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_d393, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_d394, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_d395, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_d396, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_d397, 1);  ret();                                /* ret */
        }
    }
}
