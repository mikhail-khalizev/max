using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x46d1-53cc6f46")]
        public void Method_0000_46d1_v2()
        {
            ii(0x46d1, 1);    wait();                                   /* wait */
            ii(0x46d2, 1);    push(ax);                                 /* push ax */
            ii(0x46d3, 1);    push(bx);                                 /* push bx */
            ii(0x46d4, 4);    jmp_abs(memw[ds, 0x9be]);                 /* jmp word [0x9be] */
        }
    }
}
