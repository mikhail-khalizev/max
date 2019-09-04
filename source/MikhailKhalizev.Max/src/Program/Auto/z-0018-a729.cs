using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a729-b07f3f3d")]
        public void Method_0018_a729()
        {
            ii(0x18_a729, 3);  mov(ax, 0x24f0);                        /* mov ax, 0x24f0 */
            ii(0x18_a72c, 2);  mov(bx, sp);                            /* mov bx, sp */
            ii(0x18_a72e, 1);  push(ds);                               /* push ds */
            ii(0x18_a72f, 5);  mov(ds, memw[cs, 0x5680]);              /* mov ds, [cs:0x5680] */
            ii(0x18_a734, 4);  mov(ds, memw[ds, 0xc28]);               /* mov ds, [0xc28] */
            ii(0x18_a738, 4);  push(memw[ss, bx + 10]);                /* push word [ss:bx+0xa] */
            ii(0x18_a73c, 4);  push(memw[ss, bx + 8]);                 /* push word [ss:bx+0x8] */
            ii(0x18_a740, 4);  push(memw[ss, bx + 6]);                 /* push word [ss:bx+0x6] */
            ii(0x18_a744, 4);  push(memw[ss, bx + 4]);                 /* push word [ss:bx+0x4] */
            ii(0x18_a748, 2);  call_abs(ax);                           /* call ax */
            ii(0x18_a74a, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x18_a74d, 1);  pop(ds);                                /* pop ds */
            ii(0x18_a74e, 1);  retf();                                 /* retf */
        }
    }
}
