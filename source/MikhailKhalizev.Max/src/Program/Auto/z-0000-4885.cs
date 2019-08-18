using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1260b931-04fa-4914-af70-b82f43291a4d")]
        public void Method_0000_4885()
        {
            ii(0x4885, 1);    pushw(ss);                                /* push ss */
            ii(0x4886, 1);    popw(ds);                                 /* pop ds */
            ii(0x4887, 1);    retw(); return;                           /* ret */
        }
    }
}
