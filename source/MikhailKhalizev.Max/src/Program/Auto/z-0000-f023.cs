using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c62f53ad-0470-40a7-bcef-1457d314d74e")]
        public void Method_0000_f023()
        {
            ii(0xf023, 1);    popw(cx);                                 /* pop cx */
            ii(0xf024, 1);    popw(cx);                                 /* pop cx */
            ii(0xf025, 3);    if(jmpw_func(0xe808, -0x820)) return;     /* jmp 0xe808 */
        }
    }
}
