using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c040bf14-bf07-41aa-98da-850b3d286327")]
        public void /* sys */ Method_1019_5b8a()
        {
            ii(0x1019_5b8a, 1); pushd(edx);                             /* push edx */
            ii(0x1019_5b8b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1019_5b90, 5); mov(eax, 0x101b_3464);                  /* mov eax, 0x101b3464 */ /* "Floating-point support not loaded\r\n" */
            ii(0x1019_5b95, 5); calld(/* sys */ 0x1018_1002, -0x14b98); /* call 0x10181002 */
            ii(0x1019_5b9a, 1); popd(edx);                              /* pop edx */
            ii(0x1019_5b9b, 1); retd(); return;                         /* ret */
        }
    }
}