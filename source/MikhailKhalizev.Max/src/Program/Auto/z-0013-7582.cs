using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f89de8a5-611a-4519-b844-a8e205f96d24")]
        public void Method_0013_7582()
        {
            ii(0x13_7582, 1); pushw(ds);                                /* push ds */
            ii(0x13_7583, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_7586, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_7588, 3); pushw(0x2000);                            /* push 0x2000 */
            ii(0x13_758b, 1); nop();                                    /* nop */
            ii(0x13_758c, 1); pushw(cs);                                /* push cs */
            ii(0x13_758d, 3); callw(0x13_e7a8, 0x7218);                 /* call 0xe7a8 */
            ii(0x13_7590, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_7593, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7594, 1); retfw(); return;                          /* retf */
        }
    }
}
