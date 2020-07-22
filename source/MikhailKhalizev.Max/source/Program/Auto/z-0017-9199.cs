using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9199-8b69d")]
        public void Method_0017_9199()
        {
            ii(0x17_9199, 1);  push(ds);                               /* push ds */
            ii(0x17_919a, 1);  pop(ax);                                /* pop ax */
            ii(0x17_919b, 1);  retf();                                 /* retf */
        }
    }
}
