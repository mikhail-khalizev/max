using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fb063ea9-f4bc-4c90-8bfd-3b8b635d14e5")]
        public void Method_0001_0566()
        {
            ii(0x1_0566, 2);  sub(ax, ax);                              /* sub ax, ax */
            ii(0x1_0568, 2);  if(jmpw_func(0x1_05cd, 0x63)) return;     /* jmp 0x5cd */
        }
    }
}
