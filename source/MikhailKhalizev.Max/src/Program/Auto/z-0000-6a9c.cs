using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6a9c-bb02feb")]
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
        }
    }
}
