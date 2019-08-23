using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_98a0-6d387c12")]
        public void /* sys */ Method_1017_98a0()
        {
            ii(0x1017_98a0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_98a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_98a3, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1017_98a6, 5); mov(memd_a32[ds, 0x1020_9db8], eax);    /* mov [0x10209db8], eax */
            ii(0x1017_98ab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_98ad, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_98ae, 1); retd();                                 /* ret */
        }
    }
}
