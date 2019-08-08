using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76333efd-7504-49ee-a76a-80fc99cacb85")]
        public void Method_0000_4ee1()
        {
            ii(0x4ee1, 1);    pushw(bp);                                /* push bp */
            ii(0x4ee2, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4ee4, 3);    sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x4ee7, 2);    jmpw(0x4ef6, 0xd); goto l_0x4ef6;         /* jmp 0x4ef6 */
        l_0x4ee9:
            ii(0x4ee9, 1);    pushw(ax);                                /* push ax */
            ii(0x4eea, 3);    callw(0x4ec6, -0x27);                     /* call 0x4ec6 */
            ii(0x4eed, 1);    popw(bx);                                 /* pop bx */
            ii(0x4eee, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x4ef1, 3);    inc(memw_a16[ss, bp + 0x4]);              /* inc word [bp+0x4] */
            ii(0x4ef4, 2);    mov(memb_a16[ds, bx], al);                /* mov [bx], al */
        l_0x4ef6:
            ii(0x4ef6, 3);    mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x4ef9, 3);    inc(memw_a16[ss, bp + 0x6]);              /* inc word [bp+0x6] */
            ii(0x4efc, 2);    mov(al, memb_a16[ds, bx]);                /* mov al, [bx] */
            ii(0x4efe, 1);    cbw();                                    /* cbw */
            ii(0x4eff, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x4f01, 2);    if(jnzw(0x4ee9, -0x1a)) goto l_0x4ee9;    /* jnz 0x4ee9 */
            ii(0x4f03, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x4f06, 3);    mov(memb_a16[ds, bx], 0);                 /* mov byte [bx], 0x0 */
            ii(0x4f09, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4f0b, 1);    popw(bp);                                 /* pop bp */
            ii(0x4f0c, 1);    retw(); return;                           /* ret */
        }
    }
}
