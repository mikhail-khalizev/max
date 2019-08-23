using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2125-fefdfaf4")]
        public void Method_1015_2125()
        {
            ii(0x1015_2125, 5); push(0x6c);                             /* push 0x6c */
            ii(0x1015_212a, 5); call(Definitions.sys_check_available_stack_size, 0x1_3c23); /* call 0x10165d52 */
            ii(0x1015_212f, 1); push(ebx);                              /* push ebx */
            ii(0x1015_2130, 1); push(ecx);                              /* push ecx */
            ii(0x1015_2131, 1); push(esi);                              /* push esi */
            ii(0x1015_2132, 1); push(edi);                              /* push edi */
            ii(0x1015_2133, 1); push(ebp);                              /* push ebp */
            ii(0x1015_2134, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2136, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1015_213c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_213f, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_2142, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_2145, 5); call(0x1007_623c, -0xd_bf0e);           /* call 0x1007623c */
            ii(0x1015_214a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_214c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_214f, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1015_2152, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2155, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_2158, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_215b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_2160, 6); imul(ecx, eax, 0x247);                  /* imul ecx, eax, 0x247 */
            ii(0x1015_2166, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1015_216b, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1015_216d, 5); call(0x100d_fd2c, -0x7_2446);           /* call 0x100dfd2c */
            ii(0x1015_2172, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1015_2174, 2); if(jz(0x1015_2187, 0x11)) goto l_0x1015_2187; /* jz 0x10152187 */
            ii(0x1015_2176, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2178, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_217b, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_217e, 5); call(0x1013_ad71, -0x1_7412);           /* call 0x1013ad71 */
            ii(0x1015_2183, 2); test(al, al);                           /* test al, al */
            ii(0x1015_2185, 2); if(jnz(0x1015_218c, 0x5)) goto l_0x1015_218c; /* jnz 0x1015218c */
        l_0x1015_2187:
            ii(0x1015_2187, 5); jmp(0x1015_2312, 0x186); goto l_0x1015_2312; /* jmp 0x10152312 */
        l_0x1015_218c:
            ii(0x1015_218c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_218f, 5); call(0x1007_20b1, -0xe_00e3);           /* call 0x100720b1 */
            ii(0x1015_2194, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1015_2197, 5); call(0x1007_20b1, -0xe_00eb);           /* call 0x100720b1 */
            ii(0x1015_219c, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x1015_219f, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1015_21a2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_21a5, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_21a8, 5); call(0x1015_5314, 0x3167);              /* call 0x10155314 */
            ii(0x1015_21ad, 5); call(0x1014_3616, -0xeb9c);             /* call 0x10143616 */
            ii(0x1015_21b2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_21b5, 5); call(0x1015_09a6, -0x1814);             /* call 0x101509a6 */
            ii(0x1015_21ba, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_21bd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_21bf, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_21c2, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1015_21c5, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1015_21c7, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1015_21ca, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1015_21cd, 3); mov(eax, memd[ss, ebp - 0x12]);         /* mov eax, [ebp-0x12] */
            ii(0x1015_21d0, 4); cmp(ax, memw[ss, ebp - 0x24]);          /* cmp ax, [ebp-0x24] */
            ii(0x1015_21d4, 2); if(jge(0x1015_2248, 0x72)) goto l_0x1015_2248; /* jge 0x10152248 */
            ii(0x1015_21d6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_21d9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_21db, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1015_21de, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_21e0, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_21e5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_21e7, 2); if(jnz(0x1015_21f2, 0x9)) goto l_0x1015_21f2; /* jnz 0x101521f2 */
            ii(0x1015_21e9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_21ec, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1015_21f0, 2); if(jnz(0x1015_21f4, 0x2)) goto l_0x1015_21f4; /* jnz 0x101521f4 */
        l_0x1015_21f2:
            ii(0x1015_21f2, 2); jmp(0x1015_2243, 0x4f); goto l_0x1015_2243; /* jmp 0x10152243 */
        l_0x1015_21f4:
            ii(0x1015_21f4, 5); call(0x100c_aa00, -0x8_77f9);           /* call 0x100caa00 */
            ii(0x1015_21f9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_21fe, 1); push(eax);                              /* push eax */
            ii(0x1015_21ff, 5); call(0x100c_aa20, -0x8_77e4);           /* call 0x100caa20 */
            ii(0x1015_2204, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_2206, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_2208, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1015_220d, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1015_2211, 1); push(eax);                              /* push eax */
            ii(0x1015_2212, 5); mov(eax, StringDefinitions.IRawMaterialNeededToUpgrade); /* mov eax, 0x101adee4 */
            ii(0x1015_2217, 1); push(eax);                              /* push eax */
            ii(0x1015_2218, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1015_221d, 1); push(eax);                              /* push eax */
            ii(0x1015_221e, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1015_2221, 5); call(Definitions.my_string_ctor, -0x1_073e); /* call 0x10141ae8 */
            ii(0x1015_2226, 1); push(eax);                              /* push eax */
            ii(0x1015_2227, 5); call(0x1014_2037, -0x1_01f5);           /* call 0x10142037 */
            ii(0x1015_222c, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1015_222f, 5); call(Definitions.my_strobj_c_str_v2, -0xc_8a6c); /* call 0x100897c8 */
            ii(0x1015_2234, 5); call(0x1011_5d23, -0x3_c516);           /* call 0x10115d23 */
            ii(0x1015_2239, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_223b, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1015_223e, 5); call(Definitions.my_string_dtor, -0x1_0719); /* call 0x10141b2a */
        l_0x1015_2243:
            ii(0x1015_2243, 5); jmp(0x1015_2312, 0xca); goto l_0x1015_2312; /* jmp 0x10152312 */
        l_0x1015_2248:
            ii(0x1015_2248, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_224b, 5); call(0x1014_f78c, -0x2ac4);             /* call 0x1014f78c */
            ii(0x1015_2250, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_2252, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_2254, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1015_2257, 2); neg(eax);                               /* neg eax */
            ii(0x1015_2259, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_225c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_225f, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_2262, 5); call(0x1015_5314, 0x30ad);              /* call 0x10155314 */
            ii(0x1015_2267, 5); call(0x100d_7a9c, -0x7_a7d0);           /* call 0x100d7a9c */
            ii(0x1015_226c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_226f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_2271, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1015_2274, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_2276, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_227b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_227d, 2); if(jnz(0x1015_2288, 0x9)) goto l_0x1015_2288; /* jnz 0x10152288 */
            ii(0x1015_227f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2282, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1015_2286, 2); if(jnz(0x1015_228d, 0x5)) goto l_0x1015_228d; /* jnz 0x1015228d */
        l_0x1015_2288:
            ii(0x1015_2288, 5); jmp(0x1015_2312, 0x85); goto l_0x1015_2312; /* jmp 0x10152312 */
        l_0x1015_228d:
            ii(0x1015_228d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_2290, 5); call(0x1007_623c, -0xd_c059);           /* call 0x1007623c */
            ii(0x1015_2295, 5); call(0x100e_f36c, -0x6_2f2e);           /* call 0x100ef36c */
            ii(0x1015_229a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_229d, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1015_22a0, 5); call(0x1014_f905, -0x29a0);             /* call 0x1014f905 */
            ii(0x1015_22a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_22a8, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_22ab, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_22ae, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_22b1, 3); mov(edx, memd[ds, edx + 0x18]);         /* mov edx, [edx+0x18] */
            ii(0x1015_22b4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_22b7, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1015_22ba, 5); call(0x1007_6aac, -0xd_b813);           /* call 0x10076aac */
            ii(0x1015_22bf, 2); mov(ecx, memd[ds, eax]);                /* mov ecx, [eax] */
            ii(0x1015_22c1, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1015_22c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_22c6, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1015_22ca, 1); push(eax);                              /* push eax */
            ii(0x1015_22cb, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1015_22ce, 1); push(eax);                              /* push eax */
            ii(0x1015_22cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_22d2, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_22d5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_22d8, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_22db, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x1015_22e1, 5); mov(eax, StringDefinitions.SUpgradedToMarkSForIRawMaterial); /* mov eax, 0x101adf07 */
            ii(0x1015_22e6, 1); push(eax);                              /* push eax */
            ii(0x1015_22e7, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1015_22ec, 1); push(eax);                              /* push eax */
            ii(0x1015_22ed, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1015_22f0, 5); call(Definitions.my_string_ctor, -0x1_080d); /* call 0x10141ae8 */
            ii(0x1015_22f5, 1); push(eax);                              /* push eax */
            ii(0x1015_22f6, 5); call(0x1014_2037, -0x1_02c4);           /* call 0x10142037 */
            ii(0x1015_22fb, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1015_22fe, 5); call(Definitions.my_strobj_c_str_v2, -0xc_8b3b); /* call 0x100897c8 */
            ii(0x1015_2303, 5); call(0x1011_5b60, -0x3_c7a8);           /* call 0x10115b60 */
            ii(0x1015_2308, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_230a, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1015_230d, 5); call(Definitions.my_string_dtor, -0x1_07e8); /* call 0x10141b2a */
        l_0x1015_2312:
            ii(0x1015_2312, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2315, 5); call(0x1014_f08b, -0x328f);             /* call 0x1014f08b */
            ii(0x1015_231a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_231c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_231f, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1015_2324, 5); call(0x1007_6630, -0xd_bcf9);           /* call 0x10076630 */
            ii(0x1015_2329, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_232e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_2331, 5); call(0x1007_6d98, -0xd_b59e);           /* call 0x10076d98 */
            ii(0x1015_2336, 2); test(al, al);                           /* test al, al */
            ii(0x1015_2338, 2); if(jz(0x1015_2342, 0x8)) goto l_0x1015_2342; /* jz 0x10152342 */
            ii(0x1015_233a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_233d, 5); call(0x1010_094d, -0x5_19f5);           /* call 0x1010094d */
        l_0x1015_2342:
            ii(0x1015_2342, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_2347, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_234a, 5); call(0x1007_6d98, -0xd_b5b7);           /* call 0x10076d98 */
            ii(0x1015_234f, 2); test(al, al);                           /* test al, al */
            ii(0x1015_2351, 2); if(jz(0x1015_2372, 0x1f)) goto l_0x1015_2372; /* jz 0x10152372 */
            ii(0x1015_2353, 7); cmp(memb[ds, 0x101c_3889], 0);          /* cmp byte [0x101c3889], 0x0 */
            ii(0x1015_235a, 2); if(jnz(0x1015_2365, 0x9)) goto l_0x1015_2365; /* jnz 0x10152365 */
            ii(0x1015_235c, 7); cmp(memb[ds, 0x101c_388a], 0);          /* cmp byte [0x101c388a], 0x0 */
            ii(0x1015_2363, 2); if(jz(0x1015_236a, 0x5)) goto l_0x1015_236a; /* jz 0x1015236a */
        l_0x1015_2365:
            ii(0x1015_2365, 5); call(0x100f_f5c1, -0x5_2da9);           /* call 0x100ff5c1 */
        l_0x1015_236a:
            ii(0x1015_236a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_236d, 5); call(0x100f_f637, -0x5_2d3b);           /* call 0x100ff637 */
        l_0x1015_2372:
            ii(0x1015_2372, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_2377, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_237a, 5); call(0x1015_2605, 0x286);               /* call 0x10152605 */
            ii(0x1015_237f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2381, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_2382, 1); pop(edi);                               /* pop edi */
            ii(0x1015_2383, 1); pop(esi);                               /* pop esi */
            ii(0x1015_2384, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_2385, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_2386, 1); ret();                                  /* ret */
        }
    }
}
