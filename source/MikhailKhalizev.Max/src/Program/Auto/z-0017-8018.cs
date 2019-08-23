using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8018-1dc984ab")]
        public void Method_0017_8018()
        {
            ii(0x17_8018, 4); enter(0x2, 0);                            /* enter 0x2, 0x0 */
            ii(0x17_801c, 1); push(ds);                                 /* push ds */
            ii(0x17_801d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_8020, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_8022, 5); mov(memw[ss, bp - 0x2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x17_8027, 4); mov(es, memw[ds, 0x1dca]);                /* mov es, [0x1dca] */
            ii(0x17_802b, 6); cmp(memb[es, 0x2e], 0);                   /* cmp byte [es:0x2e], 0x0 */
            ii(0x17_8031, 2); if(jz(0x17_804d, 0x1a)) goto l_0x17_804d; /* jz 0x804d */
            ii(0x17_8033, 1); nop();                                    /* nop */
            ii(0x17_8034, 1); push(cs);                                 /* push cs */
            ii(0x17_8035, 3); call(0x17_6d68, -0x12d0);                 /* call 0x6d68 */
            ii(0x17_8038, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_803a, 2); if(jnz(0x17_804d, 0x11)) goto l_0x17_804d; /* jnz 0x804d */
            ii(0x17_803c, 1); push(ds);                                 /* push ds */
            ii(0x17_803d, 3); push(0xa0c);                              /* push 0xa0c */
            ii(0x17_8040, 1); nop();                                    /* nop */
            ii(0x17_8041, 1); push(cs);                                 /* push cs */
            ii(0x17_8042, 3); call(0x17_ed1a, 0x6cd5);                  /* call 0xed1a */
            ii(0x17_8045, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_8048, 5); mov(memw[ss, bp - 0x2], 0x1);             /* mov word [bp-0x2], 0x1 */
        l_0x17_804d:
            ii(0x17_804d, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x17_8050, 1); nop();                                    /* nop */
            ii(0x17_8051, 1); push(cs);                                 /* push cs */
            ii(0x17_8052, 3); call(0x17_ee52, 0x6dfd);                  /* call 0xee52 */
            ii(0x17_8055, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_8058, 1); pop(ds);                                  /* pop ds */
            ii(0x17_8059, 1); leave();                                  /* leave */
            ii(0x17_805a, 1); retf();                                   /* retf */
        }
    }
}
