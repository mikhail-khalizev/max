using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_db07-bbb4ada1")]
        public void Method_0018_db07()
        {
            ii(0x18_db07, 2); push(ebx);                                /* push ebx */
            ii(0x18_db09, 4); mov(ebx, memd[ss, bp + 0x4]);             /* mov ebx, [bp+0x4] */
            ii(0x18_db0d, 2); push(esi);                                /* push esi */
            ii(0x18_db0f, 4); shl(ebx, 0x4);                            /* shl ebx, 0x4 */
            ii(0x18_db13, 5); movzx(esi, memw[ss, bp + 0x8]);           /* movzx esi, word [bp+0x8] */
            ii(0x18_db18, 4); mov(es, memw[ds, 0xc2e]);                 /* mov es, [0xc2e] */
            ii(0x18_db1c, 5); mov(ax, memw_a32[es, ebx + esi]);         /* mov ax, [es:ebx+esi] */
            ii(0x18_db21, 6); mov(dx, memw_a32[es, ebx + esi + 0x2]);   /* mov dx, [es:ebx+esi+0x2] */
            ii(0x18_db27, 2); pop(esi);                                 /* pop esi */
            ii(0x18_db29, 2); pop(ebx);                                 /* pop ebx */
            ii(0x18_db2b, 1); pop(bp);                                  /* pop bp */
            ii(0x18_db2c, 1); ret();                                    /* ret */
        }
    }
}
