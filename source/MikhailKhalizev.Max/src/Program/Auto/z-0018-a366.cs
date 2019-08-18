using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3227f0cc-174f-4202-a8d9-9ce5a6105304")]
        public void Method_0018_a366()
        {
            ii(0x18_a366, 2); pushfd();                                 /* pushfd */
            ii(0x18_a368, 2); pushd(cs);                                /* o32 push cs */
            ii(0x18_a36a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_a36c, 3); callw(0x18_a7be, 0x44f);                  /* call 0xa7be */
            ii(0x18_a36f, 1); retfw(); return;                          /* retf */
        }
    }
}
