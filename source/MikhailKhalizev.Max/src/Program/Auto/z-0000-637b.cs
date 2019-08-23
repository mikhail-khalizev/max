using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x637b-b19fb225")]
        public void Method_0000_637b()
        {
            ii(0x637b, 3);    mov(al, memb[ds, 0x1186]);                /* mov al, [0x1186] */
            ii(0x637e, 1);    cbw();                                    /* cbw */
            ii(0x637f, 1);    push(ax);                                 /* push ax */
            ii(0x6380, 3);    call(0x9c45, 0x38c2);                     /* call 0x9c45 */
            ii(0x6383, 1);    pop(bx);                                  /* pop bx */
            ii(0x6384, 1);    ret();                                    /* ret */
        }
    }
}
