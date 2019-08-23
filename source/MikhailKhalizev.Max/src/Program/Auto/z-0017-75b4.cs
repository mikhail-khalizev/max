using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_75b4-82bd889e")]
        public void Method_0017_75b4()
        {
            ii(0x17_75b4, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x17_75b8, 1); push(ds);                                 /* push ds */
            ii(0x17_75b9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_75bc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_75be, 3); lea(ax, bp + 0x8);                        /* lea ax, [bp+0x8] */
            ii(0x17_75c1, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_75c4, 3); mov(memw[ss, bp - 0x2], ss);              /* mov [bp-0x2], ss */
            ii(0x17_75c7, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x17_75ca, 1); push(ss);                                 /* push ss */
            ii(0x17_75cb, 1); push(ax);                                 /* push ax */
            ii(0x17_75cc, 3); mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x17_75cf, 1); push(ds);                                 /* push ds */
            ii(0x17_75d0, 2); push(memw[ds, bx]);                       /* push word [bx] */
            ii(0x17_75d2, 3); push(memw[ds, bx + 0x2]);                 /* push word [bx+0x2] */
            ii(0x17_75d5, 2); push(0x2);                                /* push 0x2 */
            ii(0x17_75d7, 1); push(ds);                                 /* push ds */
            ii(0x17_75d8, 3); push(0x494);                              /* push 0x494 */
            ii(0x17_75db, 1); nop();                                    /* nop */
            ii(0x17_75dc, 1); push(cs);                                 /* push cs */
            ii(0x17_75dd, 3); call(0x17_0f0c, -0x66d4);                 /* call 0xf0c */
            ii(0x17_75e0, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x17_75e3, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_75e5, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_75e8, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_75eb, 1); pop(ds);                                  /* pop ds */
            ii(0x17_75ec, 1); leave();                                  /* leave */
            ii(0x17_75ed, 1); retf();                                   /* retf */
        }
    }
}
