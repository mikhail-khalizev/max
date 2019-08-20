using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_f7c2-b12579ac")]
        public void /* sys */ Method_1018_f7c2()
        {
            ii(0x1018_f7c2, 3); add(esi, 0xc);                          /* add esi, 0xc */
            ii(0x1018_f7c5, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_f7c8, 1); retd(); return;                         /* ret */
        }
    }
}
