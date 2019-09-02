using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_54b6-e7397d31")]
        public void Method_0019_54b6()
        {
            ii(0x19_54b6, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x19_54ba, 1); push(di);                                 /* push di */
            ii(0x19_54bb, 1); push(si);                                 /* push si */
            ii(0x19_54bc, 4); mov(memb[ss, bp - 2], 0);                 /* mov byte [bp-0x2], 0x0 */
            ii(0x19_54c0, 5); mov(memw[ss, bp - 4], 1);                 /* mov word [bp-0x4], 0x1 */
            ii(0x19_54c5, 3); jmp(0x19_54ce, 6); goto l_0x19_54ce;      /* jmp 0x54ce */
        l_0x19_54c8:
            ii(0x19_54c8, 3); inc(memw[ss, bp - 4]);                    /* inc word [bp-0x4] */
            ii(0x19_54cb, 3); inc(memw[ss, bp + 4]);                    /* inc word [bp+0x4] */
        l_0x19_54ce:
            ii(0x19_54ce, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x19_54d1, 3); cmp(memw[ss, bp + 0xc], ax);              /* cmp [bp+0xc], ax */
            ii(0x19_54d4, 2); if(jg(0x19_54d9, 3)) goto l_0x19_54d9;    /* jg 0x54d9 */
            ii(0x19_54d6, 3); jmp(0x19_5518, 0x3f); goto l_0x19_5518;   /* jmp 0x5518 */
        l_0x19_54d9:
            ii(0x19_54d9, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_54dc, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_54df, 3); mov(bx, memw[ss, bp - 4]);                /* mov bx, [bp-0x4] */
            ii(0x19_54e2, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x19_54e5, 3); les(si, memw[ss, bp + 8]);                /* les si, [bp+0x8] */
            ii(0x19_54e8, 4); push(memw[es, bx + si + 2]);              /* push word [es:bx+si+0x2] */
            ii(0x19_54ec, 3); push(memw[es, bx + si]);                  /* push word [es:bx+si] */
            ii(0x19_54ef, 3); call(0x18_ff6c, -0x5586);                 /* call 0xff6c */
            ii(0x19_54f2, 3); mov(bx, memw[ss, bp - 4]);                /* mov bx, [bp-0x4] */
            ii(0x19_54f5, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x19_54f8, 3); les(si, memw[ss, bp + 8]);                /* les si, [bp+0x8] */
            ii(0x19_54fb, 4); push(memw[es, bx + si + 2]);              /* push word [es:bx+si+0x2] */
            ii(0x19_54ff, 3); push(memw[es, bx + si]);                  /* push word [es:bx+si] */
            ii(0x19_5502, 3); call(0x18_ff2f, -0x55d6);                 /* call 0xff2f */
            ii(0x19_5505, 3); add(memw[ss, bp + 4], ax);                /* add [bp+0x4], ax */
            ii(0x19_5508, 3); mov(al, memb[ss, bp - 2]);                /* mov al, [bp-0x2] */
            ii(0x19_550b, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x19_550e, 3); mov(memb[es, bx], al);                    /* mov [es:bx], al */
            ii(0x19_5511, 4); mov(memb[ss, bp - 2], 0x20);              /* mov byte [bp-0x2], 0x20 */
            ii(0x19_5515, 3); jmp(0x19_54c8, -0x50); goto l_0x19_54c8;  /* jmp 0x54c8 */
        l_0x19_5518:
            ii(0x19_5518, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x19_551b, 3); inc(memw[ss, bp + 4]);                    /* inc word [bp+0x4] */
            ii(0x19_551e, 4); mov(memb[es, bx], 0);                     /* mov byte [es:bx], 0x0 */
            ii(0x19_5522, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x19_5525, 4); mov(memb[es, bx], 0);                     /* mov byte [es:bx], 0x0 */
            ii(0x19_5529, 1); pop(si);                                  /* pop si */
            ii(0x19_552a, 1); pop(di);                                  /* pop di */
            ii(0x19_552b, 1); leave();                                  /* leave */
            ii(0x19_552c, 3); ret(0xa);                                 /* ret 0xa */
        }
    }
}
