using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_22fd-6b15a19b")]
        public void Method_100c_22fd()
        {
            ii(0x100c_22fd, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100c_2302, 5); calld(Definitions.sys_check_available_stack_size, 0xa_3a4b); /* call 0x10165d52 */
            ii(0x100c_2307, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_2308, 1); pushd(esi);                             /* push esi */
            ii(0x100c_2309, 1); pushd(edi);                             /* push edi */
            ii(0x100c_230a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_230b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_230d, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100c_2313, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_2316, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_2319, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_231c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_231f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_2322, 5); jmpd(0x100c_262e, 0x307); goto l_0x100c_262e; /* jmp 0x100c262e */
        l_0x100c_2327:
            ii(0x100c_2327, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_232a, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100c_232d, 5); calld(0x100c_b000, 0x8cce);             /* call 0x100cb000 */
            ii(0x100c_2332, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x100c_2335, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_2337, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_2339, 5); calld(0x1008_a1a4, -0x3_819a);          /* call 0x1008a1a4 */
            ii(0x100c_233e, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x100c_2342, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_2345, 5); calld(0x1008_8a08, -0x3_9942);          /* call 0x10088a08 */
            ii(0x100c_234a, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_234d, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100c_2351, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2354, 6); add(edx, 0x91);                         /* add edx, 0x91 */
            ii(0x100c_235a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_235d, 5); calld(0x100b_8583, -0x9ddf);            /* call 0x100b8583 */
            ii(0x100c_2362, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2365, 6); add(edx, 0x99);                         /* add edx, 0x99 */
            ii(0x100c_236b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_236e, 5); calld(0x100b_8583, -0x9df0);            /* call 0x100b8583 */
            ii(0x100c_2373, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2376, 6); add(edx, 0xa9);                         /* add edx, 0xa9 */
            ii(0x100c_237c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_237f, 5); calld(0x100b_8583, -0x9e01);            /* call 0x100b8583 */
            ii(0x100c_2384, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100c_2389, 5); calld(0x1007_5fdc, -0x4_c3b2);          /* call 0x10075fdc */
            ii(0x100c_238e, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100c_2391, 2); if(jld(0x100c_23a4, 0x11)) goto l_0x100c_23a4; /* jl 0x100c23a4 */
            ii(0x100c_2393, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2396, 6); add(edx, 0xb9);                         /* add edx, 0xb9 */
            ii(0x100c_239c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_239f, 5); calld(0x100b_8583, -0x9e21);            /* call 0x100b8583 */
        l_0x100c_23a4:
            ii(0x100c_23a4, 2); jmpd(0x100c_23ae, 0x8); goto l_0x100c_23ae; /* jmp 0x100c23ae */
        l_0x100c_23a6:
            ii(0x100c_23a6, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_23a9, 5); calld(0x1007_6bf8, -0x4_b7b6);          /* call 0x10076bf8 */
        l_0x100c_23ae:
            ii(0x100c_23ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_23b0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_23b3, 5); calld(0x1013_ad71, 0x7_89b9);           /* call 0x1013ad71 */
            ii(0x100c_23b8, 2); test(al, al);                           /* test al, al */
            ii(0x100c_23ba, 2); if(jzd(0x100c_23f0, 0x34)) goto l_0x100c_23f0; /* jz 0x100c23f0 */
            ii(0x100c_23bc, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_23bf, 5); calld(0x1008_a0f8, -0x3_82cc);          /* call 0x1008a0f8 */
            ii(0x100c_23c4, 5); calld(0x1008_a370, -0x3_8059);          /* call 0x1008a370 */
            ii(0x100c_23c9, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x100c_23cc, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_23cf, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100c_23d2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_23d5, 5); calld(0x100c_22fd, -0xdd);              /* call 0x100c22fd */
            ii(0x100c_23da, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_23dc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_23df, 5); calld(0x100b_8583, -0x9e61);            /* call 0x100b8583 */
            ii(0x100c_23e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_23e6, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_23e9, 5); calld(0x1008_8dcc, -0x3_9622);          /* call 0x10088dcc */
            ii(0x100c_23ee, 2); jmpd(0x100c_23a6, -0x4a); goto l_0x100c_23a6; /* jmp 0x100c23a6 */
        l_0x100c_23f0:
            ii(0x100c_23f0, 5); calld(0x1008_a4dc, -0x3_7f19);          /* call 0x1008a4dc */
            ii(0x100c_23f5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_23f7, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_23f9, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100c_23fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_23ff, 5); calld(0x100b_8505, -0x9eff);            /* call 0x100b8505 */
            ii(0x100c_2404, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_2406, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_2409, 5); calld(0x1008_8dcc, -0x3_9642);          /* call 0x10088dcc */
            ii(0x100c_240e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_2410, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_2413, 5); calld(0x1008_8e4c, -0x3_95cc);          /* call 0x10088e4c */
            ii(0x100c_2418, 5); jmpd(0x100c_27e6, 0x3c9); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_241d:
            ii(0x100c_241d, 5); calld(0x1008_a4dc, -0x3_7f46);          /* call 0x1008a4dc */
            ii(0x100c_2422, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2424, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2426, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2429, 6); add(edx, 0x81);                         /* add edx, 0x81 */
            ii(0x100c_242f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2432, 5); calld(0x100b_8505, -0x9f32);            /* call 0x100b8505 */
            ii(0x100c_2437, 5); jmpd(0x100c_27e6, 0x3aa); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_243c:
            ii(0x100c_243c, 5); calld(0x1008_a4dc, -0x3_7f65);          /* call 0x1008a4dc */
            ii(0x100c_2441, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2443, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2445, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2448, 6); add(edx, 0x85);                         /* add edx, 0x85 */
            ii(0x100c_244e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2451, 5); calld(0x100b_8505, -0x9f51);            /* call 0x100b8505 */
            ii(0x100c_2456, 5); jmpd(0x100c_27e6, 0x38b); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_245b:
            ii(0x100c_245b, 5); calld(0x1008_a4dc, -0x3_7f84);          /* call 0x1008a4dc */
            ii(0x100c_2460, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2462, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2464, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2467, 6); add(edx, 0x89);                         /* add edx, 0x89 */
            ii(0x100c_246d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2470, 5); calld(0x100b_8505, -0x9f70);            /* call 0x100b8505 */
            ii(0x100c_2475, 5); jmpd(0x100c_27e6, 0x36c); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_247a:
            ii(0x100c_247a, 5); calld(0x1008_a4dc, -0x3_7fa3);          /* call 0x1008a4dc */
            ii(0x100c_247f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2481, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2483, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2486, 3); add(edx, 0x7d);                         /* add edx, 0x7d */
            ii(0x100c_2489, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_248c, 5); calld(0x100b_8505, -0x9f8c);            /* call 0x100b8505 */
            ii(0x100c_2491, 5); jmpd(0x100c_27e6, 0x350); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_2496:
            ii(0x100c_2496, 5); calld(0x1008_a4dc, -0x3_7fbf);          /* call 0x1008a4dc */
            ii(0x100c_249b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_249d, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_249f, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_24a2, 6); add(edx, 0xc1);                         /* add edx, 0xc1 */
            ii(0x100c_24a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_24ab, 5); calld(0x100b_8505, -0x9fab);            /* call 0x100b8505 */
            ii(0x100c_24b0, 5); jmpd(0x100c_27e6, 0x331); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_24b5:
            ii(0x100c_24b5, 5); calld(0x1008_a4dc, -0x3_7fde);          /* call 0x1008a4dc */
            ii(0x100c_24ba, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_24bc, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_24be, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_24c1, 6); add(edx, 0x8d);                         /* add edx, 0x8d */
            ii(0x100c_24c7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_24ca, 5); calld(0x100b_8505, -0x9fca);            /* call 0x100b8505 */
            ii(0x100c_24cf, 5); jmpd(0x100c_27e6, 0x312); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_24d4:
            ii(0x100c_24d4, 5); calld(0x1008_a4dc, -0x3_7ffd);          /* call 0x1008a4dc */
            ii(0x100c_24d9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_24db, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_24dd, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_24e0, 6); add(edx, 0xb1);                         /* add edx, 0xb1 */
            ii(0x100c_24e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_24e9, 5); calld(0x100b_8505, -0x9fe9);            /* call 0x100b8505 */
            ii(0x100c_24ee, 5); jmpd(0x100c_27e6, 0x2f3); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_24f3:
            ii(0x100c_24f3, 5); calld(0x1008_a4dc, -0x3_801c);          /* call 0x1008a4dc */
            ii(0x100c_24f8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_24fa, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_24fc, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_24ff, 6); add(edx, 0xad);                         /* add edx, 0xad */
            ii(0x100c_2505, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2508, 5); calld(0x100b_8505, -0xa008);            /* call 0x100b8505 */
            ii(0x100c_250d, 5); jmpd(0x100c_27e6, 0x2d4); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_2512:
            ii(0x100c_2512, 5); calld(0x1008_a4dc, -0x3_803b);          /* call 0x1008a4dc */
            ii(0x100c_2517, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2519, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_251b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_251e, 6); add(edx, 0xa9);                         /* add edx, 0xa9 */
            ii(0x100c_2524, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2527, 5); calld(0x100b_8505, -0xa027);            /* call 0x100b8505 */
            ii(0x100c_252c, 5); jmpd(0x100c_27e6, 0x2b5); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_2531:
            ii(0x100c_2531, 5); calld(0x1008_a4dc, -0x3_805a);          /* call 0x1008a4dc */
            ii(0x100c_2536, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2538, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_253a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_253d, 6); add(edx, 0xa1);                         /* add edx, 0xa1 */
            ii(0x100c_2543, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2546, 5); calld(0x100b_8505, -0xa046);            /* call 0x100b8505 */
            ii(0x100c_254b, 5); jmpd(0x100c_27e6, 0x296); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_2550:
            ii(0x100c_2550, 5); calld(0x1008_a4dc, -0x3_8079);          /* call 0x1008a4dc */
            ii(0x100c_2555, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2557, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2559, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_255c, 6); add(edx, 0xb5);                         /* add edx, 0xb5 */
            ii(0x100c_2562, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2565, 5); calld(0x100b_8505, -0xa065);            /* call 0x100b8505 */
            ii(0x100c_256a, 5); jmpd(0x100c_27e6, 0x277); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_256f:
            ii(0x100c_256f, 5); calld(0x1008_a4dc, -0x3_8098);          /* call 0x1008a4dc */
            ii(0x100c_2574, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2576, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2578, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_257b, 6); add(edx, 0xa5);                         /* add edx, 0xa5 */
            ii(0x100c_2581, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2584, 5); calld(0x100b_8505, -0xa084);            /* call 0x100b8505 */
            ii(0x100c_2589, 5); jmpd(0x100c_27e6, 0x258); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_258e:
            ii(0x100c_258e, 5); calld(0x1008_a4dc, -0x3_80b7);          /* call 0x1008a4dc */
            ii(0x100c_2593, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2595, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2597, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_259a, 6); add(edx, 0x91);                         /* add edx, 0x91 */
            ii(0x100c_25a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_25a3, 5); calld(0x100b_8505, -0xa0a3);            /* call 0x100b8505 */
            ii(0x100c_25a8, 5); jmpd(0x100c_27e6, 0x239); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_25ad:
            ii(0x100c_25ad, 5); calld(0x1008_a4dc, -0x3_80d6);          /* call 0x1008a4dc */
            ii(0x100c_25b2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_25b4, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_25b6, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_25b9, 6); add(edx, 0x95);                         /* add edx, 0x95 */
            ii(0x100c_25bf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_25c2, 5); calld(0x100b_8505, -0xa0c2);            /* call 0x100b8505 */
            ii(0x100c_25c7, 5); jmpd(0x100c_27e6, 0x21a); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_25cc:
            ii(0x100c_25cc, 5); calld(0x1008_a4dc, -0x3_80f5);          /* call 0x1008a4dc */
            ii(0x100c_25d1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_25d3, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_25d5, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_25d8, 6); add(edx, 0x99);                         /* add edx, 0x99 */
            ii(0x100c_25de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_25e1, 5); calld(0x100b_8505, -0xa0e1);            /* call 0x100b8505 */
            ii(0x100c_25e6, 5); jmpd(0x100c_27e6, 0x1fb); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_25eb:
            ii(0x100c_25eb, 5); calld(0x1008_a4dc, -0x3_8114);          /* call 0x1008a4dc */
            ii(0x100c_25f0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_25f2, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_25f4, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_25f7, 6); add(edx, 0xb9);                         /* add edx, 0xb9 */
            ii(0x100c_25fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2600, 5); calld(0x100b_8505, -0xa100);            /* call 0x100b8505 */
            ii(0x100c_2605, 5); jmpd(0x100c_27e6, 0x1dc); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_260a:
            ii(0x100c_260a, 5); calld(0x1008_a4dc, -0x3_8133);          /* call 0x1008a4dc */
            ii(0x100c_260f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_2611, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_2613, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_2616, 6); add(edx, 0xbd);                         /* add edx, 0xbd */
            ii(0x100c_261c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_261f, 5); calld(0x100b_8505, -0xa11f);            /* call 0x100b8505 */
            ii(0x100c_2624, 5); jmpd(0x100c_27e6, 0x1bd); goto l_0x100c_27e6; /* jmp 0x100c27e6 */
        l_0x100c_2629:
            ii(0x100c_2629, 5); jmpd(0x100c_27b7, 0x189); goto l_0x100c_27b7; /* jmp 0x100c27b7 */
        l_0x100c_262e:
            ii(0x100c_262e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_2631, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100c_2634, 5); cmp(memw_a32[ss, ebp - 0x28], 0x44);    /* cmp word [ebp-0x28], 0x44 */
            ii(0x100c_2639, 6); if(jld(0x100c_26f2, 0xb3)) goto l_0x100c_26f2; /* jl 0x100c26f2 */
            ii(0x100c_263f, 5); cmp(memw_a32[ss, ebp - 0x28], 0x44);    /* cmp word [ebp-0x28], 0x44 */
            ii(0x100c_2644, 6); if(jled(0x100c_2531, -0x119)) goto l_0x100c_2531; /* jle 0x100c2531 */
            ii(0x100c_264a, 5); cmp(memw_a32[ss, ebp - 0x28], 0x4c);    /* cmp word [ebp-0x28], 0x4c */
            ii(0x100c_264f, 2); if(jld(0x100c_26a4, 0x53)) goto l_0x100c_26a4; /* jl 0x100c26a4 */
            ii(0x100c_2651, 5); cmp(memw_a32[ss, ebp - 0x28], 0x4c);    /* cmp word [ebp-0x28], 0x4c */
            ii(0x100c_2656, 6); if(jled(0x100c_25ad, -0xaf)) goto l_0x100c_25ad; /* jle 0x100c25ad */
            ii(0x100c_265c, 5); cmp(memw_a32[ss, ebp - 0x28], 0x50);    /* cmp word [ebp-0x28], 0x50 */
            ii(0x100c_2661, 2); if(jld(0x100c_2692, 0x2f)) goto l_0x100c_2692; /* jl 0x100c2692 */
            ii(0x100c_2663, 5); cmp(memw_a32[ss, ebp - 0x28], 0x50);    /* cmp word [ebp-0x28], 0x50 */
            ii(0x100c_2668, 6); if(jled(0x100c_24f3, -0x17b)) goto l_0x100c_24f3; /* jle 0x100c24f3 */
            ii(0x100c_266e, 5); cmp(memw_a32[ss, ebp - 0x28], 0x52);    /* cmp word [ebp-0x28], 0x52 */
            ii(0x100c_2673, 2); if(jld(0x100c_268d, 0x18)) goto l_0x100c_268d; /* jl 0x100c268d */
            ii(0x100c_2675, 5); cmp(memw_a32[ss, ebp - 0x28], 0x52);    /* cmp word [ebp-0x28], 0x52 */
            ii(0x100c_267a, 6); if(jled(0x100c_245b, -0x225)) goto l_0x100c_245b; /* jle 0x100c245b */
            ii(0x100c_2680, 5); cmp(memw_a32[ss, ebp - 0x28], 0x53);    /* cmp word [ebp-0x28], 0x53 */
            ii(0x100c_2685, 6); if(jzd(0x100c_25ad, -0xde)) goto l_0x100c_25ad; /* jz 0x100c25ad */
            ii(0x100c_268b, 2); jmpd(0x100c_2629, -0x64); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_268d:
            ii(0x100c_268d, 5); jmpd(0x100c_243c, -0x256); goto l_0x100c_243c; /* jmp 0x100c243c */
        l_0x100c_2692:
            ii(0x100c_2692, 5); cmp(memw_a32[ss, ebp - 0x28], 0x4d);    /* cmp word [ebp-0x28], 0x4d */
            ii(0x100c_2697, 6); if(jled(0x100c_25cc, -0xd1)) goto l_0x100c_25cc; /* jle 0x100c25cc */
            ii(0x100c_269d, 5); jmpd(0x100c_25ad, -0xf5); goto l_0x100c_25ad; /* jmp 0x100c25ad */
        //  ii(0x100c_26a2, 2); jmpd(0x100c_2629, -0x7b); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_26a4:
            ii(0x100c_26a4, 5); cmp(memw_a32[ss, ebp - 0x28], 0x47);    /* cmp word [ebp-0x28], 0x47 */
            ii(0x100c_26a9, 2); if(jld(0x100c_26dd, 0x32)) goto l_0x100c_26dd; /* jl 0x100c26dd */
            ii(0x100c_26ab, 5); cmp(memw_a32[ss, ebp - 0x28], 0x47);    /* cmp word [ebp-0x28], 0x47 */
            ii(0x100c_26b0, 6); if(jled(0x100c_2512, -0x1a4)) goto l_0x100c_2512; /* jle 0x100c2512 */
            ii(0x100c_26b6, 5); cmp(memw_a32[ss, ebp - 0x28], 0x49);    /* cmp word [ebp-0x28], 0x49 */
            ii(0x100c_26bb, 2); if(jld(0x100c_26d8, 0x1b)) goto l_0x100c_26d8; /* jl 0x100c26d8 */
            ii(0x100c_26bd, 5); cmp(memw_a32[ss, ebp - 0x28], 0x49);    /* cmp word [ebp-0x28], 0x49 */
            ii(0x100c_26c2, 6); if(jled(0x100c_24d4, -0x1f4)) goto l_0x100c_24d4; /* jle 0x100c24d4 */
            ii(0x100c_26c8, 5); cmp(memw_a32[ss, ebp - 0x28], 0x4b);    /* cmp word [ebp-0x28], 0x4b */
            ii(0x100c_26cd, 6); if(jzd(0x100c_2550, -0x183)) goto l_0x100c_2550; /* jz 0x100c2550 */
            ii(0x100c_26d3, 5); jmpd(0x100c_2629, -0xaf); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_26d8:
            ii(0x100c_26d8, 5); jmpd(0x100c_2550, -0x18d); goto l_0x100c_2550; /* jmp 0x100c2550 */
        l_0x100c_26dd:
            ii(0x100c_26dd, 5); cmp(memw_a32[ss, ebp - 0x28], 0x45);    /* cmp word [ebp-0x28], 0x45 */
            ii(0x100c_26e2, 6); if(jled(0x100c_256f, -0x179)) goto l_0x100c_256f; /* jle 0x100c256f */
            ii(0x100c_26e8, 5); jmpd(0x100c_24f3, -0x1fa); goto l_0x100c_24f3; /* jmp 0x100c24f3 */
        //  ii(0x100c_26ed, 5); jmpd(0x100c_2629, -0xc9); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_26f2:
            ii(0x100c_26f2, 5); cmp(memw_a32[ss, ebp - 0x28], 0x32);    /* cmp word [ebp-0x28], 0x32 */
            ii(0x100c_26f7, 2); if(jld(0x100c_2752, 0x59)) goto l_0x100c_2752; /* jl 0x100c2752 */
            ii(0x100c_26f9, 5); cmp(memw_a32[ss, ebp - 0x28], 0x32);    /* cmp word [ebp-0x28], 0x32 */
            ii(0x100c_26fe, 6); if(jled(0x100c_241d, -0x2e7)) goto l_0x100c_241d; /* jle 0x100c241d */
            ii(0x100c_2704, 5); cmp(memw_a32[ss, ebp - 0x28], 0x36);    /* cmp word [ebp-0x28], 0x36 */
            ii(0x100c_2709, 2); if(jld(0x100c_273d, 0x32)) goto l_0x100c_273d; /* jl 0x100c273d */
            ii(0x100c_270b, 5); cmp(memw_a32[ss, ebp - 0x28], 0x36);    /* cmp word [ebp-0x28], 0x36 */
            ii(0x100c_2710, 6); if(jled(0x100c_24b5, -0x261)) goto l_0x100c_24b5; /* jle 0x100c24b5 */
            ii(0x100c_2716, 5); cmp(memw_a32[ss, ebp - 0x28], 0x42);    /* cmp word [ebp-0x28], 0x42 */
            ii(0x100c_271b, 2); if(jld(0x100c_272d, 0x10)) goto l_0x100c_272d; /* jl 0x100c272d */
            ii(0x100c_271d, 5); cmp(memw_a32[ss, ebp - 0x28], 0x42);    /* cmp word [ebp-0x28], 0x42 */
            ii(0x100c_2722, 6); if(jled(0x100c_25eb, -0x13d)) goto l_0x100c_25eb; /* jle 0x100c25eb */
            ii(0x100c_2728, 5); jmpd(0x100c_260a, -0x123); goto l_0x100c_260a; /* jmp 0x100c260a */
        l_0x100c_272d:
            ii(0x100c_272d, 5); cmp(memw_a32[ss, ebp - 0x28], 0x37);    /* cmp word [ebp-0x28], 0x37 */
            ii(0x100c_2732, 6); if(jzd(0x100c_258e, -0x1aa)) goto l_0x100c_258e; /* jz 0x100c258e */
            ii(0x100c_2738, 5); jmpd(0x100c_2629, -0x114); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_273d:
            ii(0x100c_273d, 5); cmp(memw_a32[ss, ebp - 0x28], 0x33);    /* cmp word [ebp-0x28], 0x33 */
            ii(0x100c_2742, 6); if(jled(0x100c_243c, -0x30c)) goto l_0x100c_243c; /* jle 0x100c243c */
            ii(0x100c_2748, 5); jmpd(0x100c_245b, -0x2f2); goto l_0x100c_245b; /* jmp 0x100c245b */
        //  ii(0x100c_274d, 5); jmpd(0x100c_2629, -0x129); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_2752:
            ii(0x100c_2752, 5); cmp(memw_a32[ss, ebp - 0x28], 0x23);    /* cmp word [ebp-0x28], 0x23 */
            ii(0x100c_2757, 2); if(jld(0x100c_2790, 0x37)) goto l_0x100c_2790; /* jl 0x100c2790 */
            ii(0x100c_2759, 5); cmp(memw_a32[ss, ebp - 0x28], 0x23);    /* cmp word [ebp-0x28], 0x23 */
            ii(0x100c_275e, 6); if(jled(0x100c_258e, -0x1d6)) goto l_0x100c_258e; /* jle 0x100c258e */
            ii(0x100c_2764, 5); cmp(memw_a32[ss, ebp - 0x28], 0x25);    /* cmp word [ebp-0x28], 0x25 */
            ii(0x100c_2769, 6); if(jled(0x100c_247a, -0x2f5)) goto l_0x100c_247a; /* jle 0x100c247a */
            ii(0x100c_276f, 5); cmp(memw_a32[ss, ebp - 0x28], 0x29);    /* cmp word [ebp-0x28], 0x29 */
            ii(0x100c_2774, 2); if(jld(0x100c_2786, 0x10)) goto l_0x100c_2786; /* jl 0x100c2786 */
            ii(0x100c_2776, 5); cmp(memw_a32[ss, ebp - 0x28], 0x2a);    /* cmp word [ebp-0x28], 0x2a */
            ii(0x100c_277b, 6); if(jled(0x100c_2496, -0x2eb)) goto l_0x100c_2496; /* jle 0x100c2496 */
            ii(0x100c_2781, 5); jmpd(0x100c_2629, -0x15d); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_2786:
            ii(0x100c_2786, 5); jmpd(0x100c_2629, -0x162); goto l_0x100c_2629; /* jmp 0x100c2629 */
        //  ii(0x100c_278b, 5); jmpd(0x100c_2629, -0x167); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_2790:
            ii(0x100c_2790, 5); cmp(memw_a32[ss, ebp - 0x28], -0x1 /* 0xff */); /* cmp word [ebp-0x28], 0xffff */
            ii(0x100c_2795, 2); if(jld(0x100c_27b2, 0x1b)) goto l_0x100c_27b2; /* jl 0x100c27b2 */
            ii(0x100c_2797, 5); cmp(memw_a32[ss, ebp - 0x28], -0x1 /* 0xff */); /* cmp word [ebp-0x28], 0xffff */
            ii(0x100c_279c, 6); if(jled(0x100c_2327, -0x47b)) goto l_0x100c_2327; /* jle 0x100c2327 */
            ii(0x100c_27a2, 5); cmp(memw_a32[ss, ebp - 0x28], 0x22);    /* cmp word [ebp-0x28], 0x22 */
            ii(0x100c_27a7, 6); if(jzd(0x100c_247a, -0x333)) goto l_0x100c_247a; /* jz 0x100c247a */
            ii(0x100c_27ad, 5); jmpd(0x100c_2629, -0x189); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_27b2:
            ii(0x100c_27b2, 5); jmpd(0x100c_2629, -0x18e); goto l_0x100c_2629; /* jmp 0x100c2629 */
        l_0x100c_27b7:
            ii(0x100c_27b7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_27ba, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_27bd, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_27c3, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100c_27c9, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100c_27cc, 5); calld(0x1008_a4dc, -0x3_82f5);          /* call 0x1008a4dc */
            ii(0x100c_27d1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_27d3, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_27d5, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_27d8, 6); add(edx, 0xc1);                         /* add edx, 0xc1 */
            ii(0x100c_27de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_27e1, 5); calld(0x100b_8505, -0xa2e1);            /* call 0x100b8505 */
        l_0x100c_27e6:
            ii(0x100c_27e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_27e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_27eb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_27ec, 1); popd(edi);                              /* pop edi */
            ii(0x100c_27ed, 1); popd(esi);                              /* pop esi */
            ii(0x100c_27ee, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_27ef, 1); retd(); return;                         /* ret */
        }
    }
}
