using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4f7a-e586939b")]
        public void Method_0000_4f7a()
        {
            ii(0x4f7a, 2);    push(0x20);                               /* push 0x20 */
            ii(0x4f7c, 2);    push(0x20);                               /* push 0x20 */
            ii(0x4f7e, 2);    push(0x20);                               /* push 0x20 */
            ii(0x4f80, 2);    push(0x18);                               /* push 0x18 */
            ii(0x4f82, 4);    call_far_ind(memw[ds, 0x1e]);             /* call far word [0x1e] */
            ii(0x4f86, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x4f89, 1);    ret();                                    /* ret */
        }
    }
}
