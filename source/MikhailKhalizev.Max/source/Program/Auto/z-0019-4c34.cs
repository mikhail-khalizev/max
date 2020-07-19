using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4c34-3e524a0b")]
        public void Method_0019_4c34()
        {
            ii(0x19_4c34, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x19_4c38, 1);  push(ds);                               /* push ds */
            ii(0x19_4c39, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_4c3c, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_4c3e, 5);  cmp(memw[ds, 0x3b72], 0);               /* cmp word [0x3b72], 0x0 */
            ii(0x19_4c43, 2);  if(jnz(0x19_4c66, 0x21)) goto l_0x19_4c66;/* jnz 0x4c66 */
            ii(0x19_4c45, 5);  mov(memw[ss, bp - 4], 1);               /* mov word [bp-0x4], 0x1 */
            ii(0x19_4c4a, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4c4c, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4c4e, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x19_4c51, 1);  push(ss);                               /* push ss */
            ii(0x19_4c52, 1);  push(ax);                               /* push ax */
            ii(0x19_4c53, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_4c56, 2);  push(1);                                /* push 0x1 */
            ii(0x19_4c58, 1);  nop();                                  /* nop */
            ii(0x19_4c59, 1);  push(cs);                               /* push cs */
            ii(0x19_4c5a, 3);  call(0x19_41fd, -0xa60);                /* call 0x41fd */
            ii(0x19_4c5d, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x19_4c60, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_4c62, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4c63, 1);  leave();                                /* leave */
            ii(0x19_4c64, 1);  retf(); return;                         /* retf */
        //  ii(0x19_4c65, 1);  Недостижимый код.
        l_0x19_4c66:
            ii(0x19_4c66, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_4c69, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_4c6c, 5);  mov(memw[ss, bp - 6], 0x700);           /* mov word [bp-0x6], 0x700 */
            ii(0x19_4c71, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4c73, 2);  push(0);                                /* push 0x0 */
            ii(0x19_4c75, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x19_4c78, 1);  push(ss);                               /* push ss */
            ii(0x19_4c79, 1);  push(ax);                               /* push ax */
            ii(0x19_4c7a, 3);  push(0xff00);                           /* push 0xff00 */
            ii(0x19_4c7d, 1);  nop();                                  /* nop */
            ii(0x19_4c7e, 1);  push(cs);                               /* push cs */
            ii(0x19_4c7f, 3);  call(0x19_4188, -0xafa);                /* call 0x4188 */
            ii(0x19_4c82, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_4c85, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_4c87, 1);  pop(ds);                                /* pop ds */
            ii(0x19_4c88, 1);  leave();                                /* leave */
            ii(0x19_4c89, 1);  retf();                                 /* retf */
        }
    }
}
