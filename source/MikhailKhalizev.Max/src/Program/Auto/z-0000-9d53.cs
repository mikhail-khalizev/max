using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("780cecf7-f5b6-495a-ad25-32601b213e9e")]
        public void Method_0000_9d53()
        {
            ii(0x9d53, 1);    popw(cx);                                 /* pop cx */
            ii(0x9d54, 1);    popw(ax);                                 /* pop ax */
            ii(0x9d55, 1);    popw(ax);                                 /* pop ax */
            ii(0x9d56, 2);    if(jmpw_abs(cx)) return;                  /* jmp cx */
        }
    }
}
