using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("72f38b3e-24ef-464f-9cc3-564ad9400c14")]
        public void Method_0016_0faf()
        {
            ii(0x16_0faf, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x16_0fb3, 1); pushw(es);                                /* push es */
            ii(0x16_0fb4, 1); pushw(di);                                /* push di */
            ii(0x16_0fb5, 1); pushw(cx);                                /* push cx */
            ii(0x16_0fb6, 1); cld();                                    /* cld */
            ii(0x16_0fb7, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x16_0fba, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x16_0fbd, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x16_0fc0, 2); rep_a16(() => stosb_a16());               /* rep stosb */
            ii(0x16_0fc2, 1); nop();                                    /* nop */
            ii(0x16_0fc3, 1); popw(cx);                                 /* pop cx */
            ii(0x16_0fc4, 1); popw(di);                                 /* pop di */
            ii(0x16_0fc5, 1); popw(es);                                 /* pop es */
            ii(0x16_0fc6, 1); leavew();                                 /* leave */
            ii(0x16_0fc7, 1); retfw(); return;                          /* retf */
        }
    }
}
