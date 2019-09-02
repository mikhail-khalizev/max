using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e82c-86541dae")]
        public void Method_0017_e82c()
        {
            ii(0x17_e82c, 4); enter(0x14, 0);                           /* enter 0x14, 0x0 */
            ii(0x17_e830, 1); push(ds);                                 /* push ds */
            ii(0x17_e831, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_e834, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_e836, 5); mov(memw[ss, bp - 6], 0x100);             /* mov word [bp-0x6], 0x100 */
            ii(0x17_e83b, 2); push(0);                                  /* push 0x0 */
            ii(0x17_e83d, 2); push(0);                                  /* push 0x0 */
            ii(0x17_e83f, 3); lea(ax, memw[ss, bp - 0x14]);             /* lea ax, [bp-0x14] */
            ii(0x17_e842, 1); push(ss);                                 /* push ss */
            ii(0x17_e843, 1); push(ax);                                 /* push ax */
            ii(0x17_e844, 2); push(-1 /* 0xff */);                      /* push 0xffff */
            ii(0x17_e846, 1); nop();                                    /* nop */
            ii(0x17_e847, 1); push(cs);                                 /* push cs */
            ii(0x17_e848, 3); call(0x17_eb40, 0x2f5);                   /* call 0xeb40 */
            ii(0x17_e84b, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_e84e, 3); mov(dx, memw[ss, bp - 6]);                /* mov dx, [bp-0x6] */
            ii(0x17_e851, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_e853, 3); add(ax, memw[ss, bp - 2]);                /* add ax, [bp-0x2] */
            ii(0x17_e856, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_e859, 2); mov(cl, 4);                               /* mov cl, 0x4 */
        l_0x17_e85b:
            ii(0x17_e85b, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_e85d, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_e85f, 2); dec(cl);                                  /* dec cl */
            ii(0x17_e861, 2); if(jnz(0x17_e85b, -8)) goto l_0x17_e85b;  /* jnz 0xe85b */
            ii(0x17_e863, 1); pop(ds);                                  /* pop ds */
            ii(0x17_e864, 1); leave();                                  /* leave */
            ii(0x17_e865, 1); retf();                                   /* retf */
        }
    }
}
