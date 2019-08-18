using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bcbf909d-8477-4380-a1bc-dbb5e2c205a0")]
        public void Method_1009_48ff()
        {
            ii(0x1009_48ff, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_4902, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_4904, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_4905, 1); popd(edi);                              /* pop edi */
            ii(0x1009_4906, 1); popd(esi);                              /* pop esi */
            ii(0x1009_4907, 1); popd(edx);                              /* pop edx */
            ii(0x1009_4908, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_4909, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_490a, 1); retd(); return;                         /* ret */
        }
    }
}
