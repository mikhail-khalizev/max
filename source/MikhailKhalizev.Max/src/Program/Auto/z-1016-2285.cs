using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_2285-3632848f")]
        public void Method_1016_2285()
        {
            ii(0x1016_2285, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2288, 4); cmp(memb_a32[ds, eax + 0x3e], 0);       /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1016_228c, 6); if(jnzd(0x1016_230e, 0x7c)) goto l_0x1016_230e; /* jnz 0x1016230e */
            ii(0x1016_2292, 5); mov(eax, StringDefinitions.PowerUp);    /* mov eax, 0x101b2959 */
            ii(0x1016_2297, 5); calld(0x100a_8b4a, -0xb_9752);          /* call 0x100a8b4a */
            ii(0x1016_229c, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_22a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_22a4, 5); calld(0x1007_6d98, -0xe_b511);          /* call 0x10076d98 */
            ii(0x1016_22a9, 2); test(al, al);                           /* test al, al */
            ii(0x1016_22ab, 2); if(jzd(0x1016_22c8, 0x1b)) goto l_0x1016_22c8; /* jz 0x101622c8 */
            ii(0x1016_22ad, 5); calld(0x1010_2bf8, -0x5_f6ba);          /* call 0x10102bf8 */
            ii(0x1016_22b2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_22b4, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_22b6, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1016_22bb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_22be, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_22c3, 5); calld(0x1013_d5c0, -0x2_4d08);          /* call 0x1013d5c0 */
        l_0x1016_22c8:
            ii(0x1016_22c8, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1016_22cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_22d0, 5); calld(0x1015_cbca, -0x570b);            /* call 0x1015cbca */
            ii(0x1016_22d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_22d8, 4); mov(ax, memw_a32[ds, eax + 0x33]);      /* mov ax, [eax+0x33] */
            ii(0x1016_22dc, 1); inc(eax);                               /* inc eax */
            ii(0x1016_22dd, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_22e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_22e3, 5); calld(0x1014_9b07, -0x1_87e1);          /* call 0x10149b07 */
            ii(0x1016_22e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_22eb, 5); cmp(memw_a32[ds, eax + 0x8], 0x1d);     /* cmp word [eax+0x8], 0x1d */
            ii(0x1016_22f0, 2); if(jnzd(0x1016_230e, 0x1c)) goto l_0x1016_230e; /* jnz 0x1016230e */
            ii(0x1016_22f2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_22f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_22fa, 3); mov(edx, memd_a32[ds, eax + 0x5a]);     /* mov edx, [eax+0x5a] */
            ii(0x1016_22fd, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1016_2300, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2303, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1016_2306, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_2308, 1); cwde();                                 /* cwde */
            ii(0x1016_2309, 5); calld(0x1013_322d, -0x2_f0e1);          /* call 0x1013322d */
        l_0x1016_230e:
            ii(0x1016_230e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2311, 5); calld(0x1016_1499, -0xe7d);             /* call 0x10161499 */
            ii(0x1016_2316, 5); if(jmpd_func(0x1016_29a7, 0x68c)) return; /* jmp 0x101629a7 */
        }
    }
}
