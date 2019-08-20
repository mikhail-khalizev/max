using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ecd6-cf423b9d")]
        public void /* sys */ Method_1018_ecd6()
        {
            ii(0x1018_ecd6, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_ecd9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_ecdb, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_ecde, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_ece1, 3); add(esi, 0x4);                          /* add esi, 0x4 */
            ii(0x1018_ece4, 1); retd(); return;                         /* ret */
        }
    }
}
