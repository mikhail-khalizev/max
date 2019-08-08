using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1ef77fe1-6c07-4e39-a1a3-3cc36413822c")]
        public void Method_0000_9369()
        {
            ii(0x9369, 1);    pushw(bp);                                /* push bp */
            ii(0x936a, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x936c, 3);    sub(sp, 0xe);                             /* sub sp, 0xe */
            ii(0x936f, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x9372, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
        l_0x9375:
            ii(0x9375, 4);    mov(memb_a16[ss, bp - 0xd], 0x48);        /* mov byte [bp-0xd], 0x48 */
            ii(0x9379, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x937c, 1);    pushw(ax);                                /* push ax */
            ii(0x937d, 1);    pushw(ax);                                /* push ax */
            ii(0x937e, 3);    callw(0x5cc0, -0x36c1);                   /* call 0x5cc0 */
            ii(0x9381, 1);    popw(bx);                                 /* pop bx */
            ii(0x9382, 1);    popw(bx);                                 /* pop bx */
            ii(0x9383, 4);    cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x9387, 2);    if(jnzw(0x938e, 0x5)) goto l_0x938e;      /* jnz 0x938e */
            ii(0x9389, 3);    mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x938c, 2);    jmpw(0x939e, 0x10); goto l_0x939e;        /* jmp 0x939e */
        l_0x938e:
            ii(0x938e, 4);    cmp(memw_a16[ss, bp - 0xe], 0x8);         /* cmp word [bp-0xe], 0x8 */
            ii(0x9392, 2);    if(jnzw(0x939c, 0x8)) goto l_0x939c;      /* jnz 0x939c */
            ii(0x9394, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x9397, 3);    cmp(memw_a16[ss, bp - 0xc], ax);          /* cmp [bp-0xc], ax */
            ii(0x939a, 2);    if(jaew(0x9375, -0x27)) goto l_0x9375;    /* jae 0x9375 */
        l_0x939c:
            ii(0x939c, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0x939e:
            ii(0x939e, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x93a0, 1);    popw(bp);                                 /* pop bp */
            ii(0x93a1, 1);    retw(); return;                           /* ret */
        }
    }
}
