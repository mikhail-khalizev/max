using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d2b06541-f7cc-4b2a-b72d-4be080861e12")]
        public void /* sys */ Method_1018_163f()
        {
            ii(0x1018_163f, 1); popd(es);                               /* pop es */
            ii(0x1018_1640, 1); popd(edi);                              /* pop edi */
            ii(0x1018_1641, 1); popd(esi);                              /* pop esi */
            ii(0x1018_1642, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_1643, 1); retd(); return;                         /* ret */
        }
    }
}
