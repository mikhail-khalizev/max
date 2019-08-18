using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("138c2be4-6ff3-45b6-8d38-0f7909bc29d2")]
        public void Method_0017_8e80()
        {
            ii(0x17_8e80, 1); pushw(bx);                                /* push bx */
            ii(0x17_8e81, 2); pushd(edx);                               /* push edx */
            ii(0x17_8e83, 3); mov(edx, cr3);                            /* mov edx, cr3 */
            ii(0x17_8e86, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_8e88, 3); and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0x17_8e8b, 4); shr(edx, 0x10);                           /* shr edx, 0x10 */
            ii(0x17_8e8f, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x17_8e91, 2); popd(edx);                                /* pop edx */
            ii(0x17_8e93, 2); mov(dx, bx);                              /* mov dx, bx */
            ii(0x17_8e95, 1); popw(bx);                                 /* pop bx */
            ii(0x17_8e96, 1); retfw(); return;                          /* retf */
        }
    }
}
