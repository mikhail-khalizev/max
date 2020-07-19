using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_c6b4-6d068e75")]
        public void Method_0017_c6b4()
        {
            ii(0x17_c6b4, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x17_c6b8, 1);  push(ds);                               /* push ds */
            ii(0x17_c6b9, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_c6bc, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_c6be, 4);  mov(memb[ss, bp - 2], 1);               /* mov byte [bp-0x2], 0x1 */
            ii(0x17_c6c2, 2);  jmp(0x17_c6c7, 3); goto l_0x17_c6c7;    /* jmp 0xc6c7 */
        l_0x17_c6c4:
            ii(0x17_c6c4, 3);  inc(memb[ss, bp - 2]);                  /* inc byte [bp-0x2] */
        l_0x17_c6c7:
            ii(0x17_c6c7, 4);  cmp(memb[ss, bp - 2], 0x64);            /* cmp byte [bp-0x2], 0x64 */
            ii(0x17_c6cb, 2);  if(jae(0x17_c6e8, 0x1b)) goto l_0x17_c6e8;/* jae 0xc6e8 */
            ii(0x17_c6cd, 3);  mov(bl, memb[ss, bp - 2]);              /* mov bl, [bp-0x2] */
            ii(0x17_c6d0, 2);  sub(bh, bh);                            /* sub bh, bh */
            ii(0x17_c6d2, 3);  shl(bx, 3);                             /* shl bx, 0x3 */
            ii(0x17_c6d5, 4);  mov(ax, memw[ds, bx + 0x2022]);         /* mov ax, [bx+0x2022] */
            ii(0x17_c6d9, 4);  or(ax, memw[ds, bx + 0x2020]);          /* or ax, [bx+0x2020] */
            ii(0x17_c6dd, 2);  if(jnz(0x17_c6e6, 7)) goto l_0x17_c6e6; /* jnz 0xc6e6 */
            ii(0x17_c6df, 3);  mov(al, memb[ss, bp - 2]);              /* mov al, [bp-0x2] */
            ii(0x17_c6e2, 1);  pop(ds);                                /* pop ds */
            ii(0x17_c6e3, 1);  leave();                                /* leave */
            ii(0x17_c6e4, 1);  retf(); return;                         /* retf */
        //  ii(0x17_c6e5, 1);  Недостижимый код.
        l_0x17_c6e6:
            ii(0x17_c6e6, 2);  jmp(0x17_c6c4, -0x24); goto l_0x17_c6c4;/* jmp 0xc6c4 */
        l_0x17_c6e8:
            ii(0x17_c6e8, 2);  mov(al, 0xff);                          /* mov al, 0xff */
            ii(0x17_c6ea, 1);  pop(ds);                                /* pop ds */
            ii(0x17_c6eb, 1);  leave();                                /* leave */
            ii(0x17_c6ec, 1);  retf();                                 /* retf */
        }
    }
}
