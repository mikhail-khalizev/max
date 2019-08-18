using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4a8c-bb02feb")]
        public void Method_0000_4a8c()
        {
            ii(0x4a8c, 4);    mov(memw_a16[ds, 0x996], bp);             /* mov [0x996], bp */
            ii(0x4a90, 4);    mov(sp, memw_a16[ds, 0xf50]);             /* mov sp, [0xf50] */
            ii(0x4a94, 3);    callw(0x46cc, -0x3cb);                    /* call 0x46cc */
            ii(0x4a97, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x4a99, 3);    mov(bx, memw_a16[ss, bp + 0x18]);         /* mov bx, [bp+0x18] */
            ii(0x4a9c, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0x4a9e, 2);    if(jnzw(0x4aa3, 0x3)) goto l_0x4aa3;      /* jnz 0x4aa3 */
            ii(0x4aa0, 3);    xchg(memw_a16[ss, bp + 0x1c], bx);        /* xchg [bp+0x1c], bx */
        l_0x4aa3:
            ii(0x4aa3, 3);    mov(al, memb_a16[cs, bx]);                /* mov al, [cs:bx] */
            ii(0x4aa6, 3);    mov(memw_a16[ss, bp + 0x18], ax);         /* mov [bp+0x18], ax */
            ii(0x4aa9, 3);    if(jmpw_func(0x3ff1, -0xabb)) return;     /* jmp 0x3ff1 */
        }
    }
}
