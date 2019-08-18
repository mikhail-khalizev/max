using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5539-f2534a3d")]
        public void Method_0019_5539()
        {
            ii(0x19_5539, 4); enterw(0xa0, 0);                          /* enter 0xa0, 0x0 */
            ii(0x19_553d, 1); pushw(di);                                /* push di */
            ii(0x19_553e, 1); pushw(si);                                /* push si */
            ii(0x19_553f, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x19_5542, 1); pushw(ss);                                /* push ss */
            ii(0x19_5543, 1); pushw(ax);                                /* push ax */
            ii(0x19_5544, 4); pushw(memw_a16[ds, 0x40ee]);              /* push word [0x40ee] */
            ii(0x19_5548, 4); pushw(memw_a16[ds, 0x40ec]);              /* push word [0x40ec] */
            ii(0x19_554c, 3); callw(0x18_ff6c, -0x55e3);                /* call 0xff6c */
            ii(0x19_554f, 1); pushw(dx);                                /* push dx */
            ii(0x19_5550, 1); pushw(ax);                                /* push ax */
            ii(0x19_5551, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x19_5556, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5559, 4); lea(ax, bp - 0xa0);                       /* lea ax, [bp-0xa0] */
            ii(0x19_555d, 1); pushw(ss);                                /* push ss */
            ii(0x19_555e, 1); pushw(ax);                                /* push ax */
            ii(0x19_555f, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_5562, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_5565, 3); callw(0x18_ff6c, -0x55fc);                /* call 0xff6c */
            ii(0x19_5568, 1); pushw(dx);                                /* push dx */
            ii(0x19_5569, 1); pushw(ax);                                /* push ax */
            ii(0x19_556a, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x19_556f, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_5572, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x19_5575, 1); pushw(ss);                                /* push ss */
            ii(0x19_5576, 1); pushw(ax);                                /* push ax */
            ii(0x19_5577, 4); lea(ax, bp - 0xa0);                       /* lea ax, [bp-0xa0] */
            ii(0x19_557b, 1); pushw(ss);                                /* push ss */
            ii(0x19_557c, 1); pushw(ax);                                /* push ax */
            ii(0x19_557d, 3); callw(0x18_ffd5, -0x55ab);                /* call 0xffd5 */
            ii(0x19_5580, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_5582, 2); if(jnzw(0x19_5587, 0x3)) goto l_0x19_5587; /* jnz 0x5587 */
            ii(0x19_5584, 3); jmpw(0x19_5590, 0x9); goto l_0x19_5590;   /* jmp 0x5590 */
        l_0x19_5587:
            ii(0x19_5587, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_558a, 3); jmpw(0x19_5596, 0x9); goto l_0x19_5596;   /* jmp 0x5596 */
        //    ii(0x19_558d, 3); jmpw(0x19_5596, 0x6); goto l_0x19_5596;   /* jmp 0x5596 */
        l_0x19_5590:
            ii(0x19_5590, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_5593, 3); jmpw(0x19_5596, 0); goto l_0x19_5596;     /* jmp 0x5596 */
        l_0x19_5596:
            ii(0x19_5596, 1); popw(si);                                 /* pop si */
            ii(0x19_5597, 1); popw(di);                                 /* pop di */
            ii(0x19_5598, 1); leavew();                                 /* leave */
            ii(0x19_5599, 3); retw(0x6); return;                        /* ret 0x6 */
        }
    }
}
