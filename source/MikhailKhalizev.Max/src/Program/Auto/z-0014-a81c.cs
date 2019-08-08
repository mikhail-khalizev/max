using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f3bfb68f-c207-45ba-98e3-6ffc46afe910")]
        public void Method_0014_a81c()
        {
            ii(0x14_a81c, 3); callw(0x14_a893, 0x74);                   /* call 0xa893 */
            ii(0x14_a81f, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x14_a821, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x14_a823, 1); cld();                                    /* cld */
            ii(0x14_a824, 3); lea(di, bp + 0x8);                        /* lea di, [bp+0x8] */
            ii(0x14_a827, 3); lea(si, bx + 0x8);                        /* lea si, [bx+0x8] */
            ii(0x14_a82a, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x14_a82d, 2); rep_a16(() => movsw_a16());               /* rep movsw */
        }
    }
}
