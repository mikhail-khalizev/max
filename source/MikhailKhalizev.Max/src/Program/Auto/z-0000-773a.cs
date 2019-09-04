using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x773a-e586939b")]
        public void Method_0000_773a()
        {
            ii(0x773a, 2);  push(0x20);                                /* push 0x20 */
            ii(0x773c, 2);  push(0x20);                                /* push 0x20 */
            ii(0x773e, 2);  push(0x20);                                /* push 0x20 */
            ii(0x7740, 2);  push(0x18);                                /* push 0x18 */
            ii(0x7742, 4);  call_far_ind(memw[ds, 0x1e]);              /* call far word [0x1e] */
            ii(0x7746, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0x7749, 1);  ret();                                     /* ret */
        }
    }
}
