using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_1740-f9300fac")]
        public void Method_1015_1740()
        {
            ii(0x1015_1740, 5); push(0x130);                            /* push 0x130 */
            ii(0x1015_1745, 5); call(Definitions.sys_check_available_stack_size, 0x1_4608); /* call 0x10165d52 */
            ii(0x1015_174a, 1); push(ebx);                              /* push ebx */
            ii(0x1015_174b, 1); push(ecx);                              /* push ecx */
            ii(0x1015_174c, 1); push(edx);                              /* push edx */
            ii(0x1015_174d, 1); push(esi);                              /* push esi */
            ii(0x1015_174e, 1); push(edi);                              /* push edi */
            ii(0x1015_174f, 1); push(ebp);                              /* push ebp */
            ii(0x1015_1750, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_1752, 6); sub(esp, 0xfc);                         /* sub esp, 0xfc */
            ii(0x1015_1758, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_175b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_175e, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1015_1762, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_1765, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1768, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1015_176c, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_176f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1772, 5); cmp(memw[ds, eax + 8], 0x3e);           /* cmp word [eax+0x8], 0x3e */
            ii(0x1015_1777, 6); if(jnz(0x1015_188f, 0x112)) goto l_0x1015_188f; /* jnz 0x1015188f */
            ii(0x1015_177d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1780, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1015_1785, 5); call(0x1007_6574, -0xd_b216);           /* call 0x10076574 */
            ii(0x1015_178a, 4); mov(ax, memw[ds, eax + 0x52]);          /* mov ax, [eax+0x52] */
            ii(0x1015_178e, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x1015_1791:
            ii(0x1015_1791, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1794, 4); cmp(memb[ds, eax + 0x3e], 6);           /* cmp byte [eax+0x3e], 0x6 */
            ii(0x1015_1798, 2); if(jnz(0x1015_17a3, 9)) goto l_0x1015_17a3; /* jnz 0x101517a3 */
            ii(0x1015_179a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_179c, 5); call(0x1010_0efe, -0x5_08a3);           /* call 0x10100efe */
            ii(0x1015_17a1, 2); jmp(0x1015_1791, -0x12); goto l_0x1015_1791; /* jmp 0x10151791 */
        l_0x1015_17a3:
            ii(0x1015_17a3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_17a5, 1); push(eax);                              /* push eax */
            ii(0x1015_17a6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_17a8, 1); push(eax);                              /* push eax */
            ii(0x1015_17a9, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1015_17ae, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_17b0, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1015_17b4, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_17b8, 5); call(0x1007_4395, -0xd_d428);           /* call 0x10074395 */
            ii(0x1015_17bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_17c0, 5); call(0x1007_623c, -0xd_b589);           /* call 0x1007623c */
            ii(0x1015_17c5, 3); mov(edx, memd[ds, eax + 0x17]);         /* mov edx, [eax+0x17] */
            ii(0x1015_17c8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_17cb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_17ce, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1015_17d1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_17d4, 4); movsx(ebx, memw[ss, ebp - 0x28]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x1015_17d8, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_17da, 5); call(Definitions.my_min, -0xc_805b);    /* call 0x10089784 */
            ii(0x1015_17df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_17e1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_17e4, 4); mov(memw[ds, eax + 0x52], dx);          /* mov [eax+0x52], dx */
            ii(0x1015_17e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_17eb, 7); mov(ax, memw[ds, eax + 0xd5]);          /* mov ax, [eax+0xd5] */
            ii(0x1015_17f2, 3); sub(eax, 8);                            /* sub eax, 0x8 */
            ii(0x1015_17f5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_17f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_17fb, 5); call(0x1014_9b07, -0x7cf9);             /* call 0x10149b07 */
            ii(0x1015_1800, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1803, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_1807, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_180a, 4); mov(memb[ds, eax + 0x3e], 1);           /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_180e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1811, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1015_1816, 5); call(0x1007_6574, -0xd_b2a7);           /* call 0x10076574 */
            ii(0x1015_181b, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1015_181f, 2); if(jz(0x1015_184f, 0x2e)) goto l_0x1015_184f; /* jz 0x1015184f */
            ii(0x1015_1821, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1824, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x1015_1828, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_182b, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x1015_182f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1832, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x1015_1836, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1839, 4); mov(memw[ds, eax + 0x43], dx);          /* mov [eax+0x43], dx */
            ii(0x1015_183d, 5); mov(ebx, 0x24);                         /* mov ebx, 0x24 */
            ii(0x1015_1842, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1015_1847, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_184a, 5); call(0x1016_2f96, 0x1_1747);            /* call 0x10162f96 */
        l_0x1015_184f:
            ii(0x1015_184f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1851, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1854, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1015_1859, 5); call(0x1007_6630, -0xd_b22e);           /* call 0x10076630 */
            ii(0x1015_185e, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_1863, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1866, 5); call(0x1007_6d98, -0xd_aad3);           /* call 0x10076d98 */
            ii(0x1015_186b, 2); test(al, al);                           /* test al, al */
            ii(0x1015_186d, 2); if(jz(0x1015_188a, 0x1b)) goto l_0x1015_188a; /* jz 0x1015188a */
            ii(0x1015_186f, 5); call(0x1010_2bf8, -0x4_ec7c);           /* call 0x10102bf8 */
            ii(0x1015_1874, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_1876, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_1878, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1015_187d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_1880, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_1885, 5); call(0x1013_d5c0, -0x1_42ca);           /* call 0x1013d5c0 */
        l_0x1015_188a:
            ii(0x1015_188a, 5); jmp(0x1015_1d1c, 0x48d); goto l_0x1015_1d1c; /* jmp 0x10151d1c */
        l_0x1015_188f:
            ii(0x1015_188f, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_1893, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1896, 5); call(Definitions.my_ctor_0x101b_38f8, -0xd_b1ab); /* call 0x100766f0 */
            ii(0x1015_189b, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1015_189e, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_18a2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_18a5, 5); call(0x1015_0a9e, -0xe0c);              /* call 0x10150a9e */
            ii(0x1015_18aa, 1); cwde();                                 /* cwde */
            ii(0x1015_18ab, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_18ae, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1015_18b3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_18b5, 3); mov(memd[ss, ebp - 0x20], edx);         /* mov [ebp-0x20], edx */
            ii(0x1015_18b8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_18bb, 4); test(memb[ds, eax + 0x13], 2);          /* test byte [eax+0x13], 0x2 */
            ii(0x1015_18bf, 6); if(jz(0x1015_19d6, 0x111)) goto l_0x1015_19d6; /* jz 0x101519d6 */
            ii(0x1015_18c5, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_18ca, 1); push(eax);                              /* push eax */
            ii(0x1015_18cb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_18cd, 1); push(eax);                              /* push eax */
            ii(0x1015_18ce, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_18d0, 1); push(eax);                              /* push eax */
            ii(0x1015_18d1, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1015_18d5, 1); push(eax);                              /* push eax */
            ii(0x1015_18d6, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_18da, 1); push(eax);                              /* push eax */
            ii(0x1015_18db, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_18de, 5); call(0x1007_6204, -0xd_b6df);           /* call 0x10076204 */
            ii(0x1015_18e3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_18e5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_18e8, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_18eb, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_18ed, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_18f0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_18f3, 5); call(0x1015_0a9e, -0xe5a);              /* call 0x10150a9e */
            ii(0x1015_18f8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_18fb, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1015_18fe, 5); call(0x1015_a2da, 0x89d7);              /* call 0x1015a2da */
            ii(0x1015_1903, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_1905, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1908, 5); call(0x1008_ac18, -0xc_6cf5);           /* call 0x1008ac18 */
            ii(0x1015_190d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_190f, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1015_1912, 5); call(0x1007_5f2c, -0xd_b9eb);           /* call 0x10075f2c */
            ii(0x1015_1917, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_191a, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_191d, 5); call(0x1007_6574, -0xd_b3ae);           /* call 0x10076574 */
            ii(0x1015_1922, 5); call(0x1008_a998, -0xc_6f8f);           /* call 0x1008a998 */
            ii(0x1015_1927, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_192a, 5); call(0x1007_6574, -0xd_b3bb);           /* call 0x10076574 */
            ii(0x1015_192f, 4); mov(memb[ds, eax + 0x3d], 0x10);        /* mov byte [eax+0x3d], 0x10 */
            ii(0x1015_1933, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1936, 5); call(0x1007_6574, -0xd_b3c7);           /* call 0x10076574 */
            ii(0x1015_193b, 4); mov(memb[ds, eax + 0x3e], 3);           /* mov byte [eax+0x3e], 0x3 */
            ii(0x1015_193f, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1942, 5); call(0x1007_6574, -0xd_b3d3);           /* call 0x10076574 */
            ii(0x1015_1947, 4); mov(memb[ds, eax + 0x2d], 4);           /* mov byte [eax+0x2d], 0x4 */
            ii(0x1015_194b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_194e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_1950, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1015_1953, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_1959, 7); inc(memw[ds, eax + 0x101c_a581]);       /* inc word [eax+0x101ca581] */
            ii(0x1015_1960, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1962, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1965, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1968, 5); call(0x1008_b32c, -0xc_6641);           /* call 0x1008b32c */
            ii(0x1015_196d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1970, 4); cmp(memb[ds, eax + 0x7a], 0);           /* cmp byte [eax+0x7a], 0x0 */
            ii(0x1015_1974, 2); if(jz(0x1015_198c, 0x16)) goto l_0x1015_198c; /* jz 0x1015198c */
            ii(0x1015_1976, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1979, 5); call(0x1007_6574, -0xd_b40a);           /* call 0x10076574 */
            ii(0x1015_197e, 3); lea(edx, memd[ds, eax + 8]);            /* lea edx, [eax+0x8] */
            ii(0x1015_1981, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1984, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1987, 5); call(0x1008_b2a8, -0xc_66e4);           /* call 0x1008b2a8 */
        l_0x1015_198c:
            ii(0x1015_198c, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1015_198f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1992, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1015_1997, 5); call(0x1008_ac18, -0xc_6d84);           /* call 0x1008ac18 */
            ii(0x1015_199c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_199f, 6); mov(memw[ds, eax + 0x52], 1);           /* mov word [eax+0x52], 0x1 */
            ii(0x1015_19a5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_19a8, 4); mov(memb[ds, eax + 0x3d], 4);           /* mov byte [eax+0x3d], 0x4 */
            ii(0x1015_19ac, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_19af, 4); mov(memb[ds, eax + 0x3e], 0x1f);        /* mov byte [eax+0x3e], 0x1f */
            ii(0x1015_19b3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_19b6, 3); mov(edx, memd[ds, eax + 0x31]);         /* mov edx, [eax+0x31] */
            ii(0x1015_19b9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_19bc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_19bf, 5); call(0x1014_9b07, -0x7ebd);             /* call 0x10149b07 */
            ii(0x1015_19c4, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_19c9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_19cc, 5); call(0x1015_2605, 0xc34);               /* call 0x10152605 */
            ii(0x1015_19d1, 5); jmp(0x1015_1d12, 0x33c); goto l_0x1015_1d12; /* jmp 0x10151d12 */
        l_0x1015_19d6:
            ii(0x1015_19d6, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_19db, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_19de, 5); call(0x1007_6d98, -0xd_ac4b);           /* call 0x10076d98 */
            ii(0x1015_19e3, 2); test(al, al);                           /* test al, al */
            ii(0x1015_19e5, 2); if(jz(0x1015_1a02, 0x1b)) goto l_0x1015_1a02; /* jz 0x10151a02 */
            ii(0x1015_19e7, 5); call(0x1010_2bf8, -0x4_edf4);           /* call 0x10102bf8 */
            ii(0x1015_19ec, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_19ee, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_19f0, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1015_19f5, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_19f8, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_19fd, 5); call(0x1013_d5c0, -0x1_4442);           /* call 0x1013d5c0 */
        l_0x1015_1a02:
            ii(0x1015_1a02, 4); movsx(ebx, memw[ss, ebp - 0x14]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_1a06, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1015_1a0a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1a0d, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_1a10, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_1a12, 1); cwde();                                 /* cwde */
            ii(0x1015_1a13, 5); call(0x1007_3f48, -0xd_dad0);           /* call 0x10073f48 */
            ii(0x1015_1a18, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_1a1a, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1a1d, 5); call(0x1007_6630, -0xd_b3f2);           /* call 0x10076630 */
            ii(0x1015_1a22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1a24, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1a27, 5); call(0x1013_ad11, -0x1_6d1b);           /* call 0x1013ad11 */
            ii(0x1015_1a2c, 2); test(al, al);                           /* test al, al */
            ii(0x1015_1a2e, 2); if(jz(0x1015_1aa7, 0x77)) goto l_0x1015_1aa7; /* jz 0x10151aa7 */
            ii(0x1015_1a30, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1a33, 5); call(0x1015_0a9e, -0xf9a);              /* call 0x10150a9e */
            ii(0x1015_1a38, 1); cwde();                                 /* cwde */
            ii(0x1015_1a39, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_1a3c, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x1015_1a42, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1a45, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1015_1a48, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1a4b, 1); inc(eax);                               /* inc eax */
            ii(0x1015_1a4c, 1); push(eax);                              /* push eax */
            ii(0x1015_1a4d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1a50, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_1a53, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1a56, 1); inc(eax);                               /* inc eax */
            ii(0x1015_1a57, 1); push(eax);                              /* push eax */
            ii(0x1015_1a58, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1a5b, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_1a5e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1a61, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_1a64, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x1015_1a6a, 5); mov(eax, StringDefinitions.ConesForSAtIIBuildingSPrematurelyDeleted); /* mov eax, 0x101ade3f */
            ii(0x1015_1a6f, 1); push(eax);                              /* push eax */
            ii(0x1015_1a70, 6); lea(eax, memd[ss, ebp - 0xf4]);         /* lea eax, [ebp-0xf4] */
            ii(0x1015_1a76, 1); push(eax);                              /* push eax */
            ii(0x1015_1a77, 5); call(Definitions.sys_sprintf, 0x1_4485); /* call 0x10165f01 */
            ii(0x1015_1a7c, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1015_1a7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1a81, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1a84, 5); call(0x1013_ad71, -0x1_6d18);           /* call 0x1013ad71 */
            ii(0x1015_1a89, 2); test(al, al);                           /* test al, al */
            ii(0x1015_1a8b, 2); if(jnz(0x1015_1aa7, 0x1a)) goto l_0x1015_1aa7; /* jnz 0x10151aa7 */
            ii(0x1015_1a8d, 5); mov(ecx, 0xd9e);                        /* mov ecx, 0xd9e */
            ii(0x1015_1a92, 5); mov(ebx, StringDefinitions.UnitinfoCpp5); /* mov ebx, 0x101ade78 */
            ii(0x1015_1a97, 6); lea(edx, memd[ss, ebp - 0xf4]);         /* lea edx, [ebp-0xf4] */
            ii(0x1015_1a9d, 5); mov(eax, StringDefinitions.NewUnitNotEqual02); /* mov eax, 0x101ade85 */
            ii(0x1015_1aa2, 5); call(0x100f_07d4, -0x6_12d3);           /* call 0x100f07d4 */
        l_0x1015_1aa7:
            ii(0x1015_1aa7, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1aaa, 5); call(0x1007_6574, -0xd_b53b);           /* call 0x10076574 */
            ii(0x1015_1aaf, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1015_1ab3, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_1ab6, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1ab9, 5); call(0x1007_6574, -0xd_b54a);           /* call 0x10076574 */
            ii(0x1015_1abe, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1015_1ac2, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_1ac5, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_1aca, 1); push(eax);                              /* push eax */
            ii(0x1015_1acb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_1acd, 1); push(eax);                              /* push eax */
            ii(0x1015_1ace, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_1ad0, 1); push(eax);                              /* push eax */
            ii(0x1015_1ad1, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1015_1ad5, 1); push(eax);                              /* push eax */
            ii(0x1015_1ad6, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1015_1ada, 1); push(eax);                              /* push eax */
            ii(0x1015_1adb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_1add, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1ae0, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_1ae3, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_1ae5, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_1ae8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1aeb, 5); call(0x1015_0a9e, -0x1052);             /* call 0x10150a9e */
            ii(0x1015_1af0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_1af3, 6); lea(eax, memd[ss, ebp - 0xf8]);         /* lea eax, [ebp-0xf8] */
            ii(0x1015_1af9, 5); call(0x1015_a2da, 0x87dc);              /* call 0x1015a2da */
            ii(0x1015_1afe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_1b00, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1b03, 5); call(0x1008_ac18, -0xc_6ef0);           /* call 0x1008ac18 */
            ii(0x1015_1b08, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1b0a, 6); lea(eax, memd[ss, ebp - 0xf8]);         /* lea eax, [ebp-0xf8] */
            ii(0x1015_1b10, 5); call(0x1007_5f2c, -0xd_bbe9);           /* call 0x10075f2c */
            ii(0x1015_1b15, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1b17, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1b1a, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_1b1d, 5); call(0x1013_ad11, -0x1_6e11);           /* call 0x1013ad11 */
            ii(0x1015_1b22, 2); test(al, al);                           /* test al, al */
            ii(0x1015_1b24, 2); if(jz(0x1015_1b31, 0xb)) goto l_0x1015_1b31; /* jz 0x10151b31 */
            ii(0x1015_1b26, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1b29, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1b2c, 5); call(0x1009_caf8, -0xb_5039);           /* call 0x1009caf8 */
        l_0x1015_1b31:
            ii(0x1015_1b31, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1b34, 5); call(0x1007_65d0, -0xd_b569);           /* call 0x100765d0 */
            ii(0x1015_1b39, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1015_1b3c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_1b3e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_1b40, 5); call(0x1008_a998, -0xc_71ad);           /* call 0x1008a998 */
            ii(0x1015_1b45, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_1b48, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1b4b, 5); call(0x1007_6574, -0xd_b5dc);           /* call 0x10076574 */
            ii(0x1015_1b50, 5); call(0x1008_a998, -0xc_71bd);           /* call 0x1008a998 */
            ii(0x1015_1b55, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1015_1b5a, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1015_1b5f, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1b62, 5); call(0x1007_6600, -0xd_b567);           /* call 0x10076600 */
            ii(0x1015_1b67, 5); call(0x1016_2f96, 0x1_142a);            /* call 0x10162f96 */
            ii(0x1015_1b6c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1b6f, 5); cmp(memw[ds, eax + 8], 0x3d);           /* cmp word [eax+0x8], 0x3d */
            ii(0x1015_1b74, 2); if(jnz(0x1015_1b90, 0x1a)) goto l_0x1015_1b90; /* jnz 0x10151b90 */
            ii(0x1015_1b76, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1b79, 7); mov(ax, memw[ds, eax + 0xd5]);          /* mov ax, [eax+0xd5] */
            ii(0x1015_1b80, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1015_1b83, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_1b86, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1b89, 5); call(0x1014_9b07, -0x8087);             /* call 0x10149b07 */
            ii(0x1015_1b8e, 2); jmp(0x1015_1ba3, 0x13); goto l_0x1015_1ba3; /* jmp 0x10151ba3 */
        l_0x1015_1b90:
            ii(0x1015_1b90, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1b93, 3); mov(al, memb[ds, eax + 0x29]);          /* mov al, [eax+0x29] */
            ii(0x1015_1b96, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_1b98, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_1b9b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1b9e, 5); call(0x1014_9b07, -0x809c);             /* call 0x10149b07 */
        l_0x1015_1ba3:
            ii(0x1015_1ba3, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1ba6, 5); call(0x1007_6574, -0xd_b637);           /* call 0x10076574 */
            ii(0x1015_1bab, 5); cmp(memw[ds, eax + 8], 0x15);           /* cmp word [eax+0x8], 0x15 */
            ii(0x1015_1bb0, 2); if(jz(0x1015_1bc1, 0xf)) goto l_0x1015_1bc1; /* jz 0x10151bc1 */
            ii(0x1015_1bb2, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1bb5, 5); call(0x1007_6574, -0xd_b646);           /* call 0x10076574 */
            ii(0x1015_1bba, 5); cmp(memw[ds, eax + 8], 0x27);           /* cmp word [eax+0x8], 0x27 */
            ii(0x1015_1bbf, 2); if(jnz(0x1015_1bc3, 2)) goto l_0x1015_1bc3; /* jnz 0x10151bc3 */
        l_0x1015_1bc1:
            ii(0x1015_1bc1, 2); jmp(0x1015_1bd2, 0xf); goto l_0x1015_1bd2; /* jmp 0x10151bd2 */
        l_0x1015_1bc3:
            ii(0x1015_1bc3, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1bc6, 5); call(0x1007_6574, -0xd_b657);           /* call 0x10076574 */
            ii(0x1015_1bcb, 5); cmp(memw[ds, eax + 8], 0x21);           /* cmp word [eax+0x8], 0x21 */
            ii(0x1015_1bd0, 2); if(jnz(0x1015_1bd4, 2)) goto l_0x1015_1bd4; /* jnz 0x10151bd4 */
        l_0x1015_1bd2:
            ii(0x1015_1bd2, 2); jmp(0x1015_1be7, 0x13); goto l_0x1015_1be7; /* jmp 0x10151be7 */
        l_0x1015_1bd4:
            ii(0x1015_1bd4, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1bd7, 5); call(0x1007_6574, -0xd_b668);           /* call 0x10076574 */
            ii(0x1015_1bdc, 5); cmp(memw[ds, eax + 8], 0xc);            /* cmp word [eax+0x8], 0xc */
            ii(0x1015_1be1, 6); if(jnz(0x1015_1ce1, 0xfa)) goto l_0x1015_1ce1; /* jnz 0x10151ce1 */
        l_0x1015_1be7:
            ii(0x1015_1be7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_1be9, 1); push(eax);                              /* push eax */
            ii(0x1015_1bea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_1bec, 1); push(eax);                              /* push eax */
            ii(0x1015_1bed, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_1bef, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_1bf1, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1015_1bf5, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1015_1bf9, 5); call(0x1007_4395, -0xd_d869);           /* call 0x10074395 */
            ii(0x1015_1bfe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1c00, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1c03, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1015_1c08, 5); call(0x1007_6630, -0xd_b5dd);           /* call 0x10076630 */
            ii(0x1015_1c0d, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1c10, 5); call(0x1007_6574, -0xd_b6a1);           /* call 0x10076574 */
            ii(0x1015_1c15, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_1c19, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1c1c, 5); call(0x1007_6574, -0xd_b6ad);           /* call 0x10076574 */
            ii(0x1015_1c21, 4); mov(memb[ds, eax + 0x3e], 1);           /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_1c25, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1c28, 5); call(0x1008_abbc, -0xc_7071);           /* call 0x1008abbc */
            ii(0x1015_1c2d, 5); call(0x1015_ec73, 0xd041);              /* call 0x1015ec73 */
            ii(0x1015_1c32, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_1c37, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1c3a, 5); call(0x1007_6600, -0xd_b63f);           /* call 0x10076600 */
            ii(0x1015_1c3f, 5); call(0x1007_1838, -0xe_040c);           /* call 0x10071838 */
            ii(0x1015_1c44, 7); mov(memb[ds, 0x101c_391b], 1);          /* mov byte [0x101c391b], 0x1 */
            ii(0x1015_1c4b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_1c4e, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_1c53, 5); call(0x1010_3752, -0x4_e506);           /* call 0x10103752 */
            ii(0x1015_1c58, 5); call(0x100d_53f0, -0x7_c86d);           /* call 0x100d53f0 */
            ii(0x1015_1c5d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_1c5f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_1c61, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_1c64, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_1c69, 5); call(0x1010_346f, -0x4_e7ff);           /* call 0x1010346f */
            ii(0x1015_1c6e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1c70, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1c73, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_1c76, 5); call(0x1013_ad71, -0x1_6f0a);           /* call 0x1013ad71 */
            ii(0x1015_1c7b, 2); test(al, al);                           /* test al, al */
            ii(0x1015_1c7d, 2); if(jz(0x1015_1c88, 9)) goto l_0x1015_1c88; /* jz 0x10151c88 */
            ii(0x1015_1c7f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1c82, 4); mov(memb[ds, eax + 0x3e], 0x1f);        /* mov byte [eax+0x3e], 0x1f */
            ii(0x1015_1c86, 2); jmp(0x1015_1c96, 0xe); goto l_0x1015_1c96; /* jmp 0x10151c96 */
        l_0x1015_1c88:
            ii(0x1015_1c88, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1c8b, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1015_1c8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1c92, 4); mov(memb[ds, eax + 0x3e], 1);           /* mov byte [eax+0x3e], 0x1 */
        l_0x1015_1c96:
            ii(0x1015_1c96, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1c99, 3); mov(al, memb[ds, eax + 0x29]);          /* mov al, [eax+0x29] */
            ii(0x1015_1c9c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_1c9e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_1ca1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1ca4, 5); call(0x1014_9b07, -0x81a2);             /* call 0x10149b07 */
            ii(0x1015_1ca9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1cac, 5); call(0x1015_26ac, 0x9fb);               /* call 0x101526ac */
            ii(0x1015_1cb1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_1cb3, 2); if(jz(0x1015_1cdf, 0x2a)) goto l_0x1015_1cdf; /* jz 0x10151cdf */
            ii(0x1015_1cb5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1cb8, 5); call(0x1015_26ac, 0x9ef);               /* call 0x101526ac */
            ii(0x1015_1cbd, 6); mov(memd[ss, ebp - 0xfc], eax);         /* mov [ebp-0xfc], eax */
            ii(0x1015_1cc3, 6); mov(eax, memd[ss, ebp - 0xfc]);         /* mov eax, [ebp-0xfc] */
            ii(0x1015_1cc9, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1015_1ccc, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1ccf, 5); call(0x1007_6600, -0xd_b6d4);           /* call 0x10076600 */
            ii(0x1015_1cd4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_1cd6, 6); mov(eax, memd[ss, ebp - 0xfc]);         /* mov eax, [ebp-0xfc] */
            ii(0x1015_1cdc, 3); call_abs(memd[ds, ebx + 0x2c]);         /* call dword [ebx+0x2c] */
        l_0x1015_1cdf:
            ii(0x1015_1cdf, 2); jmp(0x1015_1d12, 0x31); goto l_0x1015_1d12; /* jmp 0x10151d12 */
        l_0x1015_1ce1:
            ii(0x1015_1ce1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1ce4, 4); mov(memb[ds, eax + 0x3d], 4);           /* mov byte [eax+0x3d], 0x4 */
            ii(0x1015_1ce8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1ceb, 4); mov(memb[ds, eax + 0x3e], 0x1f);        /* mov byte [eax+0x3e], 0x1f */
            ii(0x1015_1cef, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1cf2, 5); call(0x1015_26ac, 0x9b5);               /* call 0x101526ac */
            ii(0x1015_1cf7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_1cf9, 2); if(jz(0x1015_1d12, 0x17)) goto l_0x1015_1d12; /* jz 0x10151d12 */
            ii(0x1015_1cfb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1cfe, 5); call(0x1015_26ac, 0x9a9);               /* call 0x101526ac */
            ii(0x1015_1d03, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_1d05, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1d08, 5); call(0x1007_6574, -0xd_b799);           /* call 0x10076574 */
            ii(0x1015_1d0d, 5); call(0x1015_27ed, 0xadb);               /* call 0x101527ed */
        l_0x1015_1d12:
            ii(0x1015_1d12, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1d14, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1015_1d17, 5); call(0x1007_5f2c, -0xd_bdf0);           /* call 0x10075f2c */
        l_0x1015_1d1c:
            ii(0x1015_1d1c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_1d1e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_1d1f, 1); pop(edi);                               /* pop edi */
            ii(0x1015_1d20, 1); pop(esi);                               /* pop esi */
            ii(0x1015_1d21, 1); pop(edx);                               /* pop edx */
            ii(0x1015_1d22, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_1d23, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_1d24, 1); ret();                                  /* ret */
        }
    }
}
