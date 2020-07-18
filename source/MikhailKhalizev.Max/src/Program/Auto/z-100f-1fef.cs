using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_1fef-5d0d84a7")]
        public void Method_100f_1fef()
        {
            ii(0x100f_1fef, 5);  push(0x4c);                           /* push 0x4c */
            ii(0x100f_1ff4, 5);  call(Definitions.sys_check_available_stack_size, 0x7_3d59);/* call 0x10165d52 */
            ii(0x100f_1ff9, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_1ffa, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_1ffb, 1);  push(edx);                            /* push edx */
            ii(0x100f_1ffc, 1);  push(esi);                            /* push esi */
            ii(0x100f_1ffd, 1);  push(edi);                            /* push edi */
            ii(0x100f_1ffe, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_1fff, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_2001, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x100f_2007, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_200a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_200d, 5);  call(0x1007_623c, -0x7_bdd6);         /* call 0x1007623c */
            ii(0x100f_2012, 3);  lea(ebx, memd[ss, ebp - 32]);         /* lea ebx, [ebp-0x20] */
            ii(0x100f_2015, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_2017, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100f_2019, 5);  call(0x1007_6800, -0x7_b81e);         /* call 0x10076800 */
            ii(0x100f_201e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_2021, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x100f_2025, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_2028, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_202b, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x100f_202f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_2032, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_2035, 3);  mov(al, memb[ds, eax + 61]);          /* mov al, [eax+0x3d] */
            ii(0x100f_2038, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100f_203b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_203e, 3);  mov(al, memb[ds, eax + 62]);          /* mov al, [eax+0x3e] */
            ii(0x100f_2041, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x100f_2044, 4);  cmp(memb[ss, ebp - 12], 0xc);         /* cmp byte [ebp-0xc], 0xc */
            ii(0x100f_2048, 2);  if(jz(0x100f_2050, 6)) goto l_0x100f_2050;/* jz 0x100f2050 */
            ii(0x100f_204a, 4);  cmp(memb[ss, ebp - 12], 0x10);        /* cmp byte [ebp-0xc], 0x10 */
            ii(0x100f_204e, 2);  if(jnz(0x100f_2052, 2)) goto l_0x100f_2052;/* jnz 0x100f2052 */
        l_0x100f_2050:
            ii(0x100f_2050, 2);  jmp(0x100f_2058, 6); goto l_0x100f_2058;/* jmp 0x100f2058 */
        l_0x100f_2052:
            ii(0x100f_2052, 4);  cmp(memb[ss, ebp - 12], 0x1a);        /* cmp byte [ebp-0xc], 0x1a */
            ii(0x100f_2056, 2);  if(jnz(0x100f_205a, 2)) goto l_0x100f_205a;/* jnz 0x100f205a */
        l_0x100f_2058:
            ii(0x100f_2058, 2);  jmp(0x100f_2060, 6); goto l_0x100f_2060;/* jmp 0x100f2060 */
        l_0x100f_205a:
            ii(0x100f_205a, 4);  cmp(memb[ss, ebp - 12], 9);           /* cmp byte [ebp-0xc], 0x9 */
            ii(0x100f_205e, 2);  if(jnz(0x100f_2062, 2)) goto l_0x100f_2062;/* jnz 0x100f2062 */
        l_0x100f_2060:
            ii(0x100f_2060, 2);  jmp(0x100f_2068, 6); goto l_0x100f_2068;/* jmp 0x100f2068 */
        l_0x100f_2062:
            ii(0x100f_2062, 4);  cmp(memb[ss, ebp - 8], 0xe);          /* cmp byte [ebp-0x8], 0xe */
            ii(0x100f_2066, 2);  if(jnz(0x100f_206a, 2)) goto l_0x100f_206a;/* jnz 0x100f206a */
        l_0x100f_2068:
            ii(0x100f_2068, 2);  jmp(0x100f_2070, 6); goto l_0x100f_2070;/* jmp 0x100f2070 */
        l_0x100f_206a:
            ii(0x100f_206a, 4);  cmp(memb[ss, ebp - 8], 2);            /* cmp byte [ebp-0x8], 0x2 */
            ii(0x100f_206e, 2);  if(jnz(0x100f_2083, 0x13)) goto l_0x100f_2083;/* jnz 0x100f2083 */
        l_0x100f_2070:
            ii(0x100f_2070, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100f_2074, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_2076, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_2079, 5);  call(0x1007_5eec, -0x7_c192);         /* call 0x10075eec */
            ii(0x100f_207e, 5);  jmp(0x100f_2198, 0x115); goto l_0x100f_2198;/* jmp 0x100f2198 */
        l_0x100f_2083:
            ii(0x100f_2083, 4);  cmp(memb[ss, ebp - 12], 4);           /* cmp byte [ebp-0xc], 0x4 */
            ii(0x100f_2087, 2);  if(jz(0x100f_208f, 6)) goto l_0x100f_208f;/* jz 0x100f208f */
            ii(0x100f_2089, 4);  cmp(memb[ss, ebp - 12], 0xb);         /* cmp byte [ebp-0xc], 0xb */
            ii(0x100f_208d, 2);  if(jnz(0x100f_20b4, 0x25)) goto l_0x100f_20b4;/* jnz 0x100f20b4 */
        l_0x100f_208f:
            ii(0x100f_208f, 4);  cmp(memb[ss, ebp - 8], 0x19);         /* cmp byte [ebp-0x8], 0x19 */
            ii(0x100f_2093, 2);  if(jnz(0x100f_209b, 6)) goto l_0x100f_209b;/* jnz 0x100f209b */
            ii(0x100f_2095, 4);  mov(memb[ss, ebp - 36], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100f_2099, 2);  jmp(0x100f_209f, 4); goto l_0x100f_209f;/* jmp 0x100f209f */
        l_0x100f_209b:
            ii(0x100f_209b, 4);  mov(memb[ss, ebp - 36], 0);           /* mov byte [ebp-0x24], 0x0 */
        l_0x100f_209f:
            ii(0x100f_209f, 3);  mov(al, memb[ss, ebp - 36]);          /* mov al, [ebp-0x24] */
            ii(0x100f_20a2, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x100f_20a5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_20a7, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_20aa, 5);  call(0x1007_5eec, -0x7_c1c3);         /* call 0x10075eec */
            ii(0x100f_20af, 5);  jmp(0x100f_2198, 0xe4); goto l_0x100f_2198;/* jmp 0x100f2198 */
        l_0x100f_20b4:
            ii(0x100f_20b4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_20b7, 4);  cmp(memb[ds, eax + 78], 0);           /* cmp byte [eax+0x4e], 0x0 */
            ii(0x100f_20bb, 2);  if(jz(0x100f_20d0, 0x13)) goto l_0x100f_20d0;/* jz 0x100f20d0 */
            ii(0x100f_20bd, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100f_20c1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_20c3, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_20c6, 5);  call(0x1007_5eec, -0x7_c1df);         /* call 0x10075eec */
            ii(0x100f_20cb, 5);  jmp(0x100f_2198, 0xc8); goto l_0x100f_2198;/* jmp 0x100f2198 */
        l_0x100f_20d0:
            ii(0x100f_20d0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_20d3, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100f_20d7, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_20da, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_20dd, 4);  cmp(memb[ds, eax + 80], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x100f_20e1, 2);  if(jz(0x100f_2125, 0x42)) goto l_0x100f_2125;/* jz 0x100f2125 */
            ii(0x100f_20e3, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100f_20e8, 1);  push(eax);                            /* push eax */
            ii(0x100f_20e9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_20eb, 1);  push(eax);                            /* push eax */
            ii(0x100f_20ec, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_20ef, 5);  call(0x1007_6730, -0x7_b9c4);         /* call 0x10076730 */
            ii(0x100f_20f4, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100f_20f7, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_20fa, 1);  push(eax);                            /* push eax */
            ii(0x100f_20fb, 3);  lea(ecx, memd[ss, ebp - 20]);         /* lea ecx, [ebp-0x14] */
            ii(0x100f_20fe, 3);  lea(ebx, memd[ss, ebp - 28]);         /* lea ebx, [ebp-0x1c] */
            ii(0x100f_2101, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_2104, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100f_2108, 5);  call(0x1007_0efa, -0x8_1213);         /* call 0x10070efa */
            ii(0x100f_210d, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100f_2110, 2);  if(jz(0x100f_2125, 0x13)) goto l_0x100f_2125;/* jz 0x100f2125 */
            ii(0x100f_2112, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100f_2116, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_2118, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_211b, 5);  call(0x1007_5eec, -0x7_c234);         /* call 0x10075eec */
            ii(0x100f_2120, 5);  jmp(0x100f_2198, 0x73); goto l_0x100f_2198;/* jmp 0x100f2198 */
        l_0x100f_2125:
            ii(0x100f_2125, 5);  cmp(memw[ss, ebp - 24], 0x3b);        /* cmp word [ebp-0x18], 0x3b */
            ii(0x100f_212a, 2);  if(jz(0x100f_2133, 7)) goto l_0x100f_2133;/* jz 0x100f2133 */
            ii(0x100f_212c, 5);  cmp(memw[ss, ebp - 24], 0x4b);        /* cmp word [ebp-0x18], 0x4b */
            ii(0x100f_2131, 2);  if(jnz(0x100f_2135, 2)) goto l_0x100f_2135;/* jnz 0x100f2135 */
        l_0x100f_2133:
            ii(0x100f_2133, 2);  jmp(0x100f_213c, 7); goto l_0x100f_213c;/* jmp 0x100f213c */
        l_0x100f_2135:
            ii(0x100f_2135, 5);  cmp(memw[ss, ebp - 24], 0x40);        /* cmp word [ebp-0x18], 0x40 */
            ii(0x100f_213a, 2);  if(jnz(0x100f_213e, 2)) goto l_0x100f_213e;/* jnz 0x100f213e */
        l_0x100f_213c:
            ii(0x100f_213c, 2);  jmp(0x100f_2145, 7); goto l_0x100f_2145;/* jmp 0x100f2145 */
        l_0x100f_213e:
            ii(0x100f_213e, 5);  cmp(memw[ss, ebp - 24], 0x3c);        /* cmp word [ebp-0x18], 0x3c */
            ii(0x100f_2143, 2);  if(jnz(0x100f_2147, 2)) goto l_0x100f_2147;/* jnz 0x100f2147 */
        l_0x100f_2145:
            ii(0x100f_2145, 2);  jmp(0x100f_214e, 7); goto l_0x100f_214e;/* jmp 0x100f214e */
        l_0x100f_2147:
            ii(0x100f_2147, 5);  cmp(memw[ss, ebp - 24], 0x3f);        /* cmp word [ebp-0x18], 0x3f */
            ii(0x100f_214c, 2);  if(jnz(0x100f_217e, 0x30)) goto l_0x100f_217e;/* jnz 0x100f217e */
        l_0x100f_214e:
            ii(0x100f_214e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_2151, 5);  cmp(memw[ds, eax + 82], 0);           /* cmp word [eax+0x52], 0x0 */
            ii(0x100f_2156, 2);  if(jz(0x100f_216c, 0x14)) goto l_0x100f_216c;/* jz 0x100f216c */
            ii(0x100f_2158, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x100f_215c, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100f_2160, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_2163, 5);  call(0x100f_1f41, -0x227);            /* call 0x100f1f41 */
            ii(0x100f_2168, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_216a, 2);  if(jnz(0x100f_216e, 2)) goto l_0x100f_216e;/* jnz 0x100f216e */
        l_0x100f_216c:
            ii(0x100f_216c, 2);  jmp(0x100f_217e, 0x10); goto l_0x100f_217e;/* jmp 0x100f217e */
        l_0x100f_216e:
            ii(0x100f_216e, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100f_2172, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_2174, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_2177, 5);  call(0x1007_5eec, -0x7_c290);         /* call 0x10075eec */
            ii(0x100f_217c, 2);  jmp(0x100f_2198, 0x1a); goto l_0x100f_2198;/* jmp 0x100f2198 */
        l_0x100f_217e:
            ii(0x100f_217e, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100f_2182, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_2184, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_2187, 5);  call(0x1007_5eec, -0x7_c2a0);         /* call 0x10075eec */
            ii(0x100f_218c, 2);  jmp(0x100f_2198, 0xa); goto l_0x100f_2198;/* jmp 0x100f2198 */
        //  ii(0x100f_218e, 10);  Недостижимый код.
        l_0x100f_2198:
            ii(0x100f_2198, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100f_219b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_219d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_219e, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_219f, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_21a0, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_21a1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_21a2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_21a3, 1);  ret();                                /* ret */
        }
    }
}
