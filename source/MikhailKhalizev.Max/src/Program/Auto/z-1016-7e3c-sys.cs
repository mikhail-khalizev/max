using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cb46ce7e-b502-4c6f-89c6-6944d895b438")]
        public void /* sys */ Method_1016_7e3c()
        {
            ii(0x1016_7e3c, 5); calld(/* sys */ 0x1016_7dac, -0x95);    /* call 0x10167dac */
            ii(0x1016_7e41, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7e48, 2); if(jzd(0x1016_7e4e, 0x4)) goto l_0x1016_7e4e; /* jz 0x10167e4e */
            ii(0x1016_7e4a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7e4c, 2); if(jnzd(0x1016_7e54, 0x6)) goto l_0x1016_7e54; /* jnz 0x10167e54 */
        l_0x1016_7e4e:
            ii(0x1016_7e4e, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_7e53, 1); retd(); return;                         /* ret */
        l_0x1016_7e54:
            ii(0x1016_7e54, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1016_7e57, 1); retd(); return;                         /* ret */
        }
    }
}
