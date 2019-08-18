using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("58e57b0d-8516-4104-89a7-ef4504f4f81b")]
        public void Method_0018_ac85()
        {
            ii(0x18_ac85, 4); mov(ax, memw_a16[ds, bx + 0xf6a]);        /* mov ax, [bx+0xf6a] */
            ii(0x18_ac89, 4); mov(si, memw_a16[ds, bx + 0xf6c]);        /* mov si, [bx+0xf6c] */
        }
    }
}
