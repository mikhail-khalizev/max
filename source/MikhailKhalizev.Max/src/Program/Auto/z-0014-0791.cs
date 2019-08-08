using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e1131956-6fb7-43b8-9713-fafa8b014646")]
        public void Method_0014_0791()
        {
            ii(0x14_0791, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x14_0795, 1); pushw(ds);                                /* push ds */
            ii(0x14_0796, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_0799, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_079b, 5); mov(memw_a16[ss, bp - 0x2], 0x3e00);      /* mov word [bp-0x2], 0x3e00 */
            ii(0x14_07a0, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x14_07a2, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x14_07a5, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x14_07a8, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x14_07ab, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x14_07ae, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x14_07b1, 1); pushw(ss);                                /* push ss */
            ii(0x14_07b2, 1); pushw(ax);                                /* push ax */
            ii(0x14_07b3, 3); pushw(0x3e00);                            /* push 0x3e00 */
            ii(0x14_07b6, 1); nop();                                    /* nop */
            ii(0x14_07b7, 1); pushw(cs);                                /* push cs */
            ii(0x14_07b8, 3); callw(0x13_eaed, -0x1cce);                /* call 0xeaed */
            ii(0x14_07bb, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x14_07be, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_07c0, 2); if(jzw(0x14_07c7, 0x5)) goto l_0x14_07c7; /* jz 0x7c7 */
            ii(0x14_07c2, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x14_07c5, 2); jmpw(0x14_07ca, 0x3); goto l_0x14_07ca;   /* jmp 0x7ca */
        l_0x14_07c7:
            ii(0x14_07c7, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x14_07ca:
            ii(0x14_07ca, 1); popw(ds);                                 /* pop ds */
            ii(0x14_07cb, 1); leavew();                                 /* leave */
            ii(0x14_07cc, 3); retfw(0x2); return;                       /* retf 0x2 */
        }
    }
}
