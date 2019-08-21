using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_2703-f7041a28")]
        public void Method_1016_2703()
        {
            ii(0x1016_2703, 5); mov(eax, StringDefinitions.Tranferring); /* mov eax, 0x101b29c6 */
            ii(0x1016_2708, 5); calld(0x100a_8b4a, -0xb_9bc3);          /* call 0x100a8b4a */
            ii(0x1016_270d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_2710, 5); calld(0x1016_0464, -0x22b1);            /* call 0x10160464 */
            ii(0x1016_2715, 5); if(jmpd_func(0x1016_29a7, 0x28d)) return; /* jmp 0x101629a7 */
        }
    }
}
