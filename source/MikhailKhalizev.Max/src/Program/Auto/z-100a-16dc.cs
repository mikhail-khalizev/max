using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_16dc-846d2b37")]
        public void Method_100a_16dc()
        {
            ii(0x100a_16dc, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x100a_16e1, 5); calld(Definitions.sys_check_available_stack_size, 0xc_466c); /* call 0x10165d52 */
            ii(0x100a_16e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_16e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_16e8, 1); pushd(edx);                             /* push edx */
            ii(0x100a_16e9, 1); pushd(esi);                             /* push esi */
            ii(0x100a_16ea, 1); pushd(edi);                             /* push edi */
            ii(0x100a_16eb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_16ec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_16ee, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100a_16f4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_16f7, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100a_16fb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_16fe, 5); calld(0x1007_64fc, -0x2_b207);          /* call 0x100764fc */
            ii(0x100a_1703, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_1706, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100a_170a, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100a_170e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_1711, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x2_b026); /* call 0x100766f0 */
            ii(0x100a_1716, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_1719, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100a_171d, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100a_1720, 5); calld(0x1007_20b1, -0x2_f674);          /* call 0x100720b1 */
            ii(0x100a_1725, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100a_1728, 5); calld(0x1007_20b1, -0x2_f67c);          /* call 0x100720b1 */
            ii(0x100a_172d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_172f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1732, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_1735, 5); calld(0x1013_ad71, 0x9_9637);           /* call 0x1013ad71 */
            ii(0x100a_173a, 2); test(al, al);                           /* test al, al */
            ii(0x100a_173c, 2); if(jzd(0x100a_174f, 0x11)) goto l_0x100a_174f; /* jz 0x100a174f */
            ii(0x100a_173e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1741, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_1744, 5); calld(0x1007_6574, -0x2_b1d5);          /* call 0x10076574 */
            ii(0x100a_1749, 4); cmp(memb_a32[ds, eax + 0x3d], 0x8);     /* cmp byte [eax+0x3d], 0x8 */
            ii(0x100a_174d, 2); if(jnzd(0x100a_1751, 0x2)) goto l_0x100a_1751; /* jnz 0x100a1751 */
        l_0x100a_174f:
            ii(0x100a_174f, 2); jmpd(0x100a_1762, 0x11); goto l_0x100a_1762; /* jmp 0x100a1762 */
        l_0x100a_1751:
            ii(0x100a_1751, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1754, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_1757, 5); calld(0x1007_6574, -0x2_b1e8);          /* call 0x10076574 */
            ii(0x100a_175c, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100a_1760, 2); if(jnzd(0x100a_1764, 0x2)) goto l_0x100a_1764; /* jnz 0x100a1764 */
        l_0x100a_1762:
            ii(0x100a_1762, 2); jmpd(0x100a_1775, 0x11); goto l_0x100a_1775; /* jmp 0x100a1775 */
        l_0x100a_1764:
            ii(0x100a_1764, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_1767, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_176a, 5); calld(0x1007_6574, -0x2_b1fb);          /* call 0x10076574 */
            ii(0x100a_176f, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100a_1773, 2); if(jnzd(0x100a_1777, 0x2)) goto l_0x100a_1777; /* jnz 0x100a1777 */
        l_0x100a_1775:
            ii(0x100a_1775, 2); jmpd(0x100a_1789, 0x12); goto l_0x100a_1789; /* jmp 0x100a1789 */
        l_0x100a_1777:
            ii(0x100a_1777, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_177a, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_177d, 5); calld(0x1007_6574, -0x2_b20e);          /* call 0x10076574 */
            ii(0x100a_1782, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100a_1787, 2); if(jzd(0x100a_178b, 0x2)) goto l_0x100a_178b; /* jz 0x100a178b */
        l_0x100a_1789:
            ii(0x100a_1789, 2); jmpd(0x100a_17b6, 0x2b); goto l_0x100a_17b6; /* jmp 0x100a17b6 */
        l_0x100a_178b:
            ii(0x100a_178b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_178e, 3); add(edx, 0x44);                         /* add edx, 0x44 */
            ii(0x100a_1791, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_1794, 5); calld(0x1008_ac18, -0x1_6b81);          /* call 0x1008ac18 */
            ii(0x100a_1799, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_179e, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100a_17a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_17a4, 3); add(eax, 0x44);                         /* add eax, 0x44 */
            ii(0x100a_17a7, 5); calld(0x1007_6600, -0x2_b1ac);          /* call 0x10076600 */
            ii(0x100a_17ac, 5); calld(0x1007_2388, -0x2_f429);          /* call 0x10072388 */
            ii(0x100a_17b1, 5); jmpd(0x100a_189d, 0xe7); goto l_0x100a_189d; /* jmp 0x100a189d */
        l_0x100a_17b6:
            ii(0x100a_17b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_17b8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_17bb, 5); calld(0x1007_6630, -0x2_b190);          /* call 0x10076630 */
            ii(0x100a_17c0, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100a_17c5, 5); calld(0x1007_6338, -0x2_b492);          /* call 0x10076338 */
            ii(0x100a_17ca, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_17cc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_17cf, 5); calld(0x1007_643c, -0x2_b398);          /* call 0x1007643c */
        l_0x100a_17d4:
            ii(0x100a_17d4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_17d6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_17d9, 5); calld(0x1013_ad71, 0x9_9593);           /* call 0x1013ad71 */
            ii(0x100a_17de, 2); test(al, al);                           /* test al, al */
            ii(0x100a_17e0, 6); if(jzd(0x100a_189d, 0xb7)) goto l_0x100a_189d; /* jz 0x100a189d */
            ii(0x100a_17e6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_17e9, 5); calld(0x1007_63a0, -0x2_b44e);          /* call 0x100763a0 */
            ii(0x100a_17ee, 5); calld(0x1007_6204, -0x2_b5ef);          /* call 0x10076204 */
            ii(0x100a_17f3, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_17f6, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x100a_17f9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_17fb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_17fd, 5); calld(0x1007_6e00, -0x2_aa02);          /* call 0x10076e00 */
            ii(0x100a_1802, 2); test(al, al);                           /* test al, al */
            ii(0x100a_1804, 2); if(jzd(0x100a_1814, 0xe)) goto l_0x100a_1814; /* jz 0x100a1814 */
            ii(0x100a_1806, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1809, 5); calld(0x1007_63a0, -0x2_b46e);          /* call 0x100763a0 */
            ii(0x100a_180e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x8);     /* cmp byte [eax+0x3d], 0x8 */
            ii(0x100a_1812, 2); if(jnzd(0x100a_1816, 0x2)) goto l_0x100a_1816; /* jnz 0x100a1816 */
        l_0x100a_1814:
            ii(0x100a_1814, 2); jmpd(0x100a_1824, 0xe); goto l_0x100a_1824; /* jmp 0x100a1824 */
        l_0x100a_1816:
            ii(0x100a_1816, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1819, 5); calld(0x1007_63a0, -0x2_b47e);          /* call 0x100763a0 */
            ii(0x100a_181e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100a_1822, 2); if(jnzd(0x100a_1826, 0x2)) goto l_0x100a_1826; /* jnz 0x100a1826 */
        l_0x100a_1824:
            ii(0x100a_1824, 2); jmpd(0x100a_1834, 0xe); goto l_0x100a_1834; /* jmp 0x100a1834 */
        l_0x100a_1826:
            ii(0x100a_1826, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1829, 5); calld(0x1007_63a0, -0x2_b48e);          /* call 0x100763a0 */
            ii(0x100a_182e, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100a_1832, 2); if(jnzd(0x100a_1836, 0x2)) goto l_0x100a_1836; /* jnz 0x100a1836 */
        l_0x100a_1834:
            ii(0x100a_1834, 2); jmpd(0x100a_1845, 0xf); goto l_0x100a_1845; /* jmp 0x100a1845 */
        l_0x100a_1836:
            ii(0x100a_1836, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1839, 5); calld(0x1007_63a0, -0x2_b49e);          /* call 0x100763a0 */
            ii(0x100a_183e, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x100a_1843, 2); if(jzd(0x100a_1847, 0x2)) goto l_0x100a_1847; /* jz 0x100a1847 */
        l_0x100a_1845:
            ii(0x100a_1845, 2); jmpd(0x100a_1890, 0x49); goto l_0x100a_1890; /* jmp 0x100a1890 */
        l_0x100a_1847:
            ii(0x100a_1847, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_184c, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100a_184f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1852, 5); calld(0x1007_6408, -0x2_b44f);          /* call 0x10076408 */
            ii(0x100a_1857, 5); calld(0x1007_2388, -0x2_f4d4);          /* call 0x10072388 */
            ii(0x100a_185c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_185e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_1861, 5); calld(0x1013_ad11, 0x9_94ab);           /* call 0x1013ad11 */
            ii(0x100a_1866, 2); test(al, al);                           /* test al, al */
            ii(0x100a_1868, 2); if(jnzd(0x100a_1873, 0x9)) goto l_0x100a_1873; /* jnz 0x100a1873 */
            ii(0x100a_186a, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_186d, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x100a_1871, 2); if(jged(0x100a_1890, 0x1d)) goto l_0x100a_1890; /* jge 0x100a1890 */
        l_0x100a_1873:
            ii(0x100a_1873, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1876, 5); calld(0x1007_6408, -0x2_b473);          /* call 0x10076408 */
            ii(0x100a_187b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_187d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_1880, 5); calld(0x1007_6630, -0x2_b255);          /* call 0x10076630 */
            ii(0x100a_1885, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100a_1888, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100a_188b, 5); calld(0x100a_9f78, 0x86e8);             /* call 0x100a9f78 */
        l_0x100a_1890:
            ii(0x100a_1890, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_1893, 5); calld(0x1007_6bf8, -0x2_aca0);          /* call 0x10076bf8 */
            ii(0x100a_1898, 5); jmpd(0x100a_17d4, -0xc9); goto l_0x100a_17d4; /* jmp 0x100a17d4 */
        l_0x100a_189d:
            ii(0x100a_189d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_189f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_18a2, 5); calld(0x1013_ad11, 0x9_946a);           /* call 0x1013ad11 */
            ii(0x100a_18a7, 2); test(al, al);                           /* test al, al */
            ii(0x100a_18a9, 2); if(jzd(0x100a_18c8, 0x1d)) goto l_0x100a_18c8; /* jz 0x100a18c8 */
            ii(0x100a_18ab, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_18af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_18b1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_18b4, 5); calld(0x1007_5f2c, -0x2_b98d);          /* call 0x10075f2c */
            ii(0x100a_18b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_18bb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_18be, 5); calld(0x1007_5f6c, -0x2_b957);          /* call 0x10075f6c */
            ii(0x100a_18c3, 5); jmpd(0x100a_1978, 0xb0); goto l_0x100a_1978; /* jmp 0x100a1978 */
        l_0x100a_18c8:
            ii(0x100a_18c8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_18cb, 5); calld(0x1007_6574, -0x2_b35c);          /* call 0x10076574 */
            ii(0x100a_18d0, 3); mov(al, memb_a32[ds, eax + 0x47]);      /* mov al, [eax+0x47] */
            ii(0x100a_18d3, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_18d5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_18d8, 4); sub(memw_a32[ds, edx + 0x20], ax);      /* sub [edx+0x20], ax */
            ii(0x100a_18dc, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_18df, 5); calld(0x1007_6574, -0x2_b370);          /* call 0x10076574 */
            ii(0x100a_18e4, 3); mov(al, memb_a32[ds, eax + 0x49]);      /* mov al, [eax+0x49] */
            ii(0x100a_18e7, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_18e9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_18ec, 4); sub(memw_a32[ds, edx + 0x1e], ax);      /* sub [edx+0x1e], ax */
            ii(0x100a_18f0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_18f3, 5); calld(0x1007_6574, -0x2_b384);          /* call 0x10076574 */
            ii(0x100a_18f8, 3); mov(al, memb_a32[ds, eax + 0x48]);      /* mov al, [eax+0x48] */
            ii(0x100a_18fb, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_18fd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_1900, 4); sub(memw_a32[ds, edx + 0x22], ax);      /* sub [edx+0x22], ax */
            ii(0x100a_1904, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100a_1907, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_190a, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100a_190d, 5); calld(0x100a_13f7, -0x51b);             /* call 0x100a13f7 */
            ii(0x100a_1912, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_1914, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x100a_1919, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_191c, 5); calld(0x1007_6600, -0x2_b321);          /* call 0x10076600 */
            ii(0x100a_1921, 5); calld(0x1016_3053, 0xc_172d);           /* call 0x10163053 */
            ii(0x100a_1926, 5); mov(eax, StringDefinitions.Power3);     /* mov eax, 0x101a0a73 */
            ii(0x100a_192b, 1); pushd(eax);                             /* push eax */
            ii(0x100a_192c, 5); mov(ecx, StringDefinitions.MoreSNeededSTurnedOff2); /* mov ecx, 0x101a0a79 */
            ii(0x100a_1931, 5); mov(ebx, StringDefinitions.CannotTurnSOnSNeeded2); /* mov ebx, 0x101a0a99 */
            ii(0x100a_1936, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_1939, 5); calld(0x1007_6600, -0x2_b33e);          /* call 0x10076600 */
            ii(0x100a_193e, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100a_1941, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_1943, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100a_1945, 5); calld(0x100a_0f77, -0x9d3);             /* call 0x100a0f77 */
            ii(0x100a_194a, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_194e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_1950, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_1953, 5); calld(0x1007_5f2c, -0x2_ba2c);          /* call 0x10075f2c */
            ii(0x100a_1958, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_195a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_195d, 5); calld(0x1007_5f6c, -0x2_b9f6);          /* call 0x10075f6c */
            ii(0x100a_1962, 2); jmpd(0x100a_1978, 0x14); goto l_0x100a_1978; /* jmp 0x100a1978 */
        //  ii(0x100a_1964, 20); Недостижимый код.
        l_0x100a_1978:
            ii(0x100a_1978, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_197b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_197d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_197e, 1); popd(edi);                              /* pop edi */
            ii(0x100a_197f, 1); popd(esi);                              /* pop esi */
            ii(0x100a_1980, 1); popd(edx);                              /* pop edx */
            ii(0x100a_1981, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_1982, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_1983, 1); retd(); return;                         /* ret */
        }
    }
}
