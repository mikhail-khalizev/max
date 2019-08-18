using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9cea081-9858-4469-bef9-a95c3e818519")]
        public void /* sys */ sys_int_10()
        {
            ii(0x1018_7ac2, 2); @int(0x10);                             /* int 0x10 */
            ii(0x1018_7ac4, 1); retd(); return;                         /* ret */
        }
    }
}
