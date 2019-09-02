using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_b5d1-278c9300")]
        public void Method_0019_b5d1()
        {
            ii(0x19_b5d1, 4); enter(0x22, 0);                           /* enter 0x22, 0x0 */
            ii(0x19_b5d5, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x19_b5d8, 1); push(es);                                 /* push es */
            ii(0x19_b5d9, 1); push(bx);                                 /* push bx */
            ii(0x19_b5da, 2); push(-3 /* 0xfd */);                      /* push 0xfffd */
            ii(0x19_b5dc, 2); push(1);                                  /* push 0x1 */
            ii(0x19_b5de, 4); push(memw[es, bx + 0x64]);                /* push word [es:bx+0x64] */
            ii(0x19_b5e2, 4); push(memw[es, bx + 0x62]);                /* push word [es:bx+0x62] */
            ii(0x19_b5e6, 3); call(0x19_c975, 0x138c);                  /* call 0xc975 */
            ii(0x19_b5e9, 3); mov(memw[ss, bp - 0x1c], dx);             /* mov [bp-0x1c], dx */
            ii(0x19_b5ec, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_b5ee, 2); if(jnz(0x19_b5f5, 5)) goto l_0x19_b5f5;   /* jnz 0xb5f5 */
            ii(0x19_b5f0, 3); mov(ax, 0x51b);                           /* mov ax, 0x51b */
            ii(0x19_b5f3, 2); jmp(0x19_b610, 0x1b); goto l_0x19_b610;   /* jmp 0xb610 */
        l_0x19_b5f5:
            ii(0x19_b5f5, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b5f7, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b5f9, 3); push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x19_b5fc, 1); push(ax);                                 /* push ax */
            ii(0x19_b5fd, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b5ff, 3); push(0x100);                              /* push 0x100 */
            ii(0x19_b602, 3); call(0x19_de46, 0x2841);                  /* call 0xde46 */
            ii(0x19_b605, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_b607, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_b609, 1); push(es);                                 /* push es */
            ii(0x19_b60a, 1); push(bx);                                 /* push bx */
            ii(0x19_b60b, 3); call(0x19_df78, 0x296a);                  /* call 0xdf78 */
            ii(0x19_b60e, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_b610:
            ii(0x19_b610, 1); leave();                                  /* leave */
            ii(0x19_b611, 3); ret(4);                                   /* ret 0x4 */
        }
    }
}
