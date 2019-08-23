using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a81c-57c7da8c")]
        public void Method_0018_a81c()
        {
            ii(0x18_a81c, 3); call(0x18_a893, 0x74);                    /* call 0xa893 */
            ii(0x18_a81f, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x18_a821, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x18_a823, 1); cld();                                    /* cld */
            ii(0x18_a824, 3); lea(di, bp + 0x8);                        /* lea di, [bp+0x8] */
            ii(0x18_a827, 3); lea(si, bx + 0x8);                        /* lea si, [bx+0x8] */
            ii(0x18_a82a, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x18_a82d, 2); rep(() => movsw());                       /* rep movsw */
        }
    }
}
