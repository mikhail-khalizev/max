using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9af6d4d4-9a76-47a8-881b-8aea2c2fbad9")]
        public void Method_0001_3364()
        {
            ii(0x1_3364, 1);  popw(ax);                                 /* pop ax */
            ii(0x1_3365, 1);  pushw(cs);                                /* push cs */
            ii(0x1_3366, 1);  pushw(ax);                                /* push ax */
            ii(0x1_3367, 5);  if(jmpw_far_abs(0x18, 0x2b47)) return;    /* jmp word 0x18:0x2b47 */
        }
    }
}
