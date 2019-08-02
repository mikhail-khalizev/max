using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0061f0e5-1ae2-4c8c-9d34-e21ed589f750")]
        public void Method_0015_8bd0()
        {
            ii(0x15_8bd0, 1); pushw(ds);                                /* push ds */
            ii(0x15_8bd1, 3); pushw(0x1a42);                            /* push 0x1a42 */
            ii(0x15_8bd4, 3); callw(0x15_1066, -0x7b71);                /* call 0x1066 */
            ii(0x15_8bd7, 1); popw(bx);                                 /* pop bx */
            ii(0x15_8bd8, 1); popw(bx);                                 /* pop bx */
            ii(0x15_8bd9, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_8bdb, 1); nop();                                    /* nop */
            ii(0x15_8bdc, 1); pushw(cs);                                /* push cs */
            ii(0x15_8bdd, 3); callw(0x15_fd12, 0x7132);                 /* call 0xfd12 */
            ii(0x15_8be0, 1); pushw(ds);                                /* push ds */
            ii(0x15_8be1, 3); pushw(0x1a53);                            /* push 0x1a53 */
            ii(0x15_8be4, 3); callw(0x15_1066, -0x7b81);                /* call 0x1066 */
            ii(0x15_8be7, 1); popw(bx);                                 /* pop bx */
            ii(0x15_8be8, 1); popw(bx);                                 /* pop bx */
            ii(0x15_8be9, 1); retw(); return;                           /* ret */
        }
    }
}
