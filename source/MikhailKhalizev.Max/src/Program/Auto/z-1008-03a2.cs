using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("93ce774b-6f84-4879-8e85-2a0168a70725")]
        public void Method_1008_03a2()
        {
            ii(0x1008_03a2, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1008_03a7, 5); calld(Definitions.sys_check_available_stack_size, 0xe_59a6); /* call 0x10165d52 */
            ii(0x1008_03ac, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_03ad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_03ae, 1); pushd(edx);                             /* push edx */
            ii(0x1008_03af, 1); pushd(esi);                             /* push esi */
            ii(0x1008_03b0, 1); pushd(edi);                             /* push edi */
            ii(0x1008_03b1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_03b2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_03b4, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1008_03ba, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_03bd, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1008_03c2, 5); calld(0x1007_6338, -0xa08f);            /* call 0x10076338 */
            ii(0x1008_03c7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_03c9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_03cc, 5); calld(0x1007_64b8, -0x9f19);            /* call 0x100764b8 */
            ii(0x1008_03d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_03d4, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1008_03d7, 5); calld(0x1008_a228, 0x9e4c);             /* call 0x1008a228 */
            ii(0x1008_03dc, 5); calld(0x1008_a370, 0x9f8f);             /* call 0x1008a370 */
            ii(0x1008_03e1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_03e4, 2); jmpd(0x1008_03ee, 0x8); goto l_0x1008_03ee; /* jmp 0x100803ee */
        l_0x1008_03e6:
            ii(0x1008_03e6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_03e9, 5); calld(0x1007_6bf8, -0x97f6);            /* call 0x10076bf8 */
        l_0x1008_03ee:
            ii(0x1008_03ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_03f0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_03f3, 5); calld(0x1013_ad71, 0xb_a979);           /* call 0x1013ad71 */
            ii(0x1008_03f8, 2); test(al, al);                           /* test al, al */
            ii(0x1008_03fa, 6); if(jzd(0x1008_0490, 0x90)) goto l_0x1008_0490; /* jz 0x10080490 */
            ii(0x1008_0400, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_0403, 5); calld(0x1007_63a0, -0xa068);            /* call 0x100763a0 */
            ii(0x1008_0408, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_040a, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_040d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0410, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_0413, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0416, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_0418, 2); if(jnzd(0x1008_044d, 0x33)) goto l_0x1008_044d; /* jnz 0x1008044d */
            ii(0x1008_041a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_041d, 5); calld(0x1007_63a0, -0xa082);            /* call 0x100763a0 */
            ii(0x1008_0422, 5); calld(0x1015_26ac, 0xd_2285);           /* call 0x101526ac */
            ii(0x1008_0427, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_0429, 2); if(jzd(0x1008_044b, 0x20)) goto l_0x1008_044b; /* jz 0x1008044b */
            ii(0x1008_042b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_042e, 3); mov(edx, memd_a32[ds, eax + 0xb]);      /* mov edx, [eax+0xb] */
            ii(0x1008_0431, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_0434, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_0437, 5); calld(0x1007_63a0, -0xa09c);            /* call 0x100763a0 */
            ii(0x1008_043c, 5); calld(0x1015_26ac, 0xd_226b);           /* call 0x101526ac */
            ii(0x1008_0441, 5); calld(0x100a_2bc4, 0x2_277e);           /* call 0x100a2bc4 */
            ii(0x1008_0446, 1); cwde();                                 /* cwde */
            ii(0x1008_0447, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_0449, 2); if(jled(0x1008_044d, 0x2)) goto l_0x1008_044d; /* jle 0x1008044d */
        l_0x1008_044b:
            ii(0x1008_044b, 2); jmpd(0x1008_044f, 0x2); goto l_0x1008_044f; /* jmp 0x1008044f */
        l_0x1008_044d:
            ii(0x1008_044d, 2); jmpd(0x1008_046d, 0x1e); goto l_0x1008_046d; /* jmp 0x1008046d */
        l_0x1008_044f:
            ii(0x1008_044f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0452, 3); mov(ebx, memd_a32[ds, eax + 0x29]);     /* mov ebx, [eax+0x29] */
            ii(0x1008_0455, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1008_0458, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_045b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_045e, 5); calld(0x1007_63d4, -0xa08f);            /* call 0x100763d4 */
            ii(0x1008_0463, 5); calld(0x100c_0780, 0x4_0318);           /* call 0x100c0780 */
            ii(0x1008_0468, 1); cwde();                                 /* cwde */
            ii(0x1008_0469, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_046b, 2); if(jgd(0x1008_046f, 0x2)) goto l_0x1008_046f; /* jg 0x1008046f */
        l_0x1008_046d:
            ii(0x1008_046d, 2); jmpd(0x1008_048b, 0x1c); goto l_0x1008_048b; /* jmp 0x1008048b */
        l_0x1008_046f:
            ii(0x1008_046f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0472, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_0475, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_0478, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_047b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_047e, 5); calld(0x1007_63d4, -0xa0af);            /* call 0x100763d4 */
            ii(0x1008_0483, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_0485, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_0488, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
        l_0x1008_048b:
            ii(0x1008_048b, 5); jmpd(0x1008_03e6, -0xaa); goto l_0x1008_03e6; /* jmp 0x100803e6 */
        l_0x1008_0490:
            ii(0x1008_0490, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1008_0495, 5); calld(0x1007_6338, -0xa162);            /* call 0x10076338 */
            ii(0x1008_049a, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1008_049d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_049f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_04a1, 5); calld(0x1007_643c, -0xa06a);            /* call 0x1007643c */
            ii(0x1008_04a6, 2); jmpd(0x1008_04b0, 0x8); goto l_0x1008_04b0; /* jmp 0x100804b0 */
        l_0x1008_04a8:
            ii(0x1008_04a8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_04ab, 5); calld(0x1007_6bf8, -0x98b8);            /* call 0x10076bf8 */
        l_0x1008_04b0:
            ii(0x1008_04b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_04b2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_04b5, 5); calld(0x1013_ad71, 0xb_a8b7);           /* call 0x1013ad71 */
            ii(0x1008_04ba, 2); test(al, al);                           /* test al, al */
            ii(0x1008_04bc, 6); if(jzd(0x1008_0552, 0x90)) goto l_0x1008_0552; /* jz 0x10080552 */
            ii(0x1008_04c2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_04c5, 5); calld(0x1007_63a0, -0xa12a);            /* call 0x100763a0 */
            ii(0x1008_04ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_04cc, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_04cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_04d2, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_04d5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_04d8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_04da, 2); if(jnzd(0x1008_050f, 0x33)) goto l_0x1008_050f; /* jnz 0x1008050f */
            ii(0x1008_04dc, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_04df, 5); calld(0x1007_63a0, -0xa144);            /* call 0x100763a0 */
            ii(0x1008_04e4, 5); calld(0x1015_26ac, 0xd_21c3);           /* call 0x101526ac */
            ii(0x1008_04e9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_04eb, 2); if(jzd(0x1008_050d, 0x20)) goto l_0x1008_050d; /* jz 0x1008050d */
            ii(0x1008_04ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_04f0, 3); mov(edx, memd_a32[ds, eax + 0xb]);      /* mov edx, [eax+0xb] */
            ii(0x1008_04f3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_04f6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_04f9, 5); calld(0x1007_63a0, -0xa15e);            /* call 0x100763a0 */
            ii(0x1008_04fe, 5); calld(0x1015_26ac, 0xd_21a9);           /* call 0x101526ac */
            ii(0x1008_0503, 5); calld(0x100a_2bc4, 0x2_26bc);           /* call 0x100a2bc4 */
            ii(0x1008_0508, 1); cwde();                                 /* cwde */
            ii(0x1008_0509, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_050b, 2); if(jled(0x1008_050f, 0x2)) goto l_0x1008_050f; /* jle 0x1008050f */
        l_0x1008_050d:
            ii(0x1008_050d, 2); jmpd(0x1008_0511, 0x2); goto l_0x1008_0511; /* jmp 0x10080511 */
        l_0x1008_050f:
            ii(0x1008_050f, 2); jmpd(0x1008_052f, 0x1e); goto l_0x1008_052f; /* jmp 0x1008052f */
        l_0x1008_0511:
            ii(0x1008_0511, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0514, 3); mov(ebx, memd_a32[ds, eax + 0x29]);     /* mov ebx, [eax+0x29] */
            ii(0x1008_0517, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1008_051a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_051d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_0520, 5); calld(0x1007_63d4, -0xa151);            /* call 0x100763d4 */
            ii(0x1008_0525, 5); calld(0x100c_0780, 0x4_0256);           /* call 0x100c0780 */
            ii(0x1008_052a, 1); cwde();                                 /* cwde */
            ii(0x1008_052b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_052d, 2); if(jgd(0x1008_0531, 0x2)) goto l_0x1008_0531; /* jg 0x10080531 */
        l_0x1008_052f:
            ii(0x1008_052f, 2); jmpd(0x1008_054d, 0x1c); goto l_0x1008_054d; /* jmp 0x1008054d */
        l_0x1008_0531:
            ii(0x1008_0531, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0534, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_0537, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_053a, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_053d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_0540, 5); calld(0x1007_63d4, -0xa171);            /* call 0x100763d4 */
            ii(0x1008_0545, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_0547, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_054a, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
        l_0x1008_054d:
            ii(0x1008_054d, 5); jmpd(0x1008_04a8, -0xaa); goto l_0x1008_04a8; /* jmp 0x100804a8 */
        l_0x1008_0552:
            ii(0x1008_0552, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0555, 5); calld(0x1008_ad28, 0xa7ce);             /* call 0x1008ad28 */
            ii(0x1008_055a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_055c, 2); if(jnzd(0x1008_05b0, 0x52)) goto l_0x1008_05b0; /* jnz 0x100805b0 */
            ii(0x1008_055e, 5); calld(0x1008_a7bc, 0xa259);             /* call 0x1008a7bc */
            ii(0x1008_0563, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_0568, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_056b, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1008_0570, 5); calld(Definitions.sys_new, 0xe_588b);   /* call 0x10165e00 */
            ii(0x1008_0575, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_0578, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_057b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1008_057e, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1008_0582, 2); if(jzd(0x1008_059a, 0x16)) goto l_0x1008_059a; /* jz 0x1008059a */
            ii(0x1008_0584, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_0587, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_058a, 5); calld(Definitions.my_ctor_c11, 0x2_333a); /* call 0x100a38c9 */
            ii(0x1008_058f, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1008_0592, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_0595, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1008_0598, 2); jmpd(0x1008_05a0, 0x6); goto l_0x1008_05a0; /* jmp 0x100805a0 */
        l_0x1008_059a:
            ii(0x1008_059a, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_059d, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1008_05a0:
            ii(0x1008_05a0, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1008_05a3, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_05a8, 3); mov(ebx, memd_a32[ss, ebp - 0x18]);     /* mov ebx, [ebp-0x18] */
            ii(0x1008_05ab, 5); calld(0x100a_4db6, 0x2_4806);           /* call 0x100a4db6 */
        l_0x1008_05b0:
            ii(0x1008_05b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_05b2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_05b5, 5); calld(0x1007_5f6c, -0xa64e);            /* call 0x10075f6c */
            ii(0x1008_05ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_05bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_05bd, 1); popd(edi);                              /* pop edi */
            ii(0x1008_05be, 1); popd(esi);                              /* pop esi */
            ii(0x1008_05bf, 1); popd(edx);                              /* pop edx */
            ii(0x1008_05c0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_05c1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_05c2, 1); retd(); return;                         /* ret */
        }
    }
}
