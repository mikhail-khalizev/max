using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d5335e8e-caae-4f67-916e-37c5afc1212d")]
        public void Method_0018_f351()
        {
            ii(0x18_f351, 1); popw(ax);                                 /* pop ax */
            ii(0x18_f352, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x18_f354, 2); if(jmpw_func(0x18_f343, -0x13)) return;   /* jmp 0xf343 */
        }
    }
}
