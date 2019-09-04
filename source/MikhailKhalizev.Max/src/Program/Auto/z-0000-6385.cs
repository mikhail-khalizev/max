using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6385-1739b0b")]
        public void Method_0000_6385()
        {
            ii(0x6385, 3);  mov(ax, 0xffff);                           /* mov ax, 0xffff */
            ii(0x6388, 1);  ret();                                     /* ret */
        }
    }
}
