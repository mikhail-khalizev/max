using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1798-59217c7b")]
        public void Method_0019_1798()
        {
            ii(0x19_1798, 1); pushw(bp);                                /* push bp */
            ii(0x19_1799, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_179b, 4); cmp(memb_a16[ss, bp + 0x4], 0xa);         /* cmp byte [bp+0x4], 0xa */
            ii(0x19_179f, 2); if(jnzw(0x19_17a7, 0x6)) goto l_0x19_17a7; /* jnz 0x17a7 */
            ii(0x19_17a1, 2); pushw(0xd);                               /* push 0xd */
            ii(0x19_17a3, 3); callw(0x19_1798, -0xe);                   /* call 0x1798 */
            ii(0x19_17a6, 1); popw(bx);                                 /* pop bx */
        l_0x19_17a7:
            ii(0x19_17a7, 3); mov(al, memb_a16[ss, bp + 0x4]);          /* mov al, [bp+0x4] */
            ii(0x19_17aa, 3); mov(memb_a16[ds, 0x3a78], al);            /* mov [0x3a78], al */
            ii(0x19_17ad, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x19_17af, 3); mov(bx, 0x2);                             /* mov bx, 0x2 */
            ii(0x19_17b2, 3); mov(cx, 0x1);                             /* mov cx, 0x1 */
            ii(0x19_17b5, 3); mov(dx, 0x3a78);                          /* mov dx, 0x3a78 */
            ii(0x19_17b8, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_17ba, 1); leavew();                                 /* leave */
            ii(0x19_17bb, 1); retw(); return;                           /* ret */
        }
    }
}
