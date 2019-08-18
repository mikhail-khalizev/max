using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("612b33e2-0718-483f-a9e5-485e004b6f10")]
        public void Method_0019_3b54()
        {
            ii(0x19_3b54, 1); popw(cx);                                 /* pop cx */
            ii(0x19_3b55, 1); popw(dx);                                 /* pop dx */
            ii(0x19_3b56, 3); mov(ax, memw_a16[ds, 0x3f52]);            /* mov ax, [0x3f52] */
            ii(0x19_3b59, 2); cmp(ax, sp);                              /* cmp ax, sp */
            ii(0x19_3b5b, 2); if(jaew(0x19_3b64, 0x7)) goto l_0x19_3b64; /* jae 0x3b64 */
            ii(0x19_3b5d, 2); sub(ax, sp);                              /* sub ax, sp */
            ii(0x19_3b5f, 2); neg(ax);                                  /* neg ax */
        l_0x19_3b61:
            ii(0x19_3b61, 1); pushw(dx);                                /* push dx */
            ii(0x19_3b62, 1); pushw(cx);                                /* push cx */
            ii(0x19_3b63, 1); retfw(); return;                          /* retf */
        l_0x19_3b64:
            ii(0x19_3b64, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_3b66, 2); jmpw(0x19_3b61, -0x7); goto l_0x19_3b61;  /* jmp 0x3b61 */
        }
    }
}
