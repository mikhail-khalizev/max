using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a762-a089971f")]
        public void Method_100f_a762()
        {
            ii(0x100f_a762, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_a764, 5);  call(0x100f_448c, -0x62dd);           /* call 0x100f448c */
            ii(0x100f_a769, 5);  jmp_func(0x100f_a7df, 0x71);          /* jmp 0x100fa7df */
        }
    }
}
