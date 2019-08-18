using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5f8bfeca-5d8d-495c-80f6-2dc940dc94f7")]
        public void /* sys */ Method_1017_b850()
        {
            ii(0x1017_b850, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_b851, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b853, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1017_b856, 5); mov(memd_a32[ds, 0x101b_e200], eax);    /* mov [0x101be200], eax */
            ii(0x1017_b85b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_b85d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b85e, 1); retd(); return;                         /* ret */
        }
    }
}
