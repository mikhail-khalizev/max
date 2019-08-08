using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e6fa5e6f-2459-41f9-ad5e-f8afeba2eaac")]
        public void Method_0000_6f77()
        {
            ii(0x6f77, 3);    mov(al, memb_a16[ds, 0xa17]);             /* mov al, [0xa17] */
            ii(0x6f7a, 2);    cmp(al, -0x1 /* 0xff */);                 /* cmp al, 0xff */
            ii(0x6f7c, 2);    if(jzw(0x6f8c, 0xe)) goto l_0x6f8c;       /* jz 0x47cc */
            ii(0x6f7e, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x6f7f, 2);    mov(ah, 0xf);                             /* mov ah, 0xf */
            ii(0x6f81, 2);    @int(0x10);                               /* int 0x10 */
            ii(0x6f83, 2);    cmp(al, cl);                              /* cmp al, cl */
            ii(0x6f85, 2);    if(jzw(0x6f8c, 0x5)) goto l_0x6f8c;       /* jz 0x47cc */
            ii(0x6f87, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x6f88, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x6f8a, 2);    @int(0x10);                               /* int 0x10 */
        l_0x6f8c:
            ii(0x6f8c, 1);    retw(); return;                           /* ret */
        }
    }
}
