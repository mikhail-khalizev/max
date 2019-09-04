using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8bd0-5e9bfa0f")]
        public void Method_0019_8bd0()
        {
            ii(0x19_8bd0, 1); push(ds);                                 /* push ds */
            ii(0x19_8bd1, 3); push(0x1a42);                             /* push 0x1a42 */
            ii(0x19_8bd4, 3); call(0x19_1066, -0x7b71);                 /* call 0x1066 */
            ii(0x19_8bd7, 1); pop(bx);                                  /* pop bx */
            ii(0x19_8bd8, 1); pop(bx);                                  /* pop bx */
            ii(0x19_8bd9, 2); push(2);                                  /* push 0x2 */
            ii(0x19_8bdb, 1); nop();                                    /* nop */
            ii(0x19_8bdc, 1); push(cs);                                 /* push cs */
            ii(0x19_8bdd, 3); call(0x19_fd12, 0x7132);                  /* call 0xfd12 */
            ii(0x19_8be0, 1); push(ds);                                 /* push ds */
            ii(0x19_8be1, 3); push(0x1a53);                             /* push 0x1a53 */
            ii(0x19_8be4, 3); call(0x19_1066, -0x7b81);                 /* call 0x1066 */
            ii(0x19_8be7, 1); pop(bx);                                  /* pop bx */
            ii(0x19_8be8, 1); pop(bx);                                  /* pop bx */
            ii(0x19_8be9, 1); ret();                                    /* ret */
        }
    }
}
