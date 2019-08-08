using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8a92c333-846c-4058-95e8-c9c56bc111ee")]
        public void Method_0000_529a()
        {
            ii(0x529a, 4);    enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x529e, 3);    mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x52a1, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x52a4, 3);    mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
            ii(0x52a7, 3);    mov(memb_a16[ss, bp - 0x3], al);          /* mov [bp-0x3], al */
            ii(0x52aa, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x52ad, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x52b0, 3);    mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x52b3, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x52b6, 3);    mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x52b9, 2);    mov(cl, 0xc);                             /* mov cl, 0xc */
            ii(0x52bb, 3);    callw(0x5da0, 0xae2);                     /* call 0x5da0 */
            ii(0x52be, 3);    mov(memb_a16[ss, bp - 0x4], al);          /* mov [bp-0x4], al */
            ii(0x52c1, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x52c4, 3);    sar(ax, 0x4);                             /* sar ax, 0x4 */
            ii(0x52c7, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x52c9, 2);    sub(al, al);                              /* sub al, al */
            ii(0x52cb, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x52ce, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x52d0, 3);    lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x52d3, 1);    pushw(ax);                                /* push ax */
            ii(0x52d4, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x52d7, 3);    shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x52da, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x52dc, 4);    add(ax, memw_a16[ds, 0x98e]);             /* add ax, [0x98e] */
            ii(0x52e0, 4);    adc(dx, memw_a16[ds, 0x990]);             /* adc dx, [0x990] */
            ii(0x52e4, 1);    pushw(dx);                                /* push dx */
            ii(0x52e5, 1);    pushw(ax);                                /* push ax */
            ii(0x52e6, 3);    callw(0x4812, -0xad7);                    /* call 0x4812 */
            ii(0x52e9, 1);    leavew();                                 /* leave */
            ii(0x52ea, 1);    retw(); return;                           /* ret */
        }
    }
}
