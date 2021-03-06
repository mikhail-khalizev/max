using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4bd0-f538d0a3")]
        public void Method_0019_4bd0()
        {
            ii(0x19_4bd0, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x19_4bd4, 1);  push(ds);                               /* push ds */
            ii(0x19_4bd5, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_4bd8, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_4bda, 5);  cmp(memw[ds, 0x3b72], 0);               /* cmp word [0x3b72], 0x0 */
            ii(0x19_4bdf, 2);  if(jnz(0x19_4c0a, 0x29)) goto l_0x19_4c0a;/* jnz 0x4c0a */
            ii(0x19_4be1, 5);  mov(memw[ss, bp - 4], 1);               /* mov word [bp-0x4], 0x1 */
            ii(0x19_4be6, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4be8, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4bea, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x19_4bed, 1);  push(ss);                               /* push ss */
            ii(0x19_4bee, 1);  push(ax);                               /* push ax */
            ii(0x19_4bef, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4bf1, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4bf3, 1);  nop();                                  /* nop */
            ii(0x19_4bf4, 1);  push(cs);                               /* push cs */
            ii(0x19_4bf5, 3);  call(0x19_41fd, -0x9fb);                /* call 0x41fd */
            ii(0x19_4bf8, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x19_4bfb, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_4bfd, 2);  if(jnz(0x19_4c04, 5)) goto l_0x19_4c04; /* jnz 0x4c04 */
            ii(0x19_4bff, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_4c01, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4c02, 1);  leave();                                /* leave */
            ii(0x19_4c03, 1);  retf(); return;                         /* retf */
        l_0x19_4c04:
            ii(0x19_4c04, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_4c07, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4c08, 1);  leave();                                /* leave */
            ii(0x19_4c09, 1);  retf(); return;                         /* retf */
        l_0x19_4c0a:
            ii(0x19_4c0a, 5);  mov(memw[ss, bp - 4], 2);               /* mov word [bp-0x4], 0x2 */
            ii(0x19_4c0f, 5);  mov(memw[ss, bp - 8], 0xa000);          /* mov word [bp-0x8], 0xa000 */
            ii(0x19_4c14, 5);  mov(memw[ss, bp - 6], 0xa00);           /* mov word [bp-0x6], 0xa00 */
            ii(0x19_4c19, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4c1b, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4c1d, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x19_4c20, 1);  push(ss);                               /* push ss */
            ii(0x19_4c21, 1);  push(ax);                               /* push ax */
            ii(0x19_4c22, 3);  push(0xff00);                           /* push 0xff00 */
            ii(0x19_4c25, 1);  nop();                                  /* nop */
            ii(0x19_4c26, 1);  push(cs);                               /* push cs */
            ii(0x19_4c27, 3);  call(0x19_4188, -0xaa2);                /* call 0x4188 */
            ii(0x19_4c2a, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_4c2d, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x19_4c30, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4c31, 1);  leave();                                /* leave */
            ii(0x19_4c32, 1);  retf();                                 /* retf */
        }
    }
}
