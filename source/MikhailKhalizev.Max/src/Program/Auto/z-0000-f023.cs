using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fe16ce13-89c5-4996-875d-3a1f82e8ce9c")]
        public void Method_0000_f023()
        {
            ii(0xf023, 1);    popw(cx);                                 /* pop cx */
            ii(0xf024, 1);    popw(cx);                                 /* pop cx */
            ii(0xf025, 3);    if(jmpw_func(0xe808, -0x820)) return;     /* jmp 0xe808 */
        }
    }
}
