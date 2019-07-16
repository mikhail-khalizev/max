using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("735ca6da-f794-4366-ab63-7854b8e1dbed")]
        public void Method_0000_919b()
        {
            ii(0x919b, 1);    pushw(bp);                                /* push bp */
            ii(0x919c, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x919e, 3);    sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x91a1, 2);    goto l_0x91bc;                            /* jmp 0x91bc */
        l_0x91a3:
            ii(0x91a3, 3);    mov(memw_a16[ss, bp - 0x2], bx);          /* mov [bp-0x2], bx */
            ii(0x91a6, 3);    inc(memw_a16[ss, bp + 0x4]);              /* inc word [bp+0x4] */
            ii(0x91a9, 3);    callw(0x90c6, -0xe6);                     /* call 0x90c6 */
            ii(0x91ac, 3);    mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x91af, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x91b1, 2);    mov(al, memb_a16[ds, bx]);                /* mov al, [bx] */
            ii(0x91b3, 1);    cbw();                                    /* cbw */
            ii(0x91b4, 2);    cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x91b6, 2);    if(jzw(0x91bc, 0x4)) goto l_0x91bc;       /* jz 0x91bc */
            ii(0x91b8, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x91ba, 2);    goto l_0x91c7;                            /* jmp 0x91c7 */
        l_0x91bc:
            ii(0x91bc, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x91bf, 3);    cmp(memb_a16[ds, bx], 0);                 /* cmp byte [bx], 0x0 */
            ii(0x91c2, 2);    if(jnzw(0x91a3, -0x21)) goto l_0x91a3;    /* jnz 0x91a3 */
            ii(0x91c4, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
        l_0x91c7:
            ii(0x91c7, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x91c9, 1);    popw(bp);                                 /* pop bp */
            ii(0x91ca, 1);    retw();                                   /* ret */
        }
    }
}
