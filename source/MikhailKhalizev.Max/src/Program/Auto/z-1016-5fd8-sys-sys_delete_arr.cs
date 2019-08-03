using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3d8ee6a3-fcb5-49c6-b77e-9c078ef55af3")]
        public void /* sys */ sys_delete_arr()
        {
            ii(0x1016_5fd8, 5); jmpd_func(Definitions.sys_delete, -0x79); return; /* jmp 0x10165f64 */
        }
    }
}
