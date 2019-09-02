using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_2139-598379b7")]
        public void Method_1009_2139()
        {
            ii(0x1009_2139, 5); push(0x9c);                             /* push 0x9c */
            ii(0x1009_213e, 5); call(Definitions.sys_check_available_stack_size, 0xd_3c0f); /* call 0x10165d52 */
            ii(0x1009_2143, 1); push(ecx);                              /* push ecx */
            ii(0x1009_2144, 1); push(esi);                              /* push esi */
            ii(0x1009_2145, 1); push(edi);                              /* push edi */
            ii(0x1009_2146, 1); push(ebp);                              /* push ebp */
            ii(0x1009_2147, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_2149, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x1009_214f, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_2152, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_2155, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1009_2158, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1009_215b, 5); call(Definitions.my_ctor_0x101b_4184, -0x1_b670); /* call 0x10076af0 */
            ii(0x1009_2160, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1009_2165, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2168, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_216b, 5); call(Definitions.sys_new_arr, 0xd_3ea0); /* call 0x10166010 */
            ii(0x1009_2170, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1009_2173, 4); mov(memb[ss, ebp - 28], 0);             /* mov byte [ebp-0x1c], 0x0 */
            ii(0x1009_2177, 4); mov(memb[ss, ebp - 27], 0);             /* mov byte [ebp-0x1b], 0x0 */
            ii(0x1009_217b, 4); mov(memb[ss, ebp - 26], 0);             /* mov byte [ebp-0x1a], 0x0 */
            ii(0x1009_217f, 4); mov(memb[ss, ebp - 25], 0);             /* mov byte [ebp-0x19], 0x0 */
            ii(0x1009_2183, 6); mov(memw[ss, ebp - 20], 0);             /* mov word [ebp-0x14], 0x0 */
            ii(0x1009_2189, 2); jmp(0x1009_2192, 7); goto l_0x1009_2192; /* jmp 0x10092192 */
        l_0x1009_218b:
            ii(0x1009_218b, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_218e, 4); inc(memw[ss, ebp - 20]);                /* inc word [ebp-0x14] */
        l_0x1009_2192:
            ii(0x1009_2192, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_2195, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1009_219c, 6); if(jge(0x1009_2217, 0x75)) goto l_0x1009_2217; /* jge 0x10092217 */
            ii(0x1009_21a2, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1009_21a7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_21aa, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_21ad, 5); call(Definitions.sys_new_arr, 0xd_3e5e); /* call 0x10166010 */
            ii(0x1009_21b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_21b4, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1009_21b8, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_21bb, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1009_21be, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1009_21c0, 6); mov(memw[ss, ebp - 18], 0);             /* mov word [ebp-0x12], 0x0 */
            ii(0x1009_21c6, 2); jmp(0x1009_21cf, 7); goto l_0x1009_21cf; /* jmp 0x100921cf */
        l_0x1009_21c8:
            ii(0x1009_21c8, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x1009_21cb, 4); inc(memw[ss, ebp - 18]);                /* inc word [ebp-0x12] */
        l_0x1009_21cf:
            ii(0x1009_21cf, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x1009_21d2, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1009_21d9, 2); if(jge(0x1009_2212, 0x37)) goto l_0x1009_2212; /* jge 0x10092212 */
            ii(0x1009_21db, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1009_21df, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_21e2, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1009_21e5, 4); movsx(edx, memw[ss, ebp - 18]);         /* movsx edx, word [ebp-0x12] */
            ii(0x1009_21e9, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_21eb, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_21ed, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_21ef, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_21f2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_21f4, 2); if(jnz(0x1009_2210, 0x1a)) goto l_0x1009_2210; /* jnz 0x10092210 */
            ii(0x1009_21f6, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1009_21fa, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_21fd, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1009_2200, 4); movsx(edx, memw[ss, ebp - 18]);         /* movsx edx, word [ebp-0x12] */
            ii(0x1009_2204, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1009_2207, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_2209, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_220b, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1009_220e, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
        l_0x1009_2210:
            ii(0x1009_2210, 2); jmp(0x1009_21c8, -0x4a); goto l_0x1009_21c8; /* jmp 0x100921c8 */
        l_0x1009_2212:
            ii(0x1009_2212, 5); jmp(0x1009_218b, -0x8c); goto l_0x1009_218b; /* jmp 0x1009218b */
        l_0x1009_2217:
            ii(0x1009_2217, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1009_221e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_2221, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1009_2224, 5); call(0x1009_07fa, -0x1a2f);             /* call 0x100907fa */
            ii(0x1009_2229, 6); mov(memw[ss, ebp - 20], 0);             /* mov word [ebp-0x14], 0x0 */
            ii(0x1009_222f, 2); jmp(0x1009_2238, 7); goto l_0x1009_2238; /* jmp 0x10092238 */
        l_0x1009_2231:
            ii(0x1009_2231, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_2234, 4); inc(memw[ss, ebp - 20]);                /* inc word [ebp-0x14] */
        l_0x1009_2238:
            ii(0x1009_2238, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_223b, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1009_2242, 6); if(jge(0x1009_22f7, 0xaf)) goto l_0x1009_22f7; /* jge 0x100922f7 */
            ii(0x1009_2248, 6); mov(memw[ss, ebp - 18], 0);             /* mov word [ebp-0x12], 0x0 */
            ii(0x1009_224e, 2); jmp(0x1009_2257, 7); goto l_0x1009_2257; /* jmp 0x10092257 */
        l_0x1009_2250:
            ii(0x1009_2250, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x1009_2253, 4); inc(memw[ss, ebp - 18]);                /* inc word [ebp-0x12] */
        l_0x1009_2257:
            ii(0x1009_2257, 3); mov(eax, memd[ss, ebp - 18]);           /* mov eax, [ebp-0x12] */
            ii(0x1009_225a, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1009_2261, 6); if(jge(0x1009_22f2, 0x8b)) goto l_0x1009_22f2; /* jge 0x100922f2 */
            ii(0x1009_2267, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1009_226b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_226e, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1009_2271, 4); movsx(edx, memw[ss, ebp - 18]);         /* movsx edx, word [ebp-0x12] */
            ii(0x1009_2275, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_2277, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_2279, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_227b, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_227e, 3); cmp(eax, 9);                            /* cmp eax, 0x9 */
            ii(0x1009_2281, 2); if(jnz(0x1009_22ed, 0x6a)) goto l_0x1009_22ed; /* jnz 0x100922ed */
            ii(0x1009_2283, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_2286, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
            ii(0x1009_2289, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_228c, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1009_2291, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_2294, 3); lea(edx, memd[ss, ebp - 20]);           /* lea edx, [ebp-0x14] */
            ii(0x1009_2297, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1009_229a, 5); call(0x1007_5e64, -0x1_c43b);           /* call 0x10075e64 */
            ii(0x1009_229f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_22a1, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1009_22a4, 5); call(0x1009_0872, -0x1a37);             /* call 0x10090872 */
            ii(0x1009_22a9, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1009_22ac, 5); call(0x1009_c390, 0xa0df);              /* call 0x1009c390 */
            ii(0x1009_22b1, 3); lea(edi, memd[ss, ebp - 96]);           /* lea edi, [ebp-0x60] */
            ii(0x1009_22b4, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1009_22b6, 1); movsd();                                /* movsd */
            ii(0x1009_22b7, 1); movsd();                                /* movsd */
            ii(0x1009_22b8, 1); movsd();                                /* movsd */
            ii(0x1009_22b9, 1); movsd();                                /* movsd */
            ii(0x1009_22ba, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1009_22be, 1); push(eax);                              /* push eax */
            ii(0x1009_22bf, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_22c2, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1009_22c7, 1); cwde();                                 /* cwde */
            ii(0x1009_22c8, 1); push(eax);                              /* push eax */
            ii(0x1009_22c9, 3); lea(edi, memd[ss, ebp - 112]);          /* lea edi, [ebp-0x70] */
            ii(0x1009_22cc, 3); lea(esi, memd[ss, ebp - 96]);           /* lea esi, [ebp-0x60] */
            ii(0x1009_22cf, 1); movsd();                                /* movsd */
            ii(0x1009_22d0, 1); movsd();                                /* movsd */
            ii(0x1009_22d1, 1); movsd();                                /* movsd */
            ii(0x1009_22d2, 1); movsd();                                /* movsd */
            ii(0x1009_22d3, 3); push(memd[ss, ebp - 100]);              /* push dword [ebp-0x64] */
            ii(0x1009_22d6, 3); push(memd[ss, ebp - 104]);              /* push dword [ebp-0x68] */
            ii(0x1009_22d9, 3); push(memd[ss, ebp - 108]);              /* push dword [ebp-0x6c] */
            ii(0x1009_22dc, 3); push(memd[ss, ebp - 112]);              /* push dword [ebp-0x70] */
            ii(0x1009_22df, 3); mov(ebx, memd[ss, ebp - 24]);           /* mov ebx, [ebp-0x18] */
            ii(0x1009_22e2, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_22e5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_22e8, 5); call(0x1009_1f13, -0x3da);              /* call 0x10091f13 */
        l_0x1009_22ed:
            ii(0x1009_22ed, 5); jmp(0x1009_2250, -0xa2); goto l_0x1009_2250; /* jmp 0x10092250 */
        l_0x1009_22f2:
            ii(0x1009_22f2, 5); jmp(0x1009_2231, -0xc6); goto l_0x1009_2231; /* jmp 0x10092231 */
        l_0x1009_22f7:
            ii(0x1009_22f7, 6); mov(memw[ss, ebp - 20], 0);             /* mov word [ebp-0x14], 0x0 */
            ii(0x1009_22fd, 2); jmp(0x1009_2306, 7); goto l_0x1009_2306; /* jmp 0x10092306 */
        l_0x1009_22ff:
            ii(0x1009_22ff, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_2302, 4); inc(memw[ss, ebp - 20]);                /* inc word [ebp-0x14] */
        l_0x1009_2306:
            ii(0x1009_2306, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_2309, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1009_2310, 2); if(jge(0x1009_2325, 0x13)) goto l_0x1009_2325; /* jge 0x10092325 */
            ii(0x1009_2312, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1009_2316, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1009_2319, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1009_231c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_231e, 5); call(Definitions.sys_delete, 0xd_3c41); /* call 0x10165f64 */
            ii(0x1009_2323, 2); jmp(0x1009_22ff, -0x26); goto l_0x1009_22ff; /* jmp 0x100922ff */
        l_0x1009_2325:
            ii(0x1009_2325, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1009_2328, 5); call(Definitions.sys_delete, 0xd_3c37); /* call 0x10165f64 */
            ii(0x1009_232d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_232f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_2330, 1); pop(edi);                               /* pop edi */
            ii(0x1009_2331, 1); pop(esi);                               /* pop esi */
            ii(0x1009_2332, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_2333, 1); ret();                                  /* ret */
        }
    }
}
