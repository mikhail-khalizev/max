using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_231b-fd073fd0")]
        public void Method_1016_231b()
        {
            ii(0x1016_231b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_231e, 4); cmp(memb_a32[ds, eax + 0x3e], 0);       /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1016_2322, 2); if(jnzd(0x1016_232c, 0x8)) goto l_0x1016_232c; /* jnz 0x1016232c */
            ii(0x1016_2324, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2327, 5); calld(0x1015_ccd1, -0x565b);            /* call 0x1015ccd1 */
        l_0x1016_232c:
            ii(0x1016_232c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_232f, 5); calld(0x1016_1499, -0xe9b);             /* call 0x10161499 */
            ii(0x1016_2334, 5); if(jmpd_func(0x1016_29a7, 0x66e)) return; /* jmp 0x101629a7 */
        }
    }
}
