using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("22846bb4-68a4-4d9d-84a6-80a06fcb5d2e")]
        public void Method_0000_3dd2()
        {
            ii(0x3dd2, 1);    popw(cx);                                 /* pop cx */
            ii(0x3dd3, 1);    pushw(ss);                                /* push ss */
            ii(0x3dd4, 1);    popw(ds);                                 /* pop ds */
            ii(0x3dd5, 5);    cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x3dda, 2);    if(jzw(0x3e00, 0x24)) goto l_0x3e00;      /* jz 0x3e00 */
            ii(0x3ddc, 3);    callw(0x3e08, 0x29);                      /* call 0x3e08 */
            ii(0x3ddf, 5);    cmp(memb_a16[ds, 0x10ef], 0);             /* cmp byte [0x10ef], 0x0 */
            ii(0x3de4, 2);    if(jzw(0x3e00, 0x1a)) goto l_0x3e00;      /* jz 0x3e00 */
            ii(0x3de6, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x3de8, 4);    sub(al, memb_a16[ds, 0x37]);              /* sub al, [0x37] */
            ii(0x3dec, 2);    sbb(ah, ah);                              /* sbb ah, ah */
            ii(0x3dee, 3);    and(ah, 0x2);                             /* and ah, 0x2 */
            ii(0x3df1, 5);    cmp(memb_a16[ds, 0x2e], 0x2);             /* cmp byte [0x2e], 0x2 */
            ii(0x3df6, 2);    if(jzw(0x3e03, 0xb)) goto l_0x3e03;       /* jz 0x3e03 */
            ii(0x3df8, 3);    or(ah, 0xdd);                             /* or ah, 0xdd */
            ii(0x3dfb, 1);    cli();                                    /* cli */
            ii(0x3dfc, 3);    callw(0x4971, 0xb72);                     /* call 0x4971 */
            ii(0x3dff, 1);    sti();                                    /* sti */
        l_0x3e00:
            ii(0x3e00, 3);    callw(0x61d0, 0x23cd);                    /* call 0x61d0 */
        l_0x3e03:
            ii(0x3e03, 3);    callw(0x4963, 0xb5d);                     /* call 0x4963 */
            ii(0x3e06, 2);    jmpw(0x3e00, -0x8); goto l_0x3e00;        /* jmp 0x3e00 */
        }
    }
}
