using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0e41af8e-edc3-4430-9d32-e0dece81d835")]
        public void Method_0014_e60b()
        {
            ii(0x14_e60b, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x14_e60d, 1); popw(es);                                 /* pop es */
            ii(0x14_e60e, 3); mov(bx, 0x60);                            /* mov bx, 0x60 */
            ii(0x14_e611, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x14_e615, 4); mov(memb_a16[es, bx + 0x4], dl);          /* mov [es:bx+0x4], dl */
            ii(0x14_e619, 4); mov(memb_a16[es, bx + 0x7], dh);          /* mov [es:bx+0x7], dh */
            ii(0x14_e61d, 2); mov(es, bx);                              /* mov es, bx */
            ii(0x14_e61f, 1); retw(); return;                           /* ret */
        }
    }
}
