using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("39f400c4-0367-460f-8939-8501c87dfbcc")]
        public void Method_0016_0de7()
        {
            ii(0x16_0de7, 4); enterw(0x1e, 0);                          /* enter 0x1e, 0x0 */
            ii(0x16_0deb, 1); pushw(ds);                                /* push ds */
            ii(0x16_0dec, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_0def, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0df1, 4); mov(memb_a16[ss, bp - 0x1e], 0x62);       /* mov byte [bp-0x1e], 0x62 */
            ii(0x16_0df5, 4); mov(memb_a16[ss, bp - 0x1d], 0x70);       /* mov byte [bp-0x1d], 0x70 */
            ii(0x16_0df9, 4); mov(memb_a16[ss, bp - 0x1c], 0x20);       /* mov byte [bp-0x1c], 0x20 */
            ii(0x16_0dfd, 2); pushw(0);                                 /* push 0x0 */
            ii(0x16_0dff, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0e02, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x16_0e04, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x16_0e06, 3); lea(ax, bp - 0x1b);                       /* lea ax, [bp-0x1b] */
            ii(0x16_0e09, 1); pushw(ss);                                /* push ss */
            ii(0x16_0e0a, 1); pushw(ax);                                /* push ax */
            ii(0x16_0e0b, 1); pushw(cs);                                /* push cs */
            ii(0x16_0e0c, 3); callw(0x16_03cb, -0xa44);                 /* call 0x3cb */
            ii(0x16_0e0f, 4); mov(memb_a16[ss, bp - 0x17], 0x3a);       /* mov byte [bp-0x17], 0x3a */
            ii(0x16_0e13, 2); pushw(0);                                 /* push 0x0 */
            ii(0x16_0e15, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x16_0e18, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x16_0e1a, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x16_0e1c, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x16_0e1f, 1); pushw(ss);                                /* push ss */
            ii(0x16_0e20, 1); pushw(ax);                                /* push ax */
            ii(0x16_0e21, 1); pushw(cs);                                /* push cs */
            ii(0x16_0e22, 3); callw(0x16_03cb, -0xa5a);                 /* call 0x3cb */
            ii(0x16_0e25, 3); lea(ax, bp - 0x12);                       /* lea ax, [bp-0x12] */
            ii(0x16_0e28, 1); pushw(ss);                                /* push ss */
            ii(0x16_0e29, 1); pushw(ax);                                /* push ax */
            ii(0x16_0e2a, 1); pushw(ds);                                /* push ds */
            ii(0x16_0e2b, 3); pushw(0x38a9);                            /* push 0x38a9 */
            ii(0x16_0e2e, 3); callw(0x15_ff6c, -0xec5);                 /* call 0xff6c */
            ii(0x16_0e31, 3); lea(ax, bp - 0x1e);                       /* lea ax, [bp-0x1e] */
            ii(0x16_0e34, 1); pushw(ss);                                /* push ss */
            ii(0x16_0e35, 1); pushw(ax);                                /* push ax */
            ii(0x16_0e36, 5); callw_far_abs(0x80, 0x4f2c);              /* call word 0x80:0x4f2c */
            ii(0x16_0e3b, 1); popw(bx);                                 /* pop bx */
            ii(0x16_0e3c, 1); popw(bx);                                 /* pop bx */
            ii(0x16_0e3d, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0e3e, 1); leavew();                                 /* leave */
            ii(0x16_0e3f, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
