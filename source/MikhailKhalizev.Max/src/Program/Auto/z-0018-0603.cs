using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0603-5cda907f")]
        public void Method_0018_0603()
        {
            ii(0x18_0603, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x18_0607, 1); push(es);                                 /* push es */
            ii(0x18_0608, 1); push(ds);                                 /* push ds */
            ii(0x18_0609, 1); push(di);                                 /* push di */
            ii(0x18_060a, 1); push(si);                                 /* push si */
            ii(0x18_060b, 1); push(cx);                                 /* push cx */
            ii(0x18_060c, 1); cld();                                    /* cld */
            ii(0x18_060d, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x18_0610, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x18_0613, 3); mov(cx, memw[ss, bp + 0xe]);              /* mov cx, [bp+0xe] */
            ii(0x18_0616, 2); repe(() => cmpsb());                      /* repe cmpsb */
            ii(0x18_0618, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x18_061a, 1); pop(cx);                                  /* pop cx */
            ii(0x18_061b, 1); pop(si);                                  /* pop si */
            ii(0x18_061c, 1); pop(di);                                  /* pop di */
            ii(0x18_061d, 1); pop(ds);                                  /* pop ds */
            ii(0x18_061e, 1); pop(es);                                  /* pop es */
            ii(0x18_061f, 1); leave();                                  /* leave */
            ii(0x18_0620, 1); retf();                                   /* retf */
        }
    }
}
