using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e4601183-76fa-44cc-86f3-956682bfff3b")]
        public void Method_0013_e262()
        {
            ii(0x13_e262, 1); popw(cx);                                 /* pop cx */
            ii(0x13_e263, 1); popw(dx);                                 /* pop dx */
            ii(0x13_e264, 3); mov(ax, memw_a16[ds, 0x1da6]);            /* mov ax, [0x1da6] */
            ii(0x13_e267, 2); cmp(ax, sp);                              /* cmp ax, sp */
            ii(0x13_e269, 2); if(jaew(0x13_e272, 0x7)) goto l_0x13_e272; /* jae 0xe272 */
            ii(0x13_e26b, 2); sub(ax, sp);                              /* sub ax, sp */
            ii(0x13_e26d, 2); neg(ax);                                  /* neg ax */
        l_0x13_e26f:
            ii(0x13_e26f, 1); pushw(dx);                                /* push dx */
            ii(0x13_e270, 1); pushw(cx);                                /* push cx */
            ii(0x13_e271, 1); retfw(); return;                          /* retf */
        l_0x13_e272:
            ii(0x13_e272, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_e274, 2); jmpw(0x13_e26f, -0x7); goto l_0x13_e26f;  /* jmp 0xe26f */
        }
    }
}
