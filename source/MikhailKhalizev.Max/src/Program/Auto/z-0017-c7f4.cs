using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_c7f4-12b0710a")]
        public void Method_0017_c7f4()
        {
            ii(0x17_c7f4, 4); enter(0x2, 0);                            /* enter 0x2, 0x0 */
            ii(0x17_c7f8, 1); push(ds);                                 /* push ds */
            ii(0x17_c7f9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_c7fc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_c7fe, 1); push(cs);                                 /* push cs */
            ii(0x17_c7ff, 3); call(0x17_c6b4, -0x14e);                  /* call 0xc6b4 */
            ii(0x17_c802, 3); mov(memb[ss, bp - 0x2], al);              /* mov [bp-0x2], al */
            ii(0x17_c805, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_c807, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_c809, 1); inc(ax);                                  /* inc ax */
            ii(0x17_c80a, 2); if(jz(0x17_c82d, 0x21)) goto l_0x17_c82d; /* jz 0xc82d */
            ii(0x17_c80c, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_c80f, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x17_c812, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x17_c814, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x17_c817, 4); mov(memw[ds, bx + 0x2020], ax);           /* mov [bx+0x2020], ax */
            ii(0x17_c81b, 4); mov(memw[ds, bx + 0x2022], dx);           /* mov [bx+0x2022], dx */
            ii(0x17_c81f, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x17_c822, 3); mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
            ii(0x17_c825, 4); mov(memw[ds, bx + 0x2024], ax);           /* mov [bx+0x2024], ax */
            ii(0x17_c829, 4); mov(memw[ds, bx + 0x2026], dx);           /* mov [bx+0x2026], dx */
        l_0x17_c82d:
            ii(0x17_c82d, 3); mov(al, memb[ss, bp - 0x2]);              /* mov al, [bp-0x2] */
            ii(0x17_c830, 1); pop(ds);                                  /* pop ds */
            ii(0x17_c831, 1); leave();                                  /* leave */
            ii(0x17_c832, 1); retf();                                   /* retf */
        }
    }
}
