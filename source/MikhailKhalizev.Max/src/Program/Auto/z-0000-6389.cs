using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f06750a4-9afd-437d-9ffe-103ba51f10df")]
        public void Method_0000_6389()
        {
            ii(0x6389, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x638b, 1);    retw(); return;                           /* ret */
        }
    }
}
