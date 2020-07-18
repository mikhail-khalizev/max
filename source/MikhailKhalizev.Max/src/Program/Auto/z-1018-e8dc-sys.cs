using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e8dc-59602f")]
        public void /* sys */ Method_1018_e8dc()
        {
            ii(0x1018_e8dc, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1018_e8df, 2);  shr(eax, 1);                          /* shr eax, 1 */
            ii(0x1018_e8e1, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        }
    }
}
