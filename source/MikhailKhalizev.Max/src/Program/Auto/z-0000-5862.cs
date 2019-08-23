using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5862-d87a1d1d")]
        public void Method_0000_5862()
        {
            ii(0x5862, 1);    pushw(bp);                                /* push bp */
            ii(0x5863, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5865, 1);    pushw(di);                                /* push di */
            ii(0x5866, 1);    pushw(si);                                /* push si */
            ii(0x5867, 5);    cmp(memw_a16[ds, 0xed6], 0);              /* cmp word [0xed6], 0x0 */
            ii(0x586c, 2);    if(jzw(0x5895, 0x27)) goto l_0x5895;      /* jz 0x5895 */
            ii(0x586e, 4);    les(bx, ds, 0xed4);                       /* les bx, [0xed4] */
            ii(0x5872, 4);    mov(si, memw_a16[es, bx + 0x2]);          /* mov si, [es:bx+0x2] */
            ii(0x5876, 2);    jmpw(0x5879, 0x1); goto l_0x5879;         /* jmp 0x5879 */
        l_0x5878:
            ii(0x5878, 1);    dec(si);                                  /* dec si */
        l_0x5879:
            ii(0x5879, 3);    cmp(si, 0x10);                            /* cmp si, 0x10 */
            ii(0x587c, 2);    if(jlw(0x5895, 0x17)) goto l_0x5895;      /* jl 0x5895 */
            ii(0x587e, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x5881, 2);    mov(di, si);                              /* mov di, si */
            ii(0x5883, 2);    shl(di, 0x1);                             /* shl di, 1 */
            ii(0x5885, 3);    cmp(memw_a16[es, bx + di], ax);           /* cmp [es:bx+di], ax */
            ii(0x5888, 2);    if(jnzw(0x5878, -0x12)) goto l_0x5878;    /* jnz 0x5878 */
            ii(0x588a, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x588c, 2);    mov(cl, 0x3);                             /* mov cl, 0x3 */
            ii(0x588e, 2);    shl(ax, cl);                              /* shl ax, cl */
            ii(0x5890, 3);    add(ax, memw_a16[es, bx]);                /* add ax, [es:bx] */
            ii(0x5893, 2);    jmpw(0x5897, 0x2); goto l_0x5897;         /* jmp 0x5897 */
        l_0x5895:
            ii(0x5895, 2);    sub(ax, ax);                              /* sub ax, ax */
        l_0x5897:
            ii(0x5897, 1);    popw(si);                                 /* pop si */
            ii(0x5898, 1);    popw(di);                                 /* pop di */
            ii(0x5899, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x589b, 1);    popw(bp);                                 /* pop bp */
            ii(0x589c, 1);    retw();                                   /* ret */
        }
    }
}
