using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7dd4-c6d094a5")]
        public void /* sys */ Method_1016_7dd4()
        {
            ii(0x1016_7dd4, 5); call(/* sys */ 0x1016_7dac, -0x2d);     /* call 0x10167dac */
            ii(0x1016_7dd9, 7); cmp(memd[ds, 0x101b_ddbc], 0);          /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7de0, 2); if(jz(0x1016_7de6, 4)) goto l_0x1016_7de6; /* jz 0x10167de6 */
            ii(0x1016_7de2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7de4, 2); if(jnz(0x1016_7de9, 3)) goto l_0x1016_7de9; /* jnz 0x10167de9 */
        l_0x1016_7de6:
            ii(0x1016_7de6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_7de8, 1); ret(); return;                          /* ret */
        l_0x1016_7de9:
            ii(0x1016_7de9, 3); mov(eax, memd[ds, eax + 44]);           /* mov eax, [eax+0x2c] */
            ii(0x1016_7dec, 1); ret();                                  /* ret */
        }
    }
}
