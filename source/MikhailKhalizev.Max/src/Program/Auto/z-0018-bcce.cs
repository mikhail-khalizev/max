using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a230774-53f6-46ec-8844-8053670d3ec6")]
        public void Method_0018_bcce()
        {
            ii(0x18_bcce, 1); pushw(bp);                                /* push bp */
            ii(0x18_bccf, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_bcd1, 3); mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x18_bcd4, 4); mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x18_bcd8, 3); cmp(memw_a16[ss, bp + 0x6], dx);          /* cmp [bp+0x6], dx */
            ii(0x18_bcdb, 2); if(jbw(0x18_bcfc, 0x1f)) goto l_0x18_bcfc; /* jb 0xbcfc */
            ii(0x18_bcdd, 2); if(jaw(0x18_bce4, 0x5)) goto l_0x18_bce4; /* ja 0xbce4 */
            ii(0x18_bcdf, 3); cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0x18_bce2, 2); if(jbw(0x18_bcfc, 0x18)) goto l_0x18_bcfc; /* jb 0xbcfc */
        l_0x18_bce4:
            ii(0x18_bce4, 3); mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0x18_bce7, 4); mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0x18_bceb, 3); cmp(memw_a16[ss, bp + 0x6], dx);          /* cmp [bp+0x6], dx */
            ii(0x18_bcee, 2); if(jaw(0x18_bcfc, 0xc)) goto l_0x18_bcfc; /* ja 0xbcfc */
            ii(0x18_bcf0, 2); if(jbw(0x18_bcf7, 0x5)) goto l_0x18_bcf7; /* jb 0xbcf7 */
            ii(0x18_bcf2, 3); cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0x18_bcf5, 2); if(jaw(0x18_bcfc, 0x5)) goto l_0x18_bcfc; /* ja 0xbcfc */
        l_0x18_bcf7:
            ii(0x18_bcf7, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x18_bcfa, 2); jmpw(0x18_bcfe, 0x2); goto l_0x18_bcfe;   /* jmp 0xbcfe */
        l_0x18_bcfc:
            ii(0x18_bcfc, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x18_bcfe:
            ii(0x18_bcfe, 1); leavew();                                 /* leave */
            ii(0x18_bcff, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
