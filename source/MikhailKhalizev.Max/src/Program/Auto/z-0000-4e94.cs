using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4e94-60168f9c")]
        public void Method_0000_4e94()
        {
            ii(0x4e94, 1);    push(bp);                                 /* push bp */
            ii(0x4e95, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4e97, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x4e9a, 3);    mov(ax, memw[ds, 0x11f8]);                /* mov ax, [0x11f8] */
            ii(0x4e9d, 3);    add(ax, 0x1190);                          /* add ax, 0x1190 */
            ii(0x4ea0, 1);    push(ax);                                 /* push ax */
            ii(0x4ea1, 3);    call(0x5bde, 0xd3a);                      /* call 0x5bde */
            ii(0x4ea4, 1);    pop(bx);                                  /* pop bx */
            ii(0x4ea5, 1);    pop(bx);                                  /* pop bx */
            ii(0x4ea6, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4ea8, 1);    pop(bp);                                  /* pop bp */
            ii(0x4ea9, 1);    ret();                                    /* ret */
        }
    }
}
