using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0c7baf79-f9eb-48ca-9f7e-626598a7b342")]
        public void Method_0000_95e7()
        {
            ii(0x95e7, 3);    mov(bx, 0xffff);                          /* mov bx, 0xffff */
            ii(0x95ea, 4);    xchg(memw_a16[ds, 0xe70], bx);            /* xchg [0xe70], bx */
            ii(0x95ee, 2);    mov(ah, 0x3e);                            /* mov ah, 0x3e */
            ii(0x95f0, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x95f2, 1);    retw(); return;                           /* ret */
        }
    }
}
