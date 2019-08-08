using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c7fc1926-ee2d-44d1-ac8f-8d9c5035f849")]
        public void /* sys */ Method_1018_d71d()
        {
            ii(0x1018_d71d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_d71e, 1); pushd(edx);                             /* push edx */
            ii(0x1018_d71f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1018_d724, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_d726, 5); calld(Definitions.sys_lseek, -0x1_0594); /* call 0x1017d197 */
            ii(0x1018_d72b, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d72c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_d72d, 1); retd(); return;                         /* ret */
        }
    }
}
