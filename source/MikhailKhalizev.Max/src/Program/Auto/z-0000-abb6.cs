using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xabb6-c3e0d572")]
        public void Method_0000_abb6()
        {
            ii(0xabb6, 2);    mov(cx, es);                              /* mov cx, es */
            ii(0xabb8, 2);    if(jcxz(0xabf5, 0x3b)) goto l_0xabf5;     /* jcxz 0xabf5 */
            ii(0xabba, 2);    mov(bx, cs);                              /* mov bx, cs */
            ii(0xabbc, 3);    and(bx, 0x7);                             /* and bx, 0x7 */
            ii(0xabbf, 3);    or(bx, 0x8);                              /* or bx, 0x8 */
            ii(0xabc2, 2);    jmp(0xabed, 0x29); goto l_0xabed;         /* jmp 0xabed */
        l_0xabc4:
            ii(0xabc4, 3);    test(dl, 0x80);                           /* test dl, 0x80 */
            ii(0xabc7, 4);    if(jnz(0xabe0, 0x15)) goto l_0xabe0;      /* jnz 0xabe0 */
            ii(0xabcb, 3);    lar(ax, bx);                              /* lar ax, bx */
            ii(0xabce, 2);    jmp(0xabd0, 0); goto l_0xabd0;            /* jmp 0xabd0 */
        l_0xabd0:
            ii(0xabd0, 4);    if(jnz(0xabe0, 0xc)) goto l_0xabe0;       /* jnz 0xabe0 */
            ii(0xabd4, 3);    test(ah, 0x93);                           /* test ah, 0x93 */
            ii(0xabd7, 4);    if(jz(0xabe0, 0x5)) goto l_0xabe0;        /* jz 0xabe0 */
            ii(0xabdb, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0xabde, 2);    @int(0x31);                               /* int 0x31 */
        l_0xabe0:
            ii(0xabe0, 2);    add(dl, dl);                              /* add dl, dl */
            ii(0xabe2, 4);    add(bx, memw[ds, 0xc48]);                 /* add bx, [0xc48] */
            ii(0xabe6, 4);    if(jo(0xabf5, 0xb)) goto l_0xabf5;        /* jo 0xabf5 */
            ii(0xabea, 2);    if(loop(0xabc4, -0x28)) goto l_0xabc4;    /* loop 0xabc4 */
            ii(0xabec, 1);    inc(di);                                  /* inc di */
        l_0xabed:
            ii(0xabed, 3);    mov(dl, memb[es, di]);                    /* mov dl, [es:di] */
            ii(0xabf0, 3);    mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0xabf3, 2);    jmp(0xabc4, -0x31); goto l_0xabc4;        /* jmp 0xabc4 */
        l_0xabf5:
            ii(0xabf5, 1);    retf();                                   /* retf */
        }
    }
}
