using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_805c-2a049358")]
        public void Method_0017_805c()
        {
            ii(0x17_805c, 1);  push(bp);                               /* push bp */
            ii(0x17_805d, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_805f, 1);  push(ds);                               /* push ds */
            ii(0x17_8060, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_8063, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_8065, 2);  mov(ah, 0x34);                          /* mov ah, 0x34 */
            ii(0x17_8067, 2);  @int(0x21);                             /* int 0x21 */
            ii(0x17_8069, 1);  dec(bx);                                /* dec bx */
            ii(0x17_806a, 4);  mov(memw[ds, 0xa26], bx);               /* mov [0xa26], bx */
            ii(0x17_806e, 4);  mov(memw[ds, 0xa28], es);               /* mov [0xa28], es */
            ii(0x17_8072, 2);  push(0x20);                             /* push 0x20 */
            ii(0x17_8074, 4);  push(memw[ds, 0xa28]);                  /* push word [0xa28] */
            ii(0x17_8078, 4);  push(memw[ds, 0xa26]);                  /* push word [0xa26] */
            ii(0x17_807c, 1);  nop();                                  /* nop */
            ii(0x17_807d, 1);  push(cs);                               /* push cs */
            ii(0x17_807e, 3);  call(0x17_ea1e, 0x699d);                /* call 0xea1e */
            ii(0x17_8081, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_8084, 3);  mov(memw[ds, 0xa26], ax);               /* mov [0xa26], ax */
            ii(0x17_8087, 4);  mov(memw[ds, 0xa28], dx);               /* mov [0xa28], dx */
            ii(0x17_808b, 1);  pop(ds);                                /* pop ds */
            ii(0x17_808c, 1);  leave();                                /* leave */
            ii(0x17_808d, 1);  retf();                                 /* retf */
        }
    }
}
