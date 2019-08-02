using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("de614931-6908-4f2c-93fc-bfdb1a78c431")]
        public void Method_0015_5e4b()
        {
            ii(0x15_5e4b, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_5e4f, 1); pushw(di);                                /* push di */
            ii(0x15_5e50, 1); pushw(si);                                /* push si */
            ii(0x15_5e51, 1); pushw(ds);                                /* push ds */
            ii(0x15_5e52, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_5e55, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_5e57, 3); mov(ax, 0xaba);                           /* mov ax, 0xaba */
            ii(0x15_5e5a, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x15_5e5c, 3); jmpw(0x15_5e5f, 0); goto l_0x15_5e5f;     /* jmp 0x5e5f */
        l_0x15_5e5f:
            ii(0x15_5e5f, 1); popw(ds);                                 /* pop ds */
            ii(0x15_5e60, 1); popw(si);                                 /* pop si */
            ii(0x15_5e61, 1); popw(di);                                 /* pop di */
            ii(0x15_5e62, 1); leavew();                                 /* leave */
            ii(0x15_5e63, 1); retfw(); return;                          /* retf */
        }
    }
}
