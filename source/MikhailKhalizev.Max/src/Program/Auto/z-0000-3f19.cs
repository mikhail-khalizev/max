using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b930732e-fc4b-4b32-b44f-d2dc58785ff6")]
        public void Method_0000_3f19()
        {
            ii(0x3f19, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x3f1b, 1);    popw(ds);                                 /* pop ds */
        }
    }
}
