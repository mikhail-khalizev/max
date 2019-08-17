using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6bca6215-63c3-4e39-9d21-4804d6de7916")]
        public void /* sys */ Method_1018_d5b5()
        {
            ii(0x1018_d5b5, 1); pushd(edx);                             /* push edx */
        l_0x1018_d5b6:
            ii(0x1018_d5b6, 6); mov(edx, memd_a32[ds, 0x1020_a1f4]);    /* mov edx, [0x1020a1f4] */
            ii(0x1018_d5bc, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_d5be, 2); if(jzd(0x1018_d5d1, 0x11)) goto l_0x1018_d5d1; /* jz 0x1018d5d1 */
            ii(0x1018_d5c0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_d5c2, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1018_d5c4, 5); calld(Definitions.sys_free, -0x2_2508); /* call 0x1016b0c1 */
            ii(0x1018_d5c9, 6); mov(memd_a32[ds, 0x1020_a1f4], edx);    /* mov [0x1020a1f4], edx */
            ii(0x1018_d5cf, 2); jmpd(0x1018_d5b6, -0x1b); goto l_0x1018_d5b6; /* jmp 0x1018d5b6 */
        l_0x1018_d5d1:
            ii(0x1018_d5d1, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d5d2, 1); retd(); return;                         /* ret */
        }
    }
}
