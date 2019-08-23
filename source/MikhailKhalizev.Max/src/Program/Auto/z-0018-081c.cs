using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_081c-2d0f2e6c")]
        public void Method_0018_081c()
        {
            ii(0x18_081c, 4); enter(0x14, 0);                           /* enter 0x14, 0x0 */
            ii(0x18_0820, 1); push(ds);                                 /* push ds */
            ii(0x18_0821, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0824, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0826, 5); mov(memw[ss, bp - 0x12], 0);              /* mov word [bp-0x12], 0x0 */
            ii(0x18_082b, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x18_082e, 3); mov(memw[ss, bp - 0x14], ax);             /* mov [bp-0x14], ax */
            ii(0x18_0831, 3); mov(ax, memw[ss, bp + 0x8]);              /* mov ax, [bp+0x8] */
            ii(0x18_0834, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x18_0837, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x18_083a, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_083d, 3); mov(ax, memw[ss, bp + 0xc]);              /* mov ax, [bp+0xc] */
            ii(0x18_0840, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x18_0843, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x18_0846, 1); push(ss);                                 /* push ss */
            ii(0x18_0847, 1); push(ax);                                 /* push ax */
            ii(0x18_0848, 3); push(0x3f00);                             /* push 0x3f00 */
            ii(0x18_084b, 1); nop();                                    /* nop */
            ii(0x18_084c, 1); push(cs);                                 /* push cs */
            ii(0x18_084d, 3); call(0x17_eaed, -0x1d63);                 /* call 0xeaed */
            ii(0x18_0850, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_0853, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_0855, 2); if(jz(0x18_085c, 0x5)) goto l_0x18_085c;  /* jz 0x85c */
            ii(0x18_0857, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x18_085a, 2); jmp(0x18_085f, 0x3); goto l_0x18_085f;    /* jmp 0x85f */
        l_0x18_085c:
            ii(0x18_085c, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x18_085f:
            ii(0x18_085f, 1); pop(ds);                                  /* pop ds */
            ii(0x18_0860, 1); leave();                                  /* leave */
            ii(0x18_0861, 3); retf(0x8);                                /* retf 0x8 */
        }
    }
}
