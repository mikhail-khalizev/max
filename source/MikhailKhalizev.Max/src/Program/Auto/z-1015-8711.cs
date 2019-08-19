using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8711-19875e35")]
        public void Method_1015_8711()
        {
            ii(0x1015_8711, 5); pushd(0xd4);                            /* push 0xd4 */
            ii(0x1015_8716, 5); calld(Definitions.sys_check_available_stack_size, 0xd637); /* call 0x10165d52 */
            ii(0x1015_871b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_871c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_871d, 1); pushd(edx);                             /* push edx */
            ii(0x1015_871e, 1); pushd(esi);                             /* push esi */
            ii(0x1015_871f, 1); pushd(edi);                             /* push edi */
            ii(0x1015_8720, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_8721, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8723, 6); sub(esp, 0xa8);                         /* sub esp, 0xa8 */
            ii(0x1015_8729, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1015_872d, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1015_8732, 5); mov(edx, 0x6e9);                        /* mov edx, 0x6e9 */
            ii(0x1015_8737, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_873a, 5); calld(0x100d_68a3, -0x8_1e9c);          /* call 0x100d68a3 */
            ii(0x1015_873f, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1015_8742, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1015_8746, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1015_874b, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_874e, 5); calld(0x100e_f318, -0x6_943b);          /* call 0x100ef318 */
            ii(0x1015_8753, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_8758, 5); calld(0x1012_0d94, -0x3_79c9);          /* call 0x10120d94 */
            ii(0x1015_875d, 5); calld(0x100d_6124, -0x8_263e);          /* call 0x100d6124 */
            ii(0x1015_8762, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8764, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_8766, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_8769, 5); calld(0x100d_6adf, -0x8_1c8f);          /* call 0x100d6adf */
            ii(0x1015_876e, 6); lea(edx, ebp - 0x9c);                   /* lea edx, [ebp-0x9c] */
            ii(0x1015_8774, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_8777, 5); calld(0x100d_6a11, -0x8_1d6b);          /* call 0x100d6a11 */
            ii(0x1015_877c, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1015_8781, 5); calld(Definitions.sys_new, 0xd67a);     /* call 0x10165e00 */
            ii(0x1015_8786, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1015_8789, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1015_878c, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1015_878f, 4); cmp(memd_a32[ss, ebp - 0x58], 0);       /* cmp dword [ebp-0x58], 0x0 */
            ii(0x1015_8793, 2); if(jzd(0x1015_87bd, 0x28)) goto l_0x1015_87bd; /* jz 0x101587bd */
            ii(0x1015_8795, 5); mov(eax, 0xe);                          /* mov eax, 0xe */
            ii(0x1015_879a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_879b, 5); mov(ecx, 0x59);                         /* mov ecx, 0x59 */
            ii(0x1015_87a0, 5); mov(ebx, 0x15d);                        /* mov ebx, 0x15d */
            ii(0x1015_87a5, 5); mov(edx, 0x15c);                        /* mov edx, 0x15c */
            ii(0x1015_87aa, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1015_87ad, 5); calld(Definitions.my_ctor_c17, -0x8_a3a3); /* call 0x100ce40f */
            ii(0x1015_87b2, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1015_87b5, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1015_87b8, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1015_87bb, 2); jmpd(0x1015_87c3, 0x6); goto l_0x1015_87c3; /* jmp 0x101587c3 */
        l_0x1015_87bd:
            ii(0x1015_87bd, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1015_87c0, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x1015_87c3:
            ii(0x1015_87c3, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1015_87c6, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1015_87c9, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1015_87ce, 5); calld(Definitions.sys_new, 0xd62d);     /* call 0x10165e00 */
            ii(0x1015_87d3, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1015_87d6, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1015_87d9, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1015_87dc, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1015_87e0, 2); if(jzd(0x1015_880a, 0x28)) goto l_0x1015_880a; /* jz 0x1015880a */
            ii(0x1015_87e2, 5); mov(eax, 0x2e);                         /* mov eax, 0x2e */
            ii(0x1015_87e7, 1); pushd(eax);                             /* push eax */
            ii(0x1015_87e8, 5); mov(ecx, 0x59);                         /* mov ecx, 0x59 */
            ii(0x1015_87ed, 5); mov(ebx, 0x15f);                        /* mov ebx, 0x15f */
            ii(0x1015_87f2, 5); mov(edx, 0x15e);                        /* mov edx, 0x15e */
            ii(0x1015_87f7, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1015_87fa, 5); calld(Definitions.my_ctor_c17, -0x8_a3f0); /* call 0x100ce40f */
            ii(0x1015_87ff, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1015_8802, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1015_8805, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1015_8808, 2); jmpd(0x1015_8810, 0x6); goto l_0x1015_8810; /* jmp 0x10158810 */
        l_0x1015_880a:
            ii(0x1015_880a, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1015_880d, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1015_8810:
            ii(0x1015_8810, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1015_8813, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1015_8816, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1015_881b, 5); calld(/* sys */ 0x1016_a24c, 0x1_1a2c); /* call 0x1016a24c */
            ii(0x1015_8820, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_8823, 5); calld(0x100d_5224, -0x8_3604);          /* call 0x100d5224 */
            ii(0x1015_8828, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8829, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_882c, 5); calld(0x100d_5250, -0x8_35e1);          /* call 0x100d5250 */
            ii(0x1015_8831, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8832, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_8835, 5); calld(0x100d_527c, -0x8_35be);          /* call 0x100d527c */
            ii(0x1015_883a, 1); pushd(eax);                             /* push eax */
            ii(0x1015_883b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1015_883e, 5); calld(0x100d_52a8, -0x8_359b);          /* call 0x100d52a8 */
            ii(0x1015_8843, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8844, 5); calld(0x100d_52d4, -0x8_3575);          /* call 0x100d52d4 */
            ii(0x1015_8849, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_884c, 5); calld(0x100d_52f8, -0x8_3559);          /* call 0x100d52f8 */
            ii(0x1015_8851, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_8854, 5); mov(edx, StringDefinitions.Arm);        /* mov edx, 0x101b24b1 */
            ii(0x1015_8859, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_885c, 5); calld(0x100c_ef64, -0x8_98fd);          /* call 0x100cef64 */
            ii(0x1015_8861, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1015_8864, 5); calld(0x100d_5224, -0x8_3645);          /* call 0x100d5224 */
            ii(0x1015_8869, 1); pushd(eax);                             /* push eax */
            ii(0x1015_886a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1015_886d, 5); calld(0x100d_5250, -0x8_3622);          /* call 0x100d5250 */
            ii(0x1015_8872, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8873, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1015_8876, 5); calld(0x100d_527c, -0x8_35ff);          /* call 0x100d527c */
            ii(0x1015_887b, 1); pushd(eax);                             /* push eax */
            ii(0x1015_887c, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1015_887f, 5); calld(0x100d_52a8, -0x8_35dc);          /* call 0x100d52a8 */
            ii(0x1015_8884, 1); pushd(eax);                             /* push eax */
            ii(0x1015_8885, 5); calld(0x100d_52d4, -0x8_35b6);          /* call 0x100d52d4 */
            ii(0x1015_888a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1015_888d, 5); calld(0x100d_52f8, -0x8_359a);          /* call 0x100d52f8 */
            ii(0x1015_8892, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_8895, 5); mov(edx, StringDefinitions.Cancel10);   /* mov edx, 0x101b24b5 */
            ii(0x1015_889a, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1015_889d, 5); calld(0x100c_ef64, -0x8_993e);          /* call 0x100cef64 */
            ii(0x1015_88a2, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1015_88a7, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_88aa, 5); calld(0x100d_5194, -0x8_371b);          /* call 0x100d5194 */
            ii(0x1015_88af, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1015_88b4, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_88b7, 5); calld(0x100d_5164, -0x8_3758);          /* call 0x100d5164 */
            ii(0x1015_88bc, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1015_88c1, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_88c4, 5); calld(0x100d_50d4, -0x8_37f5);          /* call 0x100d50d4 */
            ii(0x1015_88c9, 6); mov(edx, memd_a32[ss, ebp - 0x8a]);     /* mov edx, [ebp-0x8a] */
            ii(0x1015_88cf, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_88d2, 5); calld(0x100c_f85c, -0x8_907b);          /* call 0x100cf85c */
            ii(0x1015_88d7, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1015_88dc, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1015_88df, 5); calld(0x100d_5134, -0x8_37b0);          /* call 0x100d5134 */
            ii(0x1015_88e4, 5); mov(edx, 0x701b);                       /* mov edx, 0x701b */
            ii(0x1015_88e9, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1015_88ec, 5); calld(0x100d_5164, -0x8_378d);          /* call 0x100d5164 */
            ii(0x1015_88f1, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x1015_88f6, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1015_88f9, 5); calld(0x100d_50d4, -0x8_382a);          /* call 0x100d50d4 */
            ii(0x1015_88fe, 6); mov(edx, memd_a32[ss, ebp - 0x8a]);     /* mov edx, [ebp-0x8a] */
            ii(0x1015_8904, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1015_8907, 5); calld(0x100c_f85c, -0x8_90b0);          /* call 0x100cf85c */
            ii(0x1015_890c, 6); mov(eax, memd_a32[ss, ebp - 0x8a]);     /* mov eax, [ebp-0x8a] */
            ii(0x1015_8912, 5); calld(Definitions.sys_display_draw_0, 0xeb6d); /* call 0x10167484 */
            ii(0x1015_8917, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1015_891b, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_891f, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1015_8923:
            ii(0x1015_8923, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1015_8927, 2); if(jnzd(0x1015_892f, 0x6)) goto l_0x1015_892f; /* jnz 0x1015892f */
            ii(0x1015_8929, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1015_892d, 2); if(jzd(0x1015_8934, 0x5)) goto l_0x1015_8934; /* jz 0x10158934 */
        l_0x1015_892f:
            ii(0x1015_892f, 5); jmpd(0x1015_89d6, 0xa2); goto l_0x1015_89d6; /* jmp 0x101589d6 */
        l_0x1015_8934:
            ii(0x1015_8934, 5); calld(/* sys */ 0x1016_b208, 0x1_28cf); /* call 0x1016b208 */
            ii(0x1015_8939, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x1015_893f, 7); cmp(memb_a32[ds, 0x101c_37d2], 0);      /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1015_8946, 2); if(jzd(0x1015_8952, 0xa)) goto l_0x1015_8952; /* jz 0x10158952 */
            ii(0x1015_8948, 10); mov(memd_a32[ss, ebp - 0xa0], 0x1b);   /* mov dword [ebp-0xa0], 0x1b */
        l_0x1015_8952:
            ii(0x1015_8952, 7); cmp(memd_a32[ss, ebp - 0xa0], 0xd);     /* cmp dword [ebp-0xa0], 0xd */
            ii(0x1015_8959, 2); if(jnzd(0x1015_898f, 0x34)) goto l_0x1015_898f; /* jnz 0x1015898f */
            ii(0x1015_895b, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_895e, 5); calld(0x100c_fbbe, -0x8_8da5);          /* call 0x100cfbbe */
            ii(0x1015_8963, 5); calld(0x100d_51c4, -0x8_37a4);          /* call 0x100d51c4 */
            ii(0x1015_8968, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_896a, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_896c, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_896f, 5); calld(0x100c_fb06, -0x8_8e6e);          /* call 0x100cfb06 */
            ii(0x1015_8974, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x1015_897a, 5); calld(0x1015_852e, -0x451);             /* call 0x1015852e */
            ii(0x1015_897f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_8981, 2); if(jzd(0x1015_8989, 0x6)) goto l_0x1015_8989; /* jz 0x10158989 */
            ii(0x1015_8983, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1015_8987, 2); jmpd(0x1015_898d, 0x4); goto l_0x1015_898d; /* jmp 0x1015898d */
        l_0x1015_8989:
            ii(0x1015_8989, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1015_898d:
            ii(0x1015_898d, 2); jmpd(0x1015_89be, 0x2f); goto l_0x1015_89be; /* jmp 0x101589be */
        l_0x1015_898f:
            ii(0x1015_898f, 7); cmp(memd_a32[ss, ebp - 0xa0], 0x1b);    /* cmp dword [ebp-0xa0], 0x1b */
            ii(0x1015_8996, 2); if(jnzd(0x1015_899e, 0x6)) goto l_0x1015_899e; /* jnz 0x1015899e */
            ii(0x1015_8998, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_899c, 2); jmpd(0x1015_89be, 0x20); goto l_0x1015_89be; /* jmp 0x101589be */
        l_0x1015_899e:
            ii(0x1015_899e, 10); cmp(memd_a32[ss, ebp - 0xa0], 0x7000); /* cmp dword [ebp-0xa0], 0x7000 */
            ii(0x1015_89a8, 2); if(jld(0x1015_89b0, 0x6)) goto l_0x1015_89b0; /* jl 0x101589b0 */
            ii(0x1015_89aa, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1015_89ae, 2); if(jzd(0x1015_89b2, 0x2)) goto l_0x1015_89b2; /* jz 0x101589b2 */
        l_0x1015_89b0:
            ii(0x1015_89b0, 2); jmpd(0x1015_89be, 0xc); goto l_0x1015_89be; /* jmp 0x101589be */
        l_0x1015_89b2:
            ii(0x1015_89b2, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1015_89b5, 5); calld(0x100c_fbbe, -0x8_8dfc);          /* call 0x100cfbbe */
            ii(0x1015_89ba, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x1015_89be:
            ii(0x1015_89be, 5); calld(0x100d_5094, -0x8_392f);          /* call 0x100d5094 */
            ii(0x1015_89c3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_89c5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1015_89c7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_89cc, 5); calld(0x1010_0e32, -0x5_7b9f);          /* call 0x10100e32 */
            ii(0x1015_89d1, 5); jmpd(0x1015_8923, -0xb3); goto l_0x1015_8923; /* jmp 0x10158923 */
        l_0x1015_89d6:
            ii(0x1015_89d6, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1015_89d9, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1015_89dc, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1015_89e0, 2); if(jzd(0x1015_89f9, 0x17)) goto l_0x1015_89f9; /* jz 0x101589f9 */
            ii(0x1015_89e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_89e4, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1015_89e7, 5); calld(Definitions.my_dtor_d2, -0x8_a4b4); /* call 0x100ce538 */
            ii(0x1015_89ec, 5); calld(Definitions.sys_delete, 0xd573);  /* call 0x10165f64 */
            ii(0x1015_89f1, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x1015_89f7, 2); jmpd(0x1015_8a03, 0xa); goto l_0x1015_8a03; /* jmp 0x10158a03 */
        l_0x1015_89f9:
            ii(0x1015_89f9, 10); mov(memd_a32[ss, ebp - 0xa4], 0);      /* mov dword [ebp-0xa4], 0x0 */
        l_0x1015_8a03:
            ii(0x1015_8a03, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1015_8a06, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1015_8a09, 4); cmp(memd_a32[ss, ebp - 0x38], 0);       /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1015_8a0d, 2); if(jzd(0x1015_8a26, 0x17)) goto l_0x1015_8a26; /* jz 0x10158a26 */
            ii(0x1015_8a0f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8a11, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1015_8a14, 5); calld(Definitions.my_dtor_d2, -0x8_a4e1); /* call 0x100ce538 */
            ii(0x1015_8a19, 5); calld(Definitions.sys_delete, 0xd546);  /* call 0x10165f64 */
            ii(0x1015_8a1e, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x1015_8a24, 2); jmpd(0x1015_8a30, 0xa); goto l_0x1015_8a30; /* jmp 0x10158a30 */
        l_0x1015_8a26:
            ii(0x1015_8a26, 10); mov(memd_a32[ss, ebp - 0xa8], 0);      /* mov dword [ebp-0xa8], 0x0 */
        l_0x1015_8a30:
            ii(0x1015_8a30, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_8a32, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1015_8a35, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1015_8a38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8a3a, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
            ii(0x1015_8a3d, 5); calld(0x100d_6999, -0x8_20a9);          /* call 0x100d6999 */
            ii(0x1015_8a42, 2); jmpd(0x1015_8a4e, 0xa); goto l_0x1015_8a4e; /* jmp 0x10158a4e */
        //  ii(0x1015_8a44, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1015_8a46, 3); lea(eax, ebp - 0x80);                   /* lea eax, [ebp-0x80] */
        //  ii(0x1015_8a49, 5); calld(0x100d_6999, -0x8_20b5);          /* call 0x100d6999 */
        l_0x1015_8a4e:
            ii(0x1015_8a4e, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1015_8a51, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_8a53, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_8a54, 1); popd(edi);                              /* pop edi */
            ii(0x1015_8a55, 1); popd(esi);                              /* pop esi */
            ii(0x1015_8a56, 1); popd(edx);                              /* pop edx */
            ii(0x1015_8a57, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_8a58, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_8a59, 1); retd(); return;                         /* ret */
        }
    }
}
