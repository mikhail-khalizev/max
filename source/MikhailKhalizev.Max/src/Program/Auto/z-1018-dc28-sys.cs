using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bf707d1b-2089-4b6f-8bff-87792212a495")]
        public void /* sys */ Method_1018_dc28()
        {
            ii(0x1018_dc28, 2); if(jaed_func(0x1018_dc38, 0xe)) return; /* jae 0x1018dc38 */
            ii(0x1018_dc2a, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_dc2f, 1); pushd(eax);                             /* push eax */
            ii(0x1018_dc30, 5); calld(/* sys */ 0x1018_dbb7, -0x7e);    /* call 0x1018dbb7 */
            ii(0x1018_dc35, 1); popd(eax);                              /* pop eax */
            ii(0x1018_dc36, 2); if(jmpd_func(0x1018_dc3a, 0x2)) return; /* jmp 0x1018dc3a */
        }
    }
}
