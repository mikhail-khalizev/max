using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a514-dd8e7526")]
        public void /* sys */ Method_1016_a514()
        {
            ii(0x1016_a514, 1); push(edx);                              /* push edx */
            ii(0x1016_a515, 6); mov(edx, memd[ds, 0x101c_f964]);        /* mov edx, [0x101cf964] */
            ii(0x1016_a51b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_a520, 3); mov(edx, memd[ds, edx + 0xc]);          /* mov edx, [edx+0xc] */
            ii(0x1016_a523, 3); mov(eax, memd[ds, edx + eax * 8]);      /* mov eax, [edx+eax*8] */
            ii(0x1016_a526, 1); pop(edx);                               /* pop edx */
            ii(0x1016_a527, 1); ret();                                  /* ret */
        }
    }
}
