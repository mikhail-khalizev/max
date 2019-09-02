using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_25d4-62ed8066")]
        public void Method_100d_25d4()
        {
            ii(0x100d_25d4, 5); push(0x198);                            /* push 0x198 */
            ii(0x100d_25d9, 5); call(Definitions.sys_check_available_stack_size, 0x9_3774); /* call 0x10165d52 */
            ii(0x100d_25de, 1); push(ebx);                              /* push ebx */
            ii(0x100d_25df, 1); push(ecx);                              /* push ecx */
            ii(0x100d_25e0, 1); push(esi);                              /* push esi */
            ii(0x100d_25e1, 1); push(edi);                              /* push edi */
            ii(0x100d_25e2, 1); push(ebp);                              /* push ebp */
            ii(0x100d_25e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_25e5, 6); sub(esp, 0x168);                        /* sub esp, 0x168 */
            ii(0x100d_25eb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_25ee, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_25f1, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100d_25f4, 5); mov(edx, 0x6c8);                        /* mov edx, 0x6c8 */
            ii(0x100d_25f9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_25fc, 5); call(0x100d_0ebd, -0x1744);             /* call 0x100d0ebd */
            ii(0x100d_2601, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_2604, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x100d_2607, 6); mov(memd[ss, ebp - 0x108], eax);        /* mov [ebp-0x108], eax */
            ii(0x100d_260d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2610, 7); mov(memd[ds, eax + 0x13], 0x101b_5c6c); /* mov dword [eax+0x13], 0x101b5c6c */
            ii(0x100d_2617, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x100d_261c, 5); call(/* sys */ 0x1016_a24c, 0x9_7c2b);  /* call 0x1016a24c */
            ii(0x100d_2621, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_2626, 5); call(Definitions.sys_new, 0x9_37d5);    /* call 0x10165e00 */
            ii(0x100d_262b, 6); mov(memd[ss, ebp - 0xfc], eax);         /* mov [ebp-0xfc], eax */
            ii(0x100d_2631, 6); mov(eax, memd[ss, ebp - 0xfc]);         /* mov eax, [ebp-0xfc] */
            ii(0x100d_2637, 6); mov(memd[ss, ebp - 0x100], eax);        /* mov [ebp-0x100], eax */
            ii(0x100d_263d, 7); cmp(memd[ss, ebp - 0x100], 0);          /* cmp dword [ebp-0x100], 0x0 */
            ii(0x100d_2644, 2); if(jz(0x100d_2677, 0x31)) goto l_0x100d_2677; /* jz 0x100d2677 */
            ii(0x100d_2646, 5); mov(eax, 0x1b9);                        /* mov eax, 0x1b9 */
            ii(0x100d_264b, 1); push(eax);                              /* push eax */
            ii(0x100d_264c, 5); mov(ecx, 0x1d7);                        /* mov ecx, 0x1d7 */
            ii(0x100d_2651, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x100d_2656, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x100d_265b, 6); mov(eax, memd[ss, ebp - 0xfc]);         /* mov eax, [ebp-0xfc] */
            ii(0x100d_2661, 5); call(Definitions.my_ctor_c17, -0x4257); /* call 0x100ce40f */
            ii(0x100d_2666, 6); mov(memd[ss, ebp - 0x104], eax);        /* mov [ebp-0x104], eax */
            ii(0x100d_266c, 6); mov(eax, memd[ss, ebp - 0x104]);        /* mov eax, [ebp-0x104] */
            ii(0x100d_2672, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_2675, 2); jmp(0x100d_2680, 9); goto l_0x100d_2680; /* jmp 0x100d2680 */
        l_0x100d_2677:
            ii(0x100d_2677, 6); mov(eax, memd[ss, ebp - 0x100]);        /* mov eax, [ebp-0x100] */
            ii(0x100d_267d, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
        l_0x100d_2680:
            ii(0x100d_2680, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_2683, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2686, 3); mov(memd[ds, edx + 0x42], eax);         /* mov [edx+0x42], eax */
            ii(0x100d_2689, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_268e, 5); call(Definitions.sys_new, 0x9_376d);    /* call 0x10165e00 */
            ii(0x100d_2693, 6); mov(memd[ss, ebp - 0xf0], eax);         /* mov [ebp-0xf0], eax */
            ii(0x100d_2699, 6); mov(eax, memd[ss, ebp - 0xf0]);         /* mov eax, [ebp-0xf0] */
            ii(0x100d_269f, 6); mov(memd[ss, ebp - 0xf4], eax);         /* mov [ebp-0xf4], eax */
            ii(0x100d_26a5, 7); cmp(memd[ss, ebp - 0xf4], 0);           /* cmp dword [ebp-0xf4], 0x0 */
            ii(0x100d_26ac, 2); if(jz(0x100d_26df, 0x31)) goto l_0x100d_26df; /* jz 0x100d26df */
            ii(0x100d_26ae, 5); mov(eax, 0x1b9);                        /* mov eax, 0x1b9 */
            ii(0x100d_26b3, 1); push(eax);                              /* push eax */
            ii(0x100d_26b4, 5); mov(ecx, 0x1eb);                        /* mov ecx, 0x1eb */
            ii(0x100d_26b9, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x100d_26be, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x100d_26c3, 6); mov(eax, memd[ss, ebp - 0xf0]);         /* mov eax, [ebp-0xf0] */
            ii(0x100d_26c9, 5); call(Definitions.my_ctor_c17, -0x42bf); /* call 0x100ce40f */
            ii(0x100d_26ce, 6); mov(memd[ss, ebp - 0xf8], eax);         /* mov [ebp-0xf8], eax */
            ii(0x100d_26d4, 6); mov(eax, memd[ss, ebp - 0xf8]);         /* mov eax, [ebp-0xf8] */
            ii(0x100d_26da, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_26dd, 2); jmp(0x100d_26e8, 9); goto l_0x100d_26e8; /* jmp 0x100d26e8 */
        l_0x100d_26df:
            ii(0x100d_26df, 6); mov(eax, memd[ss, ebp - 0xf4]);         /* mov eax, [ebp-0xf4] */
            ii(0x100d_26e5, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
        l_0x100d_26e8:
            ii(0x100d_26e8, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_26eb, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_26ee, 3); mov(memd[ds, edx + 0x46], eax);         /* mov [edx+0x46], eax */
            ii(0x100d_26f1, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_26f6, 5); call(Definitions.sys_new, 0x9_3705);    /* call 0x10165e00 */
            ii(0x100d_26fb, 6); mov(memd[ss, ebp - 0xe4], eax);         /* mov [ebp-0xe4], eax */
            ii(0x100d_2701, 6); mov(eax, memd[ss, ebp - 0xe4]);         /* mov eax, [ebp-0xe4] */
            ii(0x100d_2707, 6); mov(memd[ss, ebp - 0xe8], eax);         /* mov [ebp-0xe8], eax */
            ii(0x100d_270d, 7); cmp(memd[ss, ebp - 0xe8], 0);           /* cmp dword [ebp-0xe8], 0x0 */
            ii(0x100d_2714, 2); if(jz(0x100d_2747, 0x31)) goto l_0x100d_2747; /* jz 0x100d2747 */
            ii(0x100d_2716, 5); mov(eax, 0x108);                        /* mov eax, 0x108 */
            ii(0x100d_271b, 1); push(eax);                              /* push eax */
            ii(0x100d_271c, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_2721, 5); mov(ebx, 0x129);                        /* mov ebx, 0x129 */
            ii(0x100d_2726, 5); mov(edx, 0x128);                        /* mov edx, 0x128 */
            ii(0x100d_272b, 6); mov(eax, memd[ss, ebp - 0xe4]);         /* mov eax, [ebp-0xe4] */
            ii(0x100d_2731, 5); call(Definitions.my_ctor_c17, -0x4327); /* call 0x100ce40f */
            ii(0x100d_2736, 6); mov(memd[ss, ebp - 0xec], eax);         /* mov [ebp-0xec], eax */
            ii(0x100d_273c, 6); mov(eax, memd[ss, ebp - 0xec]);         /* mov eax, [ebp-0xec] */
            ii(0x100d_2742, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_2745, 2); jmp(0x100d_2750, 9); goto l_0x100d_2750; /* jmp 0x100d2750 */
        l_0x100d_2747:
            ii(0x100d_2747, 6); mov(eax, memd[ss, ebp - 0xe8]);         /* mov eax, [ebp-0xe8] */
            ii(0x100d_274d, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
        l_0x100d_2750:
            ii(0x100d_2750, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100d_2753, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2756, 3); mov(memd[ds, edx + 0x4a], eax);         /* mov [edx+0x4a], eax */
            ii(0x100d_2759, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_275e, 5); call(Definitions.sys_new, 0x9_369d);    /* call 0x10165e00 */
            ii(0x100d_2763, 6); mov(memd[ss, ebp - 0xd8], eax);         /* mov [ebp-0xd8], eax */
            ii(0x100d_2769, 6); mov(eax, memd[ss, ebp - 0xd8]);         /* mov eax, [ebp-0xd8] */
            ii(0x100d_276f, 6); mov(memd[ss, ebp - 0xdc], eax);         /* mov [ebp-0xdc], eax */
            ii(0x100d_2775, 7); cmp(memd[ss, ebp - 0xdc], 0);           /* cmp dword [ebp-0xdc], 0x0 */
            ii(0x100d_277c, 2); if(jz(0x100d_27af, 0x31)) goto l_0x100d_27af; /* jz 0x100d27af */
            ii(0x100d_277e, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_2783, 1); push(eax);                              /* push eax */
            ii(0x100d_2784, 5); mov(ecx, 0x18d);                        /* mov ecx, 0x18d */
            ii(0x100d_2789, 5); mov(ebx, 0x123);                        /* mov ebx, 0x123 */
            ii(0x100d_278e, 5); mov(edx, 0x122);                        /* mov edx, 0x122 */
            ii(0x100d_2793, 6); mov(eax, memd[ss, ebp - 0xd8]);         /* mov eax, [ebp-0xd8] */
            ii(0x100d_2799, 5); call(Definitions.my_ctor_c17, -0x438f); /* call 0x100ce40f */
            ii(0x100d_279e, 6); mov(memd[ss, ebp - 0xe0], eax);         /* mov [ebp-0xe0], eax */
            ii(0x100d_27a4, 6); mov(eax, memd[ss, ebp - 0xe0]);         /* mov eax, [ebp-0xe0] */
            ii(0x100d_27aa, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_27ad, 2); jmp(0x100d_27b8, 9); goto l_0x100d_27b8; /* jmp 0x100d27b8 */
        l_0x100d_27af:
            ii(0x100d_27af, 6); mov(eax, memd[ss, ebp - 0xdc]);         /* mov eax, [ebp-0xdc] */
            ii(0x100d_27b5, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x100d_27b8:
            ii(0x100d_27b8, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_27bb, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_27be, 3); mov(memd[ds, edx + 0x4e], eax);         /* mov [edx+0x4e], eax */
            ii(0x100d_27c1, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_27c6, 5); call(Definitions.sys_new, 0x9_3635);    /* call 0x10165e00 */
            ii(0x100d_27cb, 6); mov(memd[ss, ebp - 0xcc], eax);         /* mov [ebp-0xcc], eax */
            ii(0x100d_27d1, 6); mov(eax, memd[ss, ebp - 0xcc]);         /* mov eax, [ebp-0xcc] */
            ii(0x100d_27d7, 6); mov(memd[ss, ebp - 0xd0], eax);         /* mov [ebp-0xd0], eax */
            ii(0x100d_27dd, 7); cmp(memd[ss, ebp - 0xd0], 0);           /* cmp dword [ebp-0xd0], 0x0 */
            ii(0x100d_27e4, 2); if(jz(0x100d_2817, 0x31)) goto l_0x100d_2817; /* jz 0x100d2817 */
            ii(0x100d_27e6, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_27eb, 1); push(eax);                              /* push eax */
            ii(0x100d_27ec, 5); mov(ecx, 0x172);                        /* mov ecx, 0x172 */
            ii(0x100d_27f1, 5); mov(ebx, 0x12d);                        /* mov ebx, 0x12d */
            ii(0x100d_27f6, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x100d_27fb, 6); mov(eax, memd[ss, ebp - 0xcc]);         /* mov eax, [ebp-0xcc] */
            ii(0x100d_2801, 5); call(Definitions.my_ctor_c17, -0x43f7); /* call 0x100ce40f */
            ii(0x100d_2806, 6); mov(memd[ss, ebp - 0xd4], eax);         /* mov [ebp-0xd4], eax */
            ii(0x100d_280c, 6); mov(eax, memd[ss, ebp - 0xd4]);         /* mov eax, [ebp-0xd4] */
            ii(0x100d_2812, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_2815, 2); jmp(0x100d_2820, 9); goto l_0x100d_2820; /* jmp 0x100d2820 */
        l_0x100d_2817:
            ii(0x100d_2817, 6); mov(eax, memd[ss, ebp - 0xd0]);         /* mov eax, [ebp-0xd0] */
            ii(0x100d_281d, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x100d_2820:
            ii(0x100d_2820, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_2823, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2826, 3); mov(memd[ds, edx + 0x52], eax);         /* mov [edx+0x52], eax */
            ii(0x100d_2829, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_282e, 5); call(Definitions.sys_new, 0x9_35cd);    /* call 0x10165e00 */
            ii(0x100d_2833, 6); mov(memd[ss, ebp - 0xc0], eax);         /* mov [ebp-0xc0], eax */
            ii(0x100d_2839, 6); mov(eax, memd[ss, ebp - 0xc0]);         /* mov eax, [ebp-0xc0] */
            ii(0x100d_283f, 6); mov(memd[ss, ebp - 0xc4], eax);         /* mov [ebp-0xc4], eax */
            ii(0x100d_2845, 7); cmp(memd[ss, ebp - 0xc4], 0);           /* cmp dword [ebp-0xc4], 0x0 */
            ii(0x100d_284c, 2); if(jz(0x100d_287f, 0x31)) goto l_0x100d_287f; /* jz 0x100d287f */
            ii(0x100d_284e, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_2853, 1); push(eax);                              /* push eax */
            ii(0x100d_2854, 5); mov(ecx, 0x133);                        /* mov ecx, 0x133 */
            ii(0x100d_2859, 5); mov(ebx, 0x12b);                        /* mov ebx, 0x12b */
            ii(0x100d_285e, 5); mov(edx, 0x12a);                        /* mov edx, 0x12a */
            ii(0x100d_2863, 6); mov(eax, memd[ss, ebp - 0xc0]);         /* mov eax, [ebp-0xc0] */
            ii(0x100d_2869, 5); call(Definitions.my_ctor_c17, -0x445f); /* call 0x100ce40f */
            ii(0x100d_286e, 6); mov(memd[ss, ebp - 0xc8], eax);         /* mov [ebp-0xc8], eax */
            ii(0x100d_2874, 6); mov(eax, memd[ss, ebp - 0xc8]);         /* mov eax, [ebp-0xc8] */
            ii(0x100d_287a, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_287d, 2); jmp(0x100d_2888, 9); goto l_0x100d_2888; /* jmp 0x100d2888 */
        l_0x100d_287f:
            ii(0x100d_287f, 6); mov(eax, memd[ss, ebp - 0xc4]);         /* mov eax, [ebp-0xc4] */
            ii(0x100d_2885, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100d_2888:
            ii(0x100d_2888, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_288b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_288e, 3); mov(memd[ds, edx + 0x56], eax);         /* mov [edx+0x56], eax */
            ii(0x100d_2891, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_2896, 5); call(Definitions.sys_new, 0x9_3565);    /* call 0x10165e00 */
            ii(0x100d_289b, 6); mov(memd[ss, ebp - 0xb4], eax);         /* mov [ebp-0xb4], eax */
            ii(0x100d_28a1, 6); mov(eax, memd[ss, ebp - 0xb4]);         /* mov eax, [ebp-0xb4] */
            ii(0x100d_28a7, 6); mov(memd[ss, ebp - 0xb8], eax);         /* mov [ebp-0xb8], eax */
            ii(0x100d_28ad, 7); cmp(memd[ss, ebp - 0xb8], 0);           /* cmp dword [ebp-0xb8], 0x0 */
            ii(0x100d_28b4, 2); if(jz(0x100d_28e7, 0x31)) goto l_0x100d_28e7; /* jz 0x100d28e7 */
            ii(0x100d_28b6, 5); mov(eax, 0x159);                        /* mov eax, 0x159 */
            ii(0x100d_28bb, 1); push(eax);                              /* push eax */
            ii(0x100d_28bc, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_28c1, 5); mov(ebx, 0x121);                        /* mov ebx, 0x121 */
            ii(0x100d_28c6, 5); mov(edx, 0x120);                        /* mov edx, 0x120 */
            ii(0x100d_28cb, 6); mov(eax, memd[ss, ebp - 0xb4]);         /* mov eax, [ebp-0xb4] */
            ii(0x100d_28d1, 5); call(Definitions.my_ctor_c17, -0x44c7); /* call 0x100ce40f */
            ii(0x100d_28d6, 6); mov(memd[ss, ebp - 0xbc], eax);         /* mov [ebp-0xbc], eax */
            ii(0x100d_28dc, 6); mov(eax, memd[ss, ebp - 0xbc]);         /* mov eax, [ebp-0xbc] */
            ii(0x100d_28e2, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_28e5, 2); jmp(0x100d_28f0, 9); goto l_0x100d_28f0; /* jmp 0x100d28f0 */
        l_0x100d_28e7:
            ii(0x100d_28e7, 6); mov(eax, memd[ss, ebp - 0xb8]);         /* mov eax, [ebp-0xb8] */
            ii(0x100d_28ed, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x100d_28f0:
            ii(0x100d_28f0, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_28f3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_28f6, 3); mov(memd[ds, edx + 0x5e], eax);         /* mov [edx+0x5e], eax */
            ii(0x100d_28f9, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_28fe, 5); call(Definitions.sys_new, 0x9_34fd);    /* call 0x10165e00 */
            ii(0x100d_2903, 6); mov(memd[ss, ebp - 0xa8], eax);         /* mov [ebp-0xa8], eax */
            ii(0x100d_2909, 6); mov(eax, memd[ss, ebp - 0xa8]);         /* mov eax, [ebp-0xa8] */
            ii(0x100d_290f, 6); mov(memd[ss, ebp - 0xac], eax);         /* mov [ebp-0xac], eax */
            ii(0x100d_2915, 7); cmp(memd[ss, ebp - 0xac], 0);           /* cmp dword [ebp-0xac], 0x0 */
            ii(0x100d_291c, 2); if(jz(0x100d_294f, 0x31)) goto l_0x100d_294f; /* jz 0x100d294f */
            ii(0x100d_291e, 5); mov(eax, 0x171);                        /* mov eax, 0x171 */
            ii(0x100d_2923, 1); push(eax);                              /* push eax */
            ii(0x100d_2924, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_2929, 5); mov(ebx, 0x131);                        /* mov ebx, 0x131 */
            ii(0x100d_292e, 5); mov(edx, 0x130);                        /* mov edx, 0x130 */
            ii(0x100d_2933, 6); mov(eax, memd[ss, ebp - 0xa8]);         /* mov eax, [ebp-0xa8] */
            ii(0x100d_2939, 5); call(Definitions.my_ctor_c17, -0x452f); /* call 0x100ce40f */
            ii(0x100d_293e, 6); mov(memd[ss, ebp - 0xb0], eax);         /* mov [ebp-0xb0], eax */
            ii(0x100d_2944, 6); mov(eax, memd[ss, ebp - 0xb0]);         /* mov eax, [ebp-0xb0] */
            ii(0x100d_294a, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100d_294d, 2); jmp(0x100d_2958, 9); goto l_0x100d_2958; /* jmp 0x100d2958 */
        l_0x100d_294f:
            ii(0x100d_294f, 6); mov(eax, memd[ss, ebp - 0xac]);         /* mov eax, [ebp-0xac] */
            ii(0x100d_2955, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x100d_2958:
            ii(0x100d_2958, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_295b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_295e, 3); mov(memd[ds, edx + 0x62], eax);         /* mov [edx+0x62], eax */
            ii(0x100d_2961, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_2966, 5); call(Definitions.sys_new, 0x9_3495);    /* call 0x10165e00 */
            ii(0x100d_296b, 6); mov(memd[ss, ebp - 0x9c], eax);         /* mov [ebp-0x9c], eax */
            ii(0x100d_2971, 6); mov(eax, memd[ss, ebp - 0x9c]);         /* mov eax, [ebp-0x9c] */
            ii(0x100d_2977, 6); mov(memd[ss, ebp - 0xa0], eax);         /* mov [ebp-0xa0], eax */
            ii(0x100d_297d, 7); cmp(memd[ss, ebp - 0xa0], 0);           /* cmp dword [ebp-0xa0], 0x0 */
            ii(0x100d_2984, 2); if(jz(0x100d_29b7, 0x31)) goto l_0x100d_29b7; /* jz 0x100d29b7 */
            ii(0x100d_2986, 5); mov(eax, 0x18a);                        /* mov eax, 0x18a */
            ii(0x100d_298b, 1); push(eax);                              /* push eax */
            ii(0x100d_298c, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_2991, 5); mov(ebx, 0x133);                        /* mov ebx, 0x133 */
            ii(0x100d_2996, 5); mov(edx, 0x132);                        /* mov edx, 0x132 */
            ii(0x100d_299b, 6); mov(eax, memd[ss, ebp - 0x9c]);         /* mov eax, [ebp-0x9c] */
            ii(0x100d_29a1, 5); call(Definitions.my_ctor_c17, -0x4597); /* call 0x100ce40f */
            ii(0x100d_29a6, 6); mov(memd[ss, ebp - 0xa4], eax);         /* mov [ebp-0xa4], eax */
            ii(0x100d_29ac, 6); mov(eax, memd[ss, ebp - 0xa4]);         /* mov eax, [ebp-0xa4] */
            ii(0x100d_29b2, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_29b5, 2); jmp(0x100d_29c0, 9); goto l_0x100d_29c0; /* jmp 0x100d29c0 */
        l_0x100d_29b7:
            ii(0x100d_29b7, 6); mov(eax, memd[ss, ebp - 0xa0]);         /* mov eax, [ebp-0xa0] */
            ii(0x100d_29bd, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100d_29c0:
            ii(0x100d_29c0, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_29c3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_29c6, 3); mov(memd[ds, edx + 0x66], eax);         /* mov [edx+0x66], eax */
            ii(0x100d_29c9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_29cc, 5); cmp(memw[ds, eax + 8], 0x3d);           /* cmp word [eax+0x8], 0x3d */
            ii(0x100d_29d1, 6); if(jnz(0x100d_2a98, 0xc1)) goto l_0x100d_2a98; /* jnz 0x100d2a98 */
            ii(0x100d_29d7, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_29dc, 5); call(Definitions.sys_new, 0x9_341f);    /* call 0x10165e00 */
            ii(0x100d_29e1, 6); mov(memd[ss, ebp - 0x11c], eax);        /* mov [ebp-0x11c], eax */
            ii(0x100d_29e7, 6); mov(eax, memd[ss, ebp - 0x11c]);        /* mov eax, [ebp-0x11c] */
            ii(0x100d_29ed, 6); mov(memd[ss, ebp - 0x120], eax);        /* mov [ebp-0x120], eax */
            ii(0x100d_29f3, 7); cmp(memd[ss, ebp - 0x120], 0);          /* cmp dword [ebp-0x120], 0x0 */
            ii(0x100d_29fa, 2); if(jz(0x100d_2a30, 0x34)) goto l_0x100d_2a30; /* jz 0x100d2a30 */
            ii(0x100d_29fc, 5); mov(eax, 0x1ab);                        /* mov eax, 0x1ab */
            ii(0x100d_2a01, 1); push(eax);                              /* push eax */
            ii(0x100d_2a02, 5); mov(ecx, 0x15b);                        /* mov ecx, 0x15b */
            ii(0x100d_2a07, 5); mov(ebx, 0x12f);                        /* mov ebx, 0x12f */
            ii(0x100d_2a0c, 5); mov(edx, 0x12e);                        /* mov edx, 0x12e */
            ii(0x100d_2a11, 6); mov(eax, memd[ss, ebp - 0x11c]);        /* mov eax, [ebp-0x11c] */
            ii(0x100d_2a17, 5); call(Definitions.my_ctor_c17, -0x460d); /* call 0x100ce40f */
            ii(0x100d_2a1c, 6); mov(memd[ss, ebp - 0x124], eax);        /* mov [ebp-0x124], eax */
            ii(0x100d_2a22, 6); mov(eax, memd[ss, ebp - 0x124]);        /* mov eax, [ebp-0x124] */
            ii(0x100d_2a28, 6); mov(memd[ss, ebp - 0x128], eax);        /* mov [ebp-0x128], eax */
            ii(0x100d_2a2e, 2); jmp(0x100d_2a3c, 0xc); goto l_0x100d_2a3c; /* jmp 0x100d2a3c */
        l_0x100d_2a30:
            ii(0x100d_2a30, 6); mov(eax, memd[ss, ebp - 0x120]);        /* mov eax, [ebp-0x120] */
            ii(0x100d_2a36, 6); mov(memd[ss, ebp - 0x128], eax);        /* mov [ebp-0x128], eax */
        l_0x100d_2a3c:
            ii(0x100d_2a3c, 6); mov(eax, memd[ss, ebp - 0x128]);        /* mov eax, [ebp-0x128] */
            ii(0x100d_2a42, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2a45, 3); mov(memd[ds, edx + 0x5a], eax);         /* mov [edx+0x5a], eax */
            ii(0x100d_2a48, 6); lea(eax, memd[ss, ebp - 0x12c]);        /* lea eax, [ebp-0x12c] */
            ii(0x100d_2a4e, 5); call(0x100d_5224, 0x27d1);              /* call 0x100d5224 */
            ii(0x100d_2a53, 1); push(eax);                              /* push eax */
            ii(0x100d_2a54, 6); lea(eax, memd[ss, ebp - 0x114]);        /* lea eax, [ebp-0x114] */
            ii(0x100d_2a5a, 5); call(0x100d_5250, 0x27f1);              /* call 0x100d5250 */
            ii(0x100d_2a5f, 1); push(eax);                              /* push eax */
            ii(0x100d_2a60, 6); lea(eax, memd[ss, ebp - 0x118]);        /* lea eax, [ebp-0x118] */
            ii(0x100d_2a66, 5); call(0x100d_527c, 0x2811);              /* call 0x100d527c */
            ii(0x100d_2a6b, 1); push(eax);                              /* push eax */
            ii(0x100d_2a6c, 6); lea(eax, memd[ss, ebp - 0x110]);        /* lea eax, [ebp-0x110] */
            ii(0x100d_2a72, 5); call(0x100d_52a8, 0x2831);              /* call 0x100d52a8 */
            ii(0x100d_2a77, 1); push(eax);                              /* push eax */
            ii(0x100d_2a78, 5); call(0x100d_52d4, 0x2857);              /* call 0x100d52d4 */
            ii(0x100d_2a7d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_2a80, 5); call(0x100d_52f8, 0x2873);              /* call 0x100d52f8 */
            ii(0x100d_2a85, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_2a88, 5); mov(edx, StringDefinitions.Path);       /* mov edx, 0x101a149d */
            ii(0x100d_2a8d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2a90, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x100d_2a93, 5); call(0x100c_ef64, -0x3b34);             /* call 0x100cef64 */
        l_0x100d_2a98:
            ii(0x100d_2a98, 5); mov(ecx, 6);                            /* mov ecx, 0x6 */
            ii(0x100d_2a9d, 6); lea(edi, memd[ss, ebp - 0x148]);        /* lea edi, [ebp-0x148] */
            ii(0x100d_2aa3, 3); mov(esi, memd[ss, ebp - 8]);            /* mov esi, [ebp-0x8] */
            ii(0x100d_2aa6, 3); lea(esi, memd[ds, esi + 0x17]);         /* lea esi, [esi+0x17] */
            ii(0x100d_2aa9, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x100d_2aab, 2); movsw();                                /* movsw */
            ii(0x100d_2aad, 10); mov(memd[ss, ebp - 0x148], 0x1e3);     /* mov dword [ebp-0x148], 0x1e3 */
            ii(0x100d_2ab7, 10); mov(memd[ss, ebp - 0x144], 0x3c);      /* mov dword [ebp-0x144], 0x3c */
            ii(0x100d_2ac1, 10); mov(memd[ss, ebp - 0x140], 0x256);     /* mov dword [ebp-0x140], 0x256 */
            ii(0x100d_2acb, 10); mov(memd[ss, ebp - 0x13c], 0x1ad);     /* mov dword [ebp-0x13c], 0x1ad */
            ii(0x100d_2ad5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2ad8, 3); mov(esi, memd[ds, eax + 0x25]);         /* mov esi, [eax+0x25] */
            ii(0x100d_2adb, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x100d_2ade, 7); imul(esi, memd[ss, ebp - 0x144]);       /* imul esi, [ebp-0x144] */
            ii(0x100d_2ae5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2ae8, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_2aeb, 6); add(eax, memd[ss, ebp - 0x148]);        /* add eax, [ebp-0x148] */
            ii(0x100d_2af1, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x100d_2af3, 6); mov(memd[ss, ebp - 0x132], eax);        /* mov [ebp-0x132], eax */
            ii(0x100d_2af9, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100d_2afe, 5); call(Definitions.sys_new, 0x9_32fd);    /* call 0x10165e00 */
            ii(0x100d_2b03, 6); mov(memd[ss, ebp - 0x90], eax);         /* mov [ebp-0x90], eax */
            ii(0x100d_2b09, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x100d_2b0f, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x100d_2b15, 7); cmp(memd[ss, ebp - 0x94], 0);           /* cmp dword [ebp-0x94], 0x0 */
            ii(0x100d_2b1c, 2); if(jz(0x100d_2b64, 0x46)) goto l_0x100d_2b64; /* jz 0x100d2b64 */
            ii(0x100d_2b1e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2b21, 3); push(memd[ds, eax + 0x46]);             /* push dword [eax+0x46] */
            ii(0x100d_2b24, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2b27, 3); push(memd[ds, eax + 0x42]);             /* push dword [eax+0x42] */
            ii(0x100d_2b2a, 5); mov(eax, 0x7d0);                        /* mov eax, 0x7d0 */
            ii(0x100d_2b2f, 1); push(eax);                              /* push eax */
            ii(0x100d_2b30, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2b33, 3); push(memd[ds, eax + 0x31]);             /* push dword [eax+0x31] */
            ii(0x100d_2b36, 3); mov(ecx, memd[ss, ebp - 8]);            /* mov ecx, [ebp-0x8] */
            ii(0x100d_2b39, 3); add(ecx, 0x3a);                         /* add ecx, 0x3a */
            ii(0x100d_2b3c, 6); lea(ebx, memd[ss, ebp - 0x148]);        /* lea ebx, [ebp-0x148] */
            ii(0x100d_2b42, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2b45, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x100d_2b4b, 5); call(0x100d_0b0a, -0x2046);             /* call 0x100d0b0a */
            ii(0x100d_2b50, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x100d_2b56, 6); mov(eax, memd[ss, ebp - 0x98]);         /* mov eax, [ebp-0x98] */
            ii(0x100d_2b5c, 6); mov(memd[ss, ebp - 0x14c], eax);        /* mov [ebp-0x14c], eax */
            ii(0x100d_2b62, 2); jmp(0x100d_2b70, 0xc); goto l_0x100d_2b70; /* jmp 0x100d2b70 */
        l_0x100d_2b64:
            ii(0x100d_2b64, 6); mov(eax, memd[ss, ebp - 0x94]);         /* mov eax, [ebp-0x94] */
            ii(0x100d_2b6a, 6); mov(memd[ss, ebp - 0x14c], eax);        /* mov [ebp-0x14c], eax */
        l_0x100d_2b70:
            ii(0x100d_2b70, 6); mov(eax, memd[ss, ebp - 0x14c]);        /* mov eax, [ebp-0x14c] */
            ii(0x100d_2b76, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2b79, 3); mov(memd[ds, edx + 0x3e], eax);         /* mov [edx+0x3e], eax */
            ii(0x100d_2b7c, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2b81, 5); call(Definitions.sys_new, 0x9_327a);    /* call 0x10165e00 */
            ii(0x100d_2b86, 6); mov(memd[ss, ebp - 0x84], eax);         /* mov [ebp-0x84], eax */
            ii(0x100d_2b8c, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x100d_2b92, 6); mov(memd[ss, ebp - 0x88], eax);         /* mov [ebp-0x88], eax */
            ii(0x100d_2b98, 7); cmp(memd[ss, ebp - 0x88], 0);           /* cmp dword [ebp-0x88], 0x0 */
            ii(0x100d_2b9f, 2); if(jz(0x100d_2bd5, 0x34)) goto l_0x100d_2bd5; /* jz 0x100d2bd5 */
            ii(0x100d_2ba1, 5); mov(eax, 0xae);                         /* mov eax, 0xae */
            ii(0x100d_2ba6, 1); push(eax);                              /* push eax */
            ii(0x100d_2ba7, 5); mov(ecx, 0xfa);                         /* mov ecx, 0xfa */
            ii(0x100d_2bac, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_2bb1, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x100d_2bb6, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x100d_2bbc, 5); call(0x100d_7bdc, 0x501b);              /* call 0x100d7bdc */
            ii(0x100d_2bc1, 6); mov(memd[ss, ebp - 0x8c], eax);         /* mov [ebp-0x8c], eax */
            ii(0x100d_2bc7, 6); mov(eax, memd[ss, ebp - 0x8c]);         /* mov eax, [ebp-0x8c] */
            ii(0x100d_2bcd, 6); mov(memd[ss, ebp - 0x150], eax);        /* mov [ebp-0x150], eax */
            ii(0x100d_2bd3, 2); jmp(0x100d_2be1, 0xc); goto l_0x100d_2be1; /* jmp 0x100d2be1 */
        l_0x100d_2bd5:
            ii(0x100d_2bd5, 6); mov(eax, memd[ss, ebp - 0x88]);         /* mov eax, [ebp-0x88] */
            ii(0x100d_2bdb, 6); mov(memd[ss, ebp - 0x150], eax);        /* mov [ebp-0x150], eax */
        l_0x100d_2be1:
            ii(0x100d_2be1, 6); mov(eax, memd[ss, ebp - 0x150]);        /* mov eax, [ebp-0x150] */
            ii(0x100d_2be7, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2bea, 3); mov(memd[ds, edx + 0x6a], eax);         /* mov [edx+0x6a], eax */
            ii(0x100d_2bed, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2bf2, 5); call(Definitions.sys_new, 0x9_3209);    /* call 0x10165e00 */
            ii(0x100d_2bf7, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x100d_2bfa, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x100d_2bfd, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x100d_2c00, 4); cmp(memd[ss, ebp - 0x7c], 0);           /* cmp dword [ebp-0x7c], 0x0 */
            ii(0x100d_2c04, 2); if(jz(0x100d_2c31, 0x2b)) goto l_0x100d_2c31; /* jz 0x100d2c31 */
            ii(0x100d_2c06, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_2c0b, 1); push(eax);                              /* push eax */
            ii(0x100d_2c0c, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100d_2c11, 5); mov(ebx, 0x15d);                        /* mov ebx, 0x15d */
            ii(0x100d_2c16, 5); mov(edx, 0x17a);                        /* mov edx, 0x17a */
            ii(0x100d_2c1b, 3); mov(eax, memd[ss, ebp - 0x78]);         /* mov eax, [ebp-0x78] */
            ii(0x100d_2c1e, 5); call(0x100d_7bdc, 0x4fb9);              /* call 0x100d7bdc */
            ii(0x100d_2c23, 3); mov(memd[ss, ebp - 0x80], eax);         /* mov [ebp-0x80], eax */
            ii(0x100d_2c26, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x100d_2c29, 6); mov(memd[ss, ebp - 0x154], eax);        /* mov [ebp-0x154], eax */
            ii(0x100d_2c2f, 2); jmp(0x100d_2c3a, 9); goto l_0x100d_2c3a; /* jmp 0x100d2c3a */
        l_0x100d_2c31:
            ii(0x100d_2c31, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x100d_2c34, 6); mov(memd[ss, ebp - 0x154], eax);        /* mov [ebp-0x154], eax */
        l_0x100d_2c3a:
            ii(0x100d_2c3a, 6); mov(eax, memd[ss, ebp - 0x154]);        /* mov eax, [ebp-0x154] */
            ii(0x100d_2c40, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2c43, 3); mov(memd[ds, edx + 0x6e], eax);         /* mov [edx+0x6e], eax */
            ii(0x100d_2c46, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2c4b, 5); call(Definitions.sys_new, 0x9_31b0);    /* call 0x10165e00 */
            ii(0x100d_2c50, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x100d_2c53, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100d_2c56, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x100d_2c59, 4); cmp(memd[ss, ebp - 0x70], 0);           /* cmp dword [ebp-0x70], 0x0 */
            ii(0x100d_2c5d, 2); if(jz(0x100d_2c8a, 0x2b)) goto l_0x100d_2c8a; /* jz 0x100d2c8a */
            ii(0x100d_2c5f, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_2c64, 1); push(eax);                              /* push eax */
            ii(0x100d_2c65, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x100d_2c6a, 5); mov(ebx, 0x15d);                        /* mov ebx, 0x15d */
            ii(0x100d_2c6f, 5); mov(edx, 0x19e);                        /* mov edx, 0x19e */
            ii(0x100d_2c74, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x100d_2c77, 5); call(0x100d_7bdc, 0x4f60);              /* call 0x100d7bdc */
            ii(0x100d_2c7c, 3); mov(memd[ss, ebp - 0x74], eax);         /* mov [ebp-0x74], eax */
            ii(0x100d_2c7f, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x100d_2c82, 6); mov(memd[ss, ebp - 0x158], eax);        /* mov [ebp-0x158], eax */
            ii(0x100d_2c88, 2); jmp(0x100d_2c93, 9); goto l_0x100d_2c93; /* jmp 0x100d2c93 */
        l_0x100d_2c8a:
            ii(0x100d_2c8a, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x100d_2c8d, 6); mov(memd[ss, ebp - 0x158], eax);        /* mov [ebp-0x158], eax */
        l_0x100d_2c93:
            ii(0x100d_2c93, 6); mov(eax, memd[ss, ebp - 0x158]);        /* mov eax, [ebp-0x158] */
            ii(0x100d_2c99, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2c9c, 3); mov(memd[ds, edx + 0x72], eax);         /* mov [edx+0x72], eax */
            ii(0x100d_2c9f, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2ca4, 5); call(Definitions.sys_new, 0x9_3157);    /* call 0x10165e00 */
            ii(0x100d_2ca9, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_2cac, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_2caf, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x100d_2cb2, 4); cmp(memd[ss, ebp - 0x64], 0);           /* cmp dword [ebp-0x64], 0x0 */
            ii(0x100d_2cb6, 2); if(jz(0x100d_2ce3, 0x2b)) goto l_0x100d_2ce3; /* jz 0x100d2ce3 */
            ii(0x100d_2cb8, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_2cbd, 1); push(eax);                              /* push eax */
            ii(0x100d_2cbe, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100d_2cc3, 5); mov(ebx, 0x176);                        /* mov ebx, 0x176 */
            ii(0x100d_2cc8, 5); mov(edx, 0x17a);                        /* mov edx, 0x17a */
            ii(0x100d_2ccd, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_2cd0, 5); call(0x100d_7bdc, 0x4f07);              /* call 0x100d7bdc */
            ii(0x100d_2cd5, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x100d_2cd8, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x100d_2cdb, 6); mov(memd[ss, ebp - 0x15c], eax);        /* mov [ebp-0x15c], eax */
            ii(0x100d_2ce1, 2); jmp(0x100d_2cec, 9); goto l_0x100d_2cec; /* jmp 0x100d2cec */
        l_0x100d_2ce3:
            ii(0x100d_2ce3, 3); mov(eax, memd[ss, ebp - 0x64]);         /* mov eax, [ebp-0x64] */
            ii(0x100d_2ce6, 6); mov(memd[ss, ebp - 0x15c], eax);        /* mov [ebp-0x15c], eax */
        l_0x100d_2cec:
            ii(0x100d_2cec, 6); mov(eax, memd[ss, ebp - 0x15c]);        /* mov eax, [ebp-0x15c] */
            ii(0x100d_2cf2, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2cf5, 3); mov(memd[ds, edx + 0x76], eax);         /* mov [edx+0x76], eax */
            ii(0x100d_2cf8, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2cfd, 5); call(Definitions.sys_new, 0x9_30fe);    /* call 0x10165e00 */
            ii(0x100d_2d02, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_2d05, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_2d08, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_2d0b, 4); cmp(memd[ss, ebp - 0x58], 0);           /* cmp dword [ebp-0x58], 0x0 */
            ii(0x100d_2d0f, 2); if(jz(0x100d_2d3c, 0x2b)) goto l_0x100d_2d3c; /* jz 0x100d2d3c */
            ii(0x100d_2d11, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_2d16, 1); push(eax);                              /* push eax */
            ii(0x100d_2d17, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x100d_2d1c, 5); mov(ebx, 0x176);                        /* mov ebx, 0x176 */
            ii(0x100d_2d21, 5); mov(edx, 0x19e);                        /* mov edx, 0x19e */
            ii(0x100d_2d26, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_2d29, 5); call(0x100d_7bdc, 0x4eae);              /* call 0x100d7bdc */
            ii(0x100d_2d2e, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_2d31, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x100d_2d34, 6); mov(memd[ss, ebp - 0x160], eax);        /* mov [ebp-0x160], eax */
            ii(0x100d_2d3a, 2); jmp(0x100d_2d45, 9); goto l_0x100d_2d45; /* jmp 0x100d2d45 */
        l_0x100d_2d3c:
            ii(0x100d_2d3c, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_2d3f, 6); mov(memd[ss, ebp - 0x160], eax);        /* mov [ebp-0x160], eax */
        l_0x100d_2d45:
            ii(0x100d_2d45, 6); mov(eax, memd[ss, ebp - 0x160]);        /* mov eax, [ebp-0x160] */
            ii(0x100d_2d4b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2d4e, 3); mov(memd[ds, edx + 0x7a], eax);         /* mov [edx+0x7a], eax */
            ii(0x100d_2d51, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2d56, 5); call(Definitions.sys_new, 0x9_30a5);    /* call 0x10165e00 */
            ii(0x100d_2d5b, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100d_2d5e, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100d_2d61, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_2d64, 4); cmp(memd[ss, ebp - 0x4c], 0);           /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100d_2d68, 2); if(jz(0x100d_2d95, 0x2b)) goto l_0x100d_2d95; /* jz 0x100d2d95 */
            ii(0x100d_2d6a, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_2d6f, 1); push(eax);                              /* push eax */
            ii(0x100d_2d70, 5); mov(ecx, 0x14);                         /* mov ecx, 0x14 */
            ii(0x100d_2d75, 5); mov(ebx, 0x18f);                        /* mov ebx, 0x18f */
            ii(0x100d_2d7a, 5); mov(edx, 0x17a);                        /* mov edx, 0x17a */
            ii(0x100d_2d7f, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100d_2d82, 5); call(0x100d_7bdc, 0x4e55);              /* call 0x100d7bdc */
            ii(0x100d_2d87, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_2d8a, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_2d8d, 6); mov(memd[ss, ebp - 0x164], eax);        /* mov [ebp-0x164], eax */
            ii(0x100d_2d93, 2); jmp(0x100d_2d9e, 9); goto l_0x100d_2d9e; /* jmp 0x100d2d9e */
        l_0x100d_2d95:
            ii(0x100d_2d95, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_2d98, 6); mov(memd[ss, ebp - 0x164], eax);        /* mov [ebp-0x164], eax */
        l_0x100d_2d9e:
            ii(0x100d_2d9e, 6); mov(eax, memd[ss, ebp - 0x164]);        /* mov eax, [ebp-0x164] */
            ii(0x100d_2da4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2da7, 3); mov(memd[ds, edx + 0x7e], eax);         /* mov [edx+0x7e], eax */
            ii(0x100d_2daa, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2daf, 5); call(Definitions.sys_new, 0x9_304c);    /* call 0x10165e00 */
            ii(0x100d_2db4, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100d_2db7, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100d_2dba, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100d_2dbd, 4); cmp(memd[ss, ebp - 0x40], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100d_2dc1, 2); if(jz(0x100d_2dee, 0x2b)) goto l_0x100d_2dee; /* jz 0x100d2dee */
            ii(0x100d_2dc3, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x100d_2dc8, 1); push(eax);                              /* push eax */
            ii(0x100d_2dc9, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x100d_2dce, 5); mov(ebx, 0x18f);                        /* mov ebx, 0x18f */
            ii(0x100d_2dd3, 5); mov(edx, 0x19e);                        /* mov edx, 0x19e */
            ii(0x100d_2dd8, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x100d_2ddb, 5); call(0x100d_7bdc, 0x4dfc);              /* call 0x100d7bdc */
            ii(0x100d_2de0, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100d_2de3, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100d_2de6, 6); mov(memd[ss, ebp - 0x168], eax);        /* mov [ebp-0x168], eax */
            ii(0x100d_2dec, 2); jmp(0x100d_2df7, 9); goto l_0x100d_2df7; /* jmp 0x100d2df7 */
        l_0x100d_2dee:
            ii(0x100d_2dee, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100d_2df1, 6); mov(memd[ss, ebp - 0x168], eax);        /* mov [ebp-0x168], eax */
        l_0x100d_2df7:
            ii(0x100d_2df7, 6); mov(eax, memd[ss, ebp - 0x168]);        /* mov eax, [ebp-0x168] */
            ii(0x100d_2dfd, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_2e00, 6); mov(memd[ds, edx + 0x82], eax);         /* mov [edx+0x82], eax */
            ii(0x100d_2e06, 5); call(0x100d_531c, 0x2511);              /* call 0x100d531c */
            ii(0x100d_2e0b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_2e10, 1); push(eax);                              /* push eax */
            ii(0x100d_2e11, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_2e16, 1); push(eax);                              /* push eax */
            ii(0x100d_2e17, 2); push(2);                                /* push 0x2 */
            ii(0x100d_2e19, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x100d_2e1e, 1); push(eax);                              /* push eax */
            ii(0x100d_2e1f, 5); mov(eax, 0x9e);                         /* mov eax, 0x9e */
            ii(0x100d_2e24, 1); push(eax);                              /* push eax */
            ii(0x100d_2e25, 5); mov(eax, 7);                            /* mov eax, 0x7 */
            ii(0x100d_2e2a, 1); push(eax);                              /* push eax */
            ii(0x100d_2e2b, 5); mov(ecx, 0x147);                        /* mov ecx, 0x147 */
            ii(0x100d_2e30, 5); mov(ebx, StringDefinitions.ConstructionMenu); /* mov ebx, 0x101a14a2 */
            ii(0x100d_2e35, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2e38, 3); mov(edx, memd[ds, eax + 0x25]);         /* mov edx, [eax+0x25] */
            ii(0x100d_2e3b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_2e3e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2e41, 3); mov(eax, memd[ds, eax + 0x2d]);         /* mov eax, [eax+0x2d] */
            ii(0x100d_2e44, 5); call(0x100e_9ae5, 0x1_6c9c);            /* call 0x100e9ae5 */
            ii(0x100d_2e49, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x100d_2e4e, 5); call(/* sys */ 0x1016_a24c, 0x9_73f9);  /* call 0x1016a24c */
            ii(0x100d_2e53, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_2e58, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_2e5b, 5); call(0x100d_4d78, 0x1f18);              /* call 0x100d4d78 */
            ii(0x100d_2e60, 1); push(eax);                              /* push eax */
            ii(0x100d_2e61, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_2e66, 1); push(eax);                              /* push eax */
            ii(0x100d_2e67, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_2e6c, 1); push(eax);                              /* push eax */
            ii(0x100d_2e6d, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_2e72, 1); push(eax);                              /* push eax */
            ii(0x100d_2e73, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x100d_2e78, 1); push(eax);                              /* push eax */
            ii(0x100d_2e79, 5); mov(ecx, 0x108);                        /* mov ecx, 0x108 */
            ii(0x100d_2e7e, 5); mov(ebx, 0xd1);                         /* mov ebx, 0xd1 */
            ii(0x100d_2e83, 5); mov(edx, StringDefinitions.Description3); /* mov edx, 0x101a14b4 */
            ii(0x100d_2e88, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2e8b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_2e8e, 5); call(0x100e_ab9d, 0x1_7d0a);            /* call 0x100eab9d */
            ii(0x100d_2e93, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_2e98, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_2e9b, 5); call(0x100d_4d78, 0x1ed8);              /* call 0x100d4d78 */
            ii(0x100d_2ea0, 1); push(eax);                              /* push eax */
            ii(0x100d_2ea1, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_2ea6, 1); push(eax);                              /* push eax */
            ii(0x100d_2ea7, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_2eac, 1); push(eax);                              /* push eax */
            ii(0x100d_2ead, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2eb2, 1); push(eax);                              /* push eax */
            ii(0x100d_2eb3, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x100d_2eb8, 1); push(eax);                              /* push eax */
            ii(0x100d_2eb9, 5); mov(ecx, 0x14a);                        /* mov ecx, 0x14a */
            ii(0x100d_2ebe, 5); mov(ebx, 0x170);                        /* mov ebx, 0x170 */
            ii(0x100d_2ec3, 5); mov(edx, StringDefinitions.Turns2);     /* mov edx, 0x101a14c0 */
            ii(0x100d_2ec8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2ecb, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_2ece, 5); call(0x100e_ab9d, 0x1_7cca);            /* call 0x100eab9d */
            ii(0x100d_2ed3, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_2ed8, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100d_2edb, 5); call(0x100d_4d78, 0x1e98);              /* call 0x100d4d78 */
            ii(0x100d_2ee0, 1); push(eax);                              /* push eax */
            ii(0x100d_2ee1, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_2ee6, 1); push(eax);                              /* push eax */
            ii(0x100d_2ee7, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_2eec, 1); push(eax);                              /* push eax */
            ii(0x100d_2eed, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_2ef2, 1); push(eax);                              /* push eax */
            ii(0x100d_2ef3, 5); mov(eax, 0x29);                         /* mov eax, 0x29 */
            ii(0x100d_2ef8, 1); push(eax);                              /* push eax */
            ii(0x100d_2ef9, 5); mov(ecx, 0x14a);                        /* mov ecx, 0x14a */
            ii(0x100d_2efe, 5); mov(ebx, 0x199);                        /* mov ebx, 0x199 */
            ii(0x100d_2f03, 5); mov(edx, StringDefinitions.Cost6);      /* mov edx, 0x101a14c6 */
            ii(0x100d_2f08, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2f0b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_2f0e, 5); call(0x100e_ab9d, 0x1_7c8a);            /* call 0x100eab9d */
            ii(0x100d_2f13, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_2f16, 6); mov(memd[ss, ebp - 0x10c], eax);        /* mov [ebp-0x10c], eax */
            ii(0x100d_2f1c, 6); mov(eax, memd[ss, ebp - 0x10c]);        /* mov eax, [ebp-0x10c] */
            ii(0x100d_2f22, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_2f24, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_2f25, 1); pop(edi);                               /* pop edi */
            ii(0x100d_2f26, 1); pop(esi);                               /* pop esi */
            ii(0x100d_2f27, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_2f28, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_2f29, 1); ret();                                  /* ret */
        }
    }
}
