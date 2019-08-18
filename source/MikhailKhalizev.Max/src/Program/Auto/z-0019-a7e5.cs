using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_a7e5-2d2f82d8")]
        public void Method_0019_a7e5()
        {
            ii(0x19_a7e5, 4); enterw(0x12, 0);                          /* enter 0x12, 0x0 */
            ii(0x19_a7e9, 1); pushw(si);                                /* push si */
            ii(0x19_a7ea, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_a7ed, 4); mov(ax, memw_a16[es, bx + 0x1c]);         /* mov ax, [es:bx+0x1c] */
            ii(0x19_a7f1, 4); mov(dx, memw_a16[es, bx + 0x1e]);         /* mov dx, [es:bx+0x1e] */
            ii(0x19_a7f5, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_a7f8, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x19_a7fb, 4); mov(ax, memw_a16[es, bx + 0x3c]);         /* mov ax, [es:bx+0x3c] */
            ii(0x19_a7ff, 4); mov(dx, memw_a16[es, bx + 0x3e]);         /* mov dx, [es:bx+0x3e] */
            ii(0x19_a803, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x19_a806, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x19_a809, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_a80b, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_a80e, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_a811, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_a814, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_a817, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x19_a81a, 2); jmpw(0x19_a834, 0x18); goto l_0x19_a834;  /* jmp 0xa834 */
        l_0x19_a81c:
            ii(0x19_a81c, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x19_a81f, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x19_a822, 3); add(ax, 0xfff);                           /* add ax, 0xfff */
            ii(0x19_a825, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x19_a828, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x19_a82b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_a82e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x19_a831:
            ii(0x19_a831, 3); inc(memw_a16[ss, bp - 0x12]);             /* inc word [bp-0x12] */
        l_0x19_a834:
            ii(0x19_a834, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x19_a837, 3); les(bx, ss, bp - 0x10);                   /* les bx, [bp-0x10] */
            ii(0x19_a83a, 4); cmp(memw_a16[es, bx + 0x44], ax);         /* cmp [es:bx+0x44], ax */
            ii(0x19_a83e, 2); if(jbew(0x19_a886, 0x46)) goto l_0x19_a886; /* jbe 0xa886 */
            ii(0x19_a840, 3); imul(bx, ax, 0x18);                       /* imul bx, ax, 0x18 */
            ii(0x19_a843, 3); les(si, ss, bp - 0xc);                    /* les si, [bp-0xc] */
            ii(0x19_a846, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x19_a849, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x19_a84d, 3); add(memw_a16[ss, bp - 0x4], ax);          /* add [bp-0x4], ax */
            ii(0x19_a850, 3); adc(memw_a16[ss, bp - 0x2], dx);          /* adc [bp-0x2], dx */
            ii(0x19_a853, 2); add(bx, si);                              /* add bx, si */
            ii(0x19_a855, 5); test(memb_a16[es, bx + 0x8], 0x4);        /* test byte [es:bx+0x8], 0x4 */
            ii(0x19_a85a, 2); if(jzw(0x19_a81c, -0x40)) goto l_0x19_a81c; /* jz 0xa81c */
            ii(0x19_a85c, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x19_a85e, 3); les(si, ss, bp - 0x10);                   /* les si, [bp-0x10] */
            ii(0x19_a861, 5); test(memb_a16[es, si + 0x10], 0x10);      /* test byte [es:si+0x10], 0x10 */
            ii(0x19_a866, 2); if(jzw(0x19_a878, 0x10)) goto l_0x19_a878; /* jz 0xa878 */
            ii(0x19_a868, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x19_a86a, 4); add(ax, memw_a16[es, bx + 0x4]);          /* add ax, [es:bx+0x4] */
            ii(0x19_a86e, 4); adc(dx, memw_a16[es, bx + 0x6]);          /* adc dx, [es:bx+0x6] */
            ii(0x19_a872, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_a875, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x19_a878:
            ii(0x19_a878, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x19_a87b, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x19_a87e, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_a881, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x19_a884, 2); jmpw(0x19_a831, -0x55); goto l_0x19_a831; /* jmp 0xa831 */
        l_0x19_a886:
            ii(0x19_a886, 5); test(memb_a16[es, bx + 0x10], 0x10);      /* test byte [es:bx+0x10], 0x10 */
            ii(0x19_a88b, 2); if(jzw(0x19_a89e, 0x11)) goto l_0x19_a89e; /* jz 0xa89e */
            ii(0x19_a88d, 3); les(bx, ss, bp - 0xc);                    /* les bx, [bp-0xc] */
            ii(0x19_a890, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x19_a894, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x19_a898, 3); sub(memw_a16[ss, bp - 0x8], ax);          /* sub [bp-0x8], ax */
            ii(0x19_a89b, 3); sbb(memw_a16[ss, bp - 0x6], dx);          /* sbb [bp-0x6], dx */
        l_0x19_a89e:
            ii(0x19_a89e, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x19_a8a1, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x19_a8a4, 1); popw(si);                                 /* pop si */
            ii(0x19_a8a5, 1); leavew();                                 /* leave */
            ii(0x19_a8a6, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
