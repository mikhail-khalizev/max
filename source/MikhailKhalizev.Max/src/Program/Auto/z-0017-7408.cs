using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7408-613089e7")]
        public void Method_0017_7408()
        {
            ii(0x17_7408, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x17_740c, 1);  push(ds);                               /* push ds */
            ii(0x17_740d, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_7410, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_7412, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_7414, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x17_7417, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x17_741a, 5);  mov(memw[ss, bp - 6], 0x1500);          /* mov word [bp-0x6], 0x1500 */
            ii(0x17_741f, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x17_7422, 1);  push(ss);                               /* push ss */
            ii(0x17_7423, 1);  push(ax);                               /* push ax */
            ii(0x17_7424, 3);  push(0xff00);                           /* push 0xff00 */
            ii(0x17_7427, 1);  nop();                                  /* nop */
            ii(0x17_7428, 1);  push(cs);                               /* push cs */
            ii(0x17_7429, 3);  call(0x17_eaed, 0x76c1);                /* call 0xeaed */
            ii(0x17_742c, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_742f, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_7431, 2);  if(jnz(0x17_7436, 3)) goto l_0x17_7436; /* jnz 0x7436 */
            ii(0x17_7433, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7434, 1);  leave();                                /* leave */
            ii(0x17_7435, 1);  retf(); return;                         /* retf */
        l_0x17_7436:
            ii(0x17_7436, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x17_7439, 3);  mov(memw[ds, 0x1ea0], ax);              /* mov [0x1ea0], ax */
            ii(0x17_743c, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x17_743f, 3);  mov(memw[ds, 0x1e9e], ax);              /* mov [0x1e9e], ax */
            ii(0x17_7442, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_7445, 3);  mov(memw[ds, 0x1ea4], ax);              /* mov [0x1ea4], ax */
            ii(0x17_7448, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x17_744b, 3);  mov(memw[ds, 0x1ea2], ax);              /* mov [0x1ea2], ax */
            ii(0x17_744e, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_7451, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7452, 1);  leave();                                /* leave */
            ii(0x17_7453, 1);  retf();                                 /* retf */
        }
    }
}
