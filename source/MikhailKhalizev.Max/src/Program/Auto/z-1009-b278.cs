using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45e45b29-8a54-4a17-8422-d382cdb3e0a8")]
        public void Method_1009_b278()
        {
            ii(0x1009_b278, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x1009_b27d, 5); calld(Definitions.sys_check_available_stack_size, 0xc_aad0); /* call 0x10165d52 */
            ii(0x1009_b282, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b283, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b284, 1); pushd(edx);                             /* push edx */
            ii(0x1009_b285, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b286, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b287, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b288, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b28a, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x1009_b290, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_b293, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b296, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b299, 5); calld(0x1007_6b90, -0x2_470e);          /* call 0x10076b90 */
            ii(0x1009_b29e, 1); cwde();                                 /* cwde */
            ii(0x1009_b29f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_b2a1, 2); if(jnzd(0x1009_b2ac, 0x9)) goto l_0x1009_b2ac; /* jnz 0x1009b2ac */
            ii(0x1009_b2a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b2a6, 4); cmp(memb_a32[ds, eax + 0x1d], 0);       /* cmp byte [eax+0x1d], 0x0 */
            ii(0x1009_b2aa, 2); if(jzd(0x1009_b2b1, 0x5)) goto l_0x1009_b2b1; /* jz 0x1009b2b1 */
        l_0x1009_b2ac:
            ii(0x1009_b2ac, 5); jmpd(0x1009_b473, 0x1c2); goto l_0x1009_b473; /* jmp 0x1009b473 */
        l_0x1009_b2b1:
            ii(0x1009_b2b1, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1009_b2b6, 5); calld(0x1007_6338, -0x2_4f83);          /* call 0x10076338 */
            ii(0x1009_b2bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b2bd, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b2c0, 5); calld(0x1007_64b8, -0x2_4e0d);          /* call 0x100764b8 */
            ii(0x1009_b2c5, 5); mov(eax, 0xe1);                         /* mov eax, 0xe1 */
            ii(0x1009_b2ca, 5); calld(Definitions.sys_new, 0xc_ab31);   /* call 0x10165e00 */
            ii(0x1009_b2cf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_b2d2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_b2d5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_b2d8, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_b2dc, 2); if(jzd(0x1009_b30b, 0x2d)) goto l_0x1009_b30b; /* jz 0x1009b30b */
            ii(0x1009_b2de, 5); calld(0x1008_ac70, -0x1_0673);          /* call 0x1008ac70 */
            ii(0x1009_b2e3, 1); cwde();                                 /* cwde */
            ii(0x1009_b2e4, 1); pushd(eax);                             /* push eax */
            ii(0x1009_b2e5, 5); mov(ecx, 0xffff);                       /* mov ecx, 0xffff */
            ii(0x1009_b2ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b2ed, 3); mov(ebx, memd_a32[ds, eax + 0x7]);      /* mov ebx, [eax+0x7] */
            ii(0x1009_b2f0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_b2f3, 5); mov(edx, 0x3e);                         /* mov edx, 0x3e */
            ii(0x1009_b2f8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_b2fb, 5); calld(0x1014_9237, 0xa_df37);           /* call 0x10149237 */
            ii(0x1009_b300, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_b303, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_b306, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_b309, 2); jmpd(0x1009_b311, 0x6); goto l_0x1009_b311; /* jmp 0x1009b311 */
        l_0x1009_b30b:
            ii(0x1009_b30b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_b30e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1009_b311:
            ii(0x1009_b311, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1009_b314, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_b317, 5); calld(0x1007_66ac, -0x2_4c70);          /* call 0x100766ac */
            ii(0x1009_b31c, 2); jmpd(0x1009_b326, 0x8); goto l_0x1009_b326; /* jmp 0x1009b326 */
        l_0x1009_b31e:
            ii(0x1009_b31e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b321, 5); calld(0x1007_6bf8, -0x2_472e);          /* call 0x10076bf8 */
        l_0x1009_b326:
            ii(0x1009_b326, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b328, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b32b, 5); calld(0x1013_ad71, 0x9_fa41);           /* call 0x1013ad71 */
            ii(0x1009_b330, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b332, 6); if(jzd(0x1009_b45f, 0x127)) goto l_0x1009_b45f; /* jz 0x1009b45f */
            ii(0x1009_b338, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b33b, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1009_b33e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_b341, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b344, 5); calld(0x1007_63a0, -0x2_4fa9);          /* call 0x100763a0 */
            ii(0x1009_b349, 5); calld(0x1007_6074, -0x2_52da);          /* call 0x10076074 */
            ii(0x1009_b34e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b350, 2); if(jzd(0x1009_b372, 0x20)) goto l_0x1009_b372; /* jz 0x1009b372 */
            ii(0x1009_b352, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b355, 5); calld(0x1007_63a0, -0x2_4fba);          /* call 0x100763a0 */
            ii(0x1009_b35a, 5); cmp(memw_a32[ds, eax + 0x8], 0xe);      /* cmp word [eax+0x8], 0xe */
            ii(0x1009_b35f, 2); if(jzd(0x1009_b370, 0xf)) goto l_0x1009_b370; /* jz 0x1009b370 */
            ii(0x1009_b361, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b364, 5); calld(0x1007_63a0, -0x2_4fc9);          /* call 0x100763a0 */
            ii(0x1009_b369, 5); cmp(memw_a32[ds, eax + 0x8], 0xd);      /* cmp word [eax+0x8], 0xd */
            ii(0x1009_b36e, 2); if(jnzd(0x1009_b372, 0x2)) goto l_0x1009_b372; /* jnz 0x1009b372 */
        l_0x1009_b370:
            ii(0x1009_b370, 2); jmpd(0x1009_b377, 0x5); goto l_0x1009_b377; /* jmp 0x1009b377 */
        l_0x1009_b372:
            ii(0x1009_b372, 5); jmpd(0x1009_b45a, 0xe3); goto l_0x1009_b45a; /* jmp 0x1009b45a */
        l_0x1009_b377:
            ii(0x1009_b377, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b37a, 5); calld(0x1007_63a0, -0x2_4fdf);          /* call 0x100763a0 */
            ii(0x1009_b37f, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1009_b382, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_b385, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b388, 5); calld(0x1007_63a0, -0x2_4fed);          /* call 0x100763a0 */
            ii(0x1009_b38d, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_b390, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_b393, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_b396, 5); calld(0x1007_6aac, -0x2_48ef);          /* call 0x10076aac */
            ii(0x1009_b39b, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1009_b3a0, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1009_b3a5, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1009_b3a8, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_b3ab, 5); calld(0x1007_5e64, -0x2_554c);          /* call 0x10075e64 */
            ii(0x1009_b3b0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b3b2, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_b3b5, 5); calld(0x1008_abbc, -0x1_07fe);          /* call 0x1008abbc */
            ii(0x1009_b3ba, 5); calld(0x100a_90f9, 0xdd3a);             /* call 0x100a90f9 */
            ii(0x1009_b3bf, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b3c1, 6); if(jnzd(0x1009_b45a, 0x93)) goto l_0x1009_b45a; /* jnz 0x1009b45a */
            ii(0x1009_b3c7, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1009_b3cc, 5); calld(Definitions.sys_new, 0xc_aa2f);   /* call 0x10165e00 */
            ii(0x1009_b3d1, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_b3d4, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_b3d7, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1009_b3da, 4); cmp(memd_a32[ss, ebp - 0x2c], 0);       /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1009_b3de, 2); if(jzd(0x1009_b3f9, 0x19)) goto l_0x1009_b3f9; /* jz 0x1009b3f9 */
            ii(0x1009_b3e0, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1009_b3e3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_b3e6, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_b3e9, 5); calld(Definitions.my_ctor_c12, 0xac7e); /* call 0x100a606c */
            ii(0x1009_b3ee, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1009_b3f1, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_b3f4, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1009_b3f7, 2); jmpd(0x1009_b3ff, 0x6); goto l_0x1009_b3ff; /* jmp 0x1009b3ff */
        l_0x1009_b3f9:
            ii(0x1009_b3f9, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1009_b3fc, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1009_b3ff:
            ii(0x1009_b3ff, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1009_b402, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_b405, 5); calld(0x1008_a914, -0x1_0af6);          /* call 0x1008a914 */
            ii(0x1009_b40a, 5); mov(edx, 0x3e);                         /* mov edx, 0x3e */
            ii(0x1009_b40f, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_b412, 5); calld(0x1008_a7dc, -0x1_0c3b);          /* call 0x1008a7dc */
            ii(0x1009_b417, 5); calld(0x100a_63bc, 0xafa0);             /* call 0x100a63bc */
            ii(0x1009_b41c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b41f, 4); mov(memb_a32[ds, eax + 0x1d], 0x1);     /* mov byte [eax+0x1d], 0x1 */
            ii(0x1009_b423, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_b426, 5); calld(0x1008_a838, -0x1_0bf3);          /* call 0x1008a838 */
            ii(0x1009_b42b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b42d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_b432, 5); calld(0x100a_4d50, 0x9919);             /* call 0x100a4d50 */
            ii(0x1009_b437, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b439, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_b43c, 5); calld(0x1008_8cbc, -0x1_2785);          /* call 0x10088cbc */
            ii(0x1009_b441, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b443, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_b446, 5); calld(0x1007_5f2c, -0x2_551f);          /* call 0x10075f2c */
            ii(0x1009_b44b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b44d, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b450, 5); calld(0x1007_5f6c, -0x2_54e9);          /* call 0x10075f6c */
            ii(0x1009_b455, 5); jmpd(0x1009_b4d1, 0x77); goto l_0x1009_b4d1; /* jmp 0x1009b4d1 */
        l_0x1009_b45a:
            ii(0x1009_b45a, 5); jmpd(0x1009_b31e, -0x141); goto l_0x1009_b31e; /* jmp 0x1009b31e */
        l_0x1009_b45f:
            ii(0x1009_b45f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b461, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_b464, 5); calld(0x1007_5f2c, -0x2_553d);          /* call 0x10075f2c */
            ii(0x1009_b469, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b46b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b46e, 5); calld(0x1007_5f6c, -0x2_5507);          /* call 0x10075f6c */
        l_0x1009_b473:
            ii(0x1009_b473, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b476, 5); calld(0x1008_ad28, -0x1_0753);          /* call 0x1008ad28 */
            ii(0x1009_b47b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b47d, 2); if(jnzd(0x1009_b4d1, 0x52)) goto l_0x1009_b4d1; /* jnz 0x1009b4d1 */
            ii(0x1009_b47f, 5); calld(0x1008_a7bc, -0x1_0cc8);          /* call 0x1008a7bc */
            ii(0x1009_b484, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_b489, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1009_b48c, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1009_b491, 5); calld(Definitions.sys_new, 0xc_a96a);   /* call 0x10165e00 */
            ii(0x1009_b496, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1009_b499, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1009_b49c, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1009_b49f, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1009_b4a3, 2); if(jzd(0x1009_b4bb, 0x16)) goto l_0x1009_b4bb; /* jz 0x1009b4bb */
            ii(0x1009_b4a5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_b4a8, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1009_b4ab, 5); calld(Definitions.my_ctor_c11, 0x8419); /* call 0x100a38c9 */
            ii(0x1009_b4b0, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1009_b4b3, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1009_b4b6, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1009_b4b9, 2); jmpd(0x1009_b4c1, 0x6); goto l_0x1009_b4c1; /* jmp 0x1009b4c1 */
        l_0x1009_b4bb:
            ii(0x1009_b4bb, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1009_b4be, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
        l_0x1009_b4c1:
            ii(0x1009_b4c1, 3); mov(edx, memd_a32[ss, ebp - 0x4c]);     /* mov edx, [ebp-0x4c] */
            ii(0x1009_b4c4, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_b4c9, 3); mov(ebx, memd_a32[ss, ebp - 0x3c]);     /* mov ebx, [ebp-0x3c] */
            ii(0x1009_b4cc, 5); calld(0x100a_4db6, 0x98e5);             /* call 0x100a4db6 */
        l_0x1009_b4d1:
            ii(0x1009_b4d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b4d3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b4d4, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b4d5, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b4d6, 1); popd(edx);                              /* pop edx */
            ii(0x1009_b4d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b4d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b4d9, 1); retd(); return;                         /* ret */
        }
    }
}
