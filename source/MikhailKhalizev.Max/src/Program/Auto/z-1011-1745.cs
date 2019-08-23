using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_1745-e1aa4479")]
        public void Method_1011_1745()
        {
            ii(0x1011_1745, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1011_174a, 5); calld(Definitions.sys_check_available_stack_size, 0x5_4603); /* call 0x10165d52 */
            ii(0x1011_174f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_1750, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_1751, 1); pushd(edx);                             /* push edx */
            ii(0x1011_1752, 1); pushd(esi);                             /* push esi */
            ii(0x1011_1753, 1); pushd(edi);                             /* push edi */
            ii(0x1011_1754, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_1755, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_1757, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1011_175d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_175f, 5); calld(0x100e_883d, -0x2_8f27);          /* call 0x100e883d */
            ii(0x1011_1764, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_1767, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1011_176e:
            ii(0x1011_176e, 4); cmp(memd_a32[ss, ebp - 0x4], 0x1b);     /* cmp dword [ebp-0x4], 0x1b */
            ii(0x1011_1772, 2); if(jzd(0x1011_177d, 0x9)) goto l_0x1011_177d; /* jz 0x1011177d */
            ii(0x1011_1774, 7); cmp(memd_a32[ss, ebp - 0x4], 0x2328);   /* cmp dword [ebp-0x4], 0x2328 */
            ii(0x1011_177b, 2); if(jnzd(0x1011_1782, 0x5)) goto l_0x1011_1782; /* jnz 0x10111782 */
        l_0x1011_177d:
            ii(0x1011_177d, 5); jmpd(0x1011_1ada, 0x358); goto l_0x1011_1ada; /* jmp 0x10111ada */
        l_0x1011_1782:
            ii(0x1011_1782, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1011_1786, 5); calld(/* sys */ 0x1016_be34, 0x5_a6a9); /* call 0x1016be34 */
            ii(0x1011_178b, 5); calld(0x100d_533c, -0x3_c454);          /* call 0x100d533c */
            ii(0x1011_1790, 1); cwde();                                 /* cwde */
            ii(0x1011_1791, 1); pushd(eax);                             /* push eax */
            ii(0x1011_1792, 5); calld(0x100d_5360, -0x3_c437);          /* call 0x100d5360 */
            ii(0x1011_1797, 1); cwde();                                 /* cwde */
            ii(0x1011_1798, 1); pushd(eax);                             /* push eax */
            ii(0x1011_1799, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_179b, 1); pushd(eax);                             /* push eax */
            ii(0x1011_179c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_179e, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1011_17a3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_17a6, 5); mov(eax, 0x6c0);                        /* mov eax, 0x6c0 */
            ii(0x1011_17ab, 5); calld(0x100e_8c51, -0x2_8b5f);          /* call 0x100e8c51 */
            ii(0x1011_17b0, 5); mov(edx, StringDefinitions.NewGameMenu); /* mov edx, 0x101a46cd */
            ii(0x1011_17b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_17b8, 5); calld(0x1010_c628, -0x5195);            /* call 0x1010c628 */
            ii(0x1011_17bd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_17bf, 6); mov(edx, memd_a32[ds, 0x101c_4e4c]);    /* mov edx, [0x101c4e4c] */
            ii(0x1011_17c5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_17c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_17cb, 5); calld(0x1010_c693, -0x513d);            /* call 0x1010c693 */
            ii(0x1011_17d0, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1011_17d5, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1011_17da, 5); mov(eax, 0x101b_90b4);                  /* mov eax, 0x101b90b4 */
            ii(0x1011_17df, 5); calld(0x1010_9cee, -0x7af6);            /* call 0x10109cee */
            ii(0x1011_17e4, 5); calld(/* sys */ 0x1016_bcc4, 0x5_a4db); /* call 0x1016bcc4 */
            ii(0x1011_17e9, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1011_17ed, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x1011_17f1:
            ii(0x1011_17f1, 5); calld(/* sys */ 0x1016_b208, 0x5_9a12); /* call 0x1016b208 */
            ii(0x1011_17f6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_17f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_17fc, 5); calld(Definitions.sys_tolower, 0x6_1294); /* call 0x10172a95 */
            ii(0x1011_1801, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_1804, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1011_1808, 2); if(jled(0x1011_1813, 0x9)) goto l_0x1011_1813; /* jle 0x10111813 */
            ii(0x1011_180a, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x1011_1811, 2); if(jld(0x1011_1815, 0x2)) goto l_0x1011_1815; /* jl 0x10111815 */
        l_0x1011_1813:
            ii(0x1011_1813, 2); jmpd(0x1011_1819, 0x4); goto l_0x1011_1819; /* jmp 0x10111819 */
        l_0x1011_1815:
            ii(0x1011_1815, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1011_1819:
            ii(0x1011_1819, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_181c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_181f, 5); jmpd(0x1011_1a02, 0x1de); goto l_0x1011_1a02; /* jmp 0x10111a02 */
        l_0x1011_1824:
            ii(0x1011_1824, 5); calld(0x1010_9b8a, -0x7c9f);            /* call 0x10109b8a */
            ii(0x1011_1829, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_182b, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_1830, 5); calld(0x100c_aafc, -0x4_6d39);          /* call 0x100caafc */
            ii(0x1011_1835, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_183a, 5); calld(0x1010_e7df, -0x3060);            /* call 0x1010e7df */
            ii(0x1011_183f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1841, 2); if(jzd(0x1011_184a, 0x7)) goto l_0x1011_184a; /* jz 0x1011184a */
            ii(0x1011_1843, 7); mov(memd_a32[ss, ebp - 0x4], 0x2328);   /* mov dword [ebp-0x4], 0x2328 */
        l_0x1011_184a:
            ii(0x1011_184a, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1011_184e, 5); jmpd(0x1011_1acb, 0x278); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_1853:
            ii(0x1011_1853, 5); calld(0x1010_9b8a, -0x7cce);            /* call 0x10109b8a */
            ii(0x1011_1858, 5); calld(0x1011_5358, 0x3afb);             /* call 0x10115358 */
            ii(0x1011_185d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_185f, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_1861, 5); calld(0x1011_5378, 0x3b12);             /* call 0x10115378 */
            ii(0x1011_1866, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_1868, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_186a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_186f, 5); calld(0x1011_1386, -0x4ee);             /* call 0x10111386 */
            ii(0x1011_1874, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1876, 2); if(jzd(0x1011_187f, 0x7)) goto l_0x1011_187f; /* jz 0x1011187f */
            ii(0x1011_1878, 7); mov(memd_a32[ss, ebp - 0x4], 0x2328);   /* mov dword [ebp-0x4], 0x2328 */
        l_0x1011_187f:
            ii(0x1011_187f, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1011_1883, 5); jmpd(0x1011_1acb, 0x243); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_1888:
            ii(0x1011_1888, 5); calld(0x1010_9b8a, -0x7d03);            /* call 0x10109b8a */
            ii(0x1011_188d, 5); calld(0x1011_5358, 0x3ac6);             /* call 0x10115358 */
            ii(0x1011_1892, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_1894, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_1896, 5); calld(0x1011_5378, 0x3add);             /* call 0x10115378 */
            ii(0x1011_189b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_189d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_189f, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1011_18a4, 5); calld(0x1011_1386, -0x523);             /* call 0x10111386 */
            ii(0x1011_18a9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_18ab, 2); if(jzd(0x1011_18b4, 0x7)) goto l_0x1011_18b4; /* jz 0x101118b4 */
            ii(0x1011_18ad, 7); mov(memd_a32[ss, ebp - 0x4], 0x2328);   /* mov dword [ebp-0x4], 0x2328 */
        l_0x1011_18b4:
            ii(0x1011_18b4, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1011_18b8, 5); jmpd(0x1011_1acb, 0x20e); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_18bd:
            ii(0x1011_18bd, 5); calld(0x1010_9b8a, -0x7d38);            /* call 0x10109b8a */
            ii(0x1011_18c2, 5); calld(0x1011_5358, 0x3a91);             /* call 0x10115358 */
            ii(0x1011_18c7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_18c9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_18cb, 5); calld(0x1011_5378, 0x3aa8);             /* call 0x10115378 */
            ii(0x1011_18d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_18d2, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_18d4, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1011_18d9, 5); calld(0x1011_1386, -0x558);             /* call 0x10111386 */
            ii(0x1011_18de, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_18e0, 2); if(jzd(0x1011_18e9, 0x7)) goto l_0x1011_18e9; /* jz 0x101118e9 */
            ii(0x1011_18e2, 7); mov(memd_a32[ss, ebp - 0x4], 0x2328);   /* mov dword [ebp-0x4], 0x2328 */
        l_0x1011_18e9:
            ii(0x1011_18e9, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1011_18ed, 5); jmpd(0x1011_1acb, 0x1d9); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_18f2:
            ii(0x1011_18f2, 5); calld(0x1010_9b8a, -0x7d6d);            /* call 0x10109b8a */
            ii(0x1011_18f7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_18f9, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_18fe, 5); calld(0x100c_aafc, -0x4_6e07);          /* call 0x100caafc */
            ii(0x1011_1903, 5); calld(0x1011_5358, 0x3a50);             /* call 0x10115358 */
            ii(0x1011_1908, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_190a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_190c, 5); calld(0x1011_5378, 0x3a67);             /* call 0x10115378 */
            ii(0x1011_1911, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_1913, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_1915, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1011_191a, 5); calld(0x1011_1386, -0x599);             /* call 0x10111386 */
            ii(0x1011_191f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1921, 2); if(jzd(0x1011_192a, 0x7)) goto l_0x1011_192a; /* jz 0x1011192a */
            ii(0x1011_1923, 7); mov(memd_a32[ss, ebp - 0x4], 0x2328);   /* mov dword [ebp-0x4], 0x2328 */
        l_0x1011_192a:
            ii(0x1011_192a, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1011_192e, 5); jmpd(0x1011_1acb, 0x198); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_1933:
            ii(0x1011_1933, 4); xor(memb_a32[ss, ebp - 0x10], 0x1);     /* xor byte [ebp-0x10], 0x1 */
            ii(0x1011_1937, 5); mov(eax, memd_a32[ds, 0x101b_9113]);    /* mov eax, [0x101b9113] */
            ii(0x1011_193c, 5); calld(0x100c_fbbe, -0x4_1d83);          /* call 0x100cfbbe */
            ii(0x1011_1941, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1011_1945, 2); if(jzd(0x1011_1951, 0xa)) goto l_0x1011_1951; /* jz 0x10111951 */
            ii(0x1011_1947, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_194a, 5); calld(0x1010_9804, -0x814b);            /* call 0x10109804 */
            ii(0x1011_194f, 2); jmpd(0x1011_195a, 0x9); goto l_0x1011_195a; /* jmp 0x1011195a */
        l_0x1011_1951:
            ii(0x1011_1951, 5); calld(0x1010_9b8a, -0x7dcc);            /* call 0x10109b8a */
            ii(0x1011_1956, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
        l_0x1011_195a:
            ii(0x1011_195a, 5); jmpd(0x1011_1acb, 0x16c); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_195f:
            ii(0x1011_195f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_1962, 5); calld(0x1010_9a84, -0x7ee3);            /* call 0x10109a84 */
            ii(0x1011_1967, 5); jmpd(0x1011_1acb, 0x15f); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_196c:
            ii(0x1011_196c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_196f, 5); calld(0x1010_9b05, -0x7e6f);            /* call 0x10109b05 */
            ii(0x1011_1974, 5); jmpd(0x1011_1acb, 0x152); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_1979:
            ii(0x1011_1979, 5); calld(0x1010_9b8a, -0x7df4);            /* call 0x10109b8a */
            ii(0x1011_197e, 7); mov(memd_a32[ss, ebp - 0x4], 0x1b);     /* mov dword [ebp-0x4], 0x1b */
            ii(0x1011_1985, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x1011_1989, 5); jmpd(0x1011_1acb, 0x13d); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_198e:
            ii(0x1011_198e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1990, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1011_1993, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1995, 2); if(jnzd(0x1011_19a9, 0x12)) goto l_0x1011_19a9; /* jnz 0x101119a9 */
            ii(0x1011_1997, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_199c, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1011_19a1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_19a4, 5); calld(0x1010_c693, -0x5316);            /* call 0x1010c693 */
        l_0x1011_19a9:
            ii(0x1011_19a9, 5); jmpd(0x1011_1acb, 0x11d); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_19ae:
            ii(0x1011_19ae, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x1011_19b5, 2); if(jld(0x1011_19bd, 0x6)) goto l_0x1011_19bd; /* jl 0x101119bd */
            ii(0x1011_19b7, 4); cmp(memb_a32[ss, ebp - 0x14], 0);       /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1011_19bb, 2); if(jzd(0x1011_19bf, 0x2)) goto l_0x1011_19bf; /* jz 0x101119bf */
        l_0x1011_19bd:
            ii(0x1011_19bd, 2); jmpd(0x1011_19fd, 0x3e); goto l_0x1011_19fd; /* jmp 0x101119fd */
        l_0x1011_19bf:
            ii(0x1011_19bf, 7); add(memd_a32[ss, ebp - 0x4], 0xffff_9000); /* add dword [ebp-0x4], 0xffff9000 */
            ii(0x1011_19c6, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3e8);    /* cmp dword [ebp-0x4], 0x3e8 */
            ii(0x1011_19cd, 2); if(jzd(0x1011_19d8, 0x9)) goto l_0x1011_19d8; /* jz 0x101119d8 */
            ii(0x1011_19cf, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3e9);    /* cmp dword [ebp-0x4], 0x3e9 */
            ii(0x1011_19d6, 2); if(jnzd(0x1011_19e4, 0xc)) goto l_0x1011_19e4; /* jnz 0x101119e4 */
        l_0x1011_19d8:
            ii(0x1011_19d8, 5); mov(eax, memd_a32[ds, 0x101c_4de0]);    /* mov eax, [0x101c4de0] */
            ii(0x1011_19dd, 5); calld(0x100c_fbbe, -0x4_1e24);          /* call 0x100cfbbe */
            ii(0x1011_19e2, 2); jmpd(0x1011_19f9, 0x15); goto l_0x1011_19f9; /* jmp 0x101119f9 */
        l_0x1011_19e4:
            ii(0x1011_19e4, 4); cmp(memd_a32[ss, ebp - 0x4], 0x8);      /* cmp dword [ebp-0x4], 0x8 */
            ii(0x1011_19e8, 2); if(jaed(0x1011_19f9, 0xf)) goto l_0x1011_19f9; /* jae 0x101119f9 */
            ii(0x1011_19ea, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x13); /* imul eax, [ebp-0x4], 0x13 */
            ii(0x1011_19ee, 6); mov(eax, memd_a32[ds, eax + 0x101b_90b4]); /* mov eax, [eax+0x101b90b4] */
            ii(0x1011_19f4, 5); calld(0x100c_fbbe, -0x4_1e3b);          /* call 0x100cfbbe */
        l_0x1011_19f9:
            ii(0x1011_19f9, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
        l_0x1011_19fd:
            ii(0x1011_19fd, 5); jmpd(0x1011_1acb, 0xc9); goto l_0x1011_1acb; /* jmp 0x10111acb */
        l_0x1011_1a02:
            ii(0x1011_1a02, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x53);    /* cmp dword [ebp-0x1c], 0x53 */
            ii(0x1011_1a06, 2); if(jbd(0x1011_1a73, 0x6b)) goto l_0x1011_1a73; /* jb 0x10111a73 */
            ii(0x1011_1a08, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x53);    /* cmp dword [ebp-0x1c], 0x53 */
            ii(0x1011_1a0c, 6); if(jbed(0x1011_1888, -0x18a)) goto l_0x1011_1888; /* jbe 0x10111888 */
            ii(0x1011_1a12, 7); cmp(memd_a32[ss, ebp - 0x1c], 0x148);   /* cmp dword [ebp-0x1c], 0x148 */
            ii(0x1011_1a19, 2); if(jbd(0x1011_1a55, 0x3a)) goto l_0x1011_1a55; /* jb 0x10111a55 */
            ii(0x1011_1a1b, 7); cmp(memd_a32[ss, ebp - 0x1c], 0x148);   /* cmp dword [ebp-0x1c], 0x148 */
            ii(0x1011_1a22, 6); if(jbed(0x1011_198e, -0x9a)) goto l_0x1011_198e; /* jbe 0x1011198e */
            ii(0x1011_1a28, 7); cmp(memd_a32[ss, ebp - 0x1c], 0x3e8);   /* cmp dword [ebp-0x1c], 0x3e8 */
            ii(0x1011_1a2f, 2); if(jbd(0x1011_1a50, 0x1f)) goto l_0x1011_1a50; /* jb 0x10111a50 */
            ii(0x1011_1a31, 7); cmp(memd_a32[ss, ebp - 0x1c], 0x3e8);   /* cmp dword [ebp-0x1c], 0x3e8 */
            ii(0x1011_1a38, 6); if(jbed(0x1011_195f, -0xdf)) goto l_0x1011_195f; /* jbe 0x1011195f */
            ii(0x1011_1a3e, 7); cmp(memd_a32[ss, ebp - 0x1c], 0x3e9);   /* cmp dword [ebp-0x1c], 0x3e9 */
            ii(0x1011_1a45, 6); if(jzd(0x1011_196c, -0xdf)) goto l_0x1011_196c; /* jz 0x1011196c */
            ii(0x1011_1a4b, 5); jmpd(0x1011_19ae, -0xa2); goto l_0x1011_19ae; /* jmp 0x101119ae */
        l_0x1011_1a50:
            ii(0x1011_1a50, 5); jmpd(0x1011_19ae, -0xa7); goto l_0x1011_19ae; /* jmp 0x101119ae */
        l_0x1011_1a55:
            ii(0x1011_1a55, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x54);    /* cmp dword [ebp-0x1c], 0x54 */
            ii(0x1011_1a59, 6); if(jbed(0x1011_1853, -0x20c)) goto l_0x1011_1853; /* jbe 0x10111853 */
            ii(0x1011_1a5f, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x55);    /* cmp dword [ebp-0x1c], 0x55 */
            ii(0x1011_1a63, 6); if(jzd(0x1011_1824, -0x245)) goto l_0x1011_1824; /* jz 0x10111824 */
            ii(0x1011_1a69, 5); jmpd(0x1011_19ae, -0xc0); goto l_0x1011_19ae; /* jmp 0x101119ae */
        //  ii(0x1011_1a6e, 5); jmpd(0x1011_19ae, -0xc5); goto l_0x1011_19ae; /* jmp 0x101119ae */
        l_0x1011_1a73:
            ii(0x1011_1a73, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x43);    /* cmp dword [ebp-0x1c], 0x43 */
            ii(0x1011_1a77, 2); if(jbd(0x1011_1aa7, 0x2e)) goto l_0x1011_1aa7; /* jb 0x10111aa7 */
            ii(0x1011_1a79, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x43);    /* cmp dword [ebp-0x1c], 0x43 */
            ii(0x1011_1a7d, 6); if(jbed(0x1011_1979, -0x10a)) goto l_0x1011_1979; /* jbe 0x10111979 */
            ii(0x1011_1a83, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x49);    /* cmp dword [ebp-0x1c], 0x49 */
            ii(0x1011_1a87, 2); if(jbd(0x1011_1aa2, 0x19)) goto l_0x1011_1aa2; /* jb 0x10111aa2 */
            ii(0x1011_1a89, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x49);    /* cmp dword [ebp-0x1c], 0x49 */
            ii(0x1011_1a8d, 6); if(jbed(0x1011_1933, -0x160)) goto l_0x1011_1933; /* jbe 0x10111933 */
            ii(0x1011_1a93, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x4d);    /* cmp dword [ebp-0x1c], 0x4d */
            ii(0x1011_1a97, 6); if(jzd(0x1011_18f2, -0x1ab)) goto l_0x1011_18f2; /* jz 0x101118f2 */
            ii(0x1011_1a9d, 5); jmpd(0x1011_19ae, -0xf4); goto l_0x1011_19ae; /* jmp 0x101119ae */
        l_0x1011_1aa2:
            ii(0x1011_1aa2, 5); jmpd(0x1011_19ae, -0xf9); goto l_0x1011_19ae; /* jmp 0x101119ae */
        l_0x1011_1aa7:
            ii(0x1011_1aa7, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x1b);    /* cmp dword [ebp-0x1c], 0x1b */
            ii(0x1011_1aab, 2); if(jbd(0x1011_1ac6, 0x19)) goto l_0x1011_1ac6; /* jb 0x10111ac6 */
            ii(0x1011_1aad, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x1b);    /* cmp dword [ebp-0x1c], 0x1b */
            ii(0x1011_1ab1, 6); if(jbed(0x1011_1979, -0x13e)) goto l_0x1011_1979; /* jbe 0x10111979 */
            ii(0x1011_1ab7, 4); cmp(memd_a32[ss, ebp - 0x1c], 0x41);    /* cmp dword [ebp-0x1c], 0x41 */
            ii(0x1011_1abb, 6); if(jzd(0x1011_18bd, -0x204)) goto l_0x1011_18bd; /* jz 0x101118bd */
            ii(0x1011_1ac1, 5); jmpd(0x1011_19ae, -0x118); goto l_0x1011_19ae; /* jmp 0x101119ae */
        l_0x1011_1ac6:
            ii(0x1011_1ac6, 5); jmpd(0x1011_19ae, -0x11d); goto l_0x1011_19ae; /* jmp 0x101119ae */
        l_0x1011_1acb:
            ii(0x1011_1acb, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1011_1acf, 6); if(jzd(0x1011_17f1, -0x2e4)) goto l_0x1011_17f1; /* jz 0x101117f1 */
            ii(0x1011_1ad5, 5); jmpd(0x1011_176e, -0x36c); goto l_0x1011_176e; /* jmp 0x1011176e */
        l_0x1011_1ada:
            ii(0x1011_1ada, 7); cmp(memd_a32[ss, ebp - 0x4], 0x2328);   /* cmp dword [ebp-0x4], 0x2328 */
            ii(0x1011_1ae1, 2); if(jnzd(0x1011_1aec, 0x9)) goto l_0x1011_1aec; /* jnz 0x10111aec */
            ii(0x1011_1ae3, 7); mov(memd_a32[ss, ebp - 0x20], 0x1);     /* mov dword [ebp-0x20], 0x1 */
            ii(0x1011_1aea, 2); jmpd(0x1011_1af3, 0x7); goto l_0x1011_1af3; /* jmp 0x10111af3 */
        l_0x1011_1aec:
            ii(0x1011_1aec, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
        l_0x1011_1af3:
            ii(0x1011_1af3, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1011_1af6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_1af9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_1afc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_1afe, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_1aff, 1); popd(edi);                              /* pop edi */
            ii(0x1011_1b00, 1); popd(esi);                              /* pop esi */
            ii(0x1011_1b01, 1); popd(edx);                              /* pop edx */
            ii(0x1011_1b02, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_1b03, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_1b04, 1); retd();                                 /* ret */
        }
    }
}
