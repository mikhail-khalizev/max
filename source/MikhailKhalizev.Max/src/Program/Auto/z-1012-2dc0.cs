using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("85120e64-38f3-49b6-b957-18c5bea4d085")]
        public void Method_1012_2dc0()
        {
        l_0x1012_2dc0:
            ii(0x1012_2dc0, 2); if(jmpd_func(0x1012_2df9, 0x37)) return; /* jmp 0x10122df9 */
            ii(0x1012_2dc2, 2); mov(eax, eax);                          /* mov eax, eax */
            ii(0x1012_2dc4, 6); adc(ch, memb_a32[ds, 0x2d2c_1012]);     /* adc ch, [0x2d2c1012] */
            ii(0x1012_2dca, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
            ii(0x1012_2dcc, 1); inc(esi);                               /* inc esi */
            ii(0x1012_2dcd, 5); sub(eax, 0x2d60_1012);                  /* sub eax, 0x2d601012 */
            ii(0x1012_2dd2, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
            ii(0x1012_2dd4, 7); sub(memb_a32[ds, 0x2da1_1012], 0x12);   /* sub byte [0x2da11012], 0x12 */
            ii(0x1012_2ddb, 6); adc(memb_a32[ds, edx + 0x362c_b445], cl); /* adc [edx+0x362cb445], cl */
            ii(0x1012_2de1, 3); mov(memb_a32[ss, ebp - 0x50], al);      /* mov [ebp-0x50], al */
            ii(0x1012_2de4, 4); cmp(memb_a32[ss, ebp - 0x50], 0x5);     /* cmp byte [ebp-0x50], 0x5 */
            ii(0x1012_2de8, 2); if(jad(0x1012_2dc0, -0x2a)) goto l_0x1012_2dc0; /* ja 0x10122dc0 */
            ii(0x1012_2dea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_2dec, 3); mov(al, memb_a32[ss, ebp - 0x50]);      /* mov al, [ebp-0x50] */
            ii(0x1012_2def, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_2df2, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1012_2dc4])) return; /* jmp dword [cs:eax+0x10122dc4] */
        }
    }
}
