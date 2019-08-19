using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_177d-5639582")]
        public void Method_1009_177d()
        {
            ii(0x1009_177d, 5); pushd(0xa8);                            /* push 0xa8 */
            ii(0x1009_1782, 5); calld(Definitions.sys_check_available_stack_size, 0xd_45cb); /* call 0x10165d52 */
            ii(0x1009_1787, 1); pushd(esi);                             /* push esi */
            ii(0x1009_1788, 1); pushd(edi);                             /* push edi */
            ii(0x1009_1789, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_178a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_178c, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x1009_1792, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_1795, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_1798, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_179b, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_179e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_17a1, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_17a4, 5); calld(0x1009_c6c8, 0xaf1f);             /* call 0x1009c6c8 */
            ii(0x1009_17a9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_17ab, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_17ae, 5); calld(0x1009_c5dc, 0xae29);             /* call 0x1009c5dc */
            ii(0x1009_17b3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_17b7, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_17ba, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1009_17c1, 2); if(jzd(0x1009_17cc, 0x9)) goto l_0x1009_17cc; /* jz 0x100917cc */
            ii(0x1009_17c3, 7); mov(memd_a32[ss, ebp - 0x20], 0x2);     /* mov dword [ebp-0x20], 0x2 */
            ii(0x1009_17ca, 2); jmpd(0x1009_17d3, 0x7); goto l_0x1009_17d3; /* jmp 0x100917d3 */
        l_0x1009_17cc:
            ii(0x1009_17cc, 7); mov(memd_a32[ss, ebp - 0x20], 0x1);     /* mov dword [ebp-0x20], 0x1 */
        l_0x1009_17d3:
            ii(0x1009_17d3, 2); jmpd(0x1009_17dd, 0x8); goto l_0x1009_17dd; /* jmp 0x100917dd */
        l_0x1009_17d5:
            ii(0x1009_17d5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_17d8, 5); calld(0x1007_6bf8, -0x1_abe5);          /* call 0x10076bf8 */
        l_0x1009_17dd:
            ii(0x1009_17dd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_17df, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_17e2, 5); calld(0x1013_ad71, 0xa_958a);           /* call 0x1013ad71 */
            ii(0x1009_17e7, 2); test(al, al);                           /* test al, al */
            ii(0x1009_17e9, 6); if(jzd(0x1009_18cf, 0xe0)) goto l_0x1009_18cf; /* jz 0x100918cf */
            ii(0x1009_17ef, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_17f2, 5); calld(0x1009_c52c, 0xad35);             /* call 0x1009c52c */
            ii(0x1009_17f7, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1009_17fa, 2); if(jzd(0x1009_180f, 0x13)) goto l_0x1009_180f; /* jz 0x1009180f */
            ii(0x1009_17fc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_17ff, 5); calld(0x1009_c4f8, 0xacf4);             /* call 0x1009c4f8 */
            ii(0x1009_1804, 5); calld(0x1009_c4c4, 0xacbb);             /* call 0x1009c4c4 */
            ii(0x1009_1809, 4); cmp(ax, 0xc);                           /* cmp ax, 0xc */
            ii(0x1009_180d, 2); if(jnzd(0x1009_1811, 0x2)) goto l_0x1009_1811; /* jnz 0x10091811 */
        l_0x1009_180f:
            ii(0x1009_180f, 2); jmpd(0x1009_1824, 0x13); goto l_0x1009_1824; /* jmp 0x10091824 */
        l_0x1009_1811:
            ii(0x1009_1811, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1814, 5); calld(0x1009_c4f8, 0xacdf);             /* call 0x1009c4f8 */
            ii(0x1009_1819, 5); calld(0x1009_c4c4, 0xaca6);             /* call 0x1009c4c4 */
            ii(0x1009_181e, 4); cmp(ax, 0x21);                          /* cmp ax, 0x21 */
            ii(0x1009_1822, 2); if(jnzd(0x1009_1826, 0x2)) goto l_0x1009_1826; /* jnz 0x10091826 */
        l_0x1009_1824:
            ii(0x1009_1824, 2); jmpd(0x1009_1841, 0x1b); goto l_0x1009_1841; /* jmp 0x10091841 */
        l_0x1009_1826:
            ii(0x1009_1826, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1829, 5); calld(0x1009_c4f8, 0xacca);             /* call 0x1009c4f8 */
            ii(0x1009_182e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_1831, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_1834, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_1837, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_183a, 3); calld_abs(memd_a32[ds, edx + 0x74]);    /* call dword [edx+0x74] */
            ii(0x1009_183d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_183f, 2); if(jnzd(0x1009_1846, 0x5)) goto l_0x1009_1846; /* jnz 0x10091846 */
        l_0x1009_1841:
            ii(0x1009_1841, 5); jmpd(0x1009_18ca, 0x84); goto l_0x1009_18ca; /* jmp 0x100918ca */
        l_0x1009_1846:
            ii(0x1009_1846, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1849, 5); calld(0x1009_c4f8, 0xacaa);             /* call 0x1009c4f8 */
            ii(0x1009_184e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_1851, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_1854, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_1857, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1009_185a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_185d, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1009_1860, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1863, 5); calld(0x1009_c4f8, 0xac90);             /* call 0x1009c4f8 */
            ii(0x1009_1868, 5); calld(0x1009_c4c4, 0xac57);             /* call 0x1009c4c4 */
            ii(0x1009_186d, 4); cmp(ax, 0x27);                          /* cmp ax, 0x27 */
            ii(0x1009_1871, 2); if(jnzd(0x1009_18a7, 0x34)) goto l_0x1009_18a7; /* jnz 0x100918a7 */
            ii(0x1009_1873, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1876, 5); calld(0x1009_c4f8, 0xac7d);             /* call 0x1009c4f8 */
            ii(0x1009_187b, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1009_187e, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1009_1881, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_1884, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1009_1887, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_188a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_188c, 2); if(jzd(0x1009_18a5, 0x17)) goto l_0x1009_18a5; /* jz 0x100918a5 */
            ii(0x1009_188e, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_1891, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1894, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_1897, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1009_189a, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_189c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_189e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_18a0, 5); mov(memw_a32[ds, eax], 0x6);            /* mov word [eax], 0x6 */
        l_0x1009_18a5:
            ii(0x1009_18a5, 2); jmpd(0x1009_18ca, 0x23); goto l_0x1009_18ca; /* jmp 0x100918ca */
        l_0x1009_18a7:
            ii(0x1009_18a7, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1009_18ac, 1); pushd(eax);                             /* push eax */
            ii(0x1009_18ad, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1009_18b1, 1); pushd(eax);                             /* push eax */
            ii(0x1009_18b2, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1009_18b6, 1); pushd(eax);                             /* push eax */
            ii(0x1009_18b7, 4); movsx(ecx, memw_a32[ss, ebp - 0x34]);   /* movsx ecx, word [ebp-0x34] */
            ii(0x1009_18bb, 4); movsx(ebx, memw_a32[ss, ebp - 0x38]);   /* movsx ebx, word [ebp-0x38] */
            ii(0x1009_18bf, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_18c2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_18c5, 5); calld(0x1009_0aaa, -0xe20);             /* call 0x10090aaa */
        l_0x1009_18ca:
            ii(0x1009_18ca, 5); jmpd(0x1009_17d5, -0xfa); goto l_0x1009_17d5; /* jmp 0x100917d5 */
        l_0x1009_18cf:
            ii(0x1009_18cf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_18d3, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_18d6, 6); mov(al, memb_a32[ds, eax + 0x101c_81d4]); /* mov al, [eax+0x101c81d4] */
            ii(0x1009_18dc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_18e1, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1009_18e4, 2); if(jnzd(0x1009_18ec, 0x6)) goto l_0x1009_18ec; /* jnz 0x100918ec */
            ii(0x1009_18e6, 4); mov(memb_a32[ss, ebp - 0x40], 0x1);     /* mov byte [ebp-0x40], 0x1 */
            ii(0x1009_18ea, 2); jmpd(0x1009_18f0, 0x4); goto l_0x1009_18f0; /* jmp 0x100918f0 */
        l_0x1009_18ec:
            ii(0x1009_18ec, 4); mov(memb_a32[ss, ebp - 0x40], 0);       /* mov byte [ebp-0x40], 0x0 */
        l_0x1009_18f0:
            ii(0x1009_18f0, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x1009_18f3, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1009_18f6, 5); cmp(memw_a32[ss, ebp - 0x4], 0x18);     /* cmp word [ebp-0x4], 0x18 */
            ii(0x1009_18fb, 2); if(jzd(0x1009_1904, 0x7)) goto l_0x1009_1904; /* jz 0x10091904 */
            ii(0x1009_18fd, 5); cmp(memw_a32[ss, ebp - 0x4], 0x19);     /* cmp word [ebp-0x4], 0x19 */
            ii(0x1009_1902, 2); if(jnzd(0x1009_1906, 0x2)) goto l_0x1009_1906; /* jnz 0x10091906 */
        l_0x1009_1904:
            ii(0x1009_1904, 2); jmpd(0x1009_190d, 0x7); goto l_0x1009_190d; /* jmp 0x1009190d */
        l_0x1009_1906:
            ii(0x1009_1906, 5); cmp(memw_a32[ss, ebp - 0x4], 0x9);      /* cmp word [ebp-0x4], 0x9 */
            ii(0x1009_190b, 2); if(jnzd(0x1009_190f, 0x2)) goto l_0x1009_190f; /* jnz 0x1009190f */
        l_0x1009_190d:
            ii(0x1009_190d, 2); jmpd(0x1009_1916, 0x7); goto l_0x1009_1916; /* jmp 0x10091916 */
        l_0x1009_190f:
            ii(0x1009_190f, 5); cmp(memw_a32[ss, ebp - 0x4], 0x20);     /* cmp word [ebp-0x4], 0x20 */
            ii(0x1009_1914, 2); if(jnzd(0x1009_191c, 0x6)) goto l_0x1009_191c; /* jnz 0x1009191c */
        l_0x1009_1916:
            ii(0x1009_1916, 4); mov(memb_a32[ss, ebp - 0x44], 0x1);     /* mov byte [ebp-0x44], 0x1 */
            ii(0x1009_191a, 2); jmpd(0x1009_1920, 0x4); goto l_0x1009_1920; /* jmp 0x10091920 */
        l_0x1009_191c:
            ii(0x1009_191c, 4); mov(memb_a32[ss, ebp - 0x44], 0);       /* mov byte [ebp-0x44], 0x0 */
        l_0x1009_1920:
            ii(0x1009_1920, 3); mov(al, memb_a32[ss, ebp - 0x44]);      /* mov al, [ebp-0x44] */
            ii(0x1009_1923, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1009_1926, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1009_192a, 5); cmp(eax, 0x1300);                       /* cmp eax, 0x1300 */
            ii(0x1009_192f, 2); if(jgd(0x1009_1935, 0x4)) goto l_0x1009_1935; /* jg 0x10091935 */
            ii(0x1009_1931, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x1009_1935:
            ii(0x1009_1935, 5); mov(eax, memd_a32[ds, 0x101c_9454]);    /* mov eax, [0x101c9454] */
            ii(0x1009_193a, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1009_193d, 7); mov(memd_a32[ss, ebp - 0x4c], 0);       /* mov dword [ebp-0x4c], 0x0 */
            ii(0x1009_1944, 2); jmpd(0x1009_194c, 0x6); goto l_0x1009_194c; /* jmp 0x1009194c */
        l_0x1009_1946:
            ii(0x1009_1946, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1009_1949, 3); inc(memd_a32[ss, ebp - 0x4c]);          /* inc dword [ebp-0x4c] */
        l_0x1009_194c:
            ii(0x1009_194c, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1009_194f, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1009_1956, 6); if(jged(0x1009_1afd, 0x1a1)) goto l_0x1009_1afd; /* jge 0x10091afd */
            ii(0x1009_195c, 7); mov(memd_a32[ss, ebp - 0x50], 0);       /* mov dword [ebp-0x50], 0x0 */
            ii(0x1009_1963, 2); jmpd(0x1009_196b, 0x6); goto l_0x1009_196b; /* jmp 0x1009196b */
        l_0x1009_1965:
            ii(0x1009_1965, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_1968, 3); inc(memd_a32[ss, ebp - 0x50]);          /* inc dword [ebp-0x50] */
        l_0x1009_196b:
            ii(0x1009_196b, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1009_196e, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1009_1975, 6); if(jged(0x1009_1af8, 0x17d)) goto l_0x1009_1af8; /* jge 0x10091af8 */
            ii(0x1009_197b, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1009_197e, 3); inc(memd_a32[ss, ebp - 0x48]);          /* inc dword [ebp-0x48] */
            ii(0x1009_1981, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1009_1983, 3); mov(memb_a32[ss, ebp - 0x54], al);      /* mov [ebp-0x54], al */
            ii(0x1009_1986, 5); jmpd(0x1009_1ab7, 0x12c); goto l_0x1009_1ab7; /* jmp 0x10091ab7 */
        l_0x1009_198b:
            ii(0x1009_198b, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_198f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1992, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_1995, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_1999, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_199b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_199d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_199f, 5); mov(memw_a32[ds, eax], 0x8);            /* mov word [eax], 0x8 */
            ii(0x1009_19a4, 5); jmpd(0x1009_1af3, 0x14a); goto l_0x1009_1af3; /* jmp 0x10091af3 */
        l_0x1009_19a9:
            ii(0x1009_19a9, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_19ad, 2); if(jzd(0x1009_19ca, 0x1b)) goto l_0x1009_19ca; /* jz 0x100919ca */
            ii(0x1009_19af, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_19b3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_19b6, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_19b9, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_19bd, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_19bf, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_19c1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_19c3, 5); mov(memw_a32[ds, eax], 0x8);            /* mov word [eax], 0x8 */
            ii(0x1009_19c8, 2); jmpd(0x1009_19ff, 0x35); goto l_0x1009_19ff; /* jmp 0x100919ff */
        l_0x1009_19ca:
            ii(0x1009_19ca, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_19ce, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_19d1, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_19d4, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_19d8, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_19da, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_19dc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_19de, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_19e1, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_19e4, 2); if(jged(0x1009_19ff, 0x19)) goto l_0x1009_19ff; /* jge 0x100919ff */
            ii(0x1009_19e6, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_19ea, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_19ed, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_19f0, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_19f4, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_19f6, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_19f8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_19fa, 5); mov(memw_a32[ds, eax], 0x3);            /* mov word [eax], 0x3 */
        l_0x1009_19ff:
            ii(0x1009_19ff, 5); jmpd(0x1009_1af3, 0xef); goto l_0x1009_1af3; /* jmp 0x10091af3 */
        l_0x1009_1a04:
            ii(0x1009_1a04, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_1a08, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1a0b, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_1a0e, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_1a12, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_1a14, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_1a16, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1a18, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_1a1b, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1009_1a1e, 2); jmpd(0x1009_1a77, 0x57); goto l_0x1009_1a77; /* jmp 0x10091a77 */
        l_0x1009_1a20:
            ii(0x1009_1a20, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_1a24, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1a27, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_1a2a, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_1a2e, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_1a30, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_1a32, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1a34, 5); mov(memw_a32[ds, eax], 0x2);            /* mov word [eax], 0x2 */
            ii(0x1009_1a39, 2); jmpd(0x1009_1a8f, 0x54); goto l_0x1009_1a8f; /* jmp 0x10091a8f */
        l_0x1009_1a3b:
            ii(0x1009_1a3b, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_1a3f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1a42, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_1a45, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_1a49, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_1a4b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_1a4d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1a4f, 5); mov(memw_a32[ds, eax], 0x3);            /* mov word [eax], 0x3 */
            ii(0x1009_1a54, 2); jmpd(0x1009_1a8f, 0x39); goto l_0x1009_1a8f; /* jmp 0x10091a8f */
        l_0x1009_1a56:
            ii(0x1009_1a56, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1009_1a5a, 2); if(jzd(0x1009_1a75, 0x19)) goto l_0x1009_1a75; /* jz 0x10091a75 */
            ii(0x1009_1a5c, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_1a60, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1a63, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_1a66, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_1a6a, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_1a6c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_1a6e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1a70, 5); mov(memw_a32[ds, eax], 0x9);            /* mov word [eax], 0x9 */
        l_0x1009_1a75:
            ii(0x1009_1a75, 2); jmpd(0x1009_1a8f, 0x18); goto l_0x1009_1a8f; /* jmp 0x10091a8f */
        l_0x1009_1a77:
            ii(0x1009_1a77, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1009_1a7a, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1009_1a7d, 5); cmp(memw_a32[ss, ebp - 0x5c], 0);       /* cmp word [ebp-0x5c], 0x0 */
            ii(0x1009_1a82, 2); if(jbed(0x1009_1a20, -0x64)) goto l_0x1009_1a20; /* jbe 0x10091a20 */
            ii(0x1009_1a84, 5); cmp(memw_a32[ss, ebp - 0x5c], 0x1);     /* cmp word [ebp-0x5c], 0x1 */
            ii(0x1009_1a89, 2); if(jzd(0x1009_1a3b, -0x50)) goto l_0x1009_1a3b; /* jz 0x10091a3b */
            ii(0x1009_1a8b, 2); jmpd(0x1009_1a56, -0x37); goto l_0x1009_1a56; /* jmp 0x10091a56 */
        //  ii(0x1009_1a8d, 2); Недостижимый код.
        l_0x1009_1a8f:
            ii(0x1009_1a8f, 5); jmpd(0x1009_1af3, 0x5f); goto l_0x1009_1af3; /* jmp 0x10091af3 */
        l_0x1009_1a94:
            ii(0x1009_1a94, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_1a98, 2); if(jzd(0x1009_1ab3, 0x19)) goto l_0x1009_1ab3; /* jz 0x10091ab3 */
            ii(0x1009_1a9a, 4); movsx(eax, memw_a32[ss, ebp - 0x50]);   /* movsx eax, word [ebp-0x50] */
            ii(0x1009_1a9e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_1aa1, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1009_1aa4, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1009_1aa8, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_1aaa, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_1aac, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1aae, 5); mov(memw_a32[ds, eax], 0x8);            /* mov word [eax], 0x8 */
        l_0x1009_1ab3:
            ii(0x1009_1ab3, 2); jmpd(0x1009_1af3, 0x3e); goto l_0x1009_1af3; /* jmp 0x10091af3 */
        l_0x1009_1ab5:
            ii(0x1009_1ab5, 2); jmpd(0x1009_1af3, 0x3c); goto l_0x1009_1af3; /* jmp 0x10091af3 */
        l_0x1009_1ab7:
            ii(0x1009_1ab7, 3); mov(al, memb_a32[ss, ebp - 0x54]);      /* mov al, [ebp-0x54] */
            ii(0x1009_1aba, 3); mov(memb_a32[ss, ebp - 0x60], al);      /* mov [ebp-0x60], al */
            ii(0x1009_1abd, 4); cmp(memb_a32[ss, ebp - 0x60], 0x2);     /* cmp byte [ebp-0x60], 0x2 */
            ii(0x1009_1ac1, 2); if(jbd(0x1009_1aeb, 0x28)) goto l_0x1009_1aeb; /* jb 0x10091aeb */
            ii(0x1009_1ac3, 4); cmp(memb_a32[ss, ebp - 0x60], 0x2);     /* cmp byte [ebp-0x60], 0x2 */
            ii(0x1009_1ac7, 6); if(jbed(0x1009_1a04, -0xc9)) goto l_0x1009_1a04; /* jbe 0x10091a04 */
            ii(0x1009_1acd, 4); cmp(memb_a32[ss, ebp - 0x60], 0x4);     /* cmp byte [ebp-0x60], 0x4 */
            ii(0x1009_1ad1, 2); if(jbd(0x1009_1ae9, 0x16)) goto l_0x1009_1ae9; /* jb 0x10091ae9 */
            ii(0x1009_1ad3, 4); cmp(memb_a32[ss, ebp - 0x60], 0x4);     /* cmp byte [ebp-0x60], 0x4 */
            ii(0x1009_1ad7, 6); if(jbed(0x1009_19a9, -0x134)) goto l_0x1009_19a9; /* jbe 0x100919a9 */
            ii(0x1009_1add, 4); cmp(memb_a32[ss, ebp - 0x60], 0x8);     /* cmp byte [ebp-0x60], 0x8 */
            ii(0x1009_1ae1, 6); if(jzd(0x1009_198b, -0x15c)) goto l_0x1009_198b; /* jz 0x1009198b */
            ii(0x1009_1ae7, 2); jmpd(0x1009_1ab5, -0x34); goto l_0x1009_1ab5; /* jmp 0x10091ab5 */
        l_0x1009_1ae9:
            ii(0x1009_1ae9, 2); jmpd(0x1009_1ab5, -0x36); goto l_0x1009_1ab5; /* jmp 0x10091ab5 */
        l_0x1009_1aeb:
            ii(0x1009_1aeb, 4); cmp(memb_a32[ss, ebp - 0x60], 0x1);     /* cmp byte [ebp-0x60], 0x1 */
            ii(0x1009_1aef, 2); if(jzd(0x1009_1a94, -0x5d)) goto l_0x1009_1a94; /* jz 0x10091a94 */
            ii(0x1009_1af1, 2); jmpd(0x1009_1ab5, -0x3e); goto l_0x1009_1ab5; /* jmp 0x10091ab5 */
        l_0x1009_1af3:
            ii(0x1009_1af3, 5); jmpd(0x1009_1965, -0x193); goto l_0x1009_1965; /* jmp 0x10091965 */
        l_0x1009_1af8:
            ii(0x1009_1af8, 5); jmpd(0x1009_1946, -0x1b7); goto l_0x1009_1946; /* jmp 0x10091946 */
        l_0x1009_1afd:
            ii(0x1009_1afd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_1b00, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_1b03, 5); calld(0x1007_6338, -0x1_b7d0);          /* call 0x10076338 */
            ii(0x1009_1b08, 3); lea(ebx, ebp - 0x64);                   /* lea ebx, [ebp-0x64] */
            ii(0x1009_1b0b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_1b0d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_1b0f, 5); calld(0x1007_64b8, -0x1_b65c);          /* call 0x100764b8 */
            ii(0x1009_1b14, 2); jmpd(0x1009_1b1e, 0x8); goto l_0x1009_1b1e; /* jmp 0x10091b1e */
        l_0x1009_1b16:
            ii(0x1009_1b16, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1b19, 5); calld(0x1007_6bf8, -0x1_af26);          /* call 0x10076bf8 */
        l_0x1009_1b1e:
            ii(0x1009_1b1e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1b20, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1b23, 5); calld(0x1013_ad71, 0xa_9249);           /* call 0x1013ad71 */
            ii(0x1009_1b28, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1b2a, 6); if(jzd(0x1009_1c6b, 0x13b)) goto l_0x1009_1c6b; /* jz 0x10091c6b */
            ii(0x1009_1b30, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1b33, 5); calld(0x1007_63a0, -0x1_b798);          /* call 0x100763a0 */
            ii(0x1009_1b38, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1009_1b3d, 6); if(jnzd(0x1009_1c2a, 0xe7)) goto l_0x1009_1c2a; /* jnz 0x10091c2a */
            ii(0x1009_1b43, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1009_1b47, 2); if(jzd(0x1009_1b7b, 0x32)) goto l_0x1009_1b7b; /* jz 0x10091b7b */
            ii(0x1009_1b49, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1b4c, 5); calld(0x1007_63a0, -0x1_b7b1);          /* call 0x100763a0 */
            ii(0x1009_1b51, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_1b54, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_1b57, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_1b5a, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1009_1b5d, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1b60, 5); calld(0x1007_63a0, -0x1_b7c5);          /* call 0x100763a0 */
            ii(0x1009_1b65, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_1b68, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1b6b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_1b6d, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_1b6f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1b71, 5); mov(memw_a32[ds, eax], 0x9);            /* mov word [eax], 0x9 */
            ii(0x1009_1b76, 5); jmpd(0x1009_1c2a, 0xaf); goto l_0x1009_1c2a; /* jmp 0x10091c2a */
        l_0x1009_1b7b:
            ii(0x1009_1b7b, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1b7e, 5); calld(0x1007_63a0, -0x1_b7e3);          /* call 0x100763a0 */
            ii(0x1009_1b83, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_1b86, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_1b89, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_1b8c, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1009_1b8f, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1b92, 5); calld(0x1007_63a0, -0x1_b7f7);          /* call 0x100763a0 */
            ii(0x1009_1b97, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_1b9a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1b9d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_1b9f, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_1ba1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1ba3, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_1ba6, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1009_1ba9, 2); jmpd(0x1009_1c0b, 0x60); goto l_0x1009_1c0b; /* jmp 0x10091c0b */
        l_0x1009_1bab:
            ii(0x1009_1bab, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1bae, 5); calld(0x1007_63a0, -0x1_b813);          /* call 0x100763a0 */
            ii(0x1009_1bb3, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_1bb6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_1bb9, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_1bbc, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1009_1bbf, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1bc2, 5); calld(0x1007_63a0, -0x1_b827);          /* call 0x100763a0 */
            ii(0x1009_1bc7, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_1bca, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1bcd, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_1bcf, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_1bd1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1bd3, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x1009_1bd8, 2); jmpd(0x1009_1c2a, 0x50); goto l_0x1009_1c2a; /* jmp 0x10091c2a */
        l_0x1009_1bda:
            ii(0x1009_1bda, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1bdd, 5); calld(0x1007_63a0, -0x1_b842);          /* call 0x100763a0 */
            ii(0x1009_1be2, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_1be5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_1be8, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_1beb, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1009_1bee, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1bf1, 5); calld(0x1007_63a0, -0x1_b856);          /* call 0x100763a0 */
            ii(0x1009_1bf6, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_1bf9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1bfc, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_1bfe, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_1c00, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1c02, 5); mov(memw_a32[ds, eax], 0x1);            /* mov word [eax], 0x1 */
            ii(0x1009_1c07, 2); jmpd(0x1009_1c2a, 0x21); goto l_0x1009_1c2a; /* jmp 0x10091c2a */
        l_0x1009_1c09:
            ii(0x1009_1c09, 2); jmpd(0x1009_1c2a, 0x1f); goto l_0x1009_1c2a; /* jmp 0x10091c2a */
        l_0x1009_1c0b:
            ii(0x1009_1c0b, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1009_1c0e, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x1009_1c11, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x2);     /* cmp word [ebp-0x6c], 0x2 */
            ii(0x1009_1c16, 2); if(jbd(0x1009_1c28, 0x10)) goto l_0x1009_1c28; /* jb 0x10091c28 */
            ii(0x1009_1c18, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x2);     /* cmp word [ebp-0x6c], 0x2 */
            ii(0x1009_1c1d, 2); if(jbed(0x1009_1bab, -0x74)) goto l_0x1009_1bab; /* jbe 0x10091bab */
            ii(0x1009_1c1f, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x3);     /* cmp word [ebp-0x6c], 0x3 */
            ii(0x1009_1c24, 2); if(jzd(0x1009_1bda, -0x4c)) goto l_0x1009_1bda; /* jz 0x10091bda */
            ii(0x1009_1c26, 2); jmpd(0x1009_1c09, -0x1f); goto l_0x1009_1c09; /* jmp 0x10091c09 */
        l_0x1009_1c28:
            ii(0x1009_1c28, 2); jmpd(0x1009_1c09, -0x21); goto l_0x1009_1c09; /* jmp 0x10091c09 */
        l_0x1009_1c2a:
            ii(0x1009_1c2a, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1c2d, 5); calld(0x1007_63a0, -0x1_b892);          /* call 0x100763a0 */
            ii(0x1009_1c32, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1009_1c37, 2); if(jnzd(0x1009_1c66, 0x2d)) goto l_0x1009_1c66; /* jnz 0x10091c66 */
            ii(0x1009_1c39, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1c3c, 5); calld(0x1007_63a0, -0x1_b8a1);          /* call 0x100763a0 */
            ii(0x1009_1c41, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_1c44, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_1c47, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_1c4a, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1009_1c4d, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1c50, 5); calld(0x1007_63a0, -0x1_b8b5);          /* call 0x100763a0 */
            ii(0x1009_1c55, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_1c58, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1c5b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_1c5d, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_1c5f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_1c61, 5); mov(memw_a32[ds, eax], 0x6);            /* mov word [eax], 0x6 */
        l_0x1009_1c66:
            ii(0x1009_1c66, 5); jmpd(0x1009_1b16, -0x155); goto l_0x1009_1b16; /* jmp 0x10091b16 */
        l_0x1009_1c6b:
            ii(0x1009_1c6b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1009_1c70, 5); calld(0x1007_6338, -0x1_b93d);          /* call 0x10076338 */
            ii(0x1009_1c75, 3); lea(ebx, ebp - 0x64);                   /* lea ebx, [ebp-0x64] */
            ii(0x1009_1c78, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_1c7a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_1c7c, 5); calld(0x1007_643c, -0x1_b845);          /* call 0x1007643c */
            ii(0x1009_1c81, 2); jmpd(0x1009_1c8b, 0x8); goto l_0x1009_1c8b; /* jmp 0x10091c8b */
        l_0x1009_1c83:
            ii(0x1009_1c83, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1c86, 5); calld(0x1007_6bf8, -0x1_b093);          /* call 0x10076bf8 */
        l_0x1009_1c8b:
            ii(0x1009_1c8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1c8d, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1c90, 5); calld(0x1013_ad71, 0xa_90dc);           /* call 0x1013ad71 */
            ii(0x1009_1c95, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1c97, 6); if(jzd(0x1009_1d69, 0xcc)) goto l_0x1009_1d69; /* jz 0x10091d69 */
            ii(0x1009_1c9d, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1ca0, 5); calld(0x1007_63a0, -0x1_b905);          /* call 0x100763a0 */
            ii(0x1009_1ca5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1ca7, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1009_1caa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_1cad, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_1cb0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_1cb3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_1cb5, 6); if(jnzd(0x1009_1d64, 0xa9)) goto l_0x1009_1d64; /* jnz 0x10091d64 */
            ii(0x1009_1cbb, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1cbe, 5); calld(0x1007_63a0, -0x1_b923);          /* call 0x100763a0 */
            ii(0x1009_1cc3, 5); cmp(memw_a32[ds, eax + 0x8], 0x3);      /* cmp word [eax+0x8], 0x3 */
            ii(0x1009_1cc8, 2); if(jzd(0x1009_1cd9, 0xf)) goto l_0x1009_1cd9; /* jz 0x10091cd9 */
            ii(0x1009_1cca, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1ccd, 5); calld(0x1007_63a0, -0x1_b932);          /* call 0x100763a0 */
            ii(0x1009_1cd2, 5); cmp(memw_a32[ds, eax + 0x8], 0x9);      /* cmp word [eax+0x8], 0x9 */
            ii(0x1009_1cd7, 2); if(jnzd(0x1009_1cdb, 0x2)) goto l_0x1009_1cdb; /* jnz 0x10091cdb */
        l_0x1009_1cd9:
            ii(0x1009_1cd9, 2); jmpd(0x1009_1cea, 0xf); goto l_0x1009_1cea; /* jmp 0x10091cea */
        l_0x1009_1cdb:
            ii(0x1009_1cdb, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1cde, 5); calld(0x1007_63a0, -0x1_b943);          /* call 0x100763a0 */
            ii(0x1009_1ce3, 5); cmp(memw_a32[ds, eax + 0x8], 0xb);      /* cmp word [eax+0x8], 0xb */
            ii(0x1009_1ce8, 2); if(jnzd(0x1009_1cec, 0x2)) goto l_0x1009_1cec; /* jnz 0x10091cec */
        l_0x1009_1cea:
            ii(0x1009_1cea, 2); jmpd(0x1009_1cfb, 0xf); goto l_0x1009_1cfb; /* jmp 0x10091cfb */
        l_0x1009_1cec:
            ii(0x1009_1cec, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1cef, 5); calld(0x1007_63a0, -0x1_b954);          /* call 0x100763a0 */
            ii(0x1009_1cf4, 5); cmp(memw_a32[ds, eax + 0x8], 0x20);     /* cmp word [eax+0x8], 0x20 */
            ii(0x1009_1cf9, 2); if(jnzd(0x1009_1cfd, 0x2)) goto l_0x1009_1cfd; /* jnz 0x10091cfd */
        l_0x1009_1cfb:
            ii(0x1009_1cfb, 2); jmpd(0x1009_1d0c, 0xf); goto l_0x1009_1d0c; /* jmp 0x10091d0c */
        l_0x1009_1cfd:
            ii(0x1009_1cfd, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1d00, 5); calld(0x1007_63a0, -0x1_b965);          /* call 0x100763a0 */
            ii(0x1009_1d05, 5); cmp(memw_a32[ds, eax + 0x8], 0x18);     /* cmp word [eax+0x8], 0x18 */
            ii(0x1009_1d0a, 2); if(jnzd(0x1009_1d0e, 0x2)) goto l_0x1009_1d0e; /* jnz 0x10091d0e */
        l_0x1009_1d0c:
            ii(0x1009_1d0c, 2); jmpd(0x1009_1d1d, 0xf); goto l_0x1009_1d1d; /* jmp 0x10091d1d */
        l_0x1009_1d0e:
            ii(0x1009_1d0e, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1d11, 5); calld(0x1007_63a0, -0x1_b976);          /* call 0x100763a0 */
            ii(0x1009_1d16, 5); cmp(memw_a32[ds, eax + 0x8], 0x19);     /* cmp word [eax+0x8], 0x19 */
            ii(0x1009_1d1b, 2); if(jnzd(0x1009_1d1f, 0x2)) goto l_0x1009_1d1f; /* jnz 0x10091d1f */
        l_0x1009_1d1d:
            ii(0x1009_1d1d, 2); jmpd(0x1009_1d2e, 0xf); goto l_0x1009_1d2e; /* jmp 0x10091d2e */
        l_0x1009_1d1f:
            ii(0x1009_1d1f, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1d22, 5); calld(0x1007_63a0, -0x1_b987);          /* call 0x100763a0 */
            ii(0x1009_1d27, 5); cmp(memw_a32[ds, eax + 0x8], 0x17);     /* cmp word [eax+0x8], 0x17 */
            ii(0x1009_1d2c, 2); if(jnzd(0x1009_1d64, 0x36)) goto l_0x1009_1d64; /* jnz 0x10091d64 */
        l_0x1009_1d2e:
            ii(0x1009_1d2e, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1009_1d31, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1d34, 5); calld(0x1007_63a0, -0x1_b999);          /* call 0x100763a0 */
            ii(0x1009_1d39, 5); calld(0x1015_2532, 0xc_07f4);           /* call 0x10152532 */
            ii(0x1009_1d3e, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_1d42, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1d43, 3); lea(edi, ebp - 0x7c);                   /* lea edi, [ebp-0x7c] */
            ii(0x1009_1d46, 3); lea(esi, ebp - 0x38);                   /* lea esi, [ebp-0x38] */
            ii(0x1009_1d49, 1); movsd_a32();                            /* movsd */
            ii(0x1009_1d4a, 1); movsd_a32();                            /* movsd */
            ii(0x1009_1d4b, 1); movsd_a32();                            /* movsd */
            ii(0x1009_1d4c, 1); movsd_a32();                            /* movsd */
            ii(0x1009_1d4d, 3); pushd(memd_a32[ss, ebp - 0x70]);        /* push dword [ebp-0x70] */
            ii(0x1009_1d50, 3); pushd(memd_a32[ss, ebp - 0x74]);        /* push dword [ebp-0x74] */
            ii(0x1009_1d53, 3); pushd(memd_a32[ss, ebp - 0x78]);        /* push dword [ebp-0x78] */
            ii(0x1009_1d56, 3); pushd(memd_a32[ss, ebp - 0x7c]);        /* push dword [ebp-0x7c] */
            ii(0x1009_1d59, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_1d5c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_1d5f, 5); calld(0x1009_15ce, -0x796);             /* call 0x100915ce */
        l_0x1009_1d64:
            ii(0x1009_1d64, 5); jmpd(0x1009_1c83, -0xe6); goto l_0x1009_1c83; /* jmp 0x10091c83 */
        l_0x1009_1d69:
            ii(0x1009_1d69, 2); jmpd(0x1009_1d73, 0x8); goto l_0x1009_1d73; /* jmp 0x10091d73 */
        l_0x1009_1d6b:
            ii(0x1009_1d6b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1d6e, 5); calld(0x1007_6bf8, -0x1_b17b);          /* call 0x10076bf8 */
        l_0x1009_1d73:
            ii(0x1009_1d73, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1d75, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1d78, 5); calld(0x1013_ad71, 0xa_8ff4);           /* call 0x1013ad71 */
            ii(0x1009_1d7d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1d7f, 6); if(jzd(0x1009_1e3e, 0xb9)) goto l_0x1009_1e3e; /* jz 0x10091e3e */
            ii(0x1009_1d85, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1d88, 5); calld(0x1009_c52c, 0xa79f);             /* call 0x1009c52c */
            ii(0x1009_1d8d, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1009_1d90, 6); if(jzd(0x1009_1e39, 0xa3)) goto l_0x1009_1e39; /* jz 0x10091e39 */
            ii(0x1009_1d96, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1d99, 5); calld(0x1009_c4f8, 0xa75a);             /* call 0x1009c4f8 */
            ii(0x1009_1d9e, 5); calld(0x1009_c4c4, 0xa721);             /* call 0x1009c4c4 */
            ii(0x1009_1da3, 4); cmp(ax, 0xc);                           /* cmp ax, 0xc */
            ii(0x1009_1da7, 2); if(jzd(0x1009_1dbc, 0x13)) goto l_0x1009_1dbc; /* jz 0x10091dbc */
            ii(0x1009_1da9, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1dac, 5); calld(0x1009_c4f8, 0xa747);             /* call 0x1009c4f8 */
            ii(0x1009_1db1, 5); calld(0x1009_c4c4, 0xa70e);             /* call 0x1009c4c4 */
            ii(0x1009_1db6, 4); cmp(ax, 0x27);                          /* cmp ax, 0x27 */
            ii(0x1009_1dba, 2); if(jnzd(0x1009_1dbe, 0x2)) goto l_0x1009_1dbe; /* jnz 0x10091dbe */
        l_0x1009_1dbc:
            ii(0x1009_1dbc, 2); jmpd(0x1009_1dd1, 0x13); goto l_0x1009_1dd1; /* jmp 0x10091dd1 */
        l_0x1009_1dbe:
            ii(0x1009_1dbe, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1dc1, 5); calld(0x1009_c4f8, 0xa732);             /* call 0x1009c4f8 */
            ii(0x1009_1dc6, 5); calld(0x1009_c4c4, 0xa6f9);             /* call 0x1009c4c4 */
            ii(0x1009_1dcb, 4); cmp(ax, 0x21);                          /* cmp ax, 0x21 */
            ii(0x1009_1dcf, 2); if(jnzd(0x1009_1dd3, 0x2)) goto l_0x1009_1dd3; /* jnz 0x10091dd3 */
        l_0x1009_1dd1:
            ii(0x1009_1dd1, 2); jmpd(0x1009_1dee, 0x1b); goto l_0x1009_1dee; /* jmp 0x10091dee */
        l_0x1009_1dd3:
            ii(0x1009_1dd3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1dd6, 5); calld(0x1009_c4f8, 0xa71d);             /* call 0x1009c4f8 */
            ii(0x1009_1ddb, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x1009_1dde, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x1009_1de1, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_1de4, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x1009_1de7, 3); calld_abs(memd_a32[ds, edx + 0x74]);    /* call dword [edx+0x74] */
            ii(0x1009_1dea, 2); test(al, al);                           /* test al, al */
            ii(0x1009_1dec, 2); if(jnzd(0x1009_1df0, 0x2)) goto l_0x1009_1df0; /* jnz 0x10091df0 */
        l_0x1009_1dee:
            ii(0x1009_1dee, 2); jmpd(0x1009_1e39, 0x49); goto l_0x1009_1e39; /* jmp 0x10091e39 */
        l_0x1009_1df0:
            ii(0x1009_1df0, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1df3, 5); calld(0x1009_c4f8, 0xa700);             /* call 0x1009c4f8 */
            ii(0x1009_1df8, 6); mov(memd_a32[ss, ebp - 0x84], eax);     /* mov [ebp-0x84], eax */
            ii(0x1009_1dfe, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x1009_1e04, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_1e07, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1009_1e0a, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x1009_1e10, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1009_1e13, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1009_1e17, 1); pushd(eax);                             /* push eax */
            ii(0x1009_1e18, 3); lea(edi, ebp - 0x7c);                   /* lea edi, [ebp-0x7c] */
            ii(0x1009_1e1b, 3); lea(esi, ebp - 0x38);                   /* lea esi, [ebp-0x38] */
            ii(0x1009_1e1e, 1); movsd_a32();                            /* movsd */
            ii(0x1009_1e1f, 1); movsd_a32();                            /* movsd */
            ii(0x1009_1e20, 1); movsd_a32();                            /* movsd */
            ii(0x1009_1e21, 1); movsd_a32();                            /* movsd */
            ii(0x1009_1e22, 3); pushd(memd_a32[ss, ebp - 0x70]);        /* push dword [ebp-0x70] */
            ii(0x1009_1e25, 3); pushd(memd_a32[ss, ebp - 0x74]);        /* push dword [ebp-0x74] */
            ii(0x1009_1e28, 3); pushd(memd_a32[ss, ebp - 0x78]);        /* push dword [ebp-0x78] */
            ii(0x1009_1e2b, 3); pushd(memd_a32[ss, ebp - 0x7c]);        /* push dword [ebp-0x7c] */
            ii(0x1009_1e2e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_1e31, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_1e34, 5); calld(0x1009_15ce, -0x86b);             /* call 0x100915ce */
        l_0x1009_1e39:
            ii(0x1009_1e39, 5); jmpd(0x1009_1d6b, -0xd3); goto l_0x1009_1d6b; /* jmp 0x10091d6b */
        l_0x1009_1e3e:
            ii(0x1009_1e3e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1e40, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1009_1e43, 5); calld(0x1007_5f6c, -0x1_bedc);          /* call 0x10075f6c */
            ii(0x1009_1e48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_1e4a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_1e4d, 5); calld(0x1009_ba6c, 0x9c1a);             /* call 0x1009ba6c */
            ii(0x1009_1e52, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_1e54, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_1e55, 1); popd(edi);                              /* pop edi */
            ii(0x1009_1e56, 1); popd(esi);                              /* pop esi */
            ii(0x1009_1e57, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
