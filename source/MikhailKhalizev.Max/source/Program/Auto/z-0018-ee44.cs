using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ee44-11ffb6e")]
        public void Method_0018_ee44()
        {
            ii(0x18_ee44, 1);  pop(ds);                                /* pop ds */
            ii(0x18_ee45, 1);  pop(dx);                                /* pop dx */
            ii(0x18_ee46, 1);  pop(ax);                                /* pop ax */
            ii(0x18_ee47, 1);  ret();                                  /* ret */
        }
    }
}
