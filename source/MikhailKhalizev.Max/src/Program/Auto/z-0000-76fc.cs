using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2ebeddcb-7fd8-4aa5-8954-2a00eb69ce7d")]
        public void Method_0000_76fc()
        {
            ii(0x76fc, 4);    enterw(0x18, 0);                          /* enter 0x18, 0x0 */
            ii(0x7700, 4);    mov(memb_a16[ss, bp - 0xd], 0x48);        /* mov byte [bp-0xd], 0x48 */
            ii(0x7704, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x7707, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x770a, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x770d, 1);    pushw(ax);                                /* push ax */
            ii(0x770e, 1);    pushw(ax);                                /* push ax */
            ii(0x770f, 3);    callw(0x6470, -0x12a2);                   /* call 0x6470 */
            ii(0x7712, 1);    popw(bx);                                 /* pop bx */
            ii(0x7713, 1);    popw(bx);                                 /* pop bx */
            ii(0x7714, 4);    test(memb_a16[ss, bp - 0x2], 0x1);        /* test byte [bp-0x2], 0x1 */
            ii(0x7718, 2);    if(jzw(0x771f, 0x5)) goto l_0x771f;       /* jz 0x771f */
            ii(0x771a, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x771c, 1);    cwd();                                    /* cwd */
            ii(0x771d, 1);    leavew();                                 /* leave */
            ii(0x771e, 1);    retw(); return;                           /* ret */
        l_0x771f:
            ii(0x771f, 3);    mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x7722, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x7724, 1);    leavew();                                 /* leave */
            ii(0x7725, 1);    retw(); return;                           /* ret */
        }
    }
}
