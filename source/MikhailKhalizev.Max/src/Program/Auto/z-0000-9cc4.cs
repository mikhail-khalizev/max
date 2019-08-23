using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9cc4-82aff1c0")]
        public void Method_0000_9cc4()
        {
            ii(0x9cc4, 1);    pushfw();                                 /* pushfw */
            ii(0x9cc5, 1);    popw(ax);                                 /* pop ax */
            ii(0x9cc6, 3);    and(ah, 0xcf);                            /* and ah, 0xcf */
            ii(0x9cc9, 1);    pushw(ax);                                /* push ax */
            ii(0x9cca, 1);    popfw();                                  /* popfw */
            ii(0x9ccb, 1);    pushfw();                                 /* pushfw */
            ii(0x9ccc, 1);    popw(ax);                                 /* pop ax */
            ii(0x9ccd, 3);    and(ax, 0x3000);                          /* and ax, 0x3000 */
            ii(0x9cd0, 1);    retw();                                   /* ret */
        }
    }
}
