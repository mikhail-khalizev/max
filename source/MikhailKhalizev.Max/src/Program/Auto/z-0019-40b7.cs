using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_40b7-c1642391")]
        public void Method_0019_40b7()
        {
            ii(0x19_40b7, 1); push(ax);                                 /* push ax */
            ii(0x19_40b8, 1); push(es);                                 /* push es */
            ii(0x19_40b9, 3); push(0xa8);                               /* push 0xa8 */
            ii(0x19_40bc, 1); pop(es);                                  /* pop es */
            ii(0x19_40bd, 5); push(memw[es, 0x3b78]);                   /* push word [es:0x3b78] */
            ii(0x19_40c2, 1); pop(es);                                  /* pop es */
            ii(0x19_40c3, 4); mov(al, memb[es, 0x2f]);                  /* mov al, [es:0x2f] */
            ii(0x19_40c7, 2); sub(al, 0x2);                             /* sub al, 0x2 */
            ii(0x19_40c9, 1); pop(es);                                  /* pop es */
            ii(0x19_40ca, 1); pop(ax);                                  /* pop ax */
            ii(0x19_40cb, 1); ret();                                    /* ret */
        }
    }
}
