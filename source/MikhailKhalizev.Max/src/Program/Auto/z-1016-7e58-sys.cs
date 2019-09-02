using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7e58-fb553be5")]
        public void /* sys */ Method_1016_7e58()
        {
            ii(0x1016_7e58, 5); call(/* sys */ 0x1016_7dac, -0xb1);     /* call 0x10167dac */
            ii(0x1016_7e5d, 7); cmp(memd[ds, 0x101b_ddbc], 0);          /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7e64, 2); if(jz(0x1016_7e6a, 4)) goto l_0x1016_7e6a; /* jz 0x10167e6a */
            ii(0x1016_7e66, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7e68, 2); if(jnz(0x1016_7e70, 6)) goto l_0x1016_7e70; /* jnz 0x10167e70 */
        l_0x1016_7e6a:
            ii(0x1016_7e6a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_7e6f, 1); ret(); return;                          /* ret */
        l_0x1016_7e70:
            ii(0x1016_7e70, 3); mov(eax, memd[ds, eax + 28]);           /* mov eax, [eax+0x1c] */
            ii(0x1016_7e73, 1); ret();                                  /* ret */
        }
    }
}
