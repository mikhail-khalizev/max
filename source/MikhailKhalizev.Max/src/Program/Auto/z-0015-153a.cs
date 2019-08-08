using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a69f70e2-3174-4296-b576-bb7e939d78a1")]
        public void Method_0015_153a()
        {
            ii(0x15_153a, 1); pushw(ds);                                /* push ds */
            ii(0x15_153b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_153e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_1540, 3); pushw(0x80);                              /* push 0x80 */
            ii(0x15_1543, 3); pushw(0x20cc);                            /* push 0x20cc */
            ii(0x15_1546, 5); callw_far_abs(0x88, 0xa6ae);              /* call word 0x88:0xa6ae */
            ii(0x15_154b, 1); pushw(ds);                                /* push ds */
            ii(0x15_154c, 3); pushw(0x38ba);                            /* push 0x38ba */
            ii(0x15_154f, 3); pushw(0xa8);                              /* push 0xa8 */
            ii(0x15_1552, 3); pushw(0x3904);                            /* push 0x3904 */
            ii(0x15_1555, 5); callw_far_abs(0x88, 0xa7f7);              /* call word 0x88:0xa7f7 */
            ii(0x15_155a, 1); popw(ds);                                 /* pop ds */
            ii(0x15_155b, 1); retfw(); return;                          /* retf */
        }
    }
}