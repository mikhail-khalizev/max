using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_29a7-69485d42")]
        public void Method_1016_29a7()
        {
            ii(0x1016_29a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_29a9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_29aa, 1); popd(edi);                              /* pop edi */
            ii(0x1016_29ab, 1); popd(esi);                              /* pop esi */
            ii(0x1016_29ac, 1); popd(edx);                              /* pop edx */
            ii(0x1016_29ad, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_29ae, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_29af, 1); retd(); return;                         /* ret */
        }
    }
}
