using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_f1aa-794615d1")]
        public void Method_0017_f1aa()
        {
            ii(0x17_f1aa, 4); enter(0x14, 0);                           /* enter 0x14, 0x0 */
            ii(0x17_f1ae, 1); push(ds);                                 /* push ds */
            ii(0x17_f1af, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_f1b2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_f1b4, 5); cmp(memw[ds, 0x1412], 0);                 /* cmp word [0x1412], 0x0 */
            ii(0x17_f1b9, 2); if(jnz(0x17_f1dc, 0x21)) goto l_0x17_f1dc; /* jnz 0xf1dc */
            ii(0x17_f1bb, 5); mov(memw[ss, bp - 0x4], 0x1);             /* mov word [bp-0x4], 0x1 */
            ii(0x17_f1c0, 2); push(0);                                  /* push 0x0 */
            ii(0x17_f1c2, 2); push(0);                                  /* push 0x0 */
            ii(0x17_f1c4, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x17_f1c7, 1); push(ss);                                 /* push ss */
            ii(0x17_f1c8, 1); push(ax);                                 /* push ax */
            ii(0x17_f1c9, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x17_f1cc, 2); push(0x1);                                /* push 0x1 */
            ii(0x17_f1ce, 1); nop();                                    /* nop */
            ii(0x17_f1cf, 1); push(cs);                                 /* push cs */
            ii(0x17_f1d0, 3); call(0x17_eb98, -0x63b);                  /* call 0xeb98 */
            ii(0x17_f1d3, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_f1d6, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_f1d8, 1); pop(ds);                                  /* pop ds */
            ii(0x17_f1d9, 1); leave();                                  /* leave */
            ii(0x17_f1da, 1); retf(); return;                           /* retf */
        //  ii(0x17_f1db, 1); Недостижимый код.
        l_0x17_f1dc:
            ii(0x17_f1dc, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_f1df, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_f1e2, 5); mov(memw[ss, bp - 0x6], 0x700);           /* mov word [bp-0x6], 0x700 */
            ii(0x17_f1e7, 2); push(0);                                  /* push 0x0 */
            ii(0x17_f1e9, 2); push(0);                                  /* push 0x0 */
            ii(0x17_f1eb, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x17_f1ee, 1); push(ss);                                 /* push ss */
            ii(0x17_f1ef, 1); push(ax);                                 /* push ax */
            ii(0x17_f1f0, 3); push(0xff00);                             /* push 0xff00 */
            ii(0x17_f1f3, 1); nop();                                    /* nop */
            ii(0x17_f1f4, 1); push(cs);                                 /* push cs */
            ii(0x17_f1f5, 3); call(0x17_eb40, -0x6b8);                  /* call 0xeb40 */
            ii(0x17_f1f8, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_f1fb, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_f1fd, 1); pop(ds);                                  /* pop ds */
            ii(0x17_f1fe, 1); leave();                                  /* leave */
            ii(0x17_f1ff, 1); retf();                                   /* retf */
        }
    }
}
