using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_15e9-b8086f4c")]
        public void Method_0001_15e9()
        {
            ii(0x1_15e9, 4);  enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x1_15ed, 1);  pushw(si);                                /* push si */
            ii(0x1_15ee, 3);  mov(si, memw_a16[ss, bp + 0x4]);          /* mov si, [bp+0x4] */
            ii(0x1_15f1, 4);  xor(si, memw_a16[ds, 0x97c]);             /* xor si, [0x97c] */
            ii(0x1_15f5, 3);  and(si, 0x7);                             /* and si, 0x7 */
            ii(0x1_15f8, 4);  xor(si, memw_a16[ds, 0x97c]);             /* xor si, [0x97c] */
            ii(0x1_15fc, 2);  jmpw(0x1_1632, 0x34); goto l_0x1_1632;    /* jmp 0x1632 */
        l_0x1_15fe:
            ii(0x1_15fe, 3);  lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x1_1601, 1);  pushw(ax);                                /* push ax */
            ii(0x1_1602, 1);  pushw(si);                                /* push si */
            ii(0x1_1603, 3);  callw(0x1_1c5e, 0x658);                   /* call 0x1c5e */
            ii(0x1_1606, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_1607, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_1608, 2);  or(ax, ax);                               /* or ax, ax */
            ii(0x1_160a, 2);  if(jzw(0x1_1632, 0x26)) goto l_0x1_1632;  /* jz 0x1632 */
            ii(0x1_160c, 4);  test(memb_a16[ss, bp - 0x2], 0x10);       /* test byte [bp-0x2], 0x10 */
            ii(0x1_1610, 2);  if(jzw(0x1_1632, 0x20)) goto l_0x1_1632;  /* jz 0x1632 */
            ii(0x1_1612, 3);  mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x1_1615, 3);  mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x1_1618, 3);  sub(ax, memw_a16[ss, bp + 0x6]);          /* sub ax, [bp+0x6] */
            ii(0x1_161b, 3);  sbb(dx, memw_a16[ss, bp + 0x8]);          /* sbb dx, [bp+0x8] */
            ii(0x1_161e, 3);  mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x1_1621, 2);  sub(bx, bx);                              /* sub bx, bx */
            ii(0x1_1623, 2);  cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x1_1625, 2);  if(jaw(0x1_1632, 0xb)) goto l_0x1_1632;   /* ja 0x1632 */
            ii(0x1_1627, 2);  if(jbw(0x1_162d, 0x4)) goto l_0x1_162d;   /* jb 0x162d */
            ii(0x1_1629, 2);  cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x1_162b, 2);  if(jaw(0x1_1632, 0x5)) goto l_0x1_1632;   /* ja 0x1632 */
        l_0x1_162d:
            ii(0x1_162d, 1);  pushw(si);                                /* push si */
            ii(0x1_162e, 3);  callw(0x1_1cd1, 0x6a0);                   /* call 0x1cd1 */
            ii(0x1_1631, 1);  popw(bx);                                 /* pop bx */
        l_0x1_1632:
            ii(0x1_1632, 3);  sub(si, 0x8);                             /* sub si, 0x8 */
            ii(0x1_1635, 4);  cmp(si, memw_a16[ds, 0xc34]);             /* cmp si, [0xc34] */
            ii(0x1_1639, 2);  if(jaew(0x1_15fe, -0x3d)) goto l_0x1_15fe; /* jae 0x15fe */
            ii(0x1_163b, 1);  popw(si);                                 /* pop si */
            ii(0x1_163c, 1);  leavew();                                 /* leave */
            ii(0x1_163d, 1);  retw(); return;                           /* ret */
        }
    }
}
