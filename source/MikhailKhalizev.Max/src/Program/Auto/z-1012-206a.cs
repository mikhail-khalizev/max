using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_206a-cccac87")]
        public void Method_1012_206a()
        {
            ii(0x1012_206a, 5); push(0x6c);                             /* push 0x6c */
            ii(0x1012_206f, 5); call(Definitions.sys_check_available_stack_size, 0x4_3cde); /* call 0x10165d52 */
            ii(0x1012_2074, 1); push(esi);                              /* push esi */
            ii(0x1012_2075, 1); push(edi);                              /* push edi */
            ii(0x1012_2076, 1); push(ebp);                              /* push ebp */
            ii(0x1012_2077, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_2079, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1012_207f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_2082, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1012_2085, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1012_2088, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1012_208b, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_208f, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2092, 6); mov(al, memb[ds, eax + 0x101b_b061]);   /* mov al, [eax+0x101bb061] */
            ii(0x1012_2098, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1012_209b, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1012_209e, 5); call(0x1012_336c, 0x12c9);              /* call 0x1012336c */
            ii(0x1012_20a3, 1); push(eax);                              /* push eax */
            ii(0x1012_20a4, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_20a9, 1); push(eax);                              /* push eax */
            ii(0x1012_20aa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_20ac, 1); push(eax);                              /* push eax */
            ii(0x1012_20ad, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_20b2, 1); push(eax);                              /* push eax */
            ii(0x1012_20b3, 5); mov(eax, 0xb9);                         /* mov eax, 0xb9 */
            ii(0x1012_20b8, 1); push(eax);                              /* push eax */
            ii(0x1012_20b9, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1012_20bd, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1012_20c1, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_20c5, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_20c8, 6); mov(edx, memd[ds, eax + 0x101b_b05d]);  /* mov edx, [eax+0x101bb05d] */
            ii(0x1012_20ce, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_20d1, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1012_20d4, 5); call(0x100e_ab9d, -0x3_753c);           /* call 0x100eab9d */
            ii(0x1012_20d9, 5); mov(eax, 0x183);                        /* mov eax, 0x183 */
            ii(0x1012_20de, 5); call(Definitions.my_get_res_data_by_id, 0x1_1ef5); /* call 0x10133fd8 */
            ii(0x1012_20e3, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1012_20e6, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1012_20e9, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1012_20ec, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1012_20ef, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_20f3, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_20f6, 6); mov(eax, memd[ds, eax + 0x101b_b05d]);  /* mov eax, [eax+0x101bb05d] */
            ii(0x1012_20fc, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x1012_2102, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x1012_2105, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1012_210a, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1012_210d, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1012_2110, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1012_2112, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_2115, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_211a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_211c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_211e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_2120, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_2123, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_2125, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_2127, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1012_212b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_212d, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_2130, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_2133, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1012_2136, 1); push(eax);                              /* push eax */
            ii(0x1012_2137, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_213c, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1012_2140, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_2144, 5); mov(eax, 0x183);                        /* mov eax, 0x183 */
            ii(0x1012_2149, 5); call(0x100e_8ef1, -0x3_925d);           /* call 0x100e8ef1 */
            ii(0x1012_214e, 4); add(memd[ss, ebp - 0x28], -0xa /* 0xf6 */); /* add dword [ebp-0x28], 0xfffffff6 */
            ii(0x1012_2152, 4); add(memd[ss, ebp - 0x24], 0x14);        /* add dword [ebp-0x24], 0x14 */
            ii(0x1012_2156, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1012_215b, 5); call(Definitions.sys_new, 0x4_3ca0);    /* call 0x10165e00 */
            ii(0x1012_2160, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1012_2163, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1012_2166, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1012_2169, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1012_216d, 2); if(jz(0x1012_2194, 0x25)) goto l_0x1012_2194; /* jz 0x10122194 */
            ii(0x1012_216f, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_2174, 1); push(eax);                              /* push eax */
            ii(0x1012_2175, 4); movsx(ecx, memw[ss, ebp - 0x24]);       /* movsx ecx, word [ebp-0x24] */
            ii(0x1012_2179, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_217d, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_2181, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1012_2184, 5); call(0x100d_7bdc, -0x4_a5ad);           /* call 0x100d7bdc */
            ii(0x1012_2189, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1012_218c, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1012_218f, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1012_2192, 2); jmp(0x1012_219a, 0x6); goto l_0x1012_219a; /* jmp 0x1012219a */
        l_0x1012_2194:
            ii(0x1012_2194, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1012_2197, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x1012_219a:
            ii(0x1012_219a, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1012_219e, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
            ii(0x1012_21a1, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1012_21a4, 6); mov(memd[ds, edx + 0x101b_b06c], eax);  /* mov [edx+0x101bb06c], eax */
            ii(0x1012_21aa, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_21ad, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_21b0, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_21b4, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_21b7, 6); mov(eax, memd[ds, eax + 0x101b_b06c]);  /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_21bd, 5); call(0x100d_7d74, -0x4_a44e);           /* call 0x100d7d74 */
            ii(0x1012_21c2, 4); movsx(eax, memb[ss, ebp - 0x14]);       /* movsx eax, byte [ebp-0x14] */
            ii(0x1012_21c6, 5); call(0x1007_5fdc, -0xa_c1ef);           /* call 0x10075fdc */
            ii(0x1012_21cb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_21ce, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1012_21d2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_21d5, 5); call(0x1012_245e, 0x284);               /* call 0x1012245e */
            ii(0x1012_21da, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_21df, 5); call(Definitions.sys_new, 0x4_3c1c);    /* call 0x10165e00 */
            ii(0x1012_21e4, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1012_21e7, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1012_21ea, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1012_21ed, 4); cmp(memd[ss, ebp - 0x40], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1012_21f1, 2); if(jz(0x1012_2218, 0x25)) goto l_0x1012_2218; /* jz 0x10122218 */
            ii(0x1012_21f3, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1012_21f8, 1); push(eax);                              /* push eax */
            ii(0x1012_21f9, 4); movsx(ecx, memw[ss, ebp - 0x24]);       /* movsx ecx, word [ebp-0x24] */
            ii(0x1012_21fd, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_2201, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1012_2205, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1012_2208, 5); call(0x100c_e39d, -0x5_3e70);           /* call 0x100ce39d */
            ii(0x1012_220d, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1012_2210, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1012_2213, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1012_2216, 2); jmp(0x1012_221e, 0x6); goto l_0x1012_221e; /* jmp 0x1012221e */
        l_0x1012_2218:
            ii(0x1012_2218, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1012_221b, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
        l_0x1012_221e:
            ii(0x1012_221e, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1012_2222, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
            ii(0x1012_2225, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1012_2228, 6); mov(memd[ds, edx + 0x101b_b068], eax);  /* mov [edx+0x101bb068], eax */
            ii(0x1012_222e, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1012_2232, 6); add(edx, 0x3ea);                        /* add edx, 0x3ea */
            ii(0x1012_2238, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_223c, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_223f, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_2245, 5); call(0x100d_5164, -0x4_d0e6);           /* call 0x100d5164 */
            ii(0x1012_224a, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_224f, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_2253, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2256, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_225c, 5); call(0x100d_50d4, -0x4_d18d);           /* call 0x100d50d4 */
            ii(0x1012_2261, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_2264, 3); mov(edx, memd[ds, eax + 0x29]);         /* mov edx, [eax+0x29] */
            ii(0x1012_2267, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_226b, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_226e, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_2274, 5); call(0x100c_f85c, -0x5_2a1d);           /* call 0x100cf85c */
            ii(0x1012_2279, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_227b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_227c, 1); pop(edi);                               /* pop edi */
            ii(0x1012_227d, 1); pop(esi);                               /* pop esi */
            ii(0x1012_227e, 1); ret();                                  /* ret */
        }
    }
}
