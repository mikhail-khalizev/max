using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_2dc0-aa7147fc")]
        public void Method_1012_2dc0()
        {
            ii(0x1012_2dc0, 2); if(jmpd_func(0x1012_2df9, 0x37)) return; /* jmp 0x10122df9 */
            ii(0x1012_2dc2, 2); mov(eax, eax);                          /* mov eax, eax */
            ii(0x1012_2dc4, 6); adc(ch, memb_a32[ds, 0x2d2c_1012]);     /* adc ch, [0x2d2c1012] */
            ii(0x1012_2dca, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
            ii(0x1012_2dcc, 1); inc(esi);                               /* inc esi */
            ii(0x1012_2dcd, 5); sub(eax, 0x2d60_1012);                  /* sub eax, 0x2d601012 */
            ii(0x1012_2dd2, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
            ii(0x1012_2dd4, 7); sub(memb_a32[ds, 0x2da1_1012], 0x12);   /* sub byte [0x2da11012], 0x12 */
        }
    }
}
