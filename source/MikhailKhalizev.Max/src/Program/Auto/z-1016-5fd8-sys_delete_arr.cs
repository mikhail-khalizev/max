using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5fd8-56566631")]
        public void /* sys */ sys_delete_arr()
        {
            ii(0x1016_5fd8, 5); if(jmp_func(Definitions.sys_delete, -0x79)) return; /* jmp 0x10165f64 */
        }
    }
}
