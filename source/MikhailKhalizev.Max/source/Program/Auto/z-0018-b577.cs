using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b577-92e46130")]
        public void Method_0018_b577()
        {
            ii(0x18_b577, 1);  pusha();                                /* pusha */
            ii(0x18_b578, 3);  mov(ax, memw[ds, 0xe]);                 /* mov ax, [0xe] */
            ii(0x18_b57b, 2);  cmp(cx, ax);                            /* cmp cx, ax */
            ii(0x18_b57d, 2);  if(jbe(0x18_b581, 2)) goto l_0x18_b581; /* jbe 0xb581 */
            ii(0x18_b57f, 2);  mov(cx, ax);                            /* mov cx, ax */
        l_0x18_b581:
            ii(0x18_b581, 2);  mov(di, si);                            /* mov di, si */
            ii(0x18_b583, 4);  mov(si, memw[ds, 0xa]);                 /* mov si, [0xa] */
            ii(0x18_b587, 1);  cld();                                  /* cld */
            ii(0x18_b588, 2);  rep(() => movsb());                     /* rep movsb */
            ii(0x18_b58a, 1);  popa();                                 /* popa */
            ii(0x18_b58b, 1);  ret();                                  /* ret */
        }
    }
}
