using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e6abdcdd-c3fe-4d89-916f-9bde9f24b709")]
        public void Method_0000_6385()
        {
            ii(0x6385, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x6388, 1);    retw(); return;                           /* ret */
        }
    }
}
