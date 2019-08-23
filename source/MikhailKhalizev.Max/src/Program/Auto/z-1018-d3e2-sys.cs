using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d3e2-14593e8c")]
        public void /* sys */ Method_1018_d3e2()
        {
            ii(0x1018_d3e2, 1); push(edx);                              /* push edx */
            ii(0x1018_d3e3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_d3e5, 5); call(/* sys */ 0x1018_d7a8, 0x3be);     /* call 0x1018d7a8 */
            ii(0x1018_d3ea, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1018_d3ec, 1); pop(edx);                               /* pop edx */
            ii(0x1018_d3ed, 1); ret();                                  /* ret */
        }
    }
}
