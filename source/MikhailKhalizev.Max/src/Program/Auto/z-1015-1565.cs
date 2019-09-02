using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_1565-51e8e957")]
        public void Method_1015_1565()
        {
            ii(0x1015_1565, 5); push(0x28);                             /* push 0x28 */
            ii(0x1015_156a, 5); call(Definitions.sys_check_available_stack_size, 0x1_47e3); /* call 0x10165d52 */
            ii(0x1015_156f, 1); push(ebx);                              /* push ebx */
            ii(0x1015_1570, 1); push(ecx);                              /* push ecx */
            ii(0x1015_1571, 1); push(edx);                              /* push edx */
            ii(0x1015_1572, 1); push(esi);                              /* push esi */
            ii(0x1015_1573, 1); push(edi);                              /* push edi */
            ii(0x1015_1574, 1); push(ebp);                              /* push ebp */
            ii(0x1015_1575, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_1577, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_157d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_1580, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1583, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_1586, 5); call(Definitions.my_2_get_count, -0xc_6223); /* call 0x1008b368 */
            ii(0x1015_158b, 1); cwde();                                 /* cwde */
            ii(0x1015_158c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_158e, 2); if(jle(0x1015_1599, 9)) goto l_0x1015_1599; /* jle 0x10151599 */
            ii(0x1015_1590, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1015_1597, 2); jmp(0x1015_15b2, 0x19); goto l_0x1015_15b2; /* jmp 0x101515b2 */
        l_0x1015_1599:
            ii(0x1015_1599, 5); mov(ecx, 0xd0e);                        /* mov ecx, 0xd0e */
            ii(0x1015_159e, 5); mov(ebx, StringDefinitions.UnitinfoCpp7); /* mov ebx, 0x101ade18 */
            ii(0x1015_15a3, 5); mov(edx, StringDefinitions.BuildListGetcountGreater05); /* mov edx, 0x101ade25 */
            ii(0x1015_15a8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_15aa, 5); call(Definitions.sys_assert, 0x1_47e3); /* call 0x10165d92 */
            ii(0x1015_15af, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x1015_15b2:
            ii(0x1015_15b2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_15b4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_15b7, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1015_15ba, 5); call(0x1008_b228, -0xc_6397);           /* call 0x1008b228 */
            ii(0x1015_15bf, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1015_15c2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_15c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_15c8, 4); test(memb[ds, eax + 19], 2);            /* test byte [eax+0x13], 0x2 */
            ii(0x1015_15cc, 6); if(jz(0x1015_16c9, 0xf7)) goto l_0x1015_16c9; /* jz 0x101516c9 */
            ii(0x1015_15d2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_15d5, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_15d8, 5); call(0x1007_6884, -0xd_ad59);           /* call 0x10076884 */
            ii(0x1015_15dd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_15df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_15e2, 5); call(0x1015_14ef, -0xf8);               /* call 0x101514ef */
            ii(0x1015_15e7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_15ea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_15ed, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_15f0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_15f3, 5); call(0x1007_1e00, -0xd_f7f8);           /* call 0x10071e00 */
            ii(0x1015_15f8, 4); sub(memw[ds, ebx + 8], ax);             /* sub [ebx+0x8], ax */
            ii(0x1015_15fc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_15ff, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_1602, 5); call(0x1007_6884, -0xd_ad83);           /* call 0x10076884 */
            ii(0x1015_1607, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_1609, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_160c, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_160f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1612, 5); call(0x1007_1f2e, -0xd_f6e9);           /* call 0x10071f2e */
            ii(0x1015_1617, 4); sub(memw[ds, ebx + 14], ax);            /* sub [ebx+0xe], ax */
            ii(0x1015_161b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_161e, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_1621, 5); call(0x1007_6884, -0xd_ada2);           /* call 0x10076884 */
            ii(0x1015_1626, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1015_1628, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_162b, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_162e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_1631, 5); call(0x1007_1ff5, -0xd_f641);           /* call 0x10071ff5 */
            ii(0x1015_1636, 4); sub(memw[ds, ebx + 16], ax);            /* sub [ebx+0x10], ax */
            ii(0x1015_163a, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1015_163d, 4); mov(memb[ds, ebx + 62], 1);             /* mov byte [ebx+0x3e], 0x1 */
            ii(0x1015_1641, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1644, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_1646, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1015_1649, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_164b, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_1650, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_1652, 2); if(jnz(0x1015_1679, 0x25)) goto l_0x1015_1679; /* jnz 0x10151679 */
            ii(0x1015_1654, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1015_1659, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1015_165e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1661, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_1664, 5); call(0x1015_52b8, 0x3c4f);              /* call 0x101552b8 */
            ii(0x1015_1669, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_166b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_166e, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1015_1671, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_1673, 1); cwde();                                 /* cwde */
            ii(0x1015_1674, 5); call(0x1010_11ff, -0x5_047a);           /* call 0x101011ff */
        l_0x1015_1679:
            ii(0x1015_1679, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_167c, 4); mov(ax, memw[ds, eax + 51]);            /* mov ax, [eax+0x33] */
            ii(0x1015_1680, 1); inc(eax);                               /* inc eax */
            ii(0x1015_1681, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_1684, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1687, 5); call(0x1014_9b07, -0x7b85);             /* call 0x10149b07 */
            ii(0x1015_168c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_168f, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1015_1694, 5); call(0x1007_6e00, -0xd_a899);           /* call 0x10076e00 */
            ii(0x1015_1699, 2); test(al, al);                           /* test al, al */
            ii(0x1015_169b, 2); if(jz(0x1015_16c7, 0x2a)) goto l_0x1015_16c7; /* jz 0x101516c7 */
            ii(0x1015_169d, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1015_16a2, 5); call(0x1007_65d0, -0xd_b0d7);           /* call 0x100765d0 */
            ii(0x1015_16a7, 5); call(0x1010_094d, -0x5_0d5f);           /* call 0x1010094d */
            ii(0x1015_16ac, 5); call(0x1010_2bf8, -0x4_eab9);           /* call 0x10102bf8 */
            ii(0x1015_16b1, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_16b3, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_16b5, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1015_16ba, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_16bd, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_16c2, 5); call(0x1013_d5c0, -0x1_4107);           /* call 0x1013d5c0 */
        l_0x1015_16c7:
            ii(0x1015_16c7, 2); jmp(0x1015_1737, 0x6e); goto l_0x1015_1737; /* jmp 0x10151737 */
        l_0x1015_16c9:
            ii(0x1015_16c9, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1015_16cd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_16d0, 5); call(0x1015_1399, -0x33c);              /* call 0x10151399 */
            ii(0x1015_16d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_16d8, 5); call(0x1015_48ba, 0x31dd);              /* call 0x101548ba */
            ii(0x1015_16dd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_16e0, 4); mov(memb[ds, eax + 94], 0);             /* mov byte [eax+0x5e], 0x0 */
            ii(0x1015_16e4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_16e7, 4); mov(memb[ds, eax + 62], 0xb);           /* mov byte [eax+0x3e], 0xb */
            ii(0x1015_16eb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_16ee, 5); cmp(memw[ds, eax + 8], 0x31);           /* cmp word [eax+0x8], 0x31 */
            ii(0x1015_16f3, 2); if(jnz(0x1015_1709, 0x14)) goto l_0x1015_1709; /* jnz 0x10151709 */
            ii(0x1015_16f5, 5); mov(ebx, 0x22);                         /* mov ebx, 0x22 */
            ii(0x1015_16fa, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1015_16ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1702, 5); call(0x1016_2f96, 0x1_188f);            /* call 0x10162f96 */
            ii(0x1015_1707, 2); jmp(0x1015_172f, 0x26); goto l_0x1015_172f; /* jmp 0x1015172f */
        l_0x1015_1709:
            ii(0x1015_1709, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1015_170d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1710, 5); call(0x1015_1172, -0x5a3);              /* call 0x10151172 */
            ii(0x1015_1715, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1718, 7); mov(ax, memw[ds, eax + 213]);           /* mov ax, [eax+0xd5] */
            ii(0x1015_171f, 5); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1015_1724, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_1727, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_172a, 5); call(0x1014_9b07, -0x7c28);             /* call 0x10149b07 */
        l_0x1015_172f:
            ii(0x1015_172f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_1732, 5); call(0x1014_b6bd, -0x607a);             /* call 0x1014b6bd */
        l_0x1015_1737:
            ii(0x1015_1737, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_1739, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_173a, 1); pop(edi);                               /* pop edi */
            ii(0x1015_173b, 1); pop(esi);                               /* pop esi */
            ii(0x1015_173c, 1); pop(edx);                               /* pop edx */
            ii(0x1015_173d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_173e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_173f, 1); ret();                                  /* ret */
        }
    }
}
