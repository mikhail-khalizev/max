using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cece440a-f7dd-46ea-a05d-1b934fb5b33b")]
        public void Method_0017_e262()
        {
            ii(0x17_e262, 1); popw(cx);                                 /* pop cx */
            ii(0x17_e263, 1); popw(dx);                                 /* pop dx */
            ii(0x17_e264, 3); mov(ax, memw_a16[ds, 0x1da6]);            /* mov ax, [0x1da6] */
            ii(0x17_e267, 2); cmp(ax, sp);                              /* cmp ax, sp */
            ii(0x17_e269, 2); if(jaew(0x17_e272, 0x7)) goto l_0x17_e272; /* jae 0xe272 */
            ii(0x17_e26b, 2); sub(ax, sp);                              /* sub ax, sp */
            ii(0x17_e26d, 2); neg(ax);                                  /* neg ax */
        l_0x17_e26f:
            ii(0x17_e26f, 1); pushw(dx);                                /* push dx */
            ii(0x17_e270, 1); pushw(cx);                                /* push cx */
            ii(0x17_e271, 1); retfw(); return;                          /* retf */
        l_0x17_e272:
            ii(0x17_e272, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_e274, 2); jmpw(0x17_e26f, -0x7); goto l_0x17_e26f;  /* jmp 0xe26f */
        }
    }
}
