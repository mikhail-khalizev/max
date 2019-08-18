using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("da233a23-5f99-4314-a595-043642ff35bb")]
        public void Method_0000_9d82()
        {
            ii(0x9d82, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x9d84, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x9d87, 3);    mov(cx, memw_a16[ds, bx + 0x4]);          /* mov cx, [bx+0x4] */
            ii(0x9d8a, 4);    mov(bx, memw_a16[ds, 0xe70]);             /* mov bx, [0xe70] */
            ii(0x9d8e, 2);    mov(ah, 0x3f);                            /* mov ah, 0x3f */
            ii(0x9d90, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9d92, 2);    sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x9d94, 2);    or(ax, bx);                               /* or ax, bx */
            ii(0x9d96, 1);    retw(); return;                           /* ret */
        }
    }
}
