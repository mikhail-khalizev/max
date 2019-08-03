using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bc2c4615-3355-489d-a81e-738916caefbb")]
        public void /* sys */ Method_1019_5c77()
        {
            ii(0x1019_5c77, 4); sub(memd_a32[ds, eax + 0x4], 0x2);      /* sub dword [eax+0x4], 0x2 */
            ii(0x1019_5c7b, 1); retd(); return;                         /* ret */
        }
    }
}
