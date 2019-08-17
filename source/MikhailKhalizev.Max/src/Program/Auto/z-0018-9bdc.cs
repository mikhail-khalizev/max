using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6749e19e-a480-4b60-9b47-833b6482b9f0")]
        public void Method_0018_9bdc()
        {
            ii(0x18_9bdc, 3); callw(0x18_9f20, 0x341);                  /* call 0x9f20 */
            ii(0x18_9bdf, 1); das();                                    /* das */
            ii(0x18_9be0, 3); callw(0x18_9f20, 0x33d);                  /* call 0x9f20 */
            ii(0x18_9be3, 2); xor(al, ch);                              /* xor al, ch */
            ii(0x18_9be5, 2); cmp(memw_a16[ss, bp + di], ax);           /* cmp [bp+di], ax */
            ii(0x18_9be7, 2); xor(ax, bp);                              /* xor ax, bp */
            ii(0x18_9be9, 3); xor(ax, 0x3203);                          /* xor ax, 0x3203 */
        }
    }
}
