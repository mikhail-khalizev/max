using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0037-36be4b85")]
        public void Method_0019_0037()
        {
            ii(0x19_0037, 2); popd(ebx);                                /* pop ebx */
            ii(0x19_0039, 2); popd(edi);                                /* pop edi */
            ii(0x19_003b, 2); popd(esi);                                /* pop esi */
            ii(0x19_003d, 1); popw(ds);                                 /* pop ds */
            ii(0x19_003e, 1); popw(bp);                                 /* pop bp */
            ii(0x19_003f, 1); retfw();                                  /* retf */
        }
    }
}
