using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ff6fcff1-1f85-4195-a87c-792f27263451")]
        public void Method_0015_0588()
        {
            ii(0x15_0588, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_058c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_058e, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_0591, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_0594, 1); pushw(ds);                                /* push ds */
            ii(0x15_0595, 1); pushw(es);                                /* push es */
            ii(0x15_0596, 2); mov(ah, 0xff);                            /* mov ah, 0xff */
            ii(0x15_0598, 2); mov(dh, 0x1a);                            /* mov dh, 0x1a */
            ii(0x15_059a, 3); mov(dl, memb_a16[ss, bp + 0x6]);          /* mov dl, [bp+0x6] */
            ii(0x15_059d, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x15_05a0, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x15_05a3, 2); @int(0x21);                               /* int 0x21 */
            ii(0x15_05a5, 2); if(jbw(0x15_05ad, 0x6)) goto l_0x15_05ad; /* jb 0x5ad */
            ii(0x15_05a7, 3); mov(memw_a16[ss, bp - 0x2], bx);          /* mov [bp-0x2], bx */
            ii(0x15_05aa, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
        l_0x15_05ad:
            ii(0x15_05ad, 1); popw(es);                                 /* pop es */
            ii(0x15_05ae, 1); popw(ds);                                 /* pop ds */
            ii(0x15_05af, 4); mov(es, memw_a16[ds, 0x3fb8]);            /* mov es, [0x3fb8] */
            ii(0x15_05b3, 4); mov(ax, memw_a16[es, 0x3b8c]);            /* mov ax, [es:0x3b8c] */
            ii(0x15_05b7, 3); cmp(memw_a16[ss, bp + 0xa], ax);          /* cmp [bp+0xa], ax */
            ii(0x15_05ba, 2); if(jbew(0x15_05e3, 0x27)) goto l_0x15_05e3; /* jbe 0x5e3 */
            ii(0x15_05bc, 3); mov(ax, 0xa);                             /* mov ax, 0xa */
            ii(0x15_05bf, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x15_05c2, 2); @int(0x31);                               /* int 0x31 */
            ii(0x15_05c4, 2); if(jbw(0x15_05e3, 0x1d)) goto l_0x15_05e3; /* jb 0x5e3 */
            ii(0x15_05c6, 3); mov(memw_a16[ss, bp + 0xa], ax);          /* mov [bp+0xa], ax */
            ii(0x15_05c9, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_05cc, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x15_05cf, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_05d2, 4); mov(memw_a16[es, bx - 0x2], dx);          /* mov [es:bx-0x2], dx */
            ii(0x15_05d6, 4); mov(memw_a16[es, bx - 0x4], ax);          /* mov [es:bx-0x4], ax */
            ii(0x15_05da, 2); mov(bx, es);                              /* mov bx, es */
            ii(0x15_05dc, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_05de, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x15_05e0, 1); inc(ax);                                  /* inc ax */
            ii(0x15_05e1, 2); @int(0x31);                               /* int 0x31 */
        l_0x15_05e3:
            ii(0x15_05e3, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_05e6, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x15_05e9, 1); leavew();                                 /* leave */
            ii(0x15_05ea, 1); retfw(); return;                          /* retf */
        }
    }
}
