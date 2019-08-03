using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("096dd90a-f6ee-48c0-8c24-7d902f4dbd4d")]
        public void /* sys */ Method_1018_0fc8()
        {
            ii(0x1018_0fc8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_0fc9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_0fcb, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1018_0fcd, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1018_0fcf, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1018_0fd0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_0fd1, 1); retd(); return;                         /* ret */
        }
    }
}
