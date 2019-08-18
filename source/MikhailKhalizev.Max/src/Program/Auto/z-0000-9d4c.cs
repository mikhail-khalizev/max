using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26601ac4-b740-447b-900c-f9eb0a453b10")]
        public void Method_0000_9d4c()
        {
            ii(0x9d4c, 1);    popw(cx);                                 /* pop cx */
            ii(0x9d4d, 1);    pushw(cx);                                /* push cx */
            ii(0x9d4e, 1);    pushw(cx);                                /* push cx */
            ii(0x9d4f, 2);    mov(ax, sp);                              /* mov ax, sp */
            ii(0x9d51, 2);    if(jmpw_abs(cx)) return;                  /* jmp cx */
        }
    }
}
