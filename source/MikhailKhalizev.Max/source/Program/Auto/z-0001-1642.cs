using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1642-2f65ab06")]
        public void Method_0001_1642()
        {
            ii(0x1_1642, 4);  enter(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x1_1646, 5);  cmp(memb[ds, 0x2e], 0);                  /* cmp byte [0x2e], 0x0 */
            ii(0x1_164b, 2);  if(jz(0x1_1688, 0x3b)) goto l_0x1_1688;  /* jz 0x1688 */
            ii(0x1_164d, 5);  cmp(memb[ds, 0xa16], 0);                 /* cmp byte [0xa16], 0x0 */
            ii(0x1_1652, 2);  if(jnz(0x1_1688, 0x34)) goto l_0x1_1688; /* jnz 0x1688 */
            ii(0x1_1654, 3);  mov(ax, memw[ds, 0x9c]);                 /* mov ax, [0x9c] */
            ii(0x1_1657, 4);  mov(dx, memw[ds, 0x9e]);                 /* mov dx, [0x9e] */
            ii(0x1_165b, 3);  mov(memw[ss, bp - 4], ax);               /* mov [bp-0x4], ax */
            ii(0x1_165e, 3);  mov(memw[ss, bp - 2], dx);               /* mov [bp-0x2], dx */
            ii(0x1_1661, 5);  cmp(memb[ds, 0x2e], 0xb);                /* cmp byte [0x2e], 0xb */
            ii(0x1_1666, 2);  if(jnz(0x1_1671, 9)) goto l_0x1_1671;    /* jnz 0x1671 */
        l_0x1_1668:
            ii(0x1_1668, 3);  mov(ax, memw[ds, 0xaa8]);                /* mov ax, [0xaa8] */
            ii(0x1_166b, 4);  mov(dx, memw[ds, 0xaaa]);                /* mov dx, [0xaaa] */
            ii(0x1_166f, 1);  leave();                                 /* leave */
            ii(0x1_1670, 1);  ret(); return;                           /* ret */
        l_0x1_1671:
            ii(0x1_1671, 3);  mov(ax, memw[ss, bp - 4]);               /* mov ax, [bp-0x4] */
            ii(0x1_1674, 3);  mov(dx, memw[ss, bp - 2]);               /* mov dx, [bp-0x2] */
            ii(0x1_1677, 4);  sub(ax, memw[ds, 0x98]);                 /* sub ax, [0x98] */
            ii(0x1_167b, 4);  sbb(dx, memw[ds, 0x9a]);                 /* sbb dx, [0x9a] */
            ii(0x1_167f, 1);  push(dx);                                /* push dx */
            ii(0x1_1680, 1);  push(ax);                                /* push ax */
            ii(0x1_1681, 3);  call(0x1_1ba7, 0x523);                   /* call 0x1ba7 */
            ii(0x1_1684, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_1685, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_1686, 1);  leave();                                 /* leave */
            ii(0x1_1687, 1);  ret(); return;                           /* ret */
        l_0x1_1688:
            ii(0x1_1688, 5);  mov(memw[ss, bp - 20], 3);               /* mov word [bp-0x14], 0x3 */
        l_0x1_168d:
            ii(0x1_168d, 3);  mov(ax, memw[ss, bp + 4]);               /* mov ax, [bp+0x4] */
            ii(0x1_1690, 3);  mov(dx, memw[ss, bp + 6]);               /* mov dx, [bp+0x6] */
            ii(0x1_1693, 4);  sub(ax, memw[ds, 0xaa8]);                /* sub ax, [0xaa8] */
            ii(0x1_1697, 4);  sbb(dx, memw[ds, 0xaaa]);                /* sbb dx, [0xaaa] */
            ii(0x1_169b, 3);  add(ax, 0xfff);                          /* add ax, 0xfff */
            ii(0x1_169e, 3);  adc(dx, 0);                              /* adc dx, 0x0 */
            ii(0x1_16a1, 3);  and(ax, 0xf000);                         /* and ax, 0xf000 */
            ii(0x1_16a4, 3);  mov(memw[ss, bp - 12], ax);              /* mov [bp-0xc], ax */
            ii(0x1_16a7, 3);  mov(memw[ss, bp - 10], dx);              /* mov [bp-0xa], dx */
            ii(0x1_16aa, 5);  mov(memw[ss, bp - 14], 3);               /* mov word [bp-0xe], 0x3 */
        l_0x1_16af:
            ii(0x1_16af, 4);  call_abs(memw[ds, 0xaa4]);               /* call word [0xaa4] */
            ii(0x1_16b3, 3);  mov(memw[ss, bp - 8], ax);               /* mov [bp-0x8], ax */
            ii(0x1_16b6, 3);  mov(memw[ss, bp - 6], dx);               /* mov [bp-0x6], dx */
            ii(0x1_16b9, 3);  cmp(dx, memw[ss, bp - 10]);              /* cmp dx, [bp-0xa] */
            ii(0x1_16bc, 2);  if(jg(0x1_16d1, 0x13)) goto l_0x1_16d1;  /* jg 0x16d1 */
            ii(0x1_16be, 2);  if(jl(0x1_16c5, 5)) goto l_0x1_16c5;     /* jl 0x16c5 */
            ii(0x1_16c0, 3);  cmp(ax, memw[ss, bp - 12]);              /* cmp ax, [bp-0xc] */
            ii(0x1_16c3, 2);  if(jae(0x1_16d1, 0xc)) goto l_0x1_16d1;  /* jae 0x16d1 */
        l_0x1_16c5:
            ii(0x1_16c5, 4);  cmp(memw[ss, bp + 8], 0);                /* cmp word [bp+0x8], 0x0 */
            ii(0x1_16c9, 2);  if(jnz(0x1_1668, -0x63)) goto l_0x1_1668;/* jnz 0x1668 */
            ii(0x1_16cb, 3);  mov(memw[ss, bp - 12], ax);              /* mov [bp-0xc], ax */
            ii(0x1_16ce, 3);  mov(memw[ss, bp - 10], dx);              /* mov [bp-0xa], dx */
        l_0x1_16d1:
            ii(0x1_16d1, 4);  cmp(memw[ss, bp - 10], 0);               /* cmp word [bp-0xa], 0x0 */
            ii(0x1_16d5, 2);  if(jg(0x1_16df, 8)) goto l_0x1_16df;     /* jg 0x16df */
            ii(0x1_16d7, 2);  if(jl(0x1_1668, -0x71)) goto l_0x1_1668; /* jl 0x1668 */
            ii(0x1_16d9, 4);  cmp(memw[ss, bp - 12], 0);               /* cmp word [bp-0xc], 0x0 */
            ii(0x1_16dd, 2);  if(jz(0x1_1668, -0x77)) goto l_0x1_1668; /* jz 0x1668 */
        l_0x1_16df:
            ii(0x1_16df, 3);  push(memw[ss, bp - 10]);                 /* push word [bp-0xa] */
            ii(0x1_16e2, 3);  push(memw[ss, bp - 12]);                 /* push word [bp-0xc] */
            ii(0x1_16e5, 4);  call_abs(memw[ds, 0xaa6]);               /* call word [0xaa6] */
            ii(0x1_16e9, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_16ea, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_16eb, 3);  mov(memw[ss, bp - 4], ax);               /* mov [bp-0x4], ax */
            ii(0x1_16ee, 3);  mov(memw[ss, bp - 2], dx);               /* mov [bp-0x2], dx */
            ii(0x1_16f1, 2);  or(dx, ax);                              /* or dx, ax */
            ii(0x1_16f3, 2);  if(jnz(0x1_170b, 0x16)) goto l_0x1_170b; /* jnz 0x170b */
            ii(0x1_16f5, 4);  cmp(memw[ss, bp + 8], 0);                /* cmp word [bp+0x8], 0x0 */
            ii(0x1_16f9, 2);  if(jz(0x1_1703, 8)) goto l_0x1_1703;     /* jz 0x1703 */
            ii(0x1_16fb, 3);  dec(memw[ss, bp - 14]);                  /* dec word [bp-0xe] */
            ii(0x1_16fe, 2);  if(jns(0x1_1703, 3)) goto l_0x1_1703;    /* jns 0x1703 */
            ii(0x1_1700, 3);  jmp(0x1_1668, -0x9b); goto l_0x1_1668;   /* jmp 0x1668 */
        l_0x1_1703:
            ii(0x1_1703, 3);  sar(memw[ss, bp - 10], 1);               /* sar word [bp-0xa], 1 */
            ii(0x1_1706, 3);  rcr(memw[ss, bp - 12], 1);               /* rcr word [bp-0xc], 1 */
            ii(0x1_1709, 2);  jmp(0x1_16af, -0x5c); goto l_0x1_16af;   /* jmp 0x16af */
        l_0x1_170b:
            ii(0x1_170b, 3);  push(memw[ss, bp - 2]);                  /* push word [bp-0x2] */
            ii(0x1_170e, 1);  push(ax);                                /* push ax */
            ii(0x1_170f, 3);  call(0x1_1b8c, 0x47a);                   /* call 0x1b8c */
            ii(0x1_1712, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_1713, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_1714, 3);  mov(memw[ss, bp - 18], ax);              /* mov [bp-0x12], ax */
            ii(0x1_1717, 3);  mov(memw[ss, bp - 16], dx);              /* mov [bp-0x10], dx */
            ii(0x1_171a, 1);  cli();                                   /* cli */
            ii(0x1_171b, 3);  mov(ax, memw[ss, bp - 18]);              /* mov ax, [bp-0x12] */
            ii(0x1_171e, 3);  mov(dx, memw[ss, bp - 16]);              /* mov dx, [bp-0x10] */
            ii(0x1_1721, 4);  cmp(memw[ds, 0x9a], dx);                 /* cmp [0x9a], dx */
            ii(0x1_1725, 2);  if(ja(0x1_1738, 0x11)) goto l_0x1_1738;  /* ja 0x1738 */
            ii(0x1_1727, 2);  if(jb(0x1_172f, 6)) goto l_0x1_172f;     /* jb 0x172f */
            ii(0x1_1729, 4);  cmp(memw[ds, 0x98], ax);                 /* cmp [0x98], ax */
            ii(0x1_172d, 2);  if(ja(0x1_1738, 9)) goto l_0x1_1738;     /* ja 0x1738 */
        l_0x1_172f:
            ii(0x1_172f, 3);  mov(ax, memw[ds, 0x9a]);                 /* mov ax, [0x9a] */
            ii(0x1_1732, 4);  or(ax, memw[ds, 0x98]);                  /* or ax, [0x98] */
            ii(0x1_1736, 2);  if(jnz(0x1_1784, 0x4c)) goto l_0x1_1784; /* jnz 0x1784 */
        l_0x1_1738:
            ii(0x1_1738, 3);  mov(ax, memw[ds, 0x98]);                 /* mov ax, [0x98] */
            ii(0x1_173b, 4);  mov(dx, memw[ds, 0x9a]);                 /* mov dx, [0x9a] */
            ii(0x1_173f, 3);  mov(memw[ss, bp - 8], ax);               /* mov [bp-0x8], ax */
            ii(0x1_1742, 3);  mov(memw[ss, bp - 6], dx);               /* mov [bp-0x6], dx */
            ii(0x1_1745, 3);  mov(ax, memw[ss, bp - 18]);              /* mov ax, [bp-0x12] */
            ii(0x1_1748, 3);  mov(dx, memw[ss, bp - 16]);              /* mov dx, [bp-0x10] */
            ii(0x1_174b, 3);  mov(memw[ds, 0x98], ax);                 /* mov [0x98], ax */
            ii(0x1_174e, 4);  mov(memw[ds, 0x9a], dx);                 /* mov [0x9a], dx */
            ii(0x1_1752, 3);  push(memw[ss, bp - 6]);                  /* push word [bp-0x6] */
            ii(0x1_1755, 3);  push(memw[ss, bp - 8]);                  /* push word [bp-0x8] */
            ii(0x1_1758, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_175a, 1);  push(dx);                                /* push dx */
            ii(0x1_175b, 1);  push(ax);                                /* push ax */
            ii(0x1_175c, 3);  call(0x1_1b37, 0x3d8);                   /* call 0x1b37 */
            ii(0x1_175f, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_1762, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_1764, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_1766, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_1768, 3);  push(memw[ss, bp - 16]);                 /* push word [bp-0x10] */
            ii(0x1_176b, 3);  push(memw[ss, bp - 18]);                 /* push word [bp-0x12] */
            ii(0x1_176e, 3);  call(0x1_1b37, 0x3c6);                   /* call 0x1b37 */
            ii(0x1_1771, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_1774, 4);  add(memw[ss, bp - 18], 1);               /* add word [bp-0x12], 0x1 */
            ii(0x1_1778, 4);  adc(memw[ss, bp - 16], 0);               /* adc word [bp-0x10], 0x0 */
            ii(0x1_177c, 4);  sub(memw[ss, bp - 12], 0x10);            /* sub word [bp-0xc], 0x10 */
            ii(0x1_1780, 4);  sbb(memw[ss, bp - 10], 0);               /* sbb word [bp-0xa], 0x0 */
        l_0x1_1784:
            ii(0x1_1784, 3);  push(memw[ss, bp - 10]);                 /* push word [bp-0xa] */
            ii(0x1_1787, 3);  push(memw[ss, bp - 12]);                 /* push word [bp-0xc] */
            ii(0x1_178a, 3);  call(0x1_1b8c, 0x3ff);                   /* call 0x1b8c */
            ii(0x1_178d, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_178e, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_178f, 3);  add(ax, memw[ss, bp - 18]);              /* add ax, [bp-0x12] */
            ii(0x1_1792, 3);  adc(dx, memw[ss, bp - 16]);              /* adc dx, [bp-0x10] */
            ii(0x1_1795, 3);  mov(memw[ss, bp - 4], ax);               /* mov [bp-0x4], ax */
            ii(0x1_1798, 3);  mov(memw[ss, bp - 2], dx);               /* mov [bp-0x2], dx */
            ii(0x1_179b, 4);  cmp(memw[ds, 0x9e], dx);                 /* cmp [0x9e], dx */
            ii(0x1_179f, 2);  if(ja(0x1_17b0, 0xf)) goto l_0x1_17b0;   /* ja 0x17b0 */
            ii(0x1_17a1, 2);  if(jb(0x1_17a9, 6)) goto l_0x1_17a9;     /* jb 0x17a9 */
            ii(0x1_17a3, 4);  cmp(memw[ds, 0x9c], ax);                 /* cmp [0x9c], ax */
            ii(0x1_17a7, 2);  if(jae(0x1_17b0, 7)) goto l_0x1_17b0;    /* jae 0x17b0 */
        l_0x1_17a9:
            ii(0x1_17a9, 3);  mov(memw[ds, 0x9c], ax);                 /* mov [0x9c], ax */
            ii(0x1_17ac, 4);  mov(memw[ds, 0x9e], dx);                 /* mov [0x9e], dx */
        l_0x1_17b0:
            ii(0x1_17b0, 3);  push(memw[ss, bp - 10]);                 /* push word [bp-0xa] */
            ii(0x1_17b3, 3);  push(memw[ss, bp - 12]);                 /* push word [bp-0xc] */
            ii(0x1_17b6, 3);  call(0x1_1b8c, 0x3d3);                   /* call 0x1b8c */
            ii(0x1_17b9, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_17ba, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_17bb, 1);  push(dx);                                /* push dx */
            ii(0x1_17bc, 1);  push(ax);                                /* push ax */
            ii(0x1_17bd, 3);  push(memw[ss, bp - 16]);                 /* push word [bp-0x10] */
            ii(0x1_17c0, 3);  push(memw[ss, bp - 18]);                 /* push word [bp-0x12] */
            ii(0x1_17c3, 3);  call(0xffe0, -0x17e6);                   /* call 0xffe0 */
            ii(0x1_17c6, 3);  add(sp, 8);                              /* add sp, 0x8 */
            ii(0x1_17c9, 5);  cmp(memb[ds, 0x2e], 0);                  /* cmp byte [0x2e], 0x0 */
            ii(0x1_17ce, 2);  if(jnz(0x1_17e1, 0x11)) goto l_0x1_17e1; /* jnz 0x17e1 */
            ii(0x1_17d0, 4);  push(memw[ds, 0x1204]);                  /* push word [0x1204] */
            ii(0x1_17d4, 4);  push(memw[ds, 0x1202]);                  /* push word [0x1202] */
            ii(0x1_17d8, 3);  push(memw[ss, bp - 16]);                 /* push word [bp-0x10] */
            ii(0x1_17db, 3);  push(memw[ss, bp - 18]);                 /* push word [bp-0x12] */
            ii(0x1_17de, 3);  call(0x1_0406, -0x13db);                 /* call 0x406 */
        l_0x1_17e1:
            ii(0x1_17e1, 5);  cmp(memb[ds, 0x2e], 0xb);                /* cmp byte [0x2e], 0xb */
            ii(0x1_17e6, 2);  if(jz(0x1_17f6, 0xe)) goto l_0x1_17f6;   /* jz 0x17f6 */
            ii(0x1_17e8, 3);  mov(ax, memw[ss, bp - 12]);              /* mov ax, [bp-0xc] */
            ii(0x1_17eb, 3);  mov(dx, memw[ss, bp - 10]);              /* mov dx, [bp-0xa] */
            ii(0x1_17ee, 4);  add(memw[ds, 0xaa8], ax);                /* add [0xaa8], ax */
            ii(0x1_17f2, 4);  adc(memw[ds, 0xaaa], dx);                /* adc [0xaaa], dx */
        l_0x1_17f6:
            ii(0x1_17f6, 3);  dec(memw[ss, bp - 20]);                  /* dec word [bp-0x14] */
            ii(0x1_17f9, 4);  cmp(memw[ss, bp - 20], 0);               /* cmp word [bp-0x14], 0x0 */
            ii(0x1_17fd, 2);  if(jg(0x1_1802, 3)) goto l_0x1_1802;     /* jg 0x1802 */
            ii(0x1_17ff, 3);  jmp(0x1_1668, -0x19a); goto l_0x1_1668;  /* jmp 0x1668 */
        l_0x1_1802:
            ii(0x1_1802, 3);  jmp(0x1_168d, -0x178); goto l_0x1_168d;  /* jmp 0x168d */
        }
    }
}
