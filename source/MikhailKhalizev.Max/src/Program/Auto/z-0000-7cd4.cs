using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("790e6019-4160-4b75-9628-fb956ae3bc6c")]
        public void Method_0000_7cd4()
        {
            ii(0x7cd4, 3);    mov(ax, 0x10ca);                          /* mov ax, 0x10ca */
            ii(0x7cd7, 3);    sub(ax, 0xb33);                           /* sub ax, 0xb33 */
            ii(0x7cda, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x7cdd, 1);    retw(); return;                           /* ret */
        }
    }
}
