using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8fd08824-97df-4462-b9e8-9865a2ef0edc")]
        public void Method_0001_1354()
        {
            ii(0x1_1354, 1);  popw(ax);                                 /* pop ax */
            ii(0x1_1355, 1);  pushw(cs);                                /* push cs */
            ii(0x1_1356, 1);  pushw(ax);                                /* push ax */
            ii(0x1_1357, 5);  if(jmpw_far_abs(0x18, 0x2b47)) return;    /* jmp word 0x18:0x2b47 */
        }
    }
}
