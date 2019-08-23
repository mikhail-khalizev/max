using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7a5a-f8884ec1")]
        public void Method_0000_7a5a()
        {
            ii(0x7a5a, 4);    enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x7a5e, 3);    mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x7a61, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x7a64, 3);    mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
            ii(0x7a67, 3);    mov(memb_a16[ss, bp - 0x3], al);          /* mov [bp-0x3], al */
            ii(0x7a6a, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x7a6d, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x7a70, 3);    mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x7a73, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x7a76, 3);    mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x7a79, 2);    mov(cl, 0xc);                             /* mov cl, 0xc */
            ii(0x7a7b, 3);    callw(0x8560, 0xae2);                     /* call 0x8560 */
            ii(0x7a7e, 3);    mov(memb_a16[ss, bp - 0x4], al);          /* mov [bp-0x4], al */
            ii(0x7a81, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x7a84, 3);    sar(ax, 0x4);                             /* sar ax, 0x4 */
            ii(0x7a87, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x7a89, 2);    sub(al, al);                              /* sub al, al */
            ii(0x7a8b, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x7a8e, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x7a90, 3);    lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x7a93, 1);    pushw(ax);                                /* push ax */
            ii(0x7a94, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x7a97, 3);    shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x7a9a, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x7a9c, 4);    add(ax, memw_a16[ds, 0x98e]);             /* add ax, [0x98e] */
            ii(0x7aa0, 4);    adc(dx, memw_a16[ds, 0x990]);             /* adc dx, [0x990] */
            ii(0x7aa4, 1);    pushw(dx);                                /* push dx */
            ii(0x7aa5, 1);    pushw(ax);                                /* push ax */
            ii(0x7aa6, 3);    callw(0x6fd2, -0xad7);                    /* call 0x6fd2 */
            ii(0x7aa9, 1);    leavew();                                 /* leave */
            ii(0x7aaa, 1);    retw();                                   /* ret */
        }
    }
}
