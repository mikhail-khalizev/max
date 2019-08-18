using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6500-d0e57e9a")]
        public void Method_100d_6500()
        {
        l_0x100d_6500:
            ii(0x100d_6500, 2); if(jmpd_func(0x100d_6541, 0x3f)) return; /* jmp 0x100d6541 */
            ii(0x100d_6502, 2); mov(eax, eax);                          /* mov eax, eax */
            ii(0x100d_6504, 3); if(jmpd_abs(memd_a32[ds, edx + 0xd])) return; /* jmp dword [edx+0xd] */
            ii(0x100d_6507, 2); adc(memb_a32[ds, esi], bh);             /* adc [esi], bh */
            ii(0x100d_6509, 6); arpl(memw_a32[ds, 0xd63_8010], cx);     /* arpl [0xd638010], cx */
            ii(0x100d_650f, 6); adc(memb_a32[ds, edi + 0x110_0d63], bh); /* adc [edi+0x1100d63], bh */
            ii(0x100d_6515, 6); or(eax, 0xd64_4310);                    /* or eax, 0xd644310 */
            ii(0x100d_651b, 6); adc(memb_a32[ds, edx - 0x3beff29c], al); /* adc [edx-0x3beff29c], al */
            ii(0x100d_6521, 6); or(eax, 0xb845_8b10);                   /* or eax, 0xb8458b10 */
            ii(0x100d_6527, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100d_652a, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x7);     /* cmp word [ebp-0x6c], 0x7 */
            ii(0x100d_652f, 2); if(jad(0x100d_6500, -0x31)) goto l_0x100d_6500; /* ja 0x100d6500 */
            ii(0x100d_6531, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_6533, 4); mov(ax, memw_a32[ss, ebp - 0x6c]);      /* mov ax, [ebp-0x6c] */
            ii(0x100d_6537, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_653a, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100d_6504])) return; /* jmp dword [cs:eax+0x100d6504] */
        }
    }
}
