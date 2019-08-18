using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_b282-64d852d4")]
        public void Method_0019_b282()
        {
            ii(0x19_b282, 1); pushw(bp);                                /* push bp */
            ii(0x19_b283, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_b285, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_b288, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_b28a, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x19_b28e, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_b291, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x19_b294, 3); or(ax, memw_a16[ss, bp + 0x8]);           /* or ax, [bp+0x8] */
            ii(0x19_b297, 2); if(jzw(0x19_b2b7, 0x1e)) goto l_0x19_b2b7; /* jz 0xb2b7 */
            ii(0x19_b299, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x19_b29c, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_b29e, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x19_b2a1, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_b2a4, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_b2a7, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_b2aa, 3); callw(0x19_de46, 0x2b99);                 /* call 0xde46 */
            ii(0x19_b2ad, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_b2b0, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_b2b3, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
        l_0x19_b2b7:
            ii(0x19_b2b7, 4); mov(ax, memw_a16[es, bx + 0x2]);          /* mov ax, [es:bx+0x2] */
            ii(0x19_b2bb, 3); or(ax, memw_a16[es, bx]);                 /* or ax, [es:bx] */
            ii(0x19_b2be, 2); if(jzw(0x19_b2c5, 0x5)) goto l_0x19_b2c5; /* jz 0xb2c5 */
            ii(0x19_b2c0, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_b2c3, 2); jmpw(0x19_b2c7, 0x2); goto l_0x19_b2c7;   /* jmp 0xb2c7 */
        l_0x19_b2c5:
            ii(0x19_b2c5, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_b2c7:
            ii(0x19_b2c7, 1); leavew();                                 /* leave */
            ii(0x19_b2c8, 3); retw(0xe); return;                        /* ret 0xe */
        }
    }
}
