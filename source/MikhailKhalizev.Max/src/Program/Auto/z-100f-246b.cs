using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_246b-ecd5d6fb")]
        public void Method_100f_246b()
        {
            ii(0x100f_246b, 5); push(0x48);                             /* push 0x48 */
            ii(0x100f_2470, 5); call(Definitions.sys_check_available_stack_size, 0x7_38dd); /* call 0x10165d52 */
            ii(0x100f_2475, 1); push(ebx);                              /* push ebx */
            ii(0x100f_2476, 1); push(ecx);                              /* push ecx */
            ii(0x100f_2477, 1); push(edx);                              /* push edx */
            ii(0x100f_2478, 1); push(esi);                              /* push esi */
            ii(0x100f_2479, 1); push(edi);                              /* push edi */
            ii(0x100f_247a, 1); push(ebp);                              /* push ebp */
            ii(0x100f_247b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_247d, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100f_2483, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_2486, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x100f_248b, 5); mov(ebx, 0x3ca);                        /* mov ebx, 0x3ca */
            ii(0x100f_2490, 5); mov(edx, 0x38f);                        /* mov edx, 0x38f */
            ii(0x100f_2495, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_249a, 5); call(0x1013_daea, 0x4_b64b);            /* call 0x1013daea */
            ii(0x100f_249f, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_24a3, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_24a7, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100f_24ab, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_24af, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_24b2, 5); call(0x1007_623c, -0x7_c27b);           /* call 0x1007623c */
            ii(0x100f_24b7, 4); mov(ax, memw[ds, eax + 0x1b]);          /* mov ax, [eax+0x1b] */
            ii(0x100f_24bb, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_24be, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100f_24c2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_24c4, 2); if(jz(0x100f_2512, 0x4c)) goto l_0x100f_2512; /* jz 0x100f2512 */
            ii(0x100f_24c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_24c9, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x100f_24cc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_24d1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_24d3, 2); if(jnz(0x100f_24db, 6)) goto l_0x100f_24db; /* jnz 0x100f24db */
            ii(0x100f_24d5, 4); mov(memb[ss, ebp - 0x24], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x100f_24d9, 2); jmp(0x100f_24df, 4); goto l_0x100f_24df; /* jmp 0x100f24df */
        l_0x100f_24db:
            ii(0x100f_24db, 4); mov(memb[ss, ebp - 0x24], 0);           /* mov byte [ebp-0x24], 0x0 */
        l_0x100f_24df:
            ii(0x100f_24df, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x100f_24e2, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100f_24e5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100f_24e8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_24ea, 3); mov(bl, memb[ds, edx + 0x54]);          /* mov bl, [edx+0x54] */
            ii(0x100f_24ed, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100f_24f1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_24f3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_24f6, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100f_24f9, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100f_24fb, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x100f_24fe, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100f_2500, 2); if(jg(0x100f_2508, 6)) goto l_0x100f_2508; /* jg 0x100f2508 */
            ii(0x100f_2502, 4); mov(memb[ss, ebp - 0x20], 1);           /* mov byte [ebp-0x20], 0x1 */
            ii(0x100f_2506, 2); jmp(0x100f_250c, 4); goto l_0x100f_250c; /* jmp 0x100f250c */
        l_0x100f_2508:
            ii(0x100f_2508, 4); mov(memb[ss, ebp - 0x20], 0);           /* mov byte [ebp-0x20], 0x0 */
        l_0x100f_250c:
            ii(0x100f_250c, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x100f_250f, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x100f_2512:
            ii(0x100f_2512, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2515, 6); test(memw[ds, eax + 0x12], 0x1c0);      /* test word [eax+0x12], 0x1c0 */
            ii(0x100f_251b, 2); if(jz(0x100f_253c, 0x1f)) goto l_0x100f_253c; /* jz 0x100f253c */
            ii(0x100f_251d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2520, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100f_2523, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_2528, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_252a, 2); if(jnz(0x100f_2532, 6)) goto l_0x100f_2532; /* jnz 0x100f2532 */
            ii(0x100f_252c, 4); mov(memb[ss, ebp - 0x28], 1);           /* mov byte [ebp-0x28], 0x1 */
            ii(0x100f_2530, 2); jmp(0x100f_2536, 4); goto l_0x100f_2536; /* jmp 0x100f2536 */
        l_0x100f_2532:
            ii(0x100f_2532, 4); mov(memb[ss, ebp - 0x28], 0);           /* mov byte [ebp-0x28], 0x0 */
        l_0x100f_2536:
            ii(0x100f_2536, 3); mov(al, memb[ss, ebp - 0x28]);          /* mov al, [ebp-0x28] */
            ii(0x100f_2539, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
        l_0x100f_253c:
            ii(0x100f_253c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_253f, 5); call(0x1007_623c, -0x7_c308);           /* call 0x1007623c */
            ii(0x100f_2544, 4); mov(ax, memw[ds, eax + 0xa]);           /* mov ax, [eax+0xa] */
            ii(0x100f_2548, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_254b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_254e, 6); test(memw[ds, eax + 0x12], 0x3c0);      /* test word [eax+0x12], 0x3c0 */
            ii(0x100f_2554, 2); if(jz(0x100f_257f, 0x29)) goto l_0x100f_257f; /* jz 0x100f257f */
            ii(0x100f_2556, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100f_2559, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_255b, 3); mov(bl, memb[ds, edx + 0x4d]);          /* mov bl, [edx+0x4d] */
            ii(0x100f_255e, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100f_2562, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_2564, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_2567, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_2569, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x100f_256b, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100f_256d, 2); if(jg(0x100f_2575, 6)) goto l_0x100f_2575; /* jg 0x100f2575 */
            ii(0x100f_256f, 4); mov(memb[ss, ebp - 0x2c], 1);           /* mov byte [ebp-0x2c], 0x1 */
            ii(0x100f_2573, 2); jmp(0x100f_2579, 4); goto l_0x100f_2579; /* jmp 0x100f2579 */
        l_0x100f_2575:
            ii(0x100f_2575, 4); mov(memb[ss, ebp - 0x2c], 0);           /* mov byte [ebp-0x2c], 0x0 */
        l_0x100f_2579:
            ii(0x100f_2579, 3); mov(al, memb[ss, ebp - 0x2c]);          /* mov al, [ebp-0x2c] */
            ii(0x100f_257c, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
        l_0x100f_257f:
            ii(0x100f_257f, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_2583, 2); if(jz(0x100f_25a3, 0x1e)) goto l_0x100f_25a3; /* jz 0x100f25a3 */
            ii(0x100f_2585, 5); call(0x100d_5470, -0x1_d11a);           /* call 0x100d5470 */
            ii(0x100f_258a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_258d, 5); mov(ebx, 0x39d);                        /* mov ebx, 0x39d */
            ii(0x100f_2592, 5); mov(edx, 0x39c);                        /* mov edx, 0x39c */
            ii(0x100f_2597, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_259c, 5); call(0x1013_daea, 0x4_b549);            /* call 0x1013daea */
            ii(0x100f_25a1, 2); jmp(0x100f_25c5, 0x22); goto l_0x100f_25c5; /* jmp 0x100f25c5 */
        l_0x100f_25a3:
            ii(0x100f_25a3, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_25a7, 2); if(jz(0x100f_25c5, 0x1c)) goto l_0x100f_25c5; /* jz 0x100f25c5 */
            ii(0x100f_25a9, 5); call(0x100d_5470, -0x1_d13e);           /* call 0x100d5470 */
            ii(0x100f_25ae, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_25b1, 5); mov(ebx, 0x39b);                        /* mov ebx, 0x39b */
            ii(0x100f_25b6, 5); mov(edx, 0x39a);                        /* mov edx, 0x39a */
            ii(0x100f_25bb, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_25c0, 5); call(0x1013_daea, 0x4_b525);            /* call 0x1013daea */
        l_0x100f_25c5:
            ii(0x100f_25c5, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_25c9, 2); if(jz(0x100f_25e7, 0x1c)) goto l_0x100f_25e7; /* jz 0x100f25e7 */
            ii(0x100f_25cb, 5); call(0x100d_5470, -0x1_d160);           /* call 0x100d5470 */
            ii(0x100f_25d0, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_25d3, 5); mov(ebx, 0x39f);                        /* mov ebx, 0x39f */
            ii(0x100f_25d8, 5); mov(edx, 0x39e);                        /* mov edx, 0x39e */
            ii(0x100f_25dd, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_25e2, 5); call(0x1013_daea, 0x4_b503);            /* call 0x1013daea */
        l_0x100f_25e7:
            ii(0x100f_25e7, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100f_25eb, 2); if(jz(0x100f_2644, 0x57)) goto l_0x100f_2644; /* jz 0x100f2644 */
            ii(0x100f_25ed, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100f_25f0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_25f2, 3); mov(bl, memb[ds, edx + 0x4d]);          /* mov bl, [edx+0x4d] */
            ii(0x100f_25f5, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100f_25f9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_25fb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_25fe, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100f_2601, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100f_2603, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x100f_2606, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100f_2608, 2); if(jg(0x100f_2628, 0x1e)) goto l_0x100f_2628; /* jg 0x100f2628 */
            ii(0x100f_260a, 5); call(0x100d_5470, -0x1_d19f);           /* call 0x100d5470 */
            ii(0x100f_260f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_2612, 5); mov(ebx, 0x3a9);                        /* mov ebx, 0x3a9 */
            ii(0x100f_2617, 5); mov(edx, 0x3a6);                        /* mov edx, 0x3a6 */
            ii(0x100f_261c, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_2621, 5); call(0x1013_daea, 0x4_b4c4);            /* call 0x1013daea */
            ii(0x100f_2626, 2); jmp(0x100f_2644, 0x1c); goto l_0x100f_2644; /* jmp 0x100f2644 */
        l_0x100f_2628:
            ii(0x100f_2628, 5); call(0x100d_5470, -0x1_d1bd);           /* call 0x100d5470 */
            ii(0x100f_262d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_2630, 5); mov(ebx, 0x3a3);                        /* mov ebx, 0x3a3 */
            ii(0x100f_2635, 5); mov(edx, 0x3a0);                        /* mov edx, 0x3a0 */
            ii(0x100f_263a, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_263f, 5); call(0x1013_daea, 0x4_b4a6);            /* call 0x1013daea */
        l_0x100f_2644:
            ii(0x100f_2644, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_2648, 2); if(jnz(0x100f_2650, 6)) goto l_0x100f_2650; /* jnz 0x100f2650 */
            ii(0x100f_264a, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_264e, 2); if(jz(0x100f_2652, 2)) goto l_0x100f_2652; /* jz 0x100f2652 */
        l_0x100f_2650:
            ii(0x100f_2650, 2); jmp(0x100f_2658, 6); goto l_0x100f_2658; /* jmp 0x100f2658 */
        l_0x100f_2652:
            ii(0x100f_2652, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100f_2656, 2); if(jz(0x100f_265a, 2)) goto l_0x100f_265a; /* jz 0x100f265a */
        l_0x100f_2658:
            ii(0x100f_2658, 2); jmp(0x100f_2660, 6); goto l_0x100f_2660; /* jmp 0x100f2660 */
        l_0x100f_265a:
            ii(0x100f_265a, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100f_265e, 2); if(jz(0x100f_2665, 5)) goto l_0x100f_2665; /* jz 0x100f2665 */
        l_0x100f_2660:
            ii(0x100f_2660, 5); jmp(0x100f_2899, 0x234); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_2665:
            ii(0x100f_2665, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2668, 5); cmp(memw[ds, eax + 8], 0x39);           /* cmp word [eax+0x8], 0x39 */
            ii(0x100f_266d, 2); if(jnz(0x100f_2690, 0x21)) goto l_0x100f_2690; /* jnz 0x100f2690 */
            ii(0x100f_266f, 5); call(0x100d_5470, -0x1_d204);           /* call 0x100d5470 */
            ii(0x100f_2674, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_2677, 5); mov(ebx, 0x3c5);                        /* mov ebx, 0x3c5 */
            ii(0x100f_267c, 5); mov(edx, 0x3c2);                        /* mov edx, 0x3c2 */
            ii(0x100f_2681, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_2686, 5); call(0x1013_daea, 0x4_b45f);            /* call 0x1013daea */
            ii(0x100f_268b, 5); jmp(0x100f_2899, 0x209); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_2690:
            ii(0x100f_2690, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2693, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x100f_2697, 2); if(jnz(0x100f_26ba, 0x21)) goto l_0x100f_26ba; /* jnz 0x100f26ba */
            ii(0x100f_2699, 5); call(0x100d_5470, -0x1_d22e);           /* call 0x100d5470 */
            ii(0x100f_269e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_26a1, 5); mov(ebx, 0x3c9);                        /* mov ebx, 0x3c9 */
            ii(0x100f_26a6, 5); mov(edx, 0x3c6);                        /* mov edx, 0x3c6 */
            ii(0x100f_26ab, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_26b0, 5); call(0x1013_daea, 0x4_b435);            /* call 0x1013daea */
            ii(0x100f_26b5, 5); jmp(0x100f_2899, 0x1df); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_26ba:
            ii(0x100f_26ba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_26bd, 4); cmp(memb[ds, eax + 0x3d], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100f_26c1, 2); if(jz(0x100f_26cc, 9)) goto l_0x100f_26cc; /* jz 0x100f26cc */
            ii(0x100f_26c3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_26c6, 4); cmp(memb[ds, eax + 0x3d], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100f_26ca, 2); if(jnz(0x100f_26d8, 0xc)) goto l_0x100f_26d8; /* jnz 0x100f26d8 */
        l_0x100f_26cc:
            ii(0x100f_26cc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_26cf, 5); call(0x1008_aa4c, -0x6_7c88);           /* call 0x1008aa4c */
            ii(0x100f_26d4, 2); cmp(al, 2);                             /* cmp al, 0x2 */
            ii(0x100f_26d6, 2); if(jz(0x100f_26da, 2)) goto l_0x100f_26da; /* jz 0x100f26da */
        l_0x100f_26d8:
            ii(0x100f_26d8, 2); jmp(0x100f_26fb, 0x21); goto l_0x100f_26fb; /* jmp 0x100f26fb */
        l_0x100f_26da:
            ii(0x100f_26da, 5); call(0x100d_5470, -0x1_d26f);           /* call 0x100d5470 */
            ii(0x100f_26df, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_26e2, 5); mov(ebx, 0x3bd);                        /* mov ebx, 0x3bd */
            ii(0x100f_26e7, 5); mov(edx, 0x3ba);                        /* mov edx, 0x3ba */
            ii(0x100f_26ec, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_26f1, 5); call(0x1013_daea, 0x4_b3f4);            /* call 0x1013daea */
            ii(0x100f_26f6, 5); jmp(0x100f_2899, 0x19e); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_26fb:
            ii(0x100f_26fb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_26fe, 4); cmp(memb[ds, eax + 0x3d], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100f_2702, 2); if(jz(0x100f_270d, 9)) goto l_0x100f_270d; /* jz 0x100f270d */
            ii(0x100f_2704, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2707, 4); cmp(memb[ds, eax + 0x3d], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100f_270b, 2); if(jnz(0x100f_2719, 0xc)) goto l_0x100f_2719; /* jnz 0x100f2719 */
        l_0x100f_270d:
            ii(0x100f_270d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2710, 5); call(0x1008_aa4c, -0x6_7cc9);           /* call 0x1008aa4c */
            ii(0x100f_2715, 2); cmp(al, 1);                             /* cmp al, 0x1 */
            ii(0x100f_2717, 2); if(jz(0x100f_271b, 2)) goto l_0x100f_271b; /* jz 0x100f271b */
        l_0x100f_2719:
            ii(0x100f_2719, 2); jmp(0x100f_273c, 0x21); goto l_0x100f_273c; /* jmp 0x100f273c */
        l_0x100f_271b:
            ii(0x100f_271b, 5); call(0x100d_5470, -0x1_d2b0);           /* call 0x100d5470 */
            ii(0x100f_2720, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_2723, 5); mov(ebx, 0x3c1);                        /* mov ebx, 0x3c1 */
            ii(0x100f_2728, 5); mov(edx, 0x3be);                        /* mov edx, 0x3be */
            ii(0x100f_272d, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_2732, 5); call(0x1013_daea, 0x4_b3b3);            /* call 0x1013daea */
            ii(0x100f_2737, 5); jmp(0x100f_2899, 0x15d); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_273c:
            ii(0x100f_273c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_273f, 4); cmp(memb[ds, eax + 0x3d], 0xb);         /* cmp byte [eax+0x3d], 0xb */
            ii(0x100f_2743, 2); if(jnz(0x100f_2766, 0x21)) goto l_0x100f_2766; /* jnz 0x100f2766 */
            ii(0x100f_2745, 5); call(0x100d_5470, -0x1_d2da);           /* call 0x100d5470 */
            ii(0x100f_274a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_274d, 5); mov(ebx, 0x3b9);                        /* mov ebx, 0x3b9 */
            ii(0x100f_2752, 5); mov(edx, 0x3b8);                        /* mov edx, 0x3b8 */
            ii(0x100f_2757, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_275c, 5); call(0x1013_daea, 0x4_b389);            /* call 0x1013daea */
            ii(0x100f_2761, 5); jmp(0x100f_2899, 0x133); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_2766:
            ii(0x100f_2766, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2769, 4); cmp(memb[ds, eax + 0x3d], 0xc);         /* cmp byte [eax+0x3d], 0xc */
            ii(0x100f_276d, 2); if(jnz(0x100f_277a, 0xb)) goto l_0x100f_277a; /* jnz 0x100f277a */
            ii(0x100f_276f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2772, 6); test(memw[ds, eax + 0x12], 0x1c0);      /* test word [eax+0x12], 0x1c0 */
            ii(0x100f_2778, 2); if(jnz(0x100f_277c, 2)) goto l_0x100f_277c; /* jnz 0x100f277c */
        l_0x100f_277a:
            ii(0x100f_277a, 2); jmp(0x100f_279d, 0x21); goto l_0x100f_279d; /* jmp 0x100f279d */
        l_0x100f_277c:
            ii(0x100f_277c, 5); call(0x100d_5470, -0x1_d311);           /* call 0x100d5470 */
            ii(0x100f_2781, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_2784, 5); mov(ebx, 0x3ab);                        /* mov ebx, 0x3ab */
            ii(0x100f_2789, 5); mov(edx, 0x3aa);                        /* mov edx, 0x3aa */
            ii(0x100f_278e, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_2793, 5); call(0x1013_daea, 0x4_b352);            /* call 0x1013daea */
            ii(0x100f_2798, 5); jmp(0x100f_2899, 0xfc); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_279d:
            ii(0x100f_279d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_27a0, 4); cmp(memb[ds, eax + 0x3d], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100f_27a4, 2); if(jnz(0x100f_2815, 0x6f)) goto l_0x100f_2815; /* jnz 0x100f2815 */
            ii(0x100f_27a6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_27a9, 4); cmp(memb[ds, eax + 0x3e], 0x1e);        /* cmp byte [eax+0x3e], 0x1e */
            ii(0x100f_27ad, 2); if(jnz(0x100f_27cd, 0x1e)) goto l_0x100f_27cd; /* jnz 0x100f27cd */
            ii(0x100f_27af, 5); call(0x100d_5470, -0x1_d344);           /* call 0x100d5470 */
            ii(0x100f_27b4, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_27b7, 5); mov(ebx, 0x3b3);                        /* mov ebx, 0x3b3 */
            ii(0x100f_27bc, 5); mov(edx, 0x3ac);                        /* mov edx, 0x3ac */
            ii(0x100f_27c1, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_27c6, 5); call(0x1013_daea, 0x4_b31f);            /* call 0x1013daea */
            ii(0x100f_27cb, 2); jmp(0x100f_2810, 0x43); goto l_0x100f_2810; /* jmp 0x100f2810 */
        l_0x100f_27cd:
            ii(0x100f_27cd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_27d0, 4); cmp(memb[ds, eax + 0x3e], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100f_27d4, 2); if(jnz(0x100f_27f4, 0x1e)) goto l_0x100f_27f4; /* jnz 0x100f27f4 */
            ii(0x100f_27d6, 5); call(0x100d_5470, -0x1_d36b);           /* call 0x100d5470 */
            ii(0x100f_27db, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_27de, 5); mov(ebx, 0x3b7);                        /* mov ebx, 0x3b7 */
            ii(0x100f_27e3, 5); mov(edx, 0x3b4);                        /* mov edx, 0x3b4 */
            ii(0x100f_27e8, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_27ed, 5); call(0x1013_daea, 0x4_b2f8);            /* call 0x1013daea */
            ii(0x100f_27f2, 2); jmp(0x100f_2810, 0x1c); goto l_0x100f_2810; /* jmp 0x100f2810 */
        l_0x100f_27f4:
            ii(0x100f_27f4, 5); call(0x100d_5470, -0x1_d389);           /* call 0x100d5470 */
            ii(0x100f_27f9, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_27fc, 5); mov(ebx, 0x399);                        /* mov ebx, 0x399 */
            ii(0x100f_2801, 5); mov(edx, 0x398);                        /* mov edx, 0x398 */
            ii(0x100f_2806, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_280b, 5); call(0x1013_daea, 0x4_b2da);            /* call 0x1013daea */
        l_0x100f_2810:
            ii(0x100f_2810, 5); jmp(0x100f_2899, 0x84); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_2815:
            ii(0x100f_2815, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2818, 5); cmp(memw[ds, eax + 8], 0x1d);           /* cmp word [eax+0x8], 0x1d */
            ii(0x100f_281d, 2); if(jnz(0x100f_2828, 9)) goto l_0x100f_2828; /* jnz 0x100f2828 */
            ii(0x100f_281f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2822, 4); cmp(memb[ds, eax + 0x3d], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100f_2826, 2); if(jz(0x100f_282a, 2)) goto l_0x100f_282a; /* jz 0x100f282a */
        l_0x100f_2828:
            ii(0x100f_2828, 2); jmp(0x100f_2852, 0x28); goto l_0x100f_2852; /* jmp 0x100f2852 */
        l_0x100f_282a:
            ii(0x100f_282a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_282d, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100f_2830, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_2835, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x100f_283b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_283e, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x100f_2841, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_2844, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x100f_2847, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_2849, 7); cmp(memd[ds, eax + 0x101c_a4f4], 0);    /* cmp dword [eax+0x101ca4f4], 0x0 */
            ii(0x100f_2850, 2); if(jz(0x100f_2854, 2)) goto l_0x100f_2854; /* jz 0x100f2854 */
        l_0x100f_2852:
            ii(0x100f_2852, 2); jmp(0x100f_2872, 0x1e); goto l_0x100f_2872; /* jmp 0x100f2872 */
        l_0x100f_2854:
            ii(0x100f_2854, 5); call(0x100d_5470, -0x1_d3e9);           /* call 0x100d5470 */
            ii(0x100f_2859, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_285c, 5); mov(ebx, 0x43a);                        /* mov ebx, 0x43a */
            ii(0x100f_2861, 5); mov(edx, 0x439);                        /* mov edx, 0x439 */
            ii(0x100f_2866, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_286b, 5); call(0x1013_daea, 0x4_b27a);            /* call 0x1013daea */
            ii(0x100f_2870, 2); jmp(0x100f_2899, 0x27); goto l_0x100f_2899; /* jmp 0x100f2899 */
        l_0x100f_2872:
            ii(0x100f_2872, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_2875, 6); test(memw[ds, eax + 0x12], 0x1c0);      /* test word [eax+0x12], 0x1c0 */
            ii(0x100f_287b, 2); if(jz(0x100f_2899, 0x1c)) goto l_0x100f_2899; /* jz 0x100f2899 */
            ii(0x100f_287d, 5); call(0x100d_5470, -0x1_d412);           /* call 0x100d5470 */
            ii(0x100f_2882, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_2885, 5); mov(ebx, 0x397);                        /* mov ebx, 0x397 */
            ii(0x100f_288a, 5); mov(edx, 0x390);                        /* mov edx, 0x390 */
            ii(0x100f_288f, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_2894, 5); call(0x1013_daea, 0x4_b251);            /* call 0x1013daea */
        l_0x100f_2899:
            ii(0x100f_2899, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_289b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_289c, 1); pop(edi);                               /* pop edi */
            ii(0x100f_289d, 1); pop(esi);                               /* pop esi */
            ii(0x100f_289e, 1); pop(edx);                               /* pop edx */
            ii(0x100f_289f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_28a0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_28a1, 1); ret();                                  /* ret */
        }
    }
}
