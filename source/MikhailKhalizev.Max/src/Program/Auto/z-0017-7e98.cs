using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7e98-fe32217d")]
        public void Method_0017_7e98()
        {
            ii(0x17_7e98, 1); pushw(bp);                                /* push bp */
            ii(0x17_7e99, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_7e9b, 1); pushw(si);                                /* push si */
            ii(0x17_7e9c, 1); pushw(ds);                                /* push ds */
            ii(0x17_7e9d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7ea0, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7ea2, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7ea6, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x17_7ea9, 4); test(memb_a16[es, bx + si], 0x80);        /* test byte [es:bx+si], 0x80 */
            ii(0x17_7ead, 2); if(jzw(0x17_7ec2, 0x13)) goto l_0x17_7ec2; /* jz 0x7ec2 */
            ii(0x17_7eaf, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x17_7eb2, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x17_7eb4, 2); inc(al);                                  /* inc al */
            ii(0x17_7eb6, 2); xor(cl, al);                              /* xor cl, al */
            ii(0x17_7eb8, 3); and(cl, 0x7f);                            /* and cl, 0x7f */
            ii(0x17_7ebb, 3); xor(memb_a16[es, bx + si], cl);           /* xor [es:bx+si], cl */
            ii(0x17_7ebe, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7ebf, 1); popw(si);                                 /* pop si */
            ii(0x17_7ec0, 1); leavew();                                 /* leave */
            ii(0x17_7ec1, 1); retfw(); return;                          /* retf */
        l_0x17_7ec2:
            ii(0x17_7ec2, 5); sub(memw_a16[ds, 0x1fb0], 0x1);           /* sub word [0x1fb0], 0x1 */
            ii(0x17_7ec7, 5); sbb(memw_a16[ds, 0x1fb2], 0);             /* sbb word [0x1fb2], 0x0 */
            ii(0x17_7ecc, 5); sub(memw_a16[ds, 0x1fb8], 0x1);           /* sub word [0x1fb8], 0x1 */
            ii(0x17_7ed1, 5); sbb(memw_a16[ds, 0x1fba], 0);             /* sbb word [0x1fba], 0x0 */
            ii(0x17_7ed6, 4); or(memb_a16[es, bx + si], -0x80 /* 0x80 */); /* or byte [es:bx+si], 0x80 */
            ii(0x17_7eda, 4); les(bx, ds, 0x4f9c);                      /* les bx, [0x4f9c] */
            ii(0x17_7ede, 4); and(memb_a16[es, bx + si], -0x80 /* 0x80 */); /* and byte [es:bx+si], 0x80 */
            ii(0x17_7ee2, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7ee3, 1); popw(si);                                 /* pop si */
            ii(0x17_7ee4, 1); leavew();                                 /* leave */
            ii(0x17_7ee5, 1); retfw();                                  /* retf */
        }
    }
}
