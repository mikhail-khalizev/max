using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("920d28e8-5829-485e-b3a4-35c0f4fc2fbe")]
        public void /* sys */ Method_1018_17c1()
        {
            ii(0x1018_17c1, 1); pushd(esi);                             /* push esi */
            ii(0x1018_17c2, 1); pushd(edi);                             /* push edi */
            ii(0x1018_17c3, 1); pushd(es);                              /* push es */
            ii(0x1018_17c4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_17c5, 3); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1018_17c8, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_17ca, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1018_17cc, 4); mov(memd_a32[ss, esp + 0x4], ecx);      /* mov [esp+0x4], ecx */
            ii(0x1018_17d0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_17d2, 7); mov(memd_a32[ss, esp], 0x1);            /* mov dword [esp], 0x1 */
            ii(0x1018_17d9, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1018_17db, 2); mov(ecx, edi);                          /* mov ecx, edi */
            ii(0x1018_17dd, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1018_17df, 3); mov(dl, memb_a32[ds, ebx + 0x15]);      /* mov dl, [ebx+0x15] */
            ii(0x1018_17e2, 7); mov(memd_a32[ds, ebx + 0xc], 0);        /* mov dword [ebx+0xc], 0x0 */
            ii(0x1018_17e9, 3); cmp(dl, 0x69);                          /* cmp dl, 0x69 */
            ii(0x1018_17ec, 2); if(jbd(0x1018_180a, 0x1c)) goto l_0x1018_180a; /* jb 0x1018180a */
            ii(0x1018_17ee, 6); if(jbed(0x1018_185b, 0x67)) goto l_0x1018_185b; /* jbe 0x1018185b */
            ii(0x1018_17f4, 3); cmp(dl, 0x75);                          /* cmp dl, 0x75 */
            ii(0x1018_17f7, 2); if(jbd(0x1018_1805, 0xc)) goto l_0x1018_1805; /* jb 0x10181805 */
            ii(0x1018_17f9, 2); if(jbed(0x1018_1818, 0x1d)) goto l_0x1018_1818; /* jbe 0x10181818 */
            ii(0x1018_17fb, 3); cmp(dl, 0x78);                          /* cmp dl, 0x78 */
        l_0x1018_17fe:
            ii(0x1018_17fe, 2); if(jzd(0x1018_1818, 0x18)) goto l_0x1018_1818; /* jz 0x10181818 */
            ii(0x1018_1800, 5); jmpd(0x1018_1865, 0x60); goto l_0x1018_1865; /* jmp 0x10181865 */
        l_0x1018_1805:
            ii(0x1018_1805, 3); cmp(dl, 0x6f);                          /* cmp dl, 0x6f */
            ii(0x1018_1808, 2); jmpd(0x1018_17fe, -0xc); goto l_0x1018_17fe; /* jmp 0x101817fe */
        l_0x1018_180a:
            ii(0x1018_180a, 3); cmp(dl, 0x58);                          /* cmp dl, 0x58 */
            ii(0x1018_180d, 2); if(jbd(0x1018_1865, 0x56)) goto l_0x1018_1865; /* jb 0x10181865 */
            ii(0x1018_180f, 2); if(jbed(0x1018_1818, 0x7)) goto l_0x1018_1818; /* jbe 0x10181818 */
            ii(0x1018_1811, 3); cmp(dl, 0x64);                          /* cmp dl, 0x64 */
            ii(0x1018_1814, 2); if(jzd(0x1018_185b, 0x45)) goto l_0x1018_185b; /* jz 0x1018185b */
            ii(0x1018_1816, 2); jmpd(0x1018_1865, 0x4d); goto l_0x1018_1865; /* jmp 0x10181865 */
        l_0x1018_1818:
            ii(0x1018_1818, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_181b, 3); and(dl, 0x20);                          /* and dl, 0x20 */
            ii(0x1018_181e, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_1824, 2); if(jzd(0x1018_1832, 0xc)) goto l_0x1018_1832; /* jz 0x10181832 */
            ii(0x1018_1826, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1018_1828, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1018_182b, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1018_182d, 3); mov(ebp, memd_a32[ds, edx - 0x4]);      /* mov ebp, [edx-0x4] */
            ii(0x1018_1830, 2); jmpd(0x1018_1857, 0x25); goto l_0x1018_1857; /* jmp 0x10181857 */
        l_0x1018_1832:
            ii(0x1018_1832, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1835, 3); and(dl, 0x10);                          /* and dl, 0x10 */
            ii(0x1018_1838, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_183e, 2); if(jzd(0x1018_184d, 0xd)) goto l_0x1018_184d; /* jz 0x1018184d */
            ii(0x1018_1840, 2); mov(ebp, memd_a32[ds, eax]);            /* mov ebp, [eax] */
            ii(0x1018_1842, 3); add(ebp, 0x4);                          /* add ebp, 0x4 */
            ii(0x1018_1845, 2); mov(memd_a32[ds, eax], ebp);            /* mov [eax], ebp */
            ii(0x1018_1847, 4); movzx(ebp, memw_a32[ss, ebp - 0x4]);    /* movzx ebp, word [ebp-0x4] */
            ii(0x1018_184b, 2); jmpd(0x1018_1857, 0xa); goto l_0x1018_1857; /* jmp 0x10181857 */
        l_0x1018_184d:
            ii(0x1018_184d, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1018_184f, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1018_1852, 2); mov(memd_a32[ds, eax], ebx);            /* mov [eax], ebx */
            ii(0x1018_1854, 3); mov(ebp, memd_a32[ds, ebx - 0x4]);      /* mov ebp, [ebx-0x4] */
        l_0x1018_1857:
            ii(0x1018_1857, 4); and(memb_a32[ds, esi + 0x14], -0x7 /* 0xf9 */); /* and byte [esi+0x14], 0xf9 */
        l_0x1018_185b:
            ii(0x1018_185b, 4); cmp(memd_a32[ds, esi + 0x8], -0x1 /* 0xff */); /* cmp dword [esi+0x8], 0xffffffff */
            ii(0x1018_185f, 2); if(jzd(0x1018_1865, 0x4)) goto l_0x1018_1865; /* jz 0x10181865 */
            ii(0x1018_1861, 4); mov(memb_a32[ds, esi + 0x16], 0x20);    /* mov byte [esi+0x16], 0x20 */
        l_0x1018_1865:
            ii(0x1018_1865, 3); mov(dl, memb_a32[ds, esi + 0x15]);      /* mov dl, [esi+0x15] */
            ii(0x1018_1868, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1018_186d, 3); cmp(dl, 0x65);                          /* cmp dl, 0x65 */
            ii(0x1018_1870, 2); if(jbd(0x1018_18d2, 0x60)) goto l_0x1018_18d2; /* jb 0x101818d2 */
            ii(0x1018_1872, 6); if(jbed(0x1018_1952, 0xda)) goto l_0x1018_1952; /* jbe 0x10181952 */
            ii(0x1018_1878, 3); cmp(dl, 0x6f);                          /* cmp dl, 0x6f */
            ii(0x1018_187b, 2); if(jbd(0x1018_18b9, 0x3c)) goto l_0x1018_18b9; /* jb 0x101818b9 */
            ii(0x1018_187d, 6); if(jbed(0x1018_1968, 0xe5)) goto l_0x1018_1968; /* jbe 0x10181968 */
            ii(0x1018_1883, 3); cmp(dl, 0x73);                          /* cmp dl, 0x73 */
            ii(0x1018_1886, 2); if(jbd(0x1018_18ab, 0x23)) goto l_0x1018_18ab; /* jb 0x101818ab */
            ii(0x1018_1888, 6); if(jbed(0x1018_19fd, 0x16f)) goto l_0x1018_19fd; /* jbe 0x101819fd */
            ii(0x1018_188e, 3); cmp(dl, 0x75);                          /* cmp dl, 0x75 */
            ii(0x1018_1891, 6); if(jbd(0x1018_1bcf, 0x338)) goto l_0x1018_1bcf; /* jb 0x10181bcf */
            ii(0x1018_1897, 6); if(jbed(0x1018_1ae9, 0x24c)) goto l_0x1018_1ae9; /* jbe 0x10181ae9 */
            ii(0x1018_189d, 3); cmp(dl, 0x78);                          /* cmp dl, 0x78 */
            ii(0x1018_18a0, 6); if(jzd(0x1018_1ac6, 0x220)) goto l_0x1018_1ac6; /* jz 0x10181ac6 */
            ii(0x1018_18a6, 5); jmpd(0x1018_1bcf, 0x324); goto l_0x1018_1bcf; /* jmp 0x10181bcf */
        l_0x1018_18ab:
            ii(0x1018_18ab, 3); cmp(dl, 0x70);                          /* cmp dl, 0x70 */
            ii(0x1018_18ae, 6); if(jzd(0x1018_1b0c, 0x258)) goto l_0x1018_1b0c; /* jz 0x10181b0c */
            ii(0x1018_18b4, 5); jmpd(0x1018_1bcf, 0x316); goto l_0x1018_1bcf; /* jmp 0x10181bcf */
        l_0x1018_18b9:
            ii(0x1018_18b9, 3); cmp(dl, 0x67);                          /* cmp dl, 0x67 */
            ii(0x1018_18bc, 2); if(jbd(0x1018_1920, 0x62)) goto l_0x1018_1920; /* jb 0x10181920 */
            ii(0x1018_18be, 6); if(jbed(0x1018_1952, 0x8e)) goto l_0x1018_1952; /* jbe 0x10181952 */
            ii(0x1018_18c4, 3); cmp(dl, 0x69);                          /* cmp dl, 0x69 */
            ii(0x1018_18c7, 6); if(jzd(0x1018_19ac, 0xdf)) goto l_0x1018_19ac; /* jz 0x101819ac */
            ii(0x1018_18cd, 5); jmpd(0x1018_1bcf, 0x2fd); goto l_0x1018_1bcf; /* jmp 0x10181bcf */
        l_0x1018_18d2:
            ii(0x1018_18d2, 3); cmp(dl, 0x50);                          /* cmp dl, 0x50 */
            ii(0x1018_18d5, 2); if(jbd(0x1018_190a, 0x33)) goto l_0x1018_190a; /* jb 0x1018190a */
            ii(0x1018_18d7, 6); if(jbed(0x1018_1b0c, 0x22f)) goto l_0x1018_1b0c; /* jbe 0x10181b0c */
            ii(0x1018_18dd, 3); cmp(dl, 0x58);                          /* cmp dl, 0x58 */
            ii(0x1018_18e0, 2); if(jbd(0x1018_18fc, 0x1a)) goto l_0x1018_18fc; /* jb 0x101818fc */
            ii(0x1018_18e2, 6); if(jbed(0x1018_1ac6, 0x1de)) goto l_0x1018_1ac6; /* jbe 0x10181ac6 */
            ii(0x1018_18e8, 3); cmp(dl, 0x63);                          /* cmp dl, 0x63 */
            ii(0x1018_18eb, 6); if(jbd(0x1018_1bcf, 0x2de)) goto l_0x1018_1bcf; /* jb 0x10181bcf */
            ii(0x1018_18f1, 6); if(jbed(0x1018_1ba3, 0x2ac)) goto l_0x1018_1ba3; /* jbe 0x10181ba3 */
            ii(0x1018_18f7, 5); jmpd(0x1018_19ac, 0xb0); goto l_0x1018_19ac; /* jmp 0x101819ac */
        l_0x1018_18fc:
            ii(0x1018_18fc, 3); cmp(dl, 0x53);                          /* cmp dl, 0x53 */
            ii(0x1018_18ff, 6); if(jzd(0x1018_19fd, 0xf8)) goto l_0x1018_19fd; /* jz 0x101819fd */
            ii(0x1018_1905, 5); jmpd(0x1018_1bcf, 0x2c5); goto l_0x1018_1bcf; /* jmp 0x10181bcf */
        l_0x1018_190a:
            ii(0x1018_190a, 3); cmp(dl, 0x46);                          /* cmp dl, 0x46 */
            ii(0x1018_190d, 2); if(jbd(0x1018_191b, 0xc)) goto l_0x1018_191b; /* jb 0x1018191b */
            ii(0x1018_190f, 2); if(jbed(0x1018_1920, 0xf)) goto l_0x1018_1920; /* jbe 0x10181920 */
            ii(0x1018_1911, 3); cmp(dl, 0x47);                          /* cmp dl, 0x47 */
        l_0x1018_1914:
            ii(0x1018_1914, 2); if(jzd(0x1018_1952, 0x3c)) goto l_0x1018_1952; /* jz 0x10181952 */
            ii(0x1018_1916, 5); jmpd(0x1018_1bcf, 0x2b4); goto l_0x1018_1bcf; /* jmp 0x10181bcf */
        l_0x1018_191b:
            ii(0x1018_191b, 3); cmp(dl, 0x45);                          /* cmp dl, 0x45 */
            ii(0x1018_191e, 2); jmpd(0x1018_1914, -0xc); goto l_0x1018_1914; /* jmp 0x10181914 */
        l_0x1018_1920:
            ii(0x1018_1920, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1923, 3); and(dl, 0x10);                          /* and dl, 0x10 */
            ii(0x1018_1926, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_192c, 2); if(jzd(0x1018_1952, 0x24)) goto l_0x1018_1952; /* jz 0x10181952 */
            ii(0x1018_192e, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1018_1930, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1018_1933, 2); mov(memd_a32[ds, eax], ebx);            /* mov [eax], ebx */
            ii(0x1018_1935, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_1937, 3); mov(edx, memd_a32[ds, ebx - 0x4]);      /* mov edx, [ebx-0x4] */
            ii(0x1018_193a, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1018_193c, 5); calld(/* sys */ 0x1018_16c5, -0x27c);   /* call 0x101816c5 */
            ii(0x1018_1941, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1018_1946, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1018_1948, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1018_194a, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1018_194c, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_194e, 2); mov(ecx, edi);                          /* mov ecx, edi */
            ii(0x1018_1950, 2); jmpd(0x1018_19a2, 0x50); goto l_0x1018_19a2; /* jmp 0x101819a2 */
        l_0x1018_1952:
            ii(0x1018_1952, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1018_1954, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_1956, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_1958, 5); calld(/* sys */ 0x1018_17ba, -0x1a3);   /* call 0x101817ba */
            ii(0x1018_195d, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1018_1962, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1018_1964, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_1966, 2); jmpd(0x1018_19a2, 0x3a); goto l_0x1018_19a2; /* jmp 0x101819a2 */
        l_0x1018_1968:
            ii(0x1018_1968, 3); mov(al, memb_a32[ds, esi + 0x14]);      /* mov al, [esi+0x14] */
            ii(0x1018_196b, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1018_1970, 2); and(al, 0x1);                           /* and al, 0x1 */
            ii(0x1018_1972, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1977, 2); if(jzd(0x1018_197d, 0x4)) goto l_0x1018_197d; /* jz 0x1018197d */
            ii(0x1018_1979, 3); mov(memb_a32[ds, edi], 0x30);           /* mov byte [edi], 0x30 */
            ii(0x1018_197c, 1); inc(edi);                               /* inc edi */
        l_0x1018_197d:
            ii(0x1018_197d, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_197f, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_1981, 5); calld(/* sys */ 0x1019_5c0b, 0x1_4285); /* call 0x10195c0b */
        l_0x1018_1986:
            ii(0x1018_1986, 4); cmp(memd_a32[ds, esi + 0x8], 0);        /* cmp dword [esi+0x8], 0x0 */
            ii(0x1018_198a, 2); if(jnzd(0x1018_1999, 0xd)) goto l_0x1018_1999; /* jnz 0x10181999 */
            ii(0x1018_198c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_198e, 2); mov(al, memb_a32[ds, edi]);             /* mov al, [edi] */
            ii(0x1018_1990, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1018_1993, 2); if(jnzd(0x1018_1999, 0x4)) goto l_0x1018_1999; /* jnz 0x10181999 */
            ii(0x1018_1995, 4); mov(memb_a32[es, ecx], 0);              /* mov byte [es:ecx], 0x0 */
        l_0x1018_1999:
            ii(0x1018_1999, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1018_199e, 2); mov(edx, es);                           /* mov edx, es */
            ii(0x1018_19a0, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1018_19a2:
            ii(0x1018_19a2, 5); calld(/* sys */ 0x1018_1620, -0x387);   /* call 0x10181620 */
            ii(0x1018_19a7, 5); jmpd(0x1018_1bf8, 0x24c); goto l_0x1018_1bf8; /* jmp 0x10181bf8 */
        l_0x1018_19ac:
            ii(0x1018_19ac, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_19af, 3); and(dl, 0x20);                          /* and dl, 0x20 */
            ii(0x1018_19b2, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_19b8, 2); if(jzd(0x1018_19cd, 0x13)) goto l_0x1018_19cd; /* jz 0x101819cd */
            ii(0x1018_19ba, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1018_19bc, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1018_19bf, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1018_19c1, 3); mov(eax, memd_a32[ds, edx - 0x4]);      /* mov eax, [edx-0x4] */
            ii(0x1018_19c4, 2); mov(edx, edi);                          /* mov edx, edi */
        l_0x1018_19c6:
            ii(0x1018_19c6, 5); calld(/* sys */ 0x1019_5c0b, 0x1_4240); /* call 0x10195c0b */
            ii(0x1018_19cb, 2); jmpd(0x1018_1986, -0x47); goto l_0x1018_1986; /* jmp 0x10181986 */
        l_0x1018_19cd:
            ii(0x1018_19cd, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_19d0, 3); and(dl, 0x10);                          /* and dl, 0x10 */
            ii(0x1018_19d3, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_19d9, 2); if(jzd(0x1018_19ea, 0xf)) goto l_0x1018_19ea; /* jz 0x101819ea */
            ii(0x1018_19db, 2); mov(ebp, memd_a32[ds, eax]);            /* mov ebp, [eax] */
            ii(0x1018_19dd, 3); add(ebp, 0x4);                          /* add ebp, 0x4 */
            ii(0x1018_19e0, 2); mov(memd_a32[ds, eax], ebp);            /* mov [eax], ebp */
            ii(0x1018_19e2, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_19e4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1018_19e8, 2); jmpd(0x1018_19c6, -0x24); goto l_0x1018_19c6; /* jmp 0x101819c6 */
        l_0x1018_19ea:
            ii(0x1018_19ea, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1018_19ec, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1018_19ef, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1018_19f1, 3); mov(eax, memd_a32[ds, edx - 0x4]);      /* mov eax, [edx-0x4] */
            ii(0x1018_19f4, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_19f6, 5); calld(/* sys */ 0x1017_93f8, -0x8603);  /* call 0x101793f8 */
            ii(0x1018_19fb, 2); jmpd(0x1018_1986, -0x77); goto l_0x1018_1986; /* jmp 0x10181986 */
        l_0x1018_19fd:
            ii(0x1018_19fd, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1a00, 3); and(dl, 0x80);                          /* and dl, 0x80 */
            ii(0x1018_1a03, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_1a09, 2); if(jzd(0x1018_1a2e, 0x23)) goto l_0x1018_1a2e; /* jz 0x10181a2e */
            ii(0x1018_1a0b, 2); mov(edi, memd_a32[ds, eax]);            /* mov edi, [eax] */
            ii(0x1018_1a0d, 3); add(edi, 0x8);                          /* add edi, 0x8 */
            ii(0x1018_1a10, 2); mov(memd_a32[ds, eax], edi);            /* mov [eax], edi */
            ii(0x1018_1a12, 3); mov(ecx, memd_a32[ds, edi - 0x8]);      /* mov ecx, [edi-0x8] */
            ii(0x1018_1a15, 4); mov(dx, memw_a32[ds, edi - 0x4]);       /* mov dx, [edi-0x4] */
            ii(0x1018_1a19, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_1a1b, 2); if(jnzd(0x1018_1a22, 0x5)) goto l_0x1018_1a22; /* jnz 0x10181a22 */
            ii(0x1018_1a1d, 3); test(dx, dx);                           /* test dx, dx */
            ii(0x1018_1a20, 2); if(jzd(0x1018_1a26, 0x4)) goto l_0x1018_1a26; /* jz 0x10181a26 */
        l_0x1018_1a22:
            ii(0x1018_1a22, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1018_1a24, 2); jmpd(0x1018_1a64, 0x3e); goto l_0x1018_1a64; /* jmp 0x10181a64 */
        l_0x1018_1a26:
            ii(0x1018_1a26, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1018_1a28, 4); mov(ecx, memd_a32[ss, esp + 0x4]);      /* mov ecx, [esp+0x4] */
            ii(0x1018_1a2c, 2); jmpd(0x1018_1a62, 0x34); goto l_0x1018_1a62; /* jmp 0x10181a62 */
        l_0x1018_1a2e:
            ii(0x1018_1a2e, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1a31, 3); and(dl, 0x40);                          /* and dl, 0x40 */
            ii(0x1018_1a34, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_1a3a, 2); if(jzd(0x1018_1a4e, 0x12)) goto l_0x1018_1a4e; /* jz 0x10181a4e */
            ii(0x1018_1a3c, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1018_1a3e, 3); add(ecx, 0x4);                          /* add ecx, 0x4 */
            ii(0x1018_1a41, 2); mov(memd_a32[ds, eax], ecx);            /* mov [eax], ecx */
            ii(0x1018_1a43, 3); mov(ecx, memd_a32[ds, ecx - 0x4]);      /* mov ecx, [ecx-0x4] */
            ii(0x1018_1a46, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_1a48, 2); if(jzd(0x1018_1a26, -0x24)) goto l_0x1018_1a26; /* jz 0x10181a26 */
        l_0x1018_1a4a:
            ii(0x1018_1a4a, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1018_1a4c, 2); jmpd(0x1018_1a62, 0x14); goto l_0x1018_1a62; /* jmp 0x10181a62 */
        l_0x1018_1a4e:
            ii(0x1018_1a4e, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1018_1a50, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1018_1a53, 2); mov(memd_a32[ds, eax], ebx);            /* mov [eax], ebx */
            ii(0x1018_1a55, 3); mov(ecx, memd_a32[ds, ebx - 0x4]);      /* mov ecx, [ebx-0x4] */
            ii(0x1018_1a58, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_1a5a, 2); if(jnzd(0x1018_1a4a, -0x12)) goto l_0x1018_1a4a; /* jnz 0x10181a4a */
            ii(0x1018_1a5c, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1018_1a5e, 4); mov(ecx, memd_a32[ss, esp + 0x4]);      /* mov ecx, [esp+0x4] */
        l_0x1018_1a62:
            ii(0x1018_1a62, 2); mov(es, eax);                           /* mov es, eax */
        l_0x1018_1a64:
            ii(0x1018_1a64, 3); mov(bl, memb_a32[ds, esi + 0x14]);      /* mov bl, [esi+0x14] */
            ii(0x1018_1a67, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1018_1a69, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1a6b, 3); and(bl, 0xf9);                          /* and bl, 0xf9 */
            ii(0x1018_1a6e, 3); mov(memd_a32[ss, esp], ebp);            /* mov [esp], ebp */
            ii(0x1018_1a71, 3); mov(al, memb_a32[ds, esi + 0x15]);      /* mov al, [esi+0x15] */
            ii(0x1018_1a74, 3); mov(memb_a32[ds, esi + 0x14], bl);      /* mov [esi+0x14], bl */
            ii(0x1018_1a77, 3); cmp(eax, 0x53);                         /* cmp eax, 0x53 */
            ii(0x1018_1a7a, 2); if(jnzd(0x1018_1a9e, 0x22)) goto l_0x1018_1a9e; /* jnz 0x10181a9e */
            ii(0x1018_1a7c, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_1a7e, 2); and(al, 0x20);                          /* and al, 0x20 */
            ii(0x1018_1a80, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1a85, 2); if(jzd(0x1018_1a95, 0xe)) goto l_0x1018_1a95; /* jz 0x10181a95 */
            ii(0x1018_1a87, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1a89, 4); mov(ax, memw_a32[es, ecx]);             /* mov ax, [es:ecx] */
            ii(0x1018_1a8d, 3); add(ecx, 0x2);                          /* add ecx, 0x2 */
            ii(0x1018_1a90, 5); jmpd(0x1018_1bf8, 0x163); goto l_0x1018_1bf8; /* jmp 0x10181bf8 */
        l_0x1018_1a95:
            ii(0x1018_1a95, 3); mov(al, memb_a32[es, ecx]);             /* mov al, [es:ecx] */
            ii(0x1018_1a98, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_1a99, 5); jmpd(0x1018_1bf8, 0x15a); goto l_0x1018_1bf8; /* jmp 0x10181bf8 */
        l_0x1018_1a9e:
            ii(0x1018_1a9e, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_1aa0, 2); and(al, 0x20);                          /* and al, 0x20 */
            ii(0x1018_1aa2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1aa7, 2); if(jzd(0x1018_1aba, 0x11)) goto l_0x1018_1aba; /* jz 0x10181aba */
            ii(0x1018_1aa9, 2); mov(edx, es);                           /* mov edx, es */
            ii(0x1018_1aab, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_1aad, 3); mov(ebx, memd_a32[ds, esi + 0x8]);      /* mov ebx, [esi+0x8] */
            ii(0x1018_1ab0, 5); calld(/* sys */ 0x1018_1644, -0x471);   /* call 0x10181644 */
            ii(0x1018_1ab5, 5); jmpd(0x1018_1bf8, 0x13e); goto l_0x1018_1bf8; /* jmp 0x10181bf8 */
        l_0x1018_1aba:
            ii(0x1018_1aba, 2); mov(edx, es);                           /* mov edx, es */
            ii(0x1018_1abc, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_1abe, 3); mov(ebx, memd_a32[ds, esi + 0x8]);      /* mov ebx, [esi+0x8] */
            ii(0x1018_1ac1, 5); jmpd(0x1018_19a2, -0x124); goto l_0x1018_19a2; /* jmp 0x101819a2 */
        l_0x1018_1ac6:
            ii(0x1018_1ac6, 3); mov(al, memb_a32[ds, esi + 0x14]);      /* mov al, [esi+0x14] */
            ii(0x1018_1ac9, 2); and(al, 0x1);                           /* and al, 0x1 */
            ii(0x1018_1acb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1ad0, 2); if(jzd(0x1018_1ae4, 0x12)) goto l_0x1018_1ae4; /* jz 0x10181ae4 */
            ii(0x1018_1ad2, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1018_1ad4, 2); if(jzd(0x1018_1ae4, 0xe)) goto l_0x1018_1ae4; /* jz 0x10181ae4 */
            ii(0x1018_1ad6, 4); mov(memb_a32[ds, esi + 0x17], 0x30);    /* mov byte [esi+0x17], 0x30 */
            ii(0x1018_1ada, 3); mov(al, memb_a32[ds, esi + 0x15]);      /* mov al, [esi+0x15] */
            ii(0x1018_1add, 4); mov(memb_a32[ds, esi + 0x19], 0);       /* mov byte [esi+0x19], 0x0 */
            ii(0x1018_1ae1, 3); mov(memb_a32[ds, esi + 0x18], al);      /* mov [esi+0x18], al */
        l_0x1018_1ae4:
            ii(0x1018_1ae4, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
        l_0x1018_1ae9:
            ii(0x1018_1ae9, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_1aeb, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_1aed, 5); calld(/* sys */ 0x1019_5bc1, 0x1_40cf); /* call 0x10195bc1 */
            ii(0x1018_1af2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1af4, 3); mov(al, memb_a32[ds, esi + 0x15]);      /* mov al, [esi+0x15] */
            ii(0x1018_1af7, 3); cmp(eax, 0x58);                         /* cmp eax, 0x58 */
            ii(0x1018_1afa, 6); if(jnzd(0x1018_1986, -0x17a)) goto l_0x1018_1986; /* jnz 0x10181986 */
            ii(0x1018_1b00, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_1b02, 5); calld(/* sys */ 0x1018_1caa, 0x1a3);    /* call 0x10181caa */
            ii(0x1018_1b07, 5); jmpd(0x1018_1986, -0x186); goto l_0x1018_1986; /* jmp 0x10181986 */
        l_0x1018_1b0c:
            ii(0x1018_1b0c, 4); cmp(memd_a32[ds, esi + 0x4], 0);        /* cmp dword [esi+0x4], 0x0 */
            ii(0x1018_1b10, 2); if(jnzd(0x1018_1b30, 0x1e)) goto l_0x1018_1b30; /* jnz 0x10181b30 */
            ii(0x1018_1b12, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1b15, 3); and(dl, 0x80);                          /* and dl, 0x80 */
            ii(0x1018_1b18, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_1b1e, 2); if(jzd(0x1018_1b29, 0x9)) goto l_0x1018_1b29; /* jz 0x10181b29 */
            ii(0x1018_1b20, 7); mov(memd_a32[ds, esi + 0x4], 0xd);      /* mov dword [esi+0x4], 0xd */
            ii(0x1018_1b27, 2); jmpd(0x1018_1b30, 0x7); goto l_0x1018_1b30; /* jmp 0x10181b30 */
        l_0x1018_1b29:
            ii(0x1018_1b29, 7); mov(memd_a32[ds, esi + 0x4], 0x8);      /* mov dword [esi+0x4], 0x8 */
        l_0x1018_1b30:
            ii(0x1018_1b30, 4); and(memb_a32[ds, esi + 0x14], -0x7 /* 0xf9 */); /* and byte [esi+0x14], 0xf9 */
            ii(0x1018_1b34, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1018_1b36, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1018_1b39, 2); mov(memd_a32[ds, eax], ebx);            /* mov [eax], ebx */
            ii(0x1018_1b3b, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1b3e, 3); and(dl, 0x80);                          /* and dl, 0x80 */
            ii(0x1018_1b41, 4); mov(memb_a32[ss, esp + 0x8], dl);       /* mov [esp+0x8], dl */
            ii(0x1018_1b45, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1b47, 4); mov(dl, memb_a32[ss, esp + 0x8]);       /* mov dl, [esp+0x8] */
            ii(0x1018_1b4b, 3); mov(ebp, memd_a32[ds, ebx - 0x4]);      /* mov ebp, [ebx-0x4] */
            ii(0x1018_1b4e, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_1b50, 2); if(jzd(0x1018_1b7b, 0x29)) goto l_0x1018_1b7b; /* jz 0x10181b7b */
            ii(0x1018_1b52, 3); add(ebx, 0x4);                          /* add ebx, 0x4 */
            ii(0x1018_1b55, 2); mov(memd_a32[ds, eax], ebx);            /* mov [eax], ebx */
            ii(0x1018_1b57, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_1b59, 3); mov(eax, memd_a32[ds, ebx - 0x4]);      /* mov eax, [ebx-0x4] */
            ii(0x1018_1b5c, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1018_1b61, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_1b66, 5); calld(/* sys */ 0x1018_1667, -0x504);   /* call 0x10181667 */
            ii(0x1018_1b6b, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1018_1b70, 3); lea(edx, edi + 0x5);                    /* lea edx, [edi+0x5] */
            ii(0x1018_1b73, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_1b75, 4); mov(memb_a32[ds, edi + 0x4], 0x3a);     /* mov byte [edi+0x4], 0x3a */
            ii(0x1018_1b79, 2); jmpd(0x1018_1b84, 0x9); goto l_0x1018_1b84; /* jmp 0x10181b84 */
        l_0x1018_1b7b:
            ii(0x1018_1b7b, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1018_1b80, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_1b82, 2); mov(eax, ebp);                          /* mov eax, ebp */
        l_0x1018_1b84:
            ii(0x1018_1b84, 5); calld(/* sys */ 0x1018_1667, -0x522);   /* call 0x10181667 */
            ii(0x1018_1b89, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1b8b, 3); mov(al, memb_a32[ds, esi + 0x15]);      /* mov al, [esi+0x15] */
            ii(0x1018_1b8e, 3); cmp(eax, 0x50);                         /* cmp eax, 0x50 */
            ii(0x1018_1b91, 6); if(jnzd(0x1018_1999, -0x1fe)) goto l_0x1018_1999; /* jnz 0x10181999 */
            ii(0x1018_1b97, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_1b99, 5); calld(/* sys */ 0x1018_1caa, 0x10c);    /* call 0x10181caa */
            ii(0x1018_1b9e, 5); jmpd(0x1018_1999, -0x20a); goto l_0x1018_1999; /* jmp 0x10181999 */
        l_0x1018_1ba3:
            ii(0x1018_1ba3, 2); mov(ebp, memd_a32[ds, eax]);            /* mov ebp, [eax] */
            ii(0x1018_1ba5, 3); add(ebp, 0x4);                          /* add ebp, 0x4 */
            ii(0x1018_1ba8, 2); mov(memd_a32[ds, eax], ebp);            /* mov [eax], ebp */
            ii(0x1018_1baa, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1018_1bad, 4); mov(memb_a32[ds, edi + 0x1], 0);        /* mov byte [edi+0x1], 0x0 */
            ii(0x1018_1bb1, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1018_1bb3, 7); mov(memd_a32[ds, esi + 0x8], 0x1);      /* mov dword [esi+0x8], 0x1 */
            ii(0x1018_1bba, 3); mov(dh, memb_a32[ds, esi + 0x14]);      /* mov dh, [esi+0x14] */
            ii(0x1018_1bbd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1bbf, 3); and(dh, 0xf9);                          /* and dh, 0xf9 */
            ii(0x1018_1bc2, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1018_1bc5, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_1bca, 3); mov(memb_a32[ds, esi + 0x14], dh);      /* mov [esi+0x14], dh */
            ii(0x1018_1bcd, 2); jmpd(0x1018_1bf8, 0x29); goto l_0x1018_1bf8; /* jmp 0x10181bf8 */
        l_0x1018_1bcf:
            ii(0x1018_1bcf, 7); mov(memd_a32[ds, esi + 0x4], 0);        /* mov dword [esi+0x4], 0x0 */
            ii(0x1018_1bd6, 3); mov(al, memb_a32[ds, esi + 0x15]);      /* mov al, [esi+0x15] */
            ii(0x1018_1bd9, 4); mov(memb_a32[ds, edi + 0x1], 0);        /* mov byte [edi+0x1], 0x0 */
            ii(0x1018_1bdd, 2); mov(memb_a32[ds, edi], al);             /* mov [edi], al */
            ii(0x1018_1bdf, 7); mov(memd_a32[ds, esi + 0x8], 0x1);      /* mov dword [esi+0x8], 0x1 */
            ii(0x1018_1be6, 3); mov(al, memb_a32[ds, esi + 0x14]);      /* mov al, [esi+0x14] */
            ii(0x1018_1be9, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1018_1beb, 2); and(al, 0xf9);                          /* and al, 0xf9 */
            ii(0x1018_1bed, 3); mov(memd_a32[ss, esp], edi);            /* mov [esp], edi */
            ii(0x1018_1bf0, 3); mov(memb_a32[ds, esi + 0x14], al);      /* mov [esi+0x14], al */
            ii(0x1018_1bf3, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1018_1bf8:
            ii(0x1018_1bf8, 4); cmp(memd_a32[ss, esp], 0);              /* cmp dword [esp], 0x0 */
            ii(0x1018_1bfc, 2); if(jzd(0x1018_1c4d, 0x4f)) goto l_0x1018_1c4d; /* jz 0x10181c4d */
            ii(0x1018_1bfe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1c00, 3); mov(dl, memb_a32[es, ecx]);             /* mov dl, [es:ecx] */
            ii(0x1018_1c03, 3); cmp(edx, 0x2d);                         /* cmp edx, 0x2d */
            ii(0x1018_1c06, 2); if(jnzd(0x1018_1c10, 0x8)) goto l_0x1018_1c10; /* jnz 0x10181c10 */
            ii(0x1018_1c08, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_1c09, 4); mov(memb_a32[ds, esi + 0x17], 0x2d);    /* mov byte [esi+0x17], 0x2d */
            ii(0x1018_1c0d, 1); dec(eax);                               /* dec eax */
            ii(0x1018_1c0e, 2); jmpd(0x1018_1c36, 0x26); goto l_0x1018_1c36; /* jmp 0x10181c36 */
        l_0x1018_1c10:
            ii(0x1018_1c10, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1c13, 3); and(dl, 0x2);                           /* and dl, 0x2 */
            ii(0x1018_1c16, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_1c1c, 2); if(jzd(0x1018_1c24, 0x6)) goto l_0x1018_1c24; /* jz 0x10181c24 */
            ii(0x1018_1c1e, 4); mov(memb_a32[ds, esi + 0x17], 0x20);    /* mov byte [esi+0x17], 0x20 */
            ii(0x1018_1c22, 2); jmpd(0x1018_1c36, 0x12); goto l_0x1018_1c36; /* jmp 0x10181c36 */
        l_0x1018_1c24:
            ii(0x1018_1c24, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1c27, 3); and(dl, 0x4);                           /* and dl, 0x4 */
            ii(0x1018_1c2a, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_1c30, 2); if(jzd(0x1018_1c3a, 0x8)) goto l_0x1018_1c3a; /* jz 0x10181c3a */
            ii(0x1018_1c32, 4); mov(memb_a32[ds, esi + 0x17], 0x2b);    /* mov byte [esi+0x17], 0x2b */
        l_0x1018_1c36:
            ii(0x1018_1c36, 4); mov(memb_a32[ds, esi + 0x18], 0);       /* mov byte [esi+0x18], 0x0 */
        l_0x1018_1c3a:
            ii(0x1018_1c3a, 3); mov(edx, memd_a32[ds, esi + 0x8]);      /* mov edx, [esi+0x8] */
            ii(0x1018_1c3d, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_1c3f, 2); if(jled(0x1018_1c46, 0x5)) goto l_0x1018_1c46; /* jle 0x10181c46 */
            ii(0x1018_1c41, 3); mov(memd_a32[ds, esi + 0x8], eax);      /* mov [esi+0x8], eax */
            ii(0x1018_1c44, 2); jmpd(0x1018_1c4d, 0x7); goto l_0x1018_1c4d; /* jmp 0x10181c4d */
        l_0x1018_1c46:
            ii(0x1018_1c46, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_1c48, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1018_1c4a, 3); mov(memd_a32[ds, esi + 0xc], ebx);      /* mov [esi+0xc], ebx */
        l_0x1018_1c4d:
            ii(0x1018_1c4d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1c4f, 3); mov(dl, memb_a32[ds, esi + 0x16]);      /* mov dl, [esi+0x16] */
            ii(0x1018_1c52, 3); cmp(edx, 0x2a);                         /* cmp edx, 0x2a */
            ii(0x1018_1c55, 2); if(jnzd(0x1018_1c64, 0xd)) goto l_0x1018_1c64; /* jnz 0x10181c64 */
            ii(0x1018_1c57, 3); mov(dl, memb_a32[ds, esi + 0x14]);      /* mov dl, [esi+0x14] */
            ii(0x1018_1c5a, 4); mov(memb_a32[ds, esi + 0x17], 0);       /* mov byte [esi+0x17], 0x0 */
            ii(0x1018_1c5e, 3); and(dl, 0xf9);                          /* and dl, 0xf9 */
            ii(0x1018_1c61, 3); mov(memb_a32[ds, esi + 0x14], dl);      /* mov [esi+0x14], dl */
        l_0x1018_1c64:
            ii(0x1018_1c64, 3); mov(ebx, memd_a32[ds, esi + 0x8]);      /* mov ebx, [esi+0x8] */
            ii(0x1018_1c67, 3); cmp(ebx, -0x1 /* 0xff */);              /* cmp ebx, 0xffffffff */
            ii(0x1018_1c6a, 2); if(jzd(0x1018_1c70, 0x4)) goto l_0x1018_1c70; /* jz 0x10181c70 */
            ii(0x1018_1c6c, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1018_1c6e, 2); if(jged(0x1018_1c7d, 0xd)) goto l_0x1018_1c7d; /* jge 0x10181c7d */
        l_0x1018_1c70:
            ii(0x1018_1c70, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1c72, 3); mov(dl, memb_a32[ds, esi + 0x15]);      /* mov dl, [esi+0x15] */
            ii(0x1018_1c75, 3); cmp(edx, 0x63);                         /* cmp edx, 0x63 */
            ii(0x1018_1c78, 2); if(jzd(0x1018_1c7d, 0x3)) goto l_0x1018_1c7d; /* jz 0x10181c7d */
            ii(0x1018_1c7a, 3); mov(memd_a32[ds, esi + 0x8], eax);      /* mov [esi+0x8], eax */
        l_0x1018_1c7d:
            ii(0x1018_1c7d, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1018_1c82, 3); lea(eax, esi + 0x17);                   /* lea eax, [esi+0x17] */
            ii(0x1018_1c85, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1018_1c87, 5); calld(/* sys */ 0x1018_1620, -0x66c);   /* call 0x10181620 */
            ii(0x1018_1c8c, 3); mov(ebp, memd_a32[ds, esi + 0x8]);      /* mov ebp, [esi+0x8] */
            ii(0x1018_1c8f, 3); mov(edx, memd_a32[ds, esi + 0xc]);      /* mov edx, [esi+0xc] */
            ii(0x1018_1c92, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1018_1c94, 3); mov(ebx, memd_a32[ds, esi + 0x4]);      /* mov ebx, [esi+0x4] */
            ii(0x1018_1c97, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_1c99, 2); mov(edx, es);                           /* mov edx, es */
            ii(0x1018_1c9b, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1018_1c9d, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_1c9f, 3); mov(memd_a32[ds, esi + 0x4], ebx);      /* mov [esi+0x4], ebx */
            ii(0x1018_1ca2, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1018_1ca5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_1ca6, 1); popd(es);                               /* pop es */
            ii(0x1018_1ca7, 1); popd(edi);                              /* pop edi */
            ii(0x1018_1ca8, 1); popd(esi);                              /* pop esi */
            ii(0x1018_1ca9, 1); retd(); return;                         /* ret */
        }
    }
}
