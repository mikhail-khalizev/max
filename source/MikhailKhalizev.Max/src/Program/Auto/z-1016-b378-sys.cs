using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("346a50ac-ff4e-4de8-b1ad-94208d76e93f")]
        public void /* sys */ Method_1016_b378()
        {
            ii(0x1016_b378, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_b379, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b37a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_b37c, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1016_b381, 6); mov(memd_a32[ds, 0x101c_fb78], edx);    /* mov [0x101cfb78], edx */
            ii(0x1016_b387, 6); mov(memd_a32[ds, 0x101c_fb6c], ebx);    /* mov [0x101cfb6c], ebx */
            ii(0x1016_b38d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b38e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_b38f, 1); retd(); return;                         /* ret */
        }
    }
}