using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5451-6999a263")]
        public void Method_0019_5451()
        {
            ii(0x19_5451, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_5455, 1); push(di);                                 /* push di */
            ii(0x19_5456, 1); push(si);                                 /* push si */
            ii(0x19_5457, 1); push(ds);                                 /* push ds */
            ii(0x19_5458, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_545b, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_545d, 1); push(ds);                                 /* push ds */
            ii(0x19_545e, 3); push(0x40ac);                             /* push 0x40ac */
            ii(0x19_5461, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_5464, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_5467, 3); call(0x18_ff6c, -0x54fe);                 /* call 0xff6c */
            ii(0x19_546a, 1); push(ds);                                 /* push ds */
            ii(0x19_546b, 3); push(0x40ac);                             /* push 0x40ac */
            ii(0x19_546e, 5); call_far_abs(0x80, 0x3e14);               /* call word 0x80:0x3e14 */
            ii(0x19_5473, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5476, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_5479, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_547c, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_547e, 2); if(jnz(0x19_5483, 0x3)) goto l_0x19_5483; /* jnz 0x5483 */
            ii(0x19_5480, 3); jmp(0x19_548f, 0xc); goto l_0x19_548f;    /* jmp 0x548f */
        l_0x19_5483:
            ii(0x19_5483, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x19_5486, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x19_5489, 3); jmp(0x19_5498, 0xc); goto l_0x19_5498;    /* jmp 0x5498 */
        //  ii(0x19_548c, 3); jmp(0x19_5498, 0x9); goto l_0x19_5498;    /* jmp 0x5498 */
        l_0x19_548f:
            ii(0x19_548f, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_5492, 3); mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x19_5495, 3); jmp(0x19_5498, 0); goto l_0x19_5498;      /* jmp 0x5498 */
        l_0x19_5498:
            ii(0x19_5498, 1); pop(ds);                                  /* pop ds */
            ii(0x19_5499, 1); pop(si);                                  /* pop si */
            ii(0x19_549a, 1); pop(di);                                  /* pop di */
            ii(0x19_549b, 1); leave();                                  /* leave */
            ii(0x19_549c, 1); retf();                                   /* retf */
        }
    }
}
