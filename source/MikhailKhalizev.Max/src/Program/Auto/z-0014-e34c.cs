using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9927dc9e-a2c3-4aeb-b510-785ef7b8c705")]
        public void Method_0014_e34c()
        {
            ii(0x14_e34c, 2); pushw(0x38);                              /* push 0x38 */
            ii(0x14_e34e, 1); popw(es);                                 /* pop es */
            ii(0x14_e34f, 4); mov(di, memw_a32[ss, ebp + 0x14]);        /* mov di, [ebp+0x14] */
            ii(0x14_e353, 4); and(di, 0xff);                            /* and di, 0xff */
            ii(0x14_e357, 3); shl(di, 0x2);                             /* shl di, 0x2 */
            ii(0x14_e35a, 4); mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x14_e35e, 1); stosw_a16();                              /* stosw */
            ii(0x14_e35f, 4); mov(ax, memw_a32[ss, ebp + 0x1c]);        /* mov ax, [ebp+0x1c] */
            ii(0x14_e363, 1); stosw_a16();                              /* stosw */
            ii(0x14_e364, 3); if(jmpw_func(0x14_e067, -0x300)) return;  /* jmp 0xe067 */
        }
    }
}
