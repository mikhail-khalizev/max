using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1174-cbf16146")]
        public void /* sys */ Method_1017_1174()
        {
            ii(0x1017_1174, 10); mov(memd[ds, 0x101b_e1c4], 1);         /* mov dword [0x101be1c4], 0x1 */
            ii(0x1017_117e, 6); call_abs(memd[ds, 0x101b_e1c8]);        /* call dword [0x101be1c8] */ /* Вызов '0x1017_11a4'. */
            ii(0x1017_1184, 1); ret();                                  /* ret */
        }
    }
}
