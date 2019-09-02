using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0708-33e814bb")]
        public void Method_0018_0708()
        {
            ii(0x18_0708, 4); enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x18_070c, 1); push(ds);                                 /* push ds */
            ii(0x18_070d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_0710, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_0712, 5); mov(memw[ss, bp - 0x14], 0);              /* mov word [bp-0x14], 0x0 */
            ii(0x18_0717, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x18_071a, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x18_071d, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x18_0720, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x18_0723, 3); mov(al, memb[ss, bp + 6]);                /* mov al, [bp+0x6] */
            ii(0x18_0726, 2); mov(ah, 0x3d);                            /* mov ah, 0x3d */
            ii(0x18_0728, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x18_072b, 3); lea(cx, memw[ss, bp - 0x16]);             /* lea cx, [bp-0x16] */
            ii(0x18_072e, 1); push(ss);                                 /* push ss */
            ii(0x18_072f, 1); push(cx);                                 /* push cx */
            ii(0x18_0730, 1); push(ax);                                 /* push ax */
            ii(0x18_0731, 1); nop();                                    /* nop */
            ii(0x18_0732, 1); push(cs);                                 /* push cs */
            ii(0x18_0733, 3); call(0x17_eaed, -0x1c49);                 /* call 0xeaed */
            ii(0x18_0736, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x18_0739, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_073b, 2); if(jz(0x18_0742, 5)) goto l_0x18_0742;    /* jz 0x742 */
            ii(0x18_073d, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x18_0740, 2); jmp(0x18_0745, 3); goto l_0x18_0745;      /* jmp 0x745 */
        l_0x18_0742:
            ii(0x18_0742, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x18_0745:
            ii(0x18_0745, 1); pop(ds);                                  /* pop ds */
            ii(0x18_0746, 1); leave();                                  /* leave */
            ii(0x18_0747, 3); retf(6);                                  /* retf 0x6 */
        }
    }
}
