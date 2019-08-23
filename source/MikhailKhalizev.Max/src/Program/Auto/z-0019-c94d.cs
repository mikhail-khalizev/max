using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c94d-50b5b4e4")]
        public void Method_0019_c94d()
        {
            ii(0x19_c94d, 1); push(bp);                                 /* push bp */
            ii(0x19_c94e, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_c950, 1); push(di);                                 /* push di */
            ii(0x19_c951, 1); push(si);                                 /* push si */
            ii(0x19_c952, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_c955, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_c958, 1); push(ds);                                 /* push ds */
            ii(0x19_c959, 3); push(0x2813);                             /* push 0x2813 */
            ii(0x19_c95c, 3); call(0x1a_1066, 0x4707);                  /* call 0x1066 */
            ii(0x19_c95f, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_c962, 3); mov(ax, 0x502);                           /* mov ax, 0x502 */
            ii(0x19_c965, 2); xor(bx, bx);                              /* xor bx, bx */
            ii(0x19_c967, 3); mov(si, memw[ss, bp + 0x6]);              /* mov si, [bp+0x6] */
            ii(0x19_c96a, 3); mov(di, memw[ss, bp + 0x4]);              /* mov di, [bp+0x4] */
            ii(0x19_c96d, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_c96f, 1); pop(si);                                  /* pop si */
            ii(0x19_c970, 1); pop(di);                                  /* pop di */
            ii(0x19_c971, 1); leave();                                  /* leave */
            ii(0x19_c972, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}
