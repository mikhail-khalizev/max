using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("df632ce9-f26a-45e4-983e-34dd89a81c50")]
        public void Method_0000_4f7a()
        {
            ii(0x4f7a, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x4f7c, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x4f7e, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0x4f80, 2);    pushw(0x18);                              /* push 0x18 */
            ii(0x4f82, 4);    callw_a16_far_ind(ds, 0x1e);              /* call far word [0x1e] */
            ii(0x4f86, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x4f89, 1);    retw(); return;                           /* ret */
        }
    }
}
