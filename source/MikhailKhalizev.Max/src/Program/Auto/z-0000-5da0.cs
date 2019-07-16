using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e857604f-dc37-407e-97b7-dc8a1838c07e")]
        public void Method_0000_5da0()
        {
            ii(0x5da0, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0x5da2, 2);    if(jcxzw(0x5daa, 0x6)) goto l_0x5daa;     /* jcxz 0x5daa */
        l_0x5da4:
            ii(0x5da4, 2);    sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x5da6, 2);    rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x5da8, 2);    if(loopw_a16(0x5da4, -0x6)) goto l_0x5da4; /* loop 0x5da4 */
        l_0x5daa:
            ii(0x5daa, 1);    retw();                                   /* ret */
        }
    }
}
