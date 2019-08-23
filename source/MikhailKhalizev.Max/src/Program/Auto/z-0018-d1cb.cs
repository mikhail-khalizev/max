using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d1cb-d2b0f249")]
        public void Method_0018_d1cb()
        {
            ii(0x18_d1cb, 4); enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x18_d1cf, 3); lea(ax, memw[ss, bp - 0xa]);              /* lea ax, [bp-0xa] */
            ii(0x18_d1d2, 1); push(ax);                                 /* push ax */
            ii(0x18_d1d3, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x18_d1d6, 3); call(0x18_dc8e, 0xab5);                   /* call 0xdc8e */
            ii(0x18_d1d9, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d1da, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d1db, 3); mov(al, memb[ss, bp - 0x2]);              /* mov al, [bp-0x2] */
            ii(0x18_d1de, 2); and(al, 0x18);                            /* and al, 0x18 */
            ii(0x18_d1e0, 2); cmp(al, 0x10);                            /* cmp al, 0x10 */
            ii(0x18_d1e2, 2); if(jnz(0x18_d1fe, 0x1a)) goto l_0x18_d1fe; /* jnz 0xd1fe */
            ii(0x18_d1e4, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x18_d1e7, 3); cmp(memw[ss, bp + 0x4], ax);              /* cmp [bp+0x4], ax */
            ii(0x18_d1ea, 2); if(ja(0x18_d1fe, 0x12)) goto l_0x18_d1fe; /* ja 0xd1fe */
            ii(0x18_d1ec, 3); push(0x92);                               /* push 0x92 */
            ii(0x18_d1ef, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x18_d1f2, 3); call(0x18_d0ac, -0x149);                  /* call 0xd0ac */
            ii(0x18_d1f5, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d1f6, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d1f7, 3); mov(memw[ss, bp + 0x6], ax);              /* mov [bp+0x6], ax */
            ii(0x18_d1fa, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_d1fc, 2); if(jnz(0x18_d202, 0x4)) goto l_0x18_d202; /* jnz 0xd202 */
        l_0x18_d1fe:
            ii(0x18_d1fe, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_d200, 1); leave();                                  /* leave */
            ii(0x18_d201, 1); ret(); return;                            /* ret */
        l_0x18_d202:
            ii(0x18_d202, 3); lea(ax, memw[ss, bp - 0xa]);              /* lea ax, [bp-0xa] */
            ii(0x18_d205, 1); push(ax);                                 /* push ax */
            ii(0x18_d206, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x18_d209, 3); call(0x18_dc8e, 0xa82);                   /* call 0xdc8e */
            ii(0x18_d20c, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d20d, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d20e, 3); dec(memw[ss, bp + 0x8]);                  /* dec word [bp+0x8] */
            ii(0x18_d211, 3); mov(ax, memw[ss, bp + 0x8]);              /* mov ax, [bp+0x8] */
            ii(0x18_d214, 3); mov(cx, memw[ss, bp + 0x4]);              /* mov cx, [bp+0x4] */
            ii(0x18_d217, 3); sub(memw[ss, bp - 0x6], cx);              /* sub [bp-0x6], cx */
            ii(0x18_d21a, 3); cmp(memw[ss, bp - 0x6], ax);              /* cmp [bp-0x6], ax */
            ii(0x18_d21d, 2); if(jbe(0x18_d222, 0x3)) goto l_0x18_d222; /* jbe 0xd222 */
            ii(0x18_d21f, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
        l_0x18_d222:
            ii(0x18_d222, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x18_d224, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x18_d226, 3); add(memw[ss, bp - 0xa], ax);              /* add [bp-0xa], ax */
            ii(0x18_d229, 3); adc(memw[ss, bp - 0x8], dx);              /* adc [bp-0x8], dx */
            ii(0x18_d22c, 3); lea(ax, memw[ss, bp - 0xa]);              /* lea ax, [bp-0xa] */
            ii(0x18_d22f, 1); push(ax);                                 /* push ax */
            ii(0x18_d230, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x18_d233, 3); call(0x18_dc28, 0x9f2);                   /* call 0xdc28 */
            ii(0x18_d236, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d237, 1); pop(bx);                                  /* pop bx */
            ii(0x18_d238, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x18_d23b, 1); leave();                                  /* leave */
            ii(0x18_d23c, 1); ret();                                    /* ret */
        }
    }
}
