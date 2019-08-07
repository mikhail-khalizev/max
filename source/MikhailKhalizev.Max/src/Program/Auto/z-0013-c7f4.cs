using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("789a0293-55bc-4ad8-b3c0-57d3c55fb402")]
        public void Method_0013_c7f4()
        {
            ii(0x13_c7f4, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x13_c7f8, 1); pushw(ds);                                /* push ds */
            ii(0x13_c7f9, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_c7fc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_c7fe, 1); pushw(cs);                                /* push cs */
            ii(0x13_c7ff, 3); callw(0x13_c6b4, -0x14e);                 /* call 0xc6b4 */
            ii(0x13_c802, 3); mov(memb_a16[ss, bp - 0x2], al);          /* mov [bp-0x2], al */
            ii(0x13_c805, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_c807, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_c809, 1); inc(ax);                                  /* inc ax */
            ii(0x13_c80a, 2); if(jzw(0x13_c82d, 0x21)) goto l_0x13_c82d; /* jz 0xc82d */
            ii(0x13_c80c, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_c80f, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_c812, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x13_c814, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x13_c817, 4); mov(memw_a16[ds, bx + 0x2020], ax);       /* mov [bx+0x2020], ax */
            ii(0x13_c81b, 4); mov(memw_a16[ds, bx + 0x2022], dx);       /* mov [bx+0x2022], dx */
            ii(0x13_c81f, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x13_c822, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x13_c825, 4); mov(memw_a16[ds, bx + 0x2024], ax);       /* mov [bx+0x2024], ax */
            ii(0x13_c829, 4); mov(memw_a16[ds, bx + 0x2026], dx);       /* mov [bx+0x2026], dx */
        l_0x13_c82d:
            ii(0x13_c82d, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x13_c830, 1); popw(ds);                                 /* pop ds */
            ii(0x13_c831, 1); leavew();                                 /* leave */
            ii(0x13_c832, 1); retfw(); return;                          /* retf */
        }
    }
}
