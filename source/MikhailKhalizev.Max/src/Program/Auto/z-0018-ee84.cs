using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ee84-dceae918")]
        public void Method_0018_ee84()
        {
            ii(0x18_ee84, 3); and(cx, 0x3f);                            /* and cx, 0x3f */
            ii(0x18_ee87, 2); pushd(ebp);                               /* push ebp */
            ii(0x18_ee89, 2); pushd(eax);                               /* push eax */
            ii(0x18_ee8b, 2); mov(bp, ss);                              /* mov bp, ss */
            ii(0x18_ee8d, 4); lar(ebp, bp);                             /* lar ebp, bp */
            ii(0x18_ee91, 4); shr(ebp, 0x17);                           /* shr ebp, 0x17 */
            ii(0x18_ee95, 2); if(jae_func(0x18_ee98, 0x1)) return;      /* jae 0xee98 */
        }
    }
}
