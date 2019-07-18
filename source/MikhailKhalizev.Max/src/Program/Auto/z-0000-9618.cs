using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f27c504a-f0e8-4064-987d-a334cedb41d0")]
        public void Method_0000_9618()
        {
            ii(0x9618, 1);    pushw(bp);                                /* push bp */
            ii(0x9619, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x961b, 2);    mov(dx, di);                              /* mov dx, di */
            ii(0x961d, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x961f, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x9621, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x9623, 3);    mov(si, memw_a16[ss, bp + 0x4]);          /* mov si, [bp+0x4] */
            ii(0x9626, 3);    mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x9629, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x962b, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x962e, 2);    repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x9630, 2);    not(cx);                                  /* not cx */
            ii(0x9632, 2);    sub(di, cx);                              /* sub di, cx */
            ii(0x9634, 2);    repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0x9636, 2);    if(jzw(0x963d, 0x5)) goto l_0x963d;       /* jz 0x963d */
            ii(0x9638, 2);    sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x963a, 3);    sbb(ax, 0xffff);                          /* sbb ax, 0xffff */
        l_0x963d:
            ii(0x963d, 2);    mov(si, bx);                              /* mov si, bx */
            ii(0x963f, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x9641, 1);    popw(bp);                                 /* pop bp */
            ii(0x9642, 1);    retw(); return;                           /* ret */
        }
    }
}
