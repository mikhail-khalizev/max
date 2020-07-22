using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_effa-d202040c")]
        public void Method_0017_effa()
        {
            ii(0x17_effa, 4);  enter(0x1c, 0);                         /* enter 0x1c, 0x0 */
            ii(0x17_effe, 1);  push(di);                               /* push di */
            ii(0x17_efff, 1);  push(si);                               /* push si */
            ii(0x17_f000, 1);  push(ds);                               /* push ds */
            ii(0x17_f001, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_f004, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_f006, 1);  nop();                                  /* nop */
            ii(0x17_f007, 1);  push(cs);                               /* push cs */
            ii(0x17_f008, 3);  call(0x17_f134, 0x129);                 /* call 0xf134 */
            ii(0x17_f00b, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_f00d, 2);  if(jz(0x17_f02e, 0x1f)) goto l_0x17_f02e;/* jz 0xf02e */
            ii(0x17_f00f, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x17_f012, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x17_f015, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x17_f018, 2);  push(0);                                /* push 0x0 */
            ii(0x17_f01a, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x17_f01d, 1);  push(ss);                               /* push ss */
            ii(0x17_f01e, 1);  push(ax);                               /* push ax */
            ii(0x17_f01f, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x17_f022, 2);  push(0xb);                              /* push 0xb */
            ii(0x17_f024, 1);  nop();                                  /* nop */
            ii(0x17_f025, 1);  push(cs);                               /* push cs */
            ii(0x17_f026, 3);  call(0x17_eb98, -0x491);                /* call 0xeb98 */
            ii(0x17_f029, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_f02c, 2);  jmp(0x17_f064, 0x36); goto l_0x17_f064; /* jmp 0xf064 */
        l_0x17_f02e:
            ii(0x17_f02e, 3);  mov(ax, memw[ds, 0x1412]);              /* mov ax, [0x1412] */
            ii(0x17_f031, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x17_f034, 5);  mov(memw[ss, bp - 28], 0);              /* mov word [bp-0x1c], 0x0 */
            ii(0x17_f039, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_f03c, 2);  and(al, 0xf8);                          /* and al, 0xf8 */
            ii(0x17_f03e, 3);  add(ax, memw[ss, bp - 28]);             /* add ax, [bp-0x1c] */
            ii(0x17_f041, 3);  mov(dx, memw[ss, bp - 26]);             /* mov dx, [bp-0x1a] */
            ii(0x17_f044, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x17_f047, 3);  mov(memw[ss, bp - 22], dx);             /* mov [bp-0x16], dx */
            ii(0x17_f04a, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x17_f04d, 2);  mov(di, bx);                            /* mov di, bx */
            ii(0x17_f04f, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x17_f051, 1);  push(ds);                               /* push ds */
            ii(0x17_f052, 2);  mov(ds, dx);                            /* mov ds, dx */
            ii(0x17_f054, 1);  movsw();                                /* movsw */
            ii(0x17_f055, 1);  movsw();                                /* movsw */
            ii(0x17_f056, 1);  movsw();                                /* movsw */
            ii(0x17_f057, 1);  movsw();                                /* movsw */
            ii(0x17_f058, 1);  pop(ds);                                /* pop ds */
            ii(0x17_f059, 3);  les(bx, memw[ss, bp - 24]);             /* les bx, [bp-0x18] */
            ii(0x17_f05c, 5);  cmp(memb[es, bx + 5], 1);               /* cmp byte [es:bx+0x5], 0x1 */
            ii(0x17_f061, 2);  sbb(ax, ax);                            /* sbb ax, ax */
            ii(0x17_f063, 1);  inc(ax);                                /* inc ax */
        l_0x17_f064:
            ii(0x17_f064, 3);  mov(memw[ss, bp + 6], ax);              /* mov [bp+0x6], ax */
            ii(0x17_f067, 1);  pop(ds);                                /* pop ds */
            ii(0x17_f068, 1);  pop(si);                                /* pop si */
            ii(0x17_f069, 1);  pop(di);                                /* pop di */
            ii(0x17_f06a, 1);  leave();                                /* leave */
            ii(0x17_f06b, 1);  retf();                                 /* retf */
        }
    }
}
