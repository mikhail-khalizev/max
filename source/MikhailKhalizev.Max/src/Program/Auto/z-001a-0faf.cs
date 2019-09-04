using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0faf-dcfc323c")]
        public void Method_001a_0faf()
        {
            ii(0x1a_0faf, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x1a_0fb3, 1); push(es);                                 /* push es */
            ii(0x1a_0fb4, 1); push(di);                                 /* push di */
            ii(0x1a_0fb5, 1); push(cx);                                 /* push cx */
            ii(0x1a_0fb6, 1); cld();                                    /* cld */
            ii(0x1a_0fb7, 3); les(di, memw[ss, bp + 6]);                /* les di, [bp+0x6] */
            ii(0x1a_0fba, 3); mov(ax, memw[ss, bp + 12]);               /* mov ax, [bp+0xc] */
            ii(0x1a_0fbd, 3); mov(cx, memw[ss, bp + 10]);               /* mov cx, [bp+0xa] */
            ii(0x1a_0fc0, 2); rep(() => stosb());                       /* rep stosb */
            ii(0x1a_0fc2, 1); nop();                                    /* nop */
            ii(0x1a_0fc3, 1); pop(cx);                                  /* pop cx */
            ii(0x1a_0fc4, 1); pop(di);                                  /* pop di */
            ii(0x1a_0fc5, 1); pop(es);                                  /* pop es */
            ii(0x1a_0fc6, 1); leave();                                  /* leave */
            ii(0x1a_0fc7, 1); retf();                                   /* retf */
        }
    }
}
