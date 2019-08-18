using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5a4a-f8884ec1")]
        public void Method_0000_5a4a()
        {
            ii(0x5a4a, 4);    enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x5a4e, 3);    mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x5a51, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x5a54, 3);    mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
            ii(0x5a57, 3);    mov(memb_a16[ss, bp - 0x3], al);          /* mov [bp-0x3], al */
            ii(0x5a5a, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x5a5d, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x5a60, 3);    mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x5a63, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x5a66, 3);    mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x5a69, 2);    mov(cl, 0xc);                             /* mov cl, 0xc */
            ii(0x5a6b, 3);    callw(0x6550, 0xae2);                     /* call 0x6550 */
            ii(0x5a6e, 3);    mov(memb_a16[ss, bp - 0x4], al);          /* mov [bp-0x4], al */
            ii(0x5a71, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x5a74, 3);    sar(ax, 0x4);                             /* sar ax, 0x4 */
            ii(0x5a77, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x5a79, 2);    sub(al, al);                              /* sub al, al */
            ii(0x5a7b, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x5a7e, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x5a80, 3);    lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x5a83, 1);    pushw(ax);                                /* push ax */
            ii(0x5a84, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x5a87, 3);    shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x5a8a, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x5a8c, 4);    add(ax, memw_a16[ds, 0x98e]);             /* add ax, [0x98e] */
            ii(0x5a90, 4);    adc(dx, memw_a16[ds, 0x990]);             /* adc dx, [0x990] */
            ii(0x5a94, 1);    pushw(dx);                                /* push dx */
            ii(0x5a95, 1);    pushw(ax);                                /* push ax */
            ii(0x5a96, 3);    callw(0x4fc2, -0xad7);                    /* call 0x4fc2 */
            ii(0x5a99, 1);    leavew();                                 /* leave */
            ii(0x5a9a, 1);    retw(); return;                           /* ret */
        }
    }
}
