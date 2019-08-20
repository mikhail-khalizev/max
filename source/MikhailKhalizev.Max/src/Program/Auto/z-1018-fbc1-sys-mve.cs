using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_fbc1-4e099006")]
        public void /* sys_mve */ Method_1018_fbc1()
        {
            ii(0x1018_fbc1, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_fbc3, 3); add(esi, 0x20);                         /* add esi, 0x20 */
            ii(0x1018_fbc6, 3); sub(edi, 0x4);                          /* sub edi, 0x4 */
            ii(0x1018_fbc9, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_fbcc, 1); retd(); return;                         /* ret */
        }
    }
}
