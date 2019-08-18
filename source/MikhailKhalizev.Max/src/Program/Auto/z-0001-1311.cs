using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1311-29341e7b")]
        public void Method_0001_1311()
        {
            ii(0x1_1311, 1);  popw(ax);                                 /* pop ax */
            ii(0x1_1312, 2);  pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x1_1314, 2);  if(jmpw_func(0x1_1303, -0x13)) return;    /* jmp 0x1303 */
        }
    }
}
