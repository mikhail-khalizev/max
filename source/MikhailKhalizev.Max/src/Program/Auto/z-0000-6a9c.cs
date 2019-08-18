using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("59bef4d0-8a7b-4630-b85e-a6b6054ab13f")]
        public void Method_0000_6a9c()
        {
            ii(0x6a9c, 4);    mov(memw_a16[ds, 0x996], bp);             /* mov [0x996], bp */
            ii(0x6aa0, 4);    mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
            ii(0x6aa4, 3);    callw(0x66dc, -0x3cb);                    /* call 0x66dc */
            ii(0x6aa7, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x6aa9, 3);    mov(bx, memw_a16[ss, bp + 0x18]);         /* mov bx, [bp+0x18] */
            ii(0x6aac, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0x6aae, 2);    if(jnzw(0x6ab3, 0x3)) goto l_0x6ab3;      /* jnz 0x6ab3 */
            ii(0x6ab0, 3);    xchg(memw_a16[ss, bp + 0x1c], bx);        /* xchg [bp+0x1c], bx */
        l_0x6ab3:
            ii(0x6ab3, 3);    mov(al, memb_a16[cs, bx]);                /* mov al, [cs:bx] */
            ii(0x6ab6, 3);    mov(memw_a16[ss, bp + 0x18], ax);         /* mov [bp+0x18], ax */
            ii(0x6ab9, 3);    if(jmpw_func(0x6001, -0xabb)) return;     /* jmp 0x6001 */
            ii(0x6abc, 1);    cli();                                    /* cli */
            ii(0x6abd, 3);    pushw(0x1026);                            /* push 0x1026 */
            ii(0x6ac0, 3);    callw(0x7048, 0x585);                     /* call 0x7048 */
            ii(0x6ac3, 1);    popw(cx);                                 /* pop cx */
            ii(0x6ac4, 1);    retw(); return;                           /* ret */
        }
    }
}
