using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45e3336a-843d-41e4-aef5-4519dbc1c6d7")]
        public void Method_0000_5514()
        {
            ii(0x5514, 3);    mov(ax, 0x10ca);                          /* mov ax, 0x10ca */
            ii(0x5517, 3);    sub(ax, 0xb33);                           /* sub ax, 0xb33 */
            ii(0x551a, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x551d, 1);    retw(); return;                           /* ret */
        }
    }
}