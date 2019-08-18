using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7644c666-6dcc-4ad1-9b9a-1f452c37f88a")]
        public void /* sys */ sys_toupper()
        {
            ii(0x1018_0eea, 3); cmp(eax, 0x41);                         /* cmp eax, 0x41 */
            ii(0x1018_0eed, 2); if(jld(0x1018_0ef7, 0x8)) goto l_0x1018_0ef7; /* jl 0x10180ef7 */
            ii(0x1018_0eef, 3); cmp(eax, 0x5a);                         /* cmp eax, 0x5a */
            ii(0x1018_0ef2, 2); if(jgd(0x1018_0ef7, 0x3)) goto l_0x1018_0ef7; /* jg 0x10180ef7 */
            ii(0x1018_0ef4, 3); add(eax, 0x20);                         /* add eax, 0x20 */
        l_0x1018_0ef7:
            ii(0x1018_0ef7, 1); retd(); return;                         /* ret */
        }
    }
}
