using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("07131bde-73cc-4403-916e-3e850cd74134")]
        public void Method_0015_15d2()
        {
            ii(0x15_15d2, 1); pushw(bp);                                /* push bp */
            ii(0x15_15d3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_15d5, 5); test(memb_a16[ds, 0x36f7], 0x2);          /* test byte [0x36f7], 0x2 */
            ii(0x15_15da, 2); if(jzw(0x15_15e0, 0x4)) goto l_0x15_15e0; /* jz 0x15e0 */
            ii(0x15_15dc, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_15de, 1); leavew();                                 /* leave */
            ii(0x15_15df, 1); retfw(); return;                          /* retf */
        l_0x15_15e0:
            ii(0x15_15e0, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x15_15e3, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x15_15e6, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_15e9, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_15ec, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_15ef, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_15f2, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_15f5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_15f8, 4); callw_a16_far_ind(ds, 0x38bc);            /* call far word [0x38bc] */
            ii(0x15_15fc, 1); leavew();                                 /* leave */
            ii(0x15_15fd, 1); retfw(); return;                          /* retf */
        }
    }
}
