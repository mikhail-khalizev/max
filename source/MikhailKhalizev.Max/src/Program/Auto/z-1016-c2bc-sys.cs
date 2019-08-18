using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("297fa112-375c-4181-8d96-c10a2c58a2b6")]
        public void /* sys */ Method_1016_c2bc()
        {
            ii(0x1016_c2bc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_c2bd, 6); mov(ebx, memd_a32[ds, 0x101c_fbfc]);    /* mov ebx, [0x101cfbfc] */
            ii(0x1016_c2c3, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_c2c5, 5); mov(memd_a32[ds, 0x101c_fbd4], eax);    /* mov [0x101cfbd4], eax */
            ii(0x1016_c2ca, 5); mov(eax, memd_a32[ds, 0x101c_fbf8]);    /* mov eax, [0x101cfbf8] */
            ii(0x1016_c2cf, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_c2d1, 6); mov(memd_a32[ds, 0x101c_fbd0], edx);    /* mov [0x101cfbd0], edx */
            ii(0x1016_c2d7, 5); calld(/* sys */ 0x1016_c2e0, 0x4);      /* call 0x1016c2e0 */
            ii(0x1016_c2dc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c2dd, 1); retd(); return;                         /* ret */
        }
    }
}
