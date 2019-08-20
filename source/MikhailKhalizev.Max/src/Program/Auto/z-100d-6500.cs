using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6500-1b49a27d")]
        public void Method_100d_6500()
        {
            ii(0x100d_6500, 2); if(jmpd_func(0x100d_6541, 0x3f)) return; /* jmp 0x100d6541 */
            ii(0x100d_6502, 2); mov(eax, eax);                          /* mov eax, eax */
            ii(0x100d_6504, 3); if(jmpd_abs(memd_a32[ds, edx + 0xd])) return; /* jmp dword [edx+0xd] */
            ii(0x100d_6507, 2); adc(memb_a32[ds, esi], bh);             /* adc [esi], bh */
            ii(0x100d_6509, 6); arpl(memw_a32[ds, 0xd63_8010], cx);     /* arpl [0xd638010], cx */
            ii(0x100d_650f, 6); adc(memb_a32[ds, edi + 0x110_0d63], bh); /* adc [edi+0x1100d63], bh */
            ii(0x100d_6515, 6); or(eax, 0xd64_4310);                    /* or eax, 0xd644310 */
            ii(0x100d_651b, 6); adc(memb_a32[ds, edx - 0x3beff29c], al); /* adc [edx-0x3beff29c], al */
        }
    }
}
