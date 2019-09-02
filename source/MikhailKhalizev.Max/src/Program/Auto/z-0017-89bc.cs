using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_89bc-64d2978")]
        public void Method_0017_89bc()
        {
            ii(0x17_89bc, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x17_89c0, 1); push(ds);                                 /* push ds */
            ii(0x17_89c1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_89c4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_89c6, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x17_89c9, 3); mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x17_89cc, 3); mov(cx, 8);                               /* mov cx, 0x8 */
            ii(0x17_89cf, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_89d1, 3); mov(memw[ss, bp - 4], bx);                /* mov [bp-0x4], bx */
            ii(0x17_89d4, 3); mov(memw[ss, bp - 2], es);                /* mov [bp-0x2], es */
            ii(0x17_89d7, 4); mov(memw[es, bx + 2], ax);                /* mov [es:bx+0x2], ax */
            ii(0x17_89db, 3); mov(al, memb[ss, bp + 0xa]);              /* mov al, [bp+0xa] */
            ii(0x17_89de, 4); mov(memb[es, bx + 4], al);                /* mov [es:bx+0x4], al */
            ii(0x17_89e2, 3); mov(al, memb[ss, bp + 0xb]);              /* mov al, [bp+0xb] */
            ii(0x17_89e5, 4); mov(memb[es, bx + 7], al);                /* mov [es:bx+0x7], al */
            ii(0x17_89e9, 1); pop(ds);                                  /* pop ds */
            ii(0x17_89ea, 1); leave();                                  /* leave */
            ii(0x17_89eb, 1); retf();                                   /* retf */
        }
    }
}
