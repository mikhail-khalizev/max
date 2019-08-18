using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a859-901bbb7f")]
        public void Method_0018_a859()
        {
            ii(0x18_a859, 5); mov(memb_a16[ds, 0xc45], 0);              /* mov byte [0xc45], 0x0 */
            ii(0x18_a85e, 3); mov(ax, 0x4cfe);                          /* mov ax, 0x4cfe */
            ii(0x18_a861, 2); @int(0x21);                               /* int 0x21 */
        }
    }
}
