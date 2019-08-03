using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d3e2849d-dd05-4e46-84ce-9ff6f7a5de00")]
        public void Method_0016_092a()
        {
            ii(0x16_092a, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x16_092e, 1); pushw(ds);                                /* push ds */
            ii(0x16_092f, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x16_0932, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0934, 5); mov(memw_a16[ss, bp - 0x2], 0x18);        /* mov word [bp-0x2], 0x18 */
            ii(0x16_0939, 1); pushw(ds);                                /* push ds */
            ii(0x16_093a, 3); lds(dx, ss, bp + 0x6);                    /* lds dx, [bp+0x6] */
            ii(0x16_093d, 3); mov(ax, 0x4300);                          /* mov ax, 0x4300 */
            ii(0x16_0940, 2); @int(0x21);                               /* int 0x21 */
            ii(0x16_0942, 2); if(jbw(0x16_0947, 0x3)) goto l_0x16_0947; /* jb 0x947 */
            ii(0x16_0944, 3); mov(memw_a16[ss, bp - 0x2], cx);          /* mov [bp-0x2], cx */
        l_0x16_0947:
            ii(0x16_0947, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0948, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x16_094b, 3); and(ax, 0x18);                            /* and ax, 0x18 */
            ii(0x16_094e, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x16_0951, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x16_0953, 2); neg(ax);                                  /* neg ax */
            ii(0x16_0955, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0956, 1); leavew();                                 /* leave */
            ii(0x16_0957, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}