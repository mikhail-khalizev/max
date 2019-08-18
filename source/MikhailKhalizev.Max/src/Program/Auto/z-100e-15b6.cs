using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_15b6-cf34631f")]
        public void Method_100e_15b6()
        {
            ii(0x100e_15b6, 5); pushd(0x15c);                           /* push 0x15c */
            ii(0x100e_15bb, 5); calld(Definitions.sys_check_available_stack_size, 0x8_4792); /* call 0x10165d52 */
            ii(0x100e_15c0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_15c1, 1); pushd(esi);                             /* push esi */
            ii(0x100e_15c2, 1); pushd(edi);                             /* push edi */
            ii(0x100e_15c3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_15c4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_15c6, 6); sub(esp, 0x130);                        /* sub esp, 0x130 */
            ii(0x100e_15cc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_15cf, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_15d2, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100e_15d5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_15d8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_15db, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_15de, 5); calld(0x1007_6630, -0x6_afb3);          /* call 0x10076630 */
            ii(0x100e_15e3, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100e_15e6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_15e9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_15eb, 5); calld(0x100d_6a11, -0xabdf);            /* call 0x100d6a11 */
            ii(0x100e_15f0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_15f2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_15f5, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_15f8, 5); calld(0x1013_ad11, 0x5_9714);           /* call 0x1013ad11 */
            ii(0x100e_15fd, 2); test(al, al);                           /* test al, al */
            ii(0x100e_15ff, 6); if(jzd(0x100e_1694, 0x8f)) goto l_0x100e_1694; /* jz 0x100e1694 */
            ii(0x100e_1605, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100e_1608, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_160b, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_160e, 5); calld(0x100d_7f6c, -0x96a7);            /* call 0x100d7f6c */
            ii(0x100e_1613, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100e_1616, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1619, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_161c, 5); calld(0x100d_7f6c, -0x96b5);            /* call 0x100d7f6c */
            ii(0x100e_1621, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1624, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1627, 5); calld(0x100d_4ebc, -0xc770);            /* call 0x100d4ebc */
            ii(0x100e_162c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_162e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1631, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1634, 5); calld(0x100d_4f24, -0xc715);            /* call 0x100d4f24 */
            ii(0x100e_1639, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_163b, 1); cwde();                                 /* cwde */
            ii(0x100e_163c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_163d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1640, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1643, 5); calld(0x100d_4ef0, -0xc758);            /* call 0x100d4ef0 */
            ii(0x100e_1648, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_164a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_164d, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1650, 5); calld(0x100d_4f58, -0xc6fd);            /* call 0x100d4f58 */
            ii(0x100e_1655, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_1657, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_165a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_165d, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1660, 5); calld(0x100d_4ebc, -0xc7a9);            /* call 0x100d4ebc */
            ii(0x100e_1665, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_1668, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_166b, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_166e, 5); calld(0x100d_4ef0, -0xc783);            /* call 0x100d4ef0 */
            ii(0x100e_1673, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_1676, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100e_1679, 5); calld(0x1008_b148, -0x5_6536);          /* call 0x1008b148 */
            ii(0x100e_167e, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_1682, 2); if(jzd(0x100e_168f, 0xb)) goto l_0x100e_168f; /* jz 0x100e168f */
            ii(0x100e_1684, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x100e_1687, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x100e_168a, 5); calld(Definitions.sys_display_draw_1, 0x8_5e19); /* call 0x101674a8 */
        l_0x100e_168f:
            ii(0x100e_168f, 5); jmpd(0x100e_17db, 0x147); goto l_0x100e_17db; /* jmp 0x100e17db */
        l_0x100e_1694:
            ii(0x100e_1694, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100e_1699, 3); lea(edi, ebp - 0x54);                   /* lea edi, [ebp-0x54] */
            ii(0x100e_169c, 3); lea(esi, ebp - 0x28);                   /* lea esi, [ebp-0x28] */
            ii(0x100e_169f, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x100e_16a1, 2); movsw_a32();                            /* movsw */
            ii(0x100e_16a3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_16a6, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_16a9, 5); calld(0x1007_6574, -0x6_b13a);          /* call 0x10076574 */
            ii(0x100e_16ae, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_16b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_16b4, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_16b7, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x100e_16bc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_16be, 3); mov(memd_a32[ss, ebp - 0x58], edx);     /* mov [ebp-0x58], edx */
            ii(0x100e_16c1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_16c4, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_16c7, 5); calld(0x100d_4ebc, -0xc810);            /* call 0x100d4ebc */
            ii(0x100e_16cc, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_16cf, 4); movsx(eax, memw_a32[ss, ebp - 0x44]);   /* movsx eax, word [ebp-0x44] */
            ii(0x100e_16d3, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_16d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_16d9, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_16dc, 5); calld(0x100d_4ef0, -0xc7f1);            /* call 0x100d4ef0 */
            ii(0x100e_16e1, 1); cwde();                                 /* cwde */
            ii(0x100e_16e2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_16e4, 3); add(memd_a32[ss, ebp - 0x3e], eax);     /* add [ebp-0x3e], eax */
            ii(0x100e_16e7, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100e_16ea, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100e_16ed, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_16f0, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100e_16f3, 2); if(jnzd(0x100e_173b, 0x46)) goto l_0x100e_173b; /* jnz 0x100e173b */
            ii(0x100e_16f5, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100e_16f8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_16fb, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_16fe, 5); calld(0x100d_7f6c, -0x9797);            /* call 0x100d7f6c */
            ii(0x100e_1703, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_1705, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1706, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_1708, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1709, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_170c, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_170f, 5); calld(0x100d_4ebc, -0xc858);            /* call 0x100d4ebc */
            ii(0x100e_1714, 1); cwde();                                 /* cwde */
            ii(0x100e_1715, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1716, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1719, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_171c, 5); calld(0x100d_4ef0, -0xc831);            /* call 0x100d4ef0 */
            ii(0x100e_1721, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_1724, 4); movsx(ebx, memw_a32[ss, ebp - 0x44]);   /* movsx ebx, word [ebp-0x44] */
            ii(0x100e_1728, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100e_172b, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100e_172e, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_1731, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1734, 5); calld(0x100f_04d8, 0xed9f);             /* call 0x100f04d8 */
            ii(0x100e_1739, 2); jmpd(0x100e_1766, 0x2b); goto l_0x100e_1766; /* jmp 0x100e1766 */
        l_0x100e_173b:
            ii(0x100e_173b, 5); calld(0x100d_533c, -0xc404);            /* call 0x100d533c */
            ii(0x100e_1740, 1); cwde();                                 /* cwde */
            ii(0x100e_1741, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1742, 5); calld(0x100d_5360, -0xc3e7);            /* call 0x100d5360 */
            ii(0x100e_1747, 1); cwde();                                 /* cwde */
            ii(0x100e_1748, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1749, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_174b, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_174e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_174f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100e_1751, 4); movsx(ebx, memw_a32[ss, ebp - 0x44]);   /* movsx ebx, word [ebp-0x44] */
            ii(0x100e_1755, 3); lea(edx, ebp - 0x54);                   /* lea edx, [ebp-0x54] */
            ii(0x100e_1758, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x100e_175b, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x100e_175e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1761, 5); calld(0x100e_8c51, 0x74eb);             /* call 0x100e8c51 */
        l_0x100e_1766:
            ii(0x100e_1766, 6); lea(edx, ebp - 0x120);                  /* lea edx, [ebp-0x120] */
            ii(0x100e_176c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_176f, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1772, 5); calld(0x1007_6574, -0x6_b203);          /* call 0x10076574 */
            ii(0x100e_1777, 5); calld(0x1014_fa43, 0x6_e2c7);           /* call 0x1014fa43 */
            ii(0x100e_177c, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100e_1781, 5); calld(/* sys */ 0x1016_a24c, 0x8_8ac6); /* call 0x1016a24c */
            ii(0x100e_1786, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_1788, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1789, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_178b, 1); pushd(eax);                             /* push eax */
            ii(0x100e_178c, 5); pushd(0x1_00a2);                        /* push 0x100a2 */
            ii(0x100e_1791, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1794, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_1797, 5); calld(0x100d_4f24, -0xc878);            /* call 0x100d4f24 */
            ii(0x100e_179c, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x100e_179f, 1); cwde();                                 /* cwde */
            ii(0x100e_17a0, 1); pushd(eax);                             /* push eax */
            ii(0x100e_17a1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_17a4, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_17a7, 5); calld(0x100d_4f58, -0xc854);            /* call 0x100d4f58 */
            ii(0x100e_17ac, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x100e_17af, 1); cwde();                                 /* cwde */
            ii(0x100e_17b0, 1); pushd(eax);                             /* push eax */
            ii(0x100e_17b1, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x100e_17b6, 1); pushd(eax);                             /* push eax */
            ii(0x100e_17b7, 5); mov(ecx, 0xa);                          /* mov ecx, 0xa */
            ii(0x100e_17bc, 6); lea(ebx, ebp - 0x120);                  /* lea ebx, [ebp-0x120] */
            ii(0x100e_17c2, 4); movsx(edx, memw_a32[ss, ebp - 0x44]);   /* movsx edx, word [ebp-0x44] */
            ii(0x100e_17c6, 3); mov(eax, memd_a32[ss, ebp - 0x3e]);     /* mov eax, [ebp-0x3e] */
            ii(0x100e_17c9, 5); calld(0x100e_9ae5, 0x8317);             /* call 0x100e9ae5 */
            ii(0x100e_17ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_17d0, 3); mov(dl, memb_a32[ss, ebp - 0x4]);       /* mov dl, [ebp-0x4] */
            ii(0x100e_17d3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_17d6, 5); calld(0x100e_19f6, 0x21b);              /* call 0x100e19f6 */
        l_0x100e_17db:
            ii(0x100e_17db, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_17df, 2); if(jzd(0x100e_184f, 0x6e)) goto l_0x100e_184f; /* jz 0x100e184f */
            ii(0x100e_17e1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_17e4, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_17e7, 5); calld(0x100d_4ebc, -0xc930);            /* call 0x100d4ebc */
            ii(0x100e_17ec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_17ee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_17f1, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_17f4, 5); calld(0x100d_4f24, -0xc8d5);            /* call 0x100d4f24 */
            ii(0x100e_17f9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_17fb, 1); cwde();                                 /* cwde */
            ii(0x100e_17fc, 1); pushd(eax);                             /* push eax */
            ii(0x100e_17fd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1800, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_1803, 5); calld(0x100d_4ef0, -0xc918);            /* call 0x100d4ef0 */
            ii(0x100e_1808, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_180a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_180d, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_1810, 5); calld(0x100d_4f58, -0xc8bd);            /* call 0x100d4f58 */
            ii(0x100e_1815, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_1817, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100e_181a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_181d, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_1820, 5); calld(0x100d_4ebc, -0xc969);            /* call 0x100d4ebc */
            ii(0x100e_1825, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100e_1828, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_182b, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_182e, 5); calld(0x100d_4ef0, -0xc943);            /* call 0x100d4ef0 */
            ii(0x100e_1833, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_1836, 6); lea(eax, ebp - 0x130);                  /* lea eax, [ebp-0x130] */
            ii(0x100e_183c, 5); calld(0x1008_b148, -0x5_66f9);          /* call 0x1008b148 */
            ii(0x100e_1841, 6); lea(edx, ebp - 0x130);                  /* lea edx, [ebp-0x130] */
            ii(0x100e_1847, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x100e_184a, 5); calld(Definitions.sys_display_draw_1, 0x8_5c59); /* call 0x101674a8 */
        l_0x100e_184f:
            ii(0x100e_184f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_1852, 5); calld(0x100e_185e, 0x7);                /* call 0x100e185e */
            ii(0x100e_1857, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_1859, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_185a, 1); popd(edi);                              /* pop edi */
            ii(0x100e_185b, 1); popd(esi);                              /* pop esi */
            ii(0x100e_185c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_185d, 1); retd(); return;                         /* ret */
        }
    }
}
