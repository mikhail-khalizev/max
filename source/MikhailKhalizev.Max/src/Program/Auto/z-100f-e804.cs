using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e804-526892de")]
        public void Method_100f_e804()
        {
            ii(0x100f_e804, 7); mov(memb[ds, 0x101c_391e], 0x9);        /* mov byte [0x101c391e], 0x9 */
            ii(0x100f_e80b, 5); if(jmp_func(0x100f_ea24, 0x214)) return; /* jmp 0x100fea24 */
        }
    }
}
