using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_40cc-a14651e8")]
        public void Method_0019_40cc()
        {
            ii(0x19_40cc, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_40ce, 3); lar(ax, cx);                              /* lar ax, cx */
            ii(0x19_40d1, 2); jmpw(0x19_40d3, 0); goto l_0x19_40d3;     /* jmp 0x40d3 */
        l_0x19_40d3:
            ii(0x19_40d3, 3); test(ah, 0x10);                           /* test ah, 0x10 */
            ii(0x19_40d6, 2); if(jnzw(0x19_40da, 0x2)) goto l_0x19_40da; /* jnz 0x40da */
            ii(0x19_40d8, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x19_40da:
            ii(0x19_40da, 1); retw();                                   /* ret */
        }
    }
}
