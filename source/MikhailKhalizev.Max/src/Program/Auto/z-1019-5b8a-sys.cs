using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5b8a-ab948266")]
        public void /* sys */ Method_1019_5b8a()
        {
            ii(0x1019_5b8a, 1); push(edx);                              /* push edx */
            ii(0x1019_5b8b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1019_5b90, 5); mov(eax, StringDefinitions.FloatingPointSupportNotLoaded); /* mov eax, 0x101b3464 */
            ii(0x1019_5b95, 5); call(/* sys */ 0x1018_1002, -0x1_4b98); /* call 0x10181002 */
            ii(0x1019_5b9a, 1); pop(edx);                               /* pop edx */
            ii(0x1019_5b9b, 1); ret();                                  /* ret */
        }
    }
}
