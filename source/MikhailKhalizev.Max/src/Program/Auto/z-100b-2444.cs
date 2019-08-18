using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_2444-11c70740")]
        public void Method_100b_2444()
        {
            ii(0x100b_2444, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100b_2449, 5); calld(Definitions.sys_check_available_stack_size, 0xb_3904); /* call 0x10165d52 */
            ii(0x100b_244e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_244f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_2450, 1); pushd(esi);                             /* push esi */
            ii(0x100b_2451, 1); pushd(edi);                             /* push edi */
            ii(0x100b_2452, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_2453, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_2455, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100b_245b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_245e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_2461, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2463, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2466, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2469, 5); calld(0x1013_ad11, 0x8_88a3);           /* call 0x1013ad11 */
            ii(0x100b_246e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2470, 2); if(jnzd(0x100b_2489, 0x17)) goto l_0x100b_2489; /* jnz 0x100b2489 */
            ii(0x100b_2472, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_2475, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2478, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_247b, 5); calld(0x1007_6574, -0x3_bf0c);          /* call 0x10076574 */
            ii(0x100b_2480, 5); calld(0x1015_2a52, 0xa_05cd);           /* call 0x10152a52 */
            ii(0x100b_2485, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2487, 2); if(jnzd(0x100b_2492, 0x9)) goto l_0x100b_2492; /* jnz 0x100b2492 */
        l_0x100b_2489:
            ii(0x100b_2489, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_248d, 5); jmpd(0x100b_2774, 0x2e2); goto l_0x100b_2774; /* jmp 0x100b2774 */
        l_0x100b_2492:
            ii(0x100b_2492, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_2494, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_2499, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_249b, 2); if(jnzd(0x100b_24b2, 0x15)) goto l_0x100b_24b2; /* jnz 0x100b24b2 */
            ii(0x100b_249d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_24a0, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_24a3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_24a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_24a8, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100b_24ae, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_24b0, 2); if(jnzd(0x100b_24b4, 0x2)) goto l_0x100b_24b4; /* jnz 0x100b24b4 */
        l_0x100b_24b2:
            ii(0x100b_24b2, 2); jmpd(0x100b_24bd, 0x9); goto l_0x100b_24bd; /* jmp 0x100b24bd */
        l_0x100b_24b4:
            ii(0x100b_24b4, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_24b8, 5); jmpd(0x100b_2774, 0x2b7); goto l_0x100b_2774; /* jmp 0x100b2774 */
        l_0x100b_24bd:
            ii(0x100b_24bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_24c0, 5); calld(0x100a_2edb, -0xf5ea);            /* call 0x100a2edb */
            ii(0x100b_24c5, 2); test(al, al);                           /* test al, al */
            ii(0x100b_24c7, 2); if(jzd(0x100b_24eb, 0x22)) goto l_0x100b_24eb; /* jz 0x100b24eb */
            ii(0x100b_24c9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_24cb, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_24d0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_24d2, 2); if(jnzd(0x100b_24e9, 0x15)) goto l_0x100b_24e9; /* jnz 0x100b24e9 */
            ii(0x100b_24d4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_24d7, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_24da, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_24dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_24df, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100b_24e5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_24e7, 2); if(jnzd(0x100b_24eb, 0x2)) goto l_0x100b_24eb; /* jnz 0x100b24eb */
        l_0x100b_24e9:
            ii(0x100b_24e9, 2); jmpd(0x100b_24f4, 0x9); goto l_0x100b_24f4; /* jmp 0x100b24f4 */
        l_0x100b_24eb:
            ii(0x100b_24eb, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_24ef, 5); jmpd(0x100b_2774, 0x280); goto l_0x100b_2774; /* jmp 0x100b2774 */
        l_0x100b_24f4:
            ii(0x100b_24f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_24f7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_24fa, 5); calld(0x1008_abbc, -0x2_7943);          /* call 0x1008abbc */
            ii(0x100b_24ff, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_2502, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2504, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_2506, 5); calld(0x100a_601a, -0xc4f1);            /* call 0x100a601a */
            ii(0x100b_250b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_250e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2511, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2514, 5); calld(0x1007_6574, -0x3_bfa5);          /* call 0x10076574 */
            ii(0x100b_2519, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_251e, 2); if(jnzd(0x100b_2528, 0x8)) goto l_0x100b_2528; /* jnz 0x100b2528 */
            ii(0x100b_2520, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_2524, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2526, 2); if(jgd(0x100b_252a, 0x2)) goto l_0x100b_252a; /* jg 0x100b252a */
        l_0x100b_2528:
            ii(0x100b_2528, 2); jmpd(0x100b_2533, 0x9); goto l_0x100b_2533; /* jmp 0x100b2533 */
        l_0x100b_252a:
            ii(0x100b_252a, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_252e, 5); jmpd(0x100b_2774, 0x241); goto l_0x100b_2774; /* jmp 0x100b2774 */
        l_0x100b_2533:
            ii(0x100b_2533, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2536, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2539, 5); calld(0x1007_6574, -0x3_bfca);          /* call 0x10076574 */
            ii(0x100b_253e, 5); cmp(memw_a32[ds, eax + 0x8], 0x48);     /* cmp word [eax+0x8], 0x48 */
            ii(0x100b_2543, 2); if(jzd(0x100b_2557, 0x12)) goto l_0x100b_2557; /* jz 0x100b2557 */
            ii(0x100b_2545, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2548, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_254b, 5); calld(0x1007_6574, -0x3_bfdc);          /* call 0x10076574 */
            ii(0x100b_2550, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x100b_2555, 2); if(jnzd(0x100b_2560, 0x9)) goto l_0x100b_2560; /* jnz 0x100b2560 */
        l_0x100b_2557:
            ii(0x100b_2557, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_255b, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100b_255e, 2); if(jgd(0x100b_2562, 0x2)) goto l_0x100b_2562; /* jg 0x100b2562 */
        l_0x100b_2560:
            ii(0x100b_2560, 2); jmpd(0x100b_256b, 0x9); goto l_0x100b_256b; /* jmp 0x100b256b */
        l_0x100b_2562:
            ii(0x100b_2562, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_2566, 5); jmpd(0x100b_2774, 0x209); goto l_0x100b_2774; /* jmp 0x100b2774 */
        l_0x100b_256b:
            ii(0x100b_256b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_256e, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2571, 5); calld(0x1007_6574, -0x3_c002);          /* call 0x10076574 */
            ii(0x100b_2576, 5); cmp(memw_a32[ds, eax + 0x8], 0x4e);     /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_257b, 6); if(jnzd(0x100b_25f6, 0x75)) goto l_0x100b_25f6; /* jnz 0x100b25f6 */
            ii(0x100b_2581, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_2584, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2587, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_258a, 5); calld(0x1007_6574, -0x3_c01b);          /* call 0x10076574 */
            ii(0x100b_258f, 5); calld(0x1008_a998, -0x2_7bfc);          /* call 0x1008a998 */
            ii(0x100b_2594, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_2596, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_259b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_259d, 2); if(jnzd(0x100b_25b4, 0x15)) goto l_0x100b_25b4; /* jnz 0x100b25b4 */
            ii(0x100b_259f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_25a2, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_25a5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_25a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_25aa, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100b_25b0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_25b2, 2); if(jnzd(0x100b_25bd, 0x9)) goto l_0x100b_25bd; /* jnz 0x100b25bd */
        l_0x100b_25b4:
            ii(0x100b_25b4, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x100b_25bb, 2); jmpd(0x100b_25d6, 0x19); goto l_0x100b_25d6; /* jmp 0x100b25d6 */
        l_0x100b_25bd:
            ii(0x100b_25bd, 5); mov(ecx, 0xac5);                        /* mov ecx, 0xac5 */
            ii(0x100b_25c2, 5); mov(ebx, StringDefinitions.AiMoveCpp8); /* mov ebx, 0x101a1022 */
            ii(0x100b_25c7, 5); mov(edx, StringDefinitions.PlaymodeNotEqualTurnBasedTeamturnidEqualTeam2); /* mov edx, 0x101a102e */
            ii(0x100b_25cc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_25ce, 5); calld(Definitions.sys_assert, 0xb_37bf); /* call 0x10165d92 */
            ii(0x100b_25d3, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x100b_25d6:
            ii(0x100b_25d6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_25d8, 5); mov(edx, 0xf);                          /* mov edx, 0xf */
            ii(0x100b_25dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_25e0, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_25e3, 5); calld(0x1007_65d0, -0x3_c018);          /* call 0x100765d0 */
            ii(0x100b_25e8, 5); calld(0x1016_3053, 0xb_0a66);           /* call 0x10163053 */
            ii(0x100b_25ed, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_25f1, 5); jmpd(0x100b_2774, 0x17e); goto l_0x100b_2774; /* jmp 0x100b2774 */
        l_0x100b_25f6:
            ii(0x100b_25f6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_25f9, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_25fc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_2601, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2603, 2); if(jnzd(0x100b_260e, 0x9)) goto l_0x100b_260e; /* jnz 0x100b260e */
            ii(0x100b_2605, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_2609, 5); jmpd(0x100b_2774, 0x166); goto l_0x100b_2774; /* jmp 0x100b2774 */
        l_0x100b_260e:
            ii(0x100b_260e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2611, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2614, 5); calld(0x1007_6574, -0x3_c0a5);          /* call 0x10076574 */
            ii(0x100b_2619, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x100b_261d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2620, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100b_2624, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2627, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_262a, 5); calld(0x1007_6574, -0x3_c0bb);          /* call 0x10076574 */
            ii(0x100b_262f, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x100b_2633, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2636, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100b_263a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_263c, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_2641, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2643, 2); if(jnzd(0x100b_265a, 0x15)) goto l_0x100b_265a; /* jnz 0x100b265a */
            ii(0x100b_2645, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2648, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100b_264b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_264e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2650, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100b_2656, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_2658, 2); if(jnzd(0x100b_2663, 0x9)) goto l_0x100b_2663; /* jnz 0x100b2663 */
        l_0x100b_265a:
            ii(0x100b_265a, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100b_2661, 2); jmpd(0x100b_267c, 0x19); goto l_0x100b_267c; /* jmp 0x100b267c */
        l_0x100b_2663:
            ii(0x100b_2663, 5); mov(ecx, 0xad9);                        /* mov ecx, 0xad9 */
            ii(0x100b_2668, 5); mov(ebx, StringDefinitions.AiMoveCpp9); /* mov ebx, 0x101a105b */
            ii(0x100b_266d, 5); mov(edx, StringDefinitions.PlaymodeNotEqualTurnBasedTeamturnidEqualTeam3); /* mov edx, 0x101a1067 */
            ii(0x100b_2672, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_2674, 5); calld(Definitions.sys_assert, 0xb_3719); /* call 0x10165d92 */
            ii(0x100b_2679, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100b_267c:
            ii(0x100b_267c, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x100b_2681, 5); calld(Definitions.sys_new, 0xb_377a);   /* call 0x10165e00 */
            ii(0x100b_2686, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_2689, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_268c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_268f, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100b_2693, 2); if(jzd(0x100b_26ca, 0x35)) goto l_0x100b_26ca; /* jz 0x100b26ca */
            ii(0x100b_2695, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2698, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_269b, 5); calld(0x1007_6574, -0x3_c12c);          /* call 0x10076574 */
            ii(0x100b_26a0, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_26a3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_26a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_26a9, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_26ac, 5); calld(0x1007_6574, -0x3_c13d);          /* call 0x10076574 */
            ii(0x100b_26b1, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_26b4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_26b7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_26ba, 5); calld(Definitions.my_ctor_c20, 0x6_7897); /* call 0x10119f56 */
            ii(0x100b_26bf, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_26c2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_26c5, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100b_26c8, 2); jmpd(0x100b_26d0, 0x6); goto l_0x100b_26d0; /* jmp 0x100b26d0 */
        l_0x100b_26ca:
            ii(0x100b_26ca, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_26cd, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100b_26d0:
            ii(0x100b_26d0, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100b_26d3, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_26d6, 5); calld(0x100a_b3b0, -0x732b);            /* call 0x100ab3b0 */
            ii(0x100b_26db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_26de, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_26e1, 5); calld(0x1007_6574, -0x3_c172);          /* call 0x10076574 */
            ii(0x100b_26e6, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100b_26ea, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_26ed, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x100b_26f1, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100b_26f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_26f7, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_26fa, 5); calld(0x1007_6574, -0x3_c18b);          /* call 0x10076574 */
            ii(0x100b_26ff, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100b_2703, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_2706, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x100b_270a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_270d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_2710, 5); calld(0x100a_b2e0, -0x7435);            /* call 0x100ab2e0 */
            ii(0x100b_2715, 5); calld(0x1011_aca3, 0x6_8589);           /* call 0x1011aca3 */
            ii(0x100b_271a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_271d, 5); calld(0x100a_b33c, -0x73e6);            /* call 0x100ab33c */
            ii(0x100b_2722, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2724, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2727, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x100b_272a, 5); calld(0x1007_6a34, -0x3_bcfb);          /* call 0x10076a34 */
            ii(0x100b_272f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2732, 5); calld(0x1015_48ba, 0xa_2183);           /* call 0x101548ba */
            ii(0x100b_2737, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100b_273c, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x100b_2741, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2744, 5); calld(0x1016_3053, 0xb_090a);           /* call 0x10163053 */
            ii(0x100b_2749, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100b_2750, 2); if(jzd(0x100b_275a, 0x8)) goto l_0x100b_275a; /* jz 0x100b275a */
            ii(0x100b_2752, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_2755, 5); calld(0x1012_ae8d, 0x7_8733);           /* call 0x1012ae8d */
        l_0x100b_275a:
            ii(0x100b_275a, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_275e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2760, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100b_2763, 5); calld(0x100a_9f38, -0x8830);            /* call 0x100a9f38 */
            ii(0x100b_2768, 2); jmpd(0x100b_2774, 0xa); goto l_0x100b_2774; /* jmp 0x100b2774 */
        //    ii(0x100b_276a, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100b_276c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //    ii(0x100b_276f, 5); calld(0x100a_9f38, -0x883c);            /* call 0x100a9f38 */
        l_0x100b_2774:
            ii(0x100b_2774, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_2777, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_2779, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_277a, 1); popd(edi);                              /* pop edi */
            ii(0x100b_277b, 1); popd(esi);                              /* pop esi */
            ii(0x100b_277c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_277d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_277e, 1); retd(); return;                         /* ret */
        }
    }
}
