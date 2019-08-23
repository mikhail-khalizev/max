using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4eaa-6c389a8d")]
        public void Method_0000_4eaa()
        {
            ii(0x4eaa, 1);    push(bp);                                 /* push bp */
            ii(0x4eab, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4ead, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x4eb0, 1);    push(ax);                                 /* push ax */
            ii(0x4eb1, 3);    call(0x5c10, 0xd5c);                      /* call 0x5c10 */
            ii(0x4eb4, 1);    pop(bx);                                  /* pop bx */
            ii(0x4eb5, 4);    cmp(ax, memw[ds, 0x11f8]);                /* cmp ax, [0x11f8] */
            ii(0x4eb9, 2);    if(jnz(0x4ec2, 0x7)) goto l_0x4ec2;       /* jnz 0x4ec2 */
            ii(0x4ebb, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x4ebe, 3);    call(0x4e94, -0x2d);                      /* call 0x4e94 */
            ii(0x4ec1, 1);    pop(bx);                                  /* pop bx */
        l_0x4ec2:
            ii(0x4ec2, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4ec4, 1);    pop(bp);                                  /* pop bp */
            ii(0x4ec5, 1);    ret();                                    /* ret */
        }
    }
}
