using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb366-c3e0d572")]
        public void Method_0000_b366()
        {
            ii(0xb366, 2);    mov(cx, es);                              /* mov cx, es */
            ii(0xb368, 2);    if(jcxzw(0xb3a5, 0x3b)) goto l_0xb3a5;    /* jcxz 0xb3a5 */
            ii(0xb36a, 2);    mov(bx, cs);                              /* mov bx, cs */
            ii(0xb36c, 3);    and(bx, 0x7);                             /* and bx, 0x7 */
            ii(0xb36f, 3);    or(bx, 0x8);                              /* or bx, 0x8 */
            ii(0xb372, 2);    jmpw(0xb39d, 0x29); goto l_0xb39d;        /* jmp 0xb39d */
        l_0xb374:
            ii(0xb374, 3);    test(dl, 0x80);                           /* test dl, 0x80 */
            ii(0xb377, 4);    if(jnzw(0xb390, 0x15)) goto l_0xb390;     /* jnz 0xb390 */
            ii(0xb37b, 3);    lar(ax, bx);                              /* lar ax, bx */
            ii(0xb37e, 2);    jmpw(0xb380, 0); goto l_0xb380;           /* jmp 0xb380 */
        l_0xb380:
            ii(0xb380, 4);    if(jnzw(0xb390, 0xc)) goto l_0xb390;      /* jnz 0xb390 */
            ii(0xb384, 3);    test(ah, 0x93);                           /* test ah, 0x93 */
            ii(0xb387, 4);    if(jzw(0xb390, 0x5)) goto l_0xb390;       /* jz 0xb390 */
            ii(0xb38b, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0xb38e, 2);    @int(0x31);                               /* int 0x31 */
        l_0xb390:
            ii(0xb390, 2);    add(dl, dl);                              /* add dl, dl */
            ii(0xb392, 4);    add(bx, memw_a16[ds, 0xc48]);             /* add bx, [0xc48] */
            ii(0xb396, 4);    if(jow(0xb3a5, 0xb)) goto l_0xb3a5;       /* jo 0xb3a5 */
            ii(0xb39a, 2);    if(loopw_a16(0xb374, -0x28)) goto l_0xb374; /* loop 0xb374 */
            ii(0xb39c, 1);    inc(di);                                  /* inc di */
        l_0xb39d:
            ii(0xb39d, 3);    mov(dl, memb_a16[es, di]);                /* mov dl, [es:di] */
            ii(0xb3a0, 3);    mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0xb3a3, 2);    jmpw(0xb374, -0x31); goto l_0xb374;       /* jmp 0xb374 */
        l_0xb3a5:
            ii(0xb3a5, 1);    retfw();                                  /* retf */
        }
    }
}
