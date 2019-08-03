using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f0ae57b-8f7c-446f-b8a7-ac78b8a2b0fe")]
        public void /* sys */ Method_1016_7dd4()
        {
            ii(0x1016_7dd4, 5); calld(/* sys */ 0x1016_7dac, -0x2d);    /* call 0x10167dac */
            ii(0x1016_7dd9, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7de0, 2); if(jzd(0x1016_7de6, 0x4)) goto l_0x1016_7de6; /* jz 0x10167de6 */
            ii(0x1016_7de2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7de4, 2); if(jnzd(0x1016_7de9, 0x3)) goto l_0x1016_7de9; /* jnz 0x10167de9 */
        l_0x1016_7de6:
            ii(0x1016_7de6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_7de8, 1); retd(); return;                         /* ret */
        l_0x1016_7de9:
            ii(0x1016_7de9, 3); mov(eax, memd_a32[ds, eax + 0x2c]);     /* mov eax, [eax+0x2c] */
            ii(0x1016_7dec, 1); retd(); return;                         /* ret */
        }
    }
}
