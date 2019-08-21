using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_2607-56d41bc8")]
        public void Method_1016_2607()
        {
            ii(0x1016_2607, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_260a, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1e);    /* cmp byte [eax+0x3e], 0x1e */
            ii(0x1016_260e, 2); if(jnzd(0x1016_2618, 0x8)) goto l_0x1016_2618; /* jnz 0x10162618 */
            ii(0x1016_2610, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2613, 5); calld(0x1015_f9ae, -0x2c6a);            /* call 0x1015f9ae */
        l_0x1016_2618:
            ii(0x1016_2618, 5); if(jmpd_func(0x1016_29a7, 0x38a)) return; /* jmp 0x101629a7 */
        }
    }
}
