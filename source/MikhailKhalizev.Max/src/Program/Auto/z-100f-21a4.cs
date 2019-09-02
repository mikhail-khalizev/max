using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_21a4-ca8cf815")]
        public void Method_100f_21a4()
        {
            ii(0x100f_21a4, 5); push(0x6c);                             /* push 0x6c */
            ii(0x100f_21a9, 5); call(Definitions.sys_check_available_stack_size, 0x7_3ba4); /* call 0x10165d52 */
            ii(0x100f_21ae, 1); push(ebx);                              /* push ebx */
            ii(0x100f_21af, 1); push(ecx);                              /* push ecx */
            ii(0x100f_21b0, 1); push(edx);                              /* push edx */
            ii(0x100f_21b1, 1); push(esi);                              /* push esi */
            ii(0x100f_21b2, 1); push(edi);                              /* push edi */
            ii(0x100f_21b3, 1); push(ebp);                              /* push ebp */
            ii(0x100f_21b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_21b6, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100f_21bc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_21bf, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x100f_21c3, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100f_21c6, 5); call(Definitions.my_string_ctor, 0x4_f91d); /* call 0x10141ae8 */
            ii(0x100f_21cb, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100f_21ce, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x100f_21d2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_21d5, 5); cmp(memw[ds, eax + 8], 0x3e);           /* cmp word [eax+0x8], 0x3e */
            ii(0x100f_21da, 2); if(jnz(0x100f_2205, 0x29)) goto l_0x100f_2205; /* jnz 0x100f2205 */
            ii(0x100f_21dc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_21df, 3); mov(al, memb[ds, eax + 69]);            /* mov al, [eax+0x45] */
            ii(0x100f_21e2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_21e7, 1); push(eax);                              /* push eax */
            ii(0x100f_21e8, 5); mov(eax, StringDefinitions.NumberOfTurnsToClearSiteI); /* mov eax, 0x101a230d */
            ii(0x100f_21ed, 1); push(eax);                              /* push eax */
            ii(0x100f_21ee, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x100f_21f3, 1); push(eax);                              /* push eax */
            ii(0x100f_21f4, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100f_21f7, 1); push(eax);                              /* push eax */
            ii(0x100f_21f8, 5); call(0x1014_2037, 0x4_fe3a);            /* call 0x10142037 */
            ii(0x100f_21fd, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100f_2200, 5); jmp(0x100f_23ad, 0x1a8); goto l_0x100f_23ad; /* jmp 0x100f23ad */
        l_0x100f_2205:
            ii(0x100f_2205, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2208, 4); cmp(memb[ds, eax + 62], 0x1f);          /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100f_220c, 6); if(jnz(0x100f_22c5, 0xb3)) goto l_0x100f_22c5; /* jnz 0x100f22c5 */
            ii(0x100f_2212, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2215, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100f_2218, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_221b, 3); imul(edx, eax, 0x33);                   /* imul edx, eax, 0x33 */
            ii(0x100f_221e, 5); mov(eax, 0x101c_81c0);                  /* mov eax, 0x101c81c0 */
            ii(0x100f_2223, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_2225, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100f_2228, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_222b, 5); call(0x1007_611c, -0x7_c114);           /* call 0x1007611c */
            ii(0x100f_2230, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100f_2233, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_2236, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_2239, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x100f_223e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_2240, 3); mov(memd[ss, ebp - 24], edx);           /* mov [ebp-0x18], edx */
            ii(0x100f_2243, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2246, 4); test(memb[ds, eax + 19], 2);            /* test byte [eax+0x13], 0x2 */
            ii(0x100f_224a, 2); if(jz(0x100f_2287, 0x3b)) goto l_0x100f_2287; /* jz 0x100f2287 */
            ii(0x100f_224c, 3); lea(edi, memd[ss, ebp - 36]);           /* lea edi, [ebp-0x24] */
            ii(0x100f_224f, 5); mov(esi, 0x101b_8a88);                  /* mov esi, 0x101b8a88 */
            ii(0x100f_2254, 1); movsd();                                /* movsd */
            ii(0x100f_2255, 1); movsd();                                /* movsd */
            ii(0x100f_2256, 1); movsd();                                /* movsd */
            ii(0x100f_2257, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_225a, 3); push(memd[ds, eax + 23]);               /* push dword [eax+0x17] */
            ii(0x100f_225d, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_2260, 3); push(memd[ds, eax + 23]);               /* push dword [eax+0x17] */
            ii(0x100f_2263, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_2266, 3); mov(eax, memd[ds, eax + 19]);           /* mov eax, [eax+0x13] */
            ii(0x100f_2269, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_226c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100f_226f, 4); push(memd[ds, eax + ebp - 36]);         /* push dword [eax+ebp-0x24] */
            ii(0x100f_2273, 5); mov(eax, 0xc8);                         /* mov eax, 0xc8 */
            ii(0x100f_2278, 1); push(eax);                              /* push eax */
            ii(0x100f_2279, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100f_227c, 1); push(eax);                              /* push eax */
            ii(0x100f_227d, 5); call(0x1014_2037, 0x4_fdb5);            /* call 0x10142037 */
            ii(0x100f_2282, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x100f_2285, 2); jmp(0x100f_22c0, 0x39); goto l_0x100f_22c0; /* jmp 0x100f22c0 */
        l_0x100f_2287:
            ii(0x100f_2287, 3); lea(edi, memd[ss, ebp - 48]);           /* lea edi, [ebp-0x30] */
            ii(0x100f_228a, 5); mov(esi, 0x101b_8a94);                  /* mov esi, 0x101b8a94 */
            ii(0x100f_228f, 1); movsd();                                /* movsd */
            ii(0x100f_2290, 1); movsd();                                /* movsd */
            ii(0x100f_2291, 1); movsd();                                /* movsd */
            ii(0x100f_2292, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_2295, 3); push(memd[ds, eax + 23]);               /* push dword [eax+0x17] */
            ii(0x100f_2298, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100f_229b, 3); push(memd[ds, eax + 23]);               /* push dword [eax+0x17] */
            ii(0x100f_229e, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_22a1, 3); mov(eax, memd[ds, eax + 19]);           /* mov eax, [eax+0x13] */
            ii(0x100f_22a4, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_22a7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100f_22aa, 4); push(memd[ds, eax + ebp - 48]);         /* push dword [eax+ebp-0x30] */
            ii(0x100f_22ae, 5); mov(eax, 0xc8);                         /* mov eax, 0xc8 */
            ii(0x100f_22b3, 1); push(eax);                              /* push eax */
            ii(0x100f_22b4, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100f_22b7, 1); push(eax);                              /* push eax */
            ii(0x100f_22b8, 5); call(0x1014_2037, 0x4_fd7a);            /* call 0x10142037 */
            ii(0x100f_22bd, 3); add(esp, 0x14);                         /* add esp, 0x14 */
        l_0x100f_22c0:
            ii(0x100f_22c0, 5); jmp(0x100f_23ad, 0xe8); goto l_0x100f_23ad; /* jmp 0x100f23ad */
        l_0x100f_22c5:
            ii(0x100f_22c5, 3); lea(edx, memd[ss, ebp - 52]);           /* lea edx, [ebp-0x34] */
            ii(0x100f_22c8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_22cb, 5); call(0x1015_0a5f, 0x5_e78f);            /* call 0x10150a5f */
            ii(0x100f_22d0, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100f_22d3, 5); call(Definitions.my_2_get_count, -0x6_6f70); /* call 0x1008b368 */
            ii(0x100f_22d8, 1); cwde();                                 /* cwde */
            ii(0x100f_22d9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_22db, 2); if(jle(0x100f_22e6, 9)) goto l_0x100f_22e6; /* jle 0x100f22e6 */
            ii(0x100f_22dd, 7); mov(memd[ss, ebp - 56], 0);             /* mov dword [ebp-0x38], 0x0 */
            ii(0x100f_22e4, 2); jmp(0x100f_22ff, 0x19); goto l_0x100f_22ff; /* jmp 0x100f22ff */
        l_0x100f_22e6:
            ii(0x100f_22e6, 5); mov(ecx, 0x488);                        /* mov ecx, 0x488 */
            ii(0x100f_22eb, 5); mov(ebx, StringDefinitions.GamemgrCpp4); /* mov ebx, 0x101a2330 */
            ii(0x100f_22f0, 5); mov(edx, StringDefinitions.BuildListGetcountGreater02); /* mov edx, 0x101a233c */
            ii(0x100f_22f5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_22f7, 5); call(Definitions.sys_assert, 0x7_3a96); /* call 0x10165d92 */
            ii(0x100f_22fc, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
        l_0x100f_22ff:
            ii(0x100f_22ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2302, 4); cmp(memb[ds, eax + 61], 0x15);          /* cmp byte [eax+0x3d], 0x15 */
            ii(0x100f_2306, 2); if(jz(0x100f_2311, 9)) goto l_0x100f_2311; /* jz 0x100f2311 */
            ii(0x100f_2308, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_230b, 4); cmp(memb[ds, eax + 61], 0x1f);          /* cmp byte [eax+0x3d], 0x1f */
            ii(0x100f_230f, 2); if(jnz(0x100f_234d, 0x3c)) goto l_0x100f_234d; /* jnz 0x100f234d */
        l_0x100f_2311:
            ii(0x100f_2311, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2314, 3); mov(al, memb[ds, eax + 69]);            /* mov al, [eax+0x45] */
            ii(0x100f_2317, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_231c, 1); push(eax);                              /* push eax */
            ii(0x100f_231d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_231f, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100f_2322, 5); call(0x1008_b228, -0x6_70ff);           /* call 0x1008b228 */
            ii(0x100f_2327, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_232a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_232d, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100f_2333, 5); mov(eax, StringDefinitions.WasBuildingSWithITurnsToCompletion); /* mov eax, 0x101a2356 */
            ii(0x100f_2338, 1); push(eax);                              /* push eax */
            ii(0x100f_2339, 5); mov(eax, 0xc8);                         /* mov eax, 0xc8 */
            ii(0x100f_233e, 1); push(eax);                              /* push eax */
            ii(0x100f_233f, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100f_2342, 1); push(eax);                              /* push eax */
            ii(0x100f_2343, 5); call(0x1014_2037, 0x4_fcef);            /* call 0x10142037 */
            ii(0x100f_2348, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x100f_234b, 2); jmp(0x100f_23a3, 0x56); goto l_0x100f_23a3; /* jmp 0x100f23a3 */
        l_0x100f_234d:
            ii(0x100f_234d, 3); lea(ecx, memd[ss, ebp - 60]);           /* lea ecx, [ebp-0x3c] */
            ii(0x100f_2350, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2353, 5); call(0x1009_c9a0, -0x5_59b8);           /* call 0x1009c9a0 */
            ii(0x100f_2358, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_235b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_235d, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100f_2360, 5); call(0x1008_b228, -0x6_713d);           /* call 0x1008b228 */
            ii(0x100f_2365, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100f_2368, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_236b, 5); call(0x1015_4f88, 0x6_2c18);            /* call 0x10154f88 */
            ii(0x100f_2370, 4); movsx(eax, memw[ss, ebp - 60]);         /* movsx eax, word [ebp-0x3c] */
            ii(0x100f_2374, 1); push(eax);                              /* push eax */
            ii(0x100f_2375, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2377, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100f_237a, 5); call(0x1008_b228, -0x6_7157);           /* call 0x1008b228 */
            ii(0x100f_237f, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_2382, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_2385, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100f_238b, 5); mov(eax, StringDefinitions.CurrentlyBuildingSTurnsToCompletionI); /* mov eax, 0x101a2384 */
            ii(0x100f_2390, 1); push(eax);                              /* push eax */
            ii(0x100f_2391, 5); mov(eax, 0xc8);                         /* mov eax, 0xc8 */
            ii(0x100f_2396, 1); push(eax);                              /* push eax */
            ii(0x100f_2397, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100f_239a, 1); push(eax);                              /* push eax */
            ii(0x100f_239b, 5); call(0x1014_2037, 0x4_fc97);            /* call 0x10142037 */
            ii(0x100f_23a0, 3); add(esp, 0x14);                         /* add esp, 0x14 */
        l_0x100f_23a3:
            ii(0x100f_23a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_23a5, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x100f_23a8, 5); call(0x1008_8b04, -0x6_98a9);           /* call 0x10088b04 */
        l_0x100f_23ad:
            ii(0x100f_23ad, 5); call(0x100c_aa00, -0x2_79b2);           /* call 0x100caa00 */
            ii(0x100f_23b2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_23b7, 1); push(eax);                              /* push eax */
            ii(0x100f_23b8, 5); call(0x100c_aa20, -0x2_799d);           /* call 0x100caa20 */
            ii(0x100f_23bd, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_23bf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_23c1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_23c3, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100f_23c6, 5); call(Definitions.my_strobj_c_str_v2, -0x6_8c03); /* call 0x100897c8 */
            ii(0x100f_23cb, 5); call(0x1011_5d23, 0x2_3953);            /* call 0x10115d23 */
            ii(0x100f_23d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_23d2, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100f_23d5, 5); call(Definitions.my_string_dtor, 0x4_f750); /* call 0x10141b2a */
            ii(0x100f_23da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_23dc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_23dd, 1); pop(edi);                               /* pop edi */
            ii(0x100f_23de, 1); pop(esi);                               /* pop esi */
            ii(0x100f_23df, 1); pop(edx);                               /* pop edx */
            ii(0x100f_23e0, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_23e1, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_23e2, 1); ret();                                  /* ret */
        }
    }
}
