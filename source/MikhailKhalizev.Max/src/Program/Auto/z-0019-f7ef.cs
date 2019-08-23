using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f7ef-4c1de174")]
        public void Method_0019_f7ef()
        {
            ii(0x19_f7ef, 4); enter(0xc, 0);                            /* enter 0xc, 0x0 */
            ii(0x19_f7f3, 1); push(di);                                 /* push di */
            ii(0x19_f7f4, 1); push(si);                                 /* push si */
            ii(0x19_f7f5, 4); cmp(memw[ss, bp + 0x8], 0);               /* cmp word [bp+0x8], 0x0 */
            ii(0x19_f7f9, 2); if(jnz(0x19_f7fe, 0x3)) goto l_0x19_f7fe; /* jnz 0xf7fe */
            ii(0x19_f7fb, 3); jmp(0x19_f83f, 0x41); goto l_0x19_f83f;   /* jmp 0xf83f */
        l_0x19_f7fe:
            ii(0x19_f7fe, 5); mov(memw[ss, bp - 0x4], 0xa3a6);          /* mov word [bp-0x4], 0xa3a6 */
            ii(0x19_f803, 5); mov(memw[ss, bp - 0x2], 0x88);            /* mov word [bp-0x2], 0x88 */
            ii(0x19_f808, 3); mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x19_f80b, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_f80e, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x19_f811, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x19_f814, 5); mov(memw[ss, bp - 0xa], 0);               /* mov word [bp-0xa], 0x0 */
            ii(0x19_f819, 3); lea(ax, bp - 0xc);                        /* lea ax, [bp-0xc] */
            ii(0x19_f81c, 1); push(ss);                                 /* push ss */
            ii(0x19_f81d, 1); push(ax);                                 /* push ax */
            ii(0x19_f81e, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_f821, 5); call_far_abs(0x80, 0xb38);                /* call word 0x80:0xb38 */
            ii(0x19_f826, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_f829, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x19_f82c, 3); mov(si, memw[ss, bp - 0x6]);              /* mov si, [bp-0x6] */
            ii(0x19_f82f, 3); and(si, -0x8 /* 0xf8 */);                 /* and si, 0xfff8 */
            ii(0x19_f832, 4); mov(es, memw[ds, 0x3fda]);                /* mov es, [0x3fda] */
            ii(0x19_f836, 5); les(bx, es, 0x122);                       /* les bx, [es:0x122] */
            ii(0x19_f83b, 4); mov(memb[es, bx + si], 0x3);              /* mov byte [es:bx+si], 0x3 */
        l_0x19_f83f:
            ii(0x19_f83f, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_f841, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_f844, 1); nop();                                    /* nop */
            ii(0x19_f845, 1); push(cs);                                 /* push cs */
            ii(0x19_f846, 3); call(0x1a_606f, 0x6826);                  /* call 0x606f */
            ii(0x19_f849, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_f84c, 1); pop(si);                                  /* pop si */
            ii(0x19_f84d, 1); pop(di);                                  /* pop di */
            ii(0x19_f84e, 1); leave();                                  /* leave */
            ii(0x19_f84f, 1); retf();                                   /* retf */
        }
    }
}
