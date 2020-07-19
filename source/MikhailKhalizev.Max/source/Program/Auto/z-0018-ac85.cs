using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ac85-71ed5b66")]
        public void Method_0018_ac85()
        {
            ii(0x18_ac85, 4);  mov(ax, memw[ds, bx + 3946]);           /* mov ax, [bx+0xf6a] */
            ii(0x18_ac89, 4);  mov(si, memw[ds, bx + 3948]);           /* mov si, [bx+0xf6c] */
        }
    }
}
