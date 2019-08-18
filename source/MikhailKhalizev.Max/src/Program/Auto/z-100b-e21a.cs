using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("257abd53-bb8a-47a1-916f-c04b31a9dd62")]
        public void Method_100b_e21a()
        {
            ii(0x100b_e21a, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100b_e21f, 5); calld(Definitions.sys_check_available_stack_size, 0xa_7b2e); /* call 0x10165d52 */
            ii(0x100b_e224, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_e225, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_e226, 1); pushd(edx);                             /* push edx */
            ii(0x100b_e227, 1); pushd(esi);                             /* push esi */
            ii(0x100b_e228, 1); pushd(edi);                             /* push edi */
            ii(0x100b_e229, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_e22a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_e22c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_e232, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_e235, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_e239, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e23c, 5); calld(0x1007_64fc, -0x4_7d45);          /* call 0x100764fc */
            ii(0x100b_e241, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_e244, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_e248, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_e24d, 5); calld(0x1007_6338, -0x4_7f1a);          /* call 0x10076338 */
            ii(0x100b_e252, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e254, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e257, 5); calld(0x1007_643c, -0x4_7e20);          /* call 0x1007643c */
            ii(0x100b_e25c, 2); jmpd(0x100b_e266, 0x8); goto l_0x100b_e266; /* jmp 0x100be266 */
        l_0x100b_e25e:
            ii(0x100b_e25e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e261, 5); calld(0x1007_6bf8, -0x4_766e);          /* call 0x10076bf8 */
        l_0x100b_e266:
            ii(0x100b_e266, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e268, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e26b, 5); calld(0x1013_ad71, 0x7_cb01);           /* call 0x1013ad71 */
            ii(0x100b_e270, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e272, 6); if(jzd(0x100b_e335, 0xbd)) goto l_0x100b_e335; /* jz 0x100be335 */
            ii(0x100b_e278, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e27b, 5); calld(0x1007_63a0, -0x4_7ee0);          /* call 0x100763a0 */
            ii(0x100b_e280, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e282, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_e285, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e288, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_e28b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_e28d, 2); if(jnzd(0x100b_e2a0, 0x11)) goto l_0x100b_e2a0; /* jnz 0x100be2a0 */
            ii(0x100b_e28f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e292, 5); calld(0x1007_63a0, -0x4_7ef7);          /* call 0x100763a0 */
            ii(0x100b_e297, 5); calld(0x1015_26ac, 0x9_4410);           /* call 0x101526ac */
            ii(0x100b_e29c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_e29e, 2); if(jzd(0x100b_e2a5, 0x5)) goto l_0x100b_e2a5; /* jz 0x100be2a5 */
        l_0x100b_e2a0:
            ii(0x100b_e2a0, 5); jmpd(0x100b_e311, 0x6c); goto l_0x100b_e311; /* jmp 0x100be311 */
        l_0x100b_e2a5:
            ii(0x100b_e2a5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e2a8, 5); calld(0x1007_63a0, -0x4_7f0d);          /* call 0x100763a0 */
            ii(0x100b_e2ad, 5); calld(0x1007_623c, -0x4_8076);          /* call 0x1007623c */
            ii(0x100b_e2b2, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100b_e2b5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_e2b8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_e2ba, 2); if(jgd(0x100b_e2cb, 0xf)) goto l_0x100b_e2cb; /* jg 0x100be2cb */
            ii(0x100b_e2bc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e2bf, 5); calld(0x1007_63a0, -0x4_7f24);          /* call 0x100763a0 */
            ii(0x100b_e2c4, 5); cmp(memw_a32[ds, eax + 0x8], 0x18);     /* cmp word [eax+0x8], 0x18 */
            ii(0x100b_e2c9, 2); if(jnzd(0x100b_e2cd, 0x2)) goto l_0x100b_e2cd; /* jnz 0x100be2cd */
        l_0x100b_e2cb:
            ii(0x100b_e2cb, 2); jmpd(0x100b_e2dc, 0xf); goto l_0x100b_e2dc; /* jmp 0x100be2dc */
        l_0x100b_e2cd:
            ii(0x100b_e2cd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e2d0, 5); calld(0x1007_63a0, -0x4_7f35);          /* call 0x100763a0 */
            ii(0x100b_e2d5, 5); cmp(memw_a32[ds, eax + 0x8], 0x19);     /* cmp word [eax+0x8], 0x19 */
            ii(0x100b_e2da, 2); if(jnzd(0x100b_e2de, 0x2)) goto l_0x100b_e2de; /* jnz 0x100be2de */
        l_0x100b_e2dc:
            ii(0x100b_e2dc, 2); jmpd(0x100b_e2ed, 0xf); goto l_0x100b_e2ed; /* jmp 0x100be2ed */
        l_0x100b_e2de:
            ii(0x100b_e2de, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e2e1, 5); calld(0x1007_63a0, -0x4_7f46);          /* call 0x100763a0 */
            ii(0x100b_e2e6, 5); cmp(memw_a32[ds, eax + 0x8], 0x17);     /* cmp word [eax+0x8], 0x17 */
            ii(0x100b_e2eb, 2); if(jnzd(0x100b_e2ef, 0x2)) goto l_0x100b_e2ef; /* jnz 0x100be2ef */
        l_0x100b_e2ed:
            ii(0x100b_e2ed, 2); jmpd(0x100b_e2fe, 0xf); goto l_0x100b_e2fe; /* jmp 0x100be2fe */
        l_0x100b_e2ef:
            ii(0x100b_e2ef, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e2f2, 5); calld(0x1007_63a0, -0x4_7f57);          /* call 0x100763a0 */
            ii(0x100b_e2f7, 5); cmp(memw_a32[ds, eax + 0x8], 0x1b);     /* cmp word [eax+0x8], 0x1b */
            ii(0x100b_e2fc, 2); if(jnzd(0x100b_e300, 0x2)) goto l_0x100b_e300; /* jnz 0x100be300 */
        l_0x100b_e2fe:
            ii(0x100b_e2fe, 2); jmpd(0x100b_e30f, 0xf); goto l_0x100b_e30f; /* jmp 0x100be30f */
        l_0x100b_e300:
            ii(0x100b_e300, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e303, 5); calld(0x1007_63a0, -0x4_7f68);          /* call 0x100763a0 */
            ii(0x100b_e308, 5); cmp(memw_a32[ds, eax + 0x8], 0x20);     /* cmp word [eax+0x8], 0x20 */
            ii(0x100b_e30d, 2); if(jnzd(0x100b_e311, 0x2)) goto l_0x100b_e311; /* jnz 0x100be311 */
        l_0x100b_e30f:
            ii(0x100b_e30f, 2); jmpd(0x100b_e313, 0x2); goto l_0x100b_e313; /* jmp 0x100be313 */
        l_0x100b_e311:
            ii(0x100b_e311, 2); jmpd(0x100b_e330, 0x1d); goto l_0x100b_e330; /* jmp 0x100be330 */
        l_0x100b_e313:
            ii(0x100b_e313, 5); calld(0x1008_a79c, -0x3_3b7c);          /* call 0x1008a79c */
            ii(0x100b_e318, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_e31a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_e31c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e31f, 5); calld(0x1007_63d4, -0x4_7f50);          /* call 0x100763d4 */
            ii(0x100b_e324, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e326, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_e32b, 5); calld(0x100a_53ac, -0x1_8f84);          /* call 0x100a53ac */
        l_0x100b_e330:
            ii(0x100b_e330, 5); jmpd(0x100b_e25e, -0xd7); goto l_0x100b_e25e; /* jmp 0x100be25e */
        l_0x100b_e335:
            ii(0x100b_e335, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_e33a, 5); calld(0x1007_6338, -0x4_8007);          /* call 0x10076338 */
            ii(0x100b_e33f, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100b_e342, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e344, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_e346, 5); calld(0x1007_643c, -0x4_7f0f);          /* call 0x1007643c */
            ii(0x100b_e34b, 2); jmpd(0x100b_e355, 0x8); goto l_0x100b_e355; /* jmp 0x100be355 */
        l_0x100b_e34d:
            ii(0x100b_e34d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e350, 5); calld(0x1007_6bf8, -0x4_775d);          /* call 0x10076bf8 */
        l_0x100b_e355:
            ii(0x100b_e355, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e357, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e35a, 5); calld(0x1013_ad71, 0x7_ca12);           /* call 0x1013ad71 */
            ii(0x100b_e35f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e361, 2); if(jzd(0x100b_e3ac, 0x49)) goto l_0x100b_e3ac; /* jz 0x100be3ac */
            ii(0x100b_e363, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e366, 5); calld(0x1007_63a0, -0x4_7fcb);          /* call 0x100763a0 */
            ii(0x100b_e36b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e36d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_e370, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e373, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_e376, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_e378, 2); if(jnzd(0x100b_e38b, 0x11)) goto l_0x100b_e38b; /* jnz 0x100be38b */
            ii(0x100b_e37a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e37d, 5); calld(0x1007_63a0, -0x4_7fe2);          /* call 0x100763a0 */
            ii(0x100b_e382, 5); calld(0x1015_26ac, 0x9_4325);           /* call 0x101526ac */
            ii(0x100b_e387, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_e389, 2); if(jzd(0x100b_e38d, 0x2)) goto l_0x100b_e38d; /* jz 0x100be38d */
        l_0x100b_e38b:
            ii(0x100b_e38b, 2); jmpd(0x100b_e3aa, 0x1d); goto l_0x100b_e3aa; /* jmp 0x100be3aa */
        l_0x100b_e38d:
            ii(0x100b_e38d, 5); calld(0x1008_a79c, -0x3_3bf6);          /* call 0x1008a79c */
            ii(0x100b_e392, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_e394, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_e396, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e399, 5); calld(0x1007_63d4, -0x4_7fca);          /* call 0x100763d4 */
            ii(0x100b_e39e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e3a0, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_e3a5, 5); calld(0x100a_53ac, -0x1_8ffe);          /* call 0x100a53ac */
        l_0x100b_e3aa:
            ii(0x100b_e3aa, 2); jmpd(0x100b_e34d, -0x5f); goto l_0x100b_e34d; /* jmp 0x100be34d */
        l_0x100b_e3ac:
            ii(0x100b_e3ac, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100b_e3b1, 5); calld(0x1007_6338, -0x4_807e);          /* call 0x10076338 */
            ii(0x100b_e3b6, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100b_e3b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e3bb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_e3bd, 5); calld(0x1007_643c, -0x4_7f86);          /* call 0x1007643c */
            ii(0x100b_e3c2, 2); jmpd(0x100b_e3cc, 0x8); goto l_0x100b_e3cc; /* jmp 0x100be3cc */
        l_0x100b_e3c4:
            ii(0x100b_e3c4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e3c7, 5); calld(0x1007_6bf8, -0x4_77d4);          /* call 0x10076bf8 */
        l_0x100b_e3cc:
            ii(0x100b_e3cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e3ce, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e3d1, 5); calld(0x1013_ad71, 0x7_c99b);           /* call 0x1013ad71 */
            ii(0x100b_e3d6, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e3d8, 2); if(jzd(0x100b_e423, 0x49)) goto l_0x100b_e423; /* jz 0x100be423 */
            ii(0x100b_e3da, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e3dd, 5); calld(0x1007_63a0, -0x4_8042);          /* call 0x100763a0 */
            ii(0x100b_e3e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e3e4, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_e3e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e3ea, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_e3ed, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_e3ef, 2); if(jnzd(0x100b_e402, 0x11)) goto l_0x100b_e402; /* jnz 0x100be402 */
            ii(0x100b_e3f1, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e3f4, 5); calld(0x1007_63a0, -0x4_8059);          /* call 0x100763a0 */
            ii(0x100b_e3f9, 5); calld(0x1015_26ac, 0x9_42ae);           /* call 0x101526ac */
            ii(0x100b_e3fe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_e400, 2); if(jzd(0x100b_e404, 0x2)) goto l_0x100b_e404; /* jz 0x100be404 */
        l_0x100b_e402:
            ii(0x100b_e402, 2); jmpd(0x100b_e421, 0x1d); goto l_0x100b_e421; /* jmp 0x100be421 */
        l_0x100b_e404:
            ii(0x100b_e404, 5); calld(0x1008_a79c, -0x3_3c6d);          /* call 0x1008a79c */
            ii(0x100b_e409, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_e40b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_e40d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e410, 5); calld(0x1007_63d4, -0x4_8041);          /* call 0x100763d4 */
            ii(0x100b_e415, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e417, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_e41c, 5); calld(0x100a_53ac, -0x1_9075);          /* call 0x100a53ac */
        l_0x100b_e421:
            ii(0x100b_e421, 2); jmpd(0x100b_e3c4, -0x5f); goto l_0x100b_e3c4; /* jmp 0x100be3c4 */
        l_0x100b_e423:
            ii(0x100b_e423, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e425, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_e428, 5); calld(0x1007_5f6c, -0x4_84c1);          /* call 0x10075f6c */
            ii(0x100b_e42d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_e42f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_e430, 1); popd(edi);                              /* pop edi */
            ii(0x100b_e431, 1); popd(esi);                              /* pop esi */
            ii(0x100b_e432, 1); popd(edx);                              /* pop edx */
            ii(0x100b_e433, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_e434, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_e435, 1); retd(); return;                         /* ret */
        }
    }
}
