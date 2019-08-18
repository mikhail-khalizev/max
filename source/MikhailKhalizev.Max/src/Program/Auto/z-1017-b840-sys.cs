using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("485421d7-4ca5-4f2a-9aca-e7bed139af07")]
        public void /* sys */ Method_1017_b840()
        {
            ii(0x1017_b840, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_b841, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b843, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1017_b846, 5); mov(memd_a32[ds, 0x1020_9c8c], eax);    /* mov [0x10209c8c], eax */
            ii(0x1017_b84b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_b84d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b84e, 1); retd(); return;                         /* ret */
        }
    }
}
