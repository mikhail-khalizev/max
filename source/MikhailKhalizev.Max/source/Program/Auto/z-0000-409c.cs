using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x409c-350be7bd")]
        public void Method_0000_409c()
        {
            ii(0x409c, 5);  pop(memw[cs, 0x2fa]);                      /* pop word [cs:0x2fa] */
            ii(0x40a1, 1);  cli();                                     /* cli */
            ii(0x40a2, 1);  pushfw();                                  /* pushfw */
            ii(0x40a3, 1);  pop(ax);                                   /* pop ax */
            ii(0x40a4, 3);  and(ah, 0xf);                              /* and ah, 0xf */
            ii(0x40a7, 1);  push(ax);                                  /* push ax */
            ii(0x40a8, 1);  push(cs);                                  /* push cs */
            ii(0x40a9, 3);  call(0x4f60, 0xeb4);                       /* call 0x4f60 */
            ii(0x40ac, 3);  call(0x49ad, 0x8fe);                       /* call 0x49ad */
            ii(0x40af, 4);  mov(memb[ds, 0x35], cl);                   /* mov [0x35], cl */
            ii(0x40b3, 3);  mov(ax, 0x334);                            /* mov ax, 0x334 */
            ii(0x40b6, 4);  call_abs(memw[ds, 0x9ba]);                 /* call word [0x9ba] */
            ii(0x40ba, 3);  smsw(ax);                                  /* smsw ax */
            ii(0x40bd, 2);  or(al, 1);                                 /* or al, 0x1 */
            ii(0x40bf, 6);  lgdt(memd[ds, 0x974]);                     /* o32 lgdt [0x974] */
            ii(0x40c5, 5);  lidt(memw[ds, 0x8d0]);                     /* lidt [0x8d0] */
            ii(0x40ca, 3);  lmsw(ax);                                  /* lmsw ax */
            ii(0x40cd, 5);  jmp_far_abs(0x18, 0x334);                  /* jmp word 0x18:0x334 */
        }
    }
}
