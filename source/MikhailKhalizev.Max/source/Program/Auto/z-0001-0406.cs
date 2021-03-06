using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_0406-d7d5aa10")]
        public void Method_0001_0406()
        {
            ii(0x1_0406, 4);  enter(4, 0);                             /* enter 0x4, 0x0 */
            ii(0x1_040a, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_040c, 2);  push(1);                                 /* push 0x1 */
            ii(0x1_040e, 3);  call(0xfdab, -0x666);                    /* call 0xfdab */
            ii(0x1_0411, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_0412, 1);  pop(bx);                                 /* pop bx */
            ii(0x1_0413, 3);  mov(memw[ss, bp - 4], ax);               /* mov [bp-0x4], ax */
            ii(0x1_0416, 3);  mov(memw[ss, bp - 2], dx);               /* mov [bp-0x2], dx */
            ii(0x1_0419, 2);  or(dx, ax);                              /* or dx, ax */
            ii(0x1_041b, 2);  if(jnz(0x1_0421, 4)) goto l_0x1_0421;    /* jnz 0x421 */
            ii(0x1_041d, 2);  sub(ax, ax);                             /* sub ax, ax */
            ii(0x1_041f, 2);  jmp(0x1_0485, 0x64); goto l_0x1_0485;    /* jmp 0x485 */
        l_0x1_0421:
            ii(0x1_0421, 1);  cli();                                   /* cli */
            ii(0x1_0422, 3);  push(memw[ss, bp + 10]);                 /* push word [bp+0xa] */
            ii(0x1_0425, 3);  push(memw[ss, bp + 8]);                  /* push word [bp+0x8] */
            ii(0x1_0428, 2);  push(8);                                 /* push 0x8 */
            ii(0x1_042a, 3);  push(memw[ss, bp - 2]);                  /* push word [bp-0x2] */
            ii(0x1_042d, 3);  push(memw[ss, bp - 4]);                  /* push word [bp-0x4] */
            ii(0x1_0430, 3);  call(0x1_1b37, 0x1704);                  /* call 0x1b37 */
            ii(0x1_0433, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_0436, 3);  push(memw[ss, bp + 6]);                  /* push word [bp+0x6] */
            ii(0x1_0439, 3);  push(memw[ss, bp + 4]);                  /* push word [bp+0x4] */
            ii(0x1_043c, 2);  push(0xc);                               /* push 0xc */
            ii(0x1_043e, 3);  push(memw[ss, bp - 2]);                  /* push word [bp-0x2] */
            ii(0x1_0441, 3);  push(memw[ss, bp - 4]);                  /* push word [bp-0x4] */
            ii(0x1_0444, 3);  call(0x1_1b37, 0x16f0);                  /* call 0x1b37 */
            ii(0x1_0447, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_044a, 3);  push(0xdead);                            /* push 0xdead */
            ii(0x1_044d, 3);  push(0xdead);                            /* push 0xdead */
            ii(0x1_0450, 2);  push(4);                                 /* push 0x4 */
            ii(0x1_0452, 3);  push(memw[ss, bp - 2]);                  /* push word [bp-0x2] */
            ii(0x1_0455, 3);  push(memw[ss, bp - 4]);                  /* push word [bp-0x4] */
            ii(0x1_0458, 3);  call(0x1_1b37, 0x16dc);                  /* call 0x1b37 */
            ii(0x1_045b, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_045e, 4);  push(memw[ds, 0xc12]);                   /* push word [0xc12] */
            ii(0x1_0462, 4);  push(memw[ds, 0xc10]);                   /* push word [0xc10] */
            ii(0x1_0466, 2);  push(0);                                 /* push 0x0 */
            ii(0x1_0468, 3);  push(memw[ss, bp - 2]);                  /* push word [bp-0x2] */
            ii(0x1_046b, 3);  push(memw[ss, bp - 4]);                  /* push word [bp-0x4] */
            ii(0x1_046e, 3);  call(0x1_1b37, 0x16c6);                  /* call 0x1b37 */
            ii(0x1_0471, 3);  add(sp, 0xa);                            /* add sp, 0xa */
            ii(0x1_0474, 3);  mov(ax, memw[ss, bp - 4]);               /* mov ax, [bp-0x4] */
            ii(0x1_0477, 3);  mov(dx, memw[ss, bp - 2]);               /* mov dx, [bp-0x2] */
            ii(0x1_047a, 3);  mov(memw[ds, 0xc10], ax);                /* mov [0xc10], ax */
            ii(0x1_047d, 4);  mov(memw[ds, 0xc12], dx);                /* mov [0xc12], dx */
            ii(0x1_0481, 1);  sti();                                   /* sti */
            ii(0x1_0482, 3);  mov(ax, 1);                              /* mov ax, 0x1 */
        l_0x1_0485:
            ii(0x1_0485, 1);  leave();                                 /* leave */
            ii(0x1_0486, 3);  ret(8);                                  /* ret 0x8 */
        }
    }
}
