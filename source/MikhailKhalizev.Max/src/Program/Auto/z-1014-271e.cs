using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_271e-d5fa10a0")]
        public void Method_1014_271e()
        {
            ii(0x1014_271e, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1014_2723, 5); calld(Definitions.sys_check_available_stack_size, 0x2_362a); /* call 0x10165d52 */
            ii(0x1014_2728, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_2729, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_272a, 1); pushd(esi);                             /* push esi */
            ii(0x1014_272b, 1); pushd(edi);                             /* push edi */
            ii(0x1014_272c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_272d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_272f, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1014_2735, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_2738, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_273b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_273d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_2740, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1014_2743, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_2746, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1014_274a, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1014_2750, 5); mov(eax, 0x101c_a468);                  /* mov eax, 0x101ca468 */
            ii(0x1014_2755, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2757, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_275a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_275d, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1014_2761, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_2764, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_2767, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1014_276b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_276e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_2771, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1014_2774, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_2777, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_2779, 5); calld(0x1007_6e7c, -0xc_b902);          /* call 0x10076e7c */
            ii(0x1014_277e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_2781, 2); jmpd(0x1014_2789, 0x6); goto l_0x1014_2789; /* jmp 0x10142789 */
        l_0x1014_2783:
            ii(0x1014_2783, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_2786, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1014_2789:
            ii(0x1014_2789, 6); mov(ax, memw_a32[ds, 0x101c_8172]);     /* mov ax, [0x101c8172] */
            ii(0x1014_278f, 1); dec(eax);                               /* dec eax */
            ii(0x1014_2790, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_2793, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_2796, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1014_2799, 1); cwde();                                 /* cwde */
            ii(0x1014_279a, 5); calld(Definitions.my_min, -0xb_901b);   /* call 0x10089784 */
            ii(0x1014_279f, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1014_27a3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_27a5, 6); if(jgd(0x1014_2928, 0x17d)) goto l_0x1014_2928; /* jg 0x10142928 */
            ii(0x1014_27ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_27ae, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1014_27b1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_27b4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_27b6, 5); calld(0x1007_6e7c, -0xc_b93f);          /* call 0x10076e7c */
            ii(0x1014_27bb, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_27be, 2); jmpd(0x1014_27c6, 0x6); goto l_0x1014_27c6; /* jmp 0x101427c6 */
        l_0x1014_27c0:
            ii(0x1014_27c0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_27c3, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1014_27c6:
            ii(0x1014_27c6, 6); mov(ax, memw_a32[ds, 0x101c_8174]);     /* mov ax, [0x101c8174] */
            ii(0x1014_27cc, 1); dec(eax);                               /* dec eax */
            ii(0x1014_27cd, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_27d0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_27d3, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1014_27d6, 1); cwde();                                 /* cwde */
            ii(0x1014_27d7, 5); calld(Definitions.my_min, -0xb_9058);   /* call 0x10089784 */
            ii(0x1014_27dc, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1014_27e0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_27e2, 6); if(jgd(0x1014_2923, 0x13b)) goto l_0x1014_2923; /* jg 0x10142923 */
            ii(0x1014_27e8, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1014_27ec, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1014_27f0, 5); calld(0x1007_3d48, -0xc_eaad);          /* call 0x10073d48 */
            ii(0x1014_27f5, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_27fa, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1014_27fd, 2); if(jzd(0x1014_2808, 0x9)) goto l_0x1014_2808; /* jz 0x10142808 */
            ii(0x1014_27ff, 7); mov(memd_a32[ss, ebp - 0x24], 0x1);     /* mov dword [ebp-0x24], 0x1 */
            ii(0x1014_2806, 2); jmpd(0x1014_280f, 0x7); goto l_0x1014_280f; /* jmp 0x1014280f */
        l_0x1014_2808:
            ii(0x1014_2808, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
        l_0x1014_280f:
            ii(0x1014_280f, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1014_2813, 6); if(jzd(0x1014_291e, 0x105)) goto l_0x1014_291e; /* jz 0x1014291e */
            ii(0x1014_2819, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1014_281d, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1014_2821, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1014_2825, 5); calld(0x1007_4e0c, -0xc_da1e);          /* call 0x10074e0c */
            ii(0x1014_282a, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1014_282d, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x1014_2831, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1014_2835, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1014_2839, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1014_283c, 5); calld(0x1007_6aac, -0xc_bd95);          /* call 0x10076aac */
            ii(0x1014_2841, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1014_2843, 5); calld(0x100a_9239, -0x9_960f);          /* call 0x100a9239 */
            ii(0x1014_2848, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1014_284c, 2); if(jzd(0x1014_285a, 0xc)) goto l_0x1014_285a; /* jz 0x1014285a */
            ii(0x1014_284e, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1014_2852, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1014_2855, 5); calld(0x1014_f634, 0xcdda);             /* call 0x1014f634 */
        l_0x1014_285a:
            ii(0x1014_285a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_285d, 5); cmp(memw_a32[ds, eax + 0x8], 0x39);     /* cmp word [eax+0x8], 0x39 */
            ii(0x1014_2862, 6); if(jnzd(0x1014_291e, 0xb6)) goto l_0x1014_291e; /* jnz 0x1014291e */
            ii(0x1014_2868, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1014_286c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_286e, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1014_2873, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_2875, 2); if(jnzd(0x1014_28b0, 0x39)) goto l_0x1014_28b0; /* jnz 0x101428b0 */
            ii(0x1014_2877, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1014_287b, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1014_2880, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2883, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_2886, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1014_288a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_288c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_288e, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1014_2894, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2896, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_2898, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x1014_289b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_289e, 6); mov(eax, memd_a32[ds, eax + 0xfa]);     /* mov eax, [eax+0xfa] */
            ii(0x1014_28a4, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1014_28a7, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_28ac, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1014_28ae, 2); if(jzd(0x1014_28b2, 0x2)) goto l_0x1014_28b2; /* jz 0x101428b2 */
        l_0x1014_28b0:
            ii(0x1014_28b0, 2); jmpd(0x1014_28ef, 0x3d); goto l_0x1014_28ef; /* jmp 0x101428ef */
        l_0x1014_28b2:
            ii(0x1014_28b2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_28b5, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1014_28b8, 5); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x1014_28bd, 1); cwde();                                 /* cwde */
            ii(0x1014_28be, 1); pushd(eax);                             /* push eax */
            ii(0x1014_28bf, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_28c2, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1014_28c5, 5); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x1014_28ca, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_28cd, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_28d0, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1014_28d3, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_28d6, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1014_28d9, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1014_28dc, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_28df, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1014_28e2, 5); calld(0x1008_b148, -0xb_779f);          /* call 0x1008b148 */
            ii(0x1014_28e7, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1014_28ea, 5); calld(0x100f_f562, -0x4_338d);          /* call 0x100ff562 */
        l_0x1014_28ef:
            ii(0x1014_28ef, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1014_28f3, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1014_28f9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_28fc, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_28ff, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1014_2903, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2905, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_2907, 6); mov(edx, memd_a32[ds, 0x101c_811c]);    /* mov edx, [0x101c811c] */
            ii(0x1014_290d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_290f, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1014_2912, 6); mov(edx, memd_a32[ds, edx + 0xfa]);     /* mov edx, [edx+0xfa] */
            ii(0x1014_2918, 3); mov(dx, memw_a32[ds, edx]);             /* mov dx, [edx] */
            ii(0x1014_291b, 3); or(memw_a32[ds, eax], dx);              /* or [eax], dx */
        l_0x1014_291e:
            ii(0x1014_291e, 5); jmpd(0x1014_27c0, -0x163); goto l_0x1014_27c0; /* jmp 0x101427c0 */
        l_0x1014_2923:
            ii(0x1014_2923, 5); jmpd(0x1014_2783, -0x1a5); goto l_0x1014_2783; /* jmp 0x10142783 */
        l_0x1014_2928:
            ii(0x1014_2928, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_292a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_292b, 1); popd(edi);                              /* pop edi */
            ii(0x1014_292c, 1); popd(esi);                              /* pop esi */
            ii(0x1014_292d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_292e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_292f, 1); retd();                                 /* ret */
        }
    }
}
