using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("40b0e7fe-657c-40dd-aca7-f8b8103aeaf3")]
        public void Method_1010_1620()
        {
            ii(0x1010_1620, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1010_1625, 5); calld(Definitions.sys_check_available_stack_size, 0x6_4728); /* call 0x10165d52 */
            ii(0x1010_162a, 1); pushd(esi);                             /* push esi */
            ii(0x1010_162b, 1); pushd(edi);                             /* push edi */
            ii(0x1010_162c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_162d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_162f, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1010_1635, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_1638, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_163b, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_163e, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1010_1641, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_1644, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_1647, 5); jmpd(0x1010_194e, 0x302); goto l_0x1010_194e; /* jmp 0x1010194e */
        l_0x1010_164c:
            ii(0x1010_164c, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x1010_1651, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1010_1656, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_165a, 5); calld(0x1007_6e7c, -0x8_a7e3);          /* call 0x10076e7c */
            ii(0x1010_165f, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1010_1661, 5); calld(Definitions.my_min, -0x7_7ee2);   /* call 0x10089784 */
            ii(0x1010_1666, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_1669, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_166d, 6); cmp(eax, memd_a32[ds, 0x101c_38c0]);    /* cmp eax, [0x101c38c0] */
            ii(0x1010_1673, 2); if(jnzd(0x1010_167b, 0x6)) goto l_0x1010_167b; /* jnz 0x1010167b */
            ii(0x1010_1675, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_1679, 2); if(jzd(0x1010_167d, 0x2)) goto l_0x1010_167d; /* jz 0x1010167d */
        l_0x1010_167b:
            ii(0x1010_167b, 2); jmpd(0x1010_1682, 0x5); goto l_0x1010_1682; /* jmp 0x10101682 */
        l_0x1010_167d:
            ii(0x1010_167d, 5); jmpd(0x1010_19b2, 0x330); goto l_0x1010_19b2; /* jmp 0x101019b2 */
        l_0x1010_1682:
            ii(0x1010_1682, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_1686, 5); mov(memd_a32[ds, 0x101c_38c0], eax);    /* mov [0x101c38c0], eax */
            ii(0x1010_168b, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x1010_1692, 6); if(jzd(0x1010_1723, 0x8b)) goto l_0x1010_1723; /* jz 0x10101723 */
            ii(0x1010_1698, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x1010_169d, 5); calld(0x100e_883d, -0x1_8e65);          /* call 0x100e883d */
            ii(0x1010_16a2, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_16a5, 5); calld(0x1010_2b60, 0x14b6);             /* call 0x10102b60 */
            ii(0x1010_16aa, 1); pushd(eax);                             /* push eax */
            ii(0x1010_16ab, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_16ad, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_16b0, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x1010_16b3, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_16b6, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_16b8, 5); mov(eax, 0x258);                        /* mov eax, 0x258 */
            ii(0x1010_16bd, 5); calld(0x100e_8ef1, -0x1_87d1);          /* call 0x100e8ef1 */
            ii(0x1010_16c2, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1010_16c5, 3); mov(edx, memd_a32[ds, edx + 0x8]);      /* mov edx, [edx+0x8] */
            ii(0x1010_16c8, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_16cb, 2); sub(edx, memd_a32[ds, eax]);            /* sub edx, [eax] */
            ii(0x1010_16cd, 5); mov(eax, 0x40);                         /* mov eax, 0x40 */
            ii(0x1010_16d2, 6); sub(eax, memd_a32[ds, 0x101c_38c0]);    /* sub eax, [0x101c38c0] */
            ii(0x1010_16d8, 3); sub(edx, 0x1c);                         /* sub edx, 0x1c */
            ii(0x1010_16db, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1010_16de, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x1010_16e3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_16e5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_16e8, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_16ea, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1010_16ed, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_16f0, 5); calld(0x1010_2b60, 0x146b);             /* call 0x10102b60 */
            ii(0x1010_16f5, 1); pushd(eax);                             /* push eax */
            ii(0x1010_16f6, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_16fb, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1010_16fe, 3); mov(ebx, memd_a32[ds, edx + 0x4]);      /* mov ebx, [edx+0x4] */
            ii(0x1010_1701, 1); inc(ebx);                               /* inc ebx */
            ii(0x1010_1702, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1010_1706, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_1709, 2); add(edx, memd_a32[ds, eax]);            /* add edx, [eax] */
            ii(0x1010_170b, 5); mov(eax, 0x25f);                        /* mov eax, 0x25f */
            ii(0x1010_1710, 5); calld(0x100e_8ef1, -0x1_8824);          /* call 0x100e8ef1 */
            ii(0x1010_1715, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1010_1718, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_171b, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_171e, 5); calld(Definitions.sys_display_draw_1, 0x6_5d85); /* call 0x101674a8 */
        l_0x1010_1723:
            ii(0x1010_1723, 6); mov(ebx, memd_a32[ds, 0x101c_38c0]);    /* mov ebx, [0x101c38c0] */
            ii(0x1010_1729, 5); mov(eax, 0x40_0000);                    /* mov eax, 0x400000 */
            ii(0x1010_172e, 5); mov(edx, 0x40_0000);                    /* mov edx, 0x400000 */
            ii(0x1010_1733, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_1736, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_1738, 5); mov(memd_a32[ds, 0x101c_38c4], eax);    /* mov [0x101c38c4], eax */
            ii(0x1010_173d, 5); mov(eax, 0x54);                         /* mov eax, 0x54 */
            ii(0x1010_1742, 5); calld(0x1007_5fdc, -0x8_b76b);          /* call 0x10075fdc */
            ii(0x1010_1747, 6); mov(memw_a32[ds, 0x101c_398a], ax);     /* mov [0x101c398a], ax */
            ii(0x1010_174d, 5); mov(eax, memd_a32[ds, 0x101c_3988]);    /* mov eax, [0x101c3988] */
            ii(0x1010_1752, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1755, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1010_1758, 2); if(jged(0x1010_1776, 0x1c)) goto l_0x1010_1776; /* jge 0x10101776 */
            ii(0x1010_175a, 9); mov(memw_a32[ds, 0x101c_398a], 0x10);   /* mov word [0x101c398a], 0x10 */
            ii(0x1010_1763, 6); mov(edx, memd_a32[ds, 0x101c_3988]);    /* mov edx, [0x101c3988] */
            ii(0x1010_1769, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_176c, 5); mov(eax, 0x54);                         /* mov eax, 0x54 */
            ii(0x1010_1771, 5); calld(0x100c_aafc, -0x3_6c7a);          /* call 0x100caafc */
        l_0x1010_1776:
            ii(0x1010_1776, 5); mov(eax, memd_a32[ds, 0x101c_3988]);    /* mov eax, [0x101c3988] */
            ii(0x1010_177b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_177e, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x1010_1785, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_1788, 6); mov(memw_a32[ds, 0x101c_398a], ax);     /* mov [0x101c398a], ax */
            ii(0x1010_178e, 6); mov(ax, memw_a32[ds, 0x101c_398a]);     /* mov ax, [0x101c398a] */
            ii(0x1010_1794, 6); mov(memw_a32[ds, 0x101c_398c], ax);     /* mov [0x101c398c], ax */
            ii(0x1010_179a, 9); mov(memw_a32[ds, 0x101c_398e], 0);      /* mov word [0x101c398e], 0x0 */
            ii(0x1010_17a3, 6); mov(ax, memw_a32[ds, 0x101c_38e2]);     /* mov ax, [0x101c38e2] */
            ii(0x1010_17a9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_17ac, 6); mov(ax, memw_a32[ds, 0x101c_38e4]);     /* mov ax, [0x101c38e4] */
            ii(0x1010_17b2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_17b5, 9); mov(memw_a32[ds, 0x101c_38e4], 0);      /* mov word [0x101c38e4], 0x0 */
            ii(0x1010_17be, 6); mov(ax, memw_a32[ds, 0x101c_38e4]);     /* mov ax, [0x101c38e4] */
            ii(0x1010_17c4, 6); mov(memw_a32[ds, 0x101c_38e2], ax);     /* mov [0x101c38e2], ax */
        l_0x1010_17ca:
            ii(0x1010_17ca, 6); mov(ebx, memd_a32[ds, 0x101c_8170]);    /* mov ebx, [0x101c8170] */
            ii(0x1010_17d0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_17d3, 3); sub(ebx, 0x4);                          /* sub ebx, 0x4 */
            ii(0x1010_17d6, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1010_17db, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_17df, 5); calld(0x1007_6e7c, -0x8_a968);          /* call 0x10076e7c */
            ii(0x1010_17e4, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1010_17e6, 5); calld(Definitions.my_min, -0x7_8067);   /* call 0x10089784 */
            ii(0x1010_17eb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_17ee, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x1010_17f3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_17f6, 3); lea(ebx, eax - 0x4);                    /* lea ebx, [eax-0x4] */
            ii(0x1010_17f9, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1010_17fe, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_1802, 5); calld(0x1007_6e7c, -0x8_a98b);          /* call 0x10076e7c */
            ii(0x1010_1807, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1010_1809, 5); calld(Definitions.my_min, -0x7_808a);   /* call 0x10089784 */
            ii(0x1010_180e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_1811, 6); mov(ax, memw_a32[ds, 0x101c_38e2]);     /* mov ax, [0x101c38e2] */
            ii(0x1010_1817, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1010_181b, 2); if(jnzd(0x1010_1829, 0xc)) goto l_0x1010_1829; /* jnz 0x10101829 */
            ii(0x1010_181d, 6); mov(ax, memw_a32[ds, 0x101c_38e4]);     /* mov ax, [0x101c38e4] */
            ii(0x1010_1823, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1010_1827, 2); if(jzd(0x1010_182b, 0x2)) goto l_0x1010_182b; /* jz 0x1010182b */
        l_0x1010_1829:
            ii(0x1010_1829, 2); jmpd(0x1010_1830, 0x5); goto l_0x1010_1830; /* jmp 0x10101830 */
        l_0x1010_182b:
            ii(0x1010_182b, 5); jmpd(0x1010_19b2, 0x182); goto l_0x1010_19b2; /* jmp 0x101019b2 */
        l_0x1010_1830:
            ii(0x1010_1830, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_1833, 6); mov(memw_a32[ds, 0x101c_38e2], ax);     /* mov [0x101c38e2], ax */
            ii(0x1010_1839, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_183c, 6); mov(memw_a32[ds, 0x101c_38e4], ax);     /* mov [0x101c38e4], ax */
            ii(0x1010_1842, 6); mov(ax, memw_a32[ds, 0x101c_38e2]);     /* mov ax, [0x101c38e2] */
            ii(0x1010_1848, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1010_184b, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1010_1850, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_1853, 6); mov(ax, memw_a32[ds, 0x101c_38e4]);     /* mov ax, [0x101c38e4] */
            ii(0x1010_1859, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1010_185c, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1010_1861, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_1864, 6); mov(edx, memd_a32[ds, 0x101b_8746]);    /* mov edx, [0x101b8746] */
            ii(0x1010_186a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_186d, 7); imul(edx, memd_a32[ds, 0x101c_38c4]);   /* imul edx, [0x101c38c4] */
            ii(0x1010_1874, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_1877, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_1879, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_187c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1010_187e, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1010_1880, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1010_1884, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1010_1886, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_1889, 6); mov(edx, memd_a32[ds, 0x101b_8748]);    /* mov edx, [0x101b8748] */
            ii(0x1010_188f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_1892, 7); imul(edx, memd_a32[ds, 0x101c_38c4]);   /* imul edx, [0x101c38c4] */
            ii(0x1010_1899, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_189c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_189e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_18a1, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1010_18a3, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1010_18a5, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_18a9, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1010_18ab, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_18ae, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_18b2, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_18b6, 5); calld(0x1010_1427, -0x494);             /* call 0x10101427 */
            ii(0x1010_18bb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_18bd, 6); if(jzd(0x1010_19b2, 0xef)) goto l_0x1010_19b2; /* jz 0x101019b2 */
            ii(0x1010_18c3, 5); jmpd(0x1010_1980, 0xb8); goto l_0x1010_1980; /* jmp 0x10101980 */
        l_0x1010_18c8:
            ii(0x1010_18c8, 6); mov(ax, memw_a32[ds, 0x101c_38da]);     /* mov ax, [0x101c38da] */
            ii(0x1010_18ce, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_18d1, 6); mov(ax, memw_a32[ds, 0x101c_38dc]);     /* mov ax, [0x101c38dc] */
            ii(0x1010_18d7, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_18da, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_18dd, 8); imul(ax, memw_a32[ds, 0x101c_398c]);    /* imul ax, [0x101c398c] */
            ii(0x1010_18e5, 7); mov(dx, memw_a32[ds, 0x101c_38ec]);     /* mov dx, [0x101c38ec] */
            ii(0x1010_18ec, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_18ee, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_18f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_18f4, 8); imul(ax, memw_a32[ds, 0x101c_398c]);    /* imul ax, [0x101c398c] */
            ii(0x1010_18fc, 7); mov(dx, memw_a32[ds, 0x101c_38f0]);     /* mov dx, [0x101c38f0] */
            ii(0x1010_1903, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_1905, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_1908, 6); mov(ax, memw_a32[ds, 0x101c_398c]);     /* mov ax, [0x101c398c] */
            ii(0x1010_190e, 7); add(memw_a32[ds, 0x101c_398e], ax);     /* add [0x101c398e], ax */
            ii(0x1010_1915, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_1919, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_191d, 5); calld(0x1010_1427, -0x4fb);             /* call 0x10101427 */
            ii(0x1010_1922, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_1924, 6); if(jzd(0x1010_19b2, 0x88)) goto l_0x1010_19b2; /* jz 0x101019b2 */
            ii(0x1010_192a, 6); mov(ax, memw_a32[ds, 0x101c_38da]);     /* mov ax, [0x101c38da] */
            ii(0x1010_1930, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1010_1933, 7); add(memw_a32[ds, 0x101c_38e2], ax);     /* add [0x101c38e2], ax */
            ii(0x1010_193a, 6); mov(ax, memw_a32[ds, 0x101c_38dc]);     /* mov ax, [0x101c38dc] */
            ii(0x1010_1940, 3); sub(eax, memd_a32[ss, ebp - 0x24]);     /* sub eax, [ebp-0x24] */
            ii(0x1010_1943, 7); add(memw_a32[ds, 0x101c_38e4], ax);     /* add [0x101c38e4], ax */
            ii(0x1010_194a, 2); jmpd(0x1010_1980, 0x34); goto l_0x1010_1980; /* jmp 0x10101980 */
        l_0x1010_194c:
            ii(0x1010_194c, 2); jmpd(0x1010_1980, 0x32); goto l_0x1010_1980; /* jmp 0x10101980 */
        l_0x1010_194e:
            ii(0x1010_194e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_1951, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1010_1954, 5); cmp(memw_a32[ss, ebp - 0x28], 0x1);     /* cmp word [ebp-0x28], 0x1 */
            ii(0x1010_1959, 2); if(jbd(0x1010_1973, 0x18)) goto l_0x1010_1973; /* jb 0x10101973 */
            ii(0x1010_195b, 5); cmp(memw_a32[ss, ebp - 0x28], 0x1);     /* cmp word [ebp-0x28], 0x1 */
            ii(0x1010_1960, 6); if(jbed(0x1010_17ca, -0x19c)) goto l_0x1010_17ca; /* jbe 0x101017ca */
            ii(0x1010_1966, 5); cmp(memw_a32[ss, ebp - 0x28], 0x2);     /* cmp word [ebp-0x28], 0x2 */
            ii(0x1010_196b, 6); if(jzd(0x1010_18c8, -0xa9)) goto l_0x1010_18c8; /* jz 0x101018c8 */
            ii(0x1010_1971, 2); jmpd(0x1010_194c, -0x27); goto l_0x1010_194c; /* jmp 0x1010194c */
        l_0x1010_1973:
            ii(0x1010_1973, 5); cmp(memw_a32[ss, ebp - 0x28], 0);       /* cmp word [ebp-0x28], 0x0 */
            ii(0x1010_1978, 6); if(jzd(0x1010_164c, -0x332)) goto l_0x1010_164c; /* jz 0x1010164c */
            ii(0x1010_197e, 2); jmpd(0x1010_194c, -0x34); goto l_0x1010_194c; /* jmp 0x1010194c */
        l_0x1010_1980:
            ii(0x1010_1980, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_1982, 5); mov(al, memb_a32[ds, 0x101c_37d0]);     /* mov al, [0x101c37d0] */
            ii(0x1010_1987, 5); calld(0x100f_4685, -0xd307);            /* call 0x100f4685 */
            ii(0x1010_198c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_198e, 5); calld(0x100f_448c, -0xd507);            /* call 0x100f448c */
            ii(0x1010_1993, 5); calld(0x100f_f5c1, -0x23d7);            /* call 0x100ff5c1 */
            ii(0x1010_1998, 7); cmp(memb_a32[ds, 0x101c_38a2], 0x2);    /* cmp byte [0x101c38a2], 0x2 */
            ii(0x1010_199f, 2); if(jnzd(0x1010_19a8, 0x7)) goto l_0x1010_19a8; /* jnz 0x101019a8 */
            ii(0x1010_19a1, 7); mov(memb_a32[ds, 0x101c_38a3], 0x1);    /* mov byte [0x101c38a3], 0x1 */
        l_0x1010_19a8:
            ii(0x1010_19a8, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1010_19ad, 5); calld(0x1013_dcdf, 0x3_c32d);           /* call 0x1013dcdf */
        l_0x1010_19b2:
            ii(0x1010_19b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_19b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_19b5, 1); popd(edi);                              /* pop edi */
            ii(0x1010_19b6, 1); popd(esi);                              /* pop esi */
            ii(0x1010_19b7, 1); retd(); return;                         /* ret */
        }
    }
}
