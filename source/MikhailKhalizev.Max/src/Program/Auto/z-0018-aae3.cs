using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a0567585-8761-4fa0-b767-85bb78891369")]
        public void Method_0018_aae3()
        {
            ii(0x18_aae3, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x18_aae8, 2); if(jzw_func(0x18_aad5, -0x15)) return;    /* jz 0xaad5 */
            ii(0x18_aaea, 1); pushw(es);                                /* push es */
            ii(0x18_aaeb, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x18_aaee, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x18_aaf0, 3); and(di, -0x8 /* 0xf8 */);                 /* and di, 0xfff8 */
            ii(0x18_aaf3, 4); mov(ax, memw_a16[es, di + 0x2]);          /* mov ax, [es:di+0x2] */
            ii(0x18_aaf7, 4); mov(cl, memb_a16[es, di + 0x4]);          /* mov cl, [es:di+0x4] */
            ii(0x18_aafb, 4); mov(ch, memb_a16[es, di + 0x7]);          /* mov ch, [es:di+0x7] */
            ii(0x18_aaff, 1); popw(es);                                 /* pop es */
        }
    }
}
