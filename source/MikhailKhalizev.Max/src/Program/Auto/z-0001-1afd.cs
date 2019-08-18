using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1afd-747d7594")]
        public void Method_0001_1afd()
        {
            ii(0x1_1afd, 2);  pushd(edi);                               /* push edi */
            ii(0x1_1aff, 4);  mov(edi, memd_a16[ss, bp + 0x4]);         /* mov edi, [bp+0x4] */
            ii(0x1_1b03, 2);  pushd(esi);                               /* push esi */
            ii(0x1_1b05, 4);  shl(edi, 0x4);                            /* shl edi, 0x4 */
            ii(0x1_1b09, 4);  movzx(esi, bp);                           /* movzx esi, bp */
            ii(0x1_1b0d, 3);  add(di, memw_a16[ss, bp + 0x8]);          /* add di, [bp+0x8] */
            ii(0x1_1b10, 3);  add(si, 0xa);                             /* add si, 0xa */
            ii(0x1_1b13, 4);  mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0x1_1b17, 4);  movsd_a32(ss);                            /* a32 ss movsd */
            ii(0x1_1b1b, 2);  popd(esi);                                /* pop esi */
            ii(0x1_1b1d, 2);  popd(edi);                                /* pop edi */
            ii(0x1_1b1f, 1);  popw(bp);                                 /* pop bp */
            ii(0x1_1b20, 1);  retw(); return;                           /* ret */
        }
    }
}
