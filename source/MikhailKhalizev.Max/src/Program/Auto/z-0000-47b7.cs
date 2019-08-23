using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x47b7-612e4b50")]
        public void Method_0000_47b7()
        {
            ii(0x47b7, 3);    mov(al, memb[ds, 0xa17]);                 /* mov al, [0xa17] */
            ii(0x47ba, 2);    cmp(al, -0x1 /* 0xff */);                 /* cmp al, 0xff */
            ii(0x47bc, 2);    if(jz(0x47cc, 0xe)) goto l_0x47cc;        /* jz 0x47cc */
            ii(0x47be, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x47bf, 2);    mov(ah, 0xf);                             /* mov ah, 0xf */
            ii(0x47c1, 2);    @int(0x10);                               /* int 0x10 */
            ii(0x47c3, 2);    cmp(al, cl);                              /* cmp al, cl */
            ii(0x47c5, 2);    if(jz(0x47cc, 0x5)) goto l_0x47cc;        /* jz 0x47cc */
            ii(0x47c7, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x47c8, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x47ca, 2);    @int(0x10);                               /* int 0x10 */
        l_0x47cc:
            ii(0x47cc, 1);    ret();                                    /* ret */
        }
    }
}
