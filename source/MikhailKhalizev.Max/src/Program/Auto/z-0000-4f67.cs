using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4f67-612e4b50")]
        public void Method_0000_4f67()
        {
            ii(0x4f67, 3);  mov(al, memb[ds, 0xa17]);                  /* mov al, [0xa17] */
            ii(0x4f6a, 2);  cmp(al, -1 /* 0xff */);                    /* cmp al, 0xff */
            ii(0x4f6c, 2);  if(jz(0x4f7c, 0xe)) goto l_0x4f7c;         /* jz 0x4f7c */
            ii(0x4f6e, 1);  xchg(cx, ax);                              /* xchg cx, ax */
            ii(0x4f6f, 2);  mov(ah, 0xf);                              /* mov ah, 0xf */
            ii(0x4f71, 2);  @int(0x10);                                /* int 0x10 */
            ii(0x4f73, 2);  cmp(al, cl);                               /* cmp al, cl */
            ii(0x4f75, 2);  if(jz(0x4f7c, 5)) goto l_0x4f7c;           /* jz 0x4f7c */
            ii(0x4f77, 1);  xchg(cx, ax);                              /* xchg cx, ax */
            ii(0x4f78, 2);  xor(ah, ah);                               /* xor ah, ah */
            ii(0x4f7a, 2);  @int(0x10);                                /* int 0x10 */
        l_0x4f7c:
            ii(0x4f7c, 1);  ret();                                     /* ret */
        }
    }
}
