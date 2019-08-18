using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("27203880-e721-4ea5-ae47-21d41e05f118")]
        public void Method_0018_b069()
        {
            ii(0x18_b069, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x18_b06b, 3); mov(ax, memw_a16[ds, bx + 0x10]);         /* mov ax, [bx+0x10] */
            ii(0x18_b06e, 3); mov(memw_a16[ss, bp + 0x10], ax);         /* mov [bp+0x10], ax */
            ii(0x18_b071, 3); mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0x18_b074, 3); mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x18_b077, 3); mov(memw_a16[ss, bp + 0x16], ax);         /* mov [bp+0x16], ax */
            ii(0x18_b07a, 4); test(memb_a16[ds, bx + 0x26], 0x1);       /* test byte [bx+0x26], 0x1 */
            ii(0x18_b07e, 2); if(jzw(0x18_b082, 0x2)) goto l_0x18_b082; /* jz 0xb082 */
            ii(0x18_b080, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x18_b082:
            ii(0x18_b082, 1); popw(bp);                                 /* pop bp */
            ii(0x18_b083, 1); retw(); return;                           /* ret */
        //  ii(0x18_b084, 43); Недостижимый (и не декодированный) код.
        //    ii(0x18_b0af, 1); pushw(bp);                                /* push bp */
        //    ii(0x18_b0b0, 2); mov(bp, sp);                              /* mov bp, sp */
        //    ii(0x18_b0b2, 3); mov(bp, memw_a16[ss, bp + 0x4]);          /* mov bp, [bp+0x4] */
        //    ii(0x18_b0b5, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
        //    ii(0x18_b0b9, 4); mov(memb_a16[ds, bx + 0x17], 0x49);       /* mov byte [bx+0x17], 0x49 */
        //    ii(0x18_b0bd, 3); callw(0x18_a893, -0x82d);                 /* call 0xa893 */
        //    ii(0x18_b0c0, 3); mov(al, memb_a16[ds, bx + 0x26]);         /* mov al, [bx+0x26] */
        //    ii(0x18_b0c3, 3); and(ax, 0x1);                             /* and ax, 0x1 */
        //    ii(0x18_b0c6, 1); popw(bp);                                 /* pop bp */
        //    ii(0x18_b0c7, 1); retw(); return;                           /* ret */
        }
    }
}
