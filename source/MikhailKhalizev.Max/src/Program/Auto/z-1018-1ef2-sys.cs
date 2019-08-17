using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cbe4ee95-38da-4753-8588-8ff37686e494")]
        public void /* sys */ Method_1018_1ef2()
        {
            ii(0x1018_1ef2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1ef4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_1ef5, 1); pushd(edx);                             /* push edx */
            ii(0x1018_1ef6, 6); mov(edx, memd_a32[ds, 0x1020_a1f8]);    /* mov edx, [0x1020a1f8] */
            ii(0x1018_1efc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_1efe, 5); calld(/* sys */ 0x1018_1db8, -0x14b);   /* call 0x10181db8 */
            ii(0x1018_1f03, 1); popd(edx);                              /* pop edx */
            ii(0x1018_1f04, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_1f05, 1); retd(); return;                         /* ret */
        }
    }
}
