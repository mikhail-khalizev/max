using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_808e-a7dbaa27")]
        public void Method_0017_808e()
        {
            ii(0x17_808e, 4); enter(0x2, 0);                            /* enter 0x2, 0x0 */
            ii(0x17_8092, 1); push(ds);                                 /* push ds */
            ii(0x17_8093, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_8096, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_8098, 1); push(cs);                                 /* push cs */
            ii(0x17_8099, 3); call(0x17_80e0, 0x44);                    /* call 0x80e0 */
            ii(0x17_809c, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_809f, 1); push(cs);                                 /* push cs */
            ii(0x17_80a0, 3); call(0x17_805c, -0x47);                   /* call 0x805c */
            ii(0x17_80a3, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x17_80a6, 4); les(bx, memw[ds, 0xa26]);                 /* les bx, [0xa26] */
            ii(0x17_80aa, 4); cmp(memw[es, bx + 0x10], ax);             /* cmp [es:bx+0x10], ax */
            ii(0x17_80ae, 2); if(jz(0x17_80b4, 0x4)) goto l_0x17_80b4;  /* jz 0x80b4 */
            ii(0x17_80b0, 1); pop(ds);                                  /* pop ds */
            ii(0x17_80b1, 1); leave();                                  /* leave */
            ii(0x17_80b2, 1); retf(); return;                           /* retf */
        //  ii(0x17_80b3, 1); Недостижимый код.
        l_0x17_80b4:
            ii(0x17_80b4, 2); not(ax);                                  /* not ax */
            ii(0x17_80b6, 1); push(ax);                                 /* push ax */
            ii(0x17_80b7, 1); push(cs);                                 /* push cs */
            ii(0x17_80b8, 3); call(0x17_8106, 0x4b);                    /* call 0x8106 */
            ii(0x17_80bb, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_80be, 4); les(bx, memw[ds, 0xa26]);                 /* les bx, [0xa26] */
            ii(0x17_80c2, 4); mov(ax, memw[es, bx + 0x10]);             /* mov ax, [es:bx+0x10] */
            ii(0x17_80c6, 3); add(ax, memw[ss, bp - 0x2]);              /* add ax, [bp-0x2] */
            ii(0x17_80c9, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_80cc, 2); if(jnz(0x17_80d2, 0x4)) goto l_0x17_80d2; /* jnz 0x80d2 */
            ii(0x17_80ce, 4); inc(memb[ds, 0xa2a]);                     /* inc byte [0xa2a] */
        l_0x17_80d2:
            ii(0x17_80d2, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x17_80d5, 1); push(cs);                                 /* push cs */
            ii(0x17_80d6, 3); call(0x17_8106, 0x2d);                    /* call 0x8106 */
            ii(0x17_80d9, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_80dc, 1); pop(ds);                                  /* pop ds */
            ii(0x17_80dd, 1); leave();                                  /* leave */
            ii(0x17_80de, 1); retf();                                   /* retf */
        }
    }
}
