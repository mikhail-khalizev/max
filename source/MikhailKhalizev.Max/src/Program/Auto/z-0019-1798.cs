using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1798-59217c7b")]
        public void Method_0019_1798()
        {
            ii(0x19_1798, 1); push(bp);                                 /* push bp */
            ii(0x19_1799, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_179b, 4); cmp(memb[ss, bp + 4], 0xa);               /* cmp byte [bp+0x4], 0xa */
            ii(0x19_179f, 2); if(jnz(0x19_17a7, 6)) goto l_0x19_17a7;   /* jnz 0x17a7 */
            ii(0x19_17a1, 2); push(0xd);                                /* push 0xd */
            ii(0x19_17a3, 3); call(0x19_1798, -0xe);                    /* call 0x1798 */
            ii(0x19_17a6, 1); pop(bx);                                  /* pop bx */
        l_0x19_17a7:
            ii(0x19_17a7, 3); mov(al, memb[ss, bp + 4]);                /* mov al, [bp+0x4] */
            ii(0x19_17aa, 3); mov(memb[ds, 0x3a78], al);                /* mov [0x3a78], al */
            ii(0x19_17ad, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x19_17af, 3); mov(bx, 2);                               /* mov bx, 0x2 */
            ii(0x19_17b2, 3); mov(cx, 1);                               /* mov cx, 0x1 */
            ii(0x19_17b5, 3); mov(dx, 0x3a78);                          /* mov dx, 0x3a78 */
            ii(0x19_17b8, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_17ba, 1); leave();                                  /* leave */
            ii(0x19_17bb, 1); ret();                                    /* ret */
        }
    }
}
