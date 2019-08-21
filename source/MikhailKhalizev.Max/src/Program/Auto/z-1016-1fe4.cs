using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_1fe4-d3eb5b93")]
        public void Method_1016_1fe4()
        {
            ii(0x1016_1fe4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1fe7, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1016_1fea, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x1016_1fed, 5); jmpd(0x1016_2135, 0x143); goto l_0x1016_2135; /* jmp 0x10162135 */
        l_0x1016_1ff2:
            ii(0x1016_1ff2, 5); mov(eax, StringDefinitions.BuildStart); /* mov eax, 0x101b2902 */
            ii(0x1016_1ff7, 5); calld(0x100a_8b4a, -0xb_94b2);          /* call 0x100a8b4a */
            ii(0x1016_1ffc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1fff, 5); calld(0x1015_1565, -0x1_0a9f);          /* call 0x10151565 */
            ii(0x1016_2004, 5); jmpd(0x1016_21a9, 0x1a0); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_2009:
            ii(0x1016_2009, 5); mov(eax, 0x52);                         /* mov eax, 0x52 */
            ii(0x1016_200e, 5); calld(0x1007_5fdc, -0xe_c037);          /* call 0x10075fdc */
            ii(0x1016_2013, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_2015, 2); if(jzd(0x1016_2021, 0xa)) goto l_0x1016_2021; /* jz 0x10162021 */
            ii(0x1016_2017, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_201a, 5); cmp(memw_a32[ds, eax + 0x8], 0x31);     /* cmp word [eax+0x8], 0x31 */
            ii(0x1016_201f, 2); if(jzd(0x1016_2023, 0x2)) goto l_0x1016_2023; /* jz 0x10162023 */
        l_0x1016_2021:
            ii(0x1016_2021, 2); jmpd(0x1016_2073, 0x50); goto l_0x1016_2073; /* jmp 0x10162073 */
        l_0x1016_2023:
            ii(0x1016_2023, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2026, 4); test(memb_a32[ds, eax + 0x5e], 0x1);    /* test byte [eax+0x5e], 0x1 */
            ii(0x1016_202a, 2); if(jzd(0x1016_206d, 0x41)) goto l_0x1016_206d; /* jz 0x1016206d */
            ii(0x1016_202c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_202f, 5); calld(0x1012_0a5c, -0x4_15d8);          /* call 0x10120a5c */
            ii(0x1016_2034, 1); cwde();                                 /* cwde */
            ii(0x1016_2035, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1016_2038, 3); cmp(eax, 0x28);                         /* cmp eax, 0x28 */
            ii(0x1016_203b, 2); if(jld(0x1016_2055, 0x18)) goto l_0x1016_2055; /* jl 0x10162055 */
            ii(0x1016_203d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2040, 5); calld(0x1012_0a5c, -0x4_15e9);          /* call 0x10120a5c */
            ii(0x1016_2045, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1016_2048, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_204b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_204e, 5); calld(0x1014_9b07, -0x1_854c);          /* call 0x10149b07 */
            ii(0x1016_2053, 2); jmpd(0x1016_206d, 0x18); goto l_0x1016_206d; /* jmp 0x1016206d */
        l_0x1016_2055:
            ii(0x1016_2055, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2058, 5); calld(0x1012_0a5c, -0x4_1601);          /* call 0x10120a5c */
            ii(0x1016_205d, 5); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1016_2062, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_2065, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2068, 5); calld(0x1014_9b07, -0x1_8566);          /* call 0x10149b07 */
        l_0x1016_206d:
            ii(0x1016_206d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2070, 3); inc(memb_a32[ds, eax + 0x5e]);          /* inc byte [eax+0x5e] */
        l_0x1016_2073:
            ii(0x1016_2073, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_2078, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_207b, 5); calld(0x1007_6d98, -0xe_b2e8);          /* call 0x10076d98 */
            ii(0x1016_2080, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2082, 2); if(jzd(0x1016_209f, 0x1b)) goto l_0x1016_209f; /* jz 0x1016209f */
            ii(0x1016_2084, 5); calld(0x1010_2bf8, -0x5_f491);          /* call 0x10102bf8 */
            ii(0x1016_2089, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_208b, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_208d, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1016_2092, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_2095, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_209a, 5); calld(0x1013_d5c0, -0x2_4adf);          /* call 0x1013d5c0 */
        l_0x1016_209f:
            ii(0x1016_209f, 5); jmpd(0x1016_21a9, 0x105); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_20a4:
            ii(0x1016_20a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_20a7, 5); calld(0x1014_ac97, -0x1_7415);          /* call 0x1014ac97 */
            ii(0x1016_20ac, 2); test(al, al);                           /* test al, al */
            ii(0x1016_20ae, 6); if(jzd(0x1016_21a9, 0xf5)) goto l_0x1016_21a9; /* jz 0x101621a9 */
        l_0x1016_20b4:
            ii(0x1016_20b4, 5); mov(eax, StringDefinitions.Moving4);    /* mov eax, 0x101b290e */
            ii(0x1016_20b9, 5); calld(0x100a_8b4a, -0xb_9574);          /* call 0x100a8b4a */
            ii(0x1016_20be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_20c1, 5); calld(0x1014_af42, -0x1_7184);          /* call 0x1014af42 */
            ii(0x1016_20c6, 5); jmpd(0x1016_21a9, 0xde); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_20cb:
            ii(0x1016_20cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_20ce, 5); calld(0x1016_1499, -0xc3a);             /* call 0x10161499 */
            ii(0x1016_20d3, 5); jmpd(0x1016_21a9, 0xd1); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_20d8:
            ii(0x1016_20d8, 5); mov(eax, StringDefinitions.BuildClearing); /* mov eax, 0x101b2915 */
            ii(0x1016_20dd, 5); calld(0x100a_8b4a, -0xb_9598);          /* call 0x100a8b4a */
            ii(0x1016_20e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_20e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_20e7, 5); calld(0x1016_07bf, -0x192d);            /* call 0x101607bf */
            ii(0x1016_20ec, 5); jmpd(0x1016_21a9, 0xb8); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_20f1:
            ii(0x1016_20f1, 5); mov(eax, StringDefinitions.BuildCancel); /* mov eax, 0x101b2924 */
            ii(0x1016_20f6, 5); calld(0x100a_8b4a, -0xb_95b1);          /* call 0x100a8b4a */
            ii(0x1016_20fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_20fe, 5); calld(0x1015_0b1a, -0x1_15e9);          /* call 0x10150b1a */
            ii(0x1016_2103, 5); jmpd(0x1016_21a9, 0xa1); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_2108:
            ii(0x1016_2108, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_210a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_210d, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1016_2110, 5); calld(0x1013_ad71, -0x2_73a4);          /* call 0x1013ad71 */
            ii(0x1016_2115, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2117, 2); if(jzd(0x1016_2123, 0xa)) goto l_0x1016_2123; /* jz 0x10162123 */
            ii(0x1016_2119, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_211c, 5); calld(0x1015_f7cf, -0x2952);            /* call 0x1015f7cf */
            ii(0x1016_2121, 2); jmpd(0x1016_212b, 0x8); goto l_0x1016_212b; /* jmp 0x1016212b */
        l_0x1016_2123:
            ii(0x1016_2123, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2126, 5); calld(0x1016_1499, -0xc92);             /* call 0x10161499 */
        l_0x1016_212b:
            ii(0x1016_212b, 5); jmpd(0x1016_21a9, 0x79); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_2130:
            ii(0x1016_2130, 5); jmpd(0x1016_21a9, 0x74); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_2135:
            ii(0x1016_2135, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x1016_2138, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x1016_213b, 4); cmp(memb_a32[ss, ebp - 0x30], 0xd);     /* cmp byte [ebp-0x30], 0xd */
            ii(0x1016_213f, 2); if(jbd(0x1016_2175, 0x34)) goto l_0x1016_2175; /* jb 0x10162175 */
            ii(0x1016_2141, 4); cmp(memb_a32[ss, ebp - 0x30], 0xd);     /* cmp byte [ebp-0x30], 0xd */
            ii(0x1016_2145, 2); if(jbed(0x1016_20f1, -0x56)) goto l_0x1016_20f1; /* jbe 0x101620f1 */
            ii(0x1016_2147, 4); cmp(memb_a32[ss, ebp - 0x30], 0x1a);    /* cmp byte [ebp-0x30], 0x1a */
            ii(0x1016_214b, 2); if(jbd(0x1016_2169, 0x1c)) goto l_0x1016_2169; /* jb 0x10162169 */
            ii(0x1016_214d, 4); cmp(memb_a32[ss, ebp - 0x30], 0x1a);    /* cmp byte [ebp-0x30], 0x1a */
            ii(0x1016_2151, 2); if(jbed(0x1016_20d8, -0x7b)) goto l_0x1016_20d8; /* jbe 0x101620d8 */
            ii(0x1016_2153, 4); cmp(memb_a32[ss, ebp - 0x30], 0x1f);    /* cmp byte [ebp-0x30], 0x1f */
            ii(0x1016_2157, 2); if(jbd(0x1016_2167, 0xe)) goto l_0x1016_2167; /* jb 0x10162167 */
            ii(0x1016_2159, 4); cmp(memb_a32[ss, ebp - 0x30], 0x1f);    /* cmp byte [ebp-0x30], 0x1f */
            ii(0x1016_215d, 2); if(jbed(0x1016_2108, -0x57)) goto l_0x1016_2108; /* jbe 0x10162108 */
            ii(0x1016_215f, 4); cmp(memb_a32[ss, ebp - 0x30], 0x2e);    /* cmp byte [ebp-0x30], 0x2e */
            ii(0x1016_2163, 2); if(jzd(0x1016_20f1, -0x74)) goto l_0x1016_20f1; /* jz 0x101620f1 */
            ii(0x1016_2165, 2); jmpd(0x1016_2130, -0x37); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_2167:
            ii(0x1016_2167, 2); jmpd(0x1016_2130, -0x39); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_2169:
            ii(0x1016_2169, 4); cmp(memb_a32[ss, ebp - 0x30], 0x19);    /* cmp byte [ebp-0x30], 0x19 */
            ii(0x1016_216d, 6); if(jzd(0x1016_20cb, -0xa8)) goto l_0x1016_20cb; /* jz 0x101620cb */
            ii(0x1016_2173, 2); jmpd(0x1016_2130, -0x45); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_2175:
            ii(0x1016_2175, 4); cmp(memb_a32[ss, ebp - 0x30], 0x5);     /* cmp byte [ebp-0x30], 0x5 */
            ii(0x1016_2179, 2); if(jbd(0x1016_219d, 0x22)) goto l_0x1016_219d; /* jb 0x1016219d */
            ii(0x1016_217b, 4); cmp(memb_a32[ss, ebp - 0x30], 0x5);     /* cmp byte [ebp-0x30], 0x5 */
            ii(0x1016_217f, 6); if(jbed(0x1016_20a4, -0xe1)) goto l_0x1016_20a4; /* jbe 0x101620a4 */
            ii(0x1016_2185, 4); cmp(memb_a32[ss, ebp - 0x30], 0x6);     /* cmp byte [ebp-0x30], 0x6 */
            ii(0x1016_2189, 6); if(jbed(0x1016_20b4, -0xdb)) goto l_0x1016_20b4; /* jbe 0x101620b4 */
            ii(0x1016_218f, 4); cmp(memb_a32[ss, ebp - 0x30], 0xb);     /* cmp byte [ebp-0x30], 0xb */
            ii(0x1016_2193, 6); if(jzd(0x1016_2009, -0x190)) goto l_0x1016_2009; /* jz 0x10162009 */
            ii(0x1016_2199, 2); jmpd(0x1016_2130, -0x6b); goto l_0x1016_2130; /* jmp 0x10162130 */
        //  ii(0x1016_219b, 2); jmpd(0x1016_2130, -0x6d); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_219d:
            ii(0x1016_219d, 4); cmp(memb_a32[ss, ebp - 0x30], 0);       /* cmp byte [ebp-0x30], 0x0 */
            ii(0x1016_21a1, 6); if(jzd(0x1016_1ff2, -0x1b5)) goto l_0x1016_1ff2; /* jz 0x10161ff2 */
            ii(0x1016_21a7, 2); jmpd(0x1016_2130, -0x79); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_21a9:
            ii(0x1016_21a9, 5); if(jmpd_func(0x1016_29a7, 0x7f9)) return; /* jmp 0x101629a7 */
        }
    }
}
