using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2e9864a5-be53-4810-bfed-9f3d777f99b5")]
        public void Method_0000_9644()
        {
            ii(0x9644, 1);    pushw(bp);                                /* push bp */
            ii(0x9645, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9647, 1);    pushw(di);                                /* push di */
            ii(0x9648, 1);    pushw(si);                                /* push si */
            ii(0x9649, 1);    pushw(ds);                                /* push ds */
            ii(0x964a, 1);    popw(es);                                 /* pop es */
            ii(0x964b, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x964e, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x9651, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x9653, 3);    mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x9656, 2);    if(jcxzw(0x9664, 0xc)) goto l_0x9664;     /* jcxz 0x9664 */
        l_0x9658:
            ii(0x9658, 1);    lodsb_a16();                              /* lodsb */
            ii(0x9659, 2);    or(al, al);                               /* or al, al */
            ii(0x965b, 2);    if(jzw(0x9660, 0x3)) goto l_0x9660;       /* jz 0x9660 */
            ii(0x965d, 1);    stosb_a16();                              /* stosb */
            ii(0x965e, 2);    if(loopw_a16(0x9658, -0x8)) goto l_0x9658; /* loop 0x9658 */
        l_0x9660:
            ii(0x9660, 2);    xor(al, al);                              /* xor al, al */
            ii(0x9662, 2);    rep_a16(() => stosb_a16());               /* rep stosb */
        l_0x9664:
            ii(0x9664, 2);    mov(ax, bx);                              /* mov ax, bx */
            ii(0x9666, 1);    popw(si);                                 /* pop si */
            ii(0x9667, 1);    popw(di);                                 /* pop di */
            ii(0x9668, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x966a, 1);    popw(bp);                                 /* pop bp */
            ii(0x966b, 1);    retw(); return;                           /* ret */
        }
    }
}
