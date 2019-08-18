using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x95f1-9c933")]
        public void Method_0000_95f1()
        {
            ii(0x95f1, 1);    popw(bx);                                 /* pop bx */
            ii(0x95f2, 1);    popw(bx);                                 /* pop bx */
            ii(0x95f3, 1);    retw(); return;                           /* ret */
        }
    }
}
