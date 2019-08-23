using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfb24-8b931")]
        public void Method_0000_fb24()
        {
            ii(0xfb24, 1);    pop(ds);                                  /* pop ds */
            ii(0xfb25, 1);    pop(bp);                                  /* pop bp */
            ii(0xfb26, 1);    ret();                                    /* ret */
        }
    }
}
