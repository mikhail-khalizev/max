using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1b48-4d95de6d")]
        public void Method_001a_1b48()
        {
            ii(0x1a_1b48, 4); enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x1a_1b4c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x1a_1b4e, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x1a_1b51, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x1a_1b54, 1); push(ds);                                 /* push ds */
            ii(0x1a_1b55, 3); push(0x3b08);                             /* push 0x3b08 */
            ii(0x1a_1b58, 5); call_far_abs(0x80, 0x5ba0);               /* call word 0x80:0x5ba0 */
            ii(0x1a_1b5d, 1); pop(bx);                                  /* pop bx */
            ii(0x1a_1b5e, 1); pop(bx);                                  /* pop bx */
            ii(0x1a_1b5f, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x1a_1b62, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_1b64, 2); if(jz(0x1a_1b7b, 0x15)) goto l_0x1a_1b7b; /* jz 0x1b7b */
            ii(0x1a_1b66, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_1b69, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x1a_1b6c, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x1a_1b6f, 1); push(ax);                                 /* push ax */
            ii(0x1a_1b70, 5); call_far_abs(0x80, 0x5a20);               /* call word 0x80:0x5a20 */
            ii(0x1a_1b75, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x1a_1b78, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
        l_0x1a_1b7b:
            ii(0x1a_1b7b, 3); mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x1a_1b7e, 3); mov(dx, memw[ss, bp - 6]);                /* mov dx, [bp-0x6] */
            ii(0x1a_1b81, 1); leave();                                  /* leave */
            ii(0x1a_1b82, 1); retf();                                   /* retf */
        }
    }
}
