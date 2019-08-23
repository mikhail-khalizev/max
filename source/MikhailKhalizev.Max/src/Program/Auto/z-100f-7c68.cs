using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_7c68-90753f86")]
        public void Method_100f_7c68()
        {
            ii(0x100f_7c68, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100f_7c6d, 5); calld(Definitions.sys_check_available_stack_size, 0x6_e0e0); /* call 0x10165d52 */
            ii(0x100f_7c72, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_7c73, 1); pushd(esi);                             /* push esi */
            ii(0x100f_7c74, 1); pushd(edi);                             /* push edi */
            ii(0x100f_7c75, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_7c76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_7c78, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100f_7c7e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_7c81, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100f_7c84, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100f_7c87, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7c8c, 5); calld(0x1007_6574, -0x8_171d);          /* call 0x10076574 */
            ii(0x100f_7c91, 4); cmp(memb_a32[ds, eax + 0x59], 0);       /* cmp byte [eax+0x59], 0x0 */
            ii(0x100f_7c95, 2); if(jzd(0x100f_7ca0, 0x9)) goto l_0x100f_7ca0; /* jz 0x100f7ca0 */
            ii(0x100f_7c97, 4); mov(memb_a32[ss, ebp - 0x10], 0x15);    /* mov byte [ebp-0x10], 0x15 */
            ii(0x100f_7c9b, 5); jmpd(0x100f_7ecc, 0x22c); goto l_0x100f_7ecc; /* jmp 0x100f7ecc */
        l_0x100f_7ca0:
            ii(0x100f_7ca0, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7ca5, 5); calld(0x1007_6574, -0x8_1736);          /* call 0x10076574 */
            ii(0x100f_7caa, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x100f_7caf, 2); if(jzd(0x100f_7cf2, 0x41)) goto l_0x100f_7cf2; /* jz 0x100f7cf2 */
            ii(0x100f_7cb1, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7cb6, 5); calld(0x1007_6574, -0x8_1747);          /* call 0x10076574 */
            ii(0x100f_7cbb, 3); mov(al, memb_a32[ds, eax + 0x61]);      /* mov al, [eax+0x61] */
            ii(0x100f_7cbe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_7cc3, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_7cc6, 2); if(jnzd(0x100f_7ced, 0x25)) goto l_0x100f_7ced; /* jnz 0x100f7ced */
            ii(0x100f_7cc8, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7ccd, 5); calld(0x1007_6574, -0x8_175e);          /* call 0x10076574 */
            ii(0x100f_7cd2, 4); cmp(memb_a32[ds, eax + 0x54], 0);       /* cmp byte [eax+0x54], 0x0 */
            ii(0x100f_7cd6, 2); if(jnzd(0x100f_7ceb, 0x13)) goto l_0x100f_7ceb; /* jnz 0x100f7ceb */
            ii(0x100f_7cd8, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7cdd, 5); calld(0x1007_6574, -0x8_176e);          /* call 0x10076574 */
            ii(0x100f_7ce2, 5); calld(0x1007_61d4, -0x8_1b13);          /* call 0x100761d4 */
            ii(0x100f_7ce7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_7ce9, 2); if(jzd(0x100f_7ced, 0x2)) goto l_0x100f_7ced; /* jz 0x100f7ced */
        l_0x100f_7ceb:
            ii(0x100f_7ceb, 2); jmpd(0x100f_7cf2, 0x5); goto l_0x100f_7cf2; /* jmp 0x100f7cf2 */
        l_0x100f_7ced:
            ii(0x100f_7ced, 5); jmpd(0x100f_7ec8, 0x1d6); goto l_0x100f_7ec8; /* jmp 0x100f7ec8 */
        l_0x100f_7cf2:
            ii(0x100f_7cf2, 5); calld(0x1007_6034, -0x8_1cc3);          /* call 0x10076034 */
            ii(0x100f_7cf7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_7cf9, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_7cfb, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_7cff, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_7d03, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7d08, 5); calld(0x1008_abbc, -0x6_d151);          /* call 0x1008abbc */
            ii(0x100f_7d0d, 5); calld(0x1007_4c30, -0x8_30e2);          /* call 0x10074c30 */
            ii(0x100f_7d12, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_7d15, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_7d19, 2); if(jnzd(0x100f_7d24, 0x9)) goto l_0x100f_7d24; /* jnz 0x100f7d24 */
            ii(0x100f_7d1b, 4); mov(memb_a32[ss, ebp - 0x10], 0x15);    /* mov byte [ebp-0x10], 0x15 */
            ii(0x100f_7d1f, 5); jmpd(0x100f_7ecc, 0x1a8); goto l_0x100f_7ecc; /* jmp 0x100f7ecc */
        l_0x100f_7d24:
            ii(0x100f_7d24, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7d29, 5); calld(0x1007_6574, -0x8_17ba);          /* call 0x10076574 */
            ii(0x100f_7d2e, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x100f_7d33, 2); if(jnzd(0x100f_7d45, 0x10)) goto l_0x100f_7d45; /* jnz 0x100f7d45 */
            ii(0x100f_7d35, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7d3a, 5); calld(0x1007_6574, -0x8_17cb);          /* call 0x10076574 */
            ii(0x100f_7d3f, 4); cmp(memb_a32[ds, eax + 0x55], 0);       /* cmp byte [eax+0x55], 0x0 */
            ii(0x100f_7d43, 2); if(jzd(0x100f_7d4a, 0x5)) goto l_0x100f_7d4a; /* jz 0x100f7d4a */
        l_0x100f_7d45:
            ii(0x100f_7d45, 5); jmpd(0x100f_7df8, 0xae); goto l_0x100f_7df8; /* jmp 0x100f7df8 */
        l_0x100f_7d4a:
            ii(0x100f_7d4a, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_7d4e, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_7d52, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7d57, 5); calld(0x1007_65d0, -0x8_178c);          /* call 0x100765d0 */
            ii(0x100f_7d5c, 5); calld(0x100f_1f41, -0x5e20);            /* call 0x100f1f41 */
            ii(0x100f_7d61, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_7d63, 2); if(jzd(0x100f_7d71, 0xc)) goto l_0x100f_7d71; /* jz 0x100f7d71 */
            ii(0x100f_7d65, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_7d68, 5); calld(0x100f_73f7, -0x976);             /* call 0x100f73f7 */
            ii(0x100f_7d6d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_7d6f, 2); if(jnzd(0x100f_7d76, 0x5)) goto l_0x100f_7d76; /* jnz 0x100f7d76 */
        l_0x100f_7d71:
            ii(0x100f_7d71, 5); jmpd(0x100f_7df8, 0x82); goto l_0x100f_7df8; /* jmp 0x100f7df8 */
        l_0x100f_7d76:
            ii(0x100f_7d76, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7d7b, 5); calld(0x1007_6574, -0x8_180c);          /* call 0x10076574 */
            ii(0x100f_7d80, 4); cmp(memb_a32[ds, eax + 0x57], 0x9);     /* cmp byte [eax+0x57], 0x9 */
            ii(0x100f_7d84, 2); if(jzd(0x100f_7d96, 0x10)) goto l_0x100f_7d96; /* jz 0x100f7d96 */
            ii(0x100f_7d86, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7d8b, 5); calld(0x1007_6574, -0x8_181c);          /* call 0x10076574 */
            ii(0x100f_7d90, 4); cmp(memb_a32[ds, eax + 0x57], 0);       /* cmp byte [eax+0x57], 0x0 */
            ii(0x100f_7d94, 2); if(jnzd(0x100f_7dac, 0x16)) goto l_0x100f_7dac; /* jnz 0x100f7dac */
        l_0x100f_7d96:
            ii(0x100f_7d96, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100f_7d99, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7d9e, 5); calld(0x1007_65d0, -0x8_17d3);          /* call 0x100765d0 */
            ii(0x100f_7da3, 5); calld(0x100f_7bd5, -0x1d3);             /* call 0x100f7bd5 */
            ii(0x100f_7da8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_7daa, 2); if(jnzd(0x100f_7dae, 0x2)) goto l_0x100f_7dae; /* jnz 0x100f7dae */
        l_0x100f_7dac:
            ii(0x100f_7dac, 2); jmpd(0x100f_7db7, 0x9); goto l_0x100f_7db7; /* jmp 0x100f7db7 */
        l_0x100f_7dae:
            ii(0x100f_7dae, 4); mov(memb_a32[ss, ebp - 0x10], 0x1b);    /* mov byte [ebp-0x10], 0x1b */
            ii(0x100f_7db2, 5); jmpd(0x100f_7ecc, 0x115); goto l_0x100f_7ecc; /* jmp 0x100f7ecc */
        l_0x100f_7db7:
            ii(0x100f_7db7, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7dbc, 5); calld(0x1007_6574, -0x8_184d);          /* call 0x10076574 */
            ii(0x100f_7dc1, 4); cmp(memb_a32[ds, eax + 0x57], 0x8);     /* cmp byte [eax+0x57], 0x8 */
            ii(0x100f_7dc5, 2); if(jzd(0x100f_7dd7, 0x10)) goto l_0x100f_7dd7; /* jz 0x100f7dd7 */
            ii(0x100f_7dc7, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7dcc, 5); calld(0x1007_6574, -0x8_185d);          /* call 0x10076574 */
            ii(0x100f_7dd1, 4); cmp(memb_a32[ds, eax + 0x57], 0);       /* cmp byte [eax+0x57], 0x0 */
            ii(0x100f_7dd5, 2); if(jnzd(0x100f_7ded, 0x16)) goto l_0x100f_7ded; /* jnz 0x100f7ded */
        l_0x100f_7dd7:
            ii(0x100f_7dd7, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100f_7dda, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7ddf, 5); calld(0x1007_65d0, -0x8_1814);          /* call 0x100765d0 */
            ii(0x100f_7de4, 5); calld(0x100f_7b0b, -0x2de);             /* call 0x100f7b0b */
            ii(0x100f_7de9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_7deb, 2); if(jnzd(0x100f_7def, 0x2)) goto l_0x100f_7def; /* jnz 0x100f7def */
        l_0x100f_7ded:
            ii(0x100f_7ded, 2); jmpd(0x100f_7df8, 0x9); goto l_0x100f_7df8; /* jmp 0x100f7df8 */
        l_0x100f_7def:
            ii(0x100f_7def, 4); mov(memb_a32[ss, ebp - 0x10], 0x1a);    /* mov byte [ebp-0x10], 0x1a */
            ii(0x100f_7df3, 5); jmpd(0x100f_7ecc, 0xd4); goto l_0x100f_7ecc; /* jmp 0x100f7ecc */
        l_0x100f_7df8:
            ii(0x100f_7df8, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7dfd, 5); calld(0x1007_6574, -0x8_188e);          /* call 0x10076574 */
            ii(0x100f_7e02, 3); mov(al, memb_a32[ds, eax + 0x61]);      /* mov al, [eax+0x61] */
            ii(0x100f_7e05, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_7e0a, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_7e0d, 2); if(jnzd(0x100f_7e34, 0x25)) goto l_0x100f_7e34; /* jnz 0x100f7e34 */
            ii(0x100f_7e0f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7e14, 5); calld(0x1007_6574, -0x8_18a5);          /* call 0x10076574 */
            ii(0x100f_7e19, 4); cmp(memb_a32[ds, eax + 0x54], 0);       /* cmp byte [eax+0x54], 0x0 */
            ii(0x100f_7e1d, 2); if(jnzd(0x100f_7e32, 0x13)) goto l_0x100f_7e32; /* jnz 0x100f7e32 */
            ii(0x100f_7e1f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7e24, 5); calld(0x1007_6574, -0x8_18b5);          /* call 0x10076574 */
            ii(0x100f_7e29, 5); calld(0x1007_61d4, -0x8_1c5a);          /* call 0x100761d4 */
            ii(0x100f_7e2e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_7e30, 2); if(jzd(0x100f_7e34, 0x2)) goto l_0x100f_7e34; /* jz 0x100f7e34 */
        l_0x100f_7e32:
            ii(0x100f_7e32, 2); jmpd(0x100f_7e39, 0x5); goto l_0x100f_7e39; /* jmp 0x100f7e39 */
        l_0x100f_7e34:
            ii(0x100f_7e34, 5); jmpd(0x100f_7ec8, 0x8f); goto l_0x100f_7ec8; /* jmp 0x100f7ec8 */
        l_0x100f_7e39:
            ii(0x100f_7e39, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7e3e, 5); calld(0x1007_6574, -0x8_18cf);          /* call 0x10076574 */
            ii(0x100f_7e43, 5); calld(0x1007_623c, -0x8_1c0c);          /* call 0x1007623c */
            ii(0x100f_7e48, 3); mov(ecx, memd_a32[ds, eax + 0x10]);     /* mov ecx, [eax+0x10] */
            ii(0x100f_7e4b, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_7e4e, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_7e52, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_7e56, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7e5b, 5); calld(0x1007_65d0, -0x8_1890);          /* call 0x100765d0 */
            ii(0x100f_7e60, 5); calld(0x1007_0d68, -0x8_70fd);          /* call 0x10070d68 */
            ii(0x100f_7e65, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x100f_7e68, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x100f_7e6c, 2); if(jzd(0x100f_7e8a, 0x1c)) goto l_0x100f_7e8a; /* jz 0x100f7e8a */
            ii(0x100f_7e6e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7e73, 5); calld(0x1007_6574, -0x8_1904);          /* call 0x10076574 */
            ii(0x100f_7e78, 4); cmp(memb_a32[ds, eax + 0x54], 0);       /* cmp byte [eax+0x54], 0x0 */
            ii(0x100f_7e7c, 2); if(jzd(0x100f_7e84, 0x6)) goto l_0x100f_7e84; /* jz 0x100f7e84 */
            ii(0x100f_7e7e, 4); mov(memb_a32[ss, ebp - 0x14], 0x12);    /* mov byte [ebp-0x14], 0x12 */
            ii(0x100f_7e82, 2); jmpd(0x100f_7e88, 0x4); goto l_0x100f_7e88; /* jmp 0x100f7e88 */
        l_0x100f_7e84:
            ii(0x100f_7e84, 4); mov(memb_a32[ss, ebp - 0x14], 0x15);    /* mov byte [ebp-0x14], 0x15 */
        l_0x100f_7e88:
            ii(0x100f_7e88, 2); jmpd(0x100f_7ea4, 0x1a); goto l_0x100f_7ea4; /* jmp 0x100f7ea4 */
        l_0x100f_7e8a:
            ii(0x100f_7e8a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7e8f, 5); calld(0x1007_6574, -0x8_1920);          /* call 0x10076574 */
            ii(0x100f_7e94, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100f_7e98, 2); if(jzd(0x100f_7ea0, 0x6)) goto l_0x100f_7ea0; /* jz 0x100f7ea0 */
            ii(0x100f_7e9a, 4); mov(memb_a32[ss, ebp - 0x14], 0x15);    /* mov byte [ebp-0x14], 0x15 */
            ii(0x100f_7e9e, 2); jmpd(0x100f_7ea4, 0x4); goto l_0x100f_7ea4; /* jmp 0x100f7ea4 */
        l_0x100f_7ea0:
            ii(0x100f_7ea0, 4); mov(memb_a32[ss, ebp - 0x14], 0x13);    /* mov byte [ebp-0x14], 0x13 */
        l_0x100f_7ea4:
            ii(0x100f_7ea4, 4); cmp(memb_a32[ss, ebp - 0x14], 0x15);    /* cmp byte [ebp-0x14], 0x15 */
            ii(0x100f_7ea8, 2); if(jzd(0x100f_7ec0, 0x16)) goto l_0x100f_7ec0; /* jz 0x100f7ec0 */
            ii(0x100f_7eaa, 4); movsx(ebx, memb_a32[ss, ebp - 0x14]);   /* movsx ebx, byte [ebp-0x14] */
            ii(0x100f_7eae, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100f_7eb1, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_7eb6, 5); calld(0x1007_65d0, -0x8_18eb);          /* call 0x100765d0 */
            ii(0x100f_7ebb, 5); calld(0x1012_1078, 0x2_91b8);           /* call 0x10121078 */
        l_0x100f_7ec0:
            ii(0x100f_7ec0, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_7ec3, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100f_7ec6, 2); jmpd(0x100f_7ecc, 0x4); goto l_0x100f_7ecc; /* jmp 0x100f7ecc */
        l_0x100f_7ec8:
            ii(0x100f_7ec8, 4); mov(memb_a32[ss, ebp - 0x10], 0x15);    /* mov byte [ebp-0x10], 0x15 */
        l_0x100f_7ecc:
            ii(0x100f_7ecc, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100f_7ecf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_7ed1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_7ed2, 1); popd(edi);                              /* pop edi */
            ii(0x100f_7ed3, 1); popd(esi);                              /* pop esi */
            ii(0x100f_7ed4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_7ed5, 1); retd();                                 /* ret */
        }
    }
}
