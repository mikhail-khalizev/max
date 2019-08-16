using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eace4245-a0d2-4c36-95cd-669616019498")]
        public void Method_0000_7d56()
        {
            ii(0x7d56, 3);    callw(0x66dc, -0x167d);                   /* call 0x66dc */
            ii(0x7d59, 5);    xchg(memw_a16[cs, 0x1fbb], cx);           /* xchg [cs:0x1fbb], cx */
            ii(0x7d5e, 3);    mov(memw_a16[ss, bp + 0x14], cx);         /* mov [bp+0x14], cx */
            ii(0x7d61, 2);    jmpw(0x7d63, 0); goto l_0x7d63;           /* jmp 0x7d63 */
        l_0x7d63:
            ii(0x7d63, 1);    popw(ax);                                 /* pop ax */
            ii(0x7d64, 1);    popw(ss);                                 /* pop ss */
            ii(0x7d65, 1);    xchg(sp, ax);                             /* xchg sp, ax */
            ii(0x7d66, 1);    popw(ds);                                 /* pop ds */
            ii(0x7d67, 1);    popw(es);                                 /* pop es */
            ii(0x7d68, 2);    popad();                                  /* popad */
            ii(0x7d6a, 1);    popfw();                                  /* popfw */
        }
    }
}