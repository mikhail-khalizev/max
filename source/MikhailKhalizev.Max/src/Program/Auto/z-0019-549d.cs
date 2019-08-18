using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_549d-95d83e87")]
        public void Method_0019_549d()
        {
            ii(0x19_549d, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x19_54a1, 1); pushw(di);                                /* push di */
            ii(0x19_54a2, 1); pushw(si);                                /* push si */
            ii(0x19_54a3, 1); pushw(ds);                                /* push ds */
            ii(0x19_54a4, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_54a7, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_54a9, 3); mov(ax, 0xd90);                           /* mov ax, 0xd90 */
            ii(0x19_54ac, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_54ae, 3); jmpw(0x19_54b1, 0); goto l_0x19_54b1;     /* jmp 0x54b1 */
        l_0x19_54b1:
            ii(0x19_54b1, 1); popw(ds);                                 /* pop ds */
            ii(0x19_54b2, 1); popw(si);                                 /* pop si */
            ii(0x19_54b3, 1); popw(di);                                 /* pop di */
            ii(0x19_54b4, 1); leavew();                                 /* leave */
            ii(0x19_54b5, 1); retfw(); return;                          /* retf */
        }
    }
}
