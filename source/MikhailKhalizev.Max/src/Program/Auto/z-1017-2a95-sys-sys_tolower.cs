using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f88d433a-a46f-43dc-961c-2b63a3529a57")]
        public void /* sys */ sys_tolower()
        {
            ii(0x1017_2a95, 3); cmp(eax, 0x61);                         /* cmp eax, 0x61 */
            ii(0x1017_2a98, 2); if(jld(0x1017_2aa2, 0x8)) goto l_0x1017_2aa2; /* jl 0x10172aa2 */
            ii(0x1017_2a9a, 3); cmp(eax, 0x7a);                         /* cmp eax, 0x7a */
            ii(0x1017_2a9d, 2); if(jgd(0x1017_2aa2, 0x3)) goto l_0x1017_2aa2; /* jg 0x10172aa2 */
            ii(0x1017_2a9f, 3); sub(eax, 0x20);                         /* sub eax, 0x20 */
        l_0x1017_2aa2:
            ii(0x1017_2aa2, 1); retd(); return;                         /* ret */
        }
    }
}
