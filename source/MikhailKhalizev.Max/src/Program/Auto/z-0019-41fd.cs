using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_41fd-27ac6aba")]
        public void Method_0019_41fd()
        {
            ii(0x19_41fd, 1);  push(bp);                               /* push bp */
            ii(0x19_41fe, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_4200, 1);  push(bx);                               /* push bx */
            ii(0x19_4201, 1);  push(ds);                               /* push ds */
            ii(0x19_4202, 3);  lds(bx, memw[ss, bp + 10]);             /* lds bx, [bp+0xa] */
            ii(0x19_4205, 3);  mov(ax, memw[ss, bp + 14]);             /* mov ax, [bp+0xe] */
            ii(0x19_4208, 2);  mov(memw[ds, bx], ax);                  /* mov [bx], ax */
            ii(0x19_420a, 3);  mov(ax, memw[ss, bp + 16]);             /* mov ax, [bp+0x10] */
            ii(0x19_420d, 3);  mov(memw[ds, bx + 2], ax);              /* mov [bx+0x2], ax */
            ii(0x19_4210, 1);  push(ds);                               /* push ds */
            ii(0x19_4211, 1);  push(bx);                               /* push bx */
            ii(0x19_4212, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_4215, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_4218, 1);  nop();                                  /* nop */
            ii(0x19_4219, 1);  push(cs);                               /* push cs */
            ii(0x19_421a, 3);  call(0x19_41ac, -0x71);                 /* call 0x41ac */
            ii(0x19_421d, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_4220, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4221, 1);  pop(bx);                                /* pop bx */
            ii(0x19_4222, 1);  pop(bp);                                /* pop bp */
            ii(0x19_4223, 1);  retf();                                 /* retf */
        }
    }
}
