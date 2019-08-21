using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_5760-6f3ca496")]
        public void Method_1008_5760()
        {
            ii(0x1008_5760, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1008_5763, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x1008_5766, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x4);     /* cmp word [ebp-0x6c], 0x4 */
            ii(0x1008_576b, 2); if(jad_func(0x1008_5748, -0x25)) return; /* ja 0x10085748 */
            ii(0x1008_576d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_576f, 4); mov(ax, memw_a32[ss, ebp - 0x6c]);      /* mov ax, [ebp-0x6c] */
            ii(0x1008_5773, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_5776, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1008_574c])) return; /* jmp dword [cs:eax+0x1008574c] */
        }
    }
}
