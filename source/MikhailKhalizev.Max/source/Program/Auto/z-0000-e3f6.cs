using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe3f6-d7d5aa10")]
        public void Method_0000_e3f6()
        {
            ii(0xe3f6, 4);  enter(4, 0);                               /* enter 0x4, 0x0 */
            ii(0xe3fa, 2);  push(0);                                   /* push 0x0 */
            ii(0xe3fc, 2);  push(1);                                   /* push 0x1 */
            ii(0xe3fe, 3);  call(0xdd9b, -0x666);                      /* call 0xdd9b */
            ii(0xe401, 1);  pop(bx);                                   /* pop bx */
            ii(0xe402, 1);  pop(bx);                                   /* pop bx */
            ii(0xe403, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0xe406, 3);  mov(memw[ss, bp - 2], dx);                 /* mov [bp-0x2], dx */
            ii(0xe409, 2);  or(dx, ax);                                /* or dx, ax */
            ii(0xe40b, 2);  if(jnz(0xe411, 4)) goto l_0xe411;          /* jnz 0xe411 */
            ii(0xe40d, 2);  sub(ax, ax);                               /* sub ax, ax */
            ii(0xe40f, 2);  jmp(0xe475, 0x64); goto l_0xe475;          /* jmp 0xe475 */
        l_0xe411:
            ii(0xe411, 1);  cli();                                     /* cli */
            ii(0xe412, 3);  push(memw[ss, bp + 10]);                   /* push word [bp+0xa] */
            ii(0xe415, 3);  push(memw[ss, bp + 8]);                    /* push word [bp+0x8] */
            ii(0xe418, 2);  push(8);                                   /* push 0x8 */
            ii(0xe41a, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0xe41d, 3);  push(memw[ss, bp - 4]);                    /* push word [bp-0x4] */
            ii(0xe420, 3);  call(0xfb27, 0x1704);                      /* call 0xfb27 */
            ii(0xe423, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0xe426, 3);  push(memw[ss, bp + 6]);                    /* push word [bp+0x6] */
            ii(0xe429, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0xe42c, 2);  push(0xc);                                 /* push 0xc */
            ii(0xe42e, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0xe431, 3);  push(memw[ss, bp - 4]);                    /* push word [bp-0x4] */
            ii(0xe434, 3);  call(0xfb27, 0x16f0);                      /* call 0xfb27 */
            ii(0xe437, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0xe43a, 3);  push(0xdead);                              /* push 0xdead */
            ii(0xe43d, 3);  push(0xdead);                              /* push 0xdead */
            ii(0xe440, 2);  push(4);                                   /* push 0x4 */
            ii(0xe442, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0xe445, 3);  push(memw[ss, bp - 4]);                    /* push word [bp-0x4] */
            ii(0xe448, 3);  call(0xfb27, 0x16dc);                      /* call 0xfb27 */
            ii(0xe44b, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0xe44e, 4);  push(memw[ds, 0xc12]);                     /* push word [0xc12] */
            ii(0xe452, 4);  push(memw[ds, 0xc10]);                     /* push word [0xc10] */
            ii(0xe456, 2);  push(0);                                   /* push 0x0 */
            ii(0xe458, 3);  push(memw[ss, bp - 2]);                    /* push word [bp-0x2] */
            ii(0xe45b, 3);  push(memw[ss, bp - 4]);                    /* push word [bp-0x4] */
            ii(0xe45e, 3);  call(0xfb27, 0x16c6);                      /* call 0xfb27 */
            ii(0xe461, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0xe464, 3);  mov(ax, memw[ss, bp - 4]);                 /* mov ax, [bp-0x4] */
            ii(0xe467, 3);  mov(dx, memw[ss, bp - 2]);                 /* mov dx, [bp-0x2] */
            ii(0xe46a, 3);  mov(memw[ds, 0xc10], ax);                  /* mov [0xc10], ax */
            ii(0xe46d, 4);  mov(memw[ds, 0xc12], dx);                  /* mov [0xc12], dx */
            ii(0xe471, 1);  sti();                                     /* sti */
            ii(0xe472, 3);  mov(ax, 1);                                /* mov ax, 0x1 */
        l_0xe475:
            ii(0xe475, 1);  leave();                                   /* leave */
            ii(0xe476, 3);  ret(8);                                    /* ret 0x8 */
        }
    }
}
