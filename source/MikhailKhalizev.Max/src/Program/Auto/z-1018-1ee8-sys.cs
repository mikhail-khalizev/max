using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0e7b77ce-9191-42b7-9ec9-3dc89522fdcb")]
        public void /* sys */ Method_1018_1ee8()
        {
            ii(0x1018_1ee8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_1ee9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_1eeb, 5); calld(/* sys */ 0x1018_1db8, -0x138);   /* call 0x10181db8 */
            ii(0x1018_1ef0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_1ef1, 1); retd(); return;                         /* ret */
        }
    }
}
