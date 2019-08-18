using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("07725f75-f835-4894-b70f-65c20be21379")]
        public void Method_0018_0603()
        {
            ii(0x18_0603, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x18_0607, 1); pushw(es);                                /* push es */
            ii(0x18_0608, 1); pushw(ds);                                /* push ds */
            ii(0x18_0609, 1); pushw(di);                                /* push di */
            ii(0x18_060a, 1); pushw(si);                                /* push si */
            ii(0x18_060b, 1); pushw(cx);                                /* push cx */
            ii(0x18_060c, 1); cld();                                    /* cld */
            ii(0x18_060d, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x18_0610, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x18_0613, 3); mov(cx, memw_a16[ss, bp + 0xe]);          /* mov cx, [bp+0xe] */
            ii(0x18_0616, 2); repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x18_0618, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x18_061a, 1); popw(cx);                                 /* pop cx */
            ii(0x18_061b, 1); popw(si);                                 /* pop si */
            ii(0x18_061c, 1); popw(di);                                 /* pop di */
            ii(0x18_061d, 1); popw(ds);                                 /* pop ds */
            ii(0x18_061e, 1); popw(es);                                 /* pop es */
            ii(0x18_061f, 1); leavew();                                 /* leave */
            ii(0x18_0620, 1); retfw(); return;                          /* retf */
        }
    }
}
