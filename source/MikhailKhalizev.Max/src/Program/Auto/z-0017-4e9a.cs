using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4e9a-dd4e0e3f")]
        public void Method_0017_4e9a()
        {
            ii(0x17_4e9a, 4); enter(0xe, 0);                            /* enter 0xe, 0x0 */
            ii(0x17_4e9e, 1); push(ds);                                 /* push ds */
            ii(0x17_4e9f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4ea2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_4ea4, 5); mov(memw[ss, bp - 0x4], 0x2e20);          /* mov word [bp-0x4], 0x2e20 */
            ii(0x17_4ea9, 5); mov(memw[ss, bp - 0x2], 0x3e58);          /* mov word [bp-0x2], 0x3e58 */
            ii(0x17_4eae, 3); mov(ax, 0x400);                           /* mov ax, 0x400 */
            ii(0x17_4eb1, 2); @int(0x31);                               /* int 0x31 */
            ii(0x17_4eb3, 3); mov(memw[ds, 0x1f58], ax);                /* mov [0x1f58], ax */
            ii(0x17_4eb6, 4); mov(memw[ds, 0x1f5a], bx);                /* mov [0x1f5a], bx */
            ii(0x17_4eba, 4); mov(memw[ds, 0x1f5c], cx);                /* mov [0x1f5c], cx */
            ii(0x17_4ebe, 4); mov(memw[ds, 0x1f5e], dx);                /* mov [0x1f5e], dx */
            ii(0x17_4ec2, 3); call(0x17_4d3a, -0x18b);                  /* call 0x4d3a */
            ii(0x17_4ec5, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4ec7, 2); if(jz(0x17_4eda, 0x11)) goto l_0x17_4eda; /* jz 0x4eda */
            ii(0x17_4ec9, 3); push(0x946);                              /* push 0x946 */
            ii(0x17_4ecc, 1); push(cs);                                 /* push cs */
            ii(0x17_4ecd, 3); call(0x17_75b4, 0x26e4);                  /* call 0x75b4 */
            ii(0x17_4ed0, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_4ed3, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4ed6, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4ed7, 1); leave();                                  /* leave */
            ii(0x17_4ed8, 1); retf(); return;                           /* retf */
        //  ii(0x17_4ed9, 1); Недостижимый код.
        l_0x17_4eda:
            ii(0x17_4eda, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_4edc, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4edd, 1); leave();                                  /* leave */
            ii(0x17_4ede, 1); retf();                                   /* retf */
        }
    }
}
