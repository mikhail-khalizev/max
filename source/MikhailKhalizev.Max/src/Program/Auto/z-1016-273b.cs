using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_273b-90578774")]
        public void Method_1016_273b()
        {
            ii(0x1016_273b, 5); mov(eax, StringDefinitions.Scaling);    /* mov eax, 0x101b29dc */
            ii(0x1016_2740, 5); calld(0x100a_8b4a, -0xb_9bfb);          /* call 0x100a8b4a */
            ii(0x1016_2745, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2748, 5); calld(0x1014_9fa8, -0x1_87a5);          /* call 0x10149fa8 */
            ii(0x1016_274d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2750, 4); cmp(memb_a32[ds, eax + 0x3f], 0x18);    /* cmp byte [eax+0x3f], 0x18 */
            ii(0x1016_2754, 2); if(jzd(0x1016_275f, 0x9)) goto l_0x1016_275f; /* jz 0x1016275f */
            ii(0x1016_2756, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2759, 4); cmp(memb_a32[ds, eax + 0x3f], 0x19);    /* cmp byte [eax+0x3f], 0x19 */
            ii(0x1016_275d, 2); if(jnzd(0x1016_2766, 0x7)) goto l_0x1016_2766; /* jnz 0x10162766 */
        l_0x1016_275f:
            ii(0x1016_275f, 7); mov(memb_a32[ds, 0x101c_9448], 0x1);    /* mov byte [0x101c9448], 0x1 */
        l_0x1016_2766:
            ii(0x1016_2766, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2769, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
            ii(0x1016_276c, 3); mov(memb_a32[ss, ebp - 0x6c], al);      /* mov [ebp-0x6c], al */
            ii(0x1016_276f, 5); jmpd(0x1016_27f4, 0x80); goto l_0x1016_27f4; /* jmp 0x101627f4 */
        l_0x1016_2774:
            ii(0x1016_2774, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2777, 3); mov(al, memb_a32[ds, eax + 0x2d]);      /* mov al, [eax+0x2d] */
            ii(0x1016_277a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_277f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_2781, 2); if(jzd(0x1016_278b, 0x8)) goto l_0x1016_278b; /* jz 0x1016278b */
            ii(0x1016_2783, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2786, 3); dec(memb_a32[ds, eax + 0x2d]);          /* dec byte [eax+0x2d] */
            ii(0x1016_2789, 2); jmpd(0x1016_27ce, 0x43); goto l_0x1016_27ce; /* jmp 0x101627ce */
        l_0x1016_278b:
            ii(0x1016_278b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_278e, 5); calld(0x1014_f08b, -0x1_3708);          /* call 0x1014f08b */
            ii(0x1016_2793, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2796, 5); calld(0x1015_ec73, -0x3b28);            /* call 0x1015ec73 */
            ii(0x1016_279b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_279e, 5); calld(0x1015_26ac, -0x1_00f7);          /* call 0x101526ac */
            ii(0x1016_27a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_27a5, 2); if(jzd(0x1016_27c1, 0x1a)) goto l_0x1016_27c1; /* jz 0x101627c1 */
            ii(0x1016_27a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_27aa, 5); calld(0x1015_26ac, -0x1_0103);          /* call 0x101526ac */
            ii(0x1016_27af, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x1016_27b2, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x1016_27b5, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1016_27b8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_27bb, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x1016_27be, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
        l_0x1016_27c1:
            ii(0x1016_27c1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_27c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_27c9, 5); calld(0x1015_2605, -0x1_01c9);          /* call 0x10152605 */
        l_0x1016_27ce:
            ii(0x1016_27ce, 2); jmpd(0x1016_2814, 0x44); goto l_0x1016_2814; /* jmp 0x10162814 */
        l_0x1016_27d0:
            ii(0x1016_27d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_27d3, 3); mov(al, memb_a32[ds, eax + 0x2d]);      /* mov al, [eax+0x2d] */
            ii(0x1016_27d6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_27db, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1016_27de, 2); if(jzd(0x1016_27e8, 0x8)) goto l_0x1016_27e8; /* jz 0x101627e8 */
            ii(0x1016_27e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_27e3, 3); inc(memb_a32[ds, eax + 0x2d]);          /* inc byte [eax+0x2d] */
            ii(0x1016_27e6, 2); jmpd(0x1016_27f0, 0x8); goto l_0x1016_27f0; /* jmp 0x101627f0 */
        l_0x1016_27e8:
            ii(0x1016_27e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_27eb, 5); calld(0x1016_16bd, -0x1133);            /* call 0x101616bd */
        l_0x1016_27f0:
            ii(0x1016_27f0, 2); jmpd(0x1016_2814, 0x22); goto l_0x1016_2814; /* jmp 0x10162814 */
        l_0x1016_27f2:
            ii(0x1016_27f2, 2); jmpd(0x1016_2814, 0x20); goto l_0x1016_2814; /* jmp 0x10162814 */
        l_0x1016_27f4:
            ii(0x1016_27f4, 3); mov(al, memb_a32[ss, ebp - 0x6c]);      /* mov al, [ebp-0x6c] */
            ii(0x1016_27f7, 3); mov(memb_a32[ss, ebp - 0x74], al);      /* mov [ebp-0x74], al */
            ii(0x1016_27fa, 4); cmp(memb_a32[ss, ebp - 0x74], 0x20);    /* cmp byte [ebp-0x74], 0x20 */
            ii(0x1016_27fe, 2); if(jbd(0x1016_2812, 0x12)) goto l_0x1016_2812; /* jb 0x10162812 */
            ii(0x1016_2800, 4); cmp(memb_a32[ss, ebp - 0x74], 0x20);    /* cmp byte [ebp-0x74], 0x20 */
            ii(0x1016_2804, 6); if(jbed(0x1016_2774, -0x96)) goto l_0x1016_2774; /* jbe 0x10162774 */
            ii(0x1016_280a, 4); cmp(memb_a32[ss, ebp - 0x74], 0x21);    /* cmp byte [ebp-0x74], 0x21 */
            ii(0x1016_280e, 2); if(jzd(0x1016_27d0, -0x40)) goto l_0x1016_27d0; /* jz 0x101627d0 */
            ii(0x1016_2810, 2); jmpd(0x1016_27f2, -0x20); goto l_0x1016_27f2; /* jmp 0x101627f2 */
        l_0x1016_2812:
            ii(0x1016_2812, 2); jmpd(0x1016_27f2, -0x22); goto l_0x1016_27f2; /* jmp 0x101627f2 */
        l_0x1016_2814:
            ii(0x1016_2814, 5); if(jmpd_func(0x1016_29a7, 0x18e)) return; /* jmp 0x101629a7 */
        }
    }
}
