using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_3321-29341e7b")]
        public void Method_0001_3321()
        {
            ii(0x1_3321, 1);  pop(ax);                                  /* pop ax */
            ii(0x1_3322, 2);  push(-0x1 /* 0xff */);                    /* push 0xffff */
            ii(0x1_3324, 2);  if(jmp_func(0x1_3313, -0x13)) return;     /* jmp 0x3313 */
        }
    }
}
