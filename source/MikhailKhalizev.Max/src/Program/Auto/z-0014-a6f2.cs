using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8a73ef11-aa3f-4888-9848-7479803eb975")]
        public void Method_0014_a6f2()
        {
            ii(0x14_a6f2, 1); pushw(ds);                                /* push ds */
            ii(0x14_a6f3, 1); cbw();                                    /* cbw */
            ii(0x14_a6f4, 1); pushw(ax);                                /* push ax */
            ii(0x14_a6f5, 3); callw(0x14_e868, 0x4170);                 /* call 0xe868 */
            ii(0x14_a6f8, 1); popw(bx);                                 /* pop bx */
            ii(0x14_a6f9, 2); add(bx, bx);                              /* add bx, bx */
            ii(0x14_a6fb, 4); mov(bx, memw_a16[ds, bx + 0x44b8]);       /* mov bx, [bx+0x44b8] */
            ii(0x14_a6ff, 4); test(memb_a16[ds, bx - 0x2], 0x1);        /* test byte [bx-0x2], 0x1 */
            ii(0x14_a703, 2); if(jzw(0x14_a71b, 0x16)) goto l_0x14_a71b; /* jz 0xa71b */
            ii(0x14_a705, 3); mov(cx, memw_a16[ss, bp + 0x10]);         /* mov cx, [bp+0x10] */
            ii(0x14_a708, 3); mov(dx, memw_a16[ss, bp + 0x14]);         /* mov dx, [bp+0x14] */
            ii(0x14_a70b, 3); xchg(memw_a16[ds, bx - 0x4], cx);         /* xchg [bx-0x4], cx */
            ii(0x14_a70e, 3); xchg(memw_a16[ds, bx - 0x6], dx);         /* xchg [bx-0x6], dx */
            ii(0x14_a711, 3); mov(memw_a16[ss, bp + 0x14], dx);         /* mov [bp+0x14], dx */
            ii(0x14_a714, 3); mov(memw_a16[ss, bp + 0x10], cx);         /* mov [bp+0x10], cx */
            ii(0x14_a717, 4); or(memb_a16[ds, bx - 0x2], -0x80 /* 0x80 */); /* or byte [bx-0x2], 0x80 */
        l_0x14_a71b:
            ii(0x14_a71b, 1); popw(ds);                                 /* pop ds */
            ii(0x14_a71c, 2); if(jzw_func(0x14_a6ef, -0x2f)) return;    /* jz 0xa6ef */
            ii(0x14_a71e, 1); retw(); return;                           /* ret */
        }
    }
}
