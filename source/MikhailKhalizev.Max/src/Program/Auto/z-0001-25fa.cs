using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cd6a222f-1a2e-46f0-a5fb-623e570f7031")]
        public void Method_0001_25fa()
        {
            ii(0x1_25fa, 3);  mov(cx, 0x4);                             /* mov cx, 0x4 */
        l_0x1_25fd:
            ii(0x1_25fd, 2);  shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x1_25ff, 2);  rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x1_2601, 2);  if(loopw_a16(0x1_25fd, -0x6)) goto l_0x1_25fd; /* loop 0x25fd */
            ii(0x1_2603, 1);  retw(); return;                           /* ret */
        }
    }
}
