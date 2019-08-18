using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("de32a729-8255-44fa-a319-cbb74219dab9")]
        public void Method_0019_1af0()
        {
            ii(0x19_1af0, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x19_1af4, 1); pushw(ds);                                /* push ds */
            ii(0x19_1af5, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_1af8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_1afa, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x19_1afd, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x19_1aff, 4); mov(ax, memw_a16[ds, bx + 0x3a3a]);       /* mov ax, [bx+0x3a3a] */
            ii(0x19_1b03, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_1b06, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_1b09, 4); mov(memw_a16[ds, bx + 0x3a3a], ax);       /* mov [bx+0x3a3a], ax */
            ii(0x19_1b0d, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_1b10, 1); popw(ds);                                 /* pop ds */
            ii(0x19_1b11, 1); leavew();                                 /* leave */
            ii(0x19_1b12, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
