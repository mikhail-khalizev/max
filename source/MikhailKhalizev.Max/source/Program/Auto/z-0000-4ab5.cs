using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4ab5-c7b24c10")]
        public void Method_0000_4ab5()
        {
            ii(0x4ab5, 1);  cli();                                     /* cli */
            ii(0x4ab6, 3);  push(0x1026);                              /* push 0x1026 */
            ii(0x4ab9, 3);  call(0x5020, 0x564);                       /* call 0x5020 */
            ii(0x4abc, 1);  pop(cx);                                   /* pop cx */
            ii(0x4abd, 3);  push(0xf8a);                               /* push 0xf8a */
            ii(0x4ac0, 3);  call(0x5038, 0x575);                       /* call 0x5038 */
            ii(0x4ac3, 1);  pop(cx);                                   /* pop cx */
            ii(0x4ac4, 1);  sti();                                     /* sti */
            ii(0x4ac5, 1);  ret();                                     /* ret */
        }
    }
}
