using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_e611-11c1d4c1")]
        public void Method_1015_e611()
        {
            ii(0x1015_e611, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1015_e616, 5); calld(Definitions.sys_check_available_stack_size, 0x7737); /* call 0x10165d52 */
            ii(0x1015_e61b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_e61c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_e61d, 1); pushd(edx);                             /* push edx */
            ii(0x1015_e61e, 1); pushd(esi);                             /* push esi */
            ii(0x1015_e61f, 1); pushd(edi);                             /* push edi */
            ii(0x1015_e620, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_e621, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_e623, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_e629, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_e62c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e62f, 5); calld(0x1014_1698, -0x1_cf9c);          /* call 0x10141698 */
            ii(0x1015_e634, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_e637, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_e63b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e63e, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xe_7f53); /* call 0x100766f0 */
            ii(0x1015_e643, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_e646, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_e64a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e64d, 5); calld(0x1015_410e, -0xa544);            /* call 0x1015410e */
            ii(0x1015_e652, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e654, 2); if(jnzd(0x1015_e665, 0xf)) goto l_0x1015_e665; /* jnz 0x1015e665 */
            ii(0x1015_e656, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e658, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e65b, 5); calld(0x1007_5f2c, -0xe_8734);          /* call 0x10075f2c */
            ii(0x1015_e660, 5); jmpd(0x1015_e7e4, 0x17f); goto l_0x1015_e7e4; /* jmp 0x1015e7e4 */
        l_0x1015_e665:
            ii(0x1015_e665, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e668, 5); calld(0x1007_611c, -0xe_8551);          /* call 0x1007611c */
            ii(0x1015_e66d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_e66f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e672, 5); calld(0x1007_6630, -0xe_8047);          /* call 0x10076630 */
            ii(0x1015_e677, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e67a, 5); calld(0x1007_6574, -0xe_810b);          /* call 0x10076574 */
            ii(0x1015_e67f, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1015_e682, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e687, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_e689, 2); if(jzd(0x1015_e699, 0xe)) goto l_0x1015_e699; /* jz 0x1015e699 */
            ii(0x1015_e68b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e68e, 5); calld(0x1007_6574, -0xe_811f);          /* call 0x10076574 */
            ii(0x1015_e693, 4); cmp(memb_a32[ds, eax + 0x3d], 0x3);     /* cmp byte [eax+0x3d], 0x3 */
            ii(0x1015_e697, 2); if(jnzd(0x1015_e69b, 0x2)) goto l_0x1015_e69b; /* jnz 0x1015e69b */
        l_0x1015_e699:
            ii(0x1015_e699, 2); jmpd(0x1015_e6a9, 0xe); goto l_0x1015_e6a9; /* jmp 0x1015e6a9 */
        l_0x1015_e69b:
            ii(0x1015_e69b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e69e, 5); calld(0x1007_6574, -0xe_812f);          /* call 0x10076574 */
            ii(0x1015_e6a3, 4); cmp(memb_a32[ds, eax + 0x3d], 0x9);     /* cmp byte [eax+0x3d], 0x9 */
            ii(0x1015_e6a7, 2); if(jnzd(0x1015_e6ab, 0x2)) goto l_0x1015_e6ab; /* jnz 0x1015e6ab */
        l_0x1015_e6a9:
            ii(0x1015_e6a9, 2); jmpd(0x1015_e6b9, 0xe); goto l_0x1015_e6b9; /* jmp 0x1015e6b9 */
        l_0x1015_e6ab:
            ii(0x1015_e6ab, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e6ae, 5); calld(0x1007_6574, -0xe_813f);          /* call 0x10076574 */
            ii(0x1015_e6b3, 4); cmp(memb_a32[ds, eax + 0x3e], 0xe);     /* cmp byte [eax+0x3e], 0xe */
            ii(0x1015_e6b7, 2); if(jnzd(0x1015_e6be, 0x5)) goto l_0x1015_e6be; /* jnz 0x1015e6be */
        l_0x1015_e6b9:
            ii(0x1015_e6b9, 5); jmpd(0x1015_e7b3, 0xf5); goto l_0x1015_e7b3; /* jmp 0x1015e7b3 */
        l_0x1015_e6be:
            ii(0x1015_e6be, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_e6c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e6c6, 5); calld(0x1007_6d98, -0xe_7933);          /* call 0x10076d98 */
            ii(0x1015_e6cb, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e6cd, 2); if(jzd(0x1015_e6e6, 0x17)) goto l_0x1015_e6e6; /* jz 0x1015e6e6 */
            ii(0x1015_e6cf, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1015_e6d4, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1015_e6d9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_e6dc, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_e6e1, 5); calld(0x1013_d5c0, -0x2_1126);          /* call 0x1013d5c0 */
        l_0x1015_e6e6:
            ii(0x1015_e6e6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e6e8, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e6eb, 5); calld(0x1007_6574, -0xe_817c);          /* call 0x10076574 */
            ii(0x1015_e6f0, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_e6f3, 5); calld(0x1007_6a34, -0xe_7cc4);          /* call 0x10076a34 */
            ii(0x1015_e6f8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_e6fb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e6fe, 5); calld(0x1007_6574, -0xe_818f);          /* call 0x10076574 */
            ii(0x1015_e703, 5); calld(0x1008_a998, -0xd_3d70);          /* call 0x1008a998 */
            ii(0x1015_e708, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e70b, 5); calld(0x1007_65d0, -0xe_8140);          /* call 0x100765d0 */
            ii(0x1015_e710, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_e712, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_e717, 5); calld(0x1010_3752, -0x5_afca);          /* call 0x10103752 */
            ii(0x1015_e71c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e71f, 5); calld(0x1007_6574, -0xe_81b0);          /* call 0x10076574 */
            ii(0x1015_e724, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1015_e728, 2); if(jzd(0x1015_e742, 0x18)) goto l_0x1015_e742; /* jz 0x1015e742 */
            ii(0x1015_e72a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e72d, 5); calld(0x1007_6574, -0xe_81be);          /* call 0x10076574 */
            ii(0x1015_e732, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_e736, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e739, 5); calld(0x1007_6574, -0xe_81ca);          /* call 0x10076574 */
            ii(0x1015_e73e, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
        l_0x1015_e742:
            ii(0x1015_e742, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e744, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e747, 5); calld(0x1007_65d0, -0xe_817c);          /* call 0x100765d0 */
            ii(0x1015_e74c, 5); calld(0x1007_1838, -0xe_cf19);          /* call 0x10071838 */
            ii(0x1015_e751, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1015_e756, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1015_e75b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e75e, 5); calld(0x1007_65d0, -0xe_8193);          /* call 0x100765d0 */
            ii(0x1015_e763, 5); calld(0x1016_2f96, 0x482e);             /* call 0x10162f96 */
            ii(0x1015_e768, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e76b, 5); calld(0x1007_6574, -0xe_81fc);          /* call 0x10076574 */
            ii(0x1015_e770, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_e773, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e778, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_e77e, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_e784, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_e789, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_e78c, 2); if(jnzd(0x1015_e795, 0x7)) goto l_0x1015_e795; /* jnz 0x1015e795 */
            ii(0x1015_e78e, 7); mov(memb_a32[ds, 0x101c_391b], 0x1);    /* mov byte [0x101c391b], 0x1 */
        l_0x1015_e795:
            ii(0x1015_e795, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e798, 4); inc(memw_a32[ds, eax + 0x52]);          /* inc word [eax+0x52] */
            ii(0x1015_e79c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e79f, 4); mov(dx, memw_a32[ds, eax + 0x52]);      /* mov dx, [eax+0x52] */
            ii(0x1015_e7a3, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_e7a6, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x1015_e7aa, 2); if(jnzd(0x1015_e7b3, 0x7)) goto l_0x1015_e7b3; /* jnz 0x1015e7b3 */
            ii(0x1015_e7ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e7af, 4); mov(memb_a32[ds, eax + 0x57], 0);       /* mov byte [eax+0x57], 0x0 */
        l_0x1015_e7b3:
            ii(0x1015_e7b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e7b6, 4); mov(memb_a32[ds, eax + 0x5e], 0);       /* mov byte [eax+0x5e], 0x0 */
            ii(0x1015_e7ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e7bd, 4); mov(memb_a32[ds, eax + 0x3e], 0x10);    /* mov byte [eax+0x3e], 0x10 */
            ii(0x1015_e7c1, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_e7c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e7c9, 5); calld(0x1007_6d98, -0xe_7a36);          /* call 0x10076d98 */
            ii(0x1015_e7ce, 2); test(al, al);                           /* test al, al */
            ii(0x1015_e7d0, 2); if(jzd(0x1015_e7da, 0x8)) goto l_0x1015_e7da; /* jz 0x1015e7da */
            ii(0x1015_e7d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_e7d5, 5); calld(0x1010_094d, -0x5_de8d);          /* call 0x1010094d */
        l_0x1015_e7da:
            ii(0x1015_e7da, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_e7dc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_e7df, 5); calld(0x1007_5f2c, -0xe_88b8);          /* call 0x10075f2c */
        l_0x1015_e7e4:
            ii(0x1015_e7e4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_e7e6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_e7e7, 1); popd(edi);                              /* pop edi */
            ii(0x1015_e7e8, 1); popd(esi);                              /* pop esi */
            ii(0x1015_e7e9, 1); popd(edx);                              /* pop edx */
            ii(0x1015_e7ea, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_e7eb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_e7ec, 1); retd();                                 /* ret */
        }
    }
}
