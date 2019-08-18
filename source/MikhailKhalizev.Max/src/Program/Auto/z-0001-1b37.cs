using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8cd9876a-c781-4dae-b103-584209e134c2")]
        public void Method_0001_1b37()
        {
            ii(0x1_1b37, 1);  pushw(bp);                                /* push bp */
            ii(0x1_1b38, 2);  mov(bp, sp);                              /* mov bp, sp */
            ii(0x1_1b3a, 5);  cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x1_1b3f, 2);  if(jaew_func(0x1_1afd, -0x44)) return;    /* jae 0x1afd */
            ii(0x1_1b41, 1);  pushw(ds);                                /* push ds */
            ii(0x1_1b42, 3);  callw(0x1_1b52, 0xd);                     /* call 0x1b52 */
            ii(0x1_1b45, 3);  mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x1_1b48, 3);  mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x1_1b4b, 2);  mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x1_1b4d, 3);  mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x1_1b50, 2);  if(jmpw_func(0x1_1b34, -0x1e)) return;    /* jmp 0x1b34 */
        }
    }
}
