using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e1566847-8570-432d-8e0a-9cf0ff7c819d")]
        public void /* sys */ Method_1018_0fd2()
        {
            ii(0x1018_0fd2, 1); pushd(edx);                             /* push edx */
            ii(0x1018_0fd3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_0fd5, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1018_0fd7, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1018_0fd8, 1); popd(edx);                              /* pop edx */
            ii(0x1018_0fd9, 1); retd(); return;                         /* ret */
        }
    }
}
