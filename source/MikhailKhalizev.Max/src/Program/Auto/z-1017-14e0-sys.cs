using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_14e0-80f73707")]
        public void /* sys */ Method_1017_14e0()
        {
            ii(0x1017_14e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_14e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_14e2, 1); pushd(edx);                             /* push edx */
            ii(0x1017_14e3, 5); mov(ebx, 0x1e0);                        /* mov ebx, 0x1e0 */
            ii(0x1017_14e8, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x1017_14ed, 5); mov(eax, 0x101);                        /* mov eax, 0x101 */
            ii(0x1017_14f2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_14f4, 5); calld(/* sys */ 0x1017_1680, 0x187);    /* call 0x10171680 */
            ii(0x1017_14f9, 1); popd(edx);                              /* pop edx */
            ii(0x1017_14fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_14fb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_14fc, 1); retd();                                 /* ret */
        }
    }
}
