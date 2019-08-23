using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x572a-e586939b")]
        public void Method_0000_572a()
        {
            ii(0x572a, 2);    push(0x20);                               /* push 0x20 */
            ii(0x572c, 2);    push(0x20);                               /* push 0x20 */
            ii(0x572e, 2);    push(0x20);                               /* push 0x20 */
            ii(0x5730, 2);    push(0x18);                               /* push 0x18 */
            ii(0x5732, 4);    call_far_ind(memw[ds, 0x1e]);             /* call far word [0x1e] */
            ii(0x5736, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x5739, 1);    ret();                                    /* ret */
        }
    }
}
