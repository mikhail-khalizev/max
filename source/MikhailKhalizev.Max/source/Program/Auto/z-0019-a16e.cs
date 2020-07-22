using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_a16e-bd91b28a")]
        public void Method_0019_a16e()
        {
            ii(0x19_a16e, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x19_a172, 1);  push(si);                               /* push si */
            ii(0x19_a173, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_a178, 2);  jmp(0x19_a17d, 3); goto l_0x19_a17d;    /* jmp 0xa17d */
        l_0x19_a17a:
            ii(0x19_a17a, 3);  inc(memw[ss, bp - 2]);                  /* inc word [bp-0x2] */
        l_0x19_a17d:
            ii(0x19_a17d, 4);  cmp(memw[ss, bp - 2], 0x10);            /* cmp word [bp-0x2], 0x10 */
            ii(0x19_a181, 2);  if(jae(0x19_a1b9, 0x36)) goto l_0x19_a1b9;/* jae 0xa1b9 */
            ii(0x19_a183, 4);  les(bx, memw[ds, 0x1f1a]);              /* les bx, [0x1f1a] */
            ii(0x19_a187, 4);  add(bx, 0x1352);                        /* add bx, 0x1352 */
            ii(0x19_a18b, 3);  mov(si, memw[ss, bp - 2]);              /* mov si, [bp-0x2] */
            ii(0x19_a18e, 4);  cmp(memb[es, bx + si], 0);              /* cmp byte [es:bx+si], 0x0 */
            ii(0x19_a192, 2);  if(jz(0x19_a17a, -0x1a)) goto l_0x19_a17a;/* jz 0xa17a */
            ii(0x19_a194, 4);  imul(ax, si, 0x134);                    /* imul ax, si, 0x134 */
            ii(0x19_a198, 4);  add(ax, memw[ds, 0x1f1a]);              /* add ax, [0x1f1a] */
            ii(0x19_a19c, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x19_a19e, 3);  add(ax, 0xfc);                          /* add ax, 0xfc */
            ii(0x19_a1a1, 1);  push(dx);                               /* push dx */
            ii(0x19_a1a2, 1);  push(ax);                               /* push ax */
            ii(0x19_a1a3, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_a1a6, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x19_a1a9, 5);  call_far_abs(0x80, 0x4438);             /* call word 0x80:0x4438 */
            ii(0x19_a1ae, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_a1b1, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_a1b3, 2);  if(jnz(0x19_a17a, -0x3b)) goto l_0x19_a17a;/* jnz 0xa17a */
            ii(0x19_a1b5, 2);  mov(ax, si);                            /* mov ax, si */
            ii(0x19_a1b7, 2);  jmp(0x19_a1bc, 3); goto l_0x19_a1bc;    /* jmp 0xa1bc */
        l_0x19_a1b9:
            ii(0x19_a1b9, 3);  mov(ax, 0xffff);                        /* mov ax, 0xffff */
        l_0x19_a1bc:
            ii(0x19_a1bc, 1);  pop(si);                                /* pop si */
            ii(0x19_a1bd, 1);  leave();                                /* leave */
            ii(0x19_a1be, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
