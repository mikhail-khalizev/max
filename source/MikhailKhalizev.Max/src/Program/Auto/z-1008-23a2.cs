using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_23a2-bab5100c")]
        public void Method_1008_23a2()
        {
            ii(0x1008_23a2, 5); push(0x30);                             /* push 0x30 */
            ii(0x1008_23a7, 5); call(Definitions.sys_check_available_stack_size, 0xe_39a6); /* call 0x10165d52 */
            ii(0x1008_23ac, 1); push(ebx);                              /* push ebx */
            ii(0x1008_23ad, 1); push(ecx);                              /* push ecx */
            ii(0x1008_23ae, 1); push(edx);                              /* push edx */
            ii(0x1008_23af, 1); push(esi);                              /* push esi */
            ii(0x1008_23b0, 1); push(edi);                              /* push edi */
            ii(0x1008_23b1, 1); push(ebp);                              /* push ebp */
            ii(0x1008_23b2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_23b4, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_23ba, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_23bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_23c0, 5); call(0x1008_61ff, 0x3e3a);              /* call 0x100861ff */
            ii(0x1008_23c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_23c7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_23ca, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_23cd, 5); call(0x1013_ad71, 0xb_899f);            /* call 0x1013ad71 */
            ii(0x1008_23d2, 2); test(al, al);                           /* test al, al */
            ii(0x1008_23d4, 2); if(jz(0x1008_23ed, 0x17)) goto l_0x1008_23ed; /* jz 0x100823ed */
            ii(0x1008_23d6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_23d9, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_23dc, 5); call(0x1007_6574, -0xbe6d);             /* call 0x10076574 */
            ii(0x1008_23e1, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1008_23e4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_23e9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_23eb, 2); if(jnz(0x1008_23ef, 2)) goto l_0x1008_23ef; /* jnz 0x100823ef */
        l_0x1008_23ed:
            ii(0x1008_23ed, 2); jmp(0x1008_2404, 0x15); goto l_0x1008_2404; /* jmp 0x10082404 */
        l_0x1008_23ef:
            ii(0x1008_23ef, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_23f4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_23f7, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_23fa, 5); call(0x1007_65d0, -0xbe2f);             /* call 0x100765d0 */
            ii(0x1008_23ff, 5); call(0x100a_297d, 0x2_0579);            /* call 0x100a297d */
        l_0x1008_2404:
            ii(0x1008_2404, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_2407, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_240a, 5); call(0x1008_9d08, 0x78f9);              /* call 0x10089d08 */
            ii(0x1008_240f, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x1008_2412, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2414, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_2416, 5); call(0x1008_9be4, 0x77c9);              /* call 0x10089be4 */
            ii(0x1008_241b, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_241f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2422, 5); call(0x1007_64fc, -0xbf2b);             /* call 0x100764fc */
            ii(0x1008_2427, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_242a, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x1008_242e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2430, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_2433, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_2436, 5); call(0x1013_ad71, 0xb_8936);            /* call 0x1013ad71 */
            ii(0x1008_243b, 2); test(al, al);                           /* test al, al */
            ii(0x1008_243d, 6); if(jz(0x1008_24ce, 0x8b)) goto l_0x1008_24ce; /* jz 0x100824ce */
            ii(0x1008_2443, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_2446, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_2449, 5); call(0x1008_9970, 0x7522);              /* call 0x10089970 */
            ii(0x1008_244e, 5); call(0x1008_9a74, 0x7621);              /* call 0x10089a74 */
            ii(0x1008_2453, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2455, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2458, 5); call(0x1007_643c, -0xc021);             /* call 0x1007643c */
            ii(0x1008_245d, 2); jmp(0x1008_2467, 8); goto l_0x1008_2467; /* jmp 0x10082467 */
        l_0x1008_245f:
            ii(0x1008_245f, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2462, 5); call(0x1007_6bf8, -0xb86f);             /* call 0x10076bf8 */
        l_0x1008_2467:
            ii(0x1008_2467, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2469, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_246c, 5); call(0x1013_ad71, 0xb_8900);            /* call 0x1013ad71 */
            ii(0x1008_2471, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2473, 2); if(jz(0x1008_24ce, 0x59)) goto l_0x1008_24ce; /* jz 0x100824ce */
            ii(0x1008_2475, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2478, 5); call(0x1007_63a0, -0xc0dd);             /* call 0x100763a0 */
            ii(0x1008_247d, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1008_2480, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_2485, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2487, 2); if(jle(0x1008_249a, 0x11)) goto l_0x1008_249a; /* jle 0x1008249a */
            ii(0x1008_2489, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_248c, 5); call(0x1007_63d4, -0xc0bd);             /* call 0x100763d4 */
            ii(0x1008_2491, 5); call(0x100a_2edb, 0x2_0a45);            /* call 0x100a2edb */
            ii(0x1008_2496, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2498, 2); if(jnz(0x1008_249c, 2)) goto l_0x1008_249c; /* jnz 0x1008249c */
        l_0x1008_249a:
            ii(0x1008_249a, 2); jmp(0x1008_24b8, 0x1c); goto l_0x1008_24b8; /* jmp 0x100824b8 */
        l_0x1008_249c:
            ii(0x1008_249c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_249f, 3); add(edx, 0x2e);                         /* add edx, 0x2e */
            ii(0x1008_24a2, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_24a5, 5); call(0x1007_63a0, -0xc10a);             /* call 0x100763a0 */
            ii(0x1008_24aa, 5); call(0x1015_26ac, 0xd_01fd);            /* call 0x101526ac */
            ii(0x1008_24af, 5); call(0x1007_6d98, -0xb71c);             /* call 0x10076d98 */
            ii(0x1008_24b4, 2); test(al, al);                           /* test al, al */
            ii(0x1008_24b6, 2); if(jnz(0x1008_24ba, 2)) goto l_0x1008_24ba; /* jnz 0x100824ba */
        l_0x1008_24b8:
            ii(0x1008_24b8, 2); jmp(0x1008_24cc, 0x12); goto l_0x1008_24cc; /* jmp 0x100824cc */
        l_0x1008_24ba:
            ii(0x1008_24ba, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_24bf, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_24c2, 5); call(0x1007_63d4, -0xc0f3);             /* call 0x100763d4 */
            ii(0x1008_24c7, 5); call(0x100a_297d, 0x2_04b1);            /* call 0x100a297d */
        l_0x1008_24cc:
            ii(0x1008_24cc, 2); jmp(0x1008_245f, -0x6f); goto l_0x1008_245f; /* jmp 0x1008245f */
        l_0x1008_24ce:
            ii(0x1008_24ce, 2); jmp(0x1008_24d8, 8); goto l_0x1008_24d8; /* jmp 0x100824d8 */
        l_0x1008_24d0:
            ii(0x1008_24d0, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_24d3, 5); call(0x1007_6bf8, -0xb8e0);             /* call 0x10076bf8 */
        l_0x1008_24d8:
            ii(0x1008_24d8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_24da, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_24dd, 5); call(0x1013_ad71, 0xb_888f);            /* call 0x1013ad71 */
            ii(0x1008_24e2, 2); test(al, al);                           /* test al, al */
            ii(0x1008_24e4, 6); if(jz(0x1008_2576, 0x8c)) goto l_0x1008_2576; /* jz 0x10082576 */
            ii(0x1008_24ea, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_24ed, 5); call(0x1008_9acc, 0x75da);              /* call 0x10089acc */
            ii(0x1008_24f2, 5); call(0x1008_9fc4, 0x7acd);              /* call 0x10089fc4 */
            ii(0x1008_24f7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_24f9, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_24fc, 5); call(0x1007_643c, -0xc0c5);             /* call 0x1007643c */
            ii(0x1008_2501, 2); jmp(0x1008_250b, 8); goto l_0x1008_250b; /* jmp 0x1008250b */
        l_0x1008_2503:
            ii(0x1008_2503, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2506, 5); call(0x1007_6bf8, -0xb913);             /* call 0x10076bf8 */
        l_0x1008_250b:
            ii(0x1008_250b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_250d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2510, 5); call(0x1013_ad71, 0xb_885c);            /* call 0x1013ad71 */
            ii(0x1008_2515, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2517, 2); if(jz(0x1008_2571, 0x58)) goto l_0x1008_2571; /* jz 0x10082571 */
            ii(0x1008_2519, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_251c, 5); call(0x1007_63a0, -0xc181);             /* call 0x100763a0 */
            ii(0x1008_2521, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1008_2524, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_2529, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_252b, 2); if(jle(0x1008_253e, 0x11)) goto l_0x1008_253e; /* jle 0x1008253e */
            ii(0x1008_252d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2530, 5); call(0x1007_63d4, -0xc161);             /* call 0x100763d4 */
            ii(0x1008_2535, 5); call(0x100a_2edb, 0x2_09a1);            /* call 0x100a2edb */
            ii(0x1008_253a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_253c, 2); if(jnz(0x1008_2540, 2)) goto l_0x1008_2540; /* jnz 0x10082540 */
        l_0x1008_253e:
            ii(0x1008_253e, 2); jmp(0x1008_255b, 0x1b); goto l_0x1008_255b; /* jmp 0x1008255b */
        l_0x1008_2540:
            ii(0x1008_2540, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2543, 5); call(0x1007_63a0, -0xc1a8);             /* call 0x100763a0 */
            ii(0x1008_2548, 5); call(0x1015_26ac, 0xd_015f);            /* call 0x101526ac */
            ii(0x1008_254d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_254f, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_2552, 5); call(0x1008_9b34, 0x75dd);              /* call 0x10089b34 */
            ii(0x1008_2557, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_2559, 2); if(jz(0x1008_255d, 2)) goto l_0x1008_255d; /* jz 0x1008255d */
        l_0x1008_255b:
            ii(0x1008_255b, 2); jmp(0x1008_256f, 0x12); goto l_0x1008_256f; /* jmp 0x1008256f */
        l_0x1008_255d:
            ii(0x1008_255d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1008_2562, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_2565, 5); call(0x1007_63d4, -0xc196);             /* call 0x100763d4 */
            ii(0x1008_256a, 5); call(0x100a_297d, 0x2_040e);            /* call 0x100a297d */
        l_0x1008_256f:
            ii(0x1008_256f, 2); jmp(0x1008_2503, -0x6e); goto l_0x1008_2503; /* jmp 0x10082503 */
        l_0x1008_2571:
            ii(0x1008_2571, 5); jmp(0x1008_24d0, -0xa6); goto l_0x1008_24d0; /* jmp 0x100824d0 */
        l_0x1008_2576:
            ii(0x1008_2576, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2578, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_257b, 5); call(0x1007_5f6c, -0xc614);             /* call 0x10075f6c */
            ii(0x1008_2580, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2582, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_2585, 5); call(0x1008_9044, 0x6aba);              /* call 0x10089044 */
            ii(0x1008_258a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_258c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_258d, 1); pop(edi);                               /* pop edi */
            ii(0x1008_258e, 1); pop(esi);                               /* pop esi */
            ii(0x1008_258f, 1); pop(edx);                               /* pop edx */
            ii(0x1008_2590, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_2591, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_2592, 1); ret();                                  /* ret */
        }
    }
}
