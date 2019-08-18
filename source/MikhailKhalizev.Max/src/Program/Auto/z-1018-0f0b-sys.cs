using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("309eaeff-5a80-4037-a792-1ae9bc817820")]
        public void /* sys */ Method_1018_0f0b()
        {
            ii(0x1018_0f0b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_0f0c, 1); pushd(esi);                             /* push esi */
            ii(0x1018_0f0d, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_0f0f, 5); mov(ecx, /* sys */ 0x1018_0ef8);        /* mov ecx, 0x10180ef8 */
            ii(0x1018_0f14, 5); calld(/* sys */ 0x1018_10e4, 0x1cb);    /* call 0x101810e4 */
            ii(0x1018_0f19, 4); mov(memb_a32[ds, esi + eax], 0);        /* mov byte [esi+eax], 0x0 */
            ii(0x1018_0f1d, 1); popd(esi);                              /* pop esi */
            ii(0x1018_0f1e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_0f1f, 1); retd(); return;                         /* ret */
        }
    }
}
