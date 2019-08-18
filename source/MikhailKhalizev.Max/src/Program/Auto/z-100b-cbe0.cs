using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_cbe0-69485d42")]
        public void Method_100b_cbe0()
        {
            ii(0x100b_cbe0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_cbe2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_cbe3, 1); popd(edi);                              /* pop edi */
            ii(0x100b_cbe4, 1); popd(esi);                              /* pop esi */
            ii(0x100b_cbe5, 1); popd(edx);                              /* pop edx */
            ii(0x100b_cbe6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_cbe7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_cbe8, 1); retd(); return;                         /* ret */
        }
    }
}
