using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_1838-a2df686d")]
        public void Method_1007_1838()
        {
            ii(0x1007_1838, 5); push(0x74);                             /* push 0x74 */
            ii(0x1007_183d, 5); call(Definitions.sys_check_available_stack_size, 0xf_4510); /* call 0x10165d52 */
            ii(0x1007_1842, 1); push(ebx);                              /* push ebx */
            ii(0x1007_1843, 1); push(ecx);                              /* push ecx */
            ii(0x1007_1844, 1); push(esi);                              /* push esi */
            ii(0x1007_1845, 1); push(edi);                              /* push edi */
            ii(0x1007_1846, 1); push(ebp);                              /* push ebp */
            ii(0x1007_1847, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_1849, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x1007_184f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_1852, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1007_1855, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1858, 4); cmp(memb[ds, eax + 61], 0x1a);          /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_185c, 6); if(jz(0x1007_1c58, 0x3f6)) goto l_0x1007_1c58; /* jz 0x10071c58 */
            ii(0x1007_1862, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1865, 5); cmp(memw[ds, eax + 8], 0x39);           /* cmp word [eax+0x8], 0x39 */
            ii(0x1007_186a, 2); if(jz(0x1007_1876, 0xa)) goto l_0x1007_1876; /* jz 0x10071876 */
            ii(0x1007_186c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_186f, 5); cmp(memw[ds, eax + 8], 0x38);           /* cmp word [eax+0x8], 0x38 */
            ii(0x1007_1874, 2); if(jnz(0x1007_1878, 2)) goto l_0x1007_1878; /* jnz 0x10071878 */
        l_0x1007_1876:
            ii(0x1007_1876, 2); jmp(0x1007_1882, 0xa); goto l_0x1007_1882; /* jmp 0x10071882 */
        l_0x1007_1878:
            ii(0x1007_1878, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_187b, 5); cmp(memw[ds, eax + 8], 0x4a);           /* cmp word [eax+0x8], 0x4a */
            ii(0x1007_1880, 2); if(jnz(0x1007_1884, 2)) goto l_0x1007_1884; /* jnz 0x10071884 */
        l_0x1007_1882:
            ii(0x1007_1882, 2); jmp(0x1007_188e, 0xa); goto l_0x1007_188e; /* jmp 0x1007188e */
        l_0x1007_1884:
            ii(0x1007_1884, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1887, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_188c, 2); if(jnz(0x1007_1894, 6)) goto l_0x1007_1894; /* jnz 0x10071894 */
        l_0x1007_188e:
            ii(0x1007_188e, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_1892, 2); if(jnz(0x1007_1896, 2)) goto l_0x1007_1896; /* jnz 0x10071896 */
        l_0x1007_1894:
            ii(0x1007_1894, 2); jmp(0x1007_18a3, 0xd); goto l_0x1007_18a3; /* jmp 0x100718a3 */
        l_0x1007_1896:
            ii(0x1007_1896, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1007_189b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_189e, 5); call(0x1014_271e, 0xd_0e7b);            /* call 0x1014271e */
        l_0x1007_18a3:
            ii(0x1007_18a3, 7); cmp(memb[ds, 0x101c_3920], 0);          /* cmp byte [0x101c3920], 0x0 */
            ii(0x1007_18aa, 2); if(jz(0x1007_18f0, 0x44)) goto l_0x1007_18f0; /* jz 0x100718f0 */
            ii(0x1007_18ac, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_18b3, 2); jmp(0x1007_18bb, 6); goto l_0x1007_18bb; /* jmp 0x100718bb */
        l_0x1007_18b5:
            ii(0x1007_18b5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_18b8, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
        l_0x1007_18bb:
            ii(0x1007_18bb, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1007_18bf, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1007_18c2, 2); if(jge(0x1007_18eb, 0x27)) goto l_0x1007_18eb; /* jge 0x100718eb */
            ii(0x1007_18c4, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1007_18c8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_18ce, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1007_18d4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_18d9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_18db, 2); if(jz(0x1007_18e9, 0xc)) goto l_0x1007_18e9; /* jz 0x100718e9 */
            ii(0x1007_18dd, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1007_18e1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_18e4, 5); call(0x1014_f634, 0xd_dd4b);            /* call 0x1014f634 */
        l_0x1007_18e9:
            ii(0x1007_18e9, 2); jmp(0x1007_18b5, -0x36); goto l_0x1007_18b5; /* jmp 0x100718b5 */
        l_0x1007_18eb:
            ii(0x1007_18eb, 5); jmp(0x1007_1c58, 0x368); goto l_0x1007_1c58; /* jmp 0x10071c58 */
        l_0x1007_18f0:
            ii(0x1007_18f0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_18f3, 4); cmp(memb[ds, eax + 61], 0x10);          /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_18f7, 6); if(jz(0x1007_1c58, 0x35b)) goto l_0x1007_1c58; /* jz 0x10071c58 */
            ii(0x1007_18fd, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_1901, 2); if(jz(0x1007_190d, 0xa)) goto l_0x1007_190d; /* jz 0x1007190d */
            ii(0x1007_1903, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1906, 5); call(0x1007_15df, -0x32c);              /* call 0x100715df */
            ii(0x1007_190b, 2); jmp(0x1007_192c, 0x1f); goto l_0x1007_192c; /* jmp 0x1007192c */
        l_0x1007_190d:
            ii(0x1007_190d, 7); mov(memd[ss, ebp - 16], 4);             /* mov dword [ebp-0x10], 0x4 */
        l_0x1007_1914:
            ii(0x1007_1914, 3); dec(memd[ss, ebp - 16]);                /* dec dword [ebp-0x10] */
            ii(0x1007_1917, 5); cmp(memw[ss, ebp - 16], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1007_191c, 2); if(jz(0x1007_192c, 0xe)) goto l_0x1007_192c; /* jz 0x1007192c */
            ii(0x1007_191e, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x1007_1922, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1925, 5); call(0x1014_f2a2, 0xd_d978);            /* call 0x1014f2a2 */
            ii(0x1007_192a, 2); jmp(0x1007_1914, -0x18); goto l_0x1007_1914; /* jmp 0x10071914 */
        l_0x1007_192c:
            ii(0x1007_192c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_192f, 4); test(memb[ds, eax + 20], 0x40);         /* test byte [eax+0x14], 0x40 */
            ii(0x1007_1933, 2); if(jz(0x1007_1955, 0x20)) goto l_0x1007_1955; /* jz 0x10071955 */
            ii(0x1007_1935, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1938, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1007_193b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1940, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_1946, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1007_194c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1951, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1953, 2); if(jnz(0x1007_195a, 5)) goto l_0x1007_195a; /* jnz 0x1007195a */
        l_0x1007_1955:
            ii(0x1007_1955, 5); jmp(0x1007_1c58, 0x2fe); goto l_0x1007_1c58; /* jmp 0x10071c58 */
        l_0x1007_195a:
            ii(0x1007_195a, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1007_1961, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1964, 5); call(0x1007_623c, 0x48d3);              /* call 0x1007623c */
            ii(0x1007_1969, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1007_196d, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1007_1970, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1973, 4); cmp(memb[ds, eax + 61], 0x1a);          /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_1977, 2); if(jnz(0x1007_1980, 7)) goto l_0x1007_1980; /* jnz 0x10071980 */
            ii(0x1007_1979, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
        l_0x1007_1980:
            ii(0x1007_1980, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1983, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x1007_1987, 3); sub(eax, memd[ss, ebp - 24]);           /* sub eax, [ebp-0x18] */
            ii(0x1007_198a, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1007_198d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1990, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x1007_1994, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1007_1997, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1007_199a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_199d, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x1007_19a1, 3); sub(eax, memd[ss, ebp - 24]);           /* sub eax, [ebp-0x18] */
            ii(0x1007_19a4, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1007_19a7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_19aa, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x1007_19ae, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1007_19b1, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1007_19b4, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_19b8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_19ba, 2); if(jge(0x1007_19c3, 7)) goto l_0x1007_19c3; /* jge 0x100719c3 */
            ii(0x1007_19bc, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
        l_0x1007_19c3:
            ii(0x1007_19c3, 4); movsx(eax, memw[ss, ebp - 36]);         /* movsx eax, word [ebp-0x24] */
            ii(0x1007_19c7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_19c9, 2); if(jge(0x1007_19d2, 7)) goto l_0x1007_19d2; /* jge 0x100719d2 */
            ii(0x1007_19cb, 7); mov(memd[ss, ebp - 36], 0);             /* mov dword [ebp-0x24], 0x0 */
        l_0x1007_19d2:
            ii(0x1007_19d2, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1007_19d7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_19da, 4); movsx(edx, memw[ss, ebp - 32]);         /* movsx edx, word [ebp-0x20] */
            ii(0x1007_19de, 1); dec(eax);                               /* dec eax */
            ii(0x1007_19df, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_19e1, 2); if(jle(0x1007_19ed, 0xa)) goto l_0x1007_19ed; /* jle 0x100719ed */
            ii(0x1007_19e3, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x1007_19e9, 1); dec(eax);                               /* dec eax */
            ii(0x1007_19ea, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x1007_19ed:
            ii(0x1007_19ed, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1007_19f2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_19f5, 4); movsx(edx, memw[ss, ebp - 40]);         /* movsx edx, word [ebp-0x28] */
            ii(0x1007_19f9, 1); dec(eax);                               /* dec eax */
            ii(0x1007_19fa, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_19fc, 2); if(jle(0x1007_1a08, 0xa)) goto l_0x1007_1a08; /* jle 0x10071a08 */
            ii(0x1007_19fe, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x1007_1a04, 1); dec(eax);                               /* dec eax */
            ii(0x1007_1a05, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
        l_0x1007_1a08:
            ii(0x1007_1a08, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1007_1a0b, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1007_1a0e, 2); jmp(0x1007_1a16, 6); goto l_0x1007_1a16; /* jmp 0x10071a16 */
        l_0x1007_1a10:
            ii(0x1007_1a10, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1007_1a13, 3); inc(memd[ss, ebp - 44]);                /* inc dword [ebp-0x2c] */
        l_0x1007_1a16:
            ii(0x1007_1a16, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1007_1a19, 4); cmp(ax, memw[ss, ebp - 40]);            /* cmp ax, [ebp-0x28] */
            ii(0x1007_1a1d, 2); if(jg(0x1007_1a7d, 0x5e)) goto l_0x1007_1a7d; /* jg 0x10071a7d */
            ii(0x1007_1a1f, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_1a22, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1007_1a25, 2); jmp(0x1007_1a2d, 6); goto l_0x1007_1a2d; /* jmp 0x10071a2d */
        l_0x1007_1a27:
            ii(0x1007_1a27, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_1a2a, 3); inc(memd[ss, ebp - 48]);                /* inc dword [ebp-0x30] */
        l_0x1007_1a2d:
            ii(0x1007_1a2d, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_1a30, 4); cmp(ax, memw[ss, ebp - 32]);            /* cmp ax, [ebp-0x20] */
            ii(0x1007_1a34, 2); if(jg(0x1007_1a7b, 0x45)) goto l_0x1007_1a7b; /* jg 0x10071a7b */
            ii(0x1007_1a36, 4); movsx(ecx, memw[ss, ebp - 24]);         /* movsx ecx, word [ebp-0x18] */
            ii(0x1007_1a3a, 4); movsx(ebx, memw[ss, ebp - 44]);         /* movsx ebx, word [ebp-0x2c] */
            ii(0x1007_1a3e, 4); movsx(edx, memw[ss, ebp - 48]);         /* movsx edx, word [ebp-0x30] */
            ii(0x1007_1a42, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1a45, 5); call(0x1007_0b7d, -0xecd);              /* call 0x10070b7d */
            ii(0x1007_1a4a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1a4c, 2); if(jz(0x1007_1a79, 0x2b)) goto l_0x1007_1a79; /* jz 0x10071a79 */
            ii(0x1007_1a4e, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_1a52, 2); if(jz(0x1007_1a69, 0x15)) goto l_0x1007_1a69; /* jz 0x10071a69 */
            ii(0x1007_1a54, 4); movsx(ebx, memw[ss, ebp - 44]);         /* movsx ebx, word [ebp-0x2c] */
            ii(0x1007_1a58, 4); movsx(edx, memw[ss, ebp - 48]);         /* movsx edx, word [ebp-0x30] */
            ii(0x1007_1a5c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1a5f, 5); call(0x1007_114f, -0x915);              /* call 0x1007114f */
            ii(0x1007_1a64, 3); or(memd[ss, ebp - 20], eax);            /* or [ebp-0x14], eax */
            ii(0x1007_1a67, 2); jmp(0x1007_1a79, 0x10); goto l_0x1007_1a79; /* jmp 0x10071a79 */
        l_0x1007_1a69:
            ii(0x1007_1a69, 4); movsx(ebx, memw[ss, ebp - 44]);         /* movsx ebx, word [ebp-0x2c] */
            ii(0x1007_1a6d, 4); movsx(edx, memw[ss, ebp - 48]);         /* movsx edx, word [ebp-0x30] */
            ii(0x1007_1a71, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1a74, 5); call(0x1007_1436, -0x643);              /* call 0x10071436 */
        l_0x1007_1a79:
            ii(0x1007_1a79, 2); jmp(0x1007_1a27, -0x54); goto l_0x1007_1a27; /* jmp 0x10071a27 */
        l_0x1007_1a7b:
            ii(0x1007_1a7b, 2); jmp(0x1007_1a10, -0x6d); goto l_0x1007_1a10; /* jmp 0x10071a10 */
        l_0x1007_1a7d:
            ii(0x1007_1a7d, 5); cmp(memw[ss, ebp - 20], 0);             /* cmp word [ebp-0x14], 0x0 */
            ii(0x1007_1a82, 2); if(jz(0x1007_1ac8, 0x44)) goto l_0x1007_1ac8; /* jz 0x10071ac8 */
            ii(0x1007_1a84, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1a87, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1007_1a8a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1a8f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_1a95, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1007_1a9b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1aa0, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1007_1aa3, 2); if(jz(0x1007_1ac6, 0x21)) goto l_0x1007_1ac6; /* jz 0x10071ac6 */
            ii(0x1007_1aa5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1aa8, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1007_1aab, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1ab0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1007_1ab6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1007_1abc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_1ac1, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1007_1ac4, 2); if(jnz(0x1007_1ac8, 2)) goto l_0x1007_1ac8; /* jnz 0x10071ac8 */
        l_0x1007_1ac6:
            ii(0x1007_1ac6, 2); jmp(0x1007_1aca, 2); goto l_0x1007_1aca; /* jmp 0x10071aca */
        l_0x1007_1ac8:
            ii(0x1007_1ac8, 2); jmp(0x1007_1ad3, 9); goto l_0x1007_1ad3; /* jmp 0x10071ad3 */
        l_0x1007_1aca:
            ii(0x1007_1aca, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1acd, 4); cmp(memb[ds, eax + 61], 0);             /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1007_1ad1, 2); if(jnz(0x1007_1ad5, 2)) goto l_0x1007_1ad5; /* jnz 0x10071ad5 */
        l_0x1007_1ad3:
            ii(0x1007_1ad3, 2); jmp(0x1007_1ae3, 0xe); goto l_0x1007_1ae3; /* jmp 0x10071ae3 */
        l_0x1007_1ad5:
            ii(0x1007_1ad5, 5); mov(eax, 0x58);                         /* mov eax, 0x58 */
            ii(0x1007_1ada, 5); call(0x1007_5fdc, 0x44fd);              /* call 0x10075fdc */
            ii(0x1007_1adf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1ae1, 2); if(jnz(0x1007_1ae8, 5)) goto l_0x1007_1ae8; /* jnz 0x10071ae8 */
        l_0x1007_1ae3:
            ii(0x1007_1ae3, 5); jmp(0x1007_1c58, 0x170); goto l_0x1007_1c58; /* jmp 0x10071c58 */
        l_0x1007_1ae8:
            ii(0x1007_1ae8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1aeb, 5); call(0x1007_173a, -0x3b6);              /* call 0x1007173a */
            ii(0x1007_1af0, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x1007_1af3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1af6, 5); call(0x1007_61d4, 0x46d9);              /* call 0x100761d4 */
            ii(0x1007_1afb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1afd, 2); if(jz(0x1007_1b4a, 0x4b)) goto l_0x1007_1b4a; /* jz 0x10071b4a */
            ii(0x1007_1aff, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1b02, 5); call(0x1007_61d4, 0x46cd);              /* call 0x100761d4 */
            ii(0x1007_1b07, 5); call(0x1007_6338, 0x482c);              /* call 0x10076338 */
            ii(0x1007_1b0c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_1b0e, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1007_1b11, 5); call(0x1007_64b8, 0x49a2);              /* call 0x100764b8 */
            ii(0x1007_1b16, 2); jmp(0x1007_1b20, 8); goto l_0x1007_1b20; /* jmp 0x10071b20 */
        l_0x1007_1b18:
            ii(0x1007_1b18, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1007_1b1b, 5); call(0x1007_6bf8, 0x50d8);              /* call 0x10076bf8 */
        l_0x1007_1b20:
            ii(0x1007_1b20, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_1b22, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1007_1b25, 5); call(0x1013_ad71, 0xc_9247);            /* call 0x1013ad71 */
            ii(0x1007_1b2a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_1b2c, 2); if(jz(0x1007_1b40, 0x12)) goto l_0x1007_1b40; /* jz 0x10071b40 */
            ii(0x1007_1b2e, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1007_1b31, 5); call(0x1007_63d4, 0x489e);              /* call 0x100763d4 */
            ii(0x1007_1b36, 5); call(0x1007_173a, -0x401);              /* call 0x1007173a */
            ii(0x1007_1b3b, 3); or(memd[ss, ebp - 52], eax);            /* or [ebp-0x34], eax */
            ii(0x1007_1b3e, 2); jmp(0x1007_1b18, -0x28); goto l_0x1007_1b18; /* jmp 0x10071b18 */
        l_0x1007_1b40:
            ii(0x1007_1b40, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_1b42, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1007_1b45, 5); call(0x1007_5f6c, 0x4422);              /* call 0x10075f6c */
        l_0x1007_1b4a:
            ii(0x1007_1b4a, 4); movsx(edx, memw[ss, ebp - 20]);         /* movsx edx, word [ebp-0x14] */
            ii(0x1007_1b4e, 4); movsx(eax, memw[ss, ebp - 52]);         /* movsx eax, word [ebp-0x34] */
            ii(0x1007_1b52, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1007_1b54, 6); if(jz(0x1007_1c58, 0xfe)) goto l_0x1007_1c58; /* jz 0x10071c58 */
            ii(0x1007_1b5a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1b5d, 5); call(0x1007_61d4, 0x4672);              /* call 0x100761d4 */
            ii(0x1007_1b62, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_1b64, 2); if(jnz(0x1007_1bbe, 0x58)) goto l_0x1007_1bbe; /* jnz 0x10071bbe */
            ii(0x1007_1b66, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1007_1b6b, 5); call(Definitions.sys_new, 0xf_4290);    /* call 0x10165e00 */
            ii(0x1007_1b70, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x1007_1b73, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x1007_1b76, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x1007_1b79, 4); cmp(memd[ss, ebp - 64], 0);             /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1007_1b7d, 2); if(jz(0x1007_1b95, 0x16)) goto l_0x1007_1b95; /* jz 0x10071b95 */
            ii(0x1007_1b7f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_1b82, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x1007_1b85, 5); call(0x1014_86b6, 0xd_6b2c);            /* call 0x101486b6 */
            ii(0x1007_1b8a, 3); mov(memd[ss, ebp - 68], eax);           /* mov [ebp-0x44], eax */
            ii(0x1007_1b8d, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x1007_1b90, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x1007_1b93, 2); jmp(0x1007_1b9b, 6); goto l_0x1007_1b9b; /* jmp 0x10071b9b */
        l_0x1007_1b95:
            ii(0x1007_1b95, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x1007_1b98, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
        l_0x1007_1b9b:
            ii(0x1007_1b9b, 3); mov(edx, memd[ss, ebp - 72]);           /* mov edx, [ebp-0x48] */
            ii(0x1007_1b9e, 5); mov(eax, 0x101c_813c);                  /* mov eax, 0x101c813c */
            ii(0x1007_1ba3, 5); call(0x1007_5fac, 0x4404);              /* call 0x10075fac */
            ii(0x1007_1ba8, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1007_1baf, 2); if(jz(0x1007_1bb9, 8)) goto l_0x1007_1bb9; /* jz 0x10071bb9 */
            ii(0x1007_1bb1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1bb4, 5); call(0x1012_b063, 0xb_94aa);            /* call 0x1012b063 */
        l_0x1007_1bb9:
            ii(0x1007_1bb9, 5); jmp(0x1007_1c58, 0x9a); goto l_0x1007_1c58; /* jmp 0x10071c58 */
        l_0x1007_1bbe:
            ii(0x1007_1bbe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_1bc1, 5); call(0x1007_61d4, 0x460e);              /* call 0x100761d4 */
            ii(0x1007_1bc6, 5); call(0x1007_6338, 0x476d);              /* call 0x10076338 */
            ii(0x1007_1bcb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_1bcd, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1007_1bd0, 5); call(0x1007_64b8, 0x48e3);              /* call 0x100764b8 */
            ii(0x1007_1bd5, 2); jmp(0x1007_1bdf, 8); goto l_0x1007_1bdf; /* jmp 0x10071bdf */
        l_0x1007_1bd7:
            ii(0x1007_1bd7, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1007_1bda, 5); call(0x1007_6bf8, 0x5019);              /* call 0x10076bf8 */
        l_0x1007_1bdf:
            ii(0x1007_1bdf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_1be1, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1007_1be4, 5); call(0x1013_ad71, 0xc_9188);            /* call 0x1013ad71 */
            ii(0x1007_1be9, 2); test(al, al);                           /* test al, al */
            ii(0x1007_1beb, 2); if(jz(0x1007_1c4e, 0x61)) goto l_0x1007_1c4e; /* jz 0x10071c4e */
            ii(0x1007_1bed, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1007_1bf2, 5); call(Definitions.sys_new, 0xf_4209);    /* call 0x10165e00 */
            ii(0x1007_1bf7, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x1007_1bfa, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x1007_1bfd, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
            ii(0x1007_1c00, 4); cmp(memd[ss, ebp - 84], 0);             /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1007_1c04, 2); if(jz(0x1007_1c23, 0x1d)) goto l_0x1007_1c23; /* jz 0x10071c23 */
            ii(0x1007_1c06, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1007_1c09, 5); call(0x1007_63d4, 0x47c6);              /* call 0x100763d4 */
            ii(0x1007_1c0e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_1c10, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x1007_1c13, 5); call(0x1014_86b6, 0xd_6a9e);            /* call 0x101486b6 */
            ii(0x1007_1c18, 3); mov(memd[ss, ebp - 88], eax);           /* mov [ebp-0x58], eax */
            ii(0x1007_1c1b, 3); mov(eax, memd[ss, ebp - 88]);           /* mov eax, [ebp-0x58] */
            ii(0x1007_1c1e, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
            ii(0x1007_1c21, 2); jmp(0x1007_1c29, 6); goto l_0x1007_1c29; /* jmp 0x10071c29 */
        l_0x1007_1c23:
            ii(0x1007_1c23, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x1007_1c26, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
        l_0x1007_1c29:
            ii(0x1007_1c29, 3); mov(edx, memd[ss, ebp - 92]);           /* mov edx, [ebp-0x5c] */
            ii(0x1007_1c2c, 5); mov(eax, 0x101c_813c);                  /* mov eax, 0x101c813c */
            ii(0x1007_1c31, 5); call(0x1007_5fac, 0x4376);              /* call 0x10075fac */
            ii(0x1007_1c36, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1007_1c3d, 2); if(jz(0x1007_1c4c, 0xd)) goto l_0x1007_1c4c; /* jz 0x10071c4c */
            ii(0x1007_1c3f, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1007_1c42, 5); call(0x1007_63d4, 0x478d);              /* call 0x100763d4 */
            ii(0x1007_1c47, 5); call(0x1012_b063, 0xb_9417);            /* call 0x1012b063 */
        l_0x1007_1c4c:
            ii(0x1007_1c4c, 2); jmp(0x1007_1bd7, -0x77); goto l_0x1007_1bd7; /* jmp 0x10071bd7 */
        l_0x1007_1c4e:
            ii(0x1007_1c4e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_1c50, 3); lea(eax, memd[ss, ebp - 76]);           /* lea eax, [ebp-0x4c] */
            ii(0x1007_1c53, 5); call(0x1007_5f6c, 0x4314);              /* call 0x10075f6c */
        l_0x1007_1c58:
            ii(0x1007_1c58, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_1c5a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_1c5b, 1); pop(edi);                               /* pop edi */
            ii(0x1007_1c5c, 1); pop(esi);                               /* pop esi */
            ii(0x1007_1c5d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_1c5e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_1c5f, 1); ret();                                  /* ret */
        }
    }
}
