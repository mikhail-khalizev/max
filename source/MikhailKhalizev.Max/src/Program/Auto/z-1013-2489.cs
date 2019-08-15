using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a3a02d04-11f8-4451-89c4-256a17d82039")]
        public void Method_1013_2489()
        {
            ii(0x1013_2489, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1013_248e, 5); calld(Definitions.sys_check_available_stack_size, 0x3_38bf); /* call 0x10165d52 */
            ii(0x1013_2493, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_2494, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_2495, 1); pushd(esi);                             /* push esi */
            ii(0x1013_2496, 1); pushd(edi);                             /* push edi */
            ii(0x1013_2497, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_2498, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_249a, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1013_24a0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_24a3, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_24a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_24a9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_24ab, 5); calld(0x1013_38fc, 0x144c);             /* call 0x101338fc */
            ii(0x1013_24b0, 1); cwde();                                 /* cwde */
            ii(0x1013_24b1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_24b7, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1013_24bc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_24be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_24c1, 3); mov(ebx, memd_a32[ds, eax + 0x1]);      /* mov ebx, [eax+0x1] */
            ii(0x1013_24c4, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1013_24c7, 3); imul(ebx, ebx, 0xc);                    /* imul ebx, ebx, 0xc */
            ii(0x1013_24ca, 6); lea(eax, edx + 0x88);                   /* lea eax, [edx+0x88] */
            ii(0x1013_24d0, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1013_24d2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_24d5, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_24da, 5); calld(/* sys */ 0x1016_a24c, 0x3_7d6d); /* call 0x1016a24c */
            ii(0x1013_24df, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1013_24e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_24e5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_24e7, 5); calld(0x100d_6a11, -0x5_badb);          /* call 0x100d6a11 */
            ii(0x1013_24ec, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1013_24ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_24f2, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1013_24f5, 5); calld(0x100d_7f6c, -0x5_a58e);          /* call 0x100d7f6c */
            ii(0x1013_24fa, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1013_24ff, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x1013_2503, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2506, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1013_2509, 5); calld(0x100d_4f58, -0x5_d5b6);          /* call 0x100d4f58 */
            ii(0x1013_250e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_2511, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_2514, 3); mov(edx, memd_a32[ds, edx + 0x3]);      /* mov edx, [edx+0x3] */
            ii(0x1013_2517, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_251a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_251d, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1013_2520, 5); calld(0x100d_4ebc, -0x5_d669);          /* call 0x100d4ebc */
            ii(0x1013_2525, 1); cwde();                                 /* cwde */
            ii(0x1013_2526, 4); movsx(esi, memw_a32[ss, ebp - 0x18]);   /* movsx esi, word [ebp-0x18] */
            ii(0x1013_252a, 3); imul(esi, eax);                         /* imul esi, eax */
            ii(0x1013_252d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2530, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1013_2533, 5); calld(0x100d_4ef0, -0x5_d648);          /* call 0x100d4ef0 */
            ii(0x1013_2538, 1); cwde();                                 /* cwde */
            ii(0x1013_2539, 3); add(eax, memd_a32[ss, ebp - 0x12]);     /* add eax, [ebp-0x12] */
            ii(0x1013_253c, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1013_253e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2541, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1013_2544, 5); calld(0x100d_4f58, -0x5_d5f1);          /* call 0x100d4f58 */
            ii(0x1013_2549, 1); cwde();                                 /* cwde */
            ii(0x1013_254a, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1013_254c, 1); dec(eax);                               /* dec eax */
            ii(0x1013_254d, 5); calld(0x1012_b658, -0x6efa);            /* call 0x1012b658 */
            ii(0x1013_2552, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1013_2555, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2558, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1013_255b, 5); calld(0x100d_7f6c, -0x5_a5f4);          /* call 0x100d7f6c */
            ii(0x1013_2560, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2563, 3); mov(eax, memd_a32[ds, eax + 0x3]);      /* mov eax, [eax+0x3] */
            ii(0x1013_2566, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_2569, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_256b, 6); if(jled(0x1013_262d, 0xbc)) goto l_0x1013_262d; /* jle 0x1013262d */
            ii(0x1013_2571, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_2576, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_2579, 3); mov(edx, memd_a32[ds, edx + 0x1]);      /* mov edx, [edx+0x1] */
            ii(0x1013_257c, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1013_257f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2582, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_2584, 5); calld(0x1013_38fc, 0x1373);             /* call 0x101338fc */
            ii(0x1013_2589, 1); cwde();                                 /* cwde */
            ii(0x1013_258a, 5); calld(0x1013_322d, 0xc9e);              /* call 0x1013322d */
            ii(0x1013_258f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_2592, 3); mov(edx, memd_a32[ds, edx + 0x3]);      /* mov edx, [edx+0x3] */
            ii(0x1013_2595, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_2598, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_259b, 3); add(edx, memd_a32[ds, eax + 0x4]);      /* add edx, [eax+0x4] */
            ii(0x1013_259e, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1013_25a1, 3); mov(ebx, memd_a32[ds, ebx + 0x3]);      /* mov ebx, [ebx+0x3] */
            ii(0x1013_25a4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1013_25a7, 1); dec(edx);                               /* dec edx */
            ii(0x1013_25a8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_25aa, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_25ad, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_25af, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1013_25b2, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1013_25b7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_25ba, 3); mov(edx, memd_a32[ds, edx + 0x1]);      /* mov edx, [edx+0x1] */
            ii(0x1013_25bd, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1013_25c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_25c3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_25c5, 5); calld(0x1013_38fc, 0x1332);             /* call 0x101338fc */
            ii(0x1013_25ca, 1); cwde();                                 /* cwde */
            ii(0x1013_25cb, 5); calld(0x1013_322d, 0xc5d);              /* call 0x1013322d */
            ii(0x1013_25d0, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1013_25d5, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x1013_25d9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_25dc, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1013_25df, 5); calld(0x100d_4f58, -0x5_d68c);          /* call 0x100d4f58 */
            ii(0x1013_25e4, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_25e7, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1013_25eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_25ee, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1013_25f1, 5); calld(0x100d_4ef0, -0x5_d706);          /* call 0x100d4ef0 */
            ii(0x1013_25f6, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x1013_25f9, 3); add(esi, memd_a32[ss, ebp - 0x12]);     /* add esi, [ebp-0x12] */
            ii(0x1013_25fc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_25ff, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1013_2602, 5); calld(0x100d_4f58, -0x5_d6af);          /* call 0x100d4f58 */
            ii(0x1013_2607, 1); cwde();                                 /* cwde */
            ii(0x1013_2608, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1013_260a, 3); mov(memd_a32[ss, ebp - 0x30], esi);     /* mov [ebp-0x30], esi */
            ii(0x1013_260d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2610, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1013_2613, 5); calld(0x100d_4ebc, -0x5_d75c);          /* call 0x100d4ebc */
            ii(0x1013_2618, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x1013_261b, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1013_261f, 3); imul(esi, eax);                         /* imul esi, eax */
            ii(0x1013_2622, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1013_2625, 1); dec(eax);                               /* dec eax */
            ii(0x1013_2626, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1013_2628, 5); calld(0x1012_b658, -0x6fd5);            /* call 0x1012b658 */
        l_0x1013_262d:
            ii(0x1013_262d, 5); mov(eax, 0x182);                        /* mov eax, 0x182 */
            ii(0x1013_2632, 5); calld(Definitions.my_get_res_data_by_id, 0x19a1); /* call 0x10133fd8 */
            ii(0x1013_2637, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1013_263a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_263d, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1013_2640, 5); calld(0x100d_4f58, -0x5_d6ed);          /* call 0x100d4f58 */
            ii(0x1013_2645, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_2647, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1013_264a, 3); sub(dx, memw_a32[ds, eax]);             /* sub dx, [eax] */
            ii(0x1013_264d, 3); mov(memd_a32[ss, ebp - 0x38], edx);     /* mov [ebp-0x38], edx */
            ii(0x1013_2650, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1013_2653, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2656, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1013_2659, 5); calld(0x100d_7f6c, -0x5_a6f2);          /* call 0x100d7f6c */
            ii(0x1013_265e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2661, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_2663, 5); calld(0x1013_3930, 0x12c8);             /* call 0x10133930 */
            ii(0x1013_2668, 1); cwde();                                 /* cwde */
            ii(0x1013_2669, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_266b, 2); if(jnzd(0x1013_2676, 0x9)) goto l_0x1013_2676; /* jnz 0x10132676 */
            ii(0x1013_266d, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x1013_2674, 2); jmpd(0x1013_269d, 0x27); goto l_0x1013_269d; /* jmp 0x1013269d */
        l_0x1013_2676:
            ii(0x1013_2676, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_2679, 3); mov(edx, memd_a32[ds, edx + 0x3]);      /* mov edx, [edx+0x3] */
            ii(0x1013_267c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_267f, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1013_2683, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_2686, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_2689, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_268b, 5); calld(0x1013_3930, 0x12a0);             /* call 0x10133930 */
            ii(0x1013_2690, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_2693, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_2695, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_2698, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_269a, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1013_269d:
            ii(0x1013_269d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1013_26a0, 1); pushd(eax);                             /* push eax */
            ii(0x1013_26a1, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1013_26a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_26a9, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1013_26ac, 5); calld(0x100d_4ebc, -0x5_d7f5);          /* call 0x100d4ebc */
            ii(0x1013_26b1, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_26b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_26b7, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1013_26ba, 5); calld(0x100d_4ef0, -0x5_d7cf);          /* call 0x100d4ef0 */
            ii(0x1013_26bf, 3); add(eax, memd_a32[ss, ebp - 0x38]);     /* add eax, [ebp-0x38] */
            ii(0x1013_26c2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_26c5, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1013_26c8, 5); calld(0x100e_8d1e, -0x4_99af);          /* call 0x100e8d1e */
            ii(0x1013_26cd, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_26d1, 2); if(jzd(0x1013_26fd, 0x2a)) goto l_0x1013_26fd; /* jz 0x101326fd */
            ii(0x1013_26d3, 3); mov(edx, memd_a32[ss, ebp - 0x16]);     /* mov edx, [ebp-0x16] */
            ii(0x1013_26d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_26d9, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1013_26dc, 5); calld(0x100d_820d, -0x5_a4d4);          /* call 0x100d820d */
            ii(0x1013_26e1, 3); mov(edx, memd_a32[ss, ebp - 0x16]);     /* mov edx, [ebp-0x16] */
            ii(0x1013_26e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_26e7, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1013_26ea, 5); calld(0x100d_820d, -0x5_a4e2);          /* call 0x100d820d */
            ii(0x1013_26ef, 3); mov(edx, memd_a32[ss, ebp - 0x16]);     /* mov edx, [ebp-0x16] */
            ii(0x1013_26f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_26f5, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1013_26f8, 5); calld(0x100d_820d, -0x5_a4f0);          /* call 0x100d820d */
        l_0x1013_26fd:
            ii(0x1013_26fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_26ff, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_2700, 1); popd(edi);                              /* pop edi */
            ii(0x1013_2701, 1); popd(esi);                              /* pop esi */
            ii(0x1013_2702, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_2703, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_2704, 1); retd(); return;                         /* ret */
        }
    }
}
