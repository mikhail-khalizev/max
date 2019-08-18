using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("89ae032d-1f18-48de-a743-8222ae546c5c")]
        public void Method_100e_d734()
        {
            ii(0x100e_d734, 4); cmp(memd_a32[ss, ebp - 0x10], 0x2);     /* cmp dword [ebp-0x10], 0x2 */
            ii(0x100e_d738, 2); if(jbd(0x100e_d750, 0x16)) goto l_0x100e_d750; /* jb 0x100ed750 */
            ii(0x100e_d73a, 4); cmp(memd_a32[ss, ebp - 0x10], 0x2);     /* cmp dword [ebp-0x10], 0x2 */
            ii(0x100e_d73e, 6); if(jbed_func(0x100e_d437, -0x30d)) return; /* jbe 0x100ed437 */
            ii(0x100e_d744, 4); cmp(memd_a32[ss, ebp - 0x10], 0x8);     /* cmp dword [ebp-0x10], 0x8 */
            ii(0x100e_d748, 6); if(jzd_func(0x100e_d2ff, -0x44f)) return; /* jz 0x100ed2ff */
            ii(0x100e_d74e, 2); if(jmpd_func(0x100e_d732, -0x1e)) return; /* jmp 0x100ed732 */
        l_0x100e_d750:
            ii(0x100e_d750, 4); cmp(memd_a32[ss, ebp - 0x10], 0x1);     /* cmp dword [ebp-0x10], 0x1 */
            ii(0x100e_d754, 6); if(jzd_func(0x100e_cd8d, -0x9cd)) return; /* jz 0x100ecd8d */
            ii(0x100e_d75a, 2); if(jmpd_func(0x100e_d732, -0x2a)) return; /* jmp 0x100ed732 */
        }
    }
}
