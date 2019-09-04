using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_db2d-747d7594")]
        public void Method_0018_db2d()
        {
            ii(0x18_db2d, 2); push(edi);                                /* push edi */
            ii(0x18_db2f, 4); mov(edi, memd[ss, bp + 4]);               /* mov edi, [bp+0x4] */
            ii(0x18_db33, 2); push(esi);                                /* push esi */
            ii(0x18_db35, 4); shl(edi, 4);                              /* shl edi, 0x4 */
            ii(0x18_db39, 4); movzx(esi, bp);                           /* movzx esi, bp */
            ii(0x18_db3d, 3); add(di, memw[ss, bp + 8]);                /* add di, [bp+0x8] */
            ii(0x18_db40, 3); add(si, 0xa);                             /* add si, 0xa */
            ii(0x18_db43, 4); mov(es, memw[ds, 0xc2e]);                 /* mov es, [0xc2e] */
            ii(0x18_db47, 4); movsd_a32(ss);                            /* a32 ss movsd */
            ii(0x18_db4b, 2); pop(esi);                                 /* pop esi */
            ii(0x18_db4d, 2); pop(edi);                                 /* pop edi */
            ii(0x18_db4f, 1); pop(bp);                                  /* pop bp */
            ii(0x18_db50, 1); ret();                                    /* ret */
        }
    }
}
