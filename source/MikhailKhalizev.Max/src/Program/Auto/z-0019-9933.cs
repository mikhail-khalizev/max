using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9933-862f0f0e")]
        public void Method_0019_9933()
        {
            ii(0x19_9933, 1); cwd();                                    /* cwd */
            ii(0x19_9934, 4); mov(di, memw_a16[ds, 0x19da]);            /* mov di, [0x19da] */
            ii(0x19_9938, 2); mov(ss, di);                              /* mov ss, di */
            ii(0x19_993a, 4); mov(sp, memw_a16[ds, 0x19dc]);            /* mov sp, [0x19dc] */
            ii(0x19_993e, 4); mov(bp, memw_a16[ds, 0x19de]);            /* mov bp, [0x19de] */
            ii(0x19_9942, 1); popw(ds);                                 /* pop ds */
            ii(0x19_9943, 1); popw(di);                                 /* pop di */
            ii(0x19_9944, 1); leavew();                                 /* leave */
            ii(0x19_9945, 1); retfw(); return;                          /* retf */
        }
    }
}
