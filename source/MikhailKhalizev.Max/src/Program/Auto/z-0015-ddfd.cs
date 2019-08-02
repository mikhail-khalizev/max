using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("99e26cee-0372-4bc1-b7d8-137616116488")]
        public void Method_0015_ddfd()
        {
            ii(0x15_ddfd, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x15_de01, 1); pushw(si);                                /* push si */
            ii(0x15_de02, 4); mov(es, memw_a16[ds, 0x3fc8]);            /* mov es, [0x3fc8] */
            ii(0x15_de06, 4); mov(ax, memw_a16[es, 0x3b84]);            /* mov ax, [es:0x3b84] */
            ii(0x15_de0a, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x15_de0f, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_de12, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_de15, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_de17, 1); pushw(ax);                                /* push ax */
            ii(0x15_de18, 1); pushw(cx);                                /* push cx */
            ii(0x15_de19, 5); callw_far_abs(0x80, 0x4e04);              /* call word 0x80:0x4e04 */
            ii(0x15_de1e, 1); popw(bx);                                 /* pop bx */
            ii(0x15_de1f, 1); popw(bx);                                 /* pop bx */
            ii(0x15_de20, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_de23, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_de25, 3); or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0x15_de28, 2); if(jzw(0x15_de41, 0x17)) goto l_0x15_de41; /* jz 0xde41 */
            ii(0x15_de2a, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x15_de2c, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x15_de2f, 3); les(si, ss, bp - 0x8);                    /* les si, [bp-0x8] */
            ii(0x15_de32, 4); or(memb_a16[es, bx + si], 0x1);           /* or byte [es:bx+si], 0x1 */
            ii(0x15_de36, 1); pushw(dx);                                /* push dx */
            ii(0x15_de37, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_de3a, 5); callw_far_abs(0x80, 0x522a);              /* call word 0x80:0x522a */
            ii(0x15_de3f, 1); popw(bx);                                 /* pop bx */
            ii(0x15_de40, 1); popw(bx);                                 /* pop bx */
        l_0x15_de41:
            ii(0x15_de41, 1); popw(si);                                 /* pop si */
            ii(0x15_de42, 1); leavew();                                 /* leave */
            ii(0x15_de43, 3); retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
