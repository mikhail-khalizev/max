using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ea4c-516c238b")]
        public void Method_0017_ea4c()
        {
            ii(0x17_ea4c, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x17_ea50, 1); pushw(ds);                                /* push ds */
            ii(0x17_ea51, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_ea54, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_ea56, 3); mov(ax, memw_a16[ds, 0x1414]);            /* mov ax, [0x1414] */
            ii(0x17_ea59, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_ea5c, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x17_ea61, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ea64, 7); mov(memw_a16[es, bx + 0x7f2], 0);         /* mov word [es:bx+0x7f2], 0x0 */
            ii(0x17_ea6b, 3); lea(ax, bp + 0x6);                        /* lea ax, [bp+0x6] */
            ii(0x17_ea6e, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_ea71, 3); mov(memw_a16[ss, bp - 0x6], ss);          /* mov [bp-0x6], ss */
            ii(0x17_ea74, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ea77, 5); mov(memw_a16[es, bx + 0x7e8], ax);        /* mov [es:bx+0x7e8], ax */
            ii(0x17_ea7c, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ea7f, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_ea82, 5); mov(memw_a16[es, bx + 0x7ea], ax);        /* mov [es:bx+0x7ea], ax */
            ii(0x17_ea87, 3); mov(ax, 0x140e);                          /* mov ax, 0x140e */
            ii(0x17_ea8a, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_ea8d, 3); mov(memw_a16[ss, bp - 0x6], ds);          /* mov [bp-0x6], ds */
            ii(0x17_ea90, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ea93, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x17_ea95, 5); mov(memw_a16[es, bx + 0x7ee], ax);        /* mov [es:bx+0x7ee], ax */
            ii(0x17_ea9a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_ea9d, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_eaa0, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_eaa3, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_eaa6, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_eaa9, 5); mov(memw_a16[es, bx + 0x7f0], ax);        /* mov [es:bx+0x7f0], ax */
            ii(0x17_eaae, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_eab1, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x17_eab4, 5); mov(memw_a16[es, bx + 0x7f2], ax);        /* mov [es:bx+0x7f2], ax */
            ii(0x17_eab9, 1); popw(ds);                                 /* pop ds */
            ii(0x17_eaba, 1); leavew();                                 /* leave */
            ii(0x17_eabb, 1); retfw(); return;                          /* retf */
        //  ii(0x17_eabc, 31); Недостижимый (и не декодированный) код.
        //    ii(0x17_eadb, 1); nop();                                    /* nop */
        //    ii(0x17_eadc, 2); xor(ax, ax);                              /* xor ax, ax */
        //    ii(0x17_eade, 3); lar(ax, cx);                              /* lar ax, cx */
        //    ii(0x17_eae1, 2); jmpw(0x17_eae3, 0); goto l_0x17_eae3;     /* jmp 0xeae3 */
        l_0x17_eae3:
            ii(0x17_eae3, 2); if(jnzw(0x17_eaea, 0x5)) goto l_0x17_eaea; /* jnz 0xeaea */
            ii(0x17_eae5, 3); test(ah, 0x10);                           /* test ah, 0x10 */
            ii(0x17_eae8, 2); if(jnzw(0x17_eaec, 0x2)) goto l_0x17_eaec; /* jnz 0xeaec */
        l_0x17_eaea:
            ii(0x17_eaea, 2); xor(cx, cx);                              /* xor cx, cx */
        l_0x17_eaec:
            ii(0x17_eaec, 1); retw(); return;                           /* ret */
        }
    }
}
