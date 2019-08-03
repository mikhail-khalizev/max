using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("333632fd-6b3b-4319-95a7-fcc789dca080")]
        public void Method_0015_f76f()
        {
            ii(0x15_f76f, 4); enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0x15_f773, 1); pushw(di);                                /* push di */
            ii(0x15_f774, 1); pushw(si);                                /* push si */
            ii(0x15_f775, 5); mov(memw_a16[ss, bp - 0x4], 0xa1d4);      /* mov word [bp-0x4], 0xa1d4 */
            ii(0x15_f77a, 5); mov(memw_a16[ss, bp - 0x2], 0x88);        /* mov word [bp-0x2], 0x88 */
            ii(0x15_f77f, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_f782, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_f785, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_f788, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_f78b, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x15_f790, 3); lea(ax, bp - 0xc);                        /* lea ax, [bp-0xc] */
            ii(0x15_f793, 1); pushw(ss);                                /* push ss */
            ii(0x15_f794, 1); pushw(ax);                                /* push ax */
            ii(0x15_f795, 2); pushw(0x24);                              /* push 0x24 */
            ii(0x15_f797, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x15_f79c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_f79f, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_f7a2, 3); mov(si, memw_a16[ss, bp - 0x6]);          /* mov si, [bp-0x6] */
            ii(0x15_f7a5, 3); and(si, -0x8 /* 0xf8 */);                 /* and si, 0xfff8 */
            ii(0x15_f7a8, 4); mov(es, memw_a16[ds, 0x3fd8]);            /* mov es, [0x3fd8] */
            ii(0x15_f7ac, 5); les(bx, es, 0x122);                       /* les bx, [es:0x122] */
            ii(0x15_f7b1, 4); mov(memb_a16[es, bx + si], 0x3);          /* mov byte [es:bx+si], 0x3 */
            ii(0x15_f7b5, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_f7b7, 2); pushw(0x24);                              /* push 0x24 */
            ii(0x15_f7b9, 1); nop();                                    /* nop */
            ii(0x15_f7ba, 1); pushw(cs);                                /* push cs */
            ii(0x15_f7bb, 3); callw(0x16_606f, 0x68b1);                 /* call 0x606f */
            ii(0x15_f7be, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_f7c1, 1); popw(si);                                 /* pop si */
            ii(0x15_f7c2, 1); popw(di);                                 /* pop di */
            ii(0x15_f7c3, 1); leavew();                                 /* leave */
            ii(0x15_f7c4, 1); retfw(); return;                          /* retf */
        }
    }
}
