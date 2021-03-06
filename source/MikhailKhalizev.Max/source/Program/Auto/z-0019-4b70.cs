using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4b70-e9adfd3")]
        public void Method_0019_4b70()
        {
            ii(0x19_4b70, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x19_4b74, 1);  push(ds);                               /* push ds */
            ii(0x19_4b75, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_4b78, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_4b7a, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_4b7d, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x19_4b80, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_4b82, 2);  mov(cl, 4);                             /* mov cl, 0x4 */
        l_0x19_4b84:
            ii(0x19_4b84, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_4b86, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_4b88, 2);  dec(cl);                                /* dec cl */
            ii(0x19_4b8a, 2);  if(jnz(0x19_4b84, -8)) goto l_0x19_4b84;/* jnz 0x4b84 */
            ii(0x19_4b8c, 3);  add(ax, memw[ss, bp + 6]);              /* add ax, [bp+0x6] */
            ii(0x19_4b8f, 3);  adc(dx, 0);                             /* adc dx, 0x0 */
            ii(0x19_4b92, 1);  push(dx);                               /* push dx */
            ii(0x19_4b93, 1);  push(ax);                               /* push ax */
            ii(0x19_4b94, 1);  push(cs);                               /* push cs */
            ii(0x19_4b95, 3);  call(0x19_4abc, -0xdc);                 /* call 0x4abc */
            ii(0x19_4b98, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_4b9b, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4b9c, 1);  leave();                                /* leave */
            ii(0x19_4b9d, 1);  retf();                                 /* retf */
        }
    }
}
