using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9260900e-fa61-49d6-b780-cf205c6c0555")]
        public void Method_0000_fc9e()
        {
            ii(0xfc9e, 1);    pushw(bp);                                /* push bp */
            ii(0xfc9f, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xfca1, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0xfca4, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0xfca8, 3);    cmp(memw_a16[ss, bp + 0x6], dx);          /* cmp [bp+0x6], dx */
            ii(0xfcab, 2);    if(jbw(0xfccc, 0x1f)) goto l_0xfccc;      /* jb 0xfccc */
            ii(0xfcad, 2);    if(jaw(0xfcb4, 0x5)) goto l_0xfcb4;       /* ja 0xfcb4 */
            ii(0xfcaf, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0xfcb2, 2);    if(jbw(0xfccc, 0x18)) goto l_0xfccc;      /* jb 0xfccc */
        l_0xfcb4:
            ii(0xfcb4, 3);    mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0xfcb7, 4);    mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0xfcbb, 3);    cmp(memw_a16[ss, bp + 0x6], dx);          /* cmp [bp+0x6], dx */
            ii(0xfcbe, 2);    if(jaw(0xfccc, 0xc)) goto l_0xfccc;       /* ja 0xfccc */
            ii(0xfcc0, 2);    if(jbw(0xfcc7, 0x5)) goto l_0xfcc7;       /* jb 0xfcc7 */
            ii(0xfcc2, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0xfcc5, 2);    if(jaw(0xfccc, 0x5)) goto l_0xfccc;       /* ja 0xfccc */
        l_0xfcc7:
            ii(0xfcc7, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0xfcca, 2);    jmpw(0xfcce, 0x2); goto l_0xfcce;         /* jmp 0xfcce */
        l_0xfccc:
            ii(0xfccc, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0xfcce:
            ii(0xfcce, 1);    leavew();                                 /* leave */
            ii(0xfccf, 3);    retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
