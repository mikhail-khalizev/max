using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_febc-1ef0752f")]
        public void Method_0019_febc()
        {
            ii(0x19_febc, 1);  push(bp);                               /* push bp */
            ii(0x19_febd, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_febf, 1);  push(ds);                               /* push ds */
            ii(0x19_fec0, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_fec3, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_fec5, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_fec8, 1);  nop();                                  /* nop */
            ii(0x19_fec9, 1);  push(cs);                               /* push cs */
            ii(0x19_feca, 3);  call(0x1a_10f7, 0x122a);                /* call 0x10f7 */
            ii(0x19_fecd, 1);  pop(ds);                                /* pop ds */
            ii(0x19_fece, 1);  leave();                                /* leave */
            ii(0x19_fecf, 3);  ret(2);                                 /* ret 0x2 */
        }
    }
}
