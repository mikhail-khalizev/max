using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_cd9f-c3d2dd37")]
        public void Method_0019_cd9f()
        {
            ii(0x19_cd9f, 1);  push(bp);                               /* push bp */
            ii(0x19_cda0, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_cda2, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_cda5, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_cda8, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_cdab, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_cdae, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_cdb1, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_cdb4, 1);  push(ds);                               /* push ds */
            ii(0x19_cdb5, 3);  push(0x28bb);                           /* push 0x28bb */
            ii(0x19_cdb8, 3);  push(0x8fc);                            /* push 0x8fc */
            ii(0x19_cdbb, 5);  call_far_abs(0x80, 0x21d2);             /* call word 0x80:0x21d2 */
            ii(0x19_cdc0, 1);  leave();                                /* leave */
            ii(0x19_cdc1, 3);  ret(0xc);                               /* ret 0xc */
        }
    }
}
