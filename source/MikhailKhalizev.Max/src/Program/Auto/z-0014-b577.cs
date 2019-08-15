using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("24e7045f-a699-4a46-b635-0d75265e722b")]
        public void Method_0014_b577()
        {
            ii(0x14_b577, 1); pusha();                                  /* pusha */
            ii(0x14_b578, 3); mov(ax, memw_a16[ds, 0xe]);               /* mov ax, [0xe] */
            ii(0x14_b57b, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x14_b57d, 2); if(jbew(0x14_b581, 0x2)) goto l_0x14_b581; /* jbe 0xb581 */
            ii(0x14_b57f, 2); mov(cx, ax);                              /* mov cx, ax */
        l_0x14_b581:
            ii(0x14_b581, 2); mov(di, si);                              /* mov di, si */
            ii(0x14_b583, 4); mov(si, memw_a16[ds, 0xa]);               /* mov si, [0xa] */
            ii(0x14_b587, 1); cld();                                    /* cld */
            ii(0x14_b588, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x14_b58a, 1); popa();                                   /* popa */
            ii(0x14_b58b, 1); retw(); return;                           /* ret */
        }
    }
}
