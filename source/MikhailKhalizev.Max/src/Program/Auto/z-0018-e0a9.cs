using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e0a9-5ee7ec7d")]
        public void Method_0018_e0a9()
        {
            ii(0x18_e0a9, 4); mov(si, memw_a32[ss, ebp + 0x1c]);        /* mov si, [ebp+0x1c] */
            ii(0x18_e0ad, 2); or(si, si);                               /* or si, si */
            ii(0x18_e0af, 2); if(jlew_func(0x18_e062, -0x4f)) return;   /* jle 0xe062 */
            ii(0x18_e0b1, 3); pushw(0x4547);                            /* push 0x4547 */
            ii(0x18_e0b4, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x18_e0b6, 1); popw(es);                                 /* pop es */
            ii(0x18_e0b7, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x18_e0b9, 1); popw(ds);                                 /* pop ds */
        }
    }
}
