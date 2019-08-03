using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d519f0f-eaa9-47d9-814f-a6e1b61b1840")]
        public void Method_100e_d760()
        {
            ii(0x100e_d760, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100e_d763, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_d765, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_d766, 1); popd(edi);                              /* pop edi */
            ii(0x100e_d767, 1); popd(esi);                              /* pop esi */
            ii(0x100e_d768, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_d769, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_d76a, 1); retd(); return;                         /* ret */
        }
    }
}
