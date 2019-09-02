using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9644-1b84bf75")]
        public void Method_0000_9644()
        {
            ii(0x9644, 1);    push(bp);                                 /* push bp */
            ii(0x9645, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9647, 1);    push(di);                                 /* push di */
            ii(0x9648, 1);    push(si);                                 /* push si */
            ii(0x9649, 1);    push(ds);                                 /* push ds */
            ii(0x964a, 1);    pop(es);                                  /* pop es */
            ii(0x964b, 3);    mov(di, memw[ss, bp + 4]);                /* mov di, [bp+0x4] */
            ii(0x964e, 3);    mov(si, memw[ss, bp + 6]);                /* mov si, [bp+0x6] */
            ii(0x9651, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x9653, 3);    mov(cx, memw[ss, bp + 8]);                /* mov cx, [bp+0x8] */
            ii(0x9656, 2);    if(jcxz(0x9664, 0xc)) goto l_0x9664;      /* jcxz 0x9664 */
        l_0x9658:
            ii(0x9658, 1);    lodsb();                                  /* lodsb */
            ii(0x9659, 2);    or(al, al);                               /* or al, al */
            ii(0x965b, 2);    if(jz(0x9660, 3)) goto l_0x9660;          /* jz 0x9660 */
            ii(0x965d, 1);    stosb();                                  /* stosb */
            ii(0x965e, 2);    if(loop(0x9658, -8)) goto l_0x9658;       /* loop 0x9658 */
        l_0x9660:
            ii(0x9660, 2);    xor(al, al);                              /* xor al, al */
            ii(0x9662, 2);    rep(() => stosb());                       /* rep stosb */
        l_0x9664:
            ii(0x9664, 2);    mov(ax, bx);                              /* mov ax, bx */
            ii(0x9666, 1);    pop(si);                                  /* pop si */
            ii(0x9667, 1);    pop(di);                                  /* pop di */
            ii(0x9668, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x966a, 1);    pop(bp);                                  /* pop bp */
            ii(0x966b, 1);    ret();                                    /* ret */
        }
    }
}
