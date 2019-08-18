using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_ff58-aa15532b")]
        public void Method_100d_ff58()
        {
            ii(0x100d_ff58, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100d_ff5b, 2); dec(al);                                /* dec al */
            ii(0x100d_ff5d, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x100d_ff60, 4); cmp(memb_a32[ss, ebp - 0x24], 0x7);     /* cmp byte [ebp-0x24], 0x7 */
            ii(0x100d_ff64, 2); if(jad_func(0x100d_ff2e, -0x38)) return; /* ja 0x100dff2e */
            ii(0x100d_ff66, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_ff68, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100d_ff6b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_ff6e, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100d_ff38])) return; /* jmp dword [cs:eax+0x100dff38] */
        }
    }
}
