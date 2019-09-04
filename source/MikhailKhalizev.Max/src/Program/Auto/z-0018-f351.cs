using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f351-29341e7b")]
        public void Method_0018_f351()
        {
            ii(0x18_f351, 1);  pop(ax);                                /* pop ax */
            ii(0x18_f352, 2);  push(-1 /* 0xff */);                    /* push 0xffff */
            ii(0x18_f354, 2);  jmp_func(0x18_f343, -0x13);             /* jmp 0xf343 */
        }
    }
}
