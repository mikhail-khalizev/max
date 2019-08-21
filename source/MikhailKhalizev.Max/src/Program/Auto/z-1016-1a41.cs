using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_1a41-c284056a")]
        public void Method_1016_1a41()
        {
            ii(0x1016_1a41, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a44, 5); cmp(memw_a32[ds, eax + 0x8], 0x15);     /* cmp word [eax+0x8], 0x15 */
            ii(0x1016_1a49, 2); if(jzd(0x1016_1a55, 0xa)) goto l_0x1016_1a55; /* jz 0x10161a55 */
            ii(0x1016_1a4b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a4e, 5); cmp(memw_a32[ds, eax + 0x8], 0x21);     /* cmp word [eax+0x8], 0x21 */
            ii(0x1016_1a53, 2); if(jnzd(0x1016_1a5a, 0x5)) goto l_0x1016_1a5a; /* jnz 0x10161a5a */
        l_0x1016_1a55:
            ii(0x1016_1a55, 5); if(jmpd_func(0x1016_29a7, 0xf4d)) return; /* jmp 0x101629a7 */
        l_0x1016_1a5a:
            ii(0x1016_1a5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a5d, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1016_1a60, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1016_1a63, 5); jmpd(0x1016_1af8, 0x90); goto l_0x1016_1af8; /* jmp 0x10161af8 */
        l_0x1016_1a68:
            ii(0x1016_1a68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1a6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a6d, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1016_1a70, 5); calld(0x1007_6a34, -0xe_b041);          /* call 0x10076a34 */
            ii(0x1016_1a75, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a78, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1016_1a7c, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1a81, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a84, 5); calld(0x1007_6d98, -0xe_acf1);          /* call 0x10076d98 */
            ii(0x1016_1a89, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1a8b, 2); if(jzd(0x1016_1a9a, 0xd)) goto l_0x1016_1a9a; /* jz 0x10161a9a */
            ii(0x1016_1a8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a90, 5); calld(0x1010_094d, -0x6_1148);          /* call 0x1010094d */
            ii(0x1016_1a95, 5); calld(0x100f_f5c1, -0x6_24d9);          /* call 0x100ff5c1 */
        l_0x1016_1a9a:
            ii(0x1016_1a9a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a9d, 5); cmp(memw_a32[ds, eax + 0x8], 0x27);     /* cmp word [eax+0x8], 0x27 */
            ii(0x1016_1aa2, 2); if(jnzd(0x1016_1ab0, 0xc)) goto l_0x1016_1ab0; /* jnz 0x10161ab0 */
            ii(0x1016_1aa4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1aa7, 5); calld(0x1015_2b8c, -0xef20);            /* call 0x10152b8c */
            ii(0x1016_1aac, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1aae, 2); if(jnzd(0x1016_1ab2, 0x2)) goto l_0x1016_1ab2; /* jnz 0x10161ab2 */
        l_0x1016_1ab0:
            ii(0x1016_1ab0, 2); jmpd(0x1016_1ae4, 0x32); goto l_0x1016_1ae4; /* jmp 0x10161ae4 */
        l_0x1016_1ab2:
            ii(0x1016_1ab2, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x1016_1ab7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1aba, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1016_1abd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_1ac0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1ac3, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1016_1ac6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_1ac9, 5); calld(0x1007_36d8, -0xe_e3f6);          /* call 0x100736d8 */
            ii(0x1016_1ace, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1ad0, 2); if(jnzd(0x1016_1ae4, 0x12)) goto l_0x1016_1ae4; /* jnz 0x10161ae4 */
            ii(0x1016_1ad2, 5); mov(ebx, 0x27);                         /* mov ebx, 0x27 */
            ii(0x1016_1ad7, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1016_1adc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1adf, 5); calld(0x1016_2f96, 0x14b2);             /* call 0x10162f96 */
        l_0x1016_1ae4:
            ii(0x1016_1ae4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1ae7, 5); calld(0x1016_18c2, -0x22a);             /* call 0x101618c2 */
            ii(0x1016_1aec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1aef, 5); calld(0x1016_1499, -0x65b);             /* call 0x10161499 */
            ii(0x1016_1af4, 2); jmpd(0x1016_1b22, 0x2c); goto l_0x1016_1b22; /* jmp 0x10161b22 */
        l_0x1016_1af6:
            ii(0x1016_1af6, 2); jmpd(0x1016_1b22, 0x2a); goto l_0x1016_1b22; /* jmp 0x10161b22 */
        l_0x1016_1af8:
            ii(0x1016_1af8, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1016_1afb, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1016_1afe, 4); cmp(memb_a32[ss, ebp - 0x10], 0x2);     /* cmp byte [ebp-0x10], 0x2 */
            ii(0x1016_1b02, 2); if(jbd(0x1016_1b16, 0x12)) goto l_0x1016_1b16; /* jb 0x10161b16 */
            ii(0x1016_1b04, 4); cmp(memb_a32[ss, ebp - 0x10], 0x2);     /* cmp byte [ebp-0x10], 0x2 */
            ii(0x1016_1b08, 2); if(jbed(0x1016_1ae4, -0x26)) goto l_0x1016_1ae4; /* jbe 0x10161ae4 */
            ii(0x1016_1b0a, 4); cmp(memb_a32[ss, ebp - 0x10], 0x18);    /* cmp byte [ebp-0x10], 0x18 */
            ii(0x1016_1b0e, 6); if(jzd(0x1016_1a68, -0xac)) goto l_0x1016_1a68; /* jz 0x10161a68 */
            ii(0x1016_1b14, 2); jmpd(0x1016_1af6, -0x20); goto l_0x1016_1af6; /* jmp 0x10161af6 */
        l_0x1016_1b16:
            ii(0x1016_1b16, 4); cmp(memb_a32[ss, ebp - 0x10], 0x1);     /* cmp byte [ebp-0x10], 0x1 */
            ii(0x1016_1b1a, 6); if(jzd(0x1016_1a9a, -0x86)) goto l_0x1016_1a9a; /* jz 0x10161a9a */
            ii(0x1016_1b20, 2); jmpd(0x1016_1af6, -0x2c); goto l_0x1016_1af6; /* jmp 0x10161af6 */
        l_0x1016_1b22:
            ii(0x1016_1b22, 5); if(jmpd_func(0x1016_29a7, 0xe80)) return; /* jmp 0x101629a7 */
        }
    }
}
