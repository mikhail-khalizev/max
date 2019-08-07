using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c79834f0-0fca-439c-a523-4982826421fd")]
        public void Method_0014_a366()
        {
            ii(0x14_a366, 2); pushfd();                                 /* pushfd */
            ii(0x14_a368, 2); pushd(cs);                                /* o32 push cs */
            ii(0x14_a36a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_a36c, 3); callw(0x14_a7be, 0x44f);                  /* call 0xa7be */
            ii(0x14_a36f, 1); retfw(); return;                          /* retf */
        }
    }
}
