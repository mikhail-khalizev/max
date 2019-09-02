using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e2a0-cd7bda05")]
        public void Method_0019_e2a0()
        {
            ii(0x19_e2a0, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x19_e2a4, 1); push(ds);                                 /* push ds */
            ii(0x19_e2a5, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_e2a8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_e2aa, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x19_e2ad, 3); mov(bx, memw[ss, bp + 0xa]);              /* mov bx, [bp+0xa] */
            ii(0x19_e2b0, 3); mov(cx, 8);                               /* mov cx, 0x8 */
            ii(0x19_e2b3, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x19_e2b5, 4); mov(memw[es, bx + 2], ax);                /* mov [es:bx+0x2], ax */
            ii(0x19_e2b9, 3); mov(al, memb[ss, bp + 8]);                /* mov al, [bp+0x8] */
            ii(0x19_e2bc, 4); mov(memb[es, bx + 4], al);                /* mov [es:bx+0x4], al */
            ii(0x19_e2c0, 3); mov(al, memb[ss, bp + 9]);                /* mov al, [bp+0x9] */
            ii(0x19_e2c3, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_e2c5, 4); mov(memb[es, bx + 7], al);                /* mov [es:bx+0x7], al */
            ii(0x19_e2c9, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x19_e2cc, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_e2cf, 5); mov(memb[es, bx + 6], 0);                 /* mov byte [es:bx+0x6], 0x0 */
            ii(0x19_e2d4, 5); mov(memb[es, bx + 5], 0x93);              /* mov byte [es:bx+0x5], 0x93 */
            ii(0x19_e2d9, 1); pop(ds);                                  /* pop ds */
            ii(0x19_e2da, 1); leave();                                  /* leave */
            ii(0x19_e2db, 3); ret(8);                                   /* ret 0x8 */
        }
    }
}
