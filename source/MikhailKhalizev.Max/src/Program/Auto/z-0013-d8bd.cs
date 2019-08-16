using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4b945cd7-c541-49f8-a37d-a69e22627747")]
        public void Method_0013_d8bd()
        {
            ii(0x13_d8bd, 3); callw(0x13_d8ce, 0xe);                    /* call 0xd8ce */
            ii(0x13_d8c0, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x13_d8c3, 1); cwd();                                    /* cwd */
        }
    }
}
