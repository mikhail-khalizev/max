using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5d52-b26f3ca8")]
        public void /* sys */ sys_check_available_stack_size()
        {
            ii(0x1016_5d52, 4); xchg(memd_a32[ss, esp + 0x4], eax);     /* xchg [esp+0x4], eax */
            ii(0x1016_5d56, 5); calld(/* sys */ 0x1016_5d65, 0xa);      /* call 0x10165d65 */
            ii(0x1016_5d5b, 4); mov(eax, memd_a32[ss, esp + 0x4]);      /* mov eax, [esp+0x4] */
            ii(0x1016_5d5f, 3); retd(0x4);                              /* ret 0x4 */
        }
    }
}
