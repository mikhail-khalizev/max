using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8bea-43673a5e")]
        public void Method_0019_8bea()
        {
            ii(0x19_8bea, 1); pushw(ds);                                /* push ds */
            ii(0x19_8beb, 3); pushw(0x1a5f);                            /* push 0x1a5f */
            ii(0x19_8bee, 3); callw(0x19_1066, -0x7b8b);                /* call 0x1066 */
            ii(0x19_8bf1, 1); popw(bx);                                 /* pop bx */
            ii(0x19_8bf2, 1); popw(bx);                                 /* pop bx */
            ii(0x19_8bf3, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x19_8bf5, 1); nop();                                    /* nop */
            ii(0x19_8bf6, 1); pushw(cs);                                /* push cs */
            ii(0x19_8bf7, 3); callw(0x19_fd3c, 0x7142);                 /* call 0xfd3c */
            ii(0x19_8bfa, 1); pushw(ds);                                /* push ds */
            ii(0x19_8bfb, 3); pushw(0x1a6f);                            /* push 0x1a6f */
            ii(0x19_8bfe, 3); callw(0x19_1066, -0x7b9b);                /* call 0x1066 */
            ii(0x19_8c01, 1); popw(bx);                                 /* pop bx */
            ii(0x19_8c02, 1); popw(bx);                                 /* pop bx */
            ii(0x19_8c03, 1); retw(); return;                           /* ret */
        }
    }
}
