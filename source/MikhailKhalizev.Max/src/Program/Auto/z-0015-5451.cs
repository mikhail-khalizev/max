using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("67c912e6-a080-45fa-a05c-9deb3808d46e")]
        public void Method_0015_5451()
        {
            ii(0x15_5451, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_5455, 1); pushw(di);                                /* push di */
            ii(0x15_5456, 1); pushw(si);                                /* push si */
            ii(0x15_5457, 1); pushw(ds);                                /* push ds */
            ii(0x15_5458, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_545b, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_545d, 1); pushw(ds);                                /* push ds */
            ii(0x15_545e, 3); pushw(0x40ac);                            /* push 0x40ac */
            ii(0x15_5461, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_5464, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_5467, 3); callw(0x14_ff6c, -0x54fe);                /* call 0xff6c */
            ii(0x15_546a, 1); pushw(ds);                                /* push ds */
            ii(0x15_546b, 3); pushw(0x40ac);                            /* push 0x40ac */
            ii(0x15_546e, 5); callw_far_abs(0x80, 0x3e14);              /* call word 0x80:0x3e14 */
            ii(0x15_5473, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_5476, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_5479, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_547c, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_547e, 2); if(jnzw(0x15_5483, 0x3)) goto l_0x15_5483; /* jnz 0x5483 */
            ii(0x15_5480, 3); jmpw(0x15_548f, 0xc); goto l_0x15_548f;   /* jmp 0x548f */
        l_0x15_5483:
            ii(0x15_5483, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_5486, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x15_5489, 3); jmpw(0x15_5498, 0xc); goto l_0x15_5498;   /* jmp 0x5498 */
        //  ii(0x15_548c, 3); Недостижимый код.
l_0x15_548f:
            ii(0x15_548f, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_5492, 3); mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x15_5495, 3); jmpw(0x15_5498, 0); goto l_0x15_5498;     /* jmp 0x5498 */
        l_0x15_5498:
            ii(0x15_5498, 1); popw(ds);                                 /* pop ds */
            ii(0x15_5499, 1); popw(si);                                 /* pop si */
            ii(0x15_549a, 1); popw(di);                                 /* pop di */
            ii(0x15_549b, 1); leavew();                                 /* leave */
            ii(0x15_549c, 1); retfw(); return;                          /* retf */
        }
    }
}
