using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_ff2e-c8332488")]
        public void Method_100d_ff2e()
        {
            ii(0x100d_ff2e, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x100d_ff35, 2); if(jmpd_func(0x100d_ff75, 0x3e)) return; /* jmp 0x100dff75 */
            ii(0x100d_ff37, 1); nop();                                  /* nop */
            ii(0x100d_ff38, 3); cmp(esi, 0xd);                          /* cmp esi, 0xd */
            ii(0x100d_ff3b, 6); adc(memb_a32[ds, edx - 0x4beff202], bl); /* adc [edx-0x4beff202], bl */
            ii(0x100d_ff41, 6); dec(memb_a32[ds, 0xdff_2e10]);          /* dec byte [0xdff2e10] */
            ii(0x100d_ff47, 2); adc(dh, cl);                            /* adc dh, cl */
            ii(0x100d_ff49, 6); dec(memb_a32[ds, 0xdfe_e810]);          /* dec byte [0xdfee810] */
            ii(0x100d_ff4f, 2); adc(memb_a32[ds, edx], al);             /* adc [edx], al */
            ii(0x100d_ff51, 6); dec(memd_a32[ds, 0xdff_1910]);          /* dec dword [0xdff1910] */
        }
    }
}
