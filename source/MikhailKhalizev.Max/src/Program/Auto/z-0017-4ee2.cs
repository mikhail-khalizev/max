using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4ee2-f541f20")]
        public void Method_0017_4ee2()
        {
            ii(0x17_4ee2, 4); enter(0x6, 0);                            /* enter 0x6, 0x0 */
            ii(0x17_4ee6, 1); push(ds);                                 /* push ds */
            ii(0x17_4ee7, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4eea, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_4eec, 5); mov(memw[ss, bp - 0x2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x17_4ef1, 2); mov(ah, 0xff);                            /* mov ah, 0xff */
            ii(0x17_4ef3, 2); mov(dh, 0x1a);                            /* mov dh, 0x1a */
            ii(0x17_4ef5, 3); mov(dl, memb[ss, bp + 0x6]);              /* mov dl, [bp+0x6] */
            ii(0x17_4ef8, 3); mov(bx, memw[ss, bp + 0xa]);              /* mov bx, [bp+0xa] */
            ii(0x17_4efb, 3); mov(cx, memw[ss, bp + 0x8]);              /* mov cx, [bp+0x8] */
            ii(0x17_4efe, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_4f00, 2); if(jae(0x17_4f07, 0x5)) goto l_0x17_4f07; /* jae 0x4f07 */
            ii(0x17_4f02, 5); mov(memw[ss, bp - 0x2], 0x1);             /* mov word [bp-0x2], 0x1 */
        l_0x17_4f07:
            ii(0x17_4f07, 3); mov(memw[ss, bp - 0x6], cx);              /* mov [bp-0x6], cx */
            ii(0x17_4f0a, 3); mov(memw[ss, bp - 0x4], bx);              /* mov [bp-0x4], bx */
            ii(0x17_4f0d, 3); mov(ax, memw[ss, bp + 0xe]);              /* mov ax, [bp+0xe] */
            ii(0x17_4f10, 3); or(ax, memw[ss, bp + 0xc]);               /* or ax, [bp+0xc] */
            ii(0x17_4f13, 2); if(jz(0x17_4f25, 0x10)) goto l_0x17_4f25; /* jz 0x4f25 */
            ii(0x17_4f15, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x17_4f18, 3); mov(dx, memw[ss, bp - 0x4]);              /* mov dx, [bp-0x4] */
            ii(0x17_4f1b, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x17_4f1e, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x17_4f21, 4); mov(memw[es, bx + 0x2], dx);              /* mov [es:bx+0x2], dx */
        l_0x17_4f25:
            ii(0x17_4f25, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x17_4f28, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4f29, 1); leave();                                  /* leave */
            ii(0x17_4f2a, 1); retf();                                   /* retf */
        }
    }
}
