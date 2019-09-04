using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_15e0-924fbf81")]
        public void Method_001a_15e0()
        {
            ii(0x1a_15e0, 4);  enter(0x2a, 0);                         /* enter 0x2a, 0x0 */
            ii(0x1a_15e4, 1);  push(di);                               /* push di */
            ii(0x1a_15e5, 1);  push(si);                               /* push si */
            ii(0x1a_15e6, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x1a_15eb, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_15ee, 4);  mov(ax, memw[es, bx + 40]);             /* mov ax, [es:bx+0x28] */
            ii(0x1a_15f2, 4);  mov(dx, memw[es, bx + 42]);             /* mov dx, [es:bx+0x2a] */
            ii(0x1a_15f6, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x1a_15f8, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x1a_15fa, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x1a_15fc, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x1a_15fe, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x1a_1600, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x1a_1603, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1606, 4);  mov(al, memb[es, bx + 40]);             /* mov al, [es:bx+0x28] */
            ii(0x1a_160a, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x1a_160c, 3);  mov(memw[ss, bp - 36], ax);             /* mov [bp-0x24], ax */
            ii(0x1a_160f, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1612, 4);  mov(ax, memw[es, bx + 28]);             /* mov ax, [es:bx+0x1c] */
            ii(0x1a_1616, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x1a_1619, 3);  mov(al, memb[ss, bp - 26]);             /* mov al, [bp-0x1a] */
            ii(0x1a_161c, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x1a_161e, 3);  mov(memw[ss, bp - 38], ax);             /* mov [bp-0x26], ax */
            ii(0x1a_1621, 3);  mov(ax, memw[ss, bp - 24]);             /* mov ax, [bp-0x18] */
            ii(0x1a_1624, 3);  jmp(0x1a_1729, 0x102); goto l_0x1a_1729;/* jmp 0x1729 */
        l_0x1a_1627:
            ii(0x1a_1627, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x1a_162a, 3);  jmp(0x1a_1635, 8); goto l_0x1a_1635;    /* jmp 0x1635 */
        l_0x1a_162d:
            ii(0x1a_162d, 5);  mov(memw[ss, bp - 2], 1);               /* mov word [bp-0x2], 0x1 */
            ii(0x1a_1632, 3);  jmp(0x1a_1657, 0x22); goto l_0x1a_1657; /* jmp 0x1657 */
        l_0x1a_1635:
            ii(0x1a_1635, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1636, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1637, 2);  if(jnz(0x1a_163c, 3)) goto l_0x1a_163c; /* jnz 0x163c */
            ii(0x1a_1639, 3);  jmp(0x1a_162d, -0xf); goto l_0x1a_162d; /* jmp 0x162d */
        l_0x1a_163c:
            ii(0x1a_163c, 3);  sub(ax, 7);                             /* sub ax, 0x7 */
            ii(0x1a_163f, 2);  if(jnz(0x1a_1644, 3)) goto l_0x1a_1644; /* jnz 0x1644 */
            ii(0x1a_1641, 3);  jmp(0x1a_162d, -0x17); goto l_0x1a_162d;/* jmp 0x162d */
        l_0x1a_1644:
            ii(0x1a_1644, 3);  sub(ax, 9);                             /* sub ax, 0x9 */
            ii(0x1a_1647, 2);  if(jnz(0x1a_164c, 3)) goto l_0x1a_164c; /* jnz 0x164c */
            ii(0x1a_1649, 3);  jmp(0x1a_162d, -0x1f); goto l_0x1a_162d;/* jmp 0x162d */
        l_0x1a_164c:
            ii(0x1a_164c, 3);  sub(ax, 5);                             /* sub ax, 0x5 */
            ii(0x1a_164f, 2);  if(jnz(0x1a_1654, 3)) goto l_0x1a_1654; /* jnz 0x1654 */
            ii(0x1a_1651, 3);  jmp(0x1a_162d, -0x27); goto l_0x1a_162d;/* jmp 0x162d */
        l_0x1a_1654:
            ii(0x1a_1654, 3);  jmp(0x1a_1657, 0); goto l_0x1a_1657;    /* jmp 0x1657 */
        l_0x1a_1657:
            ii(0x1a_1657, 3);  jmp(0x1a_1766, 0x10c); goto l_0x1a_1766;/* jmp 0x1766 */
        l_0x1a_165a:
            ii(0x1a_165a, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x1a_165d, 3);  jmp(0x1a_166d, 0xd); goto l_0x1a_166d;  /* jmp 0x166d */
        l_0x1a_1660:
            ii(0x1a_1660, 5);  mov(memw[ss, bp - 2], 2);               /* mov word [bp-0x2], 0x2 */
        l_0x1a_1665:
            ii(0x1a_1665, 5);  mov(memw[ss, bp - 2], 5);               /* mov word [bp-0x2], 0x5 */
            ii(0x1a_166a, 3);  jmp(0x1a_169f, 0x32); goto l_0x1a_169f; /* jmp 0x169f */
        l_0x1a_166d:
            ii(0x1a_166d, 3);  cmp(ax, 0x10);                          /* cmp ax, 0x10 */
            ii(0x1a_1670, 2);  if(jnz(0x1a_1675, 3)) goto l_0x1a_1675; /* jnz 0x1675 */
            ii(0x1a_1672, 3);  jmp(0x1a_1660, -0x15); goto l_0x1a_1660;/* jmp 0x1660 */
        l_0x1a_1675:
            ii(0x1a_1675, 2);  if(jbe(0x1a_167a, 3)) goto l_0x1a_167a; /* jbe 0x167a */
            ii(0x1a_1677, 3);  jmp(0x1a_1684, 0xa); goto l_0x1a_1684;  /* jmp 0x1684 */
        l_0x1a_167a:
            ii(0x1a_167a, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x1a_167c, 2);  if(jnz(0x1a_1681, 3)) goto l_0x1a_1681; /* jnz 0x1681 */
            ii(0x1a_167e, 3);  jmp(0x1a_1660, -0x21); goto l_0x1a_1660;/* jmp 0x1660 */
        l_0x1a_1681:
            ii(0x1a_1681, 3);  jmp(0x1a_169f, 0x1b); goto l_0x1a_169f; /* jmp 0x169f */
        l_0x1a_1684:
            ii(0x1a_1684, 3);  sub(ax, 0x20);                          /* sub ax, 0x20 */
            ii(0x1a_1687, 2);  if(jae(0x1a_168c, 3)) goto l_0x1a_168c; /* jae 0x168c */
            ii(0x1a_1689, 3);  jmp(0x1a_169f, 0x13); goto l_0x1a_169f; /* jmp 0x169f */
        l_0x1a_168c:
            ii(0x1a_168c, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x1a_168f, 2);  if(ja(0x1a_1694, 3)) goto l_0x1a_1694;  /* ja 0x1694 */
            ii(0x1a_1691, 3);  jmp(0x1a_1660, -0x34); goto l_0x1a_1660;/* jmp 0x1660 */
        l_0x1a_1694:
            ii(0x1a_1694, 3);  sub(ax, 0xf);                           /* sub ax, 0xf */
            ii(0x1a_1697, 2);  if(jnz(0x1a_169c, 3)) goto l_0x1a_169c; /* jnz 0x169c */
            ii(0x1a_1699, 3);  jmp(0x1a_1665, -0x37); goto l_0x1a_1665;/* jmp 0x1665 */
        l_0x1a_169c:
            ii(0x1a_169c, 3);  jmp(0x1a_169f, 0); goto l_0x1a_169f;    /* jmp 0x169f */
        l_0x1a_169f:
            ii(0x1a_169f, 3);  jmp(0x1a_1766, 0xc4); goto l_0x1a_1766; /* jmp 0x1766 */
        l_0x1a_16a2:
            ii(0x1a_16a2, 4);  cmp(memw[ss, bp - 38], 0x35);           /* cmp word [bp-0x26], 0x35 */
            ii(0x1a_16a6, 2);  if(jz(0x1a_16ab, 3)) goto l_0x1a_16ab;  /* jz 0x16ab */
            ii(0x1a_16a8, 3);  jmp(0x1a_16d3, 0x28); goto l_0x1a_16d3; /* jmp 0x16d3 */
        l_0x1a_16ab:
            ii(0x1a_16ab, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x1a_16ae, 3);  jmp(0x1a_16b9, 8); goto l_0x1a_16b9;    /* jmp 0x16b9 */
        l_0x1a_16b1:
            ii(0x1a_16b1, 5);  mov(memw[ss, bp - 2], 1);               /* mov word [bp-0x2], 0x1 */
            ii(0x1a_16b6, 3);  jmp(0x1a_16d3, 0x1a); goto l_0x1a_16d3; /* jmp 0x16d3 */
        l_0x1a_16b9:
            ii(0x1a_16b9, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x1a_16bb, 2);  if(jnz(0x1a_16c0, 3)) goto l_0x1a_16c0; /* jnz 0x16c0 */
            ii(0x1a_16bd, 3);  jmp(0x1a_16b1, -0xf); goto l_0x1a_16b1; /* jmp 0x16b1 */
        l_0x1a_16c0:
            ii(0x1a_16c0, 3);  sub(ax, 2);                             /* sub ax, 0x2 */
            ii(0x1a_16c3, 2);  if(jae(0x1a_16c8, 3)) goto l_0x1a_16c8; /* jae 0x16c8 */
            ii(0x1a_16c5, 3);  jmp(0x1a_16d3, 0xb); goto l_0x1a_16d3;  /* jmp 0x16d3 */
        l_0x1a_16c8:
            ii(0x1a_16c8, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x1a_16cb, 2);  if(ja(0x1a_16d0, 3)) goto l_0x1a_16d0;  /* ja 0x16d0 */
            ii(0x1a_16cd, 3);  jmp(0x1a_16b1, -0x1f); goto l_0x1a_16b1;/* jmp 0x16b1 */
        l_0x1a_16d0:
            ii(0x1a_16d0, 3);  jmp(0x1a_16d3, 0); goto l_0x1a_16d3;    /* jmp 0x16d3 */
        l_0x1a_16d3:
            ii(0x1a_16d3, 3);  jmp(0x1a_1766, 0x90); goto l_0x1a_1766; /* jmp 0x1766 */
        l_0x1a_16d6:
            ii(0x1a_16d6, 5);  mov(memw[ss, bp - 2], 2);               /* mov word [bp-0x2], 0x2 */
            ii(0x1a_16db, 3);  jmp(0x1a_1766, 0x88); goto l_0x1a_1766; /* jmp 0x1766 */
        l_0x1a_16de:
            ii(0x1a_16de, 4);  cmp(memw[ss, bp - 26], 0);              /* cmp word [bp-0x1a], 0x0 */
            ii(0x1a_16e2, 2);  if(jz(0x1a_16e7, 3)) goto l_0x1a_16e7;  /* jz 0x16e7 */
            ii(0x1a_16e4, 3);  jmp(0x1a_16ec, 5); goto l_0x1a_16ec;    /* jmp 0x16ec */
        l_0x1a_16e7:
            ii(0x1a_16e7, 5);  mov(memw[ss, bp - 2], 3);               /* mov word [bp-0x2], 0x3 */
        l_0x1a_16ec:
            ii(0x1a_16ec, 3);  jmp(0x1a_1766, 0x77); goto l_0x1a_1766; /* jmp 0x1766 */
        l_0x1a_16ef:
            ii(0x1a_16ef, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x1a_16f2, 3);  jmp(0x1a_16fd, 8); goto l_0x1a_16fd;    /* jmp 0x16fd */
        l_0x1a_16f5:
            ii(0x1a_16f5, 5);  mov(memw[ss, bp - 2], 4);               /* mov word [bp-0x2], 0x4 */
            ii(0x1a_16fa, 3);  jmp(0x1a_1720, 0x23); goto l_0x1a_1720; /* jmp 0x1720 */
        l_0x1a_16fd:
            ii(0x1a_16fd, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x1a_1700, 2);  if(jae(0x1a_1705, 3)) goto l_0x1a_1705; /* jae 0x1705 */
            ii(0x1a_1702, 3);  jmp(0x1a_1720, 0x1b); goto l_0x1a_1720; /* jmp 0x1720 */
        l_0x1a_1705:
            ii(0x1a_1705, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x1a_1708, 2);  if(ja(0x1a_170d, 3)) goto l_0x1a_170d;  /* ja 0x170d */
            ii(0x1a_170a, 3);  jmp(0x1a_16f5, -0x18); goto l_0x1a_16f5;/* jmp 0x16f5 */
        l_0x1a_170d:
            ii(0x1a_170d, 3);  sub(ax, 0x8f);                          /* sub ax, 0x8f */
            ii(0x1a_1710, 2);  if(jae(0x1a_1715, 3)) goto l_0x1a_1715; /* jae 0x1715 */
            ii(0x1a_1712, 3);  jmp(0x1a_1720, 0xb); goto l_0x1a_1720;  /* jmp 0x1720 */
        l_0x1a_1715:
            ii(0x1a_1715, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x1a_1718, 2);  if(ja(0x1a_171d, 3)) goto l_0x1a_171d;  /* ja 0x171d */
            ii(0x1a_171a, 3);  jmp(0x1a_16f5, -0x28); goto l_0x1a_16f5;/* jmp 0x16f5 */
        l_0x1a_171d:
            ii(0x1a_171d, 3);  jmp(0x1a_1720, 0); goto l_0x1a_1720;    /* jmp 0x1720 */
        l_0x1a_1720:
            ii(0x1a_1720, 3);  jmp(0x1a_1766, 0x43); goto l_0x1a_1766; /* jmp 0x1766 */
        l_0x1a_1723:
            ii(0x1a_1723, 3);  jmp(0x1a_1766, 0x40); goto l_0x1a_1766; /* jmp 0x1766 */
        //  ii(0x1a_1726, 3);  jmp(0x1a_1766, 0x3d); goto l_0x1a_1766; /* jmp 0x1766 */
        l_0x1a_1729:
            ii(0x1a_1729, 3);  cmp(ax, 0x13);                          /* cmp ax, 0x13 */
            ii(0x1a_172c, 2);  if(jnz(0x1a_1731, 3)) goto l_0x1a_1731; /* jnz 0x1731 */
            ii(0x1a_172e, 3);  jmp(0x1a_16d6, -0x5b); goto l_0x1a_16d6;/* jmp 0x16d6 */
        l_0x1a_1731:
            ii(0x1a_1731, 2);  if(jbe(0x1a_1736, 3)) goto l_0x1a_1736; /* jbe 0x1736 */
            ii(0x1a_1733, 3);  jmp(0x1a_174d, 0x17); goto l_0x1a_174d; /* jmp 0x174d */
        l_0x1a_1736:
            ii(0x1a_1736, 3);  sub(ax, 0x10);                          /* sub ax, 0x10 */
            ii(0x1a_1739, 2);  if(jnz(0x1a_173e, 3)) goto l_0x1a_173e; /* jnz 0x173e */
            ii(0x1a_173b, 3);  jmp(0x1a_1627, -0x117); goto l_0x1a_1627;/* jmp 0x1627 */
        l_0x1a_173e:
            ii(0x1a_173e, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_173f, 2);  if(jnz(0x1a_1744, 3)) goto l_0x1a_1744; /* jnz 0x1744 */
            ii(0x1a_1741, 3);  jmp(0x1a_165a, -0xea); goto l_0x1a_165a;/* jmp 0x165a */
        l_0x1a_1744:
            ii(0x1a_1744, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1745, 2);  if(jnz(0x1a_174a, 3)) goto l_0x1a_174a; /* jnz 0x174a */
            ii(0x1a_1747, 3);  jmp(0x1a_16a2, -0xa8); goto l_0x1a_16a2;/* jmp 0x16a2 */
        l_0x1a_174a:
            ii(0x1a_174a, 3);  jmp(0x1a_1723, -0x2a); goto l_0x1a_1723;/* jmp 0x1723 */
        l_0x1a_174d:
            ii(0x1a_174d, 3);  sub(ax, 0x1b);                          /* sub ax, 0x1b */
            ii(0x1a_1750, 2);  if(jnz(0x1a_1755, 3)) goto l_0x1a_1755; /* jnz 0x1755 */
            ii(0x1a_1752, 3);  jmp(0x1a_16de, -0x77); goto l_0x1a_16de;/* jmp 0x16de */
        l_0x1a_1755:
            ii(0x1a_1755, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1756, 2);  if(jnz(0x1a_175b, 3)) goto l_0x1a_175b; /* jnz 0x175b */
            ii(0x1a_1758, 3);  jmp(0x1a_16ef, -0x6c); goto l_0x1a_16ef;/* jmp 0x16ef */
        l_0x1a_175b:
            ii(0x1a_175b, 3);  sub(ax, 0x43);                          /* sub ax, 0x43 */
            ii(0x1a_175e, 2);  if(jnz(0x1a_1763, 3)) goto l_0x1a_1763; /* jnz 0x1763 */
            ii(0x1a_1760, 3);  jmp(0x1a_16ef, -0x74); goto l_0x1a_16ef;/* jmp 0x16ef */
        l_0x1a_1763:
            ii(0x1a_1763, 3);  jmp(0x1a_1723, -0x43); goto l_0x1a_1723;/* jmp 0x1723 */
        l_0x1a_1766:
            ii(0x1a_1766, 4);  cmp(memw[ss, bp - 2], 0);               /* cmp word [bp-0x2], 0x0 */
            ii(0x1a_176a, 2);  if(jz(0x1a_176f, 3)) goto l_0x1a_176f;  /* jz 0x176f */
            ii(0x1a_176c, 3);  jmp(0x1a_1775, 6); goto l_0x1a_1775;    /* jmp 0x1775 */
        l_0x1a_176f:
            ii(0x1a_176f, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x1a_1772, 3);  jmp(0x1a_1af2, 0x37d); goto l_0x1a_1af2;/* jmp 0x1af2 */
        l_0x1a_1775:
            ii(0x1a_1775, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1778, 4);  mov(ax, memw[es, bx + 40]);             /* mov ax, [es:bx+0x28] */
            ii(0x1a_177c, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x1a_177f, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1782, 4);  mov(ax, memw[es, bx + 28]);             /* mov ax, [es:bx+0x1c] */
            ii(0x1a_1786, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x1a_1789, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_178c, 4);  mov(ax, memw[es, bx + 36]);             /* mov ax, [es:bx+0x24] */
            ii(0x1a_1790, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x1a_1793, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1796, 4);  mov(ax, memw[es, bx + 32]);             /* mov ax, [es:bx+0x20] */
            ii(0x1a_179a, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x1a_179d, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_17a0, 4);  mov(ax, memw[es, bx + 16]);             /* mov ax, [es:bx+0x10] */
            ii(0x1a_17a4, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x1a_17a7, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_17aa, 4);  mov(ax, memw[es, bx + 12]);             /* mov ax, [es:bx+0xc] */
            ii(0x1a_17ae, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x1a_17b1, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_17b4, 4);  mov(ax, memw[es, bx + 20]);             /* mov ax, [es:bx+0x14] */
            ii(0x1a_17b8, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x1a_17bb, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_17be, 4);  mov(ax, memw[es, bx + 6]);              /* mov ax, [es:bx+0x6] */
            ii(0x1a_17c2, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x1a_17c5, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_17c8, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x1a_17cc, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x1a_17cf, 4);  mov(memb[ss, bp - 34], 0);              /* mov byte [bp-0x22], 0x0 */
            ii(0x1a_17d3, 4);  cmp(memw[ss, bp - 2], 5);               /* cmp word [bp-0x2], 0x5 */
            ii(0x1a_17d7, 2);  if(jnz(0x1a_17dc, 3)) goto l_0x1a_17dc; /* jnz 0x17dc */
            ii(0x1a_17d9, 3);  jmp(0x1a_17ee, 0x12); goto l_0x1a_17ee; /* jmp 0x17ee */
        l_0x1a_17dc:
            ii(0x1a_17dc, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_17df, 4);  push(memw[es, bx + 6]);                 /* push word [es:bx+0x6] */
            ii(0x1a_17e3, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x1a_17e8, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x1a_17eb, 3);  mov(memb[ss, bp - 34], al);             /* mov [bp-0x22], al */
        l_0x1a_17ee:
            ii(0x1a_17ee, 4);  cmp(memb[ss, bp - 34], 0);              /* cmp byte [bp-0x22], 0x0 */
            ii(0x1a_17f2, 2);  if(jnz(0x1a_17f7, 3)) goto l_0x1a_17f7; /* jnz 0x17f7 */
            ii(0x1a_17f4, 3);  jmp(0x1a_192f, 0x138); goto l_0x1a_192f;/* jmp 0x192f */
        l_0x1a_17f7:
            ii(0x1a_17f7, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x1a_17fa, 3);  jmp(0x1a_1914, 0x117); goto l_0x1a_1914;/* jmp 0x1914 */
        l_0x1a_17fd:
            ii(0x1a_17fd, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1800, 4);  mov(ax, memw[es, bx + 32]);             /* mov ax, [es:bx+0x20] */
            ii(0x1a_1804, 4);  mov(dx, memw[es, bx + 34]);             /* mov dx, [es:bx+0x22] */
            ii(0x1a_1808, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x1a_180b, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x1a_180e, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1811, 4);  push(memw[es, bx + 34]);                /* push word [es:bx+0x22] */
            ii(0x1a_1815, 4);  push(memw[es, bx + 32]);                /* push word [es:bx+0x20] */
            ii(0x1a_1819, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_181c, 4);  push(memw[es, bx + 6]);                 /* push word [es:bx+0x6] */
            ii(0x1a_1820, 5);  call_far_abs(0x88, 0x247c);             /* call word 0x88:0x247c */
            ii(0x1a_1825, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x1a_1828, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
            ii(0x1a_182d, 3);  mov(memw[ss, bp - 40], ax);             /* mov [bp-0x28], ax */
            ii(0x1a_1830, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x1a_1833, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x1a_1836, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x1a_1839, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x1a_183c, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x1a_183f, 3);  jmp(0x1a_192f, 0xed); goto l_0x1a_192f; /* jmp 0x192f */
        l_0x1a_1842:
            ii(0x1a_1842, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1845, 4);  mov(ax, memw[es, bx + 12]);             /* mov ax, [es:bx+0xc] */
            ii(0x1a_1849, 4);  mov(dx, memw[es, bx + 14]);             /* mov dx, [es:bx+0xe] */
            ii(0x1a_184d, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x1a_1850, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x1a_1853, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1856, 4);  push(memw[es, bx + 14]);                /* push word [es:bx+0xe] */
            ii(0x1a_185a, 4);  push(memw[es, bx + 12]);                /* push word [es:bx+0xc] */
            ii(0x1a_185e, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1861, 4);  push(memw[es, bx + 6]);                 /* push word [es:bx+0x6] */
            ii(0x1a_1865, 5);  call_far_abs(0x88, 0x247c);             /* call word 0x88:0x247c */
            ii(0x1a_186a, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x1a_186d, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
            ii(0x1a_1872, 3);  mov(memw[ss, bp - 40], ax);             /* mov [bp-0x28], ax */
            ii(0x1a_1875, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x1a_1878, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x1a_187b, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x1a_187e, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x1a_1881, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x1a_1884, 3);  jmp(0x1a_192f, 0xa8); goto l_0x1a_192f; /* jmp 0x192f */
        l_0x1a_1887:
            ii(0x1a_1887, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_188a, 4);  mov(ax, memw[es, bx + 28]);             /* mov ax, [es:bx+0x1c] */
            ii(0x1a_188e, 4);  mov(dx, memw[es, bx + 30]);             /* mov dx, [es:bx+0x1e] */
            ii(0x1a_1892, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x1a_1895, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x1a_1898, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_189b, 4);  push(memw[es, bx + 30]);                /* push word [es:bx+0x1e] */
            ii(0x1a_189f, 4);  push(memw[es, bx + 28]);                /* push word [es:bx+0x1c] */
            ii(0x1a_18a3, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_18a6, 4);  push(memw[es, bx + 6]);                 /* push word [es:bx+0x6] */
            ii(0x1a_18aa, 5);  call_far_abs(0x88, 0x247c);             /* call word 0x88:0x247c */
            ii(0x1a_18af, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x1a_18b2, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
            ii(0x1a_18b7, 3);  mov(memw[ss, bp - 40], ax);             /* mov [bp-0x28], ax */
            ii(0x1a_18ba, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x1a_18bd, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x1a_18c0, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x1a_18c3, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x1a_18c6, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x1a_18c9, 3);  jmp(0x1a_192f, 0x63); goto l_0x1a_192f; /* jmp 0x192f */
        l_0x1a_18cc:
            ii(0x1a_18cc, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_18cf, 4);  mov(ax, memw[es, bx + 20]);             /* mov ax, [es:bx+0x14] */
            ii(0x1a_18d3, 4);  mov(dx, memw[es, bx + 22]);             /* mov dx, [es:bx+0x16] */
            ii(0x1a_18d7, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x1a_18da, 3);  mov(memw[ss, bp - 28], dx);             /* mov [bp-0x1c], dx */
            ii(0x1a_18dd, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_18e0, 4);  push(memw[es, bx + 22]);                /* push word [es:bx+0x16] */
            ii(0x1a_18e4, 4);  push(memw[es, bx + 20]);                /* push word [es:bx+0x14] */
            ii(0x1a_18e8, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_18eb, 4);  push(memw[es, bx + 6]);                 /* push word [es:bx+0x6] */
            ii(0x1a_18ef, 5);  call_far_abs(0x88, 0x247c);             /* call word 0x88:0x247c */
            ii(0x1a_18f4, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x1a_18f7, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
            ii(0x1a_18fc, 3);  mov(memw[ss, bp - 40], ax);             /* mov [bp-0x28], ax */
            ii(0x1a_18ff, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x1a_1902, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x1a_1905, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x1a_1908, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x1a_190b, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x1a_190e, 3);  jmp(0x1a_192f, 0x1e); goto l_0x1a_192f; /* jmp 0x192f */
        //  ii(0x1a_1911, 3);  jmp(0x1a_192f, 0x1b); goto l_0x1a_192f; /* jmp 0x192f */
        l_0x1a_1914:
            ii(0x1a_1914, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1915, 2);  if(jnz(0x1a_191a, 3)) goto l_0x1a_191a; /* jnz 0x191a */
            ii(0x1a_1917, 3);  jmp(0x1a_17fd, -0x11d); goto l_0x1a_17fd;/* jmp 0x17fd */
        l_0x1a_191a:
            ii(0x1a_191a, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_191b, 2);  if(jnz(0x1a_1920, 3)) goto l_0x1a_1920; /* jnz 0x1920 */
            ii(0x1a_191d, 3);  jmp(0x1a_18cc, -0x54); goto l_0x1a_18cc;/* jmp 0x18cc */
        l_0x1a_1920:
            ii(0x1a_1920, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1921, 2);  if(jnz(0x1a_1926, 3)) goto l_0x1a_1926; /* jnz 0x1926 */
            ii(0x1a_1923, 3);  jmp(0x1a_1842, -0xe4); goto l_0x1a_1842;/* jmp 0x1842 */
        l_0x1a_1926:
            ii(0x1a_1926, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1927, 2);  if(jnz(0x1a_192c, 3)) goto l_0x1a_192c; /* jnz 0x192c */
            ii(0x1a_1929, 3);  jmp(0x1a_1887, -0xa5); goto l_0x1a_1887;/* jmp 0x1887 */
        l_0x1a_192c:
            ii(0x1a_192c, 3);  jmp(0x1a_192f, 0); goto l_0x1a_192f;    /* jmp 0x192f */
        l_0x1a_192f:
            ii(0x1a_192f, 3);  lea(ax, memw[ss, bp - 22]);             /* lea ax, [bp-0x16] */
            ii(0x1a_1932, 1);  push(ss);                               /* push ss */
            ii(0x1a_1933, 1);  push(ax);                               /* push ax */
            ii(0x1a_1934, 5);  call_far_abs(0x80, 0x1abf);             /* call word 0x80:0x1abf */
            ii(0x1a_1939, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x1a_193c, 4);  cmp(memb[ss, bp - 34], 0);              /* cmp byte [bp-0x22], 0x0 */
            ii(0x1a_1940, 2);  if(jnz(0x1a_1945, 3)) goto l_0x1a_1945; /* jnz 0x1945 */
            ii(0x1a_1942, 3);  jmp(0x1a_194a, 5); goto l_0x1a_194a;    /* jmp 0x194a */
        l_0x1a_1945:
            ii(0x1a_1945, 5);  call_far_abs(0x88, 0x24a6);             /* call word 0x88:0x24a6 */
        l_0x1a_194a:
            ii(0x1a_194a, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_194d, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_194f, 4);  mov(memw[es, bx + 42], ax);             /* mov [es:bx+0x2a], ax */
            ii(0x1a_1953, 4);  mov(memw[es, bx + 40], ax);             /* mov [es:bx+0x28], ax */
            ii(0x1a_1957, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x1a_195a, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_195c, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_195f, 4);  or(memw[es, bx + 40], ax);              /* or [es:bx+0x28], ax */
            ii(0x1a_1963, 4);  or(memw[es, bx + 42], dx);              /* or [es:bx+0x2a], dx */
            ii(0x1a_1967, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_196a, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_196c, 4);  mov(memw[es, bx + 42], ax);             /* mov [es:bx+0x2a], ax */
            ii(0x1a_1970, 4);  mov(memw[es, bx + 40], ax);             /* mov [es:bx+0x28], ax */
            ii(0x1a_1974, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x1a_1977, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_1979, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_197c, 4);  or(memw[es, bx + 40], ax);              /* or [es:bx+0x28], ax */
            ii(0x1a_1980, 4);  or(memw[es, bx + 42], dx);              /* or [es:bx+0x2a], dx */
            ii(0x1a_1984, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1987, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_1989, 4);  mov(memw[es, bx + 30], ax);             /* mov [es:bx+0x1e], ax */
            ii(0x1a_198d, 4);  mov(memw[es, bx + 28], ax);             /* mov [es:bx+0x1c], ax */
            ii(0x1a_1991, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x1a_1994, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_1996, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1999, 4);  or(memw[es, bx + 28], ax);              /* or [es:bx+0x1c], ax */
            ii(0x1a_199d, 4);  or(memw[es, bx + 30], dx);              /* or [es:bx+0x1e], dx */
            ii(0x1a_19a1, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_19a4, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_19a6, 4);  mov(memw[es, bx + 38], ax);             /* mov [es:bx+0x26], ax */
            ii(0x1a_19aa, 4);  mov(memw[es, bx + 36], ax);             /* mov [es:bx+0x24], ax */
            ii(0x1a_19ae, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x1a_19b1, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_19b3, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_19b6, 4);  or(memw[es, bx + 36], ax);              /* or [es:bx+0x24], ax */
            ii(0x1a_19ba, 4);  or(memw[es, bx + 38], dx);              /* or [es:bx+0x26], dx */
            ii(0x1a_19be, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_19c1, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_19c3, 4);  mov(memw[es, bx + 34], ax);             /* mov [es:bx+0x22], ax */
            ii(0x1a_19c7, 4);  mov(memw[es, bx + 32], ax);             /* mov [es:bx+0x20], ax */
            ii(0x1a_19cb, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x1a_19ce, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_19d0, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_19d3, 4);  or(memw[es, bx + 32], ax);              /* or [es:bx+0x20], ax */
            ii(0x1a_19d7, 4);  or(memw[es, bx + 34], dx);              /* or [es:bx+0x22], dx */
            ii(0x1a_19db, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_19de, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_19e0, 4);  mov(memw[es, bx + 18], ax);             /* mov [es:bx+0x12], ax */
            ii(0x1a_19e4, 4);  mov(memw[es, bx + 16], ax);             /* mov [es:bx+0x10], ax */
            ii(0x1a_19e8, 3);  mov(ax, memw[ss, bp - 16]);             /* mov ax, [bp-0x10] */
            ii(0x1a_19eb, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_19ed, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_19f0, 4);  or(memw[es, bx + 16], ax);              /* or [es:bx+0x10], ax */
            ii(0x1a_19f4, 4);  or(memw[es, bx + 18], dx);              /* or [es:bx+0x12], dx */
            ii(0x1a_19f8, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_19fb, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_19fd, 4);  mov(memw[es, bx + 14], ax);             /* mov [es:bx+0xe], ax */
            ii(0x1a_1a01, 4);  mov(memw[es, bx + 12], ax);             /* mov [es:bx+0xc], ax */
            ii(0x1a_1a05, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x1a_1a08, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_1a0a, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1a0d, 4);  or(memw[es, bx + 12], ax);              /* or [es:bx+0xc], ax */
            ii(0x1a_1a11, 4);  or(memw[es, bx + 14], dx);              /* or [es:bx+0xe], dx */
            ii(0x1a_1a15, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1a18, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_1a1a, 4);  mov(memw[es, bx + 22], ax);             /* mov [es:bx+0x16], ax */
            ii(0x1a_1a1e, 4);  mov(memw[es, bx + 20], ax);             /* mov [es:bx+0x14], ax */
            ii(0x1a_1a22, 3);  mov(ax, memw[ss, bp - 14]);             /* mov ax, [bp-0xe] */
            ii(0x1a_1a25, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_1a27, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1a2a, 4);  or(memw[es, bx + 20], ax);              /* or [es:bx+0x14], ax */
            ii(0x1a_1a2e, 4);  or(memw[es, bx + 22], dx);              /* or [es:bx+0x16], dx */
            ii(0x1a_1a32, 4);  cmp(memb[ss, bp - 34], 0);              /* cmp byte [bp-0x22], 0x0 */
            ii(0x1a_1a36, 2);  if(jz(0x1a_1a3b, 3)) goto l_0x1a_1a3b;  /* jz 0x1a3b */
            ii(0x1a_1a38, 3);  jmp(0x1a_1a45, 0xa); goto l_0x1a_1a45;  /* jmp 0x1a45 */
        l_0x1a_1a3b:
            ii(0x1a_1a3b, 3);  mov(ax, memw[ss, bp - 20]);             /* mov ax, [bp-0x14] */
            ii(0x1a_1a3e, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1a41, 4);  mov(memw[es, bx + 6], ax);              /* mov [es:bx+0x6], ax */
        l_0x1a_1a45:
            ii(0x1a_1a45, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x1a_1a48, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1a4b, 4);  mov(memw[es, bx + 4], ax);              /* mov [es:bx+0x4], ax */
            ii(0x1a_1a4f, 4);  cmp(memb[ss, bp - 34], 0);              /* cmp byte [bp-0x22], 0x0 */
            ii(0x1a_1a53, 2);  if(jnz(0x1a_1a58, 3)) goto l_0x1a_1a58; /* jnz 0x1a58 */
            ii(0x1a_1a55, 3);  jmp(0x1a_1aec, 0x94); goto l_0x1a_1aec; /* jmp 0x1aec */
        l_0x1a_1a58:
            ii(0x1a_1a58, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x1a_1a5b, 3);  jmp(0x1a_1ad1, 0x73); goto l_0x1a_1ad1; /* jmp 0x1ad1 */
        l_0x1a_1a5e:
            ii(0x1a_1a5e, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x1a_1a61, 3);  sub(ax, memw[ss, bp - 32]);             /* sub ax, [bp-0x20] */
            ii(0x1a_1a64, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_1a66, 3);  add(ax, memw[ss, bp - 30]);             /* add ax, [bp-0x1e] */
            ii(0x1a_1a69, 3);  adc(dx, memw[ss, bp - 28]);             /* adc dx, [bp-0x1c] */
            ii(0x1a_1a6c, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1a6f, 4);  mov(memw[es, bx + 32], ax);             /* mov [es:bx+0x20], ax */
            ii(0x1a_1a73, 4);  mov(memw[es, bx + 34], dx);             /* mov [es:bx+0x22], dx */
            ii(0x1a_1a77, 3);  jmp(0x1a_1aec, 0x72); goto l_0x1a_1aec; /* jmp 0x1aec */
        l_0x1a_1a7a:
            ii(0x1a_1a7a, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x1a_1a7d, 3);  sub(ax, memw[ss, bp - 32]);             /* sub ax, [bp-0x20] */
            ii(0x1a_1a80, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_1a82, 3);  add(ax, memw[ss, bp - 30]);             /* add ax, [bp-0x1e] */
            ii(0x1a_1a85, 3);  adc(dx, memw[ss, bp - 28]);             /* adc dx, [bp-0x1c] */
            ii(0x1a_1a88, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1a8b, 4);  mov(memw[es, bx + 12], ax);             /* mov [es:bx+0xc], ax */
            ii(0x1a_1a8f, 4);  mov(memw[es, bx + 14], dx);             /* mov [es:bx+0xe], dx */
            ii(0x1a_1a93, 3);  jmp(0x1a_1aec, 0x56); goto l_0x1a_1aec; /* jmp 0x1aec */
        l_0x1a_1a96:
            ii(0x1a_1a96, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x1a_1a99, 3);  sub(ax, memw[ss, bp - 32]);             /* sub ax, [bp-0x20] */
            ii(0x1a_1a9c, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_1a9e, 3);  add(ax, memw[ss, bp - 30]);             /* add ax, [bp-0x1e] */
            ii(0x1a_1aa1, 3);  adc(dx, memw[ss, bp - 28]);             /* adc dx, [bp-0x1c] */
            ii(0x1a_1aa4, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1aa7, 4);  mov(memw[es, bx + 28], ax);             /* mov [es:bx+0x1c], ax */
            ii(0x1a_1aab, 4);  mov(memw[es, bx + 30], dx);             /* mov [es:bx+0x1e], dx */
            ii(0x1a_1aaf, 3);  jmp(0x1a_1aec, 0x3a); goto l_0x1a_1aec; /* jmp 0x1aec */
        l_0x1a_1ab2:
            ii(0x1a_1ab2, 3);  mov(ax, memw[ss, bp - 14]);             /* mov ax, [bp-0xe] */
            ii(0x1a_1ab5, 3);  sub(ax, memw[ss, bp - 32]);             /* sub ax, [bp-0x20] */
            ii(0x1a_1ab8, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x1a_1aba, 3);  add(ax, memw[ss, bp - 30]);             /* add ax, [bp-0x1e] */
            ii(0x1a_1abd, 3);  adc(dx, memw[ss, bp - 28]);             /* adc dx, [bp-0x1c] */
            ii(0x1a_1ac0, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x1a_1ac3, 4);  mov(memw[es, bx + 20], ax);             /* mov [es:bx+0x14], ax */
            ii(0x1a_1ac7, 4);  mov(memw[es, bx + 22], dx);             /* mov [es:bx+0x16], dx */
            ii(0x1a_1acb, 3);  jmp(0x1a_1aec, 0x1e); goto l_0x1a_1aec; /* jmp 0x1aec */
        //  ii(0x1a_1ace, 3);  jmp(0x1a_1aec, 0x1b); goto l_0x1a_1aec; /* jmp 0x1aec */
        l_0x1a_1ad1:
            ii(0x1a_1ad1, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1ad2, 2);  if(jnz(0x1a_1ad7, 3)) goto l_0x1a_1ad7; /* jnz 0x1ad7 */
            ii(0x1a_1ad4, 3);  jmp(0x1a_1a5e, -0x79); goto l_0x1a_1a5e;/* jmp 0x1a5e */
        l_0x1a_1ad7:
            ii(0x1a_1ad7, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1ad8, 2);  if(jnz(0x1a_1add, 3)) goto l_0x1a_1add; /* jnz 0x1add */
            ii(0x1a_1ada, 3);  jmp(0x1a_1ab2, -0x2b); goto l_0x1a_1ab2;/* jmp 0x1ab2 */
        l_0x1a_1add:
            ii(0x1a_1add, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1ade, 2);  if(jnz(0x1a_1ae3, 3)) goto l_0x1a_1ae3; /* jnz 0x1ae3 */
            ii(0x1a_1ae0, 3);  jmp(0x1a_1a7a, -0x69); goto l_0x1a_1a7a;/* jmp 0x1a7a */
        l_0x1a_1ae3:
            ii(0x1a_1ae3, 1);  dec(ax);                                /* dec ax */
            ii(0x1a_1ae4, 2);  if(jnz(0x1a_1ae9, 3)) goto l_0x1a_1ae9; /* jnz 0x1ae9 */
            ii(0x1a_1ae6, 3);  jmp(0x1a_1a96, -0x53); goto l_0x1a_1a96;/* jmp 0x1a96 */
        l_0x1a_1ae9:
            ii(0x1a_1ae9, 3);  jmp(0x1a_1aec, 0); goto l_0x1a_1aec;    /* jmp 0x1aec */
        l_0x1a_1aec:
            ii(0x1a_1aec, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x1a_1aef, 3);  jmp(0x1a_1af2, 0); goto l_0x1a_1af2;    /* jmp 0x1af2 */
        l_0x1a_1af2:
            ii(0x1a_1af2, 1);  pop(si);                                /* pop si */
            ii(0x1a_1af3, 1);  pop(di);                                /* pop di */
            ii(0x1a_1af4, 1);  leave();                                /* leave */
            ii(0x1a_1af5, 1);  retf();                                 /* retf */
        }
    }
}
