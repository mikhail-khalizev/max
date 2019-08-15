using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bd82383b-f383-4823-90a6-90669cfe02fa")]
        public void Method_1008_181f()
        {
            ii(0x1008_181f, 5); pushd(0xb8);                            /* push 0xb8 */
            ii(0x1008_1824, 5); calld(Definitions.sys_check_available_stack_size, 0xe_4529); /* call 0x10165d52 */
            ii(0x1008_1829, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_182a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_182b, 1); pushd(edx);                             /* push edx */
            ii(0x1008_182c, 1); pushd(esi);                             /* push esi */
            ii(0x1008_182d, 1); pushd(edi);                             /* push edi */
            ii(0x1008_182e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_182f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_1831, 6); sub(esp, 0x98);                         /* sub esp, 0x98 */
            ii(0x1008_1837, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_183a, 7); mov(memd_a32[ss, ebp - 0x3c], 0);       /* mov dword [ebp-0x3c], 0x0 */
            ii(0x1008_1841, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1008_1848, 2); jmpd(0x1008_1850, 0x6); goto l_0x1008_1850; /* jmp 0x10081850 */
        l_0x1008_184a:
            ii(0x1008_184a, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1008_184d, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x1008_1850:
            ii(0x1008_1850, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1853, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_1856, 5); calld(0x1007_6b90, -0xaccb);            /* call 0x10076b90 */
            ii(0x1008_185b, 4); cmp(ax, memw_a32[ss, ebp - 0x2c]);      /* cmp ax, [ebp-0x2c] */
            ii(0x1008_185f, 2); if(jled(0x1008_187e, 0x1d)) goto l_0x1008_187e; /* jle 0x1008187e */
            ii(0x1008_1861, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1008_1865, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1868, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_186b, 5); calld(0x1008_9c68, 0x83f8);             /* call 0x10089c68 */
            ii(0x1008_1870, 5); calld(0x1008_9f70, 0x86fb);             /* call 0x10089f70 */
            ii(0x1008_1875, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1008_1878, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1008_187c, 2); if(jzd(0x1008_184a, -0x34)) goto l_0x1008_184a; /* jz 0x1008184a */
        l_0x1008_187e:
            ii(0x1008_187e, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1008_1882, 2); if(jnzd(0x1008_188d, 0x9)) goto l_0x1008_188d; /* jnz 0x1008188d */
            ii(0x1008_1884, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_1888, 5); jmpd(0x1008_2048, 0x7bb); goto l_0x1008_2048; /* jmp 0x10082048 */
        l_0x1008_188d:
            ii(0x1008_188d, 4); or(memb_a32[ss, ebp - 0x18], 0x1);      /* or byte [ebp-0x18], 0x1 */
            ii(0x1008_1891, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1894, 5); calld(0x1008_8a08, 0x716f);             /* call 0x10088a08 */
            ii(0x1008_1899, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1008_189c, 4); and(memb_a32[ss, ebp - 0x18], -0x2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x1008_18a0, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1008_18a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_18a7, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1008_18aa, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1008_18ad, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_18b0, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1008_18b3, 3); calld_abs(memd_a32[ds, ebx + 0x14]);    /* call dword [ebx+0x14] */
            ii(0x1008_18b6, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1008_18b9, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x1008_18be, 3); mov(ebx, memd_a32[ss, ebp - 0x3c]);     /* mov ebx, [ebp-0x3c] */
            ii(0x1008_18c1, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1008_18c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_18c7, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_18ca, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_18cd, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1008_18d3, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1008_18d8, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1008_18da, 5); calld(0x100c_317c, 0x4_189d);           /* call 0x100c317c */
            ii(0x1008_18df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_18e1, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_18e4, 5); calld(0x100b_854d, 0x3_6c64);           /* call 0x100b854d */
            ii(0x1008_18e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_18eb, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1008_18ee, 5); calld(0x1008_8dcc, 0x74d9);             /* call 0x10088dcc */
            ii(0x1008_18f3, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1008_18fa, 2); jmpd(0x1008_1902, 0x6); goto l_0x1008_1902; /* jmp 0x10081902 */
        l_0x1008_18fc:
            ii(0x1008_18fc, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1008_18ff, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x1008_1902:
            ii(0x1008_1902, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1905, 5); calld(0x1008_a4a0, 0x8b96);             /* call 0x1008a4a0 */
            ii(0x1008_190a, 4); cmp(ax, memw_a32[ss, ebp - 0x2c]);      /* cmp ax, [ebp-0x2c] */
            ii(0x1008_190e, 2); if(jled(0x1008_1965, 0x55)) goto l_0x1008_1965; /* jle 0x10081965 */
            ii(0x1008_1910, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1008_1914, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1917, 5); calld(0x1008_a3dc, 0x8ac0);             /* call 0x1008a3dc */
            ii(0x1008_191c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_191e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_1921, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_1923, 2); if(jled(0x1008_1940, 0x1b)) goto l_0x1008_1940; /* jle 0x10081940 */
            ii(0x1008_1925, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1008_1929, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_192c, 5); calld(0x1008_a3dc, 0x8aab);             /* call 0x1008a3dc */
            ii(0x1008_1931, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1008_1934, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_1937, 7); test(memb_a32[ds, eax + 0x101c_81c1], 0x1); /* test byte [eax+0x101c81c1], 0x1 */
            ii(0x1008_193e, 2); if(jzd(0x1008_1942, 0x2)) goto l_0x1008_1942; /* jz 0x10081942 */
        l_0x1008_1940:
            ii(0x1008_1940, 2); jmpd(0x1008_195d, 0x1b); goto l_0x1008_195d; /* jmp 0x1008195d */
        l_0x1008_1942:
            ii(0x1008_1942, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1008_1946, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1949, 5); calld(0x1008_a3dc, 0x8a8e);             /* call 0x1008a3dc */
            ii(0x1008_194e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1008_1951, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_1954, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x80); /* test byte [eax+0x101c81c0], 0x80 */
            ii(0x1008_195b, 2); if(jnzd(0x1008_195f, 0x2)) goto l_0x1008_195f; /* jnz 0x1008195f */
        l_0x1008_195d:
            ii(0x1008_195d, 2); jmpd(0x1008_1963, 0x4); goto l_0x1008_1963; /* jmp 0x10081963 */
        l_0x1008_195f:
            ii(0x1008_195f, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
        l_0x1008_1963:
            ii(0x1008_1963, 2); jmpd(0x1008_18fc, -0x69); goto l_0x1008_18fc; /* jmp 0x100818fc */
        l_0x1008_1965:
            ii(0x1008_1965, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1008_1969, 2); if(jnzd(0x1008_197e, 0x13)) goto l_0x1008_197e; /* jnz 0x1008197e */
            ii(0x1008_196b, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_196f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1971, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1974, 5); calld(0x1008_8dcc, 0x7453);             /* call 0x10088dcc */
            ii(0x1008_1979, 5); jmpd(0x1008_2048, 0x6ca); goto l_0x1008_2048; /* jmp 0x10082048 */
        l_0x1008_197e:
            ii(0x1008_197e, 4); or(memb_a32[ss, ebp - 0x18], 0x1);      /* or byte [ebp-0x18], 0x1 */
            ii(0x1008_1982, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1985, 5); calld(0x1008_bbed, 0xa263);             /* call 0x1008bbed */
            ii(0x1008_198a, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1008_198d, 4); and(memb_a32[ss, ebp - 0x18], -0x2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x1008_1991, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1008_1996, 5); calld(0x1007_6338, -0xb663);            /* call 0x10076338 */
            ii(0x1008_199b, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1008_199e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_19a0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_19a2, 5); calld(0x1007_64b8, -0xb4ef);            /* call 0x100764b8 */
            ii(0x1008_19a7, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_19ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_19ae, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_19b1, 5); calld(0x1008_9d08, 0x8352);             /* call 0x10089d08 */
            ii(0x1008_19b6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_19b8, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1008_19bb, 5); calld(0x1008_9be4, 0x8224);             /* call 0x10089be4 */
            ii(0x1008_19c0, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1008_19c3, 5); calld(Definitions.my_ctor_0x101b4184, -0xaed8); /* call 0x10076af0 */
            ii(0x1008_19c8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_19ca, 1); pushd(eax);                             /* push eax */
            ii(0x1008_19cb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1008_19cd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_19cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_19d1, 3); lea(eax, ebp - 0x74);                   /* lea eax, [ebp-0x74] */
            ii(0x1008_19d4, 5); calld(0x1008_b148, 0x976f);             /* call 0x1008b148 */
            ii(0x1008_19d9, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1008_19e0, 2); jmpd(0x1008_19e8, 0x6); goto l_0x1008_19e8; /* jmp 0x100819e8 */
        l_0x1008_19e2:
            ii(0x1008_19e2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_19e5, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x1008_19e8:
            ii(0x1008_19e8, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_19eb, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1008_19f2, 2); if(jged(0x1008_1a51, 0x5d)) goto l_0x1008_1a51; /* jge 0x10081a51 */
            ii(0x1008_19f4, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1008_19fb, 2); jmpd(0x1008_1a03, 0x6); goto l_0x1008_1a03; /* jmp 0x10081a03 */
        l_0x1008_19fd:
            ii(0x1008_19fd, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_1a00, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x1008_1a03:
            ii(0x1008_1a03, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1008_1a06, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1008_1a0d, 2); if(jged(0x1008_1a4f, 0x40)) goto l_0x1008_1a4f; /* jge 0x10081a4f */
            ii(0x1008_1a0f, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1008_1a13, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1008_1a18, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_1a1b, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1008_1a1e, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1008_1a22, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_1a24, 6); mov(edx, memd_a32[ds, 0x101c_9454]);    /* mov edx, [0x101c9454] */
            ii(0x1008_1a2a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_1a2c, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1008_1a2e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_1a33, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1008_1a36, 2); if(jnzd(0x1008_1a4d, 0x15)) goto l_0x1008_1a4d; /* jnz 0x10081a4d */
            ii(0x1008_1a38, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1008_1a3c, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1a3f, 5); calld(0x1008_a728, 0x8ce4);             /* call 0x1008a728 */
            ii(0x1008_1a44, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1008_1a48, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_1a4a, 3); mov(memb_a32[ds, eax], 0x2);            /* mov byte [eax], 0x2 */
        l_0x1008_1a4d:
            ii(0x1008_1a4d, 2); jmpd(0x1008_19fd, -0x52); goto l_0x1008_19fd; /* jmp 0x100819fd */
        l_0x1008_1a4f:
            ii(0x1008_1a4f, 2); jmpd(0x1008_19e2, -0x6f); goto l_0x1008_19e2; /* jmp 0x100819e2 */
        l_0x1008_1a51:
            ii(0x1008_1a51, 2); jmpd(0x1008_1a5b, 0x8); goto l_0x1008_1a5b; /* jmp 0x10081a5b */
        l_0x1008_1a53:
            ii(0x1008_1a53, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1a56, 5); calld(0x1007_6bf8, -0xae63);            /* call 0x10076bf8 */
        l_0x1008_1a5b:
            ii(0x1008_1a5b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1a5d, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1a60, 5); calld(0x1013_ad71, 0xb_930c);           /* call 0x1013ad71 */
            ii(0x1008_1a65, 2); test(al, al);                           /* test al, al */
            ii(0x1008_1a67, 2); if(jzd(0x1008_1abf, 0x56)) goto l_0x1008_1abf; /* jz 0x10081abf */
            ii(0x1008_1a69, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1a6c, 5); calld(0x1007_63a0, -0xb6d1);            /* call 0x100763a0 */
            ii(0x1008_1a71, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1008_1a76, 2); if(jnzd(0x1008_1a92, 0x1a)) goto l_0x1008_1a92; /* jnz 0x10081a92 */
            ii(0x1008_1a78, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1a7b, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1008_1a7e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_1a81, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1a84, 5); calld(0x1007_63a0, -0xb6e9);            /* call 0x100763a0 */
            ii(0x1008_1a89, 5); calld(0x1007_6074, -0xba1a);            /* call 0x10076074 */
            ii(0x1008_1a8e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_1a90, 2); if(jnzd(0x1008_1a94, 0x2)) goto l_0x1008_1a94; /* jnz 0x10081a94 */
        l_0x1008_1a92:
            ii(0x1008_1a92, 2); jmpd(0x1008_1abd, 0x29); goto l_0x1008_1abd; /* jmp 0x10081abd */
        l_0x1008_1a94:
            ii(0x1008_1a94, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1a97, 5); calld(0x1007_63a0, -0xb6fc);            /* call 0x100763a0 */
            ii(0x1008_1a9c, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1008_1a9f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_1aa2, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1aa5, 5); calld(0x1007_63a0, -0xb70a);            /* call 0x100763a0 */
            ii(0x1008_1aaa, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1008_1aad, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_1ab0, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1ab3, 5); calld(0x1008_a728, 0x8c70);             /* call 0x1008a728 */
            ii(0x1008_1ab8, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_1aba, 3); mov(memb_a32[ds, eax], 0x2);            /* mov byte [eax], 0x2 */
        l_0x1008_1abd:
            ii(0x1008_1abd, 2); jmpd(0x1008_1a53, -0x6c); goto l_0x1008_1a53; /* jmp 0x10081a53 */
        l_0x1008_1abf:
            ii(0x1008_1abf, 2); jmpd(0x1008_1ac9, 0x8); goto l_0x1008_1ac9; /* jmp 0x10081ac9 */
        l_0x1008_1ac1:
            ii(0x1008_1ac1, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1008_1ac4, 5); calld(0x1007_6bf8, -0xaed1);            /* call 0x10076bf8 */
        l_0x1008_1ac9:
            ii(0x1008_1ac9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1acb, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1008_1ace, 5); calld(0x1013_ad71, 0xb_929e);           /* call 0x1013ad71 */
            ii(0x1008_1ad3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_1ad5, 6); if(jzd(0x1008_1bc6, 0xeb)) goto l_0x1008_1bc6; /* jz 0x10081bc6 */
            ii(0x1008_1adb, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1008_1ade, 5); calld(0x1008_9acc, 0x7fe9);             /* call 0x10089acc */
            ii(0x1008_1ae3, 5); calld(0x1008_9f38, 0x8450);             /* call 0x10089f38 */
            ii(0x1008_1ae8, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1008_1aeb, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1008_1aef, 6); if(jzd(0x1008_1bc1, 0xcc)) goto l_0x1008_1bc1; /* jz 0x10081bc1 */
            ii(0x1008_1af5, 3); lea(edx, ebp - 0x78);                   /* lea edx, [ebp-0x78] */
            ii(0x1008_1af8, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1008_1afb, 5); calld(0x100b_8e63, 0x3_7363);           /* call 0x100b8e63 */
            ii(0x1008_1b00, 3); lea(ebx, ebp - 0x4c);                   /* lea ebx, [ebp-0x4c] */
            ii(0x1008_1b03, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1b05, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_1b07, 5); calld(0x1008_8b44, 0x7038);             /* call 0x10088b44 */
            ii(0x1008_1b0c, 4); movsx(ebx, memw_a32[ss, ebp - 0x4a]);   /* movsx ebx, word [ebp-0x4a] */
            ii(0x1008_1b10, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1008_1b14, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1b17, 5); calld(0x1008_a728, 0x8c0c);             /* call 0x1008a728 */
            ii(0x1008_1b1c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_1b1e, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1008_1b20, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_1b25, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1008_1b28, 6); if(jnzd(0x1008_1bc1, 0x93)) goto l_0x1008_1bc1; /* jnz 0x10081bc1 */
            ii(0x1008_1b2e, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1008_1b33, 5); calld(Definitions.sys_new, 0xe_42c8);   /* call 0x10165e00 */
            ii(0x1008_1b38, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x1008_1b3b, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1008_1b3e, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x1008_1b41, 4); cmp(memd_a32[ss, ebp - 0x80], 0);       /* cmp dword [ebp-0x80], 0x0 */
            ii(0x1008_1b45, 2); if(jzd(0x1008_1b87, 0x40)) goto l_0x1008_1b87; /* jz 0x10081b87 */
            ii(0x1008_1b47, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_1b49, 1); pushd(eax);                             /* push eax */
            ii(0x1008_1b4a, 3); lea(edx, ebp - 0x4c);                   /* lea edx, [ebp-0x4c] */
            ii(0x1008_1b4d, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x1008_1b53, 5); calld(0x1007_5e64, -0xbcf4);            /* call 0x10075e64 */
            ii(0x1008_1b58, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1008_1b5a, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1008_1b5f, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1b62, 5); calld(0x1008_a6f8, 0x8b91);             /* call 0x1008a6f8 */
            ii(0x1008_1b67, 3); mov(esi, memd_a32[ss, ebp - 0x7c]);     /* mov esi, [ebp-0x7c] */
            ii(0x1008_1b6a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1b6c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1008_1b6e, 5); calld(0x100c_7dd0, 0x4_625d);           /* call 0x100c7dd0 */
            ii(0x1008_1b73, 6); mov(memd_a32[ss, ebp - 0x88], eax);     /* mov [ebp-0x88], eax */
            ii(0x1008_1b79, 6); mov(eax, memd_a32[ss, ebp - 0x88]);     /* mov eax, [ebp-0x88] */
            ii(0x1008_1b7f, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
            ii(0x1008_1b85, 2); jmpd(0x1008_1b90, 0x9); goto l_0x1008_1b90; /* jmp 0x10081b90 */
        l_0x1008_1b87:
            ii(0x1008_1b87, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x1008_1b8a, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
        l_0x1008_1b90:
            ii(0x1008_1b90, 6); mov(edx, memd_a32[ss, ebp - 0x8c]);     /* mov edx, [ebp-0x8c] */
            ii(0x1008_1b96, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_1b9c, 5); calld(0x1008_96e0, 0x7b3f);             /* call 0x100896e0 */
            ii(0x1008_1ba1, 3); lea(edx, ebp - 0x74);                   /* lea edx, [ebp-0x74] */
            ii(0x1008_1ba4, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_1baa, 5); calld(0x1008_9640, 0x7a91);             /* call 0x10089640 */
            ii(0x1008_1baf, 5); calld(0x1008_98c4, 0x7d10);             /* call 0x100898c4 */
            ii(0x1008_1bb4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1bb6, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1008_1bbc, 5); calld(0x1008_9600, 0x7a3f);             /* call 0x10089600 */
        l_0x1008_1bc1:
            ii(0x1008_1bc1, 5); jmpd(0x1008_1ac1, -0x105); goto l_0x1008_1ac1; /* jmp 0x10081ac1 */
        l_0x1008_1bc6:
            ii(0x1008_1bc6, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
            ii(0x1008_1bcd, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1008_1bd4, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1008_1bd9, 3); mov(ebx, memd_a32[ss, ebp - 0x3c]);     /* mov ebx, [ebp-0x3c] */
            ii(0x1008_1bdc, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1008_1bdf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1be2, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_1be5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_1be8, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x1008_1bee, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1008_1bf3, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1008_1bf5, 5); calld(0x100c_317c, 0x4_1582);           /* call 0x100c317c */
            ii(0x1008_1bfa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1bfc, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1bff, 5); calld(0x100b_854d, 0x3_6949);           /* call 0x100b854d */
            ii(0x1008_1c04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1c06, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_1c09, 5); calld(0x1008_8dcc, 0x71be);             /* call 0x10088dcc */
            ii(0x1008_1c0e, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1008_1c13, 5); calld(0x1007_6338, -0xb8e0);            /* call 0x10076338 */
            ii(0x1008_1c18, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1c1a, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1c1d, 5); calld(0x1007_643c, -0xb7e6);            /* call 0x1007643c */
            ii(0x1008_1c22, 2); jmpd(0x1008_1c2c, 0x8); goto l_0x1008_1c2c; /* jmp 0x10081c2c */
        l_0x1008_1c24:
            ii(0x1008_1c24, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1c27, 5); calld(0x1007_6bf8, -0xb034);            /* call 0x10076bf8 */
        l_0x1008_1c2c:
            ii(0x1008_1c2c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1c2e, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1c31, 5); calld(0x1013_ad71, 0xb_913b);           /* call 0x1013ad71 */
            ii(0x1008_1c36, 2); test(al, al);                           /* test al, al */
            ii(0x1008_1c38, 6); if(jzd(0x1008_1e0b, 0x1cd)) goto l_0x1008_1e0b; /* jz 0x10081e0b */
            ii(0x1008_1c3e, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1c41, 5); calld(0x1007_63a0, -0xb8a6);            /* call 0x100763a0 */
            ii(0x1008_1c46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1c48, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_1c4b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1c4e, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_1c51, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_1c54, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_1c56, 2); if(jnzd(0x1008_1c6c, 0x14)) goto l_0x1008_1c6c; /* jnz 0x10081c6c */
            ii(0x1008_1c58, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1c5b, 5); calld(0x1007_63a0, -0xb8c0);            /* call 0x100763a0 */
            ii(0x1008_1c60, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1008_1c63, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_1c68, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_1c6a, 2); if(jgd(0x1008_1c6e, 0x2)) goto l_0x1008_1c6e; /* jg 0x10081c6e */
        l_0x1008_1c6c:
            ii(0x1008_1c6c, 2); jmpd(0x1008_1c82, 0x14); goto l_0x1008_1c82; /* jmp 0x10081c82 */
        l_0x1008_1c6e:
            ii(0x1008_1c6e, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1c71, 5); calld(0x1007_63a0, -0xb8d6);            /* call 0x100763a0 */
            ii(0x1008_1c76, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1008_1c79, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_1c7e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_1c80, 2); if(jgd(0x1008_1c84, 0x2)) goto l_0x1008_1c84; /* jg 0x10081c84 */
        l_0x1008_1c82:
            ii(0x1008_1c82, 2); jmpd(0x1008_1ca8, 0x24); goto l_0x1008_1ca8; /* jmp 0x10081ca8 */
        l_0x1008_1c84:
            ii(0x1008_1c84, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1c87, 5); calld(0x1007_63a0, -0xb8ec);            /* call 0x100763a0 */
            ii(0x1008_1c8c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1c8e, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x1008_1c91, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1c94, 5); calld(0x1007_63a0, -0xb8f9);            /* call 0x100763a0 */
            ii(0x1008_1c99, 5); calld(0x1007_623c, -0xba62);            /* call 0x1007623c */
            ii(0x1008_1c9e, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1008_1ca1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_1ca4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_1ca6, 2); if(jged(0x1008_1caa, 0x2)) goto l_0x1008_1caa; /* jge 0x10081caa */
        l_0x1008_1ca8:
            ii(0x1008_1ca8, 2); jmpd(0x1008_1cb8, 0xe); goto l_0x1008_1cb8; /* jmp 0x10081cb8 */
        l_0x1008_1caa:
            ii(0x1008_1caa, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1cad, 5); calld(0x1007_63a0, -0xb912);            /* call 0x100763a0 */
            ii(0x1008_1cb2, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1008_1cb6, 2); if(jzd(0x1008_1cbd, 0x5)) goto l_0x1008_1cbd; /* jz 0x10081cbd */
        l_0x1008_1cb8:
            ii(0x1008_1cb8, 5); jmpd(0x1008_1e06, 0x149); goto l_0x1008_1e06; /* jmp 0x10081e06 */
        l_0x1008_1cbd:
            ii(0x1008_1cbd, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1cc0, 5); calld(0x1007_63a0, -0xb925);            /* call 0x100763a0 */
            ii(0x1008_1cc5, 4); test(memb_a32[ds, eax + 0x12], 0x80);   /* test byte [eax+0x12], 0x80 */
            ii(0x1008_1cc9, 2); if(jnzd(0x1008_1d01, 0x36)) goto l_0x1008_1d01; /* jnz 0x10081d01 */
            ii(0x1008_1ccb, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1cce, 5); calld(0x1007_63a0, -0xb933);            /* call 0x100763a0 */
            ii(0x1008_1cd3, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1008_1cd6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_1cd9, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1cdc, 5); calld(0x1007_63a0, -0xb941);            /* call 0x100763a0 */
            ii(0x1008_1ce1, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1008_1ce4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_1ce7, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1cea, 5); calld(0x1008_a728, 0x8a39);             /* call 0x1008a728 */
            ii(0x1008_1cef, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_1cf1, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1008_1cf3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_1cf8, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1008_1cfb, 6); if(jnzd(0x1008_1e06, 0x105)) goto l_0x1008_1e06; /* jnz 0x10081e06 */
        l_0x1008_1d01:
            ii(0x1008_1d01, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1d04, 5); calld(0x1007_63a0, -0xb969);            /* call 0x100763a0 */
            ii(0x1008_1d09, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1008_1d0d, 2); if(jzd(0x1008_1d1d, 0xe)) goto l_0x1008_1d1d; /* jz 0x10081d1d */
            ii(0x1008_1d0f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1d12, 5); calld(0x1007_63a0, -0xb977);            /* call 0x100763a0 */
            ii(0x1008_1d17, 4); cmp(memb_a32[ds, eax + 0x3d], 0xc);     /* cmp byte [eax+0x3d], 0xc */
            ii(0x1008_1d1b, 2); if(jnzd(0x1008_1d1f, 0x2)) goto l_0x1008_1d1f; /* jnz 0x10081d1f */
        l_0x1008_1d1d:
            ii(0x1008_1d1d, 2); jmpd(0x1008_1d2d, 0xe); goto l_0x1008_1d2d; /* jmp 0x10081d2d */
        l_0x1008_1d1f:
            ii(0x1008_1d1f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1d22, 5); calld(0x1007_63a0, -0xb987);            /* call 0x100763a0 */
            ii(0x1008_1d27, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1008_1d2b, 2); if(jnzd(0x1008_1d2f, 0x2)) goto l_0x1008_1d2f; /* jnz 0x10081d2f */
        l_0x1008_1d2d:
            ii(0x1008_1d2d, 2); jmpd(0x1008_1d41, 0x12); goto l_0x1008_1d41; /* jmp 0x10081d41 */
        l_0x1008_1d2f:
            ii(0x1008_1d2f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1d32, 5); calld(0x1007_63a0, -0xb997);            /* call 0x100763a0 */
            ii(0x1008_1d37, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1b);    /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1008_1d3b, 6); if(jnzd(0x1008_1e06, 0xc5)) goto l_0x1008_1e06; /* jnz 0x10081e06 */
        l_0x1008_1d41:
            ii(0x1008_1d41, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_1d45, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1d48, 5); calld(0x1007_63a0, -0xb9ad);            /* call 0x100763a0 */
            ii(0x1008_1d4d, 5); calld(0x1015_26ac, 0xd_095a);           /* call 0x101526ac */
            ii(0x1008_1d52, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_1d54, 2); if(jnzd(0x1008_1d5c, 0x6)) goto l_0x1008_1d5c; /* jnz 0x10081d5c */
            ii(0x1008_1d56, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_1d5a, 2); jmpd(0x1008_1dab, 0x4f); goto l_0x1008_1dab; /* jmp 0x10081dab */
        l_0x1008_1d5c:
            ii(0x1008_1d5c, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x1008_1d60, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1d63, 5); calld(0x1007_63a0, -0xb9c8);            /* call 0x100763a0 */
            ii(0x1008_1d68, 5); calld(0x1015_26ac, 0xd_093f);           /* call 0x101526ac */
            ii(0x1008_1d6d, 5); calld(0x100a_2bc4, 0x2_0e52);           /* call 0x100a2bc4 */
            ii(0x1008_1d72, 1); cwde();                                 /* cwde */
            ii(0x1008_1d73, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_1d75, 2); if(jled(0x1008_1dab, 0x34)) goto l_0x1008_1dab; /* jle 0x10081dab */
            ii(0x1008_1d77, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1d7a, 5); calld(0x1007_63a0, -0xb9df);            /* call 0x100763a0 */
            ii(0x1008_1d7f, 5); calld(0x1015_26ac, 0xd_0928);           /* call 0x101526ac */
            ii(0x1008_1d84, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
            ii(0x1008_1d8a, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x1008_1d90, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_1d93, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1d96, 5); calld(0x1007_63d4, -0xb9c7);            /* call 0x100763d4 */
            ii(0x1008_1d9b, 6); mov(ecx, memd_a32[ss, ebp - 0x94]);     /* mov ecx, [ebp-0x94] */
            ii(0x1008_1da1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1da3, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1008_1da5, 3); calld_abs(memd_a32[ds, ebx + 0x4]);     /* call dword [ebx+0x4] */
            ii(0x1008_1da8, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1008_1dab:
            ii(0x1008_1dab, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1008_1daf, 2); if(jzd(0x1008_1dcc, 0x1b)) goto l_0x1008_1dcc; /* jz 0x10081dcc */
            ii(0x1008_1db1, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1db4, 5); calld(0x1007_63a0, -0xba19);            /* call 0x100763a0 */
            ii(0x1008_1db9, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1008_1dbc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_1dbf, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1dc2, 5); calld(0x100b_87da, 0x3_6a13);           /* call 0x100b87da */
            ii(0x1008_1dc7, 1); cwde();                                 /* cwde */
            ii(0x1008_1dc8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_1dca, 2); if(jnzd(0x1008_1dce, 0x2)) goto l_0x1008_1dce; /* jnz 0x10081dce */
        l_0x1008_1dcc:
            ii(0x1008_1dcc, 2); jmpd(0x1008_1e06, 0x38); goto l_0x1008_1e06; /* jmp 0x10081e06 */
        l_0x1008_1dce:
            ii(0x1008_1dce, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1dd1, 5); calld(0x1007_63a0, -0xba36);            /* call 0x100763a0 */
            ii(0x1008_1dd6, 4); test(memb_a32[ds, eax + 0x12], 0x80);   /* test byte [eax+0x12], 0x80 */
            ii(0x1008_1dda, 2); if(jzd(0x1008_1df2, 0x16)) goto l_0x1008_1df2; /* jz 0x10081df2 */
            ii(0x1008_1ddc, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1ddf, 5); calld(0x1007_63a0, -0xba44);            /* call 0x100763a0 */
            ii(0x1008_1de4, 5); calld(0x1007_623c, -0xbbad);            /* call 0x1007623c */
            ii(0x1008_1de9, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1008_1ded, 3); add(memd_a32[ss, ebp - 0x24], eax);     /* add [ebp-0x24], eax */
            ii(0x1008_1df0, 2); jmpd(0x1008_1e06, 0x14); goto l_0x1008_1e06; /* jmp 0x10081e06 */
        l_0x1008_1df2:
            ii(0x1008_1df2, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1df5, 5); calld(0x1007_63a0, -0xba5a);            /* call 0x100763a0 */
            ii(0x1008_1dfa, 5); calld(0x1007_623c, -0xbbc3);            /* call 0x1007623c */
            ii(0x1008_1dff, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1008_1e03, 3); add(memd_a32[ss, ebp - 0x28], eax);     /* add [ebp-0x28], eax */
        l_0x1008_1e06:
            ii(0x1008_1e06, 5); jmpd(0x1008_1c24, -0x1e7); goto l_0x1008_1c24; /* jmp 0x10081c24 */
        l_0x1008_1e0b:
            ii(0x1008_1e0b, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1008_1e0f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_1e11, 2); if(jgd(0x1008_1e1b, 0x8)) goto l_0x1008_1e1b; /* jg 0x10081e1b */
            ii(0x1008_1e13, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1008_1e17, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_1e19, 2); if(jled(0x1008_1e6a, 0x4f)) goto l_0x1008_1e6a; /* jle 0x10081e6a */
        l_0x1008_1e1b:
            ii(0x1008_1e1b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_1e1e, 4); cmp(ax, memw_a32[ss, ebp - 0x24]);      /* cmp ax, [ebp-0x24] */
            ii(0x1008_1e22, 2); if(jled(0x1008_1e2d, 0x9)) goto l_0x1008_1e2d; /* jle 0x10081e2d */
            ii(0x1008_1e24, 7); mov(memb_a32[ss, ebp - 0x98], 0x1);     /* mov byte [ebp-0x98], 0x1 */
            ii(0x1008_1e2b, 2); jmpd(0x1008_1e34, 0x7); goto l_0x1008_1e34; /* jmp 0x10081e34 */
        l_0x1008_1e2d:
            ii(0x1008_1e2d, 7); mov(memb_a32[ss, ebp - 0x98], 0);       /* mov byte [ebp-0x98], 0x0 */
        l_0x1008_1e34:
            ii(0x1008_1e34, 6); mov(al, memb_a32[ss, ebp - 0x98]);      /* mov al, [ebp-0x98] */
            ii(0x1008_1e3a, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1008_1e3d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1e3f, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1008_1e42, 5); calld(0x1008_9044, 0x71fd);             /* call 0x10089044 */
            ii(0x1008_1e47, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1e49, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1e4c, 5); calld(0x1007_5f6c, -0xbee5);            /* call 0x10075f6c */
            ii(0x1008_1e51, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1e53, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1e56, 5); calld(0x1008_bc9f, 0x9e44);             /* call 0x1008bc9f */
            ii(0x1008_1e5b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1e5d, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1e60, 5); calld(0x1008_8dcc, 0x6f67);             /* call 0x10088dcc */
            ii(0x1008_1e65, 5); jmpd(0x1008_2048, 0x1de); goto l_0x1008_2048; /* jmp 0x10082048 */
        l_0x1008_1e6a:
            ii(0x1008_1e6a, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1008_1e6f, 5); calld(0x1007_6338, -0xbb3c);            /* call 0x10076338 */
            ii(0x1008_1e74, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1008_1e77, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1e79, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_1e7b, 5); calld(0x1007_643c, -0xba44);            /* call 0x1007643c */
            ii(0x1008_1e80, 2); jmpd(0x1008_1e8a, 0x8); goto l_0x1008_1e8a; /* jmp 0x10081e8a */
        l_0x1008_1e82:
            ii(0x1008_1e82, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1e85, 5); calld(0x1007_6bf8, -0xb292);            /* call 0x10076bf8 */
        l_0x1008_1e8a:
            ii(0x1008_1e8a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1e8c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1e8f, 5); calld(0x1013_ad71, 0xb_8edd);           /* call 0x1013ad71 */
            ii(0x1008_1e94, 2); test(al, al);                           /* test al, al */
            ii(0x1008_1e96, 6); if(jzd(0x1008_1f33, 0x97)) goto l_0x1008_1f33; /* jz 0x10081f33 */
            ii(0x1008_1e9c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1e9f, 5); calld(0x1007_63a0, -0xbb04);            /* call 0x100763a0 */
            ii(0x1008_1ea4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1ea6, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_1ea9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1eac, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_1eaf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_1eb2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_1eb4, 2); if(jnzd(0x1008_1ec5, 0xf)) goto l_0x1008_1ec5; /* jnz 0x10081ec5 */
            ii(0x1008_1eb6, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1eb9, 5); calld(0x1007_63a0, -0xbb1e);            /* call 0x100763a0 */
            ii(0x1008_1ebe, 5); cmp(memw_a32[ds, eax + 0x8], 0x19);     /* cmp word [eax+0x8], 0x19 */
            ii(0x1008_1ec3, 2); if(jzd(0x1008_1ec7, 0x2)) goto l_0x1008_1ec7; /* jz 0x10081ec7 */
        l_0x1008_1ec5:
            ii(0x1008_1ec5, 2); jmpd(0x1008_1f2e, 0x67); goto l_0x1008_1f2e; /* jmp 0x10081f2e */
        l_0x1008_1ec7:
            ii(0x1008_1ec7, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_1ecb, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1ece, 5); calld(0x1007_63a0, -0xbb33);            /* call 0x100763a0 */
            ii(0x1008_1ed3, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1008_1ed6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_1ed9, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1edc, 5); calld(0x1007_63a0, -0xbb41);            /* call 0x100763a0 */
            ii(0x1008_1ee1, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1008_1ee4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_1ee7, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1eea, 5); calld(0x1008_a728, 0x8839);             /* call 0x1008a728 */
            ii(0x1008_1eef, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_1ef1, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1008_1ef3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_1ef8, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1008_1efb, 2); if(jnzd(0x1008_1f2e, 0x31)) goto l_0x1008_1f2e; /* jnz 0x10081f2e */
            ii(0x1008_1efd, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_1f01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1f03, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1008_1f06, 5); calld(0x1008_9044, 0x7139);             /* call 0x10089044 */
            ii(0x1008_1f0b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1f0d, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1f10, 5); calld(0x1007_5f6c, -0xbfa9);            /* call 0x10075f6c */
            ii(0x1008_1f15, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1f17, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1f1a, 5); calld(0x1008_bc9f, 0x9d80);             /* call 0x1008bc9f */
            ii(0x1008_1f1f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1f21, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1f24, 5); calld(0x1008_8dcc, 0x6ea3);             /* call 0x10088dcc */
            ii(0x1008_1f29, 5); jmpd(0x1008_2048, 0x11a); goto l_0x1008_2048; /* jmp 0x10082048 */
        l_0x1008_1f2e:
            ii(0x1008_1f2e, 5); jmpd(0x1008_1e82, -0xb1); goto l_0x1008_1e82; /* jmp 0x10081e82 */
        l_0x1008_1f33:
            ii(0x1008_1f33, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_1f37, 6); if(jnzd(0x1008_1ff2, 0xb5)) goto l_0x1008_1ff2; /* jnz 0x10081ff2 */
            ii(0x1008_1f3d, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1008_1f42, 5); calld(0x1007_6338, -0xbc0f);            /* call 0x10076338 */
            ii(0x1008_1f47, 3); lea(ebx, ebp - 0x48);                   /* lea ebx, [ebp-0x48] */
            ii(0x1008_1f4a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_1f4c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_1f4e, 5); calld(0x1007_643c, -0xbb17);            /* call 0x1007643c */
            ii(0x1008_1f53, 2); jmpd(0x1008_1f5d, 0x8); goto l_0x1008_1f5d; /* jmp 0x10081f5d */
        l_0x1008_1f55:
            ii(0x1008_1f55, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1f58, 5); calld(0x1007_6bf8, -0xb365);            /* call 0x10076bf8 */
        l_0x1008_1f5d:
            ii(0x1008_1f5d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1f5f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1f62, 5); calld(0x1013_ad71, 0xb_8e0a);           /* call 0x1013ad71 */
            ii(0x1008_1f67, 2); test(al, al);                           /* test al, al */
            ii(0x1008_1f69, 6); if(jzd(0x1008_1ff2, 0x83)) goto l_0x1008_1ff2; /* jz 0x10081ff2 */
            ii(0x1008_1f6f, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1f72, 5); calld(0x1007_63a0, -0xbbd7);            /* call 0x100763a0 */
            ii(0x1008_1f77, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1f79, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_1f7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_1f7f, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_1f82, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_1f85, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_1f87, 2); if(jnzd(0x1008_1fed, 0x64)) goto l_0x1008_1fed; /* jnz 0x10081fed */
            ii(0x1008_1f89, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_1f8d, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1f90, 5); calld(0x1007_63a0, -0xbbf5);            /* call 0x100763a0 */
            ii(0x1008_1f95, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1008_1f98, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_1f9b, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1f9e, 5); calld(0x1007_63a0, -0xbc03);            /* call 0x100763a0 */
            ii(0x1008_1fa3, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1008_1fa6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_1fa9, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1fac, 5); calld(0x1008_a728, 0x8777);             /* call 0x1008a728 */
            ii(0x1008_1fb1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_1fb3, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1008_1fb5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_1fba, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1008_1fbd, 2); if(jnzd(0x1008_1fed, 0x2e)) goto l_0x1008_1fed; /* jnz 0x10081fed */
            ii(0x1008_1fbf, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_1fc3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1fc5, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1008_1fc8, 5); calld(0x1008_9044, 0x7077);             /* call 0x10089044 */
            ii(0x1008_1fcd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1fcf, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_1fd2, 5); calld(0x1007_5f6c, -0xc06b);            /* call 0x10075f6c */
            ii(0x1008_1fd7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1fd9, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_1fdc, 5); calld(0x1008_bc9f, 0x9cbe);             /* call 0x1008bc9f */
            ii(0x1008_1fe1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1fe3, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_1fe6, 5); calld(0x1008_8dcc, 0x6de1);             /* call 0x10088dcc */
            ii(0x1008_1feb, 2); jmpd(0x1008_2048, 0x5b); goto l_0x1008_2048; /* jmp 0x10082048 */
        l_0x1008_1fed:
            ii(0x1008_1fed, 5); jmpd(0x1008_1f55, -0x9d); goto l_0x1008_1f55; /* jmp 0x10081f55 */
        l_0x1008_1ff2:
            ii(0x1008_1ff2, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_1ff6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_1ff8, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x1008_1ffb, 5); calld(0x1008_9044, 0x7044);             /* call 0x10089044 */
            ii(0x1008_2000, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2002, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1008_2005, 5); calld(0x1007_5f6c, -0xc09e);            /* call 0x10075f6c */
            ii(0x1008_200a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_200c, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1008_200f, 5); calld(0x1008_bc9f, 0x9c8b);             /* call 0x1008bc9f */
            ii(0x1008_2014, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2016, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x1008_2019, 5); calld(0x1008_8dcc, 0x6dae);             /* call 0x10088dcc */
            ii(0x1008_201e, 2); jmpd(0x1008_2048, 0x28); goto l_0x1008_2048; /* jmp 0x10082048 */
        //    ii(0x1008_2020, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1008_2022, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
        //    ii(0x1008_2025, 5); calld(0x1008_9044, 0x701a);             /* call 0x10089044 */
        //    ii(0x1008_202a, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1008_202c, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
        //    ii(0x1008_202f, 5); calld(0x1007_5f6c, -0xc0c8);            /* call 0x10075f6c */
        //    ii(0x1008_2034, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1008_2036, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
        //    ii(0x1008_2039, 5); calld(0x1008_bc9f, 0x9c61);             /* call 0x1008bc9f */
        //    ii(0x1008_203e, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1008_2040, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
        //    ii(0x1008_2043, 5); calld(0x1008_8dcc, 0x6d84);             /* call 0x10088dcc */
        l_0x1008_2048:
            ii(0x1008_2048, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1008_204b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_204d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_204e, 1); popd(edi);                              /* pop edi */
            ii(0x1008_204f, 1); popd(esi);                              /* pop esi */
            ii(0x1008_2050, 1); popd(edx);                              /* pop edx */
            ii(0x1008_2051, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_2052, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_2053, 1); retd(); return;                         /* ret */
        }
    }
}
