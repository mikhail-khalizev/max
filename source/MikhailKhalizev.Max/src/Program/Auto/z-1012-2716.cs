using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e9ae9e2c-a5d3-4381-801a-db7eaea82259")]
        public void Method_1012_2716()
        {
            ii(0x1012_2716, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1012_271b, 5); calld(Definitions.sys_check_available_stack_size, 0x43632); /* call 0x10165d52 */
            ii(0x1012_2720, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_2721, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_2722, 1); pushd(esi);                             /* push esi */
            ii(0x1012_2723, 1); pushd(edi);                             /* push edi */
            ii(0x1012_2724, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_2725, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_2727, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1012_272d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_2730, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_2733, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2736, 4); cmp(memd_a32[ds, eax + 0x42], 0);       /* cmp dword [eax+0x42], 0x0 */
            ii(0x1012_273a, 2); if(jnzd(0x1012_2748, 0xc)) goto l_0x1012_2748; /* jnz 0x10122748 */
            ii(0x1012_273c, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_2743, 5); jmpd(0x1012_2906, 0x1be); goto l_0x1012_2906; /* jmp 0x10122906 */
        l_0x1012_2748:
            ii(0x1012_2748, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_274b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_274e, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_2751, 5); calld(0x100e_b283, -0x374d3);           /* call 0x100eb283 */
            ii(0x1012_2756, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2759, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_275c, 5); calld(0x100e_b68a, -0x370d7);           /* call 0x100eb68a */
            ii(0x1012_2761, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2764, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_2767, 5); calld(0x100e_b226, -0x37546);           /* call 0x100eb226 */
            ii(0x1012_276c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_276f, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_2772, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_2775, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1012_2779, 2); if(jzd(0x1012_278f, 0x14)) goto l_0x1012_278f; /* jz 0x1012278f */
            ii(0x1012_277b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_277d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_2780, 5); calld(Definitions.my_dtor_d6, -0x376ae); /* call 0x100eb0d7 */
            ii(0x1012_2785, 5); calld(Definitions.sys_delete, 0x437da); /* call 0x10165f64 */
            ii(0x1012_278a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_278d, 2); jmpd(0x1012_2796, 0x7); goto l_0x1012_2796; /* jmp 0x10122796 */
        l_0x1012_278f:
            ii(0x1012_278f, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1012_2796:
            ii(0x1012_2796, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2799, 7); mov(memd_a32[ds, eax + 0x42], 0);       /* mov dword [eax+0x42], 0x0 */
            ii(0x1012_27a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_27a3, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_27a6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_27a9, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_27ac, 7); cmp(memb_a32[ds, eax + 0x101b_b05c], 0x2); /* cmp byte [eax+0x101bb05c], 0x2 */
            ii(0x1012_27b3, 2); if(jnzd(0x1012_282c, 0x77)) goto l_0x1012_282c; /* jnz 0x1012282c */
            ii(0x1012_27b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_27b8, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_27bb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_27be, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_27c1, 6); mov(eax, memd_a32[ds, eax + 0x101b_b070]); /* mov eax, [eax+0x101bb070] */
            ii(0x1012_27c7, 5); calld(/* sys */ 0x1017_90ce, 0x56902);  /* call 0x101790ce */
            ii(0x1012_27cc, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_27cf, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1012_27d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_27d6, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_27d9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_27dc, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_27df, 6); mov(eax, memd_a32[ds, eax + 0x101b_b062]); /* mov eax, [eax+0x101bb062] */
            ii(0x1012_27e5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_27e8, 5); calld(0x1007_6e7c, -0xab971);           /* call 0x10076e7c */
            ii(0x1012_27ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_27ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_27f2, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_27f5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_27f8, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_27fb, 6); mov(eax, memd_a32[ds, eax + 0x101b_b064]); /* mov eax, [eax+0x101bb064] */
            ii(0x1012_2801, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_2804, 5); calld(Definitions.my_min, -0x99085);    /* call 0x10089784 */
            ii(0x1012_2809, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_280c, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1012_2811, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2814, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_2817, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_281a, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_281d, 6); mov(edx, memd_a32[ds, eax + 0x101b_b070]); /* mov edx, [eax+0x101bb070] */
            ii(0x1012_2823, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_2827, 5); calld(/* sys */ 0x1017_93f8, 0x56bcc);  /* call 0x101793f8 */
        l_0x1012_282c:
            ii(0x1012_282c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_282f, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_2832, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2835, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_2838, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_283b, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_283e, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_2844, 5); calld(0x100d_7f6c, -0x4a8dd);           /* call 0x100d7f6c */
            ii(0x1012_2849, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_284e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_284f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_2854, 1); pushd(eax);                             /* push eax */
            ii(0x1012_2855, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1012_285a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_285d, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_2860, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_2863, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2866, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_286c, 5); calld(0x100d_4f24, -0x4d94d);           /* call 0x100d4f24 */
            ii(0x1012_2871, 1); cwde();                                 /* cwde */
            ii(0x1012_2872, 1); pushd(eax);                             /* push eax */
            ii(0x1012_2873, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2876, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_2879, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_287c, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_287f, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_2885, 5); calld(0x100d_4f58, -0x4d932);           /* call 0x100d4f58 */
            ii(0x1012_288a, 1); cwde();                                 /* cwde */
            ii(0x1012_288b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_288c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_288f, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_2892, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_2895, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2898, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_289e, 5); calld(0x100d_4ebc, -0x4d9e7);           /* call 0x100d4ebc */
            ii(0x1012_28a3, 1); cwde();                                 /* cwde */
            ii(0x1012_28a4, 1); pushd(eax);                             /* push eax */
            ii(0x1012_28a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_28a8, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_28ab, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_28ae, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_28b1, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_28b7, 5); calld(0x100d_4ef0, -0x4d9cc);           /* call 0x100d4ef0 */
            ii(0x1012_28bc, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_28bf, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1012_28c2, 3); mov(ebx, memd_a32[ds, ebx + 0x44]);     /* mov ebx, [ebx+0x44] */
            ii(0x1012_28c5, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_28c8, 3); imul(ebx, ebx, 0x1c);                   /* imul ebx, ebx, 0x1c */
            ii(0x1012_28cb, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_b070]); /* mov ebx, [ebx+0x101bb070] */
            ii(0x1012_28d1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_28d4, 3); mov(edx, memd_a32[ds, edx + 0x25]);     /* mov edx, [edx+0x25] */
            ii(0x1012_28d7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_28da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_28dd, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1012_28e0, 5); calld(0x100e_9ae5, -0x38e00);           /* call 0x100e9ae5 */
            ii(0x1012_28e5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_28e8, 6); mov(memw_a32[ds, eax + 0x46], 0);       /* mov word [eax+0x46], 0x0 */
            ii(0x1012_28ee, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_28f1, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_28f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_28f7, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1012_28fa, 5); calld(Definitions.sys_display_draw_1, 0x44ba9); /* call 0x101674a8 */
            ii(0x1012_28ff, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
        l_0x1012_2906:
            ii(0x1012_2906, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_2909, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_290b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_290c, 1); popd(edi);                              /* pop edi */
            ii(0x1012_290d, 1); popd(esi);                              /* pop esi */
            ii(0x1012_290e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_290f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_2910, 1); retd(); return;                         /* ret */
        }
    }
}