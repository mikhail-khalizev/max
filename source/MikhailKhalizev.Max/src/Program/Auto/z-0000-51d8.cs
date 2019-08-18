using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a580f11b-0d99-4e78-b2ce-097610acce85")]
        public void Method_0000_51d8()
        {
            ii(0x51d8, 3);    mov(ax, memw_a16[ds, 0xf88]);             /* mov ax, [0xf88] */
            ii(0x51db, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0x51dd, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x51e0, 1);    retw(); return;                           /* ret */
        }
    }
}
