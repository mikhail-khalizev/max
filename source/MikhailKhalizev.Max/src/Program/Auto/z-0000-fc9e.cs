using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfc9e-739e977d")]
        public void Method_0000_fc9e()
        {
            ii(0xfc9e, 1);    push(bp);                                 /* push bp */
            ii(0xfc9f, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xfca1, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0xfca4, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0xfca8, 3);    cmp(memw[ss, bp + 6], dx);                /* cmp [bp+0x6], dx */
            ii(0xfcab, 2);    if(jb(0xfccc, 0x1f)) goto l_0xfccc;       /* jb 0xfccc */
            ii(0xfcad, 2);    if(ja(0xfcb4, 5)) goto l_0xfcb4;          /* ja 0xfcb4 */
            ii(0xfcaf, 3);    cmp(memw[ss, bp + 4], ax);                /* cmp [bp+0x4], ax */
            ii(0xfcb2, 2);    if(jb(0xfccc, 0x18)) goto l_0xfccc;       /* jb 0xfccc */
        l_0xfcb4:
            ii(0xfcb4, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0xfcb7, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0xfcbb, 3);    cmp(memw[ss, bp + 6], dx);                /* cmp [bp+0x6], dx */
            ii(0xfcbe, 2);    if(ja(0xfccc, 0xc)) goto l_0xfccc;        /* ja 0xfccc */
            ii(0xfcc0, 2);    if(jb(0xfcc7, 5)) goto l_0xfcc7;          /* jb 0xfcc7 */
            ii(0xfcc2, 3);    cmp(memw[ss, bp + 4], ax);                /* cmp [bp+0x4], ax */
            ii(0xfcc5, 2);    if(ja(0xfccc, 5)) goto l_0xfccc;          /* ja 0xfccc */
        l_0xfcc7:
            ii(0xfcc7, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0xfcca, 2);    jmp(0xfcce, 2); goto l_0xfcce;            /* jmp 0xfcce */
        l_0xfccc:
            ii(0xfccc, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0xfcce:
            ii(0xfcce, 1);    leave();                                  /* leave */
            ii(0xfccf, 3);    ret(4);                                   /* ret 0x4 */
        }
    }
}
