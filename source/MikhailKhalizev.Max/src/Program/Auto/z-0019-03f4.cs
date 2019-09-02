using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_03f4-f9a7c7b2")]
        public void Method_0019_03f4()
        {
            ii(0x19_03f4, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x19_03f8, 5); movzx(eax, memw[ss, bp + 6]);             /* movzx eax, word [bp+0x6] */
            ii(0x19_03fd, 4); lar(eax, ax);                             /* lar eax, ax */
            ii(0x19_0401, 4); shr(eax, 0x16);                           /* shr eax, 0x16 */
            ii(0x19_0405, 3); and(ax, 1);                               /* and ax, 0x1 */
            ii(0x19_0408, 1); leave();                                  /* leave */
            ii(0x19_0409, 1); retf();                                   /* retf */
        }
    }
}
