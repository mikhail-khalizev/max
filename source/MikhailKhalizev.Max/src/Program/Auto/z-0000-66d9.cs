using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fe18b2b0-f9c4-41fb-bb63-092ef761a98f")]
        public void Method_0000_66d9()
        {
            ii(0x66d9, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x66db, 1);    popw(ds);                                 /* pop ds */
        }
    }
}
