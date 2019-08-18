using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3313dc72-6929-4359-867f-1a066e5b2157")]
        public void Method_0000_46d1()
        {
            ii(0x46d1, 1);    nop();                                    /* nop */
            ii(0x46d2, 1);    pushw(ax);                                /* push ax */
            ii(0x46d3, 1);    pushw(bx);                                /* push bx */
            ii(0x46d4, 4);    if(jmpw_abs(memw_a16[ds, 0x9be])) return; /* jmp word [0x9be] */
        }
    }
}
