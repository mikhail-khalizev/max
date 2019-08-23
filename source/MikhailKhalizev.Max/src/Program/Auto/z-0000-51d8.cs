using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x51d8-e6846d66")]
        public void Method_0000_51d8()
        {
            ii(0x51d8, 3);    mov(ax, memw[ds, 0xf88]);                 /* mov ax, [0xf88] */
            ii(0x51db, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0x51dd, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x51e0, 1);    ret();                                    /* ret */
        }
    }
}
