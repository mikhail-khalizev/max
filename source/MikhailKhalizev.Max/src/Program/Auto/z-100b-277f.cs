using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_277f-1d50d4ab")]
        public void Method_100b_277f()
        {
            ii(0x100b_277f, 5); push(0x40);                             /* push 0x40 */
            ii(0x100b_2784, 5); call(Definitions.sys_check_available_stack_size, 0xb_35c9); /* call 0x10165d52 */
            ii(0x100b_2789, 1); push(ebx);                              /* push ebx */
            ii(0x100b_278a, 1); push(ecx);                              /* push ecx */
            ii(0x100b_278b, 1); push(esi);                              /* push esi */
            ii(0x100b_278c, 1); push(edi);                              /* push edi */
            ii(0x100b_278d, 1); push(ebp);                              /* push ebp */
            ii(0x100b_278e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_2790, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_2796, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_2799, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_279c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_279e, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100b_27a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_27a5, 2); if(jnz(0x100b_27bc, 0x15)) goto l_0x100b_27bc; /* jnz 0x100b27bc */
            ii(0x100b_27a7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_27aa, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100b_27ad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_27b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_27b2, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x100b_27b8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_27ba, 2); if(jnz(0x100b_27be, 2)) goto l_0x100b_27be; /* jnz 0x100b27be */
        l_0x100b_27bc:
            ii(0x100b_27bc, 2); jmp(0x100b_27c3, 5); goto l_0x100b_27c3; /* jmp 0x100b27c3 */
        l_0x100b_27be:
            ii(0x100b_27be, 5); jmp(0x100b_297a, 0x1b7); goto l_0x100b_297a; /* jmp 0x100b297a */
        l_0x100b_27c3:
            ii(0x100b_27c3, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100b_27c6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_27c9, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_27cc, 5); call(0x1008_a520, -0x2_82b1);           /* call 0x1008a520 */
            ii(0x100b_27d1, 5); call(0x100b_7da0, 0x55ca);              /* call 0x100b7da0 */
            ii(0x100b_27d6, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100b_27da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_27dc, 6); if(jl(0x100b_297a, 0x198)) goto l_0x100b_297a; /* jl 0x100b297a */
            ii(0x100b_27e2, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_27e5, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x100b_27e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_27eb, 5); call(0x1007_611c, -0x3_c6d4);           /* call 0x1007611c */
            ii(0x100b_27f0, 5); call(0x1008_b4b4, -0x2_7341);           /* call 0x1008b4b4 */
            ii(0x100b_27f5, 2); test(al, al);                           /* test al, al */
            ii(0x100b_27f7, 6); if(jnz(0x100b_297a, 0x17d)) goto l_0x100b_297a; /* jnz 0x100b297a */
            ii(0x100b_27fd, 5); mov(ecx, 0x180);                        /* mov ecx, 0x180 */
            ii(0x100b_2802, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_2805, 3); mov(ebx, memd[ds, eax + 7]);            /* mov ebx, [eax+0x7] */
            ii(0x100b_2808, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_280b, 4); movsx(edx, memw[ss, ebp - 0xe]);        /* movsx edx, word [ebp-0xe] */
            ii(0x100b_280f, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100b_2813, 5); call(0x1007_388b, -0x3_ef8d);           /* call 0x1007388b */
            ii(0x100b_2818, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_281b, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100b_281f, 6); if(jz(0x100b_28b8, 0x93)) goto l_0x100b_28b8; /* jz 0x100b28b8 */
            ii(0x100b_2825, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100b_282a, 5); call(Definitions.sys_new, 0xb_35d1);    /* call 0x10165e00 */
            ii(0x100b_282f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_2832, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_2835, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_2838, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100b_283c, 2); if(jz(0x100b_2857, 0x19)) goto l_0x100b_2857; /* jz 0x100b2857 */
            ii(0x100b_283e, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100b_2841, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_2844, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_2847, 5); call(0x100a_73d7, -0xb475);             /* call 0x100a73d7 */
            ii(0x100b_284c, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_284f, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_2852, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100b_2855, 2); jmp(0x100b_285d, 6); goto l_0x100b_285d; /* jmp 0x100b285d */
        l_0x100b_2857:
            ii(0x100b_2857, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_285a, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100b_285d:
            ii(0x100b_285d, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x100b_2860, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100b_2863, 5); call(0x100b_815c, 0x58f4);              /* call 0x100b815c */
            ii(0x100b_2868, 3); lea(edx, memd[ss, ebp - 0x10]);         /* lea edx, [ebp-0x10] */
            ii(0x100b_286b, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100b_286e, 5); call(0x100a_a824, -0x804f);             /* call 0x100aa824 */
            ii(0x100b_2873, 5); call(0x100a_7557, -0xb321);             /* call 0x100a7557 */
            ii(0x100b_2878, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_287b, 5); call(0x100a_2edb, -0xf9a5);             /* call 0x100a2edb */
            ii(0x100b_2880, 2); test(al, al);                           /* test al, al */
            ii(0x100b_2882, 2); if(jz(0x100b_28a9, 0x25)) goto l_0x100b_28a9; /* jz 0x100b28a9 */
            ii(0x100b_2884, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100b_2887, 5); call(0x100b_80f4, 0x5868);              /* call 0x100b80f4 */
            ii(0x100b_288c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_288e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_2891, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100b_2894, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_2897, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100b_289d, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100b_28a2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100b_28a4, 5); call(0x100c_21b2, 0xf909);              /* call 0x100c21b2 */
        l_0x100b_28a9:
            ii(0x100b_28a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_28ab, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100b_28ae, 5); call(0x1009_b8ec, -0x1_6fc7);           /* call 0x1009b8ec */
            ii(0x100b_28b3, 5); jmp(0x100b_297a, 0xc2); goto l_0x100b_297a; /* jmp 0x100b297a */
        l_0x100b_28b8:
            ii(0x100b_28b8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_28bb, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_28be, 5); call(0x1007_6574, -0x3_c34f);           /* call 0x10076574 */
            ii(0x100b_28c3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_28c5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_28c8, 4); mov(memw[ds, edx + 0x41], ax);          /* mov [edx+0x41], ax */
            ii(0x100b_28cc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_28cf, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_28d2, 5); call(0x1007_6574, -0x3_c363);           /* call 0x10076574 */
            ii(0x100b_28d7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_28d9, 3); mov(eax, memd[ss, ebp - 0xe]);          /* mov eax, [ebp-0xe] */
            ii(0x100b_28dc, 4); mov(memw[ds, edx + 0x43], ax);          /* mov [edx+0x43], ax */
            ii(0x100b_28e0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_28e3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_28e6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_28e9, 5); call(0x1007_6574, -0x3_c37a);           /* call 0x10076574 */
            ii(0x100b_28ee, 5); call(0x1008_a998, -0x2_7f5b);           /* call 0x1008a998 */
            ii(0x100b_28f3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_28f5, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100b_28fa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_28fc, 2); if(jnz(0x100b_2913, 0x15)) goto l_0x100b_2913; /* jnz 0x100b2913 */
            ii(0x100b_28fe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_2901, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100b_2904, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_2907, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2909, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x100b_290f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_2911, 2); if(jnz(0x100b_291c, 9)) goto l_0x100b_291c; /* jnz 0x100b291c */
        l_0x100b_2913:
            ii(0x100b_2913, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100b_291a, 2); jmp(0x100b_2935, 0x19); goto l_0x100b_2935; /* jmp 0x100b2935 */
        l_0x100b_291c:
            ii(0x100b_291c, 5); mov(ecx, 0xb1c);                        /* mov ecx, 0xb1c */
            ii(0x100b_2921, 5); mov(ebx, StringDefinitions.AiMoveCpp10); /* mov ebx, 0x101a1094 */
            ii(0x100b_2926, 5); mov(edx, StringDefinitions.PlaymodeNotEqualTurnBasedTeamturnidEqualTeam4); /* mov edx, 0x101a10a0 */
            ii(0x100b_292b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_292d, 5); call(Definitions.sys_assert, 0xb_3460); /* call 0x10165d92 */
            ii(0x100b_2932, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x100b_2935:
            ii(0x100b_2935, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_2938, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_293b, 5); call(0x1007_6574, -0x3_c3cc);           /* call 0x10076574 */
            ii(0x100b_2940, 5); cmp(memw[ds, eax + 8], 0x4e);           /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_2945, 2); if(jnz(0x100b_2960, 0x19)) goto l_0x100b_2960; /* jnz 0x100b2960 */
            ii(0x100b_2947, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_2949, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x100b_294e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_2951, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2954, 5); call(0x1007_65d0, -0x3_c389);           /* call 0x100765d0 */
            ii(0x100b_2959, 5); call(0x1016_3053, 0xb_06f5);            /* call 0x10163053 */
            ii(0x100b_295e, 2); jmp(0x100b_297a, 0x1a); goto l_0x100b_297a; /* jmp 0x100b297a */
        l_0x100b_2960:
            ii(0x100b_2960, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100b_2965, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x100b_296a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_296d, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_2970, 5); call(0x1007_65d0, -0x3_c3a5);           /* call 0x100765d0 */
            ii(0x100b_2975, 5); call(0x1016_3053, 0xb_06d9);            /* call 0x10163053 */
        l_0x100b_297a:
            ii(0x100b_297a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_297c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_297d, 1); pop(edi);                               /* pop edi */
            ii(0x100b_297e, 1); pop(esi);                               /* pop esi */
            ii(0x100b_297f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_2980, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_2981, 1); ret();                                  /* ret */
        }
    }
}
