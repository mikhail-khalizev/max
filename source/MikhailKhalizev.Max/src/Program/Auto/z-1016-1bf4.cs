using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_1bf4-8fcb0a34")]
        public void Method_1016_1bf4()
        {
            ii(0x1016_1bf4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1bf7, 4); cmp(memb_a32[ds, eax + 0x3e], 0x7);     /* cmp byte [eax+0x3e], 0x7 */
            ii(0x1016_1bfb, 2); if(jnzd(0x1016_1c0c, 0xf)) goto l_0x1016_1c0c; /* jnz 0x10161c0c */
            ii(0x1016_1bfd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c00, 5); calld(0x1015_48ba, -0xd34b);            /* call 0x101548ba */
            ii(0x1016_1c05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c08, 4); mov(memb_a32[ds, eax + 0x3e], 0x5);     /* mov byte [eax+0x3e], 0x5 */
        l_0x1016_1c0c:
            ii(0x1016_1c0c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c0f, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1016_1c12, 3); mov(memb_a32[ss, ebp - 0x1c], al);      /* mov [ebp-0x1c], al */
            ii(0x1016_1c15, 5); jmpd(0x1016_1e15, 0x1fb); goto l_0x1016_1e15; /* jmp 0x10161e15 */
        l_0x1016_1c1a:
            ii(0x1016_1c1a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_1c1c, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1016_1c21, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_1c24, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c27, 5); calld(0x1007_6074, -0xe_bbb8);          /* call 0x10076074 */
            ii(0x1016_1c2c, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1c2e, 2); if(jzd(0x1016_1c5a, 0x2a)) goto l_0x1016_1c5a; /* jz 0x10161c5a */
            ii(0x1016_1c30, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1c35, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c38, 5); calld(0x1007_6d98, -0xe_aea5);          /* call 0x10076d98 */
            ii(0x1016_1c3d, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1c3f, 2); if(jnzd(0x1016_1c4a, 0x9)) goto l_0x1016_1c4a; /* jnz 0x10161c4a */
            ii(0x1016_1c41, 7); cmp(memb_a32[ds, 0x101c_3889], 0);      /* cmp byte [0x101c3889], 0x0 */
            ii(0x1016_1c48, 2); if(jzd(0x1016_1c4c, 0x2)) goto l_0x1016_1c4c; /* jz 0x10161c4c */
        l_0x1016_1c4a:
            ii(0x1016_1c4a, 2); jmpd(0x1016_1c55, 0x9); goto l_0x1016_1c55; /* jmp 0x10161c55 */
        l_0x1016_1c4c:
            ii(0x1016_1c4c, 7); cmp(memb_a32[ds, 0x101c_388a], 0);      /* cmp byte [0x101c388a], 0x0 */
            ii(0x1016_1c53, 2); if(jzd(0x1016_1c5a, 0x5)) goto l_0x1016_1c5a; /* jz 0x10161c5a */
        l_0x1016_1c55:
            ii(0x1016_1c55, 5); calld(0x100f_f5c1, -0x6_2699);          /* call 0x100ff5c1 */
        l_0x1016_1c5a:
            ii(0x1016_1c5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c5d, 5); calld(0x1016_0283, -0x19df);            /* call 0x10160283 */
            ii(0x1016_1c62, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1c64, 6); if(jzd(0x1016_1ebf, 0x255)) goto l_0x1016_1ebf; /* jz 0x10161ebf */
        l_0x1016_1c6a:
            ii(0x1016_1c6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c6d, 5); calld(0x1014_ac97, -0x1_6fdb);          /* call 0x1014ac97 */
            ii(0x1016_1c72, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1c74, 6); if(jzd(0x1016_1ebf, 0x245)) goto l_0x1016_1ebf; /* jz 0x10161ebf */
        l_0x1016_1c7a:
            ii(0x1016_1c7a, 5); mov(eax, StringDefinitions.Moving3);    /* mov eax, 0x101b28ec */
            ii(0x1016_1c7f, 5); calld(0x100a_8b4a, -0xb_913a);          /* call 0x100a8b4a */
            ii(0x1016_1c84, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c87, 5); calld(0x1014_af42, -0x1_6d4a);          /* call 0x1014af42 */
            ii(0x1016_1c8c, 5); jmpd(0x1016_1ebf, 0x22e); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1c91:
            ii(0x1016_1c91, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c94, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1016_1c98, 2); if(jzd(0x1016_1cd6, 0x3c)) goto l_0x1016_1cd6; /* jz 0x10161cd6 */
            ii(0x1016_1c9a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1c9d, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1016_1ca0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_1ca5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_1cab, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1016_1cb1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_1cb6, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1016_1cb9, 2); if(jnzd(0x1016_1cc7, 0xc)) goto l_0x1016_1cc7; /* jnz 0x10161cc7 */
            ii(0x1016_1cbb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1cbe, 5); calld(0x1007_61d4, -0xe_baef);          /* call 0x100761d4 */
            ii(0x1016_1cc3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1cc5, 2); if(jnzd(0x1016_1cc9, 0x2)) goto l_0x1016_1cc9; /* jnz 0x10161cc9 */
        l_0x1016_1cc7:
            ii(0x1016_1cc7, 2); jmpd(0x1016_1cd6, 0xd); goto l_0x1016_1cd6; /* jmp 0x10161cd6 */
        l_0x1016_1cc9:
            ii(0x1016_1cc9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_1ccc, 5); mov(eax, 0x101c_9478);                  /* mov eax, 0x101c9478 */
            ii(0x1016_1cd1, 5); calld(0x1007_6630, -0xe_b6a6);          /* call 0x10076630 */
        l_0x1016_1cd6:
            ii(0x1016_1cd6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1cd9, 5); calld(0x1015_dfe7, -0x3cf7);            /* call 0x1015dfe7 */
            ii(0x1016_1cde, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1ce0, 2); if(jnzd(0x1016_1cf2, 0x10)) goto l_0x1016_1cf2; /* jnz 0x10161cf2 */
            ii(0x1016_1ce2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1ce5, 5); calld(0x1016_18c2, -0x428);             /* call 0x101618c2 */
            ii(0x1016_1cea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1ced, 5); calld(0x1016_1499, -0x859);             /* call 0x10161499 */
        l_0x1016_1cf2:
            ii(0x1016_1cf2, 5); jmpd(0x1016_1ebf, 0x1c8); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1cf7:
            ii(0x1016_1cf7, 5); mov(eax, StringDefinitions.Storing);    /* mov eax, 0x101b28f3 */
            ii(0x1016_1cfc, 5); calld(0x100a_8b4a, -0xb_91b7);          /* call 0x100a8b4a */
            ii(0x1016_1d01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d04, 5); calld(0x1015_eb38, -0x31d1);            /* call 0x1015eb38 */
            ii(0x1016_1d09, 5); jmpd(0x1016_1ebf, 0x1b1); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1d0e:
            ii(0x1016_1d0e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d11, 5); calld(0x1012_0a5c, -0x4_12ba);          /* call 0x10120a5c */
            ii(0x1016_1d16, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1d18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d1b, 4); cmp(dx, memw_a32[ds, eax + 0x3b]);      /* cmp dx, [eax+0x3b] */
            ii(0x1016_1d1f, 2); if(jzd(0x1016_1d5d, 0x3c)) goto l_0x1016_1d5d; /* jz 0x10161d5d */
            ii(0x1016_1d21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d24, 5); calld(0x1015_2b8c, -0xf19d);            /* call 0x10152b8c */
            ii(0x1016_1d29, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1d2b, 2); if(jnzd(0x1016_1d47, 0x1a)) goto l_0x1016_1d47; /* jnz 0x10161d47 */
            ii(0x1016_1d2d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_1d30, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1016_1d35, 5); calld(0x1008_aab4, -0xd_7286);          /* call 0x1008aab4 */
            ii(0x1016_1d3a, 5); mov(edx, 0x40_4200);                    /* mov edx, 0x404200 */
            ii(0x1016_1d3f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d42, 5); calld(0x1014_a205, -0x1_7b42);          /* call 0x1014a205 */
        l_0x1016_1d47:
            ii(0x1016_1d47, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d4a, 5); calld(0x1012_0a5c, -0x4_12f3);          /* call 0x10120a5c */
            ii(0x1016_1d4f, 1); inc(eax);                               /* inc eax */
            ii(0x1016_1d50, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_1d53, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d56, 5); calld(0x1014_9b07, -0x1_8254);          /* call 0x10149b07 */
            ii(0x1016_1d5b, 2); jmpd(0x1016_1d6c, 0xf); goto l_0x1016_1d6c; /* jmp 0x10161d6c */
        l_0x1016_1d5d:
            ii(0x1016_1d5d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_1d62, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1d64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d67, 5); calld(0x1016_2f96, 0x122a);             /* call 0x10162f96 */
        l_0x1016_1d6c:
            ii(0x1016_1d6c, 5); jmpd(0x1016_1ebf, 0x14e); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1d71:
            ii(0x1016_1d71, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x1016_1d76, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d79, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1016_1d7c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_1d7f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d82, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1016_1d85, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_1d88, 5); calld(0x1007_36d8, -0xe_e6b5);          /* call 0x100736d8 */
            ii(0x1016_1d8d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1d8f, 2); if(jzd(0x1016_1da5, 0x14)) goto l_0x1016_1da5; /* jz 0x10161da5 */
            ii(0x1016_1d91, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1016_1d96, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1016_1d9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1d9e, 5); calld(0x1016_2f96, 0x11f3);             /* call 0x10162f96 */
            ii(0x1016_1da3, 2); jmpd(0x1016_1df2, 0x4d); goto l_0x1016_1df2; /* jmp 0x10161df2 */
        l_0x1016_1da5:
            ii(0x1016_1da5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1da8, 5); calld(0x1015_2b8c, -0xf221);            /* call 0x10152b8c */
            ii(0x1016_1dad, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1daf, 2); if(jzd(0x1016_1dc7, 0x16)) goto l_0x1016_1dc7; /* jz 0x10161dc7 */
            ii(0x1016_1db1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1db4, 5); calld(0x1012_0a5c, -0x4_135d);          /* call 0x10120a5c */
            ii(0x1016_1db9, 1); dec(eax);                               /* dec eax */
            ii(0x1016_1dba, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_1dbd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1dc0, 5); calld(0x1014_9b07, -0x1_82be);          /* call 0x10149b07 */
            ii(0x1016_1dc5, 2); jmpd(0x1016_1df2, 0x2b); goto l_0x1016_1df2; /* jmp 0x10161df2 */
        l_0x1016_1dc7:
            ii(0x1016_1dc7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_1dca, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1016_1dcf, 5); calld(0x1008_aab4, -0xd_7320);          /* call 0x1008aab4 */
            ii(0x1016_1dd4, 5); calld(0x1015_50bc, -0xcd1d);            /* call 0x101550bc */
            ii(0x1016_1dd9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1ddb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1dde, 5); calld(0x1014_a205, -0x1_7bde);          /* call 0x1014a205 */
            ii(0x1016_1de3, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_1de8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1dea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1ded, 5); calld(0x1016_2f96, 0x11a4);             /* call 0x10162f96 */
        l_0x1016_1df2:
            ii(0x1016_1df2, 5); jmpd(0x1016_1ebf, 0xc8); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1df7:
            ii(0x1016_1df7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1df9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1dfc, 5); calld(0x1007_60ac, -0xe_bd55);          /* call 0x100760ac */
            ii(0x1016_1e01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1e03, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1e06, 5); calld(0x1014_f017, -0x1_2df4);          /* call 0x1014f017 */
            ii(0x1016_1e0b, 5); jmpd(0x1016_1ebf, 0xaf); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1e10:
            ii(0x1016_1e10, 5); jmpd(0x1016_1ebf, 0xaa); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1e15:
            ii(0x1016_1e15, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x1016_1e18, 3); mov(memb_a32[ss, ebp - 0x20], al);      /* mov [ebp-0x20], al */
            ii(0x1016_1e1b, 4); cmp(memb_a32[ss, ebp - 0x20], 0xc);     /* cmp byte [ebp-0x20], 0xc */
            ii(0x1016_1e1f, 2); if(jbd(0x1016_1e6d, 0x4c)) goto l_0x1016_1e6d; /* jb 0x10161e6d */
            ii(0x1016_1e21, 4); cmp(memb_a32[ss, ebp - 0x20], 0xc);     /* cmp byte [ebp-0x20], 0xc */
            ii(0x1016_1e25, 2); if(jbed(0x1016_1df7, -0x30)) goto l_0x1016_1df7; /* jbe 0x10161df7 */
            ii(0x1016_1e27, 4); cmp(memb_a32[ss, ebp - 0x20], 0x26);    /* cmp byte [ebp-0x20], 0x26 */
            ii(0x1016_1e2b, 2); if(jbd(0x1016_1e4f, 0x22)) goto l_0x1016_1e4f; /* jb 0x10161e4f */
            ii(0x1016_1e2d, 4); cmp(memb_a32[ss, ebp - 0x20], 0x26);    /* cmp byte [ebp-0x20], 0x26 */
            ii(0x1016_1e31, 6); if(jbed(0x1016_1d0e, -0x129)) goto l_0x1016_1d0e; /* jbe 0x10161d0e */
            ii(0x1016_1e37, 4); cmp(memb_a32[ss, ebp - 0x20], 0x27);    /* cmp byte [ebp-0x20], 0x27 */
            ii(0x1016_1e3b, 6); if(jbed(0x1016_1d71, -0xd0)) goto l_0x1016_1d71; /* jbe 0x10161d71 */
            ii(0x1016_1e41, 4); cmp(memb_a32[ss, ebp - 0x20], 0x2a);    /* cmp byte [ebp-0x20], 0x2a */
            ii(0x1016_1e45, 6); if(jzd(0x1016_1c91, -0x1ba)) goto l_0x1016_1c91; /* jz 0x10161c91 */
            ii(0x1016_1e4b, 2); jmpd(0x1016_1e10, -0x3d); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        //  ii(0x1016_1e4d, 2); jmpd(0x1016_1e10, -0x3f); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1e4f:
            ii(0x1016_1e4f, 4); cmp(memb_a32[ss, ebp - 0x20], 0x1c);    /* cmp byte [ebp-0x20], 0x1c */
            ii(0x1016_1e53, 2); if(jbd(0x1016_1e6b, 0x16)) goto l_0x1016_1e6b; /* jb 0x10161e6b */
            ii(0x1016_1e55, 4); cmp(memb_a32[ss, ebp - 0x20], 0x1c);    /* cmp byte [ebp-0x20], 0x1c */
            ii(0x1016_1e59, 6); if(jbed(0x1016_1c1a, -0x245)) goto l_0x1016_1c1a; /* jbe 0x10161c1a */
            ii(0x1016_1e5f, 4); cmp(memb_a32[ss, ebp - 0x20], 0x1d);    /* cmp byte [ebp-0x20], 0x1d */
            ii(0x1016_1e63, 6); if(jzd(0x1016_1cd6, -0x193)) goto l_0x1016_1cd6; /* jz 0x10161cd6 */
            ii(0x1016_1e69, 2); jmpd(0x1016_1e10, -0x5b); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1e6b:
            ii(0x1016_1e6b, 2); jmpd(0x1016_1e10, -0x5d); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1e6d:
            ii(0x1016_1e6d, 4); cmp(memb_a32[ss, ebp - 0x20], 0x3);     /* cmp byte [ebp-0x20], 0x3 */
            ii(0x1016_1e71, 2); if(jbd(0x1016_1ea1, 0x2e)) goto l_0x1016_1ea1; /* jb 0x10161ea1 */
            ii(0x1016_1e73, 4); cmp(memb_a32[ss, ebp - 0x20], 0x3);     /* cmp byte [ebp-0x20], 0x3 */
            ii(0x1016_1e77, 6); if(jbed(0x1016_1cf7, -0x186)) goto l_0x1016_1cf7; /* jbe 0x10161cf7 */
            ii(0x1016_1e7d, 4); cmp(memb_a32[ss, ebp - 0x20], 0x5);     /* cmp byte [ebp-0x20], 0x5 */
            ii(0x1016_1e81, 2); if(jbd(0x1016_1e9c, 0x19)) goto l_0x1016_1e9c; /* jb 0x10161e9c */
            ii(0x1016_1e83, 4); cmp(memb_a32[ss, ebp - 0x20], 0x5);     /* cmp byte [ebp-0x20], 0x5 */
            ii(0x1016_1e87, 6); if(jbed(0x1016_1c6a, -0x223)) goto l_0x1016_1c6a; /* jbe 0x10161c6a */
            ii(0x1016_1e8d, 4); cmp(memb_a32[ss, ebp - 0x20], 0x6);     /* cmp byte [ebp-0x20], 0x6 */
            ii(0x1016_1e91, 6); if(jzd(0x1016_1c7a, -0x21d)) goto l_0x1016_1c7a; /* jz 0x10161c7a */
            ii(0x1016_1e97, 5); jmpd(0x1016_1e10, -0x8c); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1e9c:
            ii(0x1016_1e9c, 5); jmpd(0x1016_1e10, -0x91); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1ea1:
            ii(0x1016_1ea1, 4); cmp(memb_a32[ss, ebp - 0x20], 0);       /* cmp byte [ebp-0x20], 0x0 */
            ii(0x1016_1ea5, 6); if(jbed(0x1016_1c1a, -0x291)) goto l_0x1016_1c1a; /* jbe 0x10161c1a */
            ii(0x1016_1eab, 4); cmp(memb_a32[ss, ebp - 0x20], 0x1);     /* cmp byte [ebp-0x20], 0x1 */
            ii(0x1016_1eaf, 6); if(jzd(0x1016_1cd6, -0x1df)) goto l_0x1016_1cd6; /* jz 0x10161cd6 */
            ii(0x1016_1eb5, 5); jmpd(0x1016_1e10, -0xaa); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        //  ii(0x1016_1eba, 5); jmpd(0x1016_1e10, -0xaf); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1ebf:
            ii(0x1016_1ebf, 5); if(jmpd_func(0x1016_29a7, 0xae3)) return; /* jmp 0x101629a7 */
        }
    }
}
