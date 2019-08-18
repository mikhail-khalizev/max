using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e348ff2f-953d-4149-b2c8-d7cc02c15c9e")]
        public void Method_0017_e23c()
        {
            ii(0x17_e23c, 1); pushw(bx);                                /* push bx */
            ii(0x17_e23d, 1); pushw(es);                                /* push es */
            ii(0x17_e23e, 1); pushw(cx);                                /* push cx */
            ii(0x17_e23f, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x17_e242, 4); xchg(memw_a16[ds, 0x1da8], cx);           /* xchg [0x1da8], cx */
            ii(0x17_e246, 1); pushw(cx);                                /* push cx */
            ii(0x17_e247, 1); pushw(ax);                                /* push ax */
            ii(0x17_e248, 1); nop();                                    /* nop */
            ii(0x17_e249, 1); pushw(cs);                                /* push cs */
            ii(0x17_e24a, 3); callw(0x17_e318, 0xcb);                   /* call 0xe318 */
            ii(0x17_e24d, 1); popw(bx);                                 /* pop bx */
            ii(0x17_e24e, 4); popw(memw_a16[ds, 0x1da8]);               /* pop word [0x1da8] */
            ii(0x17_e252, 1); popw(cx);                                 /* pop cx */
            ii(0x17_e253, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x17_e255, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e257, 2); if(jzw(0x17_e25c, 0x3)) goto l_0x17_e25c; /* jz 0xe25c */
            ii(0x17_e259, 1); popw(es);                                 /* pop es */
            ii(0x17_e25a, 1); popw(bx);                                 /* pop bx */
            ii(0x17_e25b, 1); retw(); return;                           /* ret */
        l_0x17_e25c:
            ii(0x17_e25c, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x17_e25e, 3); if(jmpw_func(0x17_d16b, -0x10f6)) return; /* jmp 0xd16b */
        }
    }
}
