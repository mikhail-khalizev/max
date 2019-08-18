using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("53084e0b-75d7-41ce-8d49-9aafa6eefbb7")]
        public void Method_0019_d4c3()
        {
            ii(0x19_d4c3, 1); pushw(bp);                                /* push bp */
            ii(0x19_d4c4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d4c6, 4); cmp(memw_a16[ss, bp + 0xa], 0);           /* cmp word [bp+0xa], 0x0 */
            ii(0x19_d4ca, 2); if(jzw(0x19_d507, 0x3b)) goto l_0x19_d507; /* jz 0xd507 */
            ii(0x19_d4cc, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d4cf, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d4d2, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_d4d5, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_d4d8, 1); nop();                                    /* nop */
            ii(0x19_d4d9, 1); pushw(cs);                                /* push cs */
            ii(0x19_d4da, 3); callw(0x1a_0330, 0x2e53);                 /* call 0x330 */
            ii(0x19_d4dd, 1); pushw(dx);                                /* push dx */
            ii(0x19_d4de, 1); pushw(ax);                                /* push ax */
            ii(0x19_d4df, 3); callw(0x19_ff6c, 0x2a8a);                 /* call 0xff6c */
            ii(0x19_d4e2, 2); pushw(0x2e);                              /* push 0x2e */
            ii(0x19_d4e4, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d4e7, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d4ea, 5); callw_far_abs(0x80, 0x440a);              /* call word 0x80:0x440a */
            ii(0x19_d4ef, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_d4f1, 3); mov(memw_a16[ss, bp + 0x8], ax);          /* mov [bp+0x8], ax */
            ii(0x19_d4f4, 3); mov(memw_a16[ss, bp + 0xa], dx);          /* mov [bp+0xa], dx */
            ii(0x19_d4f7, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_d4f9, 3); or(ax, memw_a16[ss, bp + 0x8]);           /* or ax, [bp+0x8] */
            ii(0x19_d4fc, 2); if(jzw(0x19_d514, 0x16)) goto l_0x19_d514; /* jz 0xd514 */
            ii(0x19_d4fe, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_d501, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x19_d505, 2); jmpw(0x19_d514, 0xd); goto l_0x19_d514;   /* jmp 0xd514 */
        l_0x19_d507:
            ii(0x19_d507, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d50a, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d50d, 1); pushw(ds);                                /* push ds */
            ii(0x19_d50e, 3); pushw(0x2a15);                            /* push 0x2a15 */
            ii(0x19_d511, 3); callw(0x19_ff6c, 0x2a58);                 /* call 0xff6c */
        l_0x19_d514:
            ii(0x19_d514, 1); leavew();                                 /* leave */
            ii(0x19_d515, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
