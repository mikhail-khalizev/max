using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5539-f2534a3d")]
        public void Method_0019_5539()
        {
            ii(0x19_5539, 4); enter(0xa0, 0);                           /* enter 0xa0, 0x0 */
            ii(0x19_553d, 1); push(di);                                 /* push di */
            ii(0x19_553e, 1); push(si);                                 /* push si */
            ii(0x19_553f, 3); lea(ax, memw[ss, bp - 0x80]);             /* lea ax, [bp-0x80] */
            ii(0x19_5542, 1); push(ss);                                 /* push ss */
            ii(0x19_5543, 1); push(ax);                                 /* push ax */
            ii(0x19_5544, 4); push(memw[ds, 0x40ee]);                   /* push word [0x40ee] */
            ii(0x19_5548, 4); push(memw[ds, 0x40ec]);                   /* push word [0x40ec] */
            ii(0x19_554c, 3); call(0x18_ff6c, -0x55e3);                 /* call 0xff6c */
            ii(0x19_554f, 1); push(dx);                                 /* push dx */
            ii(0x19_5550, 1); push(ax);                                 /* push ax */
            ii(0x19_5551, 5); call_far_abs(0x80, 0x4508);               /* call word 0x80:0x4508 */
            ii(0x19_5556, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x19_5559, 4); lea(ax, memw[ss, bp - 0xa0]);             /* lea ax, [bp-0xa0] */
            ii(0x19_555d, 1); push(ss);                                 /* push ss */
            ii(0x19_555e, 1); push(ax);                                 /* push ax */
            ii(0x19_555f, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_5562, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_5565, 3); call(0x18_ff6c, -0x55fc);                 /* call 0xff6c */
            ii(0x19_5568, 1); push(dx);                                 /* push dx */
            ii(0x19_5569, 1); push(ax);                                 /* push ax */
            ii(0x19_556a, 5); call_far_abs(0x80, 0x4508);               /* call word 0x80:0x4508 */
            ii(0x19_556f, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x19_5572, 3); lea(ax, memw[ss, bp - 0x80]);             /* lea ax, [bp-0x80] */
            ii(0x19_5575, 1); push(ss);                                 /* push ss */
            ii(0x19_5576, 1); push(ax);                                 /* push ax */
            ii(0x19_5577, 4); lea(ax, memw[ss, bp - 0xa0]);             /* lea ax, [bp-0xa0] */
            ii(0x19_557b, 1); push(ss);                                 /* push ss */
            ii(0x19_557c, 1); push(ax);                                 /* push ax */
            ii(0x19_557d, 3); call(0x18_ffd5, -0x55ab);                 /* call 0xffd5 */
            ii(0x19_5580, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_5582, 2); if(jnz(0x19_5587, 3)) goto l_0x19_5587;   /* jnz 0x5587 */
            ii(0x19_5584, 3); jmp(0x19_5590, 9); goto l_0x19_5590;      /* jmp 0x5590 */
        l_0x19_5587:
            ii(0x19_5587, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_558a, 3); jmp(0x19_5596, 9); goto l_0x19_5596;      /* jmp 0x5596 */
        //  ii(0x19_558d, 3); jmp(0x19_5596, 6); goto l_0x19_5596;      /* jmp 0x5596 */
        l_0x19_5590:
            ii(0x19_5590, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_5593, 3); jmp(0x19_5596, 0); goto l_0x19_5596;      /* jmp 0x5596 */
        l_0x19_5596:
            ii(0x19_5596, 1); pop(si);                                  /* pop si */
            ii(0x19_5597, 1); pop(di);                                  /* pop di */
            ii(0x19_5598, 1); leave();                                  /* leave */
            ii(0x19_5599, 3); ret(6);                                   /* ret 0x6 */
        }
    }
}
