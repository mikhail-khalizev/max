using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e262-b2089d8b")]
        public void Method_0017_e262()
        {
            ii(0x17_e262, 1); pop(cx);                                  /* pop cx */
            ii(0x17_e263, 1); pop(dx);                                  /* pop dx */
            ii(0x17_e264, 3); mov(ax, memw[ds, 0x1da6]);                /* mov ax, [0x1da6] */
            ii(0x17_e267, 2); cmp(ax, sp);                              /* cmp ax, sp */
            ii(0x17_e269, 2); if(jae(0x17_e272, 0x7)) goto l_0x17_e272; /* jae 0xe272 */
            ii(0x17_e26b, 2); sub(ax, sp);                              /* sub ax, sp */
            ii(0x17_e26d, 2); neg(ax);                                  /* neg ax */
        l_0x17_e26f:
            ii(0x17_e26f, 1); push(dx);                                 /* push dx */
            ii(0x17_e270, 1); push(cx);                                 /* push cx */
            ii(0x17_e271, 1); retf(); return;                           /* retf */
        l_0x17_e272:
            ii(0x17_e272, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_e274, 2); jmp(0x17_e26f, -0x7); goto l_0x17_e26f;   /* jmp 0xe26f */
        }
    }
}
