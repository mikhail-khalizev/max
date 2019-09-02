using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1b37-3dbc1da9")]
        public void Method_0001_1b37()
        {
            ii(0x1_1b37, 1);  push(bp);                                 /* push bp */
            ii(0x1_1b38, 2);  mov(bp, sp);                              /* mov bp, sp */
            ii(0x1_1b3a, 5);  cmp(memb[ds, 0x2f], 3);                   /* cmp byte [0x2f], 0x3 */
            ii(0x1_1b3f, 2);  if(jae_func(0x1_1afd, -0x44)) return;     /* jae 0x1afd */
            ii(0x1_1b41, 1);  push(ds);                                 /* push ds */
            ii(0x1_1b42, 3);  call(0x1_1b52, 0xd);                      /* call 0x1b52 */
            ii(0x1_1b45, 3);  mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x1_1b48, 3);  mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
            ii(0x1_1b4b, 2);  mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x1_1b4d, 3);  mov(memw[ds, bx + 2], dx);                /* mov [bx+0x2], dx */
            ii(0x1_1b50, 2);  if(jmp_func(0x1_1b34, -0x1e)) return;     /* jmp 0x1b34 */
        }
    }
}
