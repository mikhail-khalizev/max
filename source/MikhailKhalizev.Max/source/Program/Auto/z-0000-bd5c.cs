using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbd5c-78b5e738")]
        public void Method_0000_bd5c()
        {
            ii(0xbd5c, 1);  pop(cx);                                   /* pop cx */
            ii(0xbd5d, 1);  push(cx);                                  /* push cx */
            ii(0xbd5e, 1);  push(cx);                                  /* push cx */
            ii(0xbd5f, 2);  mov(ax, sp);                               /* mov ax, sp */
            ii(0xbd61, 2);  jmp_abs(cx);                               /* jmp cx */
        }
    }
}
