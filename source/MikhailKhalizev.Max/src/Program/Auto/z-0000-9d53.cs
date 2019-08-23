using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9d53-293a2d77")]
        public void Method_0000_9d53()
        {
            ii(0x9d53, 1);    popw(cx);                                 /* pop cx */
            ii(0x9d54, 1);    popw(ax);                                 /* pop ax */
            ii(0x9d55, 1);    popw(ax);                                 /* pop ax */
            ii(0x9d56, 2);    jmpw_abs(cx);                             /* jmp cx */
        }
    }
}
