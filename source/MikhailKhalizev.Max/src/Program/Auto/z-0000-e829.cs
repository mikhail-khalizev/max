using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c32be6d1-db8d-490d-996d-7aa38c776455")]
        public void Method_0000_e829()
        {
            ii(0xe829, 5);    mov(memb_a16[ds, 0xc45], 0);              /* mov byte [0xc45], 0x0 */
            ii(0xe82e, 3);    mov(ax, 0x4cfe);                          /* mov ax, 0x4cfe */
            ii(0xe831, 2);    @int(0x21);                               /* int 0x21 */
        }
    }
}
