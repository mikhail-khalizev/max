using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a94c1283-9dcd-4976-9cd8-97a6bb24fe4e")]
        public void Method_1012_5bcc()
        {
            ii(0x1012_5bcc, 5); calld(0x1014_82f4, 0x2_2723);           /* call 0x101482f4 */
            ii(0x1012_5bd1, 5); mov(memd_a32[ds, 0x101c_61a0], eax);    /* mov [0x101c61a0], eax */
            ii(0x1012_5bd6, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        }
    }
}
