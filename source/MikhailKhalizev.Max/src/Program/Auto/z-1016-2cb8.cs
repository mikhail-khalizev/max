using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_2cb8-e973e68e")]
        public void Method_1016_2cb8()
        {
            ii(0x1016_2cb8, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1016_2cbd, 5); calld(Definitions.sys_check_available_stack_size, 0x3090); /* call 0x10165d52 */
            ii(0x1016_2cc2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_2cc3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_2cc4, 1); pushd(edx);                             /* push edx */
            ii(0x1016_2cc5, 1); pushd(esi);                             /* push esi */
            ii(0x1016_2cc6, 1); pushd(edi);                             /* push edi */
            ii(0x1016_2cc7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_2cc8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_2cca, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_2cd0, 7); mov(memb_a32[ds, 0x101c_947c], 0x5);    /* mov byte [0x101c947c], 0x5 */
            ii(0x1016_2cd7, 5); calld(0x100a_8d0c, -0xb_9fd0);          /* call 0x100a8d0c */
            ii(0x1016_2cdc, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1016_2ce3, 2); jmpd(0x1016_2ceb, 0x6); goto l_0x1016_2ceb; /* jmp 0x10162ceb */
        l_0x1016_2ce5:
            ii(0x1016_2ce5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2ce8, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x1016_2ceb:
            ii(0x1016_2ceb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2cef, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1016_2cf2, 2); if(jged(0x1016_2d0b, 0x17)) goto l_0x1016_2d0b; /* jge 0x10162d0b */
            ii(0x1016_2cf4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2cf6, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_2cfa, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_2cfd, 5); mov(ebx, 0x101c_94b4);                  /* mov ebx, 0x101c94b4 */
            ii(0x1016_2d02, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_2d04, 5); calld(0x1007_6630, -0xe_c6d9);          /* call 0x10076630 */
            ii(0x1016_2d09, 2); jmpd(0x1016_2ce5, -0x26); goto l_0x1016_2ce5; /* jmp 0x10162ce5 */
        l_0x1016_2d0b:
            ii(0x1016_2d0b, 7); mov(memb_a32[ds, 0x101c_9447], 0);      /* mov byte [0x101c9447], 0x0 */
            ii(0x1016_2d12, 7); mov(memb_a32[ds, 0x101c_9448], 0);      /* mov byte [0x101c9448], 0x0 */
            ii(0x1016_2d19, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1016_2d1e, 5); calld(0x1016_29b0, -0x373);             /* call 0x101629b0 */
            ii(0x1016_2d23, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1016_2d28, 5); calld(0x1016_29b0, -0x37d);             /* call 0x101629b0 */
            ii(0x1016_2d2d, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1016_2d32, 5); calld(0x1016_29b0, -0x387);             /* call 0x101629b0 */
            ii(0x1016_2d37, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1016_2d3c, 5); calld(0x1016_29b0, -0x391);             /* call 0x101629b0 */
            ii(0x1016_2d41, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1016_2d46, 5); calld(0x1016_29b0, -0x39b);             /* call 0x101629b0 */
            ii(0x1016_2d4b, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1016_2d52, 2); if(jzd(0x1016_2d59, 0x5)) goto l_0x1016_2d59; /* jz 0x10162d59 */
            ii(0x1016_2d54, 5); calld(0x1012_8602, -0x3_a757);          /* call 0x10128602 */
        l_0x1016_2d59:
            ii(0x1016_2d59, 7); cmp(memb_a32[ds, 0x101c_9447], 0);      /* cmp byte [0x101c9447], 0x0 */
            ii(0x1016_2d60, 6); if(jnzd(0x1016_2e6d, 0x107)) goto l_0x1016_2e6d; /* jnz 0x10162e6d */
            ii(0x1016_2d66, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1016_2d6b, 5); calld(0x1007_6b90, -0xe_c1e0);          /* call 0x10076b90 */
            ii(0x1016_2d70, 1); cwde();                                 /* cwde */
            ii(0x1016_2d71, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_2d73, 2); if(jnzd(0x1016_2d97, 0x22)) goto l_0x1016_2d97; /* jnz 0x10162d97 */
            ii(0x1016_2d75, 5); calld(0x1015_e3c6, -0x49b4);            /* call 0x1015e3c6 */
            ii(0x1016_2d7a, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2d7c, 2); if(jnzd(0x1016_2d92, 0x14)) goto l_0x1016_2d92; /* jnz 0x10162d92 */
            ii(0x1016_2d7e, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1016_2d83, 5); calld(0x1016_2a15, -0x373);             /* call 0x10162a15 */
            ii(0x1016_2d88, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1016_2d8d, 5); calld(0x1016_2a15, -0x37d);             /* call 0x10162a15 */
        l_0x1016_2d92:
            ii(0x1016_2d92, 5); jmpd(0x1016_2e6d, 0xd6); goto l_0x1016_2e6d; /* jmp 0x10162e6d */
        l_0x1016_2d97:
            ii(0x1016_2d97, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1016_2d9c, 5); calld(0x1007_6338, -0xe_ca69);          /* call 0x10076338 */
            ii(0x1016_2da1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_2da3, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2da6, 5); calld(0x1007_64b8, -0xe_c8f3);          /* call 0x100764b8 */
            ii(0x1016_2dab, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2dae, 5); calld(0x1007_63a0, -0xe_ca13);          /* call 0x100763a0 */
            ii(0x1016_2db3, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x1016_2db6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_2dbb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_2dbd, 2); if(jled(0x1016_2dd0, 0x11)) goto l_0x1016_2dd0; /* jle 0x10162dd0 */
            ii(0x1016_2dbf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2dc2, 5); calld(0x1007_63a0, -0xe_ca27);          /* call 0x100763a0 */
            ii(0x1016_2dc7, 4); mov(memb_a32[ds, eax + 0x3e], 0x29);    /* mov byte [eax+0x3e], 0x29 */
            ii(0x1016_2dcb, 5); jmpd(0x1016_2e4f, 0x7f); goto l_0x1016_2e4f; /* jmp 0x10162e4f */
        l_0x1016_2dd0:
            ii(0x1016_2dd0, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1016_2dd5, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2dd8, 5); calld(0x1007_63a0, -0xe_ca3d);          /* call 0x100763a0 */
            ii(0x1016_2ddd, 3); mov(ebx, memd_a32[ds, eax + 0x41]);     /* mov ebx, [eax+0x41] */
            ii(0x1016_2de0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_2de3, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2de6, 5); calld(0x1007_63a0, -0xe_ca4b);          /* call 0x100763a0 */
            ii(0x1016_2deb, 3); mov(edx, memd_a32[ds, eax + 0x3f]);     /* mov edx, [eax+0x3f] */
            ii(0x1016_2dee, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_2df1, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2df4, 5); calld(0x1007_63a0, -0xe_ca59);          /* call 0x100763a0 */
            ii(0x1016_2df9, 5); calld(0x1014_e906, -0x1_44f8);          /* call 0x1014e906 */
            ii(0x1016_2dfe, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2e01, 5); calld(0x1007_63a0, -0xe_ca66);          /* call 0x100763a0 */
            ii(0x1016_2e06, 5); calld(0x1014_f08b, -0x1_3d80);          /* call 0x1014f08b */
            ii(0x1016_2e0b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2e0e, 5); calld(0x1007_63a0, -0xe_ca73);          /* call 0x100763a0 */
            ii(0x1016_2e13, 4); cmp(memb_a32[ds, eax + 0x3d], 0x3);     /* cmp byte [eax+0x3d], 0x3 */
            ii(0x1016_2e17, 2); if(jnzd(0x1016_2e31, 0x18)) goto l_0x1016_2e31; /* jnz 0x10162e31 */
            ii(0x1016_2e19, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2e1c, 5); calld(0x1007_63a0, -0xe_ca81);          /* call 0x100763a0 */
            ii(0x1016_2e21, 4); mov(memb_a32[ds, eax + 0x3d], 0);       /* mov byte [eax+0x3d], 0x0 */
            ii(0x1016_2e25, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2e28, 5); calld(0x1007_63a0, -0xe_ca8d);          /* call 0x100763a0 */
            ii(0x1016_2e2d, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
        l_0x1016_2e31:
            ii(0x1016_2e31, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_2e36, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2e39, 5); calld(0x1008_b530, -0xd_790e);          /* call 0x1008b530 */
            ii(0x1016_2e3e, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2e40, 2); if(jzd(0x1016_2e4f, 0xd)) goto l_0x1016_2e4f; /* jz 0x10162e4f */
            ii(0x1016_2e42, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2e45, 5); calld(0x1007_63d4, -0xe_ca76);          /* call 0x100763d4 */
            ii(0x1016_2e4a, 5); calld(0x1010_094d, -0x6_2502);          /* call 0x1010094d */
        l_0x1016_2e4f:
            ii(0x1016_2e4f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2e52, 5); calld(0x1007_6408, -0xe_ca4f);          /* call 0x10076408 */
            ii(0x1016_2e57, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_2e59, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1016_2e5e, 5); calld(0x1008_aab4, -0xd_83af);          /* call 0x1008aab4 */
            ii(0x1016_2e63, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2e65, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1016_2e68, 5); calld(0x1007_5f6c, -0xe_cf01);          /* call 0x10075f6c */
        l_0x1016_2e6d:
            ii(0x1016_2e6d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2e6f, 5); mov(eax, 0x101c_9478);                  /* mov eax, 0x101c9478 */
            ii(0x1016_2e74, 5); calld(0x1013_ad71, -0x2_8108);          /* call 0x1013ad71 */
            ii(0x1016_2e79, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2e7b, 2); if(jzd(0x1016_2e9c, 0x1f)) goto l_0x1016_2e9c; /* jz 0x10162e9c */
            ii(0x1016_2e7d, 5); mov(eax, 0x101c_9478);                  /* mov eax, 0x101c9478 */
            ii(0x1016_2e82, 5); calld(0x1007_65d0, -0xe_c8b7);          /* call 0x100765d0 */
            ii(0x1016_2e87, 5); calld(0x1007_5a79, -0xe_d413);          /* call 0x10075a79 */
            ii(0x1016_2e8c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_2e8e, 2); if(jzd(0x1016_2e9c, 0xc)) goto l_0x1016_2e9c; /* jz 0x10162e9c */
            ii(0x1016_2e90, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2e92, 5); mov(eax, 0x101c_9478);                  /* mov eax, 0x101c9478 */
            ii(0x1016_2e97, 5); calld(0x1007_6630, -0xe_c86c);          /* call 0x10076630 */
        l_0x1016_2e9c:
            ii(0x1016_2e9c, 5); mov(eax, 0x101c_813c);                  /* mov eax, 0x101c813c */
            ii(0x1016_2ea1, 5); calld(0x1016_4aa0, 0x1bfa);             /* call 0x10164aa0 */
            ii(0x1016_2ea6, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1016_2ea9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_2eab, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_2ead, 5); calld(0x1016_4a1c, 0x1b6a);             /* call 0x10164a1c */
            ii(0x1016_2eb2, 2); jmpd(0x1016_2ebc, 0x8); goto l_0x1016_2ebc; /* jmp 0x10162ebc */
        l_0x1016_2eb4:
            ii(0x1016_2eb4, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2eb7, 5); calld(0x1007_6bf8, -0xe_c2c4);          /* call 0x10076bf8 */
        l_0x1016_2ebc:
            ii(0x1016_2ebc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2ebe, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2ec1, 5); calld(0x1013_ad71, -0x2_8155);          /* call 0x1013ad71 */
            ii(0x1016_2ec6, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2ec8, 2); if(jzd(0x1016_2ee3, 0x19)) goto l_0x1016_2ee3; /* jz 0x10162ee3 */
            ii(0x1016_2eca, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2ecd, 5); calld(0x1016_49a4, 0x1ad2);             /* call 0x101649a4 */
            ii(0x1016_2ed2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_2ed5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_2ed8, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1016_2edb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1016_2ede, 3); calld_abs(memd_a32[ds, edx + 0x4]);     /* call dword [edx+0x4] */
            ii(0x1016_2ee1, 2); jmpd(0x1016_2eb4, -0x2f); goto l_0x1016_2eb4; /* jmp 0x10162eb4 */
        l_0x1016_2ee3:
            ii(0x1016_2ee3, 5); mov(eax, 0x101c_813c);                  /* mov eax, 0x101c813c */
            ii(0x1016_2ee8, 5); calld(0x1013_a6f4, -0x2_87f9);          /* call 0x1013a6f4 */
            ii(0x1016_2eed, 5); mov(al, memb_a32[ds, 0x101c_947c]);     /* mov al, [0x101c947c] */
            ii(0x1016_2ef2, 5); mov(memb_a32[ds, 0x101c_947d], al);     /* mov [0x101c947d], al */
            ii(0x1016_2ef7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_2ef9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_2efc, 5); calld(0x1016_4620, 0x171f);             /* call 0x10164620 */
            ii(0x1016_2f01, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_2f03, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_2f04, 1); popd(edi);                              /* pop edi */
            ii(0x1016_2f05, 1); popd(esi);                              /* pop esi */
            ii(0x1016_2f06, 1); popd(edx);                              /* pop edx */
            ii(0x1016_2f07, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_2f08, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_2f09, 1); retd(); return;                         /* ret */
        }
    }
}
