using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bede668c-85d6-4be0-ada3-391ab107151a")]
        public void /* sys */ Method_1016_7e58()
        {
            ii(0x1016_7e58, 5); calld(/* sys */ 0x1016_7dac, -0xb1);    /* call 0x10167dac */
            ii(0x1016_7e5d, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7e64, 2); if(jzd(0x1016_7e6a, 0x4)) goto l_0x1016_7e6a; /* jz 0x10167e6a */
            ii(0x1016_7e66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7e68, 2); if(jnzd(0x1016_7e70, 0x6)) goto l_0x1016_7e70; /* jnz 0x10167e70 */
        l_0x1016_7e6a:
            ii(0x1016_7e6a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_7e6f, 1); retd(); return;                         /* ret */
        l_0x1016_7e70:
            ii(0x1016_7e70, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1016_7e73, 1); retd(); return;                         /* ret */
        }
    }
}
