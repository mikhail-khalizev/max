using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0fa6f6bf-b810-4f54-808a-9917d5e62d98")]
        public void /* sys */ sys_memset()
        {
            ii(0x1016_5de0, 1); pushd(eax);                             /* push eax */
            ii(0x1016_5de1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_5de2, 2); mov(dh, dl);                            /* mov dh, dl */
            ii(0x1016_5de4, 3); shl(edx, 0x8);                          /* shl edx, 0x8 */
            ii(0x1016_5de7, 2); mov(dl, dh);                            /* mov dl, dh */
            ii(0x1016_5de9, 3); shl(edx, 0x8);                          /* shl edx, 0x8 */
            ii(0x1016_5dec, 2); mov(dl, dh);                            /* mov dl, dh */
            ii(0x1016_5dee, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1016_5df0, 5); calld(/* sys */ 0x1018_1040, 0x1_b24b); /* call 0x10181040 */
            ii(0x1016_5df5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_5df6, 1); popd(eax);                              /* pop eax */
            ii(0x1016_5df7, 1); retd(); return;                         /* ret */
        }
    }
}
