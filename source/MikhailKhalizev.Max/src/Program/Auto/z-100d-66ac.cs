using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_66ac-4904aa8b")]
        public void Method_100d_66ac()
        {
            ii(0x100d_66ac, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_66ae, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_66af, 1); popd(edi);                              /* pop edi */
            ii(0x100d_66b0, 1); popd(esi);                              /* pop esi */
            ii(0x100d_66b1, 3); retd(0x10); return;                     /* ret 0x10 */
        }
    }
}
