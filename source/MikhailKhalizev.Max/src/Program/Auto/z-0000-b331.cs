using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("339f3e50-7436-4b26-89e9-17e81d3cf893")]
        public void Method_0000_b331()
        {
            ii(0xb331, 2);    mov(dx, cs);                              /* mov dx, cs */
            ii(0xb333, 3);    and(dx, 0x7);                             /* and dx, 0x7 */
            ii(0xb336, 3);    or(dx, 0x8);                              /* or dx, 0x8 */
            ii(0xb339, 2);    jmpw(0xb35e, 0x23); goto l_0xb35e;        /* jmp 0xb35e */
        l_0xb33b:
            ii(0xb33b, 2);    add(bl, bl);                              /* add bl, bl */
            ii(0xb33d, 3);    lar(ax, dx);                              /* lar ax, dx */
            ii(0xb340, 2);    jmpw(0xb342, 0); goto l_0xb342;           /* jmp 0xb342 */
        l_0xb342:
            ii(0xb342, 4);    if(jnzw(0xb350, 0xa)) goto l_0xb350;      /* jnz 0xb350 */
            ii(0xb346, 3);    test(ah, 0x93);                           /* test ah, 0x93 */
            ii(0xb349, 4);    if(jzw(0xb350, 0x3)) goto l_0xb350;       /* jz 0xb350 */
            ii(0xb34d, 3);    or(bl, 0x1);                              /* or bl, 0x1 */
        l_0xb350:
            ii(0xb350, 4);    add(dx, memw_a16[ds, 0xc48]);             /* add dx, [0xc48] */
            ii(0xb354, 4);    if(jow(0xb365, 0xd)) goto l_0xb365;       /* jo 0xb365 */
            ii(0xb358, 2);    if(loopw_a16(0xb33b, -0x1f)) goto l_0xb33b; /* loop 0xb33b */
            ii(0xb35a, 3);    mov(memb_a16[es, di], bl);                /* mov [es:di], bl */
            ii(0xb35d, 1);    inc(di);                                  /* inc di */
        l_0xb35e:
            ii(0xb35e, 2);    xor(bl, bl);                              /* xor bl, bl */
            ii(0xb360, 3);    mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0xb363, 2);    jmpw(0xb33b, -0x2a); goto l_0xb33b;       /* jmp 0xb33b */
        l_0xb365:
            ii(0xb365, 1);    retfw(); return;                          /* retf */
        }
    }
}
