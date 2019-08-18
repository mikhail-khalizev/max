using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_20c6-f4d03e8a")]
        public void Method_1008_20c6()
        {
            ii(0x1008_20c6, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1008_20cb, 5); calld(Definitions.sys_check_available_stack_size, 0xe_3c82); /* call 0x10165d52 */
            ii(0x1008_20d0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_20d1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_20d2, 1); pushd(edx);                             /* push edx */
            ii(0x1008_20d3, 1); pushd(esi);                             /* push esi */
            ii(0x1008_20d4, 1); pushd(edi);                             /* push edi */
            ii(0x1008_20d5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_20d6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_20d8, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_20de, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_20e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_20e4, 4); cmp(memb_a32[ds, eax + 0x15], 0);       /* cmp byte [eax+0x15], 0x0 */
            ii(0x1008_20e8, 2); if(jzd(0x1008_20f9, 0xf)) goto l_0x1008_20f9; /* jz 0x100820f9 */
            ii(0x1008_20ea, 5); calld(/* sys */ 0x1016_5e9b, 0xe_3dac); /* call 0x10165e9b */
            ii(0x1008_20ef, 3); imul(eax, eax, 0x15);                   /* imul eax, eax, 0x15 */
            ii(0x1008_20f2, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1008_20f5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_20f7, 2); if(jnzd(0x1008_211b, 0x22)) goto l_0x1008_211b; /* jnz 0x1008211b */
        l_0x1008_20f9:
            ii(0x1008_20f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_20fc, 5); calld(0x1008_181f, -0x8e2);             /* call 0x1008181f */
            ii(0x1008_2101, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2103, 2); if(jzd(0x1008_2111, 0xc)) goto l_0x1008_2111; /* jz 0x10082111 */
            ii(0x1008_2105, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2108, 7); mov(memd_a32[ds, eax + 0x3a], 0x140);   /* mov dword [eax+0x3a], 0x140 */
            ii(0x1008_210f, 2); jmpd(0x1008_211b, 0xa); goto l_0x1008_211b; /* jmp 0x1008211b */
        l_0x1008_2111:
            ii(0x1008_2111, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2114, 7); mov(memd_a32[ds, eax + 0x3a], 0xc0);    /* mov dword [eax+0x3a], 0xc0 */
        l_0x1008_211b:
            ii(0x1008_211b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_211e, 5); calld(0x1008_69a3, 0x4880);             /* call 0x100869a3 */
            ii(0x1008_2123, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2126, 4); mov(memb_a32[ds, eax + 0x46], 0);       /* mov byte [eax+0x46], 0x0 */
            ii(0x1008_212a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_212d, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_2130, 5); calld(0x1007_6b90, -0xb5a5);            /* call 0x10076b90 */
            ii(0x1008_2135, 1); cwde();                                 /* cwde */
            ii(0x1008_2136, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2138, 6); if(jzd(0x1008_21d4, 0x96)) goto l_0x1008_21d4; /* jz 0x100821d4 */
            ii(0x1008_213e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2141, 5); calld(0x1008_3369, 0x1223);             /* call 0x10083369 */
            ii(0x1008_2146, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2149, 5); calld(0x1008_303c, 0xeee);              /* call 0x1008303c */
            ii(0x1008_214e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_2151, 5); calld(0x1008_61ff, 0x40a9);             /* call 0x100861ff */
            ii(0x1008_2156, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2158, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_215b, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_215e, 5); calld(0x1013_ad11, 0xb_8bae);           /* call 0x1013ad11 */
            ii(0x1008_2163, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2165, 2); if(jzd(0x1008_2178, 0x11)) goto l_0x1008_2178; /* jz 0x10082178 */
            ii(0x1008_2167, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_216a, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_216d, 5); calld(0x1007_6b90, -0xb5e2);            /* call 0x10076b90 */
            ii(0x1008_2172, 1); cwde();                                 /* cwde */
            ii(0x1008_2173, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1008_2176, 2); if(jgd(0x1008_217a, 0x2)) goto l_0x1008_217a; /* jg 0x1008217a */
        l_0x1008_2178:
            ii(0x1008_2178, 2); jmpd(0x1008_21d4, 0x5a); goto l_0x1008_21d4; /* jmp 0x100821d4 */
        l_0x1008_217a:
            ii(0x1008_217a, 5); mov(eax, 0x25);                         /* mov eax, 0x25 */
            ii(0x1008_217f, 5); calld(Definitions.sys_new, 0xe_3c7c);   /* call 0x10165e00 */
            ii(0x1008_2184, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_2187, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_218a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_218d, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1008_2191, 2); if(jzd(0x1008_21a9, 0x16)) goto l_0x1008_21a9; /* jz 0x100821a9 */
            ii(0x1008_2193, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_2196, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_2199, 5); calld(0x1008_6e3d, 0x4c9f);             /* call 0x10086e3d */
            ii(0x1008_219e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_21a1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_21a4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_21a7, 2); jmpd(0x1008_21af, 0x6); goto l_0x1008_21af; /* jmp 0x100821af */
        l_0x1008_21a9:
            ii(0x1008_21a9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_21ac, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1008_21af:
            ii(0x1008_21af, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1008_21b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_21b5, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_21b8, 5); calld(0x1008_99fc, 0x783f);             /* call 0x100899fc */
            ii(0x1008_21bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_21c0, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x1008_21c3, 5); calld(0x1008_99cc, 0x7804);             /* call 0x100899cc */
            ii(0x1008_21c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_21ca, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_21cf, 5); calld(0x100a_4d50, 0x2_2b7c);           /* call 0x100a4d50 */
        l_0x1008_21d4:
            ii(0x1008_21d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_21d6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_21d7, 1); popd(edi);                              /* pop edi */
            ii(0x1008_21d8, 1); popd(esi);                              /* pop esi */
            ii(0x1008_21d9, 1); popd(edx);                              /* pop edx */
            ii(0x1008_21da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_21db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_21dc, 1); retd(); return;                         /* ret */
        }
    }
}
