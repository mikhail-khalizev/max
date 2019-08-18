using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9966cff-4ca0-4018-9892-8278b502f09e")]
        public void /* sys */ Method_1016_7dac()
        {
            ii(0x1016_7dac, 1); pushd(edx);                             /* push edx */
            ii(0x1016_7dad, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_7db0, 2); if(jnzd(0x1016_7db6, 0x4)) goto l_0x1016_7db6; /* jnz 0x10167db6 */
            ii(0x1016_7db2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_7db4, 1); popd(edx);                              /* pop edx */
            ii(0x1016_7db5, 1); retd(); return;                         /* ret */
        l_0x1016_7db6:
            ii(0x1016_7db6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_7db9, 6); mov(edx, memd_a32[ds, eax + 0x101c_b134]); /* mov edx, [eax+0x101cb134] */
            ii(0x1016_7dbf, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1016_7dc2, 2); if(jnzd(0x1016_7dc8, 0x4)) goto l_0x1016_7dc8; /* jnz 0x10167dc8 */
            ii(0x1016_7dc4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_7dc6, 1); popd(edx);                              /* pop edx */
            ii(0x1016_7dc7, 1); retd(); return;                         /* ret */
        l_0x1016_7dc8:
            ii(0x1016_7dc8, 7); mov(eax, memd_a32[ds, edx * 4 + 0x101c_b1fc]); /* mov eax, [edx*4+0x101cb1fc] */
            ii(0x1016_7dcf, 1); popd(edx);                              /* pop edx */
            ii(0x1016_7dd0, 1); retd(); return;                         /* ret */
        }
    }
}
