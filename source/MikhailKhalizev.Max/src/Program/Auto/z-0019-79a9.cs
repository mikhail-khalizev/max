using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_79a9-5a02bc76")]
        public void Method_0019_79a9()
        {
            ii(0x19_79a9, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x19_79ad, 1);  push(di);                               /* push di */
            ii(0x19_79ae, 1);  push(si);                               /* push si */
            ii(0x19_79af, 5);  call_far_abs(0x80, 0x5740);             /* call word 0x80:0x5740 */
            ii(0x19_79b4, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_79b7, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_79ba, 3);  jmp(0x19_79bd, 0); goto l_0x19_79bd;    /* jmp 0x79bd */
        l_0x19_79bd:
            ii(0x19_79bd, 1);  pop(si);                                /* pop si */
            ii(0x19_79be, 1);  pop(di);                                /* pop di */
            ii(0x19_79bf, 1);  leave();                                /* leave */
            ii(0x19_79c0, 1);  ret();                                  /* ret */
        }
    }
}
