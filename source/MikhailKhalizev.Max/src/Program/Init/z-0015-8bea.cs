using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ea848b86-a13f-4c4d-a1b2-851eb4bc03f1")]
        public void Method_0015_8bea()
        {
            ii(0x15_8bea, 1); pushw(ds);                                /* push ds */
            ii(0x15_8beb, 3); pushw(0x1a5f);                            /* push 0x1a5f */
            ii(0x15_8bee, 3); callw(0x15_1066, -0x7b8b);                /* call 0x1066 */
            ii(0x15_8bf1, 1); popw(bx);                                 /* pop bx */
            ii(0x15_8bf2, 1); popw(bx);                                 /* pop bx */
            ii(0x15_8bf3, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_8bf5, 1); nop();                                    /* nop */
            ii(0x15_8bf6, 1); pushw(cs);                                /* push cs */
            ii(0x15_8bf7, 3); callw(0x15_fd3c, 0x7142);                 /* call 0xfd3c */
            ii(0x15_8bfa, 1); pushw(ds);                                /* push ds */
            ii(0x15_8bfb, 3); pushw(0x1a6f);                            /* push 0x1a6f */
            ii(0x15_8bfe, 3); callw(0x15_1066, -0x7b9b);                /* call 0x1066 */
            ii(0x15_8c01, 1); popw(bx);                                 /* pop bx */
            ii(0x15_8c02, 1); popw(bx);                                 /* pop bx */
            ii(0x15_8c03, 1); retw(); return;                           /* ret */
        }
    }
}
