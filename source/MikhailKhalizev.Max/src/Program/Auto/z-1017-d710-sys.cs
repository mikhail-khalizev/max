using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("72d25e0f-fd7e-48f7-a7a8-8da8ae36e10c")]
        public void /* sys */ Method_1017_d710()
        {
            ii(0x1017_d710, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_d711, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1017_d716, 2); jmpd_func(0x1017_d709, -0xf); return;   /* jmp 0x1017d709 */
        }
    }
}
