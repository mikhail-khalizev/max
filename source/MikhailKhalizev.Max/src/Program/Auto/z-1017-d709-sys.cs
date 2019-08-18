using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d709-1511c99")]
        public void /* sys */ Method_1017_d709()
        {
            ii(0x1017_d709, 5); calld(/* sys */ 0x1017_d5a3, -0x16b);   /* call 0x1017d5a3 */
            ii(0x1017_d70e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_d70f, 1); retd(); return;                         /* ret */
        }
    }
}
