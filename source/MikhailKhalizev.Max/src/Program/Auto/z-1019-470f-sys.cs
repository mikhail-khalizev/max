using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_470f-c66f647a")]
        public void /* sys */ Method_1019_470f()
        {
            ii(0x1019_470f, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1019_4711, 6); sub(eax, memd_a32[ds, 0x101b_e570]);    /* sub eax, [0x101be570] */
            ii(0x1019_4717, 1); retd(); return;                         /* ret */
        }
    }
}
