using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5fc5-3883f183")]
        public void Method_1013_5fc5()
        {
            ii(0x1013_5fc5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_5fc7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_5fc8, 1); popd(edi);                              /* pop edi */
            ii(0x1013_5fc9, 1); popd(esi);                              /* pop esi */
            ii(0x1013_5fca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_5fcb, 1); retd(); return;                         /* ret */
        }
    }
}
