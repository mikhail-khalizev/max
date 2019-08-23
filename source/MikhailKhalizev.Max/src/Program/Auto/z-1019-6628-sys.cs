using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_6628-677dffbb")]
        public void /* sys */ Method_1019_6628()
        {
            ii(0x1019_6628, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_6629, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_662b, 5); calld(/* sys */ 0x1019_6632, 0x2);      /* call 0x10196632 */
            ii(0x1019_6630, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_6631, 1); retd();                                 /* ret */
        }
    }
}
