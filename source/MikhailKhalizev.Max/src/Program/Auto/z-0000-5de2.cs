using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("36e6e117-a299-482a-8175-05df73113c54")]
        public void Method_0000_5de2()
        {
            ii(0x5de2, 1);    popw(cx);                                 /* pop cx */
            ii(0x5de3, 1);    pushw(ss);                                /* push ss */
            ii(0x5de4, 1);    popw(ds);                                 /* pop ds */
            ii(0x5de5, 5);    cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x5dea, 2);    if(jzw(0x5e10, 0x24)) goto l_0x5e10;      /* jz 0x3650 */
            ii(0x5dec, 3);    callw(0x5e18, 0x29);                      /* call 0x3658 */
            ii(0x5def, 5);    cmp(memb_a16[ds, 0x10ef], 0);             /* cmp byte [0x10ef], 0x0 */
            ii(0x5df4, 2);    if(jzw(0x5e10, 0x1a)) goto l_0x5e10;      /* jz 0x3650 */
            ii(0x5df6, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x5df8, 4);    sub(al, memb_a16[ds, 0x37]);              /* sub al, [0x37] */
            ii(0x5dfc, 2);    sbb(ah, ah);                              /* sbb ah, ah */
            ii(0x5dfe, 3);    and(ah, 0x2);                             /* and ah, 0x2 */
            ii(0x5e01, 5);    cmp(memb_a16[ds, 0x2e], 0x2);             /* cmp byte [0x2e], 0x2 */
            ii(0x5e06, 2);    if(jzw(0x5e13, 0xb)) goto l_0x5e13;       /* jz 0x3653 */
            ii(0x5e08, 3);    or(ah, 0xdd);                             /* or ah, 0xdd */
            ii(0x5e0b, 1);    cli();                                    /* cli */
            ii(0x5e0c, 3);    callw(0x6981, 0xb72);                     /* call 0x41c1 */
            ii(0x5e0f, 1);    sti();                                    /* sti */
        l_0x5e10:
            ii(0x5e10, 3);    callw(0x81e0, 0x23cd);                    /* call 0x5a20 */
        l_0x5e13:
            ii(0x5e13, 3);    callw(0x6973, 0xb5d);                     /* call 0x41b3 */
            ii(0x5e16, 2);    jmpw(0x5e10, -0x8); goto l_0x5e10;        /* jmp 0x3650 */
        }
    }
}
