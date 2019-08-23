using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_dc28-de0594a6")]
        public void /* sys */ Method_1018_dc28()
        {
            ii(0x1018_dc28, 2); if(jae(0x1018_dc38, 0xe)) goto l_0x1018_dc38; /* jae 0x1018dc38 */
            ii(0x1018_dc2a, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_dc2f, 1); push(eax);                              /* push eax */
            ii(0x1018_dc30, 5); call(/* sys */ 0x1018_dbb7, -0x7e);     /* call 0x1018dbb7 */
            ii(0x1018_dc35, 1); pop(eax);                               /* pop eax */
            ii(0x1018_dc36, 2); jmp(0x1018_dc3a, 0x2); goto l_0x1018_dc3a; /* jmp 0x1018dc3a */
        l_0x1018_dc38:
            ii(0x1018_dc38, 2); sub(eax, eax);                          /* sub eax, eax */
        l_0x1018_dc3a:
            ii(0x1018_dc3a, 1); ret();                                  /* ret */
        }
    }
}
