using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9d4cf536-56fc-4447-b6e4-ddb6f85c4db8")]
        public void Method_0000_409c()
        {
            ii(0x409c, 5);    popw(memw_a16[cs, 0x2fa]);                /* pop word [cs:0x2fa] */
            ii(0x40a1, 1);    cli();                                    /* cli */
            ii(0x40a2, 1);    pushfw();                                 /* pushfw */
            ii(0x40a3, 1);    popw(ax);                                 /* pop ax */
            ii(0x40a4, 3);    and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x40a7, 1);    pushw(ax);                                /* push ax */
            ii(0x40a8, 1);    pushw(cs);                                /* push cs */
            ii(0x40a9, 3);    callw(0x4f60, 0xeb4);                     /* call 0x4f60 */
            ii(0x40ac, 3);    callw(0x49ad, 0x8fe);                     /* call 0x49ad */
            ii(0x40af, 4);    mov(memb_a16[ds, 0x35], cl);              /* mov [0x35], cl */
            ii(0x40b3, 3);    mov(ax, 0x334);                           /* mov ax, 0x334 */
            ii(0x40b6, 4);    callw_abs(memw_a16[ds, 0x9ba]);           /* call word [0x9ba] */
            ii(0x40ba, 3);    smsw(ax);                                 /* smsw ax */
            ii(0x40bd, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0x40bf, 6);    lgdtd_a16(ds, 0x974);                     /* o32 lgdt [0x974] */
            ii(0x40c5, 5);    lidtw_a16(ds, 0x8d0);                     /* lidt [0x8d0] */
            ii(0x40ca, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x40cd, 5);    if(jmpw_far_abs(0x18, 0x334)) return;     /* jmp word 0x18:0x334 */
        }
    }
}
