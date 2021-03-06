using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d3d8-70ab6b82")]
        public void Method_0019_d3d8()
        {
            ii(0x19_d3d8, 4);  enter(0x42, 0);                         /* enter 0x42, 0x0 */
            ii(0x19_d3dc, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d3df, 5);  mov(memw[es, bx], 0);                   /* mov word [es:bx], 0x0 */
            ii(0x19_d3e4, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_d3e6, 4);  mov(memw[es, bx + 4], ax);              /* mov [es:bx+0x4], ax */
            ii(0x19_d3ea, 4);  mov(memw[es, bx + 2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x19_d3ee, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_d3f1, 3);  push(memw[ss, bp + 18]);                /* push word [bp+0x12] */
            ii(0x19_d3f4, 3);  push(memw[ss, bp + 16]);                /* push word [bp+0x10] */
            ii(0x19_d3f7, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_d3fa, 3);  lea(ax, memw[ss, bp - 64]);             /* lea ax, [bp-0x40] */
            ii(0x19_d3fd, 1);  push(ss);                               /* push ss */
            ii(0x19_d3fe, 1);  push(ax);                               /* push ax */
            ii(0x19_d3ff, 3);  call(0x19_cde9, -0x619);                /* call 0xcde9 */
            ii(0x19_d402, 3);  lea(ax, memw[ss, bp - 64]);             /* lea ax, [bp-0x40] */
            ii(0x19_d405, 1);  push(ss);                               /* push ss */
            ii(0x19_d406, 1);  push(ax);                               /* push ax */
            ii(0x19_d407, 3);  call(0x19_a16e, -0x329c);               /* call 0xa16e */
            ii(0x19_d40a, 3);  mov(memw[ss, bp - 66], ax);             /* mov [bp-0x42], ax */
            ii(0x19_d40d, 3);  cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x19_d410, 2);  if(jnz(0x19_d41d, 0xb)) goto l_0x19_d41d;/* jnz 0xd41d */
            ii(0x19_d412, 3);  lea(ax, memw[ss, bp - 64]);             /* lea ax, [bp-0x40] */
            ii(0x19_d415, 1);  push(ss);                               /* push ss */
            ii(0x19_d416, 1);  push(ax);                               /* push ax */
            ii(0x19_d417, 3);  call(0x19_d6d6, 0x2bc);                 /* call 0xd6d6 */
            ii(0x19_d41a, 3);  mov(memw[ss, bp - 66], ax);             /* mov [bp-0x42], ax */
        l_0x19_d41d:
            ii(0x19_d41d, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_d420, 3);  push(memw[ss, bp + 18]);                /* push word [bp+0x12] */
            ii(0x19_d423, 3);  lea(ax, memw[ss, bp - 64]);             /* lea ax, [bp-0x40] */
            ii(0x19_d426, 1);  push(ss);                               /* push ss */
            ii(0x19_d427, 1);  push(ax);                               /* push ax */
            ii(0x19_d428, 3);  call(0x19_d270, -0x1bb);                /* call 0xd270 */
            ii(0x19_d42b, 4);  cmp(memw[ss, bp - 66], -1 /* 0xff */);  /* cmp word [bp-0x42], 0xffff */
            ii(0x19_d42f, 2);  if(jz(0x19_d440, 0xf)) goto l_0x19_d440;/* jz 0xd440 */
            ii(0x19_d431, 3);  push(memw[ss, bp - 66]);                /* push word [bp-0x42] */
            ii(0x19_d434, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_d437, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_d43a, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_d43d, 3);  call(0x19_cff8, -0x448);                /* call 0xcff8 */
        l_0x19_d440:
            ii(0x19_d440, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d443, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_d447, 4);  or(ax, memw[es, bx + 2]);               /* or ax, [es:bx+0x2] */
            ii(0x19_d44b, 2);  if(jnz(0x19_d461, 0x14)) goto l_0x19_d461;/* jnz 0xd461 */
            ii(0x19_d44d, 3);  lea(ax, memw[ss, bp - 64]);             /* lea ax, [bp-0x40] */
            ii(0x19_d450, 1);  push(ss);                               /* push ss */
            ii(0x19_d451, 1);  push(ax);                               /* push ax */
            ii(0x19_d452, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_d455, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_d458, 1);  push(es);                               /* push es */
            ii(0x19_d459, 1);  push(bx);                               /* push bx */
            ii(0x19_d45a, 3);  mov(al, memb[ss, bp + 4]);              /* mov al, [bp+0x4] */
            ii(0x19_d45d, 1);  push(ax);                               /* push ax */
            ii(0x19_d45e, 3);  call(0x19_d1ad, -0x2b4);                /* call 0xd1ad */
        l_0x19_d461:
            ii(0x19_d461, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d464, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_d468, 4);  or(ax, memw[es, bx + 2]);               /* or ax, [es:bx+0x2] */
            ii(0x19_d46c, 2);  if(jnz(0x19_d487, 0x19)) goto l_0x19_d487;/* jnz 0xd487 */
            ii(0x19_d46e, 3);  lea(ax, memw[ss, bp - 64]);             /* lea ax, [bp-0x40] */
            ii(0x19_d471, 1);  push(ss);                               /* push ss */
            ii(0x19_d472, 1);  push(ax);                               /* push ax */
            ii(0x19_d473, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_d476, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_d479, 3);  mov(ax, memw[ss, bp + 18]);             /* mov ax, [bp+0x12] */
            ii(0x19_d47c, 3);  mov(dx, memw[ss, bp + 20]);             /* mov dx, [bp+0x14] */
            ii(0x19_d47f, 3);  add(ax, 0xea);                          /* add ax, 0xea */
            ii(0x19_d482, 1);  push(dx);                               /* push dx */
            ii(0x19_d483, 1);  push(ax);                               /* push ax */
            ii(0x19_d484, 3);  call(0x19_cd9f, -0x6e8);                /* call 0xcd9f */
        l_0x19_d487:
            ii(0x19_d487, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d48a, 3);  push(memw[es, bx]);                     /* push word [es:bx] */
            ii(0x19_d48d, 4);  push(memw[es, bx + 4]);                 /* push word [es:bx+0x4] */
            ii(0x19_d491, 4);  push(memw[es, bx + 2]);                 /* push word [es:bx+0x2] */
            ii(0x19_d495, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_d498, 3);  lea(ax, memw[ss, bp - 64]);             /* lea ax, [bp-0x40] */
            ii(0x19_d49b, 1);  push(ss);                               /* push ss */
            ii(0x19_d49c, 1);  push(ax);                               /* push ax */
            ii(0x19_d49d, 1);  push(ds);                               /* push ds */
            ii(0x19_d49e, 3);  push(0x29f0);                           /* push 0x29f0 */
            ii(0x19_d4a1, 5);  call_far_abs(0x80, 0x2289);             /* call word 0x80:0x2289 */
            ii(0x19_d4a6, 1);  leave();                                /* leave */
            ii(0x19_d4a7, 3);  ret(0x12);                              /* ret 0x12 */
        }
    }
}
