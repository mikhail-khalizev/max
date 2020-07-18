using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3fe6-8abfc9d9")]
        public void Method_0000_3fe6()
        {
            ii(0x3fe6, 3);  call(0x4ab5, 0xacc);                       /* call 0x4ab5 */
            ii(0x3fe9, 4);  call_abs(memw[ds, 0x97a]);                 /* call word [0x97a] */
            ii(0x3fed, 3);  call(0x4aac, 0xabc);                       /* call 0x4aac */
            ii(0x3ff0, 1);  ret();                                     /* ret */
        }
    }
}
