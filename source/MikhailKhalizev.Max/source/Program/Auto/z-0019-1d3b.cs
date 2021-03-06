using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1d3b-aec99cef")]
        public void Method_0019_1d3b()
        {
            ii(0x19_1d3b, 1);  push(bp);                               /* push bp */
            ii(0x19_1d3c, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_1d3e, 3);  mov(ax, memw[ss, bp + 4]);              /* mov ax, [bp+0x4] */
            ii(0x19_1d41, 3);  cmp(memw[ss, bp + 6], ax);              /* cmp [bp+0x6], ax */
            ii(0x19_1d44, 2);  if(jg(0x19_1d49, 3)) goto l_0x19_1d49;  /* jg 0x1d49 */
            ii(0x19_1d46, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
        l_0x19_1d49:
            ii(0x19_1d49, 1);  leave();                                /* leave */
            ii(0x19_1d4a, 1);  ret();                                  /* ret */
        }
    }
}
