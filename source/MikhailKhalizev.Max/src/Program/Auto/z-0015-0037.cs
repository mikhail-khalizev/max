using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d21198b9-f35c-4705-91f8-21509e97f4ce")]
        public void Method_0015_0037()
        {
            ii(0x15_0037, 2); popd(ebx);                                /* pop ebx */
            ii(0x15_0039, 2); popd(edi);                                /* pop edi */
            ii(0x15_003b, 2); popd(esi);                                /* pop esi */
            ii(0x15_003d, 1); popw(ds);                                 /* pop ds */
            ii(0x15_003e, 1); popw(bp);                                 /* pop bp */
            ii(0x15_003f, 1); retfw(); return;                          /* retf */
        }
    }
}
