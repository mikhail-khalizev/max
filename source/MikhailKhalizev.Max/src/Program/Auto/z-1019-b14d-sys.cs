using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cfefaddd-f343-4c18-9397-21f49d00d1aa")]
        public void /* sys */ Method_1019_b14d()
        {
            ii(0x1019_b14d, 6); mov(ah, memb_a32[ds, 0x101c_1cf2]);     /* mov ah, [0x101c1cf2] */
            ii(0x1019_b153, 3); test(ah, 0x1);                          /* test ah, 0x1 */
            ii(0x1019_b156, 2); if(jzd(0x1019_b15d, 0x5)) goto l_0x1019_b15d; /* jz 0x1019b15d */
            ii(0x1019_b158, 3); test(ah, 0x2);                          /* test ah, 0x2 */
            ii(0x1019_b15b, 2); if(jnzd(0x1019_b164, 0x7)) goto l_0x1019_b164; /* jnz 0x1019b164 */
        l_0x1019_b15d:
            ii(0x1019_b15d, 7); or(memb_a32[ds, 0x101c_1cf2], 0x2);     /* or byte [0x101c1cf2], 0x2 */
        l_0x1019_b164:
            ii(0x1019_b164, 1); retd(); return;                         /* ret */
        }
    }
}