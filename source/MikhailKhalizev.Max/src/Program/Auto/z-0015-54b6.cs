using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3dca2e66-4bcf-4b21-a880-f4d127a65048")]
        public void Method_0015_54b6()
        {
            ii(0x15_54b6, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_54ba, 1); pushw(di);                                /* push di */
            ii(0x15_54bb, 1); pushw(si);                                /* push si */
            ii(0x15_54bc, 4); mov(memb_a16[ss, bp - 0x2], 0);           /* mov byte [bp-0x2], 0x0 */
            ii(0x15_54c0, 5); mov(memw_a16[ss, bp - 0x4], 0x1);         /* mov word [bp-0x4], 0x1 */
            ii(0x15_54c5, 3); jmpw(0x15_54ce, 0x6); goto l_0x15_54ce;   /* jmp 0x54ce */
        l_0x15_54c8:
            ii(0x15_54c8, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x15_54cb, 3); inc(memw_a16[ss, bp + 0x4]);              /* inc word [bp+0x4] */
        l_0x15_54ce:
            ii(0x15_54ce, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_54d1, 3); cmp(memw_a16[ss, bp + 0xc], ax);          /* cmp [bp+0xc], ax */
            ii(0x15_54d4, 2); if(jgw(0x15_54d9, 0x3)) goto l_0x15_54d9; /* jg 0x54d9 */
            ii(0x15_54d6, 3); jmpw(0x15_5518, 0x3f); goto l_0x15_5518;  /* jmp 0x5518 */
        l_0x15_54d9:
            ii(0x15_54d9, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_54dc, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_54df, 3); mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x15_54e2, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x15_54e5, 3); les(si, ss, bp + 0x8);                    /* les si, [bp+0x8] */
            ii(0x15_54e8, 4); pushw(memw_a16[es, bx + si + 0x2]);       /* push word [es:bx+si+0x2] */
            ii(0x15_54ec, 3); pushw(memw_a16[es, bx + si]);             /* push word [es:bx+si] */
            ii(0x15_54ef, 3); callw(0x14_ff6c, -0x5586);                /* call 0xff6c */
            ii(0x15_54f2, 3); mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x15_54f5, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x15_54f8, 3); les(si, ss, bp + 0x8);                    /* les si, [bp+0x8] */
            ii(0x15_54fb, 4); pushw(memw_a16[es, bx + si + 0x2]);       /* push word [es:bx+si+0x2] */
            ii(0x15_54ff, 3); pushw(memw_a16[es, bx + si]);             /* push word [es:bx+si] */
            ii(0x15_5502, 3); callw(0x14_ff2f, -0x55d6);                /* call 0xff2f */
            ii(0x15_5505, 3); add(memw_a16[ss, bp + 0x4], ax);          /* add [bp+0x4], ax */
            ii(0x15_5508, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x15_550b, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_550e, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x15_5511, 4); mov(memb_a16[ss, bp - 0x2], 0x20);        /* mov byte [bp-0x2], 0x20 */
            ii(0x15_5515, 3); jmpw(0x15_54c8, -0x50); goto l_0x15_54c8; /* jmp 0x54c8 */
        l_0x15_5518:
            ii(0x15_5518, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_551b, 3); inc(memw_a16[ss, bp + 0x4]);              /* inc word [bp+0x4] */
            ii(0x15_551e, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x15_5522, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_5525, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x15_5529, 1); popw(si);                                 /* pop si */
            ii(0x15_552a, 1); popw(di);                                 /* pop di */
            ii(0x15_552b, 1); leavew();                                 /* leave */
            ii(0x15_552c, 3); retw(0xa); return;                        /* ret 0xa */
        }
    }
}
