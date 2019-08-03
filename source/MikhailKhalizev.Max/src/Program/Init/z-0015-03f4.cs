using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26ec76be-e11f-4b06-9acf-3beaa3311549")]
        public void Method_0015_03f4()
        {
            ii(0x15_03f4, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_03f8, 5); movzx(eax, memw_a16[ss, bp + 0x6]);       /* movzx eax, word [bp+0x6] */
            ii(0x15_03fd, 4); lar(eax, ax);                             /* lar eax, ax */
            ii(0x15_0401, 4); shr(eax, 0x16);                           /* shr eax, 0x16 */
            ii(0x15_0405, 3); and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x15_0408, 1); leavew();                                 /* leave */
            ii(0x15_0409, 1); retfw(); return;                          /* retf */
        }
    }
}
