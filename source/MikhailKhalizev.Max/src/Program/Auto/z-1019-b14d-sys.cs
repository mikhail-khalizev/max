using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b14d-7b2a3b63")]
        public void /* sys */ Method_1019_b14d()
        {
            ii(0x1019_b14d, 6);  mov(ah, memb[ds, 0x101c_1cf2]);       /* mov ah, [0x101c1cf2] */
            ii(0x1019_b153, 3);  test(ah, 1);                          /* test ah, 0x1 */
            ii(0x1019_b156, 2);  if(jz(0x1019_b15d, 5)) goto l_0x1019_b15d;/* jz 0x1019b15d */
            ii(0x1019_b158, 3);  test(ah, 2);                          /* test ah, 0x2 */
            ii(0x1019_b15b, 2);  if(jnz(0x1019_b164, 7)) goto l_0x1019_b164;/* jnz 0x1019b164 */
        l_0x1019_b15d:
            ii(0x1019_b15d, 7);  or(memb[ds, 0x101c_1cf2], 2);         /* or byte [0x101c1cf2], 0x2 */
        l_0x1019_b164:
            ii(0x1019_b164, 1);  ret();                                /* ret */
        }
    }
}
