using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbd63-293a2d77")]
        public void Method_0000_bd63()
        {
            ii(0xbd63, 1);    pop(cx);                                  /* pop cx */
            ii(0xbd64, 1);    pop(ax);                                  /* pop ax */
            ii(0xbd65, 1);    pop(ax);                                  /* pop ax */
            ii(0xbd66, 2);    jmp_abs(cx);                              /* jmp cx */
        }
    }
}
