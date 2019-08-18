using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_143c-c1ac4b7c")]
        public void Method_001a_143c()
        {
            ii(0x1a_143c, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x1a_1440, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x1a_1443, 3); mov(memw_a16[ss, bp - 0x4], bx);          /* mov [bp-0x4], bx */
            ii(0x1a_1446, 3); mov(memw_a16[ss, bp - 0x2], es);          /* mov [bp-0x2], es */
            ii(0x1a_1449, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x1a_144d, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x1a_144f, 2); mov(cl, 0x9);                             /* mov cl, 0x9 */
            ii(0x1a_1451, 5); callw_far_abs(0x80, 0x4324);              /* call word 0x80:0x4324 */
            ii(0x1a_1456, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x1a_1459, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x1a_145c, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x1a_1461, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x1a_1464, 5); cmp(memw_a16[es, bx + 0x2], 0);           /* cmp word [es:bx+0x2], 0x0 */
            ii(0x1a_1469, 2); if(jzw(0x1a_1484, 0x19)) goto l_0x1a_1484; /* jz 0x1484 */
            ii(0x1a_146b, 4); cmp(memb_a16[es, bx], 0x4d);              /* cmp byte [es:bx], 0x4d */
            ii(0x1a_146f, 2); if(jnzw(0x1a_1476, 0x5)) goto l_0x1a_1476; /* jnz 0x1476 */
            ii(0x1a_1471, 5); mov(memw_a16[ss, bp - 0xa], 0x200);       /* mov word [bp-0xa], 0x200 */
        l_0x1a_1476:
            ii(0x1a_1476, 4); mov(ax, memw_a16[es, bx + 0x2]);          /* mov ax, [es:bx+0x2] */
            ii(0x1a_147a, 3); sub(ax, memw_a16[ss, bp - 0xa]);          /* sub ax, [bp-0xa] */
            ii(0x1a_147d, 1); cwd();                                    /* cwd */
            ii(0x1a_147e, 3); add(memw_a16[ss, bp - 0x8], ax);          /* add [bp-0x8], ax */
            ii(0x1a_1481, 3); adc(memw_a16[ss, bp - 0x6], dx);          /* adc [bp-0x6], dx */
        l_0x1a_1484:
            ii(0x1a_1484, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x1a_1487, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x1a_148a, 1); leavew();                                 /* leave */
            ii(0x1a_148b, 1); retfw(); return;                          /* retf */
        }
    }
}
