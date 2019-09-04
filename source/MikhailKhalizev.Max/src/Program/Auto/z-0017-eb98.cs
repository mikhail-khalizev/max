using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_eb98-9efeb859")]
        public void Method_0017_eb98()
        {
            ii(0x17_eb98, 1);  push(bp);                               /* push bp */
            ii(0x17_eb99, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_eb9b, 1);  push(bx);                               /* push bx */
            ii(0x17_eb9c, 1);  push(ds);                               /* push ds */
            ii(0x17_eb9d, 3);  lds(bx, memw[ss, bp + 10]);             /* lds bx, [bp+0xa] */
            ii(0x17_eba0, 3);  mov(ax, memw[ss, bp + 14]);             /* mov ax, [bp+0xe] */
            ii(0x17_eba3, 2);  mov(memw[ds, bx], ax);                  /* mov [bx], ax */
            ii(0x17_eba5, 3);  mov(ax, memw[ss, bp + 16]);             /* mov ax, [bp+0x10] */
            ii(0x17_eba8, 3);  mov(memw[ds, bx + 2], ax);              /* mov [bx+0x2], ax */
            ii(0x17_ebab, 1);  push(ds);                               /* push ds */
            ii(0x17_ebac, 1);  push(bx);                               /* push bx */
            ii(0x17_ebad, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x17_ebb0, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x17_ebb3, 1);  nop();                                  /* nop */
            ii(0x17_ebb4, 1);  push(cs);                               /* push cs */
            ii(0x17_ebb5, 3);  call(0x17_eb64, -0x54);                 /* call 0xeb64 */
            ii(0x17_ebb8, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_ebbb, 1);  pop(ds);                                /* pop ds */
            ii(0x17_ebbc, 1);  pop(bx);                                /* pop bx */
            ii(0x17_ebbd, 1);  pop(bp);                                /* pop bp */
            ii(0x17_ebbe, 1);  retf();                                 /* retf */
        }
    }
}
