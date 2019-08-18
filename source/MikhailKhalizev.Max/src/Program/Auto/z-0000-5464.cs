using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5464-384fe75c")]
        public void Method_0000_5464()
        {
            ii(0x5464, 6);    test(memw_a16[ds, 0x1582], 0x1);          /* test word [0x1582], 0x1 */
            ii(0x546a, 2);    if(jzw(0x5479, 0xd)) goto l_0x5479;       /* jz 0x5479 */
            ii(0x546c, 3);    mov(ax, 0x1706);                          /* mov ax, 0x1706 */
            ii(0x546f, 3);    mov(memw_a16[ds, 0x9c0], ax);             /* mov [0x9c0], ax */
            ii(0x5472, 3);    mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x5475, 4);    callw_a16_far_ind(ds, 0x155c);            /* call far word [0x155c] */
        l_0x5479:
            ii(0x5479, 1);    retw(); return;                           /* ret */
        }
    }
}
