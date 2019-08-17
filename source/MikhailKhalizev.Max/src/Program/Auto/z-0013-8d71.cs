using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("00107064-4985-46d8-ad2e-5ead1ad5bb3f")]
        public void Method_0013_8d71()
        {
            ii(0x13_8d71, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x13_8d73, 1); pushw(ax);                                /* push ax */
            ii(0x13_8d74, 1); pushw(cx);                                /* push cx */
            ii(0x13_8d75, 1); nop();                                    /* nop */
            ii(0x13_8d76, 1); pushw(cs);                                /* push cs */
            ii(0x13_8d77, 3); callw(0x13_ea1e, 0x5ca4);                 /* call 0xea1e */
            ii(0x13_8d7a, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_8d7d, 3); mov(memw_a16[ds, 0xa2c], ax);             /* mov [0xa2c], ax */
            ii(0x13_8d80, 4); mov(memw_a16[ds, 0xa2e], dx);             /* mov [0xa2e], dx */
            ii(0x13_8d84, 4); les(bx, ds, 0xa2c);                       /* les bx, [0xa2c] */
            ii(0x13_8d88, 4); mov(ax, memw_a16[es, bx + 0x36]);         /* mov ax, [es:bx+0x36] */
            ii(0x13_8d8c, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_8d8e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_8d90, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_8d92, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_8d94, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_8d96, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_8d98, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_8d9a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_8d9c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_8d9e, 4); add(ax, memw_a16[es, bx + 0x34]);         /* add ax, [es:bx+0x34] */
            ii(0x13_8da2, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_8da5, 1); pushw(dx);                                /* push dx */
            ii(0x13_8da6, 1); pushw(ax);                                /* push ax */
            ii(0x13_8da7, 4); pushw(memw_a16[ds, 0xa32]);               /* push word [0xa32] */
            ii(0x13_8dab, 1); pushw(cs);                                /* push cs */
            ii(0x13_8dac, 3); callw(0x13_89bc, -0x3f3);                 /* call 0x89bc */
            ii(0x13_8daf, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_8db2, 4); pushw(memw_a16[ds, 0xa2e]);               /* push word [0xa2e] */
            ii(0x13_8db6, 4); pushw(memw_a16[ds, 0xa2c]);               /* push word [0xa2c] */
            ii(0x13_8dba, 1); nop();                                    /* nop */
            ii(0x13_8dbb, 1); pushw(cs);                                /* push cs */
            ii(0x13_8dbc, 3); callw(0x13_e758, 0x5999);                 /* call 0xe758 */
            ii(0x13_8dbf, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_8dc2, 1); popw(ds);                                 /* pop ds */
            ii(0x13_8dc3, 1); retfw(); return;                          /* retf */
        }
    }
}
