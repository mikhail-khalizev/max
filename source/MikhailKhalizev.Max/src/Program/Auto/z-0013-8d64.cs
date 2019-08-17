using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("14b29d7d-1645-4add-bd80-66f8f31c6332")]
        public void Method_0013_8d64()
        {
            ii(0x13_8d64, 1); pushw(ds);                                /* push ds */
            ii(0x13_8d65, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_8d68, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_8d6a, 3); pushw(0x100);                             /* push 0x100 */
            ii(0x13_8d6d, 1); pushw(cs);                                /* push cs */
            ii(0x13_8d6e, 3); callw(0x13_80e0, -0xc91);                 /* call 0x80e0 */
        }
    }
}
