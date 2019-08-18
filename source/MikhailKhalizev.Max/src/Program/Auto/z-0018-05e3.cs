using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8130c2ff-0da8-4255-9435-006790467cb3")]
        public void Method_0018_05e3()
        {
            ii(0x18_05e3, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x18_05e7, 1); pushw(es);                                /* push es */
            ii(0x18_05e8, 1); pushw(di);                                /* push di */
            ii(0x18_05e9, 1); pushw(cx);                                /* push cx */
            ii(0x18_05ea, 1); cld();                                    /* cld */
            ii(0x18_05eb, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x18_05ee, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x18_05f1, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x18_05f4, 2); repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x18_05f6, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x18_05f8, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x18_05fb, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x18_05fd, 1); dec(ax);                                  /* dec ax */
            ii(0x18_05fe, 1); popw(cx);                                 /* pop cx */
            ii(0x18_05ff, 1); popw(di);                                 /* pop di */
            ii(0x18_0600, 1); popw(es);                                 /* pop es */
            ii(0x18_0601, 1); leavew();                                 /* leave */
            ii(0x18_0602, 1); retfw(); return;                          /* retf */
        }
    }
}
