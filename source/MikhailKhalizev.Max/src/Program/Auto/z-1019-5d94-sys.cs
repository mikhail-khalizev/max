using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9dff2799-a4b8-471f-af4b-0f423de15a71")]
        public void /* sys */ Method_1019_5d94()
        {
            ii(0x1019_5d94, 1); pushd(edx);                             /* push edx */
            ii(0x1019_5d95, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1019_5d98, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_5d9a, 2); if(jzd(0x1019_5da0, 0x4)) goto l_0x1019_5da0; /* jz 0x10195da0 */
            ii(0x1019_5d9c, 4); mov(memb_a32[ds, edx + 0x1c], 0x3);     /* mov byte [edx+0x1c], 0x3 */
        l_0x1019_5da0:
            ii(0x1019_5da0, 4); or(memb_a32[ds, eax + 0x4], 0x1);       /* or byte [eax+0x4], 0x1 */
            ii(0x1019_5da4, 5); calld(/* sys */ 0x1019_b4ec, 0x5743);   /* call 0x1019b4ec */
            ii(0x1019_5da9, 1); popd(edx);                              /* pop edx */
            ii(0x1019_5daa, 1); retd(); return;                         /* ret */
        }
    }
}
