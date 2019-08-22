using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_148c-c974ecc3")]
        public void Method_001a_148c()
        {
            ii(0x1a_148c, 4); enterw(0x50, 0);                          /* enter 0x50, 0x0 */
            ii(0x1a_1490, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_1493, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_1496, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x1a_1499, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x1a_149b, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x1a_149e, 1); pushw(ax);                                /* push ax */
            ii(0x1a_149f, 3); callw(0x19_fed2, -0x15d0);                /* call 0xfed2 */
            ii(0x1a_14a2, 3); mov(memw_a16[ss, bp + 0x8], ax);          /* mov [bp+0x8], ax */
            ii(0x1a_14a5, 3); mov(memw_a16[ss, bp + 0xa], dx);          /* mov [bp+0xa], dx */
            ii(0x1a_14a8, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x1a_14aa, 2); if(jlw(0x1a_14be, 0x12)) goto l_0x1a_14be; /* jl 0x14be */
            ii(0x1a_14ac, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_14af, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x1a_14b2, 1); pushw(ss);                                /* push ss */
            ii(0x1a_14b3, 1); pushw(ax);                                /* push ax */
            ii(0x1a_14b4, 2); pushw(0x40);                              /* push 0x40 */
            ii(0x1a_14b6, 3); callw(0x19_fef1, -0x15c8);                /* call 0xfef1 */
            ii(0x1a_14b9, 3); cmp(ax, 0x40);                            /* cmp ax, 0x40 */
            ii(0x1a_14bc, 2); if(jzw(0x1a_14c1, 0x3)) goto l_0x1a_14c1; /* jz 0x14c1 */
        l_0x1a_14be:
            ii(0x1a_14be, 3); jmpw(0x1a_1563, 0xa2); goto l_0x1a_1563;  /* jmp 0x1563 */
        l_0x1a_14c1:
            ii(0x1a_14c1, 5); cmp(memw_a16[ss, bp - 0x40], 0x5a4d);     /* cmp word [bp-0x40], 0x5a4d */
            ii(0x1a_14c6, 2); if(jnzw(0x1a_1517, 0x4f)) goto l_0x1a_1517; /* jnz 0x1517 */
            ii(0x1a_14c8, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x1a_14cb, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x1a_14ce, 3); mov(memw_a16[ss, bp - 0x44], ax);         /* mov [bp-0x44], ax */
            ii(0x1a_14d1, 3); mov(memw_a16[ss, bp - 0x42], dx);         /* mov [bp-0x42], dx */
            ii(0x1a_14d4, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x1a_14d7, 1); pushw(ss);                                /* push ss */
            ii(0x1a_14d8, 1); pushw(ax);                                /* push ax */
            ii(0x1a_14d9, 1); pushw(cs);                                /* push cs */
            ii(0x1a_14da, 3); callw(0x1a_143c, -0xa1);                  /* call 0x143c */
            ii(0x1a_14dd, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_14de, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_14df, 3); mov(memw_a16[ss, bp - 0x4a], ax);         /* mov [bp-0x4a], ax */
            ii(0x1a_14e2, 3); mov(memw_a16[ss, bp - 0x48], dx);         /* mov [bp-0x48], dx */
        l_0x1a_14e5:
            ii(0x1a_14e5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_14e8, 3); mov(ax, memw_a16[ss, bp - 0x44]);         /* mov ax, [bp-0x44] */
            ii(0x1a_14eb, 3); mov(dx, memw_a16[ss, bp - 0x42]);         /* mov dx, [bp-0x42] */
            ii(0x1a_14ee, 3); add(ax, memw_a16[ss, bp + 0x8]);          /* add ax, [bp+0x8] */
            ii(0x1a_14f1, 3); adc(dx, memw_a16[ss, bp + 0xa]);          /* adc dx, [bp+0xa] */
            ii(0x1a_14f4, 1); pushw(dx);                                /* push dx */
            ii(0x1a_14f5, 1); pushw(ax);                                /* push ax */
            ii(0x1a_14f6, 2); pushw(0);                                 /* push 0x0 */
            ii(0x1a_14f8, 3); callw(0x19_fed2, -0x1629);                /* call 0xfed2 */
            ii(0x1a_14fb, 3); mov(memw_a16[ss, bp - 0x4e], ax);         /* mov [bp-0x4e], ax */
            ii(0x1a_14fe, 3); mov(memw_a16[ss, bp - 0x4c], dx);         /* mov [bp-0x4c], dx */
            ii(0x1a_1501, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x1a_1503, 2); if(jlw(0x1a_1563, 0x5e)) goto l_0x1a_1563; /* jl 0x1563 */
            ii(0x1a_1505, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_1508, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x1a_150b, 1); pushw(ss);                                /* push ss */
            ii(0x1a_150c, 1); pushw(ax);                                /* push ax */
            ii(0x1a_150d, 2); pushw(0x40);                              /* push 0x40 */
            ii(0x1a_150f, 3); callw(0x19_fef1, -0x1621);                /* call 0xfef1 */
            ii(0x1a_1512, 3); cmp(ax, 0x40);                            /* cmp ax, 0x40 */
            ii(0x1a_1515, 2); if(jnzw(0x1a_1563, 0x4c)) goto l_0x1a_1563; /* jnz 0x1563 */
        l_0x1a_1517:
            ii(0x1a_1517, 5); cmp(memw_a16[ss, bp - 0x40], 0x454c);     /* cmp word [bp-0x40], 0x454c */
            ii(0x1a_151c, 2); if(jnzw(0x1a_1525, 0x7)) goto l_0x1a_1525; /* jnz 0x1525 */
            ii(0x1a_151e, 5); mov(memw_a16[ss, bp - 0x50], 0x3);        /* mov word [bp-0x50], 0x3 */
            ii(0x1a_1523, 2); jmpw(0x1a_153f, 0x1a); goto l_0x1a_153f;  /* jmp 0x153f */
        l_0x1a_1525:
            ii(0x1a_1525, 5); cmp(memw_a16[ss, bp - 0x40], 0x584c);     /* cmp word [bp-0x40], 0x584c */
            ii(0x1a_152a, 2); if(jnzw(0x1a_1533, 0x7)) goto l_0x1a_1533; /* jnz 0x1533 */
            ii(0x1a_152c, 5); mov(memw_a16[ss, bp - 0x50], 0x4);        /* mov word [bp-0x50], 0x4 */
            ii(0x1a_1531, 2); jmpw(0x1a_153f, 0xc); goto l_0x1a_153f;   /* jmp 0x153f */
        l_0x1a_1533:
            ii(0x1a_1533, 5); cmp(memw_a16[ss, bp - 0x40], 0x454e);     /* cmp word [bp-0x40], 0x454e */
            ii(0x1a_1538, 2); if(jnzw(0x1a_153f, 0x5)) goto l_0x1a_153f; /* jnz 0x153f */
            ii(0x1a_153a, 5); mov(memw_a16[ss, bp - 0x50], 0x2);        /* mov word [bp-0x50], 0x2 */
        l_0x1a_153f:
            ii(0x1a_153f, 4); cmp(memw_a16[ss, bp - 0x50], 0);          /* cmp word [bp-0x50], 0x0 */
            ii(0x1a_1543, 2); if(jnzw(0x1a_1563, 0x1e)) goto l_0x1a_1563; /* jnz 0x1563 */
            ii(0x1a_1545, 3); mov(ax, memw_a16[ss, bp - 0x48]);         /* mov ax, [bp-0x48] */
            ii(0x1a_1548, 3); or(ax, memw_a16[ss, bp - 0x4a]);          /* or ax, [bp-0x4a] */
            ii(0x1a_154b, 2); if(jzw(0x1a_1563, 0x16)) goto l_0x1a_1563; /* jz 0x1563 */
            ii(0x1a_154d, 3); mov(ax, memw_a16[ss, bp - 0x4a]);         /* mov ax, [bp-0x4a] */
            ii(0x1a_1550, 3); mov(dx, memw_a16[ss, bp - 0x48]);         /* mov dx, [bp-0x48] */
            ii(0x1a_1553, 3); mov(memw_a16[ss, bp - 0x44], ax);         /* mov [bp-0x44], ax */
            ii(0x1a_1556, 3); mov(memw_a16[ss, bp - 0x42], dx);         /* mov [bp-0x42], dx */
            ii(0x1a_1559, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x1a_155b, 3); mov(memw_a16[ss, bp - 0x48], ax);         /* mov [bp-0x48], ax */
            ii(0x1a_155e, 3); mov(memw_a16[ss, bp - 0x4a], ax);         /* mov [bp-0x4a], ax */
            ii(0x1a_1561, 2); jmpw(0x1a_14e5, -0x7e); goto l_0x1a_14e5; /* jmp 0x14e5 */
        l_0x1a_1563:
            ii(0x1a_1563, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_1566, 3); pushw(memw_a16[ss, bp - 0x4c]);           /* push word [bp-0x4c] */
            ii(0x1a_1569, 3); pushw(memw_a16[ss, bp - 0x4e]);           /* push word [bp-0x4e] */
            ii(0x1a_156c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x1a_156e, 3); callw(0x19_fed2, -0x169f);                /* call 0xfed2 */
            ii(0x1a_1571, 3); mov(ax, memw_a16[ss, bp - 0x4e]);         /* mov ax, [bp-0x4e] */
            ii(0x1a_1574, 3); mov(dx, memw_a16[ss, bp - 0x4c]);         /* mov dx, [bp-0x4c] */
            ii(0x1a_1577, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x1a_157a, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x1a_157d, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x1a_1581, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x1a_1584, 1); leavew();                                 /* leave */
            ii(0x1a_1585, 1); retfw(); return;                          /* retf */
        }
    }
}