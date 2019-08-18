using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_c621-2808ba7")]
        public void Method_1019_c621()
        {
            ii(0x1019_c621, 2); mov(al, 0xb);                           /* mov al, 0xb */
            ii(0x1019_c623, 2); if(jmpd_func(0x1019_c5dc, -0x49)) return; /* jmp 0x1019c5dc */
        }
    }
}
