using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("711a1d64-98db-4cf9-8df2-676e51d7d42b")]
        public void /* sys */ Method_1018_1026()
        {
            ii(0x1018_1026, 1); pushd(edx);                             /* push edx */
            ii(0x1018_1027, 5); mov(edx, 0xff);                         /* mov edx, 0xff */
            ii(0x1018_102c, 5); mov(eax, 0x101b_32d0);                  /* mov eax, 0x101b32d0 */ /* "ABNORMAL TERMINATION\r\n" */
            ii(0x1018_1031, 5); calld(/* sys */ 0x1018_1002, -0x34);    /* call 0x10181002 */
            ii(0x1018_1036, 1); popd(edx);                              /* pop edx */
            ii(0x1018_1037, 1); retd(); return;                         /* ret */
        }
    }
}
