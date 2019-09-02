using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8d64-d3ce74ef")]
        public void Method_0017_8d64()
        {
            ii(0x17_8d64, 1); push(ds);                                 /* push ds */
            ii(0x17_8d65, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_8d68, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_8d6a, 3); push(0x100);                              /* push 0x100 */
            ii(0x17_8d6d, 1); push(cs);                                 /* push cs */
            ii(0x17_8d6e, 3); call(0x17_80e0, -0xc91);                  /* call 0x80e0 */
            ii(0x17_8d71, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x17_8d73, 1); push(ax);                                 /* push ax */
            ii(0x17_8d74, 1); push(cx);                                 /* push cx */
            ii(0x17_8d75, 1); nop();                                    /* nop */
            ii(0x17_8d76, 1); push(cs);                                 /* push cs */
            ii(0x17_8d77, 3); call(0x17_ea1e, 0x5ca4);                  /* call 0xea1e */
            ii(0x17_8d7a, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_8d7d, 3); mov(memw[ds, 0xa2c], ax);                 /* mov [0xa2c], ax */
            ii(0x17_8d80, 4); mov(memw[ds, 0xa2e], dx);                 /* mov [0xa2e], dx */
            ii(0x17_8d84, 4); les(bx, memw[ds, 0xa2c]);                 /* les bx, [0xa2c] */
            ii(0x17_8d88, 4); mov(ax, memw[es, bx + 0x36]);             /* mov ax, [es:bx+0x36] */
            ii(0x17_8d8c, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_8d8e, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_8d90, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_8d92, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_8d94, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_8d96, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_8d98, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_8d9a, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_8d9c, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_8d9e, 4); add(ax, memw[es, bx + 0x34]);             /* add ax, [es:bx+0x34] */
            ii(0x17_8da2, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_8da5, 1); push(dx);                                 /* push dx */
            ii(0x17_8da6, 1); push(ax);                                 /* push ax */
            ii(0x17_8da7, 4); push(memw[ds, 0xa32]);                    /* push word [0xa32] */
            ii(0x17_8dab, 1); push(cs);                                 /* push cs */
            ii(0x17_8dac, 3); call(0x17_89bc, -0x3f3);                  /* call 0x89bc */
            ii(0x17_8daf, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_8db2, 4); push(memw[ds, 0xa2e]);                    /* push word [0xa2e] */
            ii(0x17_8db6, 4); push(memw[ds, 0xa2c]);                    /* push word [0xa2c] */
            ii(0x17_8dba, 1); nop();                                    /* nop */
            ii(0x17_8dbb, 1); push(cs);                                 /* push cs */
            ii(0x17_8dbc, 3); call(0x17_e758, 0x5999);                  /* call 0xe758 */
            ii(0x17_8dbf, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_8dc2, 1); pop(ds);                                  /* pop ds */
            ii(0x17_8dc3, 1); retf();                                   /* retf */
        }
    }
}
