using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7823-4f455f4b")]
        public void /* sys */ Method_1018_7823()
        {
            ii(0x1018_7823, 3); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1018_7826, 3); fstp(memt[ss, esp]);                    /* fstp tword [esp] */
            ii(0x1018_7829, 4); fstp(memt[ss, esp + 0xc]);              /* fstp tword [esp+0xc] */
            ii(0x1018_782d, 5); call(/* sys */ 0x1018_7270, -0x5c2);    /* call 0x10187270 */
            ii(0x1018_7832, 3); add(esp, 0x2c);                         /* add esp, 0x2c */
            ii(0x1018_7835, 1); ret();                                  /* ret */
        }
    }
}
