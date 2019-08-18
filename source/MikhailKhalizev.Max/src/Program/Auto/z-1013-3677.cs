using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3677-490214b8")]
        public void Method_1013_3677()
        {
            ii(0x1013_3677, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3679, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_367a, 1); popd(edi);                              /* pop edi */
            ii(0x1013_367b, 1); popd(esi);                              /* pop esi */
            ii(0x1013_367c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_367d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_367e, 1); retd(); return;                         /* ret */
        }
    }
}
