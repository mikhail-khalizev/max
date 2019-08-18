using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("51b7b7b7-eb31-4854-b8d7-0c9c89558076")]
        public void /* sys */ Method_1018_6b26()
        {
            ii(0x1018_6b26, 1); popd(ds);                               /* pop ds */
            ii(0x1018_6b27, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_6b28, 1); popd(edi);                              /* pop edi */
            ii(0x1018_6b29, 1); popd(esi);                              /* pop esi */
            ii(0x1018_6b2a, 1); retd(); return;                         /* ret */
        }
    }
}
