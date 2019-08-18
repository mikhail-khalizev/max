using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x60ac-350be7bd")]
        public void Method_0000_60ac()
        {
            ii(0x60ac, 5);    popw(memw_a16[cs, 0x2fa]);                /* pop word [cs:0x2fa] */
            ii(0x60b1, 1);    cli();                                    /* cli */
            ii(0x60b2, 1);    pushfw();                                 /* pushfw */
            ii(0x60b3, 1);    popw(ax);                                 /* pop ax */
            ii(0x60b4, 3);    and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x60b7, 1);    pushw(ax);                                /* push ax */
            ii(0x60b8, 1);    pushw(cs);                                /* push cs */
            ii(0x60b9, 3);    callw(0x6f70, 0xeb4);                     /* call 0x6f70 */
            ii(0x60bc, 3);    callw(0x69bd, 0x8fe);                     /* call 0x69bd */
            ii(0x60bf, 4);    mov(memb_a16[ds, 0x35], cl);              /* mov [0x35], cl */
            ii(0x60c3, 3);    mov(ax, 0x334);                           /* mov ax, 0x334 */
            ii(0x60c6, 4);    callw_abs(memw_a16[ds, 0x9ba]);           /* call word [0x9ba] */
            ii(0x60ca, 3);    smsw(ax);                                 /* smsw ax */
            ii(0x60cd, 2);    or(al, 0x1);                              /* or al, 0x1 */
            ii(0x60cf, 6);    lgdtd_a16(ds, 0x974);                     /* o32 lgdt [0x974] */
            ii(0x60d5, 5);    lidtw_a16(ds, 0x8d0);                     /* lidt [0x8d0] */
            ii(0x60da, 3);    lmsw(ax);                                 /* lmsw ax */
            ii(0x60dd, 5);    if(jmpw_far_abs(0x18, 0x334)) return;     /* jmp word 0x18:0x334 */
        }
    }
}
