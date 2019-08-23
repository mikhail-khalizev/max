using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8ce4-6a9baa8e")]
        public void Method_0017_8ce4()
        {
            ii(0x17_8ce4, 4); enter(0x2, 0);                            /* enter 0x2, 0x0 */
            ii(0x17_8ce8, 1); push(ds);                                 /* push ds */
            ii(0x17_8ce9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_8cec, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_8cee, 5); mov(memw[ss, bp - 0x2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x17_8cf3, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_8cf7, 3); inc(memb[es, bx]);                        /* inc byte [es:bx] */
            ii(0x17_8cfa, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x17_8cfd, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x17_8d00, 1); push(cs);                                 /* push cs */
            ii(0x17_8d01, 3); call(0x17_8988, -0x37c);                  /* call 0x8988 */
            ii(0x17_8d04, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_8d07, 4); cmp(memb[ss, bp + 0x10], 0);              /* cmp byte [bp+0x10], 0x0 */
            ii(0x17_8d0b, 2); if(jz(0x17_8d10, 0x3)) goto l_0x17_8d10;  /* jz 0x8d10 */
            ii(0x17_8d0d, 2); jmp(0x17_8d54, 0x45); goto l_0x17_8d54;   /* jmp 0x8d54 */
        //  ii(0x17_8d0f, 1); nop();                                    /* nop */
        l_0x17_8d10:
            ii(0x17_8d10, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x17_8d13, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x17_8d16, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x17_8d19, 1); nop();                                    /* nop */
            ii(0x17_8d1a, 1); push(cs);                                 /* push cs */
            ii(0x17_8d1b, 3); call(0x17_9153, 0x435);                   /* call 0x9153 */
            ii(0x17_8d1e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_8d21, 2); push(0);                                  /* push 0x0 */
            ii(0x17_8d23, 3); push(0x1000);                             /* push 0x1000 */
            ii(0x17_8d26, 4); push(memw[ds, 0x4f82]);                   /* push word [0x4f82] */
            ii(0x17_8d2a, 4); push(memw[ds, 0x4f80]);                   /* push word [0x4f80] */
            ii(0x17_8d2e, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x17_8d31, 1); nop();                                    /* nop */
            ii(0x17_8d32, 1); push(cs);                                 /* push cs */
            ii(0x17_8d33, 3); call(0x17_9175, 0x43f);                   /* call 0x9175 */
            ii(0x17_8d36, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_8d39, 3); push(0x1000);                             /* push 0x1000 */
            ii(0x17_8d3c, 4); push(memw[ds, 0x4f82]);                   /* push word [0x4f82] */
            ii(0x17_8d40, 4); push(memw[ds, 0x4f80]);                   /* push word [0x4f80] */
            ii(0x17_8d44, 4); push(memw[ds, 0x4fba]);                   /* push word [0x4fba] */
            ii(0x17_8d48, 4); push(memw[ds, 0x4fb8]);                   /* push word [0x4fb8] */
            ii(0x17_8d4c, 1); nop();                                    /* nop */
            ii(0x17_8d4d, 1); push(cs);                                 /* push cs */
            ii(0x17_8d4e, 3); call(0x18_0621, 0x78d0);                  /* call 0x621 */
            ii(0x17_8d51, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x17_8d54:
            ii(0x17_8d54, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_8d58, 3); dec(memb[es, bx]);                        /* dec byte [es:bx] */
            ii(0x17_8d5b, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x17_8d5e, 1); pop(ds);                                  /* pop ds */
            ii(0x17_8d5f, 1); leave();                                  /* leave */
            ii(0x17_8d60, 1); retf();                                   /* retf */
        }
    }
}
