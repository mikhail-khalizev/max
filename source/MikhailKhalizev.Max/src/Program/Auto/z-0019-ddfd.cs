using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ddfd-d5c2f0")]
        public void Method_0019_ddfd()
        {
            ii(0x19_ddfd, 4); enter(0x8, 0);                            /* enter 0x8, 0x0 */
            ii(0x19_de01, 1); push(si);                                 /* push si */
            ii(0x19_de02, 4); mov(es, memw[ds, 0x3fc8]);                /* mov es, [0x3fc8] */
            ii(0x19_de06, 4); mov(ax, memw[es, 0x3b84]);                /* mov ax, [es:0x3b84] */
            ii(0x19_de0a, 5); mov(memw[ss, bp - 0x8], 0);               /* mov word [bp-0x8], 0x0 */
            ii(0x19_de0f, 3); mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x19_de12, 3); mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x19_de15, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_de17, 1); push(ax);                                 /* push ax */
            ii(0x19_de18, 1); push(cx);                                 /* push cx */
            ii(0x19_de19, 5); call_far_abs(0x80, 0x4e04);               /* call word 0x80:0x4e04 */
            ii(0x19_de1e, 1); pop(bx);                                  /* pop bx */
            ii(0x19_de1f, 1); pop(bx);                                  /* pop bx */
            ii(0x19_de20, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_de23, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_de25, 3); or(ax, memw[ss, bp - 0x4]);               /* or ax, [bp-0x4] */
            ii(0x19_de28, 2); if(jz(0x19_de41, 0x17)) goto l_0x19_de41; /* jz 0xde41 */
            ii(0x19_de2a, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x19_de2c, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x19_de2f, 3); les(si, memw[ss, bp - 0x8]);              /* les si, [bp-0x8] */
            ii(0x19_de32, 4); or(memb[es, bx + si], 0x1);               /* or byte [es:bx+si], 0x1 */
            ii(0x19_de36, 1); push(dx);                                 /* push dx */
            ii(0x19_de37, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x19_de3a, 5); call_far_abs(0x80, 0x522a);               /* call word 0x80:0x522a */
            ii(0x19_de3f, 1); pop(bx);                                  /* pop bx */
            ii(0x19_de40, 1); pop(bx);                                  /* pop bx */
        l_0x19_de41:
            ii(0x19_de41, 1); pop(si);                                  /* pop si */
            ii(0x19_de42, 1); leave();                                  /* leave */
            ii(0x19_de43, 3); ret(0x2);                                 /* ret 0x2 */
        }
    }
}
