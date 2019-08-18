using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("90842890-f105-47c3-bc36-3783e7ca7a01")]
        public void Method_1009_262c()
        {
            ii(0x1009_262c, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1009_2631, 5); calld(Definitions.sys_check_available_stack_size, 0xd_371c); /* call 0x10165d52 */
            ii(0x1009_2636, 1); pushd(esi);                             /* push esi */
            ii(0x1009_2637, 1); pushd(edi);                             /* push edi */
            ii(0x1009_2638, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_2639, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_263b, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1009_2641, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_2644, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_2647, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_264a, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_264d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_2650, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_bb65); /* call 0x10076af0 */
            ii(0x1009_2655, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_2658, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_bb6d); /* call 0x10076af0 */
            ii(0x1009_265d, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1009_2661, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_2666, 5); calld(0x1007_6e7c, -0x1_b7ef);          /* call 0x10076e7c */
            ii(0x1009_266b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_266e, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1009_2672, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_2677, 5); calld(0x1007_6e7c, -0x1_b800);          /* call 0x10076e7c */
            ii(0x1009_267c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_267f, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1009_2685, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_2688, 1); dec(edx);                               /* dec edx */
            ii(0x1009_2689, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1009_268d, 5); calld(Definitions.my_min, -0x8f0e);     /* call 0x10089784 */
            ii(0x1009_2692, 3); mov(memd_a32[ss, ebp + 0x10], eax);     /* mov [ebp+0x10], eax */
            ii(0x1009_2695, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x1009_269b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_269e, 1); dec(edx);                               /* dec edx */
            ii(0x1009_269f, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1009_26a3, 5); calld(Definitions.my_min, -0x8f24);     /* call 0x10089784 */
            ii(0x1009_26a8, 3); mov(memd_a32[ss, ebp + 0x14], eax);     /* mov [ebp+0x14], eax */
            ii(0x1009_26ab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_26ae, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_26b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_26b4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_26ba, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1009_26c0, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_26c3, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_26c6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_26c9, 4); mov(memw_a32[ss, ebp - 0x28], ax);      /* mov [ebp-0x28], ax */
            ii(0x1009_26cd, 2); jmpd(0x1009_26d6, 0x7); goto l_0x1009_26d6; /* jmp 0x100926d6 */
        l_0x1009_26cf:
            ii(0x1009_26cf, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_26d2, 4); inc(memw_a32[ss, ebp - 0x28]);          /* inc word [ebp-0x28] */
        l_0x1009_26d6:
            ii(0x1009_26d6, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_26d9, 4); cmp(ax, memw_a32[ss, ebp + 0x10]);      /* cmp ax, [ebp+0x10] */
            ii(0x1009_26dd, 6); if(jged(0x1009_284d, 0x16a)) goto l_0x1009_284d; /* jge 0x1009284d */
            ii(0x1009_26e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_26e6, 4); mov(memw_a32[ss, ebp - 0x26], ax);      /* mov [ebp-0x26], ax */
            ii(0x1009_26ea, 2); jmpd(0x1009_26f3, 0x7); goto l_0x1009_26f3; /* jmp 0x100926f3 */
        l_0x1009_26ec:
            ii(0x1009_26ec, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x1009_26ef, 4); inc(memw_a32[ss, ebp - 0x26]);          /* inc word [ebp-0x26] */
        l_0x1009_26f3:
            ii(0x1009_26f3, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x1009_26f6, 4); cmp(ax, memw_a32[ss, ebp + 0x14]);      /* cmp ax, [ebp+0x14] */
            ii(0x1009_26fa, 6); if(jged(0x1009_2848, 0x148)) goto l_0x1009_2848; /* jge 0x10092848 */
            ii(0x1009_2700, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1009_2704, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_2707, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_270a, 4); movsx(edx, memw_a32[ss, ebp - 0x26]);   /* movsx edx, word [ebp-0x26] */
            ii(0x1009_270e, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_2710, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_2712, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_2714, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_2717, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_271a, 6); if(jgd(0x1009_2843, 0x123)) goto l_0x1009_2843; /* jg 0x10092843 */
            ii(0x1009_2720, 4); movsx(eax, memw_a32[ss, ebp - 0x26]);   /* movsx eax, word [ebp-0x26] */
            ii(0x1009_2724, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1009_272a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_272d, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1009_2730, 4); movsx(edx, memw_a32[ss, ebp - 0x28]);   /* movsx edx, word [ebp-0x28] */
            ii(0x1009_2734, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_2736, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_2738, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1009_273e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_2740, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_2743, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_2746, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_2749, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1009_274e, 4); cmp(ax, 0x8);                           /* cmp ax, 0x8 */
            ii(0x1009_2752, 6); if(jld(0x1009_2843, 0xeb)) goto l_0x1009_2843; /* jl 0x10092843 */
            ii(0x1009_2758, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_275b, 1); dec(eax);                               /* dec eax */
            ii(0x1009_275c, 4); mov(memw_a32[ss, ebp - 0x2c], ax);      /* mov [ebp-0x2c], ax */
            ii(0x1009_2760, 2); jmpd(0x1009_2769, 0x7); goto l_0x1009_2769; /* jmp 0x10092769 */
        l_0x1009_2762:
            ii(0x1009_2762, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_2765, 4); inc(memw_a32[ss, ebp - 0x2c]);          /* inc word [ebp-0x2c] */
        l_0x1009_2769:
            ii(0x1009_2769, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_276c, 4); cmp(ax, memw_a32[ss, ebp - 0x28]);      /* cmp ax, [ebp-0x28] */
            ii(0x1009_2770, 6); if(jgd(0x1009_2843, 0xcd)) goto l_0x1009_2843; /* jg 0x10092843 */
            ii(0x1009_2776, 3); mov(eax, memd_a32[ss, ebp - 0x26]);     /* mov eax, [ebp-0x26] */
            ii(0x1009_2779, 1); dec(eax);                               /* dec eax */
            ii(0x1009_277a, 4); mov(memw_a32[ss, ebp - 0x2a], ax);      /* mov [ebp-0x2a], ax */
            ii(0x1009_277e, 2); jmpd(0x1009_2787, 0x7); goto l_0x1009_2787; /* jmp 0x10092787 */
        l_0x1009_2780:
            ii(0x1009_2780, 3); mov(eax, memd_a32[ss, ebp - 0x2a]);     /* mov eax, [ebp-0x2a] */
            ii(0x1009_2783, 4); inc(memw_a32[ss, ebp - 0x2a]);          /* inc word [ebp-0x2a] */
        l_0x1009_2787:
            ii(0x1009_2787, 3); mov(eax, memd_a32[ss, ebp - 0x2a]);     /* mov eax, [ebp-0x2a] */
            ii(0x1009_278a, 4); cmp(ax, memw_a32[ss, ebp - 0x26]);      /* cmp ax, [ebp-0x26] */
            ii(0x1009_278e, 6); if(jgd(0x1009_283e, 0xaa)) goto l_0x1009_283e; /* jg 0x1009283e */
            ii(0x1009_2794, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1009_2798, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_279a, 2); if(jled(0x1009_27ad, 0x11)) goto l_0x1009_27ad; /* jle 0x100927ad */
            ii(0x1009_279c, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1009_27a1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_27a4, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1009_27a8, 1); dec(eax);                               /* dec eax */
            ii(0x1009_27a9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_27ab, 2); if(jld(0x1009_27af, 0x2)) goto l_0x1009_27af; /* jl 0x100927af */
        l_0x1009_27ad:
            ii(0x1009_27ad, 2); jmpd(0x1009_27b7, 0x8); goto l_0x1009_27b7; /* jmp 0x100927b7 */
        l_0x1009_27af:
            ii(0x1009_27af, 4); movsx(eax, memw_a32[ss, ebp - 0x2a]);   /* movsx eax, word [ebp-0x2a] */
            ii(0x1009_27b3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_27b5, 2); if(jgd(0x1009_27b9, 0x2)) goto l_0x1009_27b9; /* jg 0x100927b9 */
        l_0x1009_27b7:
            ii(0x1009_27b7, 2); jmpd(0x1009_27ca, 0x11); goto l_0x1009_27ca; /* jmp 0x100927ca */
        l_0x1009_27b9:
            ii(0x1009_27b9, 4); movsx(edx, memw_a32[ss, ebp - 0x2a]);   /* movsx edx, word [ebp-0x2a] */
            ii(0x1009_27bd, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1009_27c2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_27c5, 1); dec(eax);                               /* dec eax */
            ii(0x1009_27c6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_27c8, 2); if(jld(0x1009_27cf, 0x5)) goto l_0x1009_27cf; /* jl 0x100927cf */
        l_0x1009_27ca:
            ii(0x1009_27ca, 5); jmpd(0x1009_2839, 0x6a); goto l_0x1009_2839; /* jmp 0x10092839 */
        l_0x1009_27cf:
            ii(0x1009_27cf, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
            ii(0x1009_27d3, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_27d6, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1009_27d9, 2); jmpd(0x1009_27e1, 0x6); goto l_0x1009_27e1; /* jmp 0x100927e1 */
        l_0x1009_27db:
            ii(0x1009_27db, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_27de, 3); inc(memd_a32[ss, ebp - 0x30]);          /* inc dword [ebp-0x30] */
        l_0x1009_27e1:
            ii(0x1009_27e1, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1009_27e5, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x1009_27e9, 1); inc(eax);                               /* inc eax */
            ii(0x1009_27ea, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_27ec, 2); if(jgd(0x1009_282d, 0x3f)) goto l_0x1009_282d; /* jg 0x1009282d */
            ii(0x1009_27ee, 3); mov(eax, memd_a32[ss, ebp - 0x2a]);     /* mov eax, [ebp-0x2a] */
            ii(0x1009_27f1, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_27f4, 2); jmpd(0x1009_27fc, 0x6); goto l_0x1009_27fc; /* jmp 0x100927fc */
        l_0x1009_27f6:
            ii(0x1009_27f6, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_27f9, 3); inc(memd_a32[ss, ebp - 0x24]);          /* inc dword [ebp-0x24] */
        l_0x1009_27fc:
            ii(0x1009_27fc, 4); movsx(eax, memw_a32[ss, ebp - 0x2a]);   /* movsx eax, word [ebp-0x2a] */
            ii(0x1009_2800, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_2804, 1); inc(eax);                               /* inc eax */
            ii(0x1009_2805, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_2807, 2); if(jgd(0x1009_282b, 0x22)) goto l_0x1009_282b; /* jg 0x1009282b */
            ii(0x1009_2809, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1009_280d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_2810, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_2813, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_2817, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_2819, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_281b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_281d, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_2820, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_2823, 2); if(jled(0x1009_2829, 0x4)) goto l_0x1009_2829; /* jle 0x10092829 */
            ii(0x1009_2825, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
        l_0x1009_2829:
            ii(0x1009_2829, 2); jmpd(0x1009_27f6, -0x35); goto l_0x1009_27f6; /* jmp 0x100927f6 */
        l_0x1009_282b:
            ii(0x1009_282b, 2); jmpd(0x1009_27db, -0x52); goto l_0x1009_27db; /* jmp 0x100927db */
        l_0x1009_282d:
            ii(0x1009_282d, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1009_2831, 2); if(jnzd(0x1009_2839, 0x6)) goto l_0x1009_2839; /* jnz 0x10092839 */
            ii(0x1009_2833, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_2837, 2); jmpd(0x1009_2851, 0x18); goto l_0x1009_2851; /* jmp 0x10092851 */
        l_0x1009_2839:
            ii(0x1009_2839, 5); jmpd(0x1009_2780, -0xbe); goto l_0x1009_2780; /* jmp 0x10092780 */
        l_0x1009_283e:
            ii(0x1009_283e, 5); jmpd(0x1009_2762, -0xe1); goto l_0x1009_2762; /* jmp 0x10092762 */
        l_0x1009_2843:
            ii(0x1009_2843, 5); jmpd(0x1009_26ec, -0x15c); goto l_0x1009_26ec; /* jmp 0x100926ec */
        l_0x1009_2848:
            ii(0x1009_2848, 5); jmpd(0x1009_26cf, -0x17e); goto l_0x1009_26cf; /* jmp 0x100926cf */
        l_0x1009_284d:
            ii(0x1009_284d, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1009_2851:
            ii(0x1009_2851, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1009_2854, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_2856, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_2857, 1); popd(edi);                              /* pop edi */
            ii(0x1009_2858, 1); popd(esi);                              /* pop esi */
            ii(0x1009_2859, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}
