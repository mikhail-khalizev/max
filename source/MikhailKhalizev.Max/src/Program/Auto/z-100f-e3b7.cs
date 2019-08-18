using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e3b7-8798bc7e")]
        public void Method_100f_e3b7()
        {
            ii(0x100f_e3b7, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_e3bc, 5); calld(Definitions.sys_check_available_stack_size, 0x6_7991); /* call 0x10165d52 */
            ii(0x100f_e3c1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_e3c2, 1); pushd(esi);                             /* push esi */
            ii(0x100f_e3c3, 1); pushd(edi);                             /* push edi */
            ii(0x100f_e3c4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_e3c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_e3c7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100f_e3cd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_e3d0, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100f_e3d3, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100f_e3d6, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_e3da, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_e3e0, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_e3e6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_e3eb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e3ed, 2); if(jnzd(0x100f_e3f8, 0x9)) goto l_0x100f_e3f8; /* jnz 0x100fe3f8 */
            ii(0x100f_e3ef, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_e3f3, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_e3f6, 2); if(jnzd(0x100f_e3fa, 0x2)) goto l_0x100f_e3fa; /* jnz 0x100fe3fa */
        l_0x100f_e3f8:
            ii(0x100f_e3f8, 2); jmpd(0x100f_e406, 0xc); goto l_0x100f_e406; /* jmp 0x100fe406 */
        l_0x100f_e3fa:
            ii(0x100f_e3fa, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_e3fe, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_e401, 5); jmpd(0x100f_e5c3, 0x1bd); goto l_0x100f_e5c3; /* jmp 0x100fe5c3 */
        l_0x100f_e406:
            ii(0x100f_e406, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_e409, 5); calld(0x1007_6338, -0x8_80d6);          /* call 0x10076338 */
            ii(0x100f_e40e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_e410, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e413, 5); calld(0x1007_64b8, -0x8_7f60);          /* call 0x100764b8 */
        l_0x100f_e418:
            ii(0x100f_e418, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e41a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e41d, 5); calld(0x1013_ad71, 0x3_c94f);           /* call 0x1013ad71 */
            ii(0x100f_e422, 2); test(al, al);                           /* test al, al */
            ii(0x100f_e424, 6); if(jzd(0x100f_e5a6, 0x17c)) goto l_0x100f_e5a6; /* jz 0x100fe5a6 */
            ii(0x100f_e42a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e42d, 5); calld(0x1007_63a0, -0x8_8092);          /* call 0x100763a0 */
            ii(0x100f_e432, 5); calld(0x1007_6154, -0x8_82e3);          /* call 0x10076154 */
            ii(0x100f_e437, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100f_e43c, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x100f_e441, 2); if(jzd(0x100f_e451, 0xe)) goto l_0x100f_e451; /* jz 0x100fe451 */
            ii(0x100f_e443, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e446, 5); calld(0x1007_63a0, -0x8_80ab);          /* call 0x100763a0 */
            ii(0x100f_e44b, 4); test(memb_a32[ds, eax + 0x12], 0x2);    /* test byte [eax+0x12], 0x2 */
            ii(0x100f_e44f, 2); if(jzd(0x100f_e453, 0x2)) goto l_0x100f_e453; /* jz 0x100fe453 */
        l_0x100f_e451:
            ii(0x100f_e451, 2); jmpd(0x100f_e468, 0x15); goto l_0x100f_e468; /* jmp 0x100fe468 */
        l_0x100f_e453:
            ii(0x100f_e453, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e456, 5); calld(0x1007_63a0, -0x8_80bb);          /* call 0x100763a0 */
            ii(0x100f_e45b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e45d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_e460, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_e464, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_e466, 2); if(jzd(0x100f_e46d, 0x5)) goto l_0x100f_e46d; /* jz 0x100fe46d */
        l_0x100f_e468:
            ii(0x100f_e468, 5); jmpd(0x100f_e599, 0x12c); goto l_0x100f_e599; /* jmp 0x100fe599 */
        l_0x100f_e46d:
            ii(0x100f_e46d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e471, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e474, 5); calld(0x1007_63a0, -0x8_80d9);          /* call 0x100763a0 */
            ii(0x100f_e479, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100f_e47c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100f_e47e, 1); cwde();                                 /* cwde */
            ii(0x100f_e47f, 5); calld(0x100f_e354, -0x130);             /* call 0x100fe354 */
            ii(0x100f_e484, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e487, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e48b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e48e, 5); calld(0x1007_63a0, -0x8_80f3);          /* call 0x100763a0 */
            ii(0x100f_e493, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_e496, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_e499, 5); calld(0x100f_e354, -0x14a);             /* call 0x100fe354 */
            ii(0x100f_e49e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e4a1, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e4a5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e4a8, 5); calld(0x1007_63a0, -0x8_810d);          /* call 0x100763a0 */
            ii(0x100f_e4ad, 3); mov(al, memb_a32[ds, eax + 0x27]);      /* mov al, [eax+0x27] */
            ii(0x100f_e4b0, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100f_e4b2, 1); cwde();                                 /* cwde */
            ii(0x100f_e4b3, 5); calld(0x100f_e354, -0x164);             /* call 0x100fe354 */
            ii(0x100f_e4b8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e4bb, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e4bf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e4c2, 5); calld(0x1007_63a0, -0x8_8127);          /* call 0x100763a0 */
            ii(0x100f_e4c7, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100f_e4ca, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_e4cd, 5); calld(0x100f_e354, -0x17e);             /* call 0x100fe354 */
            ii(0x100f_e4d2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e4d5, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e4d9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e4dc, 5); calld(0x1007_63a0, -0x8_8141);          /* call 0x100763a0 */
            ii(0x100f_e4e1, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x100f_e4e4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_e4e7, 5); calld(0x100f_e354, -0x198);             /* call 0x100fe354 */
            ii(0x100f_e4ec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e4ef, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e4f3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e4f6, 5); calld(0x1007_63a0, -0x8_815b);          /* call 0x100763a0 */
            ii(0x100f_e4fb, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100f_e4fe, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100f_e500, 1); cwde();                                 /* cwde */
            ii(0x100f_e501, 5); calld(0x100f_e354, -0x1b2);             /* call 0x100fe354 */
            ii(0x100f_e506, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e509, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e50c, 5); calld(0x1007_63a0, -0x8_8171);          /* call 0x100763a0 */
            ii(0x100f_e511, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100f_e515, 2); if(jnzd(0x100f_e531, 0x1a)) goto l_0x100f_e531; /* jnz 0x100fe531 */
            ii(0x100f_e517, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e51b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e51e, 5); calld(0x1007_63a0, -0x8_8183);          /* call 0x100763a0 */
            ii(0x100f_e523, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100f_e526, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100f_e528, 1); cwde();                                 /* cwde */
            ii(0x100f_e529, 5); calld(0x100f_e354, -0x1da);             /* call 0x100fe354 */
            ii(0x100f_e52e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100f_e531:
            ii(0x100f_e531, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e535, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e538, 5); calld(0x1007_63a0, -0x8_819d);          /* call 0x100763a0 */
            ii(0x100f_e53d, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100f_e540, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100f_e542, 1); cwde();                                 /* cwde */
            ii(0x100f_e543, 5); calld(0x100f_e354, -0x1f4);             /* call 0x100fe354 */
            ii(0x100f_e548, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e54b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e54e, 5); calld(0x1007_63a0, -0x8_81b3);          /* call 0x100763a0 */
            ii(0x100f_e553, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100f_e556, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_e559, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_e55c, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0); /* cmp byte [eax+0x101c81d5], 0x0 */
            ii(0x100f_e563, 2); if(jzd(0x100f_e57f, 0x1a)) goto l_0x100f_e57f; /* jz 0x100fe57f */
            ii(0x100f_e565, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e569, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e56c, 5); calld(0x1007_63a0, -0x8_81d1);          /* call 0x100763a0 */
            ii(0x100f_e571, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100f_e574, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_e577, 5); calld(0x100f_e354, -0x228);             /* call 0x100fe354 */
            ii(0x100f_e57c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100f_e57f:
            ii(0x100f_e57f, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_e583, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e586, 5); calld(0x1007_63a0, -0x8_81eb);          /* call 0x100763a0 */
            ii(0x100f_e58b, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x100f_e58e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100f_e590, 1); cwde();                                 /* cwde */
            ii(0x100f_e591, 5); calld(0x100f_e354, -0x242);             /* call 0x100fe354 */
            ii(0x100f_e596, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100f_e599:
            ii(0x100f_e599, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e59c, 5); calld(0x1007_6bf8, -0x8_79a9);          /* call 0x10076bf8 */
            ii(0x100f_e5a1, 5); jmpd(0x100f_e418, -0x18e); goto l_0x100f_e418; /* jmp 0x100fe418 */
        l_0x100f_e5a6:
            ii(0x100f_e5a6, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_e5aa, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_e5ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e5af, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_e5b2, 5); calld(0x1007_5f6c, -0x8_864b);          /* call 0x10075f6c */
            ii(0x100f_e5b7, 2); jmpd(0x100f_e5c3, 0xa); goto l_0x100f_e5c3; /* jmp 0x100fe5c3 */
        //    ii(0x100f_e5b9, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100f_e5bb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x100f_e5be, 5); calld(0x1007_5f6c, -0x8_8657);          /* call 0x10075f6c */
        l_0x100f_e5c3:
            ii(0x100f_e5c3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_e5c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_e5c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_e5c9, 1); popd(edi);                              /* pop edi */
            ii(0x100f_e5ca, 1); popd(esi);                              /* pop esi */
            ii(0x100f_e5cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_e5cc, 1); retd(); return;                         /* ret */
        }
    }
}
