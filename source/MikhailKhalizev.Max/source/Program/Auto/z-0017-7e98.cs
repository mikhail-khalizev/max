using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7e98-fe32217d")]
        public void Method_0017_7e98()
        {
            ii(0x17_7e98, 1);  push(bp);                               /* push bp */
            ii(0x17_7e99, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_7e9b, 1);  push(si);                               /* push si */
            ii(0x17_7e9c, 1);  push(ds);                               /* push ds */
            ii(0x17_7e9d, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_7ea0, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_7ea2, 4);  les(bx, memw[ds, 0x4f9c]);              /* les bx, [0x4f9c] */
            ii(0x17_7ea6, 3);  mov(si, memw[ss, bp + 6]);              /* mov si, [bp+0x6] */
            ii(0x17_7ea9, 4);  test(memb[es, bx + si], 0x80);          /* test byte [es:bx+si], 0x80 */
            ii(0x17_7ead, 2);  if(jz(0x17_7ec2, 0x13)) goto l_0x17_7ec2;/* jz 0x7ec2 */
            ii(0x17_7eaf, 3);  mov(al, memb[es, bx + si]);             /* mov al, [es:bx+si] */
            ii(0x17_7eb2, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x17_7eb4, 2);  inc(al);                                /* inc al */
            ii(0x17_7eb6, 2);  xor(cl, al);                            /* xor cl, al */
            ii(0x17_7eb8, 3);  and(cl, 0x7f);                          /* and cl, 0x7f */
            ii(0x17_7ebb, 3);  xor(memb[es, bx + si], cl);             /* xor [es:bx+si], cl */
            ii(0x17_7ebe, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7ebf, 1);  pop(si);                                /* pop si */
            ii(0x17_7ec0, 1);  leave();                                /* leave */
            ii(0x17_7ec1, 1);  retf(); return;                         /* retf */
        l_0x17_7ec2:
            ii(0x17_7ec2, 5);  sub(memw[ds, 0x1fb0], 1);               /* sub word [0x1fb0], 0x1 */
            ii(0x17_7ec7, 5);  sbb(memw[ds, 0x1fb2], 0);               /* sbb word [0x1fb2], 0x0 */
            ii(0x17_7ecc, 5);  sub(memw[ds, 0x1fb8], 1);               /* sub word [0x1fb8], 0x1 */
            ii(0x17_7ed1, 5);  sbb(memw[ds, 0x1fba], 0);               /* sbb word [0x1fba], 0x0 */
            ii(0x17_7ed6, 4);  or(memb[es, bx + si], -0x80 /* 0x80 */);/* or byte [es:bx+si], 0x80 */
            ii(0x17_7eda, 4);  les(bx, memw[ds, 0x4f9c]);              /* les bx, [0x4f9c] */
            ii(0x17_7ede, 4);  and(memb[es, bx + si], -0x80 /* 0x80 */);/* and byte [es:bx+si], 0x80 */
            ii(0x17_7ee2, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7ee3, 1);  pop(si);                                /* pop si */
            ii(0x17_7ee4, 1);  leave();                                /* leave */
            ii(0x17_7ee5, 1);  retf();                                 /* retf */
        }
    }
}
