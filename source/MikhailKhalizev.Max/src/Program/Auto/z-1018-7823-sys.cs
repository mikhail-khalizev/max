using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6f0092cc-09d5-4fa3-bfaa-4faa0bd98fd9")]
        public void /* sys */ Method_1018_7823()
        {
            ii(0x1018_7823, 3); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1018_7826, 3); fstp(memt_a32[ss, esp]);                /* fstp tword [esp] */
            ii(0x1018_7829, 4); fstp(memt_a32[ss, esp + 0xc]);          /* fstp tword [esp+0xc] */
            ii(0x1018_782d, 5); calld(/* sys */ 0x1018_7270, -0x5c2);   /* call 0x10187270 */
            ii(0x1018_7832, 3); add(esp, 0x2c);                         /* add esp, 0x2c */
            ii(0x1018_7835, 1); retd(); return;                         /* ret */
        }
    }
}
