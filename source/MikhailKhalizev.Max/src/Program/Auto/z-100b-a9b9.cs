using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_a9b9-69485d42")]
        public void Method_100b_a9b9()
        {
            ii(0x100b_a9b9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a9bb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_a9bc, 1); popd(edi);                              /* pop edi */
            ii(0x100b_a9bd, 1); popd(esi);                              /* pop esi */
            ii(0x100b_a9be, 1); popd(edx);                              /* pop edx */
            ii(0x100b_a9bf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_a9c0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_a9c1, 1); retd(); return;                         /* ret */
        }
    }
}
