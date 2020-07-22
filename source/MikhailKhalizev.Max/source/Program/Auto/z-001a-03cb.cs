using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_03cb-b0babf5c")]
        public void Method_001a_03cb()
        {
            ii(0x1a_03cb, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x1a_03cf, 1);  push(ds);                               /* push ds */
            ii(0x1a_03d0, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x1a_03d3, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x1a_03d5, 2);  jmp(0x1a_03fa, 0x23); goto l_0x1a_03fa; /* jmp 0x3fa */
        l_0x1a_03d7:
            ii(0x1a_03d7, 3);  mov(ax, memw[ss, bp + 14]);             /* mov ax, [bp+0xe] */
            ii(0x1a_03da, 3);  mov(dx, memw[ss, bp + 16]);             /* mov dx, [bp+0x10] */
            ii(0x1a_03dd, 3);  mov(cl, memb[ss, bp + 10]);             /* mov cl, [bp+0xa] */
            ii(0x1a_03e0, 3);  shl(cl, 2);                             /* shl cl, 0x2 */
            ii(0x1a_03e3, 5);  call_far_abs(0x80, 0x4378);             /* call word 0x80:0x4378 */
            ii(0x1a_03e8, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x1a_03ea, 3);  and(bx, 0xf);                           /* and bx, 0xf */
            ii(0x1a_03ed, 4);  mov(al, memb[ds, bx + 0x36f8]);         /* mov al, [bx+0x36f8] */
            ii(0x1a_03f1, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x1a_03f4, 3);  inc(memw[ss, bp + 6]);                  /* inc word [bp+0x6] */
            ii(0x1a_03f7, 3);  mov(memb[es, bx], al);                  /* mov [es:bx], al */
        l_0x1a_03fa:
            ii(0x1a_03fa, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x1a_03fd, 3);  dec(memw[ss, bp + 10]);                 /* dec word [bp+0xa] */
            ii(0x1a_0400, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x1a_0402, 2);  if(jnz(0x1a_03d7, -0x2d)) goto l_0x1a_03d7;/* jnz 0x3d7 */
            ii(0x1a_0404, 1);  pop(ds);                                /* pop ds */
            ii(0x1a_0405, 1);  leave();                                /* leave */
            ii(0x1a_0406, 3);  retf(0xc);                              /* retf 0xc */
        }
    }
}
