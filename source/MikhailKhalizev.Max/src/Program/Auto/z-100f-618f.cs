using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_618f-69485d42")]
        public void Method_100f_618f()
        {
            ii(0x100f_618f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_6191, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_6192, 1); popd(edi);                              /* pop edi */
            ii(0x100f_6193, 1); popd(esi);                              /* pop esi */
            ii(0x100f_6194, 1); popd(edx);                              /* pop edx */
            ii(0x100f_6195, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_6196, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_6197, 1); retd(); return;                         /* ret */
        }
    }
}
