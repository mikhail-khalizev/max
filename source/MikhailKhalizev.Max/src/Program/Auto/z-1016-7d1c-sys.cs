using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7d1c-d2a18a16")]
        public void /* sys */ Method_1016_7d1c()
        {
            ii(0x1016_7d1c, 1); pushd(edx);                             /* push edx */
            ii(0x1016_7d1d, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_7d20, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_7d22, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_7d24, 5); calld(/* sys */ 0x1016_c25c, 0x4533);   /* call 0x1016c25c */
            ii(0x1016_7d29, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_7d2b, 5); calld(/* sys */ 0x1016_7d38, 0x8);      /* call 0x10167d38 */
            ii(0x1016_7d30, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_7d33, 1); popd(edx);                              /* pop edx */
            ii(0x1016_7d34, 1); retd();                                 /* ret */
        }
    }
}
