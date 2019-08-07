using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("35a32e68-18d7-4d2c-bc3e-32f451a79cc5")]
        public void Method_0014_aae3()
        {
            ii(0x14_aae3, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x14_aae8, 2); jzw_func(0x14_aad5, -0x15);               /* jz 0xaad5 */
            ii(0x14_aaea, 1); pushw(es);                                /* push es */
            ii(0x14_aaeb, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x14_aaee, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x14_aaf0, 3); and(di, -0x8 /* 0xf8 */);                 /* and di, 0xfff8 */
            ii(0x14_aaf3, 4); mov(ax, memw_a16[es, di + 0x2]);          /* mov ax, [es:di+0x2] */
            ii(0x14_aaf7, 4); mov(cl, memb_a16[es, di + 0x4]);          /* mov cl, [es:di+0x4] */
            ii(0x14_aafb, 4); mov(ch, memb_a16[es, di + 0x7]);          /* mov ch, [es:di+0x7] */
            ii(0x14_aaff, 1); popw(es);                                 /* pop es */
        }
    }
}
