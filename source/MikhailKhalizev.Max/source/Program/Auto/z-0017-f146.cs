using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_f146-d3b308a3")]
        public void Method_0017_f146()
        {
            ii(0x17_f146, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x17_f14a, 1);  push(ds);                               /* push ds */
            ii(0x17_f14b, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_f14e, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_f150, 5);  cmp(memw[ds, 0x1412], 0);               /* cmp word [0x1412], 0x0 */
            ii(0x17_f155, 2);  if(jnz(0x17_f180, 0x29)) goto l_0x17_f180;/* jnz 0xf180 */
            ii(0x17_f157, 5);  mov(memw[ss, bp - 4], 1);               /* mov word [bp-0x4], 0x1 */
            ii(0x17_f15c, 2);  push(0);                                /* push 0x0 */
            ii(0x17_f15e, 2);  push(0);                                /* push 0x0 */
            ii(0x17_f160, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x17_f163, 1);  push(ss);                               /* push ss */
            ii(0x17_f164, 1);  push(ax);                               /* push ax */
            ii(0x17_f165, 2);  push(0);                                /* push 0x0 */
            ii(0x17_f167, 2);  push(0);                                /* push 0x0 */
            ii(0x17_f169, 1);  nop();                                  /* nop */
            ii(0x17_f16a, 1);  push(cs);                               /* push cs */
            ii(0x17_f16b, 3);  call(0x17_eb98, -0x5d6);                /* call 0xeb98 */
            ii(0x17_f16e, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_f171, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_f173, 2);  if(jnz(0x17_f17a, 5)) goto l_0x17_f17a; /* jnz 0xf17a */
            ii(0x17_f175, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_f177, 1);  pop(ds);                                /* pop ds */
            ii(0x17_f178, 1);  leave();                                /* leave */
            ii(0x17_f179, 1);  retf(); return;                         /* retf */
        l_0x17_f17a:
            ii(0x17_f17a, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x17_f17d, 1);  pop(ds);                                /* pop ds */
            ii(0x17_f17e, 1);  leave();                                /* leave */
            ii(0x17_f17f, 1);  retf(); return;                         /* retf */
        l_0x17_f180:
            ii(0x17_f180, 5);  mov(memw[ss, bp - 4], 2);               /* mov word [bp-0x4], 0x2 */
            ii(0x17_f185, 5);  mov(memw[ss, bp - 8], 0xa000);          /* mov word [bp-0x8], 0xa000 */
            ii(0x17_f18a, 5);  mov(memw[ss, bp - 6], 0xa00);           /* mov word [bp-0x6], 0xa00 */
            ii(0x17_f18f, 2);  push(0);                                /* push 0x0 */
            ii(0x17_f191, 2);  push(0);                                /* push 0x0 */
            ii(0x17_f193, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x17_f196, 1);  push(ss);                               /* push ss */
            ii(0x17_f197, 1);  push(ax);                               /* push ax */
            ii(0x17_f198, 3);  push(0xff00);                           /* push 0xff00 */
            ii(0x17_f19b, 1);  nop();                                  /* nop */
            ii(0x17_f19c, 1);  push(cs);                               /* push cs */
            ii(0x17_f19d, 3);  call(0x17_eb40, -0x660);                /* call 0xeb40 */
            ii(0x17_f1a0, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_f1a3, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x17_f1a6, 1);  pop(ds);                                /* pop ds */
            ii(0x17_f1a7, 1);  leave();                                /* leave */
            ii(0x17_f1a8, 1);  retf();                                 /* retf */
        }
    }
}
