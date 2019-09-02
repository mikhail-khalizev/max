using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xab81-90f9cfed")]
        public void Method_0000_ab81()
        {
            ii(0xab81, 2);    mov(dx, cs);                              /* mov dx, cs */
            ii(0xab83, 3);    and(dx, 7);                               /* and dx, 0x7 */
            ii(0xab86, 3);    or(dx, 8);                                /* or dx, 0x8 */
            ii(0xab89, 2);    jmp(0xabae, 0x23); goto l_0xabae;         /* jmp 0xabae */
        l_0xab8b:
            ii(0xab8b, 2);    add(bl, bl);                              /* add bl, bl */
            ii(0xab8d, 3);    lar(ax, dx);                              /* lar ax, dx */
            ii(0xab90, 2);    jmp(0xab92, 0); goto l_0xab92;            /* jmp 0xab92 */
        l_0xab92:
            ii(0xab92, 4);    if(jnz(0xaba0, 0xa)) goto l_0xaba0;       /* jnz 0xaba0 */
            ii(0xab96, 3);    test(ah, 0x93);                           /* test ah, 0x93 */
            ii(0xab99, 4);    if(jz(0xaba0, 3)) goto l_0xaba0;          /* jz 0xaba0 */
            ii(0xab9d, 3);    or(bl, 1);                                /* or bl, 0x1 */
        l_0xaba0:
            ii(0xaba0, 4);    add(dx, memw[ds, 0xc48]);                 /* add dx, [0xc48] */
            ii(0xaba4, 4);    if(jo(0xabb5, 0xd)) goto l_0xabb5;        /* jo 0xabb5 */
            ii(0xaba8, 2);    if(loop(0xab8b, -0x1f)) goto l_0xab8b;    /* loop 0xab8b */
            ii(0xabaa, 3);    mov(memb[es, di], bl);                    /* mov [es:di], bl */
            ii(0xabad, 1);    inc(di);                                  /* inc di */
        l_0xabae:
            ii(0xabae, 2);    xor(bl, bl);                              /* xor bl, bl */
            ii(0xabb0, 3);    mov(cx, 8);                               /* mov cx, 0x8 */
            ii(0xabb3, 2);    jmp(0xab8b, -0x2a); goto l_0xab8b;        /* jmp 0xab8b */
        l_0xabb5:
            ii(0xabb5, 1);    retf();                                   /* retf */
        }
    }
}
