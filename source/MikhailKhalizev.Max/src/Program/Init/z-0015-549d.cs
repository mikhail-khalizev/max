using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c146cb36-e4fc-4f0f-a377-37bae31d1b59")]
        public void Method_0015_549d()
        {
            ii(0x15_549d, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_54a1, 1); pushw(di);                                /* push di */
            ii(0x15_54a2, 1); pushw(si);                                /* push si */
            ii(0x15_54a3, 1); pushw(ds);                                /* push ds */
            ii(0x15_54a4, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_54a7, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_54a9, 3); mov(ax, 0xd90);                           /* mov ax, 0xd90 */
            ii(0x15_54ac, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x15_54ae, 3); jmpw(0x15_54b1, 0); goto l_0x15_54b1;     /* jmp 0x54b1 */
        l_0x15_54b1:
            ii(0x15_54b1, 1); popw(ds);                                 /* pop ds */
            ii(0x15_54b2, 1); popw(si);                                 /* pop si */
            ii(0x15_54b3, 1); popw(di);                                 /* pop di */
            ii(0x15_54b4, 1); leavew();                                 /* leave */
            ii(0x15_54b5, 1); retfw(); return;                          /* retf */
        }
    }
}
