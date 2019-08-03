using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1631a4af-5d37-4e81-b8f1-7f9c3e1abaaf")]
        public void Method_1016_16bd()
        {
            ii(0x1016_16bd, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_16c2, 5); calld(Definitions.sys_check_available_stack_size, 0x468b); /* call 0x10165d52 */
            ii(0x1016_16c7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_16c8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_16c9, 1); pushd(edx);                             /* push edx */
            ii(0x1016_16ca, 1); pushd(esi);                             /* push esi */
            ii(0x1016_16cb, 1); pushd(edi);                             /* push edi */
            ii(0x1016_16cc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_16cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_16cf, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_16d5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_16d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_16db, 5); calld(0x1014_f08b, -0x12655);           /* call 0x1014f08b */
            ii(0x1016_16e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_16e3, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1016_16e7, 6); if(jnzd(0x1016_1863, 0x176)) goto l_0x1016_1863; /* jnz 0x10161863 */
            ii(0x1016_16ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_16f0, 5); calld(0x1007_611c, -0xeb5d9);           /* call 0x1007611c */
            ii(0x1016_16f5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_16f7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_16fa, 5); calld(0x1007_66ac, -0xeb053);           /* call 0x100766ac */
            ii(0x1016_16ff, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_1702, 5); calld(0x1007_6574, -0xeb193);           /* call 0x10076574 */
            ii(0x1016_1707, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1709, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_170c, 5); calld(0x1007_6574, -0xeb19d);           /* call 0x10076574 */
            ii(0x1016_1711, 5); calld(0x1007_623c, -0xeb4da);           /* call 0x1007623c */
            ii(0x1016_1716, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x1016_171a, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x1016_171e, 2); if(jged(0x1016_1733, 0x13)) goto l_0x1016_1733; /* jge 0x10161733 */
            ii(0x1016_1720, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_1723, 5); calld(0x1007_6574, -0xeb1b4);           /* call 0x10076574 */
            ii(0x1016_1728, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1016_172b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_172e, 3); cmp(dl, memb_a32[ds, eax + 0x26]);      /* cmp dl, [eax+0x26] */
            ii(0x1016_1731, 2); if(jzd(0x1016_176b, 0x38)) goto l_0x1016_176b; /* jz 0x1016176b */
        l_0x1016_1733:
            ii(0x1016_1733, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1736, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1016_173a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_173d, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1016_1741, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1744, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1016_1748, 2); if(jzd(0x1016_1759, 0xf)) goto l_0x1016_1759; /* jz 0x10161759 */
            ii(0x1016_174a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_174c, 5); mov(edx, 0xe);                          /* mov edx, 0xe */
            ii(0x1016_1751, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1754, 5); calld(0x1016_2f96, 0x183d);             /* call 0x10162f96 */
        l_0x1016_1759:
            ii(0x1016_1759, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1016_175e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1761, 5); calld(0x1016_2f0a, 0x17a4);             /* call 0x10162f0a */
            ii(0x1016_1766, 5); jmpd(0x1016_17f3, 0x88); goto l_0x1016_17f3; /* jmp 0x101617f3 */
        l_0x1016_176b:
            ii(0x1016_176b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_176e, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1016_1772, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1774, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1777, 5); calld(0x1007_1838, -0xeff44);           /* call 0x10071838 */
            ii(0x1016_177c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_177f, 4); mov(memb_a32[ds, eax + 0x3d], 0x10);    /* mov byte [eax+0x3d], 0x10 */
            ii(0x1016_1783, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_1786, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1016_178b, 5); calld(0x1010_3752, -0x5e03e);           /* call 0x10103752 */
            ii(0x1016_1790, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_1793, 5); calld(0x1007_6574, -0xeb224);           /* call 0x10076574 */
            ii(0x1016_1798, 4); inc(memw_a32[ds, eax + 0x52]);          /* inc word [eax+0x52] */
            ii(0x1016_179c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_179f, 5); calld(0x1007_6574, -0xeb230);           /* call 0x10076574 */
            ii(0x1016_17a4, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1016_17a8, 2); if(jzd(0x1016_17b9, 0xf)) goto l_0x1016_17b9; /* jz 0x101617b9 */
            ii(0x1016_17aa, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_17af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_17b2, 5); calld(0x1015_2605, -0xf1b2);            /* call 0x10152605 */
            ii(0x1016_17b7, 2); jmpd(0x1016_17f3, 0x3a); goto l_0x1016_17f3; /* jmp 0x101617f3 */
        l_0x1016_17b9:
            ii(0x1016_17b9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_17bc, 5); calld(0x1007_6574, -0xeb24d);           /* call 0x10076574 */
            ii(0x1016_17c1, 5); calld(0x1015_26ac, -0xf11a);            /* call 0x101526ac */
            ii(0x1016_17c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_17c8, 2); if(jzd(0x1016_17f3, 0x29)) goto l_0x1016_17f3; /* jz 0x101617f3 */
            ii(0x1016_17ca, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_17cd, 5); calld(0x1007_6574, -0xeb25e);           /* call 0x10076574 */
            ii(0x1016_17d2, 5); calld(0x1015_26ac, -0xf12b);            /* call 0x101526ac */
            ii(0x1016_17d7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_17da, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_17dd, 3); mov(ecx, memd_a32[ds, eax + 0x2]);      /* mov ecx, [eax+0x2] */
            ii(0x1016_17e0, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1016_17e3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_17e6, 5); calld(0x1007_65d0, -0xeb21b);           /* call 0x100765d0 */
            ii(0x1016_17eb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_17ed, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_17f0, 3); calld_abs(memd_a32[ds, ecx + 0x60]);    /* call dword [ecx+0x60] */
        l_0x1016_17f3:
            ii(0x1016_17f3, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_17f8, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_17fb, 5); calld(0x1008_b530, -0xd62d0);           /* call 0x1008b530 */
            ii(0x1016_1800, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1802, 2); if(jzd(0x1016_1811, 0xd)) goto l_0x1016_1811; /* jz 0x10161811 */
            ii(0x1016_1804, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_1807, 5); calld(0x1007_65d0, -0xeb23c);           /* call 0x100765d0 */
            ii(0x1016_180c, 5); calld(0x1010_094d, -0x60ec4);           /* call 0x1010094d */
        l_0x1016_1811:
            ii(0x1016_1811, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1816, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1819, 5); calld(0x1007_6d98, -0xeaa86);           /* call 0x10076d98 */
            ii(0x1016_181e, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1820, 2); if(jzd(0x1016_184a, 0x28)) goto l_0x1016_184a; /* jz 0x1016184a */
            ii(0x1016_1822, 5); calld(0x1010_2bf8, -0x5ec2f);           /* call 0x10102bf8 */
            ii(0x1016_1827, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_1829, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_182b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_182d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_1830, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_1835, 5); calld(0x1013_d5c0, -0x2427a);           /* call 0x1013d5c0 */
            ii(0x1016_183a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_183d, 5); calld(0x1010_094d, -0x60ef5);           /* call 0x1010094d */
            ii(0x1016_1842, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1845, 5); calld(0x1010_19b8, -0x5fe92);           /* call 0x101019b8 */
        l_0x1016_184a:
            ii(0x1016_184a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_184d, 5); calld(0x1014_9fa8, -0x178aa);           /* call 0x10149fa8 */
            ii(0x1016_1852, 7); mov(memb_a32[ds, 0x101c_391b], 0x1);    /* mov byte [0x101c391b], 0x1 */
            ii(0x1016_1859, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_185b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_185e, 5); calld(0x1007_5f2c, -0xeb937);           /* call 0x10075f2c */
        l_0x1016_1863:
            ii(0x1016_1863, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_1865, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_1866, 1); popd(edi);                              /* pop edi */
            ii(0x1016_1867, 1); popd(esi);                              /* pop esi */
            ii(0x1016_1868, 1); popd(edx);                              /* pop edx */
            ii(0x1016_1869, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_186a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_186b, 1); retd(); return;                         /* ret */
        }
    }
}
