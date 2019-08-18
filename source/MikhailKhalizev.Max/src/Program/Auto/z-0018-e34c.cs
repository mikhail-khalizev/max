using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3185d517-84db-4704-93c6-a621a4fffe3c")]
        public void Method_0018_e34c()
        {
            ii(0x18_e34c, 2); pushw(0x38);                              /* push 0x38 */
            ii(0x18_e34e, 1); popw(es);                                 /* pop es */
            ii(0x18_e34f, 4); mov(di, memw_a32[ss, ebp + 0x14]);        /* mov di, [ebp+0x14] */
            ii(0x18_e353, 4); and(di, 0xff);                            /* and di, 0xff */
            ii(0x18_e357, 3); shl(di, 0x2);                             /* shl di, 0x2 */
            ii(0x18_e35a, 4); mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x18_e35e, 1); stosw_a16();                              /* stosw */
            ii(0x18_e35f, 4); mov(ax, memw_a32[ss, ebp + 0x1c]);        /* mov ax, [ebp+0x1c] */
            ii(0x18_e363, 1); stosw_a16();                              /* stosw */
            ii(0x18_e364, 3); if(jmpw_func(0x18_e067, -0x300)) return;  /* jmp 0xe067 */
        }
    }
}
