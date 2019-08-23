using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4a6c-f86f29ad")]
        public void Method_0019_4a6c()
        {
            ii(0x19_4a6c, 4); enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x19_4a70, 1); push(ds);                                 /* push ds */
            ii(0x19_4a71, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_4a74, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_4a76, 5); mov(memw[ss, bp - 0x4], 0xffff);          /* mov word [bp-0x4], 0xffff */
            ii(0x19_4a7b, 5); mov(memw[ss, bp - 0x2], 0xffff);          /* mov word [bp-0x2], 0xffff */
            ii(0x19_4a80, 3); lea(ax, memw[ss, bp - 0xc]);              /* lea ax, [bp-0xc] */
            ii(0x19_4a83, 1); push(ss);                                 /* push ss */
            ii(0x19_4a84, 1); push(ax);                                 /* push ax */
            ii(0x19_4a85, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_4a88, 1); nop();                                    /* nop */
            ii(0x19_4a89, 1); push(cs);                                 /* push cs */
            ii(0x19_4a8a, 3); call(0x19_4412, -0x67b);                  /* call 0x4412 */
            ii(0x19_4a8d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_4a90, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_4a92, 2); if(jz(0x19_4ab3, 0x1f)) goto l_0x19_4ab3; /* jz 0x4ab3 */
            ii(0x19_4a94, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x19_4a97, 2); sub(al, al);                              /* sub al, al */
            ii(0x19_4a99, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x19_4a9b, 3); mov(cx, memw[ss, bp - 0xa]);              /* mov cx, [bp-0xa] */
            ii(0x19_4a9e, 3); mov(bx, memw[ss, bp - 0x8]);              /* mov bx, [bp-0x8] */
            ii(0x19_4aa1, 2); sub(bh, bh);                              /* sub bh, bh */
            ii(0x19_4aa3, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x19_4aa5, 2); or(dx, bx);                               /* or dx, bx */
            ii(0x19_4aa7, 3); add(ax, memw[ss, bp + 0x6]);              /* add ax, [bp+0x6] */
            ii(0x19_4aaa, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x19_4aad, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_4ab0, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
        l_0x19_4ab3:
            ii(0x19_4ab3, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x19_4ab6, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x19_4ab9, 1); pop(ds);                                  /* pop ds */
            ii(0x19_4aba, 1); leave();                                  /* leave */
            ii(0x19_4abb, 1); retf();                                   /* retf */
        }
    }
}
