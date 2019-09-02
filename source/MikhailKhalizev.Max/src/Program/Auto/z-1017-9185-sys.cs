using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9185-bf984526")]
        public void /* sys */ Method_1017_9185()
        {
            ii(0x1017_9185, 1); push(edx);                              /* push edx */
            ii(0x1017_9186, 6); mov(edx, memd[ds, 0x101b_de0c]);        /* mov edx, [0x101bde0c] */
            ii(0x1017_918c, 5); call(/* sys */ 0x1017_9193, 2);         /* call 0x10179193 */
            ii(0x1017_9191, 1); pop(edx);                               /* pop edx */
            ii(0x1017_9192, 1); ret();                                  /* ret */
        }
    }
}
