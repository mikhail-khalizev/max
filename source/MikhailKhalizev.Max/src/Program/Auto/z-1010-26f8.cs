using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_26f8-b11d45d")]
        public void Method_1010_26f8()
        {
            ii(0x1010_26f8, 5); pushd(0x114);                           /* push 0x114 */
            ii(0x1010_26fd, 5); calld(Definitions.sys_check_available_stack_size, 0x6_3650); /* call 0x10165d52 */
            ii(0x1010_2702, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2703, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2704, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2705, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2706, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2707, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2709, 6); sub(esp, 0xf0);                         /* sub esp, 0xf0 */
            ii(0x1010_270f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_2712, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_2715, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_2719, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_271f, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1010_2724, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_2726, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1010_2729, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_272c, 3); mov(al, memb_a32[ds, eax + 0x28]);      /* mov al, [eax+0x28] */
            ii(0x1010_272f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_2734, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_2737, 2); if(jnzd(0x1010_273f, 0x6)) goto l_0x1010_273f; /* jnz 0x1010273f */
            ii(0x1010_2739, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1010_273d, 2); jmpd(0x1010_2743, 0x4); goto l_0x1010_2743; /* jmp 0x10102743 */
        l_0x1010_273f:
            ii(0x1010_273f, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1010_2743:
            ii(0x1010_2743, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1010_2746, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1010_2749, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_274c, 3); mov(al, memb_a32[ds, eax + 0x28]);      /* mov al, [eax+0x28] */
            ii(0x1010_274f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_2754, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1010_2757, 2); if(jzd(0x1010_2762, 0x9)) goto l_0x1010_2762; /* jz 0x10102762 */
            ii(0x1010_2759, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1010_2760, 2); jmpd(0x1010_277b, 0x19); goto l_0x1010_277b; /* jmp 0x1010277b */
        l_0x1010_2762:
            ii(0x1010_2762, 5); mov(ecx, 0x2218);                       /* mov ecx, 0x2218 */
            ii(0x1010_2767, 5); mov(ebx, StringDefinitions.GamemgrCpp2); /* mov ebx, 0x101a2bf3 */
            ii(0x1010_276c, 5); mov(edx, StringDefinitions.CtinfoTeamtypeNotEqualRemoteTeam); /* mov edx, 0x101a2bff */
            ii(0x1010_2771, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_2773, 5); calld(Definitions.sys_assert, 0x6_361a); /* call 0x10165d92 */
            ii(0x1010_2778, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1010_277b:
            ii(0x1010_277b, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1010_277f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_2782, 5); calld(0x100e_0608, -0x2_217f);          /* call 0x100e0608 */
            ii(0x1010_2787, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_278a, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1010_278e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_2791, 6); mov(eax, memd_a32[ds, eax + 0xfa]);     /* mov eax, [eax+0xfa] */
            ii(0x1010_2797, 5); calld(0x1010_2c18, 0x47c);              /* call 0x10102c18 */
            ii(0x1010_279c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_279e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_27a1, 5); calld(0x100e_0548, -0x2_225e);          /* call 0x100e0548 */
            ii(0x1010_27a6, 2); jmpd(0x1010_27b0, 0x8); goto l_0x1010_27b0; /* jmp 0x101027b0 */
        l_0x1010_27a8:
            ii(0x1010_27a8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_27ab, 5); calld(0x1007_6bf8, -0x8_bbb8);          /* call 0x10076bf8 */
        l_0x1010_27b0:
            ii(0x1010_27b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_27b2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_27b5, 5); calld(0x1013_ad71, 0x3_85b7);           /* call 0x1013ad71 */
            ii(0x1010_27ba, 2); test(al, al);                           /* test al, al */
            ii(0x1010_27bc, 6); if(jzd(0x1010_2870, 0xae)) goto l_0x1010_2870; /* jz 0x10102870 */
            ii(0x1010_27c2, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_27c5, 5); calld(0x100e_04e4, -0x2_22e6);          /* call 0x100e04e4 */
            ii(0x1010_27ca, 5); calld(0x1007_35ac, -0x8_f223);          /* call 0x100735ac */
            ii(0x1010_27cf, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_27d4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_27d6, 3); mov(bl, memb_a32[ss, ebp - 0x14]);      /* mov bl, [ebp-0x14] */
            ii(0x1010_27d9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_27dc, 5); calld(0x1010_2a58, 0x277);              /* call 0x10102a58 */
            ii(0x1010_27e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_27e3, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_27e7, 5); calld(0x1010_11ff, -0x15ed);            /* call 0x101011ff */
            ii(0x1010_27ec, 1); cwde();                                 /* cwde */
            ii(0x1010_27ed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_27ef, 2); if(jnzd(0x1010_280e, 0x1d)) goto l_0x1010_280e; /* jnz 0x1010280e */
            ii(0x1010_27f1, 5); cmp(memw_a32[ss, ebp - 0x4], 0);        /* cmp word [ebp-0x4], 0x0 */
            ii(0x1010_27f6, 2); if(jnzd(0x1010_280e, 0x16)) goto l_0x1010_280e; /* jnz 0x1010280e */
            ii(0x1010_27f8, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1010_27ff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_2801, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_2804, 5); calld(0x100e_043c, -0x2_23cd);          /* call 0x100e043c */
            ii(0x1010_2809, 5); jmpd(0x1010_2907, 0xf9); goto l_0x1010_2907; /* jmp 0x10102907 */
        l_0x1010_280e:
            ii(0x1010_280e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_2811, 5); calld(0x100e_04e4, -0x2_2332);          /* call 0x100e04e4 */
            ii(0x1010_2816, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_2818, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_281c, 5); calld(0x100a_2204, -0x6_061d);          /* call 0x100a2204 */
            ii(0x1010_2821, 2); test(al, al);                           /* test al, al */
            ii(0x1010_2823, 2); if(jzd(0x1010_282b, 0x6)) goto l_0x1010_282b; /* jz 0x1010282b */
            ii(0x1010_2825, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1010_2829, 2); if(jnzd(0x1010_282d, 0x2)) goto l_0x1010_282d; /* jnz 0x1010282d */
        l_0x1010_282b:
            ii(0x1010_282b, 2); jmpd(0x1010_286b, 0x3e); goto l_0x1010_286b; /* jmp 0x1010286b */
        l_0x1010_282d:
            ii(0x1010_282d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_2830, 5); calld(0x100e_047c, -0x2_23b9);          /* call 0x100e047c */
            ii(0x1010_2835, 5); calld(0x100e_0d64, -0x2_1ad6);          /* call 0x100e0d64 */
            ii(0x1010_283a, 1); cwde();                                 /* cwde */
            ii(0x1010_283b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_283c, 5); mov(eax, StringDefinitions.FactoriesInComplexIReStarted); /* mov eax, 0x101a2c1f */
            ii(0x1010_2841, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2842, 6); lea(eax, ebp - 0xf0);                   /* lea eax, [ebp-0xf0] */
            ii(0x1010_2848, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2849, 5); calld(Definitions.sys_sprintf, 0x6_36b3); /* call 0x10165f01 */
            ii(0x1010_284e, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_2851, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_2856, 1); pushd(eax);                             /* push eax */
            ii(0x1010_2857, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_2859, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_285b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1010_2860, 6); lea(eax, ebp - 0xf0);                   /* lea eax, [ebp-0xf0] */
            ii(0x1010_2866, 5); calld(0x1011_5d23, 0x1_34b8);           /* call 0x10115d23 */
        l_0x1010_286b:
            ii(0x1010_286b, 5); jmpd(0x1010_27a8, -0xc8); goto l_0x1010_27a8; /* jmp 0x101027a8 */
        l_0x1010_2870:
            ii(0x1010_2870, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_2874, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1010_2879, 5); calld(0x1007_2f25, -0x8_f959);          /* call 0x10072f25 */
            ii(0x1010_287e, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_2882, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1010_2887, 5); calld(0x1007_2f25, -0x8_f967);          /* call 0x10072f25 */
            ii(0x1010_288c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_2890, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_2896, 7); mov(memb_a32[ds, eax + 0x101c_a491], 0x1); /* mov byte [eax+0x101ca491], 0x1 */
            ii(0x1010_289d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_289f, 5); calld(0x1010_0efe, -0x19a6);            /* call 0x10100efe */
            ii(0x1010_28a4, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1010_28ab, 2); if(jzd(0x1010_28bd, 0x10)) goto l_0x1010_28bd; /* jz 0x101028bd */
            ii(0x1010_28ad, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_28af, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_28b3, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1010_28b8, 5); calld(0x1012_8897, 0x2_5fda);           /* call 0x10128897 */
        l_0x1010_28bd:
            ii(0x1010_28bd, 5); calld(0x1010_2912, 0x50);               /* call 0x10102912 */
            ii(0x1010_28c2, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_28c6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_28c8, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_28cd, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_28cf, 2); if(jzd(0x1010_28dc, 0xb)) goto l_0x1010_28dc; /* jz 0x101028dc */
            ii(0x1010_28d1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_28d3, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1010_28d8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_28da, 2); if(jnzd(0x1010_28ea, 0xe)) goto l_0x1010_28ea; /* jnz 0x101028ea */
        l_0x1010_28dc:
            ii(0x1010_28dc, 7); mov(memb_a32[ds, 0x101c_391e], 0x9);    /* mov byte [0x101c391e], 0x9 */
            ii(0x1010_28e3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_28e5, 5); calld(0x100f_4fa2, -0xd948);            /* call 0x100f4fa2 */
        l_0x1010_28ea:
            ii(0x1010_28ea, 7); mov(memd_a32[ss, ebp - 0x28], 0x1);     /* mov dword [ebp-0x28], 0x1 */
            ii(0x1010_28f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_28f3, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_28f6, 5); calld(0x100e_043c, -0x2_24bf);          /* call 0x100e043c */
            ii(0x1010_28fb, 2); jmpd(0x1010_2907, 0xa); goto l_0x1010_2907; /* jmp 0x10102907 */
        //  ii(0x1010_28fd, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1010_28ff, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
        //  ii(0x1010_2902, 5); calld(0x100e_043c, -0x2_24cb);          /* call 0x100e043c */
        l_0x1010_2907:
            ii(0x1010_2907, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_290a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_290c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_290d, 1); popd(edi);                              /* pop edi */
            ii(0x1010_290e, 1); popd(esi);                              /* pop esi */
            ii(0x1010_290f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2910, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2911, 1); retd(); return;                         /* ret */
        }
    }
}
