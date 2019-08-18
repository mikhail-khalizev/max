using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eefdf652-da9c-4f11-b45f-ce804eefd5d0")]
        public void Method_1008_db55()
        {
            ii(0x1008_db55, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_db57, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_db58, 1); popd(edi);                              /* pop edi */
            ii(0x1008_db59, 1); popd(esi);                              /* pop esi */
            ii(0x1008_db5a, 1); popd(edx);                              /* pop edx */
            ii(0x1008_db5b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_db5c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_db5d, 1); retd(); return;                         /* ret */
        }
    }
}
