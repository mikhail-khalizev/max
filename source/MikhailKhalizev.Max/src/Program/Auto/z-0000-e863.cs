using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe863-8f2add4d")]
        public void Method_0000_e863()
        {
            ii(0xe863, 5);    cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0xe868, 2);    if(jzw_func(0xe833, -0x37)) return;       /* jz 0xe833 */
            ii(0xe86a, 1);    cli();                                    /* cli */
            ii(0xe86b, 1);    pusha();                                  /* pusha */
            ii(0xe86c, 5);    if(jmpw_far_abs(0x18, 0x1068)) return;    /* jmp word 0x18:0x1068 */
        }
    }
}
