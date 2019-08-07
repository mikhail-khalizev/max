using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("519c5d99-1757-46eb-bd55-1eabcd1be27a")]
        public void Method_0014_d1cb()
        {
            ii(0x14_d1cb, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x14_d1cf, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x14_d1d2, 1); pushw(ax);                                /* push ax */
            ii(0x14_d1d3, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_d1d6, 3); callw(0x14_dc8e, 0xab5);                  /* call 0xdc8e */
            ii(0x14_d1d9, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d1da, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d1db, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x14_d1de, 2); and(al, 0x18);                            /* and al, 0x18 */
            ii(0x14_d1e0, 2); cmp(al, 0x10);                            /* cmp al, 0x10 */
            ii(0x14_d1e2, 2); if(jnzw(0x14_d1fe, 0x1a)) goto l_0x14_d1fe; /* jnz 0xd1fe */
            ii(0x14_d1e4, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x14_d1e7, 3); cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0x14_d1ea, 2); if(jaw(0x14_d1fe, 0x12)) goto l_0x14_d1fe; /* ja 0xd1fe */
            ii(0x14_d1ec, 3); pushw(0x92);                              /* push 0x92 */
            ii(0x14_d1ef, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_d1f2, 3); callw(0x14_d0ac, -0x149);                 /* call 0xd0ac */
            ii(0x14_d1f5, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d1f6, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d1f7, 3); mov(memw_a16[ss, bp + 0x6], ax);          /* mov [bp+0x6], ax */
            ii(0x14_d1fa, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_d1fc, 2); if(jnzw(0x14_d202, 0x4)) goto l_0x14_d202; /* jnz 0xd202 */
        l_0x14_d1fe:
            ii(0x14_d1fe, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x14_d200, 1); leavew();                                 /* leave */
            ii(0x14_d201, 1); retw(); return;                           /* ret */
        l_0x14_d202:
            ii(0x14_d202, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x14_d205, 1); pushw(ax);                                /* push ax */
            ii(0x14_d206, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_d209, 3); callw(0x14_dc8e, 0xa82);                  /* call 0xdc8e */
            ii(0x14_d20c, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d20d, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d20e, 3); dec(memw_a16[ss, bp + 0x8]);              /* dec word [bp+0x8] */
            ii(0x14_d211, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x14_d214, 3); mov(cx, memw_a16[ss, bp + 0x4]);          /* mov cx, [bp+0x4] */
            ii(0x14_d217, 3); sub(memw_a16[ss, bp - 0x6], cx);          /* sub [bp-0x6], cx */
            ii(0x14_d21a, 3); cmp(memw_a16[ss, bp - 0x6], ax);          /* cmp [bp-0x6], ax */
            ii(0x14_d21d, 2); if(jbew(0x14_d222, 0x3)) goto l_0x14_d222; /* jbe 0xd222 */
            ii(0x14_d21f, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
        l_0x14_d222:
            ii(0x14_d222, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x14_d224, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x14_d226, 3); add(memw_a16[ss, bp - 0xa], ax);          /* add [bp-0xa], ax */
            ii(0x14_d229, 3); adc(memw_a16[ss, bp - 0x8], dx);          /* adc [bp-0x8], dx */
            ii(0x14_d22c, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x14_d22f, 1); pushw(ax);                                /* push ax */
            ii(0x14_d230, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_d233, 3); callw(0x14_dc28, 0x9f2);                  /* call 0xdc28 */
            ii(0x14_d236, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d237, 1); popw(bx);                                 /* pop bx */
            ii(0x14_d238, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x14_d23b, 1); leavew();                                 /* leave */
            ii(0x14_d23c, 1); retw(); return;                           /* ret */
        }
    }
}
